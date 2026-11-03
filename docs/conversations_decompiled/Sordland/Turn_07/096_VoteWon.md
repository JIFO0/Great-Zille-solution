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
  - -> `[8]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `94` (*Sordland/Turn07/A_AssemblyVote_ResultsMeeting*), Węzeł `[9]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""That's a good start. If she's willing to talk, she's willing to cooperate.""]** — Mówca: **Player**
> ""That's a good start. If she's willing to talk, she's willing to cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 20)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote >= 20))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""I'm sure the Assembly vote must count for something... I mean, it passed by ninety percent, for God's sake!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucian, Petr and I convened on the massive balcony of the palace. It was nice to catch a breeze in the increasing summer heat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""We barely squeaked by with the Assembly. It was a tough win...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""We may need to take some extreme measures, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""If we cannot get Mrs. Edmond's centrists, we will have no choice but to reach out to the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Lucian looked at both of us with a raised eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Well, she could probably pass as one...""]** — Mówca: **Player**
> ""Well, she could probably pass as one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote > 16)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote > 16)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] > 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote > 16))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] > 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Both had grins on their faces, but Petr's got larger as he kept recounting our success in the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Hey, we won the vote comfortably. I'm sure that counts for something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""He refused to speak with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""They wouldn't dare reject such a popular proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""By convincing all of the other Justices. Every single one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""There is at least some pressure on the Court now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""...Now we have the council of grumpy old men in our way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
> ""The Old Guard won't have any trouble justifying a rejection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Fellas! The first obstacle has been cleared! Congratulations to all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[103]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""We've come this far. Anything is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""It was indeed a historic vote. The President has accomplished something even Tarquin Soll had trouble with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have to say, that's a fitting description for the Court. But unfortunately for us, they are more than that. They're our largest obstacle yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""But this may also make the Court see you as the ultimate threat. I wouldn't be so relaxed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[34]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Indeed. But then again, so was securing the Assembly vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""The Court still sees us as a threat. They will not be persuaded so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""It's going to be tough.""]** — Mówca: **Player**
> ""It's going to be tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""If the Old Guard is against us... How do we even get six votes?""]** — Mówca: **Player**
> ""If the Old Guard is against us... How do we even get six votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""If the Justices fail us at this stage, I'm sure the people will see them for who they really are.""]** — Mówca: **Player**
> ""If the Justices fail us at this stage, I'm sure the people will see them for who they really are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Don't worry. I'll talk to the Justices and convince them.""]** — Mówca: **Player**
> ""Don't worry. I'll talk to the Justices and convince them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""We never expected this to be easy. Nothing has changed.""]** — Mówca: **Player**
> ""We never expected this to be easy. Nothing has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Do you think we can do it?""]** — Mówca: **Player**
> ""Do you think we can do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""She's a tough woman. I doubt that she'll be persuaded at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Also... You are forgetting about Mrs. Edmonds. They're not all grumpy old men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[63]`
  - -> `[13]`
  - -> `[61]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""And Nia was pretty adamant about her position against the proposal. That's already one vote lost out of eleven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[82]`
  - -> `[100]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna has been helping out with the lobbying of the Court. She has been speaking with Mrs. Edmonds, and we believe she's our key figure on the inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""Yeah...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I wouldn't be so sure, sir. They control more than the Court, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""So... That gives us three votes to start with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""And the average citizen has no interest in such matters. The public won't be very helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""We've come this far. Anything is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""That's true, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Petr started laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""I believe in you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""In any case, we should start with our best bet. I already asked Nia to arrange a meeting with Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""We surely cannot. We'll need to work with Mr. Garaci and Mrs. Edmonds to undermine Orso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""It's a tough spot to be in. As I said, we have no other way but to convince Mr. Hawker's fellow Old Guard members behind his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""Also, even if she was with us, that wouldn't change the current climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
> ""She's willing to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[60]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
> ""Wait. Did you just call Nia a grumpy old woman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""How about Heron Garaci?""]** — Mówca: **Player**
> ""How about Heron Garaci?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Good. I'll make sure she joins us. Just watch.""]** — Mówca: **Player**
> ""Good. I'll make sure she joins us. Just watch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Come on, gentlemen, let's not overthink this.""]** — Mówca: **Player**
> ""Come on, gentlemen, let's not overthink this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Well, Nia has the ears of Justices Dalton and Martin. So, we could assume that we have their support as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""The real trouble is their big daddy Hawker. We can't let him control the Court against us.""]** — Mówca: **Player**
> ""The real trouble is their big daddy Hawker. We can't let him control the Court against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""I'm not trying to be pessimistic, but Mrs. Morgna cannot do this alone. Let's not forget about Mr. Hawker. And his loyalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""...And Mrs. Morgna. She's technically a member too.""]** — Mówca: **Player**
> ""...And Mrs. Morgna. She's technically a member too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""He refused to speak with you, Petr. But if the president can have a one-on-one meeting with him, I'm sure he'll open up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""With all due respect, sir, this is the most crucial step in passing your reforms. It cannot be overthought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""I'm sure you'll convince her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""Indeed. But then again, so was winning over the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""I'm afraid she is. I knew she would be a headache...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna has been reluctant to help with the lobbying of the Court. But she has accepted to at least try and convince the Justices to organize a meeting with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""She has the ears of Justices Dalton and Martin. So, we could assume that we have their support as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Which means our lobbying efforts have not yet borne fruit. It will be up to you and Mrs. Morgna, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""It's fine. We can do it together. I trust Nia.""]** — Mówca: **Player**
> ""It's fine. We can do it together. I trust Nia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""We'll still need to reach out to the Old Guard and the moderates in order to reach six votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[33]`
  - -> `[32]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""Let's not over-assume, Petr. Mrs. Morgna has already made her position known. She will not support the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Not to make it sound more depressing, but it's not only about her. Let's not forget about Mr. Hawker. And his loyalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""So, she's serious about voting against the proposal?""]** — Mówca: **Player**
> ""So, she's serious about voting against the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I can't let her sabotage our efforts. She's a minister of my cabinet, she *will* give me her vote.""]** — Mówca: **Player**
> ""I can't let her sabotage our efforts. She's a minister of my cabinet, she *will* give me her vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[80]`
Mówca: **Petr Vectern**
> ""Ouch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""It's going to be tough.""]** — Mówca: **Player**
> ""It's going to be tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""It's fine. We can do it without her.""]** — Mówca: **Player**
> ""It's fine. We can do it without her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""What? I mean... She would probably support us after that win, no?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[85]`
Mówca: **Narrator**
> "He laughed. Lucian look at him with a raised eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""I don't know about that, Anton. You have to convince her yourself, if you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[87]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""If the reformist justices are against us along with the Old Guard... How do we even get six votes?""]** — Mówca: **Player**
> ""If the reformist justices are against us along with the Old Guard... How do we even get six votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Do you think we can do it?""]** — Mówca: **Player**
> ""Do you think we can do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""That's four or five votes gone, right from the start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Hasn't she managed to lobby anyone else?""]** — Mówca: **Player**
> ""Hasn't she managed to lobby anyone else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""About the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Our lobbying efforts are continuing positively, but they have yet to yield concrete results. It will be ultimately up to Mrs. Morgna and you to persuade the Justices, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Yes. We'll need to reach out to the Old Guard and the moderates in order to reach six votes. There is not much leeway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[81]`

### Węzeł `[95]`
Mówca: **Petr Vectern**
> ""And we already have Nia inside the Court. That's one vote out of eleven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[91]`
  - -> `[74]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""Which leaves us five more...""]** — Mówca: **Player**
> ""Which leaves us five more...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Can we even trust her to bring the other Justices to the table?""]** — Mówca: **Player**
> ""Can we even trust her to bring the other Justices to the table?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Petr Vectern**
> ""I don't know, but she promised to talk Mrs. Edmonds into having a meeting with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""In the end, we cannot trust anyone, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Thank you again for your hard work, Petr.""]** — Mówca: **Player**
> ""Thank you again for your hard work, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""We can celebrate once we get past the Court.""]** — Mówca: **Player**
> ""We can celebrate once we get past the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Great job, gentlemen!""]** — Mówca: **Player**
> ""Great job, gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""It was nothing, Anton. It was mostly you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""What about Tarquin Soll? Did you see him again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""The president's right. The Assembly was the easy part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Petr leaned on the balcony railing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""As far as I know he's still staying in Holsord, but hasn't cared to pay his respects to President Rayne yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""But for now, let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""In any case, I will conduct proper investigations into this. We should know every hidden Old Guard member who is working with Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""He saw their faces, but didn't recognize them.""]** — Mówca: **Player**
> ""He saw their faces, but didn't recognize them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Let's not name any names now.""]** — Mówca: **Player**
> ""Let's not name any names now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""What the hell was that all about anyway? Him appearing out of nowhere...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[122]`
  - -> `[155]`
  - -> `[130]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Let's just move on with our next steps.""]** — Mówca: **Player**
> ""Let's just move on with our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Maybe you should have. Even Serge knew about it.""]** — Mówca: **Player**
> ""Maybe you should have. Even Serge knew about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""What's done is done. Let's not linger in the past.""]** — Mówca: **Player**
> ""What's done is done. Let's not linger in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""I'm sorry that we failed to warn you he would be attending, Mr. President. We should have been informed about his arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> ""Well, the laws protect him from almost anything, and allow him to be a member of the Assembly. He can still propose bills and vote for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""He came to the Assembly to make a statement. But we still won the vote.""]** — Mówca: **Player**
> ""He came to the Assembly to make a statement. But we still won the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Petr Vectern**
> ""Oh, he did? Who were they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[114]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""That's too bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""But he has no authority anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""No, he didn't.""]** — Mówca: **Player**
> ""No, he didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Yes, he did.""]** — Mówca: **Player**
> ""Yes, he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
> ""As long as he's around, he will always have influence over the republic he built. We should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""He wished to intimidate the Assembly into rejecting our proposal, sir. And it seems to have failed. But we can't be sure. He might be here to work with the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""What do you think was his real intention?""]** — Mówca: **Player**
> ""What do you think was his real intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
> ""Of course not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[132]`
Mówca: **Petr Vectern**
> ""He didn't see who they were, did he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[126]`
  - -> `[127]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""Soll might be working behind the scenes against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""What? Me? Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""It seems some of our respected MPs already knew about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""I guess not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""With him around, we have to be extra careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""We cannot let the party slip from our grasp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[158]`
  - -> `[157]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""It doesn't matter now, does it?""]** — Mówca: **Player**
> ""It doesn't matter now, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
> ""Still, sir, we should have been more aware. But it's time to plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""He said he overheard some people talking about it around the Assembly.""]** — Mówca: **Player**
> ""He said he overheard some people talking about it around the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I hope you are not hiding anything from me.""]** — Mówca: **Player**
> ""I hope you are not hiding anything from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""It smells fishy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[160]`
  - -> `[117]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""You're right, sir. But as long as he's here in Holsord, he can create problems for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> ""You're right, sir. We must plan ahead now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""That's proper authority, if you ask me. When you are the founder of this system, you don't need to be sitting in the presidential office to have power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[172]`
  - -> `[167]`
  - -> `[166]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""]** — Mówca: **Player**
> ""I learned it from Serge. How come MY DRIVER knows more than YOU!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""He is not a threat to us. We should focus on our tasks at hand.""]** — Mówca: **Player**
> ""He is not a threat to us. We should focus on our tasks at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""It's all good.""]** — Mówca: **Player**
> ""It's all good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[152]`
Mówca: **Petr Vectern**
> ""How did Serge know, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""That wasn't your fault.""]** — Mówca: **Player**
> ""That wasn't your fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""What Lucian said. We apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[153]`
  - -> `[149]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""He just joined a constitutional vote. I think it's perfectly normal that he'd come out for this.""]** — Mówca: **Player**
> ""He just joined a constitutional vote. I think it's perfectly normal that he'd come out for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[156]`
**[WYBÓR GRACZA: ""It's not that important. He didn't do anything.""]** — Mówca: **Player**
> ""It's not that important. He didn't do anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I just still can't believe I didn't know he was coming.""]** — Mówca: **Player**
> ""I just still can't believe I didn't know he was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""We should organize a cabinet meeting to discuss the situation.""]** — Mówca: **Player**
> ""We should organize a cabinet meeting to discuss the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Exactly. We must plan our next steps.""]** — Mówca: **Player**
> ""Exactly. We must plan our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""Just try to reach out to him.""]** — Mówca: **Player**
> ""Just try to reach out to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""That's what my sources say, sir. But considering he hasn't come to the Palace... I don't know what to expect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But it's no excuse. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[156]`
  - -> `[118]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""No, sir. But he certainly has enormous influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I want to talk to him. Are you sure he's still in Holsord?""]** — Mówca: **Player**
> ""I want to talk to him. Are you sure he's still in Holsord?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Lucian's right. He already showcased his powers at the vote. We must be careful.""]** — Mówca: **Player**
> ""Lucian's right. He already showcased his powers at the vote. We must be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
> ""I'll do my best, sir. Let's now move on to our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
> ""In a situation such as this, I would have expected Karl to report it to me. But you're right, sir. We should have done our own research.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll make the necessary arrangements. Let's talk about our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Are you saying he still has more authority than me?""]** — Mówca: **Player**
> ""Are you saying he still has more authority than me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""Yeah, we have the first hurdle cleared, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
> ""But let's move on for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""Yeah, we have the first hurdle cle..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""That was too close for comfort. Can't believe we made it through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
> ""The Court still sees us as a threat. Especially now that we're removing the term 'Sord' from the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
> ""I'll be honest. It will be extremely difficult to persuade enough Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[34]`
