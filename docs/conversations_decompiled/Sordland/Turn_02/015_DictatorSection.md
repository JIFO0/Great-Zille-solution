# Sordland/Turn02/DictatorSection

- **ID konwersacji:** `15`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/015_DictatorSection.md`
- **Liczba węzłów dialogowych:** 151
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Nia_Opposition`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[14] Sordland/Turn02/A_ReformBriefing** (../Turn_02/014_A_ReformBriefing.md), Węzeł `[63]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 3

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Nia_Opposition`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[65]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- Węzeł `[85]` (Petr Vectern): `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- Węzeł `[144]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `14` (*Sordland/Turn02/A_ReformBriefing*), Węzeł `[63]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""I'll keep working with them and keep you updated, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We need to work closely with NFP, they are our only potential partners.""]** — Mówca: **Player**
> ""We need to work closely with NFP, they are our only potential partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Petr Vectern**
> ""We will be ensuring that the Supreme Court can no longer block constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Most of them won't. But we already talked about a possible agreement with Isabel which may change things. We could potentially get Heron and the Sollist judges as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Most people already find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Yes. This will ensure that the Supreme Court will no longer have absolute power over legislation. We can persuade the other parties with this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""There are some people in USP who would support a new Constitution with more executive powers. Getting the support of the NFP nationalists is our best bet on this path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her and Judge Garaci, we might be able to get enough votes. They have major influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""You are part of my cabinet. You wouldn't dare.""]** — Mówca: **Player**
> ""You are part of my cabinet. You wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Apart from these two critical points we could address a lot of the issues already in discussion for our own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""NFP want to reform the appointment procedures of the ministers. Mr. Kibener clarified that the Assembly should have a say in the formation of the council of ministers. They are a potential ally so this is an important demand to consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""We could address the term limits and election threshold as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""That is something that a majority in our party also supports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""Well... That one is a controversial one. I doubt that USP would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Immunity of the Justices, the impeachment of the president, the power of the presidential decrees... All of these are in the realm of possibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I disagree. We'll push for comprehensive reforms.""]** — Mówca: **Player**
> ""I disagree. We'll push for comprehensive reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together with all the cabinet to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'm with you on this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I agree. Let's keep the changes small and manageable.""]** — Mówca: **Player**
> ""I agree. Let's keep the changes small and manageable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""If we can establish a proper balance and get the support of the NFP, you can gain a lot from these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Petr Vectern**
> ""I'd say keeping everything in the middle ground is the safest bet. No need to agitate anyone too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[24]`
  - -> `[4]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""As long as we accomplish our goals, I also agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[28]`
Mówca: **Nia Morgna**
> ""What? You were working on a different draft while we worked in the committee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""That said, we should try to reach a common ground with the conservative wing of our party to be able to propose such changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We will do what's necessary to get them in line.""]** — Mówca: **Player**
> ""We will do what's necessary to get them in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: DictatorKeyFigureHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[148]`
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I'm sure they will.""]** — Mówca: **Player**
> ""I'm sure they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[110]`

### Węzeł `[37]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""That is correct. Mr. President had *stronger* ideas. Surely, I couldn't work with the reform committee. No offence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Can we pass it through the Supreme Court?""]** — Mówca: **Player**
> ""Can we pass it through the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Can we possibly reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we possibly reach a two-thirds majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`
  - -> `[33]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Now if we are going with this direction, I'll need everybody to focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[56]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I understand.""]** — Mówca: **Player**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Lucian pulled out a huge dossier from his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[47]`
Mówca: **Nia Morgna**
> ""I wish you a good day, Mr. President. We'll see what happens in the Assembly and the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[99]`
  - -> `[97]`

### Węzeł `[48]`
Mówca: **Narrator**
> "She spoke with a gentle tone but her face couldn't hide her disappointment and anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why on earth would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""We will definitely need to work with some of the Old Guard aligned judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[81]`
  - -> `[79]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Did you already work on a plan?""]** — Mówca: **Player**
> ""Did you already work on a plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[54]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be tough to bribe the Old Guards. Chief Justice Hawker will do their best to undermine us. But maybe we can get to Heron Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""You have our attention.""]** — Mówca: **Player**
> ""You have our attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can unite it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can unite it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""According to such change, constitutional amendments will still require the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[50]`
  - -> `[49]`
  - -> `[5]`

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""This is a point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We can break the power of the Old Guards with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""We'll talk about this later.""]** — Mówca: **Player**
> ""We'll talk about this later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I'll move on to the second point then. The new Constitution should remove the Supreme Court out of the constitutional amendment process. Not only popular, it would also strengthen our position against the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [DictatorKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""That's true. We have bigger fish to catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Oh she will. I don't think she has that in her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Let's proceed.""]** — Mówca: **Player**
> ""Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Do not doubt me, Nia.""]** — Mówca: **Player**
> ""Do not doubt me, Nia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""According to the Constitution, I am a member of the Supreme Court, which means you already have one vote against this. I already know two of the judges who are with me, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[71]`
Mówca: **Nia Morgna**
> ""I'm starting to doubt that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""I can't believe you are all in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""That's troublesome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""While I respect her, I doubt that she's capable of creating major obstacles for us. But we have to keep close eyes on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[78]`
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Yes, keep an eye on her. We can't let her sabotage us.""]** — Mówca: **Player**
> ""Yes, keep an eye on her. We can't let her sabotage us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm sure we can work something out with you, Mrs. Morgna.""]** — Mówca: **Player**
> ""I'm sure we can work something out with you, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I will make sure she stays in line.""]** — Mówca: **Player**
> ""I will make sure she stays in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I'm sure they can be bought.""]** — Mówca: **Player**
> ""I'm sure they can be bought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""She's not our main problem here.""]** — Mówca: **Player**
> ""She's not our main problem here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Who do you think would be willing to support these changes?""]** — Mówca: **Player**
> ""Who do you think would be willing to support these changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""I meant no disrespect, Mr. President. But you should be aware of my position, and that it is final.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[77]`
  - -> `[130]`

### Węzeł `[83]`
Mówca: **Narrator**
> "She left the room and slammed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""So, we don't even have a vote in the Court?""]** — Mówca: **Player**
> ""So, we don't even have a vote in the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[85]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""Come now, Mrs. Morgna. You said you were open to discuss Mr. President's version of the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[87]`
Mówca: **Narrator**
> "She gave a fake smile and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Nia Morgna**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you think they can be persuaded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[91]`
Mówca: **Narrator**
> "She gave a fake smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""Well, we don't. I doubt that any of the judges would support such changes just like that. But they can surely be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""I think we can reach out to Judge Edmonds. And in extension, Mr. Dalton and Mr. Martin. They aren't working together with the Old Guards, as far as we know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[94]`
Mówca: **Petr Vectern**
> ""I know you will. If you can get their support, we'll have enough votes to amend the Constitution, counting we have the support of Mr. Kibener too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Be careful with what you decide to do, Mrs. Morgna.""]** — Mówca: **Player**
> ""Be careful with what you decide to do, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I'll make sure they follow me.""]** — Mówca: **Player**
> ""I'll make sure they follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Good day to you too, Mrs. Morgna.""]** — Mówca: **Player**
> ""Good day to you too, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I will be watching you.""]** — Mówca: **Player**
> ""I will be watching you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""You must be talking about Gloria Tory. She's well respected by the Sollists. She's the biggest problem in our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
Mówca: **Narrator**
> "She took her notes and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""We'll never be able to get PFJP to work with us. But if you can get Kesaro Kibener to work with you on this, our only remaining problem would be uniting our own party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. But without NFP's support of 40 votes, we can never surpass the needed 166. Mr. Kibener's full support as well as our party is needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""With all due respect, I will take my leave from this meeting. I don't think I have anything to add anymore. I cannot associate with plans of tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[96]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""You could technically choose to take no action instead of signing or vetoing it. Without a proper definition of the process, it would be perfectly legal for you to ignore a bill indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""A pocket veto? You think that's clever, Mr. Galade but anybody who understands the law would see that hole. There is no way the reformists would be deceived by that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Petr coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's get into the details of our *reforms.*""]** — Mówca: **Player**
> ""Let's get into the details of our *reforms.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""We have established two points parallel to the demands of the reformists. I'll go through each of them and get your input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""But judging by what Mr. President is trying to do, I believe you can find common ground under Sollism. The problem will not be her but me, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I like the idea. What kind of loopholes do you have in mind?""]** — Mówca: **Player**
> ""I like the idea. What kind of loopholes do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""We can also try to "persuade" the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""We could limit the vetoes and package it as a great reform.""]** — Mówca: **Player**
> ""We could limit the vetoes and package it as a great reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I'll show them true leadership.""]** — Mówca: **Player**
> ""I'll show them true leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""No. We don't need to change the Article about vetoes.""]** — Mówca: **Player**
> ""No. We don't need to change the Article about vetoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Petr Vectern**
> ""And there is another key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""I like the idea. Maybe we could convince some of the reformists with that. But it all depends on the whole changes. It could be better not to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""We'll need to reach out to Judge Edmonds and her centrist wing. We can get three votes from them. They don't seem to be in the pocket of the Old Guard and they are definitely not reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[122]`
Mówca: **Petr Vectern**
> ""I agree. If we're going against the reformists anyway, why even bother giving concessions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[123]`
Mówca: **Nia Morgna**
> ""Okay then. Let's see what we're talking about here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""Well, we could define a process for the Assembly to override your vetoes with a supermajority. While this limits your veto capabilities, if we do not define a time limit for the President to act on a bill...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing will be completely against you. He already responded negatively in the committee meetings. But I think he will still be open to discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""We will also need to get more votes from the conservative judges. I believe Heron Garaci might be the weakest link of the Old Guards. He can help us get the 6 votes needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[127]`
Mówca: **Narrator**
> "She did not even try to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Yes, Mrs. Morgna. I am a Sollist.""]** — Mówca: **Player**
> ""Yes, Mrs. Morgna. I am a Sollist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Or better yet, we could change the article according to their demands but establish new loopholes for you to hold your veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[116]`
  - -> `[118]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Frankly, I don't care.""]** — Mówca: **Player**
> ""Frankly, I don't care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[131]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [DictatorKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""Anything else, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Come now, Mrs. Morgna. There's no need for that.""]** — Mówca: **Player**
> ""Come now, Mrs. Morgna. There's no need for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[134]`
Mówca: **Nia Morgna**
> ""I cannot allow a more authoritarian Constitution to be made. There is no way I can support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[133]`
  - -> `[140]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""However, the conservatives may be persuaded easier. The influence of Soll is still living strong in the party. They might follow you if they respect you as a strong leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[135]`
  - -> `[89]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""We'll start with Section 1. Reformists want your absolute veto power to be removed, or at least, limited. We could potentially give them what they want by limiting it. It wouldn't cause problems since we already have the majority in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Lucian cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""But we need more executive powers to bring bigger change.""]** — Mówca: **Player**
> ""But we need more executive powers to bring bigger change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President but that's the Sollist talking point. I won't be convinced by that argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[130]`
  - -> `[128]`

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. If you can get the unaligned to support us, along with our "loyalists" we'll have enough votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Nia Morgna**
> ""Of course, Mr. Vectern. But I already have a strong opinion about what it contains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[150]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
