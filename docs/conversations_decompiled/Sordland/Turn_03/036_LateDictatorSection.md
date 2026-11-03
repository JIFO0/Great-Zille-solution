# Sordland/Turn03/LateDictatorSection

- **ID konwersacji:** `36`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/036_LateDictatorSection.md`
- **Liczba węzłów dialogowych:** 198
- **Liczba wyborów gracza:** 62

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
- Węzeł `[2]` -> **[35] Sordland/Turn03/A_LateBriefing** (../Turn_03/035_A_LateBriefing.md), Węzeł `[11]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[14]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- Węzeł `[17]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`

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
  - -> `[93]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `35` (*Sordland/Turn03/A_LateBriefing*), Węzeł `[11]`

### Węzeł `[3]`
Mówca: **Petr Vectern**
> ""The reformists would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> ""I agree. This really has no importance for the new Constitution. Also, Soll was a hero for many Sords, whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Even Mr. Clavin and our party's reformist wing has no problems with the current law. USP would fully support that decision. I guess we could also persuade Mr. Kibener somehow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""We'll never be able to get PFJP to work with us. But if you can get Kesaro Kibener to work with you on this, our only remaining problem would be uniting our own party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[78]`
  - -> `[27]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[127]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[14]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""We should abolish this position.""]** — Mówca: **Player**
> ""We should abolish this position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Oh, so you want to use the same privilege after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""Yeah, that's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""I think some of the reformists really want to try him for his crimes during his terms. This law really has symbolic importance for both them and the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[67]`
  - -> `[19]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you think they can be persuaded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has it. He gave it to himself right after his military coup. This law is basically made to save the Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Lucian couldn't hide the surprised look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We should open their way and unite the left.""]** — Mówca: **Player**
> ""We should open their way and unite the left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""I don't know how, but sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds and Mr. Garaci may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be tough to bribe the Old Guards. Chief Justice Hawker will do their best to undermine us. But maybe we can get to Heron Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[33]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing will be completely against you. He already responded negatively in the committee meetings. I think he would be tough to break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""That's very bold, sir. But I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[37]`
Mówca: **Petr Vectern**
> ""However, the conservatives may be persuaded easier. The influence of Soll is still living strong in the party. They might follow you if they respect you as a strong leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[98]`
  - -> `[23]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I will instead give the President the ability to replace Judges as necessary.""]** — Mówca: **Player**
> ""I will instead give the President the ability to replace Judges as necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""If we can remove their immunity or define an impeachment process, we could clean the Court from Orso and his gang.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`
  - -> `[38]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""That is a fair concern. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Sure. You'll have some time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""And there is another key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""We can also try to "persuade" the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""We will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her and Judge Garaci, we might be able to get enough votes. They have major influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""A decrease is out of the question.""]** — Mówca: **Player**
> ""A decrease is out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""But of course, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
> ""Yeah, it should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""For now I'll move onto the next one: Term Limits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[66]`
  - -> `[76]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""According to the Constitution, Nia Morgna is a member of the Supreme Court, which means we already have one vote against this. I know two of the judges who are with her, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Unlikely to have 100% vote to pass. But I hear you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Because we could use it too.""]** — Mówca: **Player**
> ""Because we could use it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such the title then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[64]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""We will also need to get more votes from the conservative judges. I believe Heron Garaci might be the weakest link of the Old Guards. He can help us get the 6 votes needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""We could try to balance it with the reformists and make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[70]`
  - -> `[82]`
  - -> `[45]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Yes, we can make it dependent on enabling acts.""]** — Mówca: **Player**
> ""Yes, we can make it dependent on enabling acts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Mr. Ricter will probably demand that we remove them completely. I doubt that this would be enough to get him to sit down with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""We'll need to reach out to Judge Edmonds and her centrist wing. We can get three votes from them. They don't seem to be in the pocket of the Old Guard and they are definitely not reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, it could be destabilizing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. If you can get the unaligned to support us, along with our "loyalists" we'll have enough votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""So, we don't even have a vote in the Court?""]** — Mówca: **Player**
> ""So, we don't even have a vote in the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Who do you think would be willing to support these changes?""]** — Mówca: **Player**
> ""Who do you think would be willing to support these changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We should strengthen the decrees further, so they have priority over statute law.""]** — Mówca: **Player**
> ""We should strengthen the decrees further, so they have priority over statute law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""You could technically choose to take no action instead of signing or vetoing it. Without a proper definition of the process, it would be perfectly legal for you to ignore a bill indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[165]`
  - -> `[141]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> ""That is pretty powerful, indeed. That may scare some of our ministers too if you decide to *rule by decree.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I'm sure they can be bought.""]** — Mówca: **Player**
> ""I'm sure they can be bought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""We are at the 6th. This is about the presidential decrees. You already know that the reformists want them to be removed or limited. But I'm guessing you do not want any changes to your already powerful decrees, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Well, we could define a process for the Assembly to override your vetoes with a supermajority. While this limits your veto capabilities, if we do not define a time limit for the President to act on a bill...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""You'll have some time to think about your decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I'll show them true leadership.""]** — Mówca: **Player**
> ""I'll show them true leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""I agree. If we're going against the reformists anyway, why even bother giving concessions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[92]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: LateDictatorKeyFigureHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[192]`
  - -> `[10]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""That said, we should try to reach common ground with NFP and the conservative wing of our party to be able to propose such changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are expecting reforms. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We could add the Assembly in the process but make impeachment possible only with an absolute majority.""]** — Mówca: **Player**
> ""We could add the Assembly in the process but make impeachment only possible with an absolute majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""We'll get rid of this law entirely.""]** — Mówca: **Player**
> ""We'll get rid of this law entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""I like the idea. Maybe we could convince some of the reformists with that. But it all depends on the whole changes. It could be better not to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Let's mess with the Court, divide and conquer them.""]** — Mówca: **Player**
> ""Let's mess with the Court, divide and conquer them. They have it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""That's a good idea. That'd make impeachment close to impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""No. We don't need to change the Article about vetoes.""]** — Mówca: **Player**
> ""No. We don't need to change the Article about vetoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""We could try to make the impeachment process more difficult or entirely get rid of it. A change like this would give you free reign. However, that might be going a little too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""That is not bad idea. As long as we are the majority in the Assembly, that does not change too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""We could limit the vetoes and package it as a great reform.""]** — Mówca: **Player**
> ""We could limit the vetoes and package it as a great reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""Yes, we'll need the rip some of the sheep Judges out of the herd in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Can we pass it through the Supreme Court?""]** — Mówca: **Player**
> ""Can we pass it through the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""I'll move on to Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Can we possibly reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we possibly reach a two-thirds majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I like the idea. What kind of loopholes do you have in mind?""]** — Mówca: **Player**
> ""I like the idea. What kind of loopholes do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""Or better yet, we could change the article according to their demands but establish new loopholes for you to hold your veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[110]`
  - -> `[103]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""An increase on the other hand is more complex. NFP could be out of the Assembly but that would mean PFJP's seats would get higher too, if we're left with only two parties in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[123]`
  - -> `[78]`
  - -> `[27]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""We should keep using the threshold to our advantage.""]** — Mówca: **Player**
> ""We should keep using the threshold to our advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that anyway.""]** — Mówca: **Player**
> ""We can't just give away our majority like that anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""Well, we can't know these for sure. In the last elections, the Socialist Party and the Worker's Party of Bludia both had close to ten percent. One of them may very well increase their votes in the next years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[78]`
  - -> `[27]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [LateDictatorKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Let's get into the details of our *reforms.*""]** — Mówca: **Player**
> ""Let's get into the details of our *reforms.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It's fine as it is.""]** — Mówca: **Player**
> ""It's fine as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[129]`
Mówca: **Petr Vectern**
> ""I'm sure some of the reformists may support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
> ""So there is no reason to change this unless you want to sell this to the opposition parties. Sharing the power with the Assembly may make them sympathetic to you. This might be important for the NFP as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[117]`
  - -> `[111]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Did you already work on a plan?""]** — Mówca: **Player**
> ""Did you already work on a plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. But without NFP's support of 40 votes, we can never surpass the needed 166. Mr. Kibener's full support as well as our party is needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""I understand sir. We will address it later in that case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian pulled out a huge dossier from his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Yea, I am not so sure about this.""]** — Mówca: **Player**
> ""Yea, I am not so sure about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Let's proceed.""]** — Mówca: **Player**
> ""Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
> ""Excellent, and it gives us additional options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[131]`
  - -> `[161]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why on earth would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""But if we keep the same voter base, say a 15% threshold would keep NFP out of the Assembly. Leaving only two parties. Unless, Frens also falls back behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""We will be ensuring that the Supreme Court can no longer block constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Petr Vectern**
> ""Most of them won't. But we already talked about a possible agreement with Isabel which may change things. We could potentially get Heron and the Sollist judges as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""Moving on to Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
> ""Most people already find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[155]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""Yes. This will ensure that the Supreme Court will no longer have absolute power over legislation. We can persuade the other parties with this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[95]`
  - -> `[97]`
  - -> `[96]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""I have established nine points parallel to the demands of the reformists. I'll go through each of them and get your input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I'm sure they will.""]** — Mówca: **Player**
> ""I'm sure they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""But don't forget that the Socialist party and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""We will do what's necessary to get them in line.""]** — Mówca: **Player**
> ""We will do what's necessary to get them in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
> ""Some would but it would be possible to pass it, so it doesn't really matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""I don't see anything wrong with it.""]** — Mówca: **Player**
> ""I don't see anything wrong with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can unite it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can unite it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""I'll make sure they follow me.""]** — Mówca: **Player**
> ""I'll make sure they follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""Now if we are going with this direction, I'll need everybody to focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[172]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""A pocket veto? Wouldn't the reformist see through that?""]** — Mówca: **Player**
> ""A pocket veto? Wouldn't the reformist see through that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[170]`
Mówca: **Petr Vectern**
> ""I know you will. If you can get their support, we'll have enough votes to amend the Constitution, counting we have the support of Mr. Kibener too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""According to such change, constitutional amendments will still require the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[151]`
  - -> `[146]`
  - -> `[145]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""You have our attention.""]** — Mówca: **Player**
> ""You have our attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. All the party, and I mean, not even Albin wants us to decrease the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold to some degree.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold to some degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Petr Vectern**
> ""Two major left parties; the Socialist Party and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[177]`
Mówca: **Petr Vectern**
> ""Well, we don't. I doubt that any of the judges would support such changes just like that. But they can surely be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[178]`
**[WYBÓR GRACZA: ""We could simply increase it.""]** — Mówca: **Player**
> ""We could simply increase it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[174]`
  - -> `[175]`
  - -> `[55]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible. We could try working with them but it is simpler to keep the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> ""A decrease would definitely hurt our position in the future. If another party is elected to the Assembly, our projected vote would be closer to the real vote, which is significantly lesser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""10% seems already too high for many, sir. An increase may bring too much attention on the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""That's a possibility. It might make the reformists more willing to consider the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Petr Vectern**
> ""We will definitely need to work with some of the Old Guard aligned judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[85]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""We'll start with Section 1. Reformists want your absolute veto power to be removed, or at least, limited. We could potentially give them what they want by limiting it. It wouldn't cause problems since we already have the majority in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[187]`
Mówca: **Petr Vectern**
> ""This is a point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We can break the power of the Old Guards with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""I'll move on to the second point then. The new Constitution should remove the Supreme Court out of the constitutional amendment process. Not only popular, it would also strengthen our position against the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[190]`
Mówca: **Petr Vectern**
> ""I think we can reach out to Judge Edmonds. And in extension, Mr. Dalton and Mr. Martin. They aren't working together with the Old Guards, as far as we know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[191]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: Jump to: [LateDictatorKeyFigureHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[192]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[194]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[197]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
