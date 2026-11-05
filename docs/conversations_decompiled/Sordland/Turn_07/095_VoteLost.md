# Sordland/Turn07/VoteLost

- **ID konwersacji:** `95`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/095_VoteLost.md`
- **Liczba węzłów dialogowych:** 106
- **Liczba wyborów gracza:** 30

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
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[94] Sordland/Turn07/A_AssemblyVote_ResultsMeeting** (../Turn_07/094_A_AssemblyVote_ResultsMeeting.md), Węzeł `[7]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""What do you think was his real intention?""** | `[38]` **Petr Vectern**: ""Yeah... What the hell was that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Lucian Galade**: ""He wished to intimidate the Ass..." |
| `[6]` | **""It doesn't matter now, does it?""** | `[4]` **Petr Vectern**: ""How did Serge know, anyway?""<br>`[76]` **Petr Vectern**: ""He didn't see who they were, di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Petr Vectern**: ""I guess not."" |
| `[18]` | **""Let's just move on to our next steps.""** | `[61]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucian Galade**: ""Of course, sir. We must plan ah..." |
| `[24]` | **""Let's just move on with our next steps.""** | `[87]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Lucian Galade**: ""Of course, sir."" |
| `[27]` | **""Just try to reach out to him.""** | `[87]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Lucian Galade**: ""I'll do my best, sir."" |
| `[33]` | **""No, he didn't.""** | `[76]` **Petr Vectern**: ""He didn't see who they were, di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Petr Vectern**: ""That's too bad."" |
| `[37]` | **""He saw their faces, but he didn't recognize them.""** | `[44]` **Petr Vectern**: ""Oh, he did? Who were they?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Petr Vectern**: ""That's too bad."" |
| `[40]` | **""Exactly. We must plan our next steps.""** | `[86]` **Lucian Galade**: ""We cannot let the party turn ag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Lucian Galade**: ""Of course, sir."" |
| `[42]` | **""Let's not name any names now.""** | `[44]` **Petr Vectern**: ""Oh, he did? Who were they?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Petr Vectern**: ""Okay..."" |
| `[46]` | **""He came to the Assembly to make a statement. And it worked.""** | `[38]` **Petr Vectern**: ""Yeah... What the hell was that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""I'm sorry that we failed to gat..." |
| `[47]` | **""What's done is done. Let's not linger in the past.""** | `[38]` **Petr Vectern**: ""Yeah... What the hell was that ..."<br>`[70]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Lucian Galade**: ""You're right, sir. We must plan..." |
| `[50]` | **""Gentlemen! Nothing is over yet. We still have a country to lead.""** | `[38]` **Petr Vectern**: ""Yeah... What the hell was that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Petr Vectern**: ""If we can lead it..."" |
| `[51]` | **""That wasn't your fault.""** | `[58]` **Petr Vectern**: ""Y-Yes. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[53]` | **""Maybe you should have. Even Serge knew about it.""** | `[61]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Petr Vectern**: ""How did Serge know, anyway?"" |
| `[55]` | **""We should organize a cabinet meeting to discuss the situation.""** | `[86]` **Lucian Galade**: ""We cannot let the party turn ag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""Of course, sir. I'll make the n..." |
| `[59]` | **""He said he overheard some people talking about it around the Assembly.""** | `[4]` **Petr Vectern**: ""How did Serge know, anyway?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: ""It seems some of our respected ..." |
| `[60]` | **""It's all good.""** | `[58]` **Petr Vectern**: ""Y-Yes. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[62]` | **""I learned it from Serge. How come MY DRIVER knows more than YOU!?""** | `[58]` **Petr Vectern**: ""Y-Yes. We apologize."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""In a situation such as this, I ..." |
| `[63]` | **""What's done is done. Let's not linger in the past.""** | `[61]` **Lucian Galade**: ""In a situation such as this, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""You're right, sir. We must plan..." |
| `[64]` | **""Yes, he did.""** | `[76]` **Petr Vectern**: ""He didn't see who they were, di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Petr Vectern**: ""Oh, he did? Who were they?"" |
| `[67]` | **""I just still can't believe I didn't know about this beforehand.""** | `[86]` **Lucian Galade**: ""We cannot let the party turn ag..."<br>`[87]` **Petr Vectern**: ""It smells fishy."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""I'm sorry that we failed to gat..." |
| `[71]` | **""I hope you are not hiding anything from me.""** | `[4]` **Petr Vectern**: ""How did Serge know, anyway?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Petr Vectern**: ""What? Me? Never!"" |
| `[72]` | **""Are you saying he still has more authority than me?""** | `[70]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: ""No, sir. But he certainly has e..." |
| `[73]` | **""Lucian's right. He already showcased his powers at the vote. We must be careful.""** | `[70]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Lucian Galade**: ""We must be careful, indeed. The..." |
| `[77]` | **""I want to talk to him. Do you know if he's still in Holsord?""** | `[70]` **Lucian Galade**: ""That's proper authority, if you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lucian Galade**: ""He must be, sir. But he didn't ..." |
| `[89]` | **""I want a list of every party member who voted against the proposal.""** | `[20]` **Lucian Galade**: ""I will also try and test the wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucian Galade**: ""Sir, it was a secret ballot."" |
| `[90]` | **""Good. I want each minister to give me a report.""** | `[20]` **Lucian Galade**: ""I will also try and test the wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Lucian Galade**: ""Yes, sir."" |
| `[91]` | **""The party has to learn to respect me. Tarquin Soll is not their leader anymore.""** | `[20]` **Lucian Galade**: ""I will also try and test the wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""Don't worry, sir. We'll address..." |
| `[93]` | **""I don't care. I want names.""** | `[92]` **Lucian Galade**: ""Sir, it was a secret ballot."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lucian Galade**: ""Of course, sir. I'll do what I ..." |
| `[94]` | **""Goddammit.""** | `[92]` **Lucian Galade**: ""Sir, it was a secret ballot."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""Don't worry, sir. We'll address..." |

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
  - -> `[9]` (*Narrator: "Lucian, Petr and I met in my office and decided to move o..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: ""As long as he's around, he will always have influence ov..."*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""What do you think was his real intention?""]** — Mówca: **Player**
> ""What do you think was his real intention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""He wished to intimidate the Assembly against our proposa..."*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> ""How did Serge know, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""It doesn't matter now, does it?""*)
  - -> `[59]` (*Player: ""He said he overheard some people talking about it around..."*)
  - -> `[71]` (*Player: ""I hope you are not hiding anything from me.""*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""He wished to intimidate the Assembly against our proposal, sir. And it seems to have worked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: ""As long as he's around, he will always have influence ov..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""It doesn't matter now, does it?""]** — Mówca: **Player**
> ""It doesn't matter now, does it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern), `[76]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: ""I guess not.""*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""As long as he's around, he will always have influence over the republic which he has built. We should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""But he has no authority anymore.""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We'll be organizing a cabinet meeting to discuss our pre..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Lucian, Petr and I met in my office and decided to move out onto the balcony to get some fresh air in the increasing summer heat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "They both looked uncomfortable in their suits. Petr was t..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote == 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote == 16"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote == 16)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote == 16`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] == 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""I still can't believe we lost by one vote...""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote == 16)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] == 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote == 11"*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""I still can't believe we lost by one vote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""It was all Mrs. Tory's doing...""*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Meanwhile...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We'll be organizing a cabinet meeting to discuss our pre..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote == 11`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote == 11"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote == 11)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote == 11`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] == 11`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == false"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote == 11)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] == 11) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""What do we do now? All our plans, for nothing...""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Let's just move on to our next steps.""]** — Mówca: **Player**
> ""Let's just move on to our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""Of course, sir. We must plan ahead now.""*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""I don't know what to say... I still can't believe we didn't even achieve a simple majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: ""The party has finally spoken.""*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I will also try and test the waters with our MPs. We can't let the party slip out of our grasp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""Good. I want each minister to give me a report.""*)
  - -> `[91]` (*Player: ""The party has to learn to respect me. Tarquin Soll is no..."*)
  - -> `[89]` (*Player: ""I want a list of every party member who voted against th..."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""What do we do now? All our plans, for nothing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""Yes. The USP leadership is beginning to target us as well.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""We'll be organizing a cabinet meeting to discuss our present and future state of affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""I will also try and test the waters with our MPs. We can..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "They both looked uncomfortable in their suits. Petr was trying not to make eye contact and kept letting out depressing sighs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He wiped the sweat off his forehead with a handkerchief."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Let's just move on with our next steps.""]** — Mówca: **Player**
> ""Let's just move on with our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He wiped the sweat off his forehead with a handkerchief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote == 16"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We'll be organizing a cabinet meeting to discuss our pre..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Just try to reach out to him.""]** — Mówca: **Player**
> ""Just try to reach out to him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""I'll do my best, sir.""*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""It was all Mrs. Tory's doing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""She changed the threshold! That bitch!""*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""The party has finally spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""Yes. The USP leadership is beginning to target us.""*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""Yes. The USP leadership is beginning to target us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""Not to mention Tarquin Soll himself.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""No, he didn't.""]** — Mówca: **Player**
> ""No, he didn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""That's too bad.""*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""She changed the threshold! That bitch!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""She merely used her authority as Speaker. It was a valid..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Of course, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""She merely used her authority as Speaker. It was a valid interpretation of the Constitution. There were more than 250 members present...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""He saw their faces, but he didn't recognize them.""]** — Mówca: **Player**
> ""He saw their faces, but he didn't recognize them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""That's too bad.""*)

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Yeah... What the hell was that all about? Soll appearing out of nowhere...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""Gentlemen! Nothing is over yet. We still have a country ..."*)
  - -> `[46]` (*Player: ""He came to the Assembly to make a statement. And it work..."*)
  - -> `[47]` (*Player: ""What's done is done. Let's not linger in the past.""*)
  - -> `[3]` (*Player: ""What do you think was his real intention?""*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Yes. The USP leadership is beginning to target us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""Not to mention Tarquin Soll himself.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Exactly. We must plan our next steps.""]** — Mówca: **Player**
> ""Exactly. We must plan our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Not to mention Tarquin Soll himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Let's not name any names now.""]** — Mówca: **Player**
> ""Let's not name any names now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""Okay...""*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Oh, he did? Who were they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Let's not name any names now.""*)
  - -> `[37]` (*Player: ""He saw their faces, but he didn't recognize them.""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We'll be organizing a cabinet meeting to discuss our pre..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""He came to the Assembly to make a statement. And it worked.""]** — Mówca: **Player**
> ""He came to the Assembly to make a statement. And it worked.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I'm sorry that we failed to gather the necessary intelli..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Petr Vectern), `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""You're right, sir. We must plan ahead now.""*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""That's too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""In any case, I will conduct proper investigations into this. We should know every hidden Old Guard member who is working with Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: ""Meanwhile...""*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Gentlemen! Nothing is over yet. We still have a country to lead.""]** — Mówca: **Player**
> ""Gentlemen! Nothing is over yet. We still have a country to lead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: ""If we can lead it...""*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""That wasn't your fault.""]** — Mówca: **Player**
> ""That wasn't your fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""If we can lead it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""...Which we will. You're right, sir. We must plan ahead ..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Maybe you should have. Even Serge knew about it.""]** — Mówca: **Player**
> ""Maybe you should have. Even Serge knew about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: ""How did Serge know, anyway?""*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""We should organize a cabinet meeting to discuss the situation.""]** — Mówca: **Player**
> ""We should organize a cabinet meeting to discuss the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Of course, sir. I'll make the necessary arrangements.""*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I'm sorry that we failed to gather the necessary intelligence about his arrival. Something went wrong on the security reports. I still don't know what. It was partly our fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: ""Y-Yes. We apologize.""*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""I'll do my best, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""Y-Yes. We apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""It's all good.""*)
  - -> `[51]` (*Player: ""That wasn't your fault.""*)
  - -> `[62]` (*Player: ""I learned it from Serge. How come MY DRIVER knows more t..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""He said he overheard some people talking about it around the Assembly.""]** — Mówca: **Player**
> ""He said he overheard some people talking about it around the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""It seems some of our respected MPs already knew about th..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""It's all good.""]** — Mówca: **Player**
> ""It's all good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But it's no excuse. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""What's done is done. Let's not linger in the past.""*)
  - -> `[18]` (*Player: ""Let's just move on to our next steps.""*)
  - -> `[53]` (*Player: ""Maybe you should have. Even Serge knew about it.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""]** — Mówca: **Player**
> ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: ""In a situation such as this, I would have expected Karl ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""You're right, sir. We must plan ahead now.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Yes, he did.""]** — Mówca: **Player**
> ""Yes, he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""Oh, he did? Who were they?""*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But you're right, sir. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: ""How did Serge know, anyway?""*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""But he has no authority anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""Well, the laws protect him from almost anything, and all..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I just still can't believe I didn't know about this beforehand.""]** — Mówca: **Player**
> ""I just still can't believe I didn't know about this beforehand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade), `[87]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I'm sorry that we failed to gather the necessary intelli..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Well, the laws protect him from almost anything, and allows him to be a member of the Assembly. He can still propose bills and vote for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""That's proper authority, if you ask me. When you are the..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Of course not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""That's proper authority, if you ask me. When you are the founder of this system, you don't need to be sitting in the presidential office to have power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""What's done is done. Let's not linger in the past.""*)
  - -> `[72]` (*Player: ""Are you saying he still has more authority than me?""*)
  - -> `[73]` (*Player: ""Lucian's right. He already showcased his powers at the v..."*)
  - -> `[77]` (*Player: ""I want to talk to him. Do you know if he's still in Hols..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I hope you are not hiding anything from me.""]** — Mówca: **Player**
> ""I hope you are not hiding anything from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: ""What? Me? Never!""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Are you saying he still has more authority than me?""]** — Mówca: **Player**
> ""Are you saying he still has more authority than me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""No, sir. But he certainly has enormous influence.""*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Lucian's right. He already showcased his powers at the vote. We must be careful.""]** — Mówca: **Player**
> ""Lucian's right. He already showcased his powers at the vote. We must be careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: ""We must be careful, indeed. The party is in disarray sin..."*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""What? Me? Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""Of course not, sir.""*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""The party is in disarray since we lost the vote. Soll might be working behind the scenes against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""We cannot let the party turn against the administration.""*)

### Węzeł `[76]`
Mówca: **Petr Vectern**
> ""He didn't see who they were, did he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""It doesn't matter now, does it?""*)
  - -> `[33]` (*Player: ""No, he didn't.""*)
  - -> `[64]` (*Player: ""Yes, he did.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I want to talk to him. Do you know if he's still in Holsord?""]** — Mówca: **Player**
> ""I want to talk to him. Do you know if he's still in Holsord?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""He must be, sir. But he didn't even come to the Palace t..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We'll be organizing a cabinet meeting to discuss our pre..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""No, sir. But he certainly has enormous influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""The party is in disarray since we lost the vote. Soll mi..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""It seems some of our respected MPs already knew about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Petr Vectern: ""He didn't see who they were, did he?""*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""We must be careful, indeed. The party is in disarray since we lost the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""And with Soll making a comeback... We cannot trust anyon..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""...Which we will. You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""And with Soll making a comeback... We cannot trust anyone in the USP to keep supporting us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""We cannot let the party turn against the administration.""*)

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""I guess not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""In any case, I will conduct proper investigations into t..."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""He must be, sir. But he didn't even come to the Palace to pay his respects. I don't know what to expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Petr Vectern: ""It smells fishy.""*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""We cannot let the party turn against the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""Exactly. We must plan our next steps.""*)
  - -> `[55]` (*Player: ""We should organize a cabinet meeting to discuss the situ..."*)
  - -> `[67]` (*Player: ""I just still can't believe I didn't know about this befo..."*)

### Węzeł `[87]`
Mówca: **Petr Vectern**
> ""It smells fishy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I just still can't believe I didn't know about this befo..."*)
  - -> `[27]` (*Player: ""Just try to reach out to him.""*)
  - -> `[24]` (*Player: ""Let's just move on with our next steps.""*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll make the necessary arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""We'll be organizing a cabinet ..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I want a list of every party member who voted against the proposal.""]** — Mówca: **Player**
> ""I want a list of every party member who voted against the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""Sir, it was a secret ballot.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Good. I want each minister to give me a report.""]** — Mówca: **Player**
> ""Good. I want each minister to give me a report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: ""Yes, sir.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""The party has to learn to respect me. Tarquin Soll is not their leader anymore.""]** — Mówca: **Player**
> ""The party has to learn to respect me. Tarquin Soll is not their leader anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Don't worry, sir. We'll address the party soon enough, a..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Sir, it was a secret ballot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I don't care. I want names.""*)
  - -> `[94]` (*Player: ""Goddammit.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I don't care. I want names.""]** — Mówca: **Player**
> ""I don't care. I want names.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: ""Of course, sir. I'll do what I can.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Goddammit.""]** — Mówca: **Player**
> ""Goddammit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Don't worry, sir. We'll address the party soon enough, a..."*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Don't worry, sir. We'll address the party soon enough, a..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Don't worry, sir. We'll address the party soon enough, and put them in their proper place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: ""With a single vote, the ghost of the past has once again..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Yeah... What the hell was that all about? Soll appearing..."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""With a single vote, the ghost of the past has once again kept our nation from achieving progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Yeah... What the hell was that all about? Soll appearing..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""I don't know what to say... I still can't believe we did..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Petr Vectern: ""We didn't even achieve a simple majority... As expected,..."*)

### Węzeł `[105]`
Mówca: **Petr Vectern**
> ""We didn't even achieve a simple majority... As expected, removing 'Sord' from the constitution was too much for the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: ""The party has finally spoken.""*)
