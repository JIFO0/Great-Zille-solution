# Sordland/Turn08/A_VPSelection

- **ID konwersacji:** `142`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/142_A_VPSelection.md`
- **Liczba węzłów dialogowych:** 211
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory
- **[38]** Lucian Galade
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Amendment_USP_Gloria_Convinced`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn08_Action_Court_GloriaJustice`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria`
- `GameCondition.Turn08_A_VPSelection`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“You know why you are here.”"** | `[7]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucian Galade**: "“I do.”" |
| `[9]` | **"“So. Vice President Galade. What do you think?”"** | `[7]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Lucian Galade**: ""You already know what I think, ..." |
| `[10]` | **""All right, Lucian. You're one hell of a strategist, but why should I make you VP?""** | `[7]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Lucian Galade**: ""It is precisely in my capacity ..." |
| `[16]` | **"“You're such a valuable strategist. I don't know if I can afford to lose you in th..."** | `[15]` **Lucian Galade**: "“I won't say much beyond that. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: "“As Vice President, my ability t..." |
| `[17]` | **"“I don't know. The public might gossip about your lack of a wife.""** | `[15]` **Lucian Galade**: "“I won't say much beyond that. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucian Galade**: "“Considering where Petr Vectern'..." |
| `[18]` | **"“You wanted Petr's job from day one. How do I know you won't try to have me ousted..."** | `[15]` **Lucian Galade**: "“I won't say much beyond that. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Lucian Galade**: "“Mr. Vectern proved himself unfi..." |
| `[26]` | **"“Why were you not surprised?”"** | `[25]` **Gloria Tory**: "“I must say I was not surprised ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Gloria Tory**: "“One does learn to expect a few ..." |
| `[27]` | **"“You seem confident.”"** | `[25]` **Gloria Tory**: "“I must say I was not surprised ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Gloria Tory**: "“I am, Mr. President.”" |
| `[28]` | **"“So, Gloria, tell me why I should pick you.”"** | `[25]` **Gloria Tory**: "“I must say I was not surprised ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Gloria Tory**: "“To put it simply, what I bring ..." |
| `[34]` | **"“Tell me. What are you getting at?”"** | `[33]` **Gloria Tory**: "“And as you know, I am also the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Gloria Tory**: "“Well...”" |
| `[35]` | **"“Your experience would be a great asset.”"** | `[33]` **Gloria Tory**: "“And as you know, I am also the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Gloria Tory**: "“Experience is always important."" |
| `[36]` | **"“You become the Vice President, and I get the votes from the conservatives.”"** | `[33]` **Gloria Tory**: "“And as you know, I am also the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Gloria Tory**: "“Precisely.”" |
| `[43]` | **"“There is no us, Gloria.”"** | `[42]` **Gloria Tory**: "“This would allow us to pass bil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Gloria Tory**: "“Before outright refusing, I ins..." |
| `[44]` | **"“I will think about it.”"** | `[42]` **Gloria Tory**: "“This would allow us to pass bil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Gloria Tory**: "“I want you to know that I value..." |
| `[45]` | **"“We are already aligned.”"** | `[42]` **Gloria Tory**: "“This would allow us to pass bil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: "“Then that makes things easier, ..." |
| `[54]` | **"“That will be all for now. Thank you.”"** | `[57]` **Gloria Tory**: "“There is much to gain from sele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Gloria Tory**: "“Thank you.”" |
| `[55]` | **"“You are right. There is much to gain. I will consider it.”"** | `[57]` **Gloria Tory**: "“There is much to gain from sele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Gloria Tory**: "“I knew you would see reason.”" |
| `[56]` | **"“I'd rather not align myself with the conservative wing.”"** | `[57]` **Gloria Tory**: "“There is much to gain from sele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Gloria Tory**: "“A shame, then. I had hoped you ..." |
| `[64]` | **"“It certainly is.”"** | `[66]` **Albin Clavin**: ""It's a great honor to have been..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Albin Clavin**: "“I hope to satisfy the requireme..." |
| `[65]` | **"“Let's talk.”"** | `[66]` **Albin Clavin**: ""It's a great honor to have been..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Albin Clavin**: "“As you know, I represent the re..." |
| `[67]` | **"“I will be straightforward. Why should I pick you?”"** | `[66]` **Albin Clavin**: ""It's a great honor to have been..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Albin Clavin**: "“I think you already know the an..."<br>`[68]` **Albin Clavin**: "“As you know, I represent the re..." |
| `[74]` | **"“Very idealistic. I like it.”"** | `[73]` **Albin Clavin**: "“So that Sordland can excel and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Albin Clavin**: "“Thank you.”" |
| `[75]` | **"“I did not ask about your opinions. What can you provide me with?”"** | `[73]` **Albin Clavin**: "“So that Sordland can excel and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Albin Clavin**: "“Very well.”" |
| `[76]` | **"“Nonsense. Sordland thrives on tradition. Striving for modernity will get us nowhe..."** | `[73]` **Albin Clavin**: "“So that Sordland can excel and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Albin Clavin**: "“That is certainly...one opinion..." |
| `[82]` | **"“I agree completely.”"** | `[81]` **Albin Clavin**: "“This will smooth the passage of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Albin Clavin**: "“And now what this country needs..." |
| `[83]` | **"“*If* you join the administration, that is. I don't think that's likely.""** | `[81]` **Albin Clavin**: "“This will smooth the passage of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Albin Clavin**: "“As unlikely as it is, we all mu..." |
| `[84]` | **"“That makes sense.”"** | `[81]` **Albin Clavin**: "“This will smooth the passage of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Albin Clavin**: "“And now what this country needs..." |
| `[93]` | **"“I'm a man of my word.”"** | `[88]` **Albin Clavin**: "“Not that you might have forgott..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Albin Clavin**: "“I always took you for a man of ..." |
| `[94]` | **"“Times have changed.”"** | `[88]` **Albin Clavin**: "“Not that you might have forgott..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Albin Clavin**: "“A promise once given has to be ..." |
| `[95]` | **"“We will see about it.”"** | `[88]` **Albin Clavin**: "“Not that you might have forgott..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Albin Clavin**: "“I trust your judgement.”" |
| `[100]` | **"“Aligning myself with the reformist wing does not seem like the way forward.”"** | `[99]` **Albin Clavin**: "“I trust your judgement.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Albin Clavin**: "“You're quite wrong there -- opp..." |
| `[101]` | **"“Thank you. I will consider what you said.""** | `[99]` **Albin Clavin**: "“I trust your judgement.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Albin Clavin**: "“Thank you, Mr. President.”" |
| `[102]` | **"“This will be all for now. Thank you.”"** | `[99]` **Albin Clavin**: "“I trust your judgement.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Albin Clavin**: "“Thank you, Mr. President.”" |
| `[142]` | **""You being a woman could also prove advantageous.""** | `[50]` **Gloria Tory**: "“You can expect to see the same ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Gloria Tory**: "“Not just any woman. A strong wo..." |
| `[143]` | **""I don't think Sordland's ready for a female vice president.""** | `[50]` **Gloria Tory**: "“You can expect to see the same ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Gloria Tory**: "“I'm not just any woman, Mr. Ray..." |
| `[160]` | **""You blocked my reform proposal, Ms. Tory. Why would I pick you as my VP?""** | `[33]` **Gloria Tory**: "“And as you know, I am also the ..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false` | *Brak zmian stanu* | `[161]` **Gloria Tory**: ""This would be your chance to ma..." |
| `[165]` | **""I simply can't forget that you worked against our constitutional reforms, Ms. Tor..."** | `[42]` **Gloria Tory**: "“This would allow us to pass bil..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false` | *Brak zmian stanu* | `[166]` **Gloria Tory**: ""I understand. But that is polit..." |
| `[167]` | **""I'm not so sure.""** | `[50]` **Gloria Tory**: "“You can expect to see the same ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Gloria Tory**: "“Think about the message it woul..." |
| `[171]` | **""Do you mean like the constitutional proposal where you didn't even say a word whe..."** | `[81]` **Albin Clavin**: "“This will smooth the passage of..." | `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true` | *Brak zmian stanu* | `[172]` **Albin Clavin**: ""Come on, Mr. President. You kne..." |
| `[188]` | **""You tried to block my reform proposal, Ms. Tory. Why would I pick you as my VP?""** | `[33]` **Gloria Tory**: "“And as you know, I am also the ..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`<br>`(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false` | *Brak zmian stanu* | `[161]` **Gloria Tory**: ""This would be your chance to ma..." |
| `[195]` | **""In exchange for your support? You blocked my reform proposal together with Ms. To..."** | `[88]` **Albin Clavin**: "“Not that you might have forgott..." | `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true` | *Brak zmian stanu* | `[197]` **Albin Clavin**: ""Come on, Mr. President. You kne..." |
| `[196]` | **""In exchange for your support? You tried to block my reform proposal together with..."** | `[88]` **Albin Clavin**: "“Not that you might have forgott..." | `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`<br>`(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false` | *Brak zmian stanu* | `[197]` **Albin Clavin**: ""Come on, Mr. President. You kne..." |
| `[200]` | **""I don't think you have a chance, Mr. Clavin.""** | `[99]` **Albin Clavin**: "“I trust your judgement.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Albin Clavin**: "“That is disappointing to hear."" |
| `[205]` | **""And what have you been doing while the party has been obstructing my every move?""** | `[73]` **Albin Clavin**: "“So that Sordland can excel and ..." | `Variable["BaseGame.Faction_USP_Obstructionist"] == true` | *Brak zmian stanu* | `[206]` **Albin Clavin**: "“Mr. President. I've been fighti..." |

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
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordish law dictated that if a Vice President failed to complete his term, new candidates were to be put forward by the members of the cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "It was up to me to decide who would fill Petr's shoes. I wanted to chat with them one on one before making my decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I had just begun to settle at my desk when I heard a knoc..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "After much deliberation, the list had been narrowed down to three. Lucian Galade was the front-runner, followed by Gloria Tory and Albin Clavin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was up to me to decide who would fill Petr's shoes. I ..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I had just begun to settle at my desk when I heard a knock at the door. Lucian entered and perched on the chair across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“You know why you are here.”"*)
  - -> `[9]` (*Player: "“So. Vice President Galade. What do you think?”"*)
  - -> `[10]` (*Player: ""All right, Lucian. You're one hell of a strategist, but ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You know why you are here.”"]** — Mówca: **Player**
> "“You know why you are here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: "“I do.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“So. Vice President Galade. What do you think?”"]** — Mówca: **Player**
> "“So. Vice President Galade. What do you think?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""You already know what I think, Mr. President.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""All right, Lucian. You're one hell of a strategist, but why should I make you VP?""]** — Mówca: **Player**
> ""All right, Lucian. You're one hell of a strategist, but why should I make you VP?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucian Galade: ""It is precisely in my capacity as strategist that I have..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""You already know what I think, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“In my current capacity as chief strategist, I have evalu..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“In my current capacity as chief strategist, I have evalu..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“In my current capacity as chief strategist, I have evaluated the experience and capabilities of your potential vice presidents. Objectively, I am by far the most qualified candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“I would advise you not only to think about our long history together, but also the many crises I have helped shepherd you through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 1"*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“I won't say much beyond that. I believe my work speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“You're such a valuable strategist. I don't know if I can..."*)
  - -> `[17]` (*Player: "“I don't know. The public might gossip about your lack of..."*)
  - -> `[18]` (*Player: "“You wanted Petr's job from day one. How do I know you wo..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“You're such a valuable strategist. I don't know if I can afford to lose you in that capacity.”"]** — Mówca: **Player**
> "“You're such a valuable strategist. I don't know if I can afford to lose you in that capacity.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“As Vice President, my ability to serve you and this admi..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I don't know. The public might gossip about your lack of a wife.""]** — Mówca: **Player**
> "“I don't know. The public might gossip about your lack of a wife.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“Considering where Petr Vectern's proclivities got us, a ..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“You wanted Petr's job from day one. How do I know you won't try to have me ousted next?""]** — Mówca: **Player**
> "“You wanted Petr's job from day one. How do I know you won't try to have me ousted next?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“Mr. Vectern proved himself unfit for the position with h..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Considering where Petr Vectern's proclivities got us, a vice president who's wholly uninterested in matters of the flesh would be a refreshing change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Lucian got up from his chair."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“As Vice President, my ability to serve you and this administration will only increase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Lucian got up from his chair."*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“Mr. Vectern proved himself unfit for the position with his selfish and unprofessional behavior. I am counting on you not to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Lucian got up from his chair."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Lucian got up from his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: ""I expect you will make the right decision.""*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He left my office. Just a minute later, there was another knock at the door and Gloria Tory came in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gloria Tory: "“Mr. President.”"*)

### Węzeł `[24]`
Mówca: **Gloria Tory**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gloria Tory: "“I must say I was not surprised at all when my name was p..."*)

### Węzeł `[25]`
Mówca: **Gloria Tory**
> "“I must say I was not surprised at all when my name was put forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“Why were you not surprised?”"*)
  - -> `[27]` (*Player: "“You seem confident.”"*)
  - -> `[28]` (*Player: "“So, Gloria, tell me why I should pick you.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Why were you not surprised?”"]** — Mówca: **Player**
> "“Why were you not surprised?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Gloria Tory: "“One does learn to expect a few things after spending so ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You seem confident.”"]** — Mówca: **Player**
> "“You seem confident.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Gloria Tory: "“I am, Mr. President.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“So, Gloria, tell me why I should pick you.”"]** — Mówca: **Player**
> "“So, Gloria, tell me why I should pick you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Gloria Tory: "“To put it simply, what I bring to the table is years of ..."*)

### Węzeł `[29]`
Mówca: **Gloria Tory**
> "“I am, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Gloria Tory: "“To put it simply, what I bring to the table is years of ..."*)

### Węzeł `[30]`
Mówca: **Gloria Tory**
> "“One does learn to expect a few things after spending so many years in government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Gloria Tory: "“To put it simply, what I bring to the table is years of ..."*)

### Węzeł `[31]`
Mówca: **Gloria Tory**
> "“To put it simply, what I bring to the table is years of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Gloria Tory: "“I have been a member of the Assembly for almost 20 years..."*)

### Węzeł `[32]`
Mówca: **Gloria Tory**
> "“I have been a member of the Assembly for almost 20 years and I spent 7 years as its Speaker. This alone speaks for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: "“And as you know, I am also the spokesperson of the party..."*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“And as you know, I am also the spokesperson of the party, as well as the leader of the conservative wing. You can see what I am getting at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“Tell me. What are you getting at?”"*)
  - -> `[35]` (*Player: "“Your experience would be a great asset.”"*)
  - -> `[36]` (*Player: "“You become the Vice President, and I get the votes from ..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false &&  BaseGame.Amend..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Tell me. What are you getting at?”"]** — Mówca: **Player**
> "“Tell me. What are you getting at?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gloria Tory: "“Well...”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Your experience would be a great asset.”"]** — Mówca: **Player**
> "“Your experience would be a great asset.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gloria Tory: "“Experience is always important.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“You become the Vice President, and I get the votes from the conservatives.”"]** — Mówca: **Player**
> "“You become the Vice President, and I get the votes from the conservatives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gloria Tory: "“Precisely.”"*)

### Węzeł `[37]`
Mówca: **Gloria Tory**
> "“Precisely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: "“This would allow us to pass bills far more easily. Espec..."*)

### Węzeł `[38]`
Mówca: **Gloria Tory**
> "“Experience is always important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Gloria Tory: "“And so is being able to rally the Assembly's conservativ..."*)

### Węzeł `[39]`
Mówca: **Gloria Tory**
> "“Well...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“I will be blunt. Being the leader of the conservative wi..."*)

### Węzeł `[40]`
Mówca: **Gloria Tory**
> "“And so is being able to rally the Assembly's conservative voters to your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: "“This would allow us to pass bills far more easily. Espec..."*)

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“I will be blunt. Being the leader of the conservative wing means that if I am the Vice President, we would have more votes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: "“This would allow us to pass bills far more easily. Espec..."*)

### Węzeł `[42]`
Mówca: **Gloria Tory**
> "“This would allow us to pass bills far more easily. Especially if those bills are aligned to my bloc's causes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“I will think about it.”"*)
  - -> `[43]` (*Player: "“There is no us, Gloria.”"*)
  - -> `[45]` (*Player: "“We are already aligned.”"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“There is no us, Gloria.”"]** — Mówca: **Player**
> "“There is no us, Gloria.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gloria Tory: "“Before outright refusing, I insist you at least think ab..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gloria Tory: "“I want you to know that I value order over everything el..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We are already aligned.”"]** — Mówca: **Player**
> "“We are already aligned.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: "“Then that makes things easier, doesn't it?""*)

### Węzeł `[46]`
Mówca: **Gloria Tory**
> "“Before outright refusing, I insist you at least think about it. Unifying the party instead of fracturing it would certainly be better for the future of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gloria Tory: "“I want you to know that I value order over everything el..."*)

### Węzeł `[47]`
Mówca: **Gloria Tory**
> "“Then that makes things easier, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gloria Tory: "“I want you to know that I value order over everything el..."*)

### Węzeł `[48]`
Mówca: **Gloria Tory**
> "“I want you to know that I value order over everything else, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gloria Tory: "“Being the Speaker of the Assembly requires principles, n..."*)

### Węzeł `[49]`
Mówca: **Gloria Tory**
> "“Being the Speaker of the Assembly requires principles, nerves like steel and determination to uphold proper conduct.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gloria Tory: "“You can expect to see the same of my vice presidency.""*)

### Węzeł `[50]`
Mówca: **Gloria Tory**
> "“You can expect to see the same of my vice presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""You being a woman could also prove advantageous.""*)
  - -> `[167]` (*Player: ""I'm not so sure.""*)
  - -> `[143]` (*Player: ""I don't think Sordland's ready for a female vice preside..."*)

### Węzeł `[51]`
Mówca: **Gloria Tory**
> "“Not just any woman. A strong woman who was able to protect order in a roomful of unruly men for 7 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gloria Tory: "“Think about the message it would send. The first woman V..."*)

### Węzeł `[52]`
Mówca: **Gloria Tory**
> "“Think about the message it would send. The first woman Vice President of Sordland. No. The first woman Vice President in the whole continent!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Gloria Tory: "“What support you would lose among traditionalists, you w..."*)

### Węzeł `[53]`
Mówca: **Gloria Tory**
> "“What support you would lose among traditionalists, you would gain tenfold among Sordish women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gloria Tory: "“There is much to gain from selecting me, Mr. President. ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“That will be all for now. Thank you.”"]** — Mówca: **Player**
> "“That will be all for now. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Gloria Tory: "“Thank you.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“You are right. There is much to gain. I will consider it.”"]** — Mówca: **Player**
> "“You are right. There is much to gain. I will consider it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gloria Tory: "“I knew you would see reason.”"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“I'd rather not align myself with the conservative wing.”"]** — Mówca: **Player**
> "“I'd rather not align myself with the conservative wing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gloria Tory: "“A shame, then. I had hoped you would see the opportunity..."*)

### Węzeł `[57]`
Mówca: **Gloria Tory**
> "“There is much to gain from selecting me, Mr. President. I believe you will make the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“That will be all for now. Thank you.”"*)
  - -> `[55]` (*Player: "“You are right. There is much to gain. I will consider it.”"*)
  - -> `[56]` (*Player: "“I'd rather not align myself with the conservative wing.”"*)

### Węzeł `[58]`
Mówca: **Gloria Tory**
> "“A shame, then. I had hoped you would see the opportunity. I guess you lack the experience to do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gloria Tory: "“I wish you a nice day, Mr. President.”"*)

### Węzeł `[59]`
Mówca: **Gloria Tory**
> "“I wish you a nice day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Gloria made her way out. A minute later, there was anothe..."*)

### Węzeł `[60]`
Mówca: **Gloria Tory**
> "“I knew you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gloria Tory: "“I wish you a nice day, Mr. President.”"*)

### Węzeł `[61]`
Mówca: **Gloria Tory**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gloria Tory: "“I wish you a nice day, Mr. President.”"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Gloria made her way out. A minute later, there was another knock at the door. This time, it was Albin Clavin's turn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "Jump to: [Clavin talk]"*)

### Węzeł `[63]`
Mówca: **Albin Clavin**
> "“Greetings, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Albin Clavin: ""It's a great honor to have been chosen as a candidate. R..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“It certainly is.”"]** — Mówca: **Player**
> "“It certainly is.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Albin Clavin: "“I hope to satisfy the requirements of this sacred positi..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Let's talk.”"]** — Mówca: **Player**
> "“Let's talk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Albin Clavin: "“As you know, I represent the reformist wing of the party.”"*)

### Węzeł `[66]`
Mówca: **Albin Clavin**
> ""It's a great honor to have been chosen as a candidate. Really terrific.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“Let's talk.”"*)
  - -> `[67]` (*Player: "“I will be straightforward. Why should I pick you?”"*)
  - -> `[64]` (*Player: "“It certainly is.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I will be straightforward. Why should I pick you?”"]** — Mówca: **Player**
> "“I will be straightforward. Why should I pick you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == true"*)

### Węzeł `[68]`
Mówca: **Albin Clavin**
> "“As you know, I represent the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Albin Clavin: "“What Sordland needs today is not only to catch up to our..."*)

### Węzeł `[69]`
Mówca: **Albin Clavin**
> "“I hope to satisfy the requirements of this sacred position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Albin Clavin: "“As you know, I represent the reformist wing of the party.”"*)

### Węzeł `[70]`
Mówca: **Albin Clavin**
> "“What Sordland needs today is not only to catch up to our more modern neighbors, but to surpass them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Albin Clavin: "“I believe we can do that. No. I am sure!”"*)

### Węzeł `[71]`
Mówca: **Albin Clavin**
> "“I believe we can do that. No. I am sure!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Albin Clavin: "“However, this will only be possible if we set aside our ..."*)

### Węzeł `[72]`
Mówca: **Albin Clavin**
> "“However, this will only be possible if we set aside our differences and unite as one. That is the outlook I wish to bring to the position of Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Albin Clavin: "“So that Sordland can excel and soar to new heights.”"*)

### Węzeł `[73]`
Mówca: **Albin Clavin**
> "“So that Sordland can excel and soar to new heights.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“I did not ask about your opinions. What can you provide ..."*)
  - -> `[74]` (*Player: "“Very idealistic. I like it.”"*)
  - -> `[76]` (*Player: "“Nonsense. Sordland thrives on tradition. Striving for mo..."*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Very idealistic. I like it.”"]** — Mówca: **Player**
> "“Very idealistic. I like it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Albin Clavin: "“Thank you.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I did not ask about your opinions. What can you provide me with?”"]** — Mówca: **Player**
> "“I did not ask about your opinions. What can you provide me with?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Albin Clavin: "“Very well.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Nonsense. Sordland thrives on tradition. Striving for modernity will get us nowhere.""]** — Mówca: **Player**
> "“Nonsense. Sordland thrives on tradition. Striving for modernity will get us nowhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Albin Clavin: "“That is certainly...one opinion, yes.”"*)

### Węzeł `[77]`
Mówca: **Albin Clavin**
> "“That is certainly...one opinion, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Albin Clavin: "“The fact is, if I am the Vice President, reformist membe..."*)

### Węzeł `[78]`
Mówca: **Albin Clavin**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Albin Clavin: "“The fact is, if I am the Vice President, reformist membe..."*)

### Węzeł `[79]`
Mówca: **Albin Clavin**
> "“The fact is, if I am the Vice President, reformist members of our party will be more likely to support you and your causes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Albin Clavin: "“This will smooth the passage of bills and help move our ..."*)

### Węzeł `[80]`
Mówca: **Albin Clavin**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Albin Clavin: "“The fact is, if I am the Vice President, reformist membe..."*)

### Węzeł `[81]`
Mówca: **Albin Clavin**
> "“This will smooth the passage of bills and help move our administration and our country forward in record time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“That makes sense.”"*)
  - -> `[83]` (*Player: "“*If* you join the administration, that is. I don't think..."*)
  - -> `[82]` (*Player: "“I agree completely.”"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I agree completely.”"]** — Mówca: **Player**
> "“I agree completely.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Albin Clavin: "“And now what this country needs is more dynamic, youthfu..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“*If* you join the administration, that is. I don't think that's likely.""]** — Mówca: **Player**
> "“*If* you join the administration, that is. I don't think that's likely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Albin Clavin: "“As unlikely as it is, we all must try.”"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“That makes sense.”"]** — Mówca: **Player**
> "“That makes sense.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Albin Clavin: "“And now what this country needs is more dynamic, youthfu..."*)

### Węzeł `[85]`
Mówca: **Albin Clavin**
> "“As unlikely as it is, we all must try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Albin Clavin: "“And now what this country needs is more dynamic, youthfu..."*)

### Węzeł `[86]`
Mówca: **Albin Clavin**
> "“And now what this country needs is more dynamic, youthful leadership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Albin Clavin: "“Look at you, President Rayne. You became the youngest me..."*)

### Węzeł `[87]`
Mówca: **Albin Clavin**
> "“Look at you, President Rayne. You became the youngest member of the Assembly and completely rejuvenated Sordish politics. I want to do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Albin Clavin: "“We need to be able to take risks to make gains and that ..."*)

### Węzeł `[88]`
Mówca: **Albin Clavin**
> "“Not that you might have forgotten, but I would also like to remind you that you promised me a position in exchange for my support at the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_USP_Gloria_Convinced == false && BaseG..."*)
  - -> `[93]` (*Player: "“I'm a man of my word.”"*)
  - -> `[94]` (*Player: "“Times have changed.”"*)
  - -> `[95]` (*Player: "“We will see about it.”"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Albin_PromisedVP == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Albin Clavin: "“Not that you might have forgotten, but I would also like..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Albin_PromisedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Albin Clavin: "“There. I've stated my case.”"*)

### Węzeł `[92]`
Mówca: **Albin Clavin**
> "“There. I've stated my case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“I trust your judgement.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I'm a man of my word.”"]** — Mówca: **Player**
> "“I'm a man of my word.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Albin Clavin: "“I always took you for a man of honor.”"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Times have changed.”"]** — Mówca: **Player**
> "“Times have changed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Albin Clavin: "“A promise once given has to be kept, Mr. President. It w..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“We will see about it.”"]** — Mówca: **Player**
> "“We will see about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“I trust your judgement.”"*)

### Węzeł `[96]`
Mówca: **Albin Clavin**
> "“I always took you for a man of honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“I trust your judgement.”"*)

### Węzeł `[97]`
Mówca: **Albin Clavin**
> "“We need to be able to take risks to make gains and that is only possible with a forward-looking perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == true"*)

### Węzeł `[98]`
Mówca: **Albin Clavin**
> "“A promise once given has to be kept, Mr. President. It would be foolish to go back on your word at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“I trust your judgement.”"*)

### Węzeł `[99]`
Mówca: **Albin Clavin**
> "“I trust your judgement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“This will be all for now. Thank you.”"*)
  - -> `[101]` (*Player: "“Thank you. I will consider what you said.""*)
  - -> `[100]` (*Player: "“Aligning myself with the reformist wing does not seem li..."*)
  - -> `[200]` (*Player: ""I don't think you have a chance, Mr. Clavin.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Aligning myself with the reformist wing does not seem like the way forward.”"]** — Mówca: **Player**
> ""Aligning myself with the reformist wing does not seem like the way forward.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Albin Clavin: "“You're quite wrong there -- opposing our views will send..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Thank you. I will consider what you said.""]** — Mówca: **Player**
> "“Thank you. I will consider what you said.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Albin Clavin: "“Thank you, Mr. President.”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“This will be all for now. Thank you.”"]** — Mówca: **Player**
> "“This will be all for now. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Albin Clavin: "“Thank you, Mr. President.”"*)

### Węzeł `[103]`
Mówca: **Albin Clavin**
> "“You're quite wrong there -- opposing our views will send Sordland backwards. I thought you would understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Albin got up and left."*)

### Węzeł `[104]`
Mówca: **Albin Clavin**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Albin got up and left."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Albin got up and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "I leaned back in my chair, thinking about the pros and co..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "I leaned back in my chair, thinking about the pros and cons of each of my vice presidential candidates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I could almost hear Petr's voice in my head, laughing at ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_VPSelection = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_VPSelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I could almost hear Petr's voice in my head, laughing at the absurdity of my situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "But of course, he wasn't there."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "But of course, he wasn't there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true || Ba..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Petr == true || ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "It was here: the day I'd been dreading since Petr's impri..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "It was here: the day I'd been dreading since Petr's resig..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Petr == true || Ba..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's resignation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "At the entrance to my office, my new secretary Sylvia too..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's imprisonment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "At the entrance to my office, my new secretary Sylvia too..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "At the entrance to my office, my new secretary Sylvia too..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "At the entrance to my office, my new secretary Sylvia took my hat and coat. She was a matronly woman in her forties. She had a spotless background assisting various Maroon Palace officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Replacing Livia had been easy. But replacing my Vice Pres..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Replacing Livia had been easy. But replacing my Vice President would be difficult."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Sordish law dictated that if a Vice President failed to c..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "After much deliberation, the list had been narrowed down ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "After much deliberation, the list had been narrowed down to two. Lucian Galade was the front-runner; Albin Clavin the second choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was up to me to decide who would fill Petr's shoes. I ..."*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""I expect you will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He left my office. Just a minute later, there was another..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucian Galade: ""Gloria Tory would be the only other suitable possibility..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“I would advise you not only to think about our long hist..."*)

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""Gloria Tory would be the only other suitable possibility, were she not already committed to her position on the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“I would advise you not only to think about our long hist..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Clavin talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Clavin talk"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Clavin talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Albin Clavin: "“Greetings, Mr. President.”"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Clavin talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "Clavin talk"*)

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""It is precisely in my capacity as strategist that I have evaluated the experience and capabilities of your potential vice presidents. Objectively, I am by far the most qualified candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion < 1"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Opinion < 1)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: ""Even when we have not seen eye to eye, you must admit th..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Opinion < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“I won't say much beyond that. I believe my work speaks f..."*)

### Węzeł `[140]`
Mówca: **Lucian Galade**
> ""Even when we have not seen eye to eye, you must admit that my instincts have been unfailingly correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“I won't say much beyond that. I believe my work speaks f..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He left my office. Just a minute later, there was another knock at the door and Albin Clavin came in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "Jump to: [Clavin talk]"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""You being a woman could also prove advantageous.""]** — Mówca: **Player**
> ""You being a woman could also prove advantageous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Gloria Tory: "“Not just any woman. A strong woman who was able to prote..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I don't think Sordland's ready for a female vice president.""]** — Mówca: **Player**
> ""I don't think Sordland's ready for a female vice president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Gloria Tory: "“I'm not just any woman, Mr. Rayne. I was able to protect..."*)

### Węzeł `[144]`
Mówca: **Gloria Tory**
> "“I'm not just any woman, Mr. Rayne. I was able to protect order in a roomful of unruly men for 7 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Gloria Tory: "“And think about the message it would send. The first wom..."*)

### Węzeł `[145]`
Mówca: **Gloria Tory**
> "“And think about the message it would send. The first woman Vice President in the whole continent! What support you would lose among traditionalists, you would gain tenfold among Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gloria Tory: "“There is much to gain from selecting me, Mr. President. ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_VPSelection = true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_VPSelection = true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "It was here: the day I'd been dreading since Petr's death."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "At the entrance to my office, my new secretary Sylvia too..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Albin_PromisedVP == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Albin Clavin: "“I think you already know the answer...”"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Albin_PromisedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Albin Clavin: "“As you know, I represent the reformist wing of the party.”"*)

### Węzeł `[156]`
Mówca: **Albin Clavin**
> "“I think you already know the answer...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Albin Clavin: "“As you know, I represent the reformist wing of the party.”"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false &&  BaseGame.Amend..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false &&  BaseGame.Ame..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""You blocked my reform proposal, Ms. Tory. Why would I pi..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendm..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You blocked my reform proposal, Ms. Tory. Why would I pick you as my VP?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Gloria Tory: ""This would be your chance to make amends with the party,..."*)

### Węzeł `[161]`
Mówca: **Gloria Tory**
> ""This would be your chance to make amends with the party, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“I will be blunt. Being the leader of the conservative wi..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Refo..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: ""I simply can't forget that you worked against our consti..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I simply can't forget that you worked against our constitutional reforms, Ms. Tory. I don't think we are aligned.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gloria Tory: ""I understand. But that is politics, Mr. President.""*)

### Węzeł `[166]`
Mówca: **Gloria Tory**
> ""I understand. But that is politics, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gloria Tory: "“Before outright refusing, I insist you at least think ab..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not so sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gloria Tory: "“Think about the message it would send. The first woman V..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Do you mean like the constitutional proposal where you d..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you mean like the constitutional proposal where you didn't even say a word when Ms. Tory confronted me?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Kontekst wejściowy (poprzednik):** `[81]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Albin Clavin: ""Come on, Mr. President. You knew my position there. Ther..."*)

### Węzeł `[172]`
Mówca: **Albin Clavin**
> ""Come on, Mr. President. You knew my position there. There was nothing I could do to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[173]`
Mówca: **Albin Clavin**
> ""But I believe we can achieve great things together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Albin Clavin: "“And now what this country needs is more dynamic, youthfu..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Albin Clavin: ""Besides, it all worked out great in the end, didn't it? ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Albin Clavin: ""But I believe we can achieve great things together.""*)

### Węzeł `[177]`
Mówca: **Albin Clavin**
> ""Besides, it all worked out great in the end, didn't it? We have successfully changed the constitution. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Albin Clavin: "“And now what this country needs is more dynamic, youthfu..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "After much deliberation, the list had been narrowed down ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "After much deliberation, the list had been narrowed down ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He left my office. Just a minute later, there was another..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He left my office. Just a minute later, there was another..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendm..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Amen..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""You tried to block my reform proposal, Ms. Tory. Why wou..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You tried to block my reform proposal, Ms. Tory. Why would I pick you as my VP?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false` AND `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Gloria Tory: ""This would be your chance to make amends with the party,..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_USP_Gloria_Convinced == false && BaseG..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Amendment_USP_Gloria_Convinced == false && Bas..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""In exchange for your support? You blocked my reform prop..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_USP_Gloria_Convinced == false && BaseG..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_USP_Gloria_Convinced == false && BaseG..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Amendment_USP_Gloria_Convinced == false && Bas..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""In exchange for your support? You tried to block my refo..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In exchange for your support? You blocked my reform proposal together with Ms. Tory. What promise are you talking about?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Kontekst wejściowy (poprzednik):** `[88]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Albin Clavin: ""Come on, Mr. President. You knew there wasn't anything I..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In exchange for your support? You tried to block my reform proposal together with Ms. Tory. What promise are you talking about?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true` AND `(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[88]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Albin Clavin: ""Come on, Mr. President. You knew there wasn't anything I..."*)

### Węzeł `[197]`
Mówca: **Albin Clavin**
> ""Come on, Mr. President. You knew there wasn't anything I could do then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Albin Clavin: ""My efforts may not have been enough, but that doesn't me..."*)

### Węzeł `[198]`
Mówca: **Albin Clavin**
> ""My efforts may not have been enough, but that doesn't mean I did not vote for your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Albin Clavin: ""And I still believe we can work together.""*)

### Węzeł `[199]`
Mówca: **Albin Clavin**
> ""And I still believe we can work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“I trust your judgement.”"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think you have a chance, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Albin Clavin: "“That is disappointing to hear.""*)

### Węzeł `[201]`
Mówca: **Albin Clavin**
> "“That is disappointing to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Albin got up and left."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""And what have you been doing while the party has been ob..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what have you been doing while the party has been obstructing my every move?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Kontekst wejściowy (poprzednik):** `[73]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Albin Clavin: "“Mr. President. I've been fighting my own fight against t..."*)

### Węzeł `[206]`
Mówca: **Albin Clavin**
> "“Mr. President. I've been fighting my own fight against the establishment within the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Albin Clavin: ""The USP reformists aren't really a part of that.""*)

### Węzeł `[207]`
Mówca: **Albin Clavin**
> ""The USP reformists aren't really a part of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Albin Clavin: "“The fact is, if I am the Vice President, reformist membe..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_VPSelection = true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria = ..."*)
