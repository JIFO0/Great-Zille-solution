# Sordland/Turn07/VoteWon

- **ID konwersacji:** `96`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/096_VoteWon.md`
- **Liczba węzłów dialogowych:** 186
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Assembly_Vote`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[94] Sordland/Turn07/A_AssemblyVote_ResultsMeeting** (../Turn_07/094_A_AssemblyVote_ResultsMeeting.md), Węzeł `[9]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""That's a good start. If she's willing to talk, she's willing to cooperate.""** | `[57]` **Petr Vectern**: ""She's willing to speak with you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Petr Vectern**: ""I'm sure you'll convince her."" |
| `[13]` | **""Well, she could probably pass as one...""** | `[39]` **Lucian Galade**: ""Also... You are forgetting abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "Petr started laughing." |
| `[32]` | **""It's going to be tough.""** | `[75]` **Lucian Galade**: ""We'll still need to reach out t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: ""Indeed. But then again, so was ..." |
| `[33]` | **""If the Old Guard is against us... How do we even get six votes?""** | `[75]` **Lucian Galade**: ""We'll still need to reach out t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Lucian Galade**: ""By convincing all of the other ..." |
| `[34]` | **""If the Justices fail us at this stage, I'm sure the people will see them for who ..."** | `[29]` **Lucian Galade**: ""But this may also make the Cour..."<br>`[31]` **Lucian Galade**: ""The Court still sees us as a th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""I wouldn't be so sure, sir. The..." |
| `[35]` | **""Don't worry. I'll talk to the Justices and convince them.""** | `[29]` **Lucian Galade**: ""But this may also make the Cour..."<br>`[31]` **Lucian Galade**: ""The Court still sees us as a th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""I believe in you, sir."" |
| `[36]` | **""We never expected this to be easy. Nothing has changed.""** | `[29]` **Lucian Galade**: ""But this may also make the Cour..."<br>`[31]` **Lucian Galade**: ""The Court still sees us as a th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucian Galade**: ""That's true, sir."" |
| `[37]` | **""Do you think we can do it?""** | `[75]` **Lucian Galade**: ""We'll still need to reach out t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: ""We've come this far. Anything i..." |
| `[59]` | **""How about Heron Garaci?""** | `[57]` **Petr Vectern**: ""She's willing to speak with you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Petr Vectern**: ""He refused to speak with us."" |
| `[60]` | **""Good. I'll make sure she joins us. Just watch.""** | `[57]` **Petr Vectern**: ""She's willing to speak with you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Petr Vectern**: ""I'm sure you'll convince her."" |
| `[61]` | **""Come on, gentlemen, let's not overthink this.""** | `[39]` **Lucian Galade**: ""Also... You are forgetting abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Petr Vectern**: ""Yeah..."" |
| `[63]` | **""The real trouble is their big daddy Hawker. We can't let him control the Court ag..."** | `[39]` **Lucian Galade**: ""Also... You are forgetting abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Lucian Galade**: ""We surely cannot. We'll need to..." |
| `[65]` | **""...And Mrs. Morgna. She's technically a member too.""** | `[39]` **Lucian Galade**: ""Also... You are forgetting abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Petr Vectern**: ""Wait. Did you just call Nia a g..." |
| `[74]` | **""It's fine. We can do it together. I trust Nia.""** | `[95]` **Petr Vectern**: ""And we already have Nia inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""Let's not over-assume, Petr. Mr..."<br>`[64]` **Lucian Galade**: ""I'm not trying to be pessimisti..." |
| `[78]` | **""So, she's serious about voting against the proposal?""** | `[40]` **Petr Vectern**: ""And Nia was pretty adamant abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Petr Vectern**: ""I'm afraid she is. I knew she w..." |
| `[79]` | **""I can't let her sabotage our efforts. She's a minister of my cabinet, she *will* ..."** | `[40]` **Petr Vectern**: ""And Nia was pretty adamant abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Petr Vectern**: ""I don't know about that, Anton...." |
| `[81]` | **""It's going to be tough.""** | `[94]` **Lucian Galade**: ""Yes. We'll need to reach out to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lucian Galade**: ""Indeed. But then again, so was ..." |
| `[82]` | **""It's fine. We can do it without her.""** | `[40]` **Petr Vectern**: ""And Nia was pretty adamant abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: ""Not to make it sound more depre..." |
| `[88]` | **""If the reformist justices are against us along with the Old Guard... How do we ev..."** | `[94]` **Lucian Galade**: ""Yes. We'll need to reach out to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""It's a tough spot to be in. As ..." |
| `[89]` | **""Do you think we can do it?""** | `[94]` **Lucian Galade**: ""Yes. We'll need to reach out to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lucian Galade**: ""We've come this far. Anything i..." |
| `[91]` | **""Hasn't she managed to lobby anyone else?""** | `[95]` **Petr Vectern**: ""And we already have Nia inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Petr Vectern**: ""She has the ears of Justices Da..." |
| `[99]` | **""Which leaves us five more...""** | `[95]` **Petr Vectern**: ""And we already have Nia inside ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Petr Vectern**: ""Well, Nia has the ears of Justi..." |
| `[100]` | **""Can we even trust her to bring the other Justices to the table?""** | `[40]` **Petr Vectern**: ""And Nia was pretty adamant abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Petr Vectern**: ""I don't know, but she promised ..." |
| `[103]` | **""Thank you again for your hard work, Petr.""** | `[25]` **Petr Vectern**: ""Fellas! The first obstacle has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Petr Vectern**: ""It was nothing, Anton. It was m..." |
| `[104]` | **""We can celebrate once we get past the Court.""** | `[25]` **Petr Vectern**: ""Fellas! The first obstacle has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Lucian Galade**: ""The president's right. The Asse..." |
| `[105]` | **""Great job, gentlemen!""** | `[25]` **Petr Vectern**: ""Fellas! The first obstacle has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "Petr leaned on the balcony railing." |
| `[114]` | **""He saw their faces, but didn't recognize them.""** | `[123]` **Petr Vectern**: ""Oh, he did? Who were they?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Petr Vectern**: ""That's too bad."" |
| `[115]` | **""Let's not name any names now.""** | `[123]` **Petr Vectern**: ""Oh, he did? Who were they?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Petr Vectern**: ""Okay..."" |
| `[117]` | **""Let's just move on with our next steps.""** | `[145]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Lucian Galade**: ""Of course, sir."" |
| `[118]` | **""Maybe you should have. Even Serge knew about it.""** | `[164]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Petr Vectern**: ""How did Serge know, anyway?"" |
| `[119]` | **""What's done is done. Let's not linger in the past.""** | `[164]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Lucian Galade**: ""You're right, sir. We must plan..." |
| `[122]` | **""He came to the Assembly to make a statement. But we still won the vote.""** | `[116]` **Petr Vectern**: ""What the hell was that all abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucian Galade**: ""I'm sorry that we failed to war..." |
| `[126]` | **""No, he didn't.""** | `[132]` **Petr Vectern**: ""He didn't see who they were, di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Petr Vectern**: ""That's too bad."" |
| `[127]` | **""Yes, he did.""** | `[132]` **Petr Vectern**: ""He didn't see who they were, di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Petr Vectern**: ""Oh, he did? Who were they?"" |
| `[130]` | **""What do you think was his real intention?""** | `[116]` **Petr Vectern**: ""What the hell was that all abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucian Galade**: ""He wished to intimidate the Ass..." |
| `[139]` | **""It doesn't matter now, does it?""** | `[132]` **Petr Vectern**: ""He didn't see who they were, di..."<br>`[152]` **Petr Vectern**: ""How did Serge know, anyway?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Petr Vectern**: ""I guess not."" |
| `[143]` | **""He said he overheard some people talking about it around the Assembly.""** | `[152]` **Petr Vectern**: ""How did Serge know, anyway?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Lucian Galade**: ""It seems some of our respected ..." |
| `[144]` | **""I hope you are not hiding anything from me.""** | `[152]` **Petr Vectern**: ""How did Serge know, anyway?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Petr Vectern**: ""What? Me? Never!"" |
| `[149]` | **""I learned it from Serge. How come MY DRIVER knows more than YOU!?""** | `[154]` **Petr Vectern**: ""What Lucian said. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[150]` | **""He is not a threat to us. We should focus on our tasks at hand.""** | `[116]` **Petr Vectern**: ""What the hell was that all abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Lucian Galade**: ""You're right, sir. We must plan..." |
| `[151]` | **""It's all good.""** | `[154]` **Petr Vectern**: ""What Lucian said. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[153]` | **""That wasn't your fault.""** | `[154]` **Petr Vectern**: ""What Lucian said. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[155]` | **""He just joined a constitutional vote. I think it's perfectly normal that he'd com..."** | `[116]` **Petr Vectern**: ""What the hell was that all abou..."<br>`[148]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Lucian Galade**: ""You're right, sir. But as long ..." |
| `[156]` | **""It's not that important. He didn't do anything.""** | `[164]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucian Galade**: ""Still, sir, we should have been..." |
| `[157]` | **""I just still can't believe I didn't know he was coming.""** | `[138]` **Lucian Galade**: ""We cannot let the party slip fr..."<br>`[145]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucian Galade**: ""I'm sorry that we failed to war..." |
| `[158]` | **""We should organize a cabinet meeting to discuss the situation.""** | `[138]` **Lucian Galade**: ""We cannot let the party slip fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Lucian Galade**: ""Of course, sir. I'll make the n..." |
| `[159]` | **""Exactly. We must plan our next steps.""** | `[138]` **Lucian Galade**: ""We cannot let the party slip fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Lucian Galade**: ""Of course, sir."" |
| `[160]` | **""Just try to reach out to him.""** | `[145]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Lucian Galade**: ""I'll do my best, sir. Let's now..." |
| `[166]` | **""I want to talk to him. Are you sure he's still in Holsord?""** | `[148]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Lucian Galade**: ""That's what my sources say, sir..." |
| `[167]` | **""Lucian's right. He already showcased his powers at the vote. We must be careful.""** | `[148]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Lucian Galade**: ""Indeed."" |
| `[172]` | **""Are you saying he still has more authority than me?""** | `[148]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Lucian Galade**: ""No, sir. But he certainly has e..." |

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
  - -> `[8]` (*Narrator: "Lucian, Petr and I convened on the massive balcony of the..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: ""We barely squeaked by with the Assembly. It was a tough ..."*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""That's a good start. If she's willing to talk, she's willing to cooperate.""]** — Mówca: **Player**
> ""That's a good start. If she's willing to talk, she's willing to cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""I'm sure you'll convince her.""*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 20"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote >= 20)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Petr Vectern: ""I'm sure the Assembly vote must count for something... I..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote >= 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote > 16"*)

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""I'm sure the Assembly vote must count for something... I mean, it passed by ninety percent, for God's sake!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""They wouldn't dare reject such a popular proposal.""*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucian, Petr and I convened on the massive balcony of the palace. It was nice to catch a breeze in the increasing summer heat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Both had grins on their faces, but Petr's got larger as h..."*)

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""We barely squeaked by with the Assembly. It was a tough win...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: ""The Old Guard won't have any trouble justifying a reject..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""We may need to take some extreme measures, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 20"*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""If we cannot get Mrs. Edmond's centrists, we will have no choice but to reach out to the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 20"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Lucian looked at both of us with a raised eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""Anyway...""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Well, she could probably pass as one...""]** — Mówca: **Player**
> ""Well, she could probably pass as one...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Petr started laughing."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote > 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote > 16"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote > 16)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote > 16`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] > 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote > 16)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] > 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: ""We barely squeaked by with the Assembly. It was a tough ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Both had grins on their faces, but Petr's got larger as he kept recounting our success in the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""Fellas! The first obstacle has been cleared! Congratulat..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Hey, we won the vote comfortably. I'm sure that counts for something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""There is at least some pressure on the Court now.""*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""He refused to speak with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""He refused to speak with you, Petr. But if the president..."*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""They wouldn't dare reject such a popular proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""It was indeed a historic vote. The President has accompl..."*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""By convincing all of the other Justices. Every single one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""If we cannot get Mrs. Edmond's centrists, we will have n..."*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""There is at least some pressure on the Court now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == false"*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""...Now we have the council of grumpy old men in our way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""I have to say, that's a fitting description for the Cour..."*)

### Węzeł `[24]`
Mówca: **Petr Vectern**
> ""The Old Guard won't have any trouble justifying a rejection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == false"*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Fellas! The first obstacle has been cleared! Congratulations to all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""Great job, gentlemen!""*)
  - -> `[104]` (*Player: ""We can celebrate once we get past the Court.""*)
  - -> `[103]` (*Player: ""Thank you again for your hard work, Petr.""*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""We've come this far. Anything is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""If we cannot get Mrs. Edmond's centrists, we will have n..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""It was indeed a historic vote. The President has accomplished something even Tarquin Soll had trouble with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""But this may also make the Court see you as the ultimate..."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have to say, that's a fitting description for the Court. But unfortunately for us, they are more than that. They're our largest obstacle yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""Also... You are forgetting about Mrs. Edmonds. They're n..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""But this may also make the Court see you as the ultimate threat. I wouldn't be so relaxed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""We never expected this to be easy. Nothing has changed.""*)
  - -> `[35]` (*Player: ""Don't worry. I'll talk to the Justices and convince them.""*)
  - -> `[34]` (*Player: ""If the Justices fail us at this stage, I'm sure the peop..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Indeed. But then again, so was securing the Assembly vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""If we cannot get Mrs. Edmond's centrists, we will have n..."*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""The Court still sees us as a threat. They will not be persuaded so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""We never expected this to be easy. Nothing has changed.""*)
  - -> `[35]` (*Player: ""Don't worry. I'll talk to the Justices and convince them.""*)
  - -> `[34]` (*Player: ""If the Justices fail us at this stage, I'm sure the peop..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""It's going to be tough.""]** — Mówca: **Player**
> ""It's going to be tough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""Indeed. But then again, so was securing the Assembly vote.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""If the Old Guard is against us... How do we even get six votes?""]** — Mówca: **Player**
> ""If the Old Guard is against us... How do we even get six votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: ""By convincing all of the other Justices. Every single one.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""If the Justices fail us at this stage, I'm sure the people will see them for who they really are.""]** — Mówca: **Player**
> ""If the Justices fail us at this stage, I'm sure the people will see them for who they really are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[31]` (Lucian Galade), `[185]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""I wouldn't be so sure, sir. They control more than the C..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Don't worry. I'll talk to the Justices and convince them.""]** — Mówca: **Player**
> ""Don't worry. I'll talk to the Justices and convince them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[31]` (Lucian Galade), `[185]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""I believe in you, sir.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""We never expected this to be easy. Nothing has changed.""]** — Mówca: **Player**
> ""We never expected this to be easy. Nothing has changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[31]` (Lucian Galade), `[185]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""That's true, sir.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Do you think we can do it?""]** — Mówca: **Player**
> ""Do you think we can do it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: ""We've come this far. Anything is possible.""*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""She's a tough woman. I doubt that she'll be persuaded at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""Also, even if she was with us, that wouldn't change the ..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Also... You are forgetting about Mrs. Edmonds. They're not all grumpy old men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""...And Mrs. Morgna. She's technically a member too.""*)
  - -> `[63]` (*Player: ""The real trouble is their big daddy Hawker. We can't let..."*)
  - -> `[13]` (*Player: ""Well, she could probably pass as one...""*)
  - -> `[61]` (*Player: ""Come on, gentlemen, let's not overthink this.""*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""And Nia was pretty adamant about her position against the proposal. That's already one vote lost out of eleven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: ""So, she's serious about voting against the proposal?""*)
  - -> `[79]` (*Player: ""I can't let her sabotage our efforts. She's a minister o..."*)
  - -> `[82]` (*Player: ""It's fine. We can do it without her.""*)
  - -> `[100]` (*Player: ""Can we even trust her to bring the other Justices to the..."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna has been helping out with the lobbying of the Court. She has been speaking with Mrs. Edmonds, and we believe she's our key figure on the inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""Our lobbying efforts are continuing positively, but they..."*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""Yeah...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""With all due respect, sir, this is the most crucial step..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I wouldn't be so sure, sir. They control more than the Court, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""And the average citizen has no interest in such matters...."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""So... That gives us three votes to start with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""And the average citizen has no interest in such matters. The public won't be very helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""In any case, we should start with our best bet. I alread..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""We've come this far. Anything is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""We may need to take some extreme measures, though.""*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""That's true, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""In any case, we should start with our best bet. I alread..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Petr started laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Petr Vectern: ""Ouch.""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""I believe in you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""In any case, we should start with our best bet. I alread..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""Let's not over-assume, Petr. Mrs. Morgna has already mad..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""I'm not trying to be pessimistic, but Mrs. Morgna cannot..."*)

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""In any case, we should start with our best bet. I already asked Nia to arrange a meeting with Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: ""She's willing to speak with you.""*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""We surely cannot. We'll need to work with Mr. Garaci and Mrs. Edmonds to undermine Orso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""It's a tough spot to be in. As I said, we have no other way but to convince Mr. Hawker's fellow Old Guard members behind his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""We may need to take some extreme measures, though.""*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""Also, even if she was with us, that wouldn't change the current climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""I'm not trying to be pessimistic, but Mrs. Morgna cannot..."*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> ""She's willing to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""That's a good start. If she's willing to talk, she's wil..."*)
  - -> `[60]` (*Player: ""Good. I'll make sure she joins us. Just watch.""*)
  - -> `[59]` (*Player: ""How about Heron Garaci?""*)

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""Wait. Did you just call Nia a grumpy old woman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He laughed. Lucian look at him with a raised eyebrow."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""How about Heron Garaci?""]** — Mówca: **Player**
> ""How about Heron Garaci?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""He refused to speak with us.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Good. I'll make sure she joins us. Just watch.""]** — Mówca: **Player**
> ""Good. I'll make sure she joins us. Just watch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""I'm sure you'll convince her.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Come on, gentlemen, let's not overthink this.""]** — Mówca: **Player**
> ""Come on, gentlemen, let's not overthink this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: ""Yeah...""*)

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Well, Nia has the ears of Justices Dalton and Martin. So, we could assume that we have their support as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""So... That gives us three votes to start with.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""The real trouble is their big daddy Hawker. We can't let him control the Court against us.""]** — Mówca: **Player**
> ""The real trouble is their big daddy Hawker. We can't let him control the Court against us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""We surely cannot. We'll need to work with Mr. Garaci and..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""I'm not trying to be pessimistic, but Mrs. Morgna cannot do this alone. Let's not forget about Mr. Hawker. And his loyalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""We'll still need to reach out to the Old Guard and the m..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""...And Mrs. Morgna. She's technically a member too.""]** — Mówca: **Player**
> ""...And Mrs. Morgna. She's technically a member too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: ""Wait. Did you just call Nia a grumpy old woman?""*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""He refused to speak with you, Petr. But if the president can have a one-on-one meeting with him, I'm sure he'll open up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""With all due respect, sir, this is the most crucial step in passing your reforms. It cannot be overthought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""I'm sure you'll convince her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Indeed. But then again, so was winning over the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""We may need to take some extreme measures, though.""*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""I'm afraid she is. I knew she would be a headache...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Not to make it sound more depressing, but it's not only ..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna has been reluctant to help with the lobbying of the Court. But she has accepted to at least try and convince the Justices to organize a meeting with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: ""Which means our lobbying efforts have not yet borne frui..."*)

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""She has the ears of Justices Dalton and Martin. So, we could assume that we have their support as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""So... That gives us three votes to start with.""*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Which means our lobbying efforts have not yet borne fruit. It will be up to you and Mrs. Morgna, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: ""And Nia was pretty adamant about her position against th..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""It's fine. We can do it together. I trust Nia.""]** — Mówca: **Player**
> ""It's fine. We can do it together. I trust Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""We'll still need to reach out to the Old Guard and the moderates in order to reach six votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Do you think we can do it?""*)
  - -> `[33]` (*Player: ""If the Old Guard is against us... How do we even get six..."*)
  - -> `[32]` (*Player: ""It's going to be tough.""*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""Let's not over-assume, Petr. Mrs. Morgna has already made her position known. She will not support the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: ""What? I mean... She would probably support us after that..."*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Not to make it sound more depressing, but it's not only about her. Let's not forget about Mr. Hawker. And his loyalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""That's four or five votes gone, right from the start.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""So, she's serious about voting against the proposal?""]** — Mówca: **Player**
> ""So, she's serious about voting against the proposal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: ""I'm afraid she is. I knew she would be a headache...""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I can't let her sabotage our efforts. She's a minister of my cabinet, she *will* give me her vote.""]** — Mówca: **Player**
> ""I can't let her sabotage our efforts. She's a minister of my cabinet, she *will* give me her vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: ""I don't know about that, Anton. You have to convince her..."*)

### Węzeł `[80]`
Mówca: **Petr Vectern**
> ""Ouch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Lucian looked at both of us with a raised eyebrow."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""It's going to be tough.""]** — Mówca: **Player**
> ""It's going to be tough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""Indeed. But then again, so was winning over the Assembly.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""It's fine. We can do it without her.""]** — Mówca: **Player**
> ""It's fine. We can do it without her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Not to make it sound more depressing, but it's not only ..."*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "He cleared his throat."*)

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""What? I mean... She would probably support us after that win, no?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""She's a tough woman. I doubt that she'll be persuaded at..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "He laughed. Lucian look at him with a raised eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""Anyway...""*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""I don't know about that, Anton. You have to convince her yourself, if you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Not to make it sound more depressing, but it's not only ..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Petr Vectern: ""About the Court...""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""If the reformist justices are against us along with the Old Guard... How do we even get six votes?""]** — Mówca: **Player**
> ""If the reformist justices are against us along with the Old Guard... How do we even get six votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""It's a tough spot to be in. As I said, we have no other ..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Do you think we can do it?""]** — Mówca: **Player**
> ""Do you think we can do it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""We've come this far. Anything is possible.""*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""That's four or five votes gone, right from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""Yes. We'll need to reach out to the Old Guard and the mo..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Hasn't she managed to lobby anyone else?""]** — Mówca: **Player**
> ""Hasn't she managed to lobby anyone else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Petr Vectern: ""She has the ears of Justices Dalton and Martin. So, we c..."*)

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""About the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Our lobbying efforts are continuing positively, but they have yet to yield concrete results. It will be ultimately up to Mrs. Morgna and you to persuade the Justices, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Petr Vectern: ""And we already have Nia inside the Court. That's one vot..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Yes. We'll need to reach out to the Old Guard and the moderates in order to reach six votes. There is not much leeway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""Do you think we can do it?""*)
  - -> `[88]` (*Player: ""If the reformist justices are against us along with the ..."*)
  - -> `[81]` (*Player: ""It's going to be tough.""*)

### Węzeł `[95]`
Mówca: **Petr Vectern**
> ""And we already have Nia inside the Court. That's one vote out of eleven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: ""Which leaves us five more...""*)
  - -> `[91]` (*Player: ""Hasn't she managed to lobby anyone else?""*)
  - -> `[74]` (*Player: ""It's fine. We can do it together. I trust Nia.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""Mrs. Morgna has been helping out with the lobbying of th..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""Mrs. Morgna has been reluctant to help with the lobbying..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""Which leaves us five more...""]** — Mówca: **Player**
> ""Which leaves us five more...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Petr Vectern: ""Well, Nia has the ears of Justices Dalton and Martin. So..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Can we even trust her to bring the other Justices to the table?""]** — Mówca: **Player**
> ""Can we even trust her to bring the other Justices to the table?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Petr Vectern: ""I don't know, but she promised to talk Mrs. Edmonds into..."*)

### Węzeł `[101]`
Mówca: **Petr Vectern**
> ""I don't know, but she promised to talk Mrs. Edmonds into having a meeting with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""In the end, we cannot trust anyone, sir.""*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""In the end, we cannot trust anyone, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: ""Not to make it sound more depressing, but it's not only ..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Thank you again for your hard work, Petr.""]** — Mówca: **Player**
> ""Thank you again for your hard work, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Petr Vectern: ""It was nothing, Anton. It was mostly you.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""We can celebrate once we get past the Court.""]** — Mówca: **Player**
> ""We can celebrate once we get past the Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: ""The president's right. The Assembly was the easy part.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Great job, gentlemen!""]** — Mówca: **Player**
> ""Great job, gentlemen!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Petr leaned on the balcony railing."*)

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""It was nothing, Anton. It was mostly you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Petr leaned on the balcony railing."*)

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""What about Tarquin Soll? Did you see him again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: ""As far as I know he's still staying in Holsord, but hasn..."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""The president's right. The Assembly was the easy part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Petr leaned on the balcony railing."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Petr leaned on the balcony railing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""What about Tarquin Soll? Did you see him again?""*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""As far as I know he's still staying in Holsord, but hasn't cared to pay his respects to President Rayne yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Petr Vectern: ""What the hell was that all about anyway? Him appearing o..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""But for now, let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yeah, we have the first hurdle cleared, but...""*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""In any case, I will conduct proper investigations into this. We should know every hidden Old Guard member who is working with Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: ""But for now, let's move on.""*)

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""He saw their faces, but didn't recognize them.""]** — Mówca: **Player**
> ""He saw their faces, but didn't recognize them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: ""That's too bad.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Let's not name any names now.""]** — Mówca: **Player**
> ""Let's not name any names now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Petr Vectern: ""Okay...""*)

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""What the hell was that all about anyway? Him appearing out of nowhere...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""He is not a threat to us. We should focus on our tasks a..."*)
  - -> `[122]` (*Player: ""He came to the Assembly to make a statement. But we stil..."*)
  - -> `[155]` (*Player: ""He just joined a constitutional vote. I think it's perfe..."*)
  - -> `[130]` (*Player: ""What do you think was his real intention?""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Let's just move on with our next steps.""]** — Mówca: **Player**
> ""Let's just move on with our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Maybe you should have. Even Serge knew about it.""]** — Mówca: **Player**
> ""Maybe you should have. Even Serge knew about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Petr Vectern: ""How did Serge know, anyway?""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: ""You're right, sir. We must plan ahead now.""*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""I'm sorry that we failed to warn you he would be attending, Mr. President. We should have been informed about his arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Petr Vectern: ""What Lucian said. We apologize.""*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> ""Well, the laws protect him from almost anything, and allow him to be a member of the Assembly. He can still propose bills and vote for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: ""That's proper authority, if you ask me. When you are the..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""He came to the Assembly to make a statement. But we still won the vote.""]** — Mówca: **Player**
> ""He came to the Assembly to make a statement. But we still won the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: ""I'm sorry that we failed to warn you he would be attendi..."*)

### Węzeł `[123]`
Mówca: **Petr Vectern**
> ""Oh, he did? Who were they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Let's not name any names now.""*)
  - -> `[114]` (*Player: ""He saw their faces, but didn't recognize them.""*)

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""That's too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""But he has no authority anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: ""Well, the laws protect him from almost anything, and all..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""No, he didn't.""]** — Mówca: **Player**
> ""No, he didn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: ""That's too bad.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Yes, he did.""]** — Mówca: **Player**
> ""Yes, he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Petr Vectern: ""Oh, he did? Who were they?""*)

### Węzeł `[128]`
Mówca: **Lucian Galade**
> ""As long as he's around, he will always have influence over the republic he built. We should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""But he has no authority anymore.""*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""He wished to intimidate the Assembly into rejecting our proposal, sir. And it seems to have failed. But we can't be sure. He might be here to work with the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucian Galade: ""As long as he's around, he will always have influence ov..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""What do you think was his real intention?""]** — Mówca: **Player**
> ""What do you think was his real intention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""He wished to intimidate the Assembly into rejecting our ..."*)

### Węzeł `[131]`
Mówca: **Lucian Galade**
> ""Of course not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[132]`
Mówca: **Petr Vectern**
> ""He didn't see who they were, did he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: ""It doesn't matter now, does it?""*)
  - -> `[126]` (*Player: ""No, he didn't.""*)
  - -> `[127]` (*Player: ""Yes, he did.""*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""Soll might be working behind the scenes against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: ""We cannot let the party slip from our grasp.""*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""What? Me? Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: ""Of course not, sir.""*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""It seems some of our respected MPs already knew about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Petr Vectern: ""He didn't see who they were, did he?""*)

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""I guess not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""With him around, we have to be extra careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: ""We cannot let the party slip from our grasp.""*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""We cannot let the party slip from our grasp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: ""Exactly. We must plan our next steps.""*)
  - -> `[158]` (*Player: ""We should organize a cabinet meeting to discuss the situ..."*)
  - -> `[157]` (*Player: ""I just still can't believe I didn't know he was coming.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""It doesn't matter now, does it?""]** — Mówca: **Player**
> ""It doesn't matter now, does it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Petr Vectern), `[152]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Petr Vectern: ""I guess not.""*)

### Węzeł `[140]`
Mówca: **Lucian Galade**
> ""Still, sir, we should have been more aware. But it's time to plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yeah, we have the first hurdle cleared, but...""*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""He said he overheard some people talking about it around the Assembly.""]** — Mówca: **Player**
> ""He said he overheard some people talking about it around the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: ""It seems some of our respected MPs already knew about th..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I hope you are not hiding anything from me.""]** — Mówca: **Player**
> ""I hope you are not hiding anything from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""What? Me? Never!""*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""It smells fishy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: ""I just still can't believe I didn't know he was coming.""*)
  - -> `[160]` (*Player: ""Just try to reach out to him.""*)
  - -> `[117]` (*Player: ""Let's just move on with our next steps.""*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""You're right, sir. But as long as he's here in Holsord, he can create problems for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucian Galade: ""But let's move on for now.""*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""That's proper authority, if you ask me. When you are the founder of this system, you don't need to be sitting in the presidential office to have power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""He just joined a constitutional vote. I think it's perfe..."*)
  - -> `[172]` (*Player: ""Are you saying he still has more authority than me?""*)
  - -> `[167]` (*Player: ""Lucian's right. He already showcased his powers at the v..."*)
  - -> `[166]` (*Player: ""I want to talk to him. Are you sure he's still in Holsord?""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""]** — Mówca: **Player**
> ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""He is not a threat to us. We should focus on our tasks at hand.""]** — Mówca: **Player**
> ""He is not a threat to us. We should focus on our tasks at hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: ""You're right, sir. We must plan ahead now.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""It's all good.""]** — Mówca: **Player**
> ""It's all good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[152]`
Mówca: **Petr Vectern**
> ""How did Serge know, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: ""It doesn't matter now, does it?""*)
  - -> `[143]` (*Player: ""He said he overheard some people talking about it around..."*)
  - -> `[144]` (*Player: ""I hope you are not hiding anything from me.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""That wasn't your fault.""]** — Mówca: **Player**
> ""That wasn't your fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""What Lucian said. We apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""It's all good.""*)
  - -> `[153]` (*Player: ""That wasn't your fault.""*)
  - -> `[149]` (*Player: ""I learned it from Serge. How come MY DRIVER knows more t..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""He just joined a constitutional vote. I think it's perfectly normal that he'd come out for this.""]** — Mówca: **Player**
> ""He just joined a constitutional vote. I think it's perfectly normal that he'd come out for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Petr Vectern), `[148]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: ""You're right, sir. But as long as he's here in Holsord, ..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: ""It's not that important. He didn't do anything.""]** — Mówca: **Player**
> ""It's not that important. He didn't do anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: ""Still, sir, we should have been more aware. But it's tim..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I just still can't believe I didn't know he was coming.""]** — Mówca: **Player**
> ""I just still can't believe I didn't know he was coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade), `[145]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: ""I'm sorry that we failed to warn you he would be attendi..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""We should organize a cabinet meeting to discuss the situation.""]** — Mówca: **Player**
> ""We should organize a cabinet meeting to discuss the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucian Galade: ""Of course, sir. I'll make the necessary arrangements. Le..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Exactly. We must plan our next steps.""]** — Mówca: **Player**
> ""Exactly. We must plan our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""Just try to reach out to him.""]** — Mówca: **Player**
> ""Just try to reach out to him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: ""I'll do my best, sir. Let's now move on to our next steps.""*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""That's what my sources say, sir. But considering he hasn't come to the Palace... I don't know what to expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: ""It smells fishy.""*)

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""With him around, we have to be extra careful.""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yeah, we have the first hurdle cleared, but...""*)

### Węzeł `[164]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But it's no excuse. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""What's done is done. Let's not linger in the past.""*)
  - -> `[156]` (*Player: ""It's not that important. He didn't do anything.""*)
  - -> `[118]` (*Player: ""Maybe you should have. Even Serge knew about it.""*)

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""No, sir. But he certainly has enormous influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: ""Soll might be working behind the scenes against us.""*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I want to talk to him. Are you sure he's still in Holsord?""]** — Mówca: **Player**
> ""I want to talk to him. Are you sure he's still in Holsord?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""That's what my sources say, sir. But considering he hasn..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Lucian's right. He already showcased his powers at the vote. We must be careful.""]** — Mówca: **Player**
> ""Lucian's right. He already showcased his powers at the vote. We must be careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucian Galade: ""Indeed.""*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[169]`
Mówca: **Lucian Galade**
> ""I'll do my best, sir. Let's now move on to our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[170]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But you're right, sir. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Petr Vectern: ""How did Serge know, anyway?""*)

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll make the necessary arrangements. Let's talk about our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Are you saying he still has more authority than me?""]** — Mówca: **Player**
> ""Are you saying he still has more authority than me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucian Galade: ""No, sir. But he certainly has enormous influence.""*)

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""Yeah, we have the first hurdle cleared, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: ""...Now we have the council of grumpy old men in our way.""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yeah, we have the first hurdle cleared, but...""*)

### Węzeł `[175]`
Mówca: **Lucian Galade**
> ""But let's move on for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""Yeah, we have the first hurdle ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yeah, we have the first hurdle cleared, but...""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: ""Hey, we won the vote comfortably. I'm sure that counts f..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Petr Vectern: ""That was too close for comfort. Can't believe we made it..."*)

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""That was too close for comfort. Can't believe we made it through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""There is at least some pressure on the Court now.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == false"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == false)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""The Court still sees us as a threat. They will not be pe..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: ""The Court still sees us as a threat. Especially now that..."*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> ""The Court still sees us as a threat. Especially now that we're removing the term 'Sord' from the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucian Galade: ""I'll be honest. It will be extremely difficult to persua..."*)

### Węzeł `[185]`
Mówca: **Lucian Galade**
> ""I'll be honest. It will be extremely difficult to persuade enough Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""We never expected this to be easy. Nothing has changed.""*)
  - -> `[35]` (*Player: ""Don't worry. I'll talk to the Justices and convince them.""*)
  - -> `[34]` (*Player: ""If the Justices fail us at this stage, I'm sure the peop..."*)
