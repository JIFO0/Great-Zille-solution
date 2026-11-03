# Sordland/Turn02/ReformistSection

- **ID konwersacji:** `17`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/017_ReformistSection.md`
- **Liczba węzłów dialogowych:** 113
- **Liczba wyborów gracza:** 26

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
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[14] Sordland/Turn02/A_ReformBriefing** (../Turn_02/014_A_ReformBriefing.md), Węzeł `[62]`
- Węzeł `[29]` -> **[16] Sordland/Turn02/AutocratSection** (../Turn_02/016_AutocratSection.md), Węzeł `[48]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 4

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Petr Vectern): `Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- Węzeł `[32]` (Petr Vectern): `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- Węzeł `[65]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- Węzeł `[90]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`

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
  - -> `[8]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `14` (*Sordland/Turn02/A_ReformBriefing*), Węzeł `[62]`

### Węzeł `[3]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""I will support the new Constitution.""]** — Mówca: **Player**
> ""I will support the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""That's great to hear, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""Most people find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
Mówca: **Nia Morgna**
> ""We will be ensuring that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""If we can fully reach an agreement with the reformists, we will be very strong in the Assembly to propose the change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""Yes. This will ensure that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""We can't just bribe the Old Guards. Judge Garaci and the Chief Justice Hawker will do their best to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[13]`
Mówca: **Nia Morgna**
> ""Most of them won't. But we already talked about my vote and a possible agreement with Isabel which may change things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Well, regardless of what Mr. Rayne decides, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Nia Morgna**
> ""I'll present your input to the committee. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""We will eventually remove his influence.""]** — Mówca: **Player**
> ""We will eventually remove his lasting influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: ReformistKeyFigureHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[107]`
  - -> `[41]`

### Węzeł `[22]`
Mówca: **Nia Morgna**
> ""We'll need to break the power of the Old Guard within USP first. Most of the conservative wing are still loyal to their Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""Now we should wrap this up. Since we evaluated the points, I'd like to hear your input, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [ReformistKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Nia Morgna**
> ""This is yet another point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We all know most of the judges are still his pawns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""I won't support these reforms. We'll work with the Old Guard to block them.""]** — Mówca: **Player**
> ""I won't support these reforms. We'll work with the Old Guard to block them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Can we reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we reach a two-thirds majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have in total?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [BackToAutocrat])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `16` (*Sordland/Turn02/AutocratSection*), Węzeł `[48]`

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Even though Mr. Ricter put on a whole show about why vetoes should completely be removed, the committee has almost unanimously agreed on fixing the loopholes, thus limiting presidential vetoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Is it possible to pass the Supreme Court?""]** — Mówca: **Player**
> ""Is it possible to pass this through the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I'm sure the rest can be bribed.""]** — Mówca: **Player**
> ""I'm sure the rest can be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""If you can get Frens Ricter to work with you on this, our only problem would be uniting our own party. We'll never be able to get NFP to work with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Apart from these two critical points they have other major demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Reformist Branch Start)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Who else would be willing to support reforms?""]** — Mówca: **Player**
> ""Who else would be willing to support reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""So, we only have 3 votes out of 11?""]** — Mówca: **Player**
> ""So, we only have 3 votes out of 11?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[40]`
Mówca: **Nia Morgna**
> ""They want to reform the appointment procedures of the ministers. Mr. Ricter clarified that the Assembly should have a say in the formation of the council of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[55]`

### Węzeł `[43]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Well, Mr. Ricter also talked about abolishing the Member of Honor rights of Tarquin Soll that gives him absolute immunity and makes him a permanent member of the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""That is something that a majority in our party also supports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""Well... That one is a controversial one. I doubt that USP would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. There are many unaligned people and some of your "loyalists" might decide to show their true faces too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""Immunity of the Justices, the impeachment of the president, limiting the power of the presidential decrees... All of this came up during the committee meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you really think they can be persuaded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""Yes, reformists expect big reforms while our faction in the USP are not very keen on pushing changes that are too great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can do it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""I'd say keeping everything in the middle ground is the safest bet. No need to agitate anyone too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[58]`
  - -> `[60]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Let's go through the draft.""]** — Mówca: **Player**
> ""Let's go through the draft details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I disagree. We'll push for comprehensive reforms.""]** — Mówca: **Player**
> ""I disagree. We'll push for comprehensive reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""But we might try and bribe the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I agree. Let's keep the changes small and manageable.""]** — Mówca: **Player**
> ""I agree. Let's keep the changes small and manageable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""Two of the judges are friends of mine, and of similar opinion about the reforms. Consider them with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[37]`
  - -> `[33]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""They have valid concerns that we need to look at.""]** — Mówca: **Player**
> ""They have valid concerns that we need to look at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`

### Węzeł `[62]`
Mówca: **Nia Morgna**
> ""I'm with you on this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Nia Morgna**
> ""As long as we address the main issues, I also agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""I'll keep working with them and keep you updated, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[84]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. With PFJP's full support of 70 votes, we will easily surpass the needed 166.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""What are the demands?""]** — Mówca: **Player**
> ""What are the final demands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""They will not be allowed to dictate the negotiations.""]** — Mówca: **Player**
> ""They will not be allowed to dictate the negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing would be supporting you. He already weighed in heavily in the committee meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""Constitutional amendments will still be very difficult to accomplish with a reform like this, particularly because we will keep the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[76]`
  - -> `[83]`
  - -> `[78]`

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""I think Judge Edmonds can be persuaded. And in extension, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""However, the conservatives would be tough to break. The influence of Soll is still living strong in the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[28]`
  - -> `[51]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""They weren't really blinded by the Sollist ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[79]`
Mówca: **Nia Morgna**
> ""Three votes, yes. But I believe that Judge Edmonds can be persuaded as well. She and two other judges, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""We'll go through each of the main demands of the committee, and get your input. Mrs. Morgna can explain them further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The loopholes give the President too much power.""]** — Mówca: **Player**
> ""The loopholes give the President too much power which could be misused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""We'll start with the first *red line*. The new Constitution will fix the loopholes regarding the president's absolute veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We will convince the leads.""]** — Mówca: **Player**
> ""We will convince the leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""My suggestion is to add a clause detailing the methods the Assembly may override a veto with some sort of a super-majority. One person should never be able to block the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[81]`
  - -> `[70]`

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[87]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [ReformistKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""All means are to be considered in order to succeed.""]** — Mówca: **Player**
> ""All means are to be considered in order to succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""The second one is about the judiciary. The new Constitution will remove the Supreme Court's right to vote on legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""According to the Constitution, I am a member of the Supreme Court, which means we already have one vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""We should run-down each of the main demands of the committee, and get your input first. Mrs. Morgna can explain them further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[97]`
Mówca: **Petr Vectern**
> ""I don't think this is up to discussion for any reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""I also have reasons to think she might be in Orso's pocket. She will be tough to break, but we'll need her help to get the conservative support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""Yes, those three don't seem to be working directly with the Chief Justice Hawker. If we can get to Isabel Edmonds, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""I stand in agreement with Mr. Ricter. The vetoes should be removed.""]** — Mówca: **Player**
> ""I stand in agreement with Mr. Ricter. The vetoes should be removed altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""This is one of the starting points of the whole discussion about changing the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[103]`
Mówca: **Nia Morgna**
> ""Whatever you decide it's important to get a balanced picture. We will be making history by changing the '29 Constitution of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[104]`
Mówca: **Petr Vectern**
> ""Most of their support is necessary to be able to amend the Constitution. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""Gloria Tory. She's well respected by the Sollists. She'll be our biggest obstacle in the Assembly and her demands will be extensive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[107]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[109]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
