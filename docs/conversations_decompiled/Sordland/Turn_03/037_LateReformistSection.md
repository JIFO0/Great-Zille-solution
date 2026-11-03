# Sordland/Turn03/LateReformistSection

- **ID konwersacji:** `37`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/037_LateReformistSection.md`
- **Liczba węzłów dialogowych:** 190
- **Liczba wyborów gracza:** 60

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01`
- `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[35] Sordland/Turn03/A_LateBriefing** (../Turn_03/035_A_LateBriefing.md), Węzeł `[7]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[39]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- Węzeł `[133]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`

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
  - -> `[41]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `35` (*Sordland/Turn03/A_LateBriefing*), Węzeł `[7]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""I agree, we should abolish this position.""]** — Mówca: **Player**
> ""I agree, we should abolish this position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Can we reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we reach a two-thirds majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""So, we only have 3 votes out of 11?""]** — Mówca: **Player**
> ""So, we only have 3 votes out of 11?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""I'm sorry, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[26]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""If you can get Frens Ricter to work with you on this, our only problem would be uniting our own party. We'll never be able to get NFP to work with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such a title, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[21]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. With PFJP's full support of 70 votes, we will easily surpass the needed 166.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Petr Vectern**
> ""The reformists would be completely behind that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Petr Vectern**
> ""Do you want to protect Tarquin Soll, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can do it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""We will convince the leads.""]** — Mówca: **Player**
> ""We will convince the leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing would be supporting you. He already weighed in heavily in the committee meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""It's just a title.""]** — Mówca: **Player**
> ""It's just a title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""However, the conservatives would be tough to break. The influence of Soll is still living strong in the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[27]`
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We will eventually remove his influence.""]** — Mówca: **Player**
> ""We will eventually remove his lasting influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""It's not unfair that former Presidents get some special treatment.""]** — Mówca: **Player**
> ""It's not unfair that former Presidents get some special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have in total?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Petr Vectern**
> ""We will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you really think they can be persuaded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. There are many unaligned people and some of your "loyalists" might decide to show their true faces too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""We'll need to break the power of the Old Guard within USP first. Most of the conservative wing are still loyal to their Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""Most of their support is necessary to be able to amend the Constitution. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Petr Vectern**
> ""And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Gloria Tory. She's well respected by the Sollists. She'll be our biggest obstacle in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""I also have reasons to think she might be in Orso's pocket. She will be tough to break, but we'll need her help to get the conservative support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""If we can reach an agreement with the reformists, we will be very strong in the Assembly to propose such change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has that title. He gave it to himself right after his military coup. This law is basically made to save the Colonel and it has a symbolic importance for Sordland because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Term limits are necessary.""]** — Mówca: **Player**
> ""Term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""We must get rid of this senseless law that protects him. He should be able to face justice for the atrocities that had taken place during his rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[6]`
  - -> `[7]`
  - -> `[9]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: LateReformistKeyFigureHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[187]`
  - -> `[57]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Is it possible to pass the Supreme Court?""]** — Mówca: **Player**
> ""Is it possible to pass this through the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""The Assembly should have oversight over the President.""]** — Mówca: **Player**
> ""The Assembly should have oversight over the President, it is the most democratic institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""That is a better strategy. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[51]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Not sure if it is correct to chastise the President this much though.""]** — Mówca: **Player**
> ""Not sure if it is correct to chastise the President this much though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[69]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""They should be able to be impeached, why do I get to be impeached but not them?""]** — Mówca: **Player**
> ""They should be able to be impeached, why do I get to be impeached but not them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Most people find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[67]`
Mówca: **Petr Vectern**
> ""Most reformists want the impeachment to be initiated by the Assembly. They think they do not have any power over potential rogue presidents that would abuse their power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[49]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Well, they need absolute immunity in theory. But look at what reality got us? We've got to deal with the most corrupt Chief Justice in the world, with no chance to deal with him!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Let's go through the draft.""]** — Mówca: **Player**
> ""Let's go through the draft details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""While I agree that the current court members are *problematic*, this is no way to resolve it. The law is supposed to ensure the judiciary's independence by giving legal protection so they can't be pressured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""I do not support taking away their power for yourself, Mr. President. The judiciary must be independent and long-lasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""What are the demands?""]** — Mówca: **Player**
> ""What are the final demands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""We will be ensuring that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
> ""Even Soll knew he had to leave, but we will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[84]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""I have suggested to bring some limitations to decrees regarding their applicability just for arguments sake. While we keep them, we should try to make sure that they will only be used in emergency situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I will take my time and seriously consider the options before settling on one.""]** — Mówca: **Player**
> ""I will take my time and seriously consider the options before settling on one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Yes, he did. But it took a long time.""]** — Mówca: **Player**
> ""Yes, he did. But it took a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""Uhm. The next one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I agree. People should be able to elect the same person if they want to.""]** — Mówca: **Player**
> ""I agree. People should be able to elect the same person if they want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""We should run-down each of the nine points from the draft, and get your input first. Mrs. Morgna will explain their demands as we go through them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""All means are to be considered in order to succeed.""]** — Mówca: **Player**
> ""All means are to be considered in order to succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""I agree. We can't allow somebody like Soll holding unto his seat for two decades again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""We can't allow somebody like Soll holding unto his seat for two decades again. We should establish limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""We will make sure the Old Guards won't control the Court any longer, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[94]`
Mówca: **Petr Vectern**
> ""Glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""We'll go through each of the nine points of the draft, and get your input. Mrs. Morgna will explain their demands as we go through them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""Next one is Section 7. Term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[100]`
  - -> `[43]`
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are aware about the current wind of change. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""Don't forget that the Socialist party and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[103]`
Mówca: **Petr Vectern**
> ""Yes, we will be collaboratively working on the specifics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
> ""Yes. This will ensure that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""They want us to include previously non-existing term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""According to the Constitution, Nia is a member of the Supreme Court, which means we already have one vote. I am sure she will back us even after what happened, her moral compass is too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> ""We'll start with Section 1. The new Constitution will fix the loopholes regarding the president's absolute veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""I don't think that's a wise idea to include in the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""Two of the judges are friends of hers, and of similar opinion about the reforms. Consider them onboard too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[125]`
  - -> `[124]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""We could also make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[115]`
  - -> `[117]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[114]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [LateReformistKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""We'll work with the reformists to limit the use of decrees.""]** — Mówca: **Player**
> ""We'll work with the reformists to limit the use of decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""We could even remove impeachment altogether.""]** — Mówca: **Player**
> ""We could even remove impeachment altogether, I can get total immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""Moving on to Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[119]`
Mówca: **Petr Vectern**
> ""Sure. You'll have a long time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""Even though Mr. Ricter put on a whole show about why vetoes should completely be removed, the committee has almost unanimously agreed on fixing the loopholes, thus limiting presidential vetoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""Frens will probably demand that we remove them completely. But he forgets that Sordland is a Presidential Republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""We should define a better impeachment process.""]** — Mówca: **Player**
> ""We should define a more refined impeachment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I'm sure the rest can be bribed.""]** — Mówca: **Player**
> ""I'm sure the rest can be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Who else would be willing to support reforms?""]** — Mówca: **Player**
> ""Who else would be willing to support reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""That's going a bit too far.""]** — Mówca: **Player**
> ""I think that's going a bit too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that.""]** — Mówca: **Player**
> ""We can't just give away our majority like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly and endanger Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
> ""I hope it works out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[131]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[122]`
  - -> `[116]`

### Węzeł `[132]`
Mówca: **Petr Vectern**
> ""I agree with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[133]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
> ""I know it is a delicate matter, sir. But you still have time to think about these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""My suggestion is to add a clause detailing the methods the Assembly may override a veto with some sort of a super-majority. One person should never be able to block the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[155]`
  - -> `[153]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""Section 6. This is about the presidential decrees. Reformists demand more limitations to the President's executive powers. Mr. Ricter has demanded them to be completely removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""There is definitely a demand to involve the Assembly in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[91]`
  - -> `[137]`

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""Mr. Ricter and his PFJP definitely wants to see change on this topic. They find our 10% threshold to be antidemocratic. Which is something I disagree with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
> ""It could be destabilising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""Most of them won't. But we already talked about my vote and a possible agreement with Isabel which may change things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
> ""On to Section 2. The new Constitution will remove the Supreme Court out of the constitutional amendment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""We can't just bribe the Old Guards. Judge Garaci and the Chief Justice Hawker will do their best to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> ""I think Judge Edmonds can be persuaded. And in extension, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""This is yet another point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We all know most of the judges are his sheep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""Three votes, yes. But I believe that Judge Edmonds can be persuaded as well. She and two other judges, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
> ""Yes, we have the Socialist party and the Worker's Party of Bludia getting more than five percent vote in the last elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""They will not be allowed to dictate the negotiations.""]** — Mówca: **Player**
> ""They will not be allowed to dictate the negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
> ""Of course that would also mean that USP might lose its majority in the Assembly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[159]`
  - -> `[128]`
  - -> `[129]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""The loopholes give the President too much power.""]** — Mówca: **Player**
> ""The loopholes give the President too much power which could be misused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[156]`
**[WYBÓR GRACZA: ""I stand in agreement with Mr. Ricter. The vetoes should be removed.""]** — Mówca: **Player**
> ""I stand in agreement with Mr. Ricter. The vetoes should be removed altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""If our own democracy is the reason of our downfall, we will have to accept it.""]** — Mówca: **Player**
> ""If our own democracy is the reason of our downfall, we will have to accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
> ""They weren't really blinded by the Sollist ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""Maybe. But Mr. Ricter doesn't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""If the entire package is to their liking, I don't think Frens will resist his own. He wouldn't say no to such major changes just because of a few small details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[163]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. All the party, and I mean, not even Albin wants us to decrease the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[168]`
  - -> `[170]`
  - -> `[172]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""But we might try and bribe the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""But the high threshold is the reason why Sordish politics has become so isolated.""]** — Mówca: **Player**
> ""But the high threshold is the reason why Sordish politics has become isolated to this degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[167]`
Mówca: **Petr Vectern**
> ""I'm sure the reformists would completely support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold for better representation.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold for better representation in our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""Whatever you decide it's important to get a balanced picture. We will be making history by changing the '29 Constitution of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""This is out of the question.""]** — Mówca: **Player**
> ""This is out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""This is one of the starting points of the whole discussion about changing the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Petr Vectern**
> ""You're right. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP was barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[175]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[176]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[177]`
Mówca: **Petr Vectern**
> ""I agree. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP is barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[178]`
Mówca: **Petr Vectern**
> ""Yes, those three don't seem to be working directly with the Chief Justice Hawker. If we can get to Isabel Edmonds, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""That was my suggestion as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""I don't think this is up to discussion for any reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[181]`
Mówca: **Petr Vectern**
> ""Constitutional amendments will still be very difficult to accomplish, particularly because we will keep the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[102]`
  - -> `[55]`

### Węzeł `[182]`
Mówca: **Petr Vectern**
> ""Mr. Clavin and our party's reformist wing has no problems with the current law. I'm sure PFJP can be persuaded too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[183]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [LateReformistKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[184]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[186]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[189]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
