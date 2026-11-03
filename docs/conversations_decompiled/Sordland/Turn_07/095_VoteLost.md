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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `94` (*Sordland/Turn07/A_AssemblyVote_ResultsMeeting*), Węzeł `[7]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""What do you think was his real intention?""]** — Mówca: **Player**
> ""What do you think was his real intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> ""How did Serge know, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[59]`
  - -> `[71]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""He wished to intimidate the Assembly against our proposal, sir. And it seems to have worked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""It doesn't matter now, does it?""]** — Mówca: **Player**
> ""It doesn't matter now, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""As long as he's around, he will always have influence over the republic which he has built. We should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Lucian, Petr and I met in my office and decided to move out onto the balcony to get some fresh air in the increasing summer heat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote == 16)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote == 16)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] == 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote == 16))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] == 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""I still can't believe we lost by one vote...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Meanwhile...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote == 11)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote == 11)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] == 11`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote == 11))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] == 11) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Let's just move on to our next steps.""]** — Mówca: **Player**
> ""Let's just move on to our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""I don't know what to say... I still can't believe we didn't even achieve a simple majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I will also try and test the waters with our MPs. We can't let the party slip out of our grasp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[89]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""What do we do now? All our plans, for nothing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""We'll be organizing a cabinet meeting to discuss our present and future state of affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Narrator**
> "They both looked uncomfortable in their suits. Petr was trying not to make eye contact and kept letting out depressing sighs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Let's just move on with our next steps.""]** — Mówca: **Player**
> ""Let's just move on with our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He wiped the sweat off his forehead with a handkerchief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Just try to reach out to him.""]** — Mówca: **Player**
> ""Just try to reach out to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""It was all Mrs. Tory's doing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""The party has finally spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""Yes. The USP leadership is beginning to target us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""No, he didn't.""]** — Mówca: **Player**
> ""No, he didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""She changed the threshold! That bitch!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Of course, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""She merely used her authority as Speaker. It was a valid interpretation of the Constitution. There were more than 250 members present...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""He saw their faces, but he didn't recognize them.""]** — Mówca: **Player**
> ""He saw their faces, but he didn't recognize them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Yeah... What the hell was that all about? Soll appearing out of nowhere...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[46]`
  - -> `[47]`
  - -> `[3]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Yes. The USP leadership is beginning to target us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Exactly. We must plan our next steps.""]** — Mówca: **Player**
> ""Exactly. We must plan our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Not to mention Tarquin Soll himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Let's not name any names now.""]** — Mówca: **Player**
> ""Let's not name any names now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Oh, he did? Who were they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""He came to the Assembly to make a statement. And it worked.""]** — Mówca: **Player**
> ""He came to the Assembly to make a statement. And it worked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""That's too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""In any case, I will conduct proper investigations into this. We should know every hidden Old Guard member who is working with Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Gentlemen! Nothing is over yet. We still have a country to lead.""]** — Mówca: **Player**
> ""Gentlemen! Nothing is over yet. We still have a country to lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""That wasn't your fault.""]** — Mówca: **Player**
> ""That wasn't your fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""If we can lead it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Maybe you should have. Even Serge knew about it.""]** — Mówca: **Player**
> ""Maybe you should have. Even Serge knew about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""We should organize a cabinet meeting to discuss the situation.""]** — Mówca: **Player**
> ""We should organize a cabinet meeting to discuss the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I'm sorry that we failed to gather the necessary intelligence about his arrival. Something went wrong on the security reports. I still don't know what. It was partly our fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""I'll do my best, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""Y-Yes. We apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[51]`
  - -> `[62]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""He said he overheard some people talking about it around the Assembly.""]** — Mówca: **Player**
> ""He said he overheard some people talking about it around the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""It's all good.""]** — Mówca: **Player**
> ""It's all good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But it's no excuse. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[18]`
  - -> `[53]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""]** — Mówca: **Player**
> ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Yes, he did.""]** — Mówca: **Player**
> ""Yes, he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But you're right, sir. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""But he has no authority anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I just still can't believe I didn't know about this beforehand.""]** — Mówca: **Player**
> ""I just still can't believe I didn't know about this beforehand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Well, the laws protect him from almost anything, and allows him to be a member of the Assembly. He can still propose bills and vote for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Of course not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""That's proper authority, if you ask me. When you are the founder of this system, you don't need to be sitting in the presidential office to have power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[72]`
  - -> `[73]`
  - -> `[77]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I hope you are not hiding anything from me.""]** — Mówca: **Player**
> ""I hope you are not hiding anything from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Are you saying he still has more authority than me?""]** — Mówca: **Player**
> ""Are you saying he still has more authority than me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Lucian's right. He already showcased his powers at the vote. We must be careful.""]** — Mówca: **Player**
> ""Lucian's right. He already showcased his powers at the vote. We must be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""What? Me? Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""The party is in disarray since we lost the vote. Soll might be working behind the scenes against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[76]`
Mówca: **Petr Vectern**
> ""He didn't see who they were, did he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[33]`
  - -> `[64]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I want to talk to him. Do you know if he's still in Holsord?""]** — Mówca: **Player**
> ""I want to talk to him. Do you know if he's still in Holsord?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Galade: ""We'll be organizing a cabinet meet..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""No, sir. But he certainly has enormous influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""It seems some of our respected MPs already knew about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""We must be careful, indeed. The party is in disarray since we lost the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""...Which we will. You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""And with Soll making a comeback... We cannot trust anyone in the USP to keep supporting us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""I guess not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""He must be, sir. But he didn't even come to the Palace to pay his respects. I don't know what to expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""We cannot let the party turn against the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[55]`
  - -> `[67]`

### Węzeł `[87]`
Mówca: **Petr Vectern**
> ""It smells fishy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[27]`
  - -> `[24]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll make the necessary arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I want a list of every party member who voted against the proposal.""]** — Mówca: **Player**
> ""I want a list of every party member who voted against the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Good. I want each minister to give me a report.""]** — Mówca: **Player**
> ""Good. I want each minister to give me a report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""The party has to learn to respect me. Tarquin Soll is not their leader anymore.""]** — Mówca: **Player**
> ""The party has to learn to respect me. Tarquin Soll is not their leader anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Sir, it was a secret ballot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I don't care. I want names.""]** — Mówca: **Player**
> ""I don't care. I want names.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Goddammit.""]** — Mówca: **Player**
> ""Goddammit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Don't worry, sir. We'll address the party soon enough, and put them in their proper place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""With a single vote, the ghost of the past has once again kept our nation from achieving progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
> ""We didn't even achieve a simple majority... As expected, removing 'Sord' from the constitution was too much for the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
