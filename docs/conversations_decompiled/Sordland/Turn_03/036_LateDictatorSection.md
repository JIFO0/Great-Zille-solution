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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Yes, he is a hero for Sordland.""** | `[4]` **Petr Vectern**: ""I agree. This really has no imp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Petr Vectern**: ""You're right."" |
| `[6]` | **""Regardless of him, I see no problem with having a special title for great heroes.""** | `[4]` **Petr Vectern**: ""I agree. This really has no imp..."<br>`[65]` **Petr Vectern**: ""That would be enough to hold hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Petr Vectern**: ""You're right."" |
| `[15]` | **""We should abolish this position.""** | `[22]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Petr Vectern**: ""The reformists would like that."" |
| `[16]` | **""No, I think we should respect this law.""** | `[22]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Petr Vectern**: ""I agree. This really has no imp..." |
| `[19]` | **""Every President should gain that title after their term.""** | `[22]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Petr Vectern**: ""Oh, so you want to use the same..." |
| `[23]` | **""Do you think they can be persuaded?""** | `[37]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Petr Vectern**: ""I'm sure it's possible. But reg..." |
| `[27]` | **""We should open their way and unite the left.""** | `[9]` **Petr Vectern**: ""You would be opening their way ..."<br>`[120]` **Petr Vectern**: ""An increase on the other hand i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Lucian couldn't hide the surpris..." |
| `[30]` | **""After pushing aggressive changes, I may need the same immunity.""** | `[18]` **Petr Vectern**: ""Oh, so you want to use the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Petr Vectern**: ""Yeah, that's fair."" |
| `[38]` | **""Maybe we shouldn't make the Supreme Court our enemies just yet.""** | `[42]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""That is a fair concern. We'll n..." |
| `[39]` | **""We should respect their immunity.""** | `[42]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: ""That might be the best thing to..." |
| `[40]` | **""I will instead give the President the ability to replace Judges as necessary.""** | `[42]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucian Galade**: ""That's very bold, sir. But I li..." |
| `[41]` | **""We should crush the Old Guards to clear ways for further reforms.""** | `[42]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Petr Vectern**: ""Hell yes, we should."" |
| `[45]` | **""I may need to think a bit longer about this.""** | `[69]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Petr Vectern**: ""Sure. You'll have some time bef..." |
| `[55]` | **""A decrease is out of the question.""** | `[179]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Petr Vectern**: ""Yeah, it should be."" |
| `[58]` | **""Uh-oh.""** | `[59]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""Yes. Tarquin Soll governed for ..." |
| `[64]` | **""Because we could use it too.""** | `[65]` **Petr Vectern**: ""That would be enough to hold hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Petr Vectern**: ""Unlikely to have 100% vote to p..." |
| `[66]` | **""Term Limits?""** | `[59]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""Yes. Tarquin Soll governed for ..." |
| `[67]` | **""We could keep the title but take away the immunity clause.""** | `[22]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Petr Vectern**: ""That would be enough to hold hi..." |
| `[70]` | **""Yes, we can make it dependent on enabling acts.""** | `[69]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucian Galade**: ""Mr. Ricter will probably demand..." |
| `[72]` | **""I don't think presidential decrees need any reforms.""** | `[69]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: ""Me neither. I think it's import..." |
| `[76]` | **""I don't aim to leave any time soon. We keep the unlimited terms.""** | `[59]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: ""I agree, we could keep that in."" |
| `[78]` | **""We can't allow communists to enter the Assembly.""** | `[9]` **Petr Vectern**: ""You would be opening their way ..."<br>`[120]` **Petr Vectern**: ""An increase on the other hand i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucian Galade**: ""Yes, it could be destabilizing."" |
| `[80]` | **""So, we don't even have a vote in the Court?""** | `[185]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Petr Vectern**: ""Well, we don't. I doubt that an..." |
| `[81]` | **""Who do you think would be willing to support these changes?""** | `[185]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Petr Vectern**: ""I think we can reach out to Jud..." |
| `[82]` | **""We should strengthen the decrees further, so they have priority over statute law.""** | `[69]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Lucian Galade**: ""That is pretty powerful, indeed..." |
| `[85]` | **""I'm sure they can be bought.""** | `[185]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Lucian Galade**: ""I'm afraid it would be tough to..." |
| `[90]` | **""I'll show them true leadership.""** | `[37]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Petr Vectern**: ""I know you will. If you can get..." |
| `[95]` | **""What if we don't succeed? The Court can have me impeached for this.""** | `[158]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lucian Galade**: ""Yes, they are already trying to..." |
| `[96]` | **""We could add the Assembly in the process but make impeachment possible only with ..."** | `[158]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Lucian Galade**: ""That's a good idea. That'd make..." |
| `[97]` | **""We'll get rid of this law entirely.""** | `[158]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lucian Galade**: ""I see."" |
| `[98]` | **""How many votes do they have?""** | `[37]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Petr Vectern**: ""The conservatives have around 4..." |
| `[100]` | **""Let's mess with the Court, divide and conquer them.""** | `[158]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: ""Yes, we'll need the rip some of..." |
| `[102]` | **""This is already what we wanted to do.""** | `[171]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Petr Vectern**: ""Yes. This will ensure that the ..." |
| `[103]` | **""No. We don't need to change the Article about vetoes.""** | `[118]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Petr Vectern**: ""I agree. If we're going against..." |
| `[110]` | **""We could limit the vetoes and package it as a great reform.""** | `[118]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Petr Vectern**: ""I like the idea. Maybe we could..." |
| `[111]` | **""I agree. We should involve the Assembly more in the process.""** | `[130]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: ""Some reformists suggested that ..." |
| `[113]` | **""Can we pass it through the Supreme Court?""** | `[93]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[62]` **Lucian Galade**: ""According to the Constitution, ..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false` | *Brak zmian stanu* | `[133]` **Lucian Galade**: ""They are the biggest obstacle. ..." |
| `[115]` | **""Can we possibly reach a two-thirds majority in the Assembly?""** | `[93]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[62]` **Lucian Galade**: ""According to the Constitution, ..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false` | *Brak zmian stanu* | `[8]` **Lucian Galade**: ""We'll never be able to get PFJP..." |
| `[116]` | **""I like the idea. What kind of loopholes do you have in mind?""** | `[118]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""Well, we could define a process..." |
| `[117]` | **""We could introduce a confidence vote.""** | `[130]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Lucian Galade**: ""That is not bad idea. As long a..." |
| `[121]` | **""We should keep using the threshold to our advantage.""** | `[120]` **Petr Vectern**: ""An increase on the other hand i..."<br>`[124]` **Lucian Galade**: ""Well, we can't know these for s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Lucian Galade**: ""I agree, sir."" |
| `[122]` | **""Don't worry. With these reforms, we will be even more popular.""** | `[9]` **Petr Vectern**: ""You would be opening their way ..."<br>`[124]` **Lucian Galade**: ""Well, we can't know these for s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Petr Vectern**: ""I hope so."" |
| `[123]` | **""We can't just give away our majority like that anyway.""** | `[9]` **Petr Vectern**: ""You would be opening their way ..."<br>`[120]` **Petr Vectern**: ""An increase on the other hand i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Petr Vectern**: ""Of course not."" |
| `[127]` | **""Let's get into the details of our *reforms.*""** | `[3]` **Petr Vectern**: ""The reformists would like that.""<br>`[13]` **Petr Vectern**: ""You're right.""<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[119]` **Lucian Galade**: ""Of course."" |
| `[128]` | **""It's fine as it is.""** | `[130]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lucian Galade**: ""I guess so."" |
| `[131]` | **""They will surely support a just cause for the country and its future.""** | `[144]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Lucian looked sceptical." |
| `[135]` | **""Did you already work on a plan?""** | `[3]` **Petr Vectern**: ""The reformists would like that.""<br>`[13]` **Petr Vectern**: ""You're right.""<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[126]` **Lucian Galade**: ""Yes, Mr. President."" |
| `[141]` | **""Yea, I am not so sure about this.""** | `[83]` **Lucian Galade**: ""You could technically choose to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lucian Galade**: ""I understand sir. We will addre..." |
| `[142]` | **""Let's proceed.""** | `[168]` **Lucian Galade**: ""Now if we are going with this d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lucian Galade**: ""I have established nine points ..." |
| `[145]` | **""And what good does that do to us?""** | `[171]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Petr Vectern**: ""We will be ensuring that the Su..." |
| `[146]` | **""We need the Court to even pass this change. Why on earth would they support this?""** | `[171]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Petr Vectern**: ""Most of them won't. But we alre..." |
| `[151]` | **""I can't disagree with that.""** | `[171]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Lucian Galade**: ""Glad to hear it, sir."" |
| `[161]` | **""I'm sure they will.""** | `[144]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Lucian looked sceptical." |
| `[163]` | **""We will do what's necessary to get them in line.""** | `[144]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "Nia was taken aback by the state..." |
| `[165]` | **""I don't see anything wrong with it.""** | `[83]` **Lucian Galade**: ""You could technically choose to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lucian Galade**: ""Excellent, and it gives us addi..." |
| `[166]` | **""We did it before for the elections. We can unite it again.""** | `[159]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[167]` | **""I'll make sure they follow me.""** | `[159]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[169]` | **""A pocket veto? Wouldn't the reformist see through that?""** | `[83]` **Lucian Galade**: ""You could technically choose to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lucian Galade**: ""Some would but it would be poss..." |
| `[172]` | **""You have our attention.""** | `[168]` **Lucian Galade**: ""Now if we are going with this d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lucian Galade**: ""I have established nine points ..." |
| `[174]` | **""We should definitely work to decrease the threshold to some degree.""** | `[179]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucian Galade**: ""That's a possibility. It might ..." |
| `[175]` | **""Do you think it would really hurt the party?""** | `[179]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Lucian Galade**: ""A decrease would definitely hur..." |
| `[178]` | **""We could simply increase it.""** | `[179]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Lucian Galade**: ""10% seems already too high for ..." |

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
  - -> `[93]` (*Lucian Galade: ""That said, we should try to reach common ground with NFP..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)

### Węzeł `[3]`
Mówca: **Petr Vectern**
> ""The reformists would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> ""I agree. This really has no importance for the new Constitution. Also, Soll was a hero for many Sords, whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""Yes, he is a hero for Sordland.""*)
  - -> `[6]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""You're right.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern), `[65]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""You're right.""*)

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Even Mr. Clavin and our party's reformist wing has no problems with the current law. USP would fully support that decision. I guess we could also persuade Mr. Kibener somehow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""We'll never be able to get PFJP to work with us. But if you can get Kesaro Kibener to work with you on this, our only remaining problem would be uniting our own party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""We need the majority of our 130 seats in the Assembly to..."*)

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Don't worry. With these reforms, we will be even more po..."*)
  - -> `[123]` (*Player: ""We can't just give away our majority like that anyway.""*)
  - -> `[78]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[27]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""Did you already work on a plan?""*)
  - -> `[127]` (*Player: ""Let's get into the details of our *reforms.*""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "Jump to: [LateDictatorKeyFigureHub]"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""We should abolish this position.""]** — Mówca: **Player**
> ""We should abolish this position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Petr Vectern: ""The reformists would like that.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: ""I agree. This really has no importance for the new Const..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "Jump to: [LateDictatorKeyFigureHub]"*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""Oh, so you want to use the same privilege after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""After pushing aggressive changes, I may need the same im..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: ""Oh, so you want to use the same privilege after all.""*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Petr Vectern: ""Of course, according to the ratio of the party's in gove..."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""Yeah, that's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""I think some of the reformists really want to try him for his crimes during his terms. This law really has symbolic importance for both them and the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""We should abolish this position.""*)
  - -> `[16]` (*Player: ""No, I think we should respect this law.""*)
  - -> `[67]` (*Player: ""We could keep the title but take away the immunity clause.""*)
  - -> `[19]` (*Player: ""Every President should gain that title after their term.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you think they can be persuaded?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Petr Vectern: ""I'm sure it's possible. But regardless of my opinion, we..."*)

### Węzeł `[24]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has it. He gave it to himself right after his military coup. This law is basically made to save the Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""I think some of the reformists really want to try him fo..."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: ""That's why only Tarquin Soll has it. He gave it to himse..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Lucian couldn't hide the surprised look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""I don't know how, but sure.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We should open their way and unite the left.""]** — Mówca: **Player**
> ""We should open their way and unite the left.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern), `[120]` (Petr Vectern), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Lucian couldn't hide the surprised look on his face."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""According to the Constitution, the Member of Honor not o..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""I don't know how, but sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""Yeah, that's fair.""*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds and Mr. Garaci may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be tough to bribe the Old Guards. Chief Justice Hawker will do their best to undermine us. But maybe we can get to Heron Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""We can also try to "persuade" the centrists of the Court..."*)

### Węzeł `[33]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing will be completely against you. He already responded negatively in the committee meetings. I think he would be tough to break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Petr Vectern: ""However, the conservatives may be persuaded easier. The ..."*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""That's very bold, sir. But I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[37]`
Mówca: **Petr Vectern**
> ""However, the conservatives may be persuaded easier. The influence of Soll is still living strong in the party. They might follow you if they respect you as a strong leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I'll show them true leadership.""*)
  - -> `[98]` (*Player: ""How many votes do they have?""*)
  - -> `[23]` (*Player: ""Do you think they can be persuaded?""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""That is a fair concern. We'll need to sway some of their..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: ""That might be the best thing to do for now. If we agitat..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I will instead give the President the ability to replace Judges as necessary.""]** — Mówca: **Player**
> ""I will instead give the President the ability to replace Judges as necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""That's very bold, sir. But I like it.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""Hell yes, we should.""*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""If we can remove their immunity or define an impeachment process, we could clean the Court from Orso and his gang.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""We should respect their immunity.""*)
  - -> `[40]` (*Player: ""I will instead give the President the ability to replace..."*)
  - -> `[41]` (*Player: ""We should crush the Old Guards to clear ways for further..."*)
  - -> `[38]` (*Player: ""Maybe we shouldn't make the Supreme Court our enemies ju..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""That is a fair concern. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Sure. You'll have some time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""Sure. You'll have some time before we start writing the ..."*)

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: ""If we can remove their immunity or define an impeachment..."*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""It's the question about the immunity of the Judges. Whil..."*)

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""And there is another key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""We can also try to "persuade" the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""Yes, we'll need to talk to Judge Edmonds. If we can get ..."*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""We will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Now I'll move unto the 8th Section. We are reaching the ..."*)

### Węzeł `[53]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""We will leave it to the President to decide.""*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her and Judge Garaci, we might be able to get enough votes. They have major influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""According to the Constitution, Nia Morgna is a member of..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""A decrease is out of the question.""]** — Mówca: **Player**
> ""A decrease is out of the question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: ""Yeah, it should be.""*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""But of course, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> ""Yeah, it should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Petr Vectern: ""Two major left parties; the Socialist Party and the Work..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""Yes. Tarquin Soll governed for twenty years. It seems hi..."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""For now I'll move onto the next one: Term Limits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""Uh-oh.""*)
  - -> `[66]` (*Player: ""Term Limits?""*)
  - -> `[76]` (*Player: ""I don't aim to leave any time soon. We keep the unlimite..."*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""But of course, I don't.""*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""According to the Constitution, Nia Morgna is a member of the Supreme Court, which means we already have one vote against this. I know two of the judges who are with her, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = ..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Unlikely to have 100% vote to pass. But I hear you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Because we could use it too.""]** — Mówca: **Player**
> ""Because we could use it too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: ""Unlikely to have 100% vote to pass. But I hear you.""*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such the title then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)
  - -> `[64]` (*Player: ""Because we could use it too.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""Yes. Tarquin Soll governed for twenty years. It seems hi..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: ""That would be enough to hold him accountable for his act..."*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""We will also need to get more votes from the conservative judges. I believe Heron Garaci might be the weakest link of the Old Guards. He can help us get the 6 votes needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""According to the Constitution, Nia Morgna is a member of..."*)

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""We could try to balance it with the reformists and make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""I don't think presidential decrees need any reforms.""*)
  - -> `[70]` (*Player: ""Yes, we can make it dependent on enabling acts.""*)
  - -> `[82]` (*Player: ""We should strengthen the decrees further, so they have p..."*)
  - -> `[45]` (*Player: ""I may need to think a bit longer about this.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Yes, we can make it dependent on enabling acts.""]** — Mówca: **Player**
> ""Yes, we can make it dependent on enabling acts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""Mr. Ricter will probably demand that we remove them comp..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""Mr. Ricter will probably demand that we remove them completely. I doubt that this would be enough to get him to sit down with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: ""Me neither. I think it's important that the President ca..."*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""We'll need to reach out to Judge Edmonds and her centrist wing. We can get three votes from them. They don't seem to be in the pocket of the Old Guard and they are definitely not reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""We will also need to get more votes from the conservativ..."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, it could be destabilizing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""I agree, we could keep that in.""*)

### Węzeł `[77]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""And there is one key person who can help us get their su..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern), `[120]` (Petr Vectern), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""Yes, it could be destabilizing.""*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. If you can get the unaligned to support us, along with our "loyalists" we'll have enough votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: ""So we need as many of the conservatives to support us. A..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""So, we don't even have a vote in the Court?""]** — Mówca: **Player**
> ""So, we don't even have a vote in the Court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Petr Vectern: ""Well, we don't. I doubt that any of the judges would sup..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Who do you think would be willing to support these changes?""]** — Mówca: **Player**
> ""Who do you think would be willing to support these changes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Petr Vectern: ""I think we can reach out to Judge Edmonds. And in extens..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We should strengthen the decrees further, so they have priority over statute law.""]** — Mówca: **Player**
> ""We should strengthen the decrees further, so they have priority over statute law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: ""That is pretty powerful, indeed. That may scare some of ..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""You could technically choose to take no action instead of signing or vetoing it. Without a proper definition of the process, it would be perfectly legal for you to ignore a bill indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""A pocket veto? Wouldn't the reformist see through that?""*)
  - -> `[165]` (*Player: ""I don't see anything wrong with it.""*)
  - -> `[141]` (*Player: ""Yea, I am not so sure about this.""*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> ""That is pretty powerful, indeed. That may scare some of our ministers too if you decide to *rule by decree.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I'm sure they can be bought.""]** — Mówca: **Player**
> ""I'm sure they can be bought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""I'm afraid it would be tough to bribe the Old Guards. Ch..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""We are at the 6th. This is about the presidential decrees. You already know that the reformists want them to be removed or limited. But I'm guessing you do not want any changes to your already powerful decrees, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: ""We could try to balance it with the reformists and make ..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""We are at the 6th. This is about the presidential decree..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Well, we could define a process for the Assembly to override your vetoes with a supermajority. While this limits your veto capabilities, if we do not define a time limit for the President to act on a bill...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""You could technically choose to take no action instead o..."*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""You'll have some time to think about your decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Lucian continued with the next section."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I'll show them true leadership.""]** — Mówca: **Player**
> ""I'll show them true leadership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Petr Vectern: ""I know you will. If you can get their support, we'll hav..."*)

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""I agree. If we're going against the reformists anyway, why even bother giving concessions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""You could technically choose to take no action instead o..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LateDictatorKeyFigureHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""That said, we should try to reach common ground with NFP and the conservative wing of our party to be able to propose such changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "LateDictatorKeyFigureHub"*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are expecting reforms. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""Yes, they are already trying to hit you since they are e..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We could add the Assembly in the process but make impeachment possible only with an absolute majority.""]** — Mówca: **Player**
> ""We could add the Assembly in the process but make impeachment only possible with an absolute majority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: ""That's a good idea. That'd make impeachment close to imp..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""We'll get rid of this law entirely.""]** — Mówca: **Player**
> ""We'll get rid of this law entirely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""I see.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: ""The conservatives have around 40 seats. If you can get t..."*)

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""I like the idea. Maybe we could convince some of the reformists with that. But it all depends on the whole changes. It could be better not to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""You could technically choose to take no action instead o..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Let's mess with the Court, divide and conquer them.""]** — Mówca: **Player**
> ""Let's mess with the Court, divide and conquer them. They have it coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: ""Yes, we'll need the rip some of the sheep Judges out of ..."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""That's a good idea. That'd make impeachment close to impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: ""Yes. This will ensure that the Supreme Court will no lon..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""No. We don't need to change the Article about vetoes.""]** — Mówca: **Player**
> ""No. We don't need to change the Article about vetoes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Petr Vectern: ""I agree. If we're going against the reformists anyway, w..."*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""We could try to make the impeachment process more difficult or entirely get rid of it. A change like this would give you free reign. However, that might be going a little too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Petr Vectern: ""This law is particularly dangerous for you in this case...."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucian Galade: ""So there is no reason to change this unless you want to ..."*)

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Petr Vectern: ""An increase on the other hand is more complex. NFP could..."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""That is not bad idea. As long as we are the majority in the Assembly, that does not change too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Petr Vectern: ""I'm sure some of the reformists may support that.""*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Petr Vectern: ""Even Mr. Clavin and our party's reformist wing has no pr..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""We could limit the vetoes and package it as a great reform.""]** — Mówca: **Player**
> ""We could limit the vetoes and package it as a great reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Petr Vectern: ""I like the idea. Maybe we could convince some of the ref..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""Some reformists suggested that the Assembly should nomin..."*)

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""Yes, we'll need the rip some of the sheep Judges out of the herd in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Can we pass it through the Supreme Court?""]** — Mówca: **Player**
> ""Can we pass it through the Supreme Court?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Lucian Galade), `[62]` (Lucian Galade), `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: ""They are the biggest obstacle. Even if we pass the Assem..."*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""I'll move on to Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: ""This is regarding the appointment of ministers. Currentl..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Can we possibly reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we possibly reach a two-thirds majority in the Assembly?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Lucian Galade), `[62]` (Lucian Galade), `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: ""We'll never be able to get PFJP to work with us. But if ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I like the idea. What kind of loopholes do you have in mind?""]** — Mówca: **Player**
> ""I like the idea. What kind of loopholes do you have in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Well, we could define a process for the Assembly to over..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: ""That is not bad idea. As long as we are the majority in ..."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""Or better yet, we could change the article according to their demands but establish new loopholes for you to hold your veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""I like the idea. What kind of loopholes do you have in m..."*)
  - -> `[110]` (*Player: ""We could limit the vetoes and package it as a great refo..."*)
  - -> `[103]` (*Player: ""No. We don't need to change the Article about vetoes.""*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Lucian pulled out a huge dossier from his briefcase."*)

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""An increase on the other hand is more complex. NFP could be out of the Assembly but that would mean PFJP's seats would get higher too, if we're left with only two parties in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""We should keep using the threshold to our advantage.""*)
  - -> `[123]` (*Player: ""We can't just give away our majority like that anyway.""*)
  - -> `[78]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[27]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""We should keep using the threshold to our advantage.""]** — Mówca: **Player**
> ""We should keep using the threshold to our advantage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Petr Vectern), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucian Galade: ""I agree, sir.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""I hope so.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that anyway.""]** — Mówca: **Player**
> ""We can't just give away our majority like that anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern), `[120]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Petr Vectern: ""Of course not.""*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""Well, we can't know these for sure. In the last elections, the Socialist Party and the Worker's Party of Bludia both had close to ten percent. One of them may very well increase their votes in the next years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""We should keep using the threshold to our advantage.""*)
  - -> `[122]` (*Player: ""Don't worry. With these reforms, we will be even more po..."*)
  - -> `[78]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[27]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LateDictatorKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "LateDictatorKeyFigureHub"*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Lucian pulled out a huge dossier from his briefcase."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Let's get into the details of our *reforms.*""]** — Mówca: **Player**
> ""Let's get into the details of our *reforms.*""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Petr Vectern), `[13]` (Petr Vectern), `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""Of course.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It's fine as it is.""]** — Mówca: **Player**
> ""It's fine as it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: ""I guess so.""*)

### Węzeł `[129]`
Mówca: **Petr Vectern**
> ""I'm sure some of the reformists may support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[130]`
Mówca: **Lucian Galade**
> ""So there is no reason to change this unless you want to sell this to the opposition parties. Sharing the power with the Assembly may make them sympathetic to you. This might be important for the NFP as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""It's fine as it is.""*)
  - -> `[117]` (*Player: ""We could introduce a confidence vote.""*)
  - -> `[111]` (*Player: ""I agree. We should involve the Assembly more in the proc..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Lucian looked sceptical."*)

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""We should reach out to the judges in secret. Some of the..."*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucian Galade: ""We need at least 6 of the 11 judges to vote for the prop..."*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Did you already work on a plan?""]** — Mówca: **Player**
> ""Did you already work on a plan?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Petr Vectern), `[13]` (Petr Vectern), `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: ""Yes, Mr. President.""*)

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. But without NFP's support of 40 votes, we can never surpass the needed 166. Mr. Kibener's full support as well as our party is needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucian Galade: ""But it will be tough to unite the USP with all the divis..."*)

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""I understand sir. We will address it later in that case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian pulled out a huge dossier from his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: ""Now if we are going with this direction, I'll need every..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Yea, I am not so sure about this.""]** — Mówca: **Player**
> ""Yea, I am not so sure about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: ""I understand sir. We will address it later in that case.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Let's proceed.""]** — Mówca: **Player**
> ""Let's proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: ""I have established nine points parallel to the demands o..."*)

### Węzeł `[143]`
Mówca: **Lucian Galade**
> ""Excellent, and it gives us additional options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""We will do what's necessary to get them in line.""*)
  - -> `[131]` (*Player: ""They will surely support a just cause for the country an..."*)
  - -> `[161]` (*Player: ""I'm sure they will.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""We will be ensuring that the Supreme Court can no longer..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why on earth would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Petr Vectern: ""Most of them won't. But we already talked about a possib..."*)

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""But if we keep the same voter base, say a 15% threshold would keep NFP out of the Assembly. Leaving only two parties. Unless, Frens also falls back behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: ""Well, we can't know these for sure. In the last election..."*)

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""We will be ensuring that the Supreme Court can no longer block constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: ""Most people already find the Supreme Court's absolute au..."*)

### Węzeł `[149]`
Mówca: **Petr Vectern**
> ""Most of them won't. But we already talked about a possible agreement with Isabel which may change things. We could potentially get Heron and the Sollist judges as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""Moving on to Section 3. This is about the impeachment pr..."*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""Moving on to Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""We could try to make the impeachment process more diffic..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Glad to hear it, sir.""*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""Moving on to Section 3. This is about the impeachment pr..."*)

### Węzeł `[153]`
Mówca: **Lucian Galade**
> ""Most people already find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Petr Vectern: ""That's why the Old Guard have bargaining chips over us.""*)

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""Moving on to Section 3. This is about the impeachment pr..."*)

### Węzeł `[155]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Petr Vectern: ""...They will be looking for anything they can declare un..."*)

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""Yes. This will ensure that the Supreme Court will no longer have absolute power over legislation. We can persuade the other parties with this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""Moving on to Section 3. This is about the impeachment pr..."*)

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""Let's mess with the Court, divide and conquer them.""*)
  - -> `[95]` (*Player: ""What if we don't succeed? The Court can have me impeache..."*)
  - -> `[97]` (*Player: ""We'll get rid of this law entirely.""*)
  - -> `[96]` (*Player: ""We could add the Assembly in the process but make impeac..."*)

### Węzeł `[159]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""We did it before for the elections. We can unite it again.""*)
  - -> `[167]` (*Player: ""I'll make sure they follow me.""*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""I have established nine points parallel to the demands of the reformists. I'll go through each of them and get your input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: ""We'll start with Section 1. Reformists want your absolut..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I'm sure they will.""]** — Mówca: **Player**
> ""I'm sure they will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Lucian looked sceptical."*)

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""But don't forget that the Socialist party and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: ""You would be opening their way into the parliament in th..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""We will do what's necessary to get them in line.""]** — Mówca: **Player**
> ""We will do what's necessary to get them in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Nia was taken aback by the statement."*)

### Węzeł `[164]`
Mówca: **Lucian Galade**
> ""Some would but it would be possible to pass it, so it doesn't really matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""I don't see anything wrong with it.""]** — Mówca: **Player**
> ""I don't see anything wrong with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucian Galade: ""Excellent, and it gives us additional options.""*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can unite it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can unite it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Petr Vectern: ""Albin Clavin and his reformist wing will be completely a..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""I'll make sure they follow me.""]** — Mówca: **Player**
> ""I'll make sure they follow me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Petr Vectern: ""Albin Clavin and his reformist wing will be completely a..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> ""Now if we are going with this direction, I'll need everybody to focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""Let's proceed.""*)
  - -> `[172]` (*Player: ""You have our attention.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""A pocket veto? Wouldn't the reformist see through that?""]** — Mówca: **Player**
> ""A pocket veto? Wouldn't the reformist see through that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: ""Some would but it would be possible to pass it, so it do..."*)

### Węzeł `[170]`
Mówca: **Petr Vectern**
> ""I know you will. If you can get their support, we'll have enough votes to amend the Constitution, counting we have the support of Mr. Kibener too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Petr Vectern: ""And there is another key person who can help us get thei..."*)

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""According to such change, constitutional amendments will still require the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""This is already what we wanted to do.""*)
  - -> `[151]` (*Player: ""I can't disagree with that.""*)
  - -> `[146]` (*Player: ""We need the Court to even pass this change. Why on earth..."*)
  - -> `[145]` (*Player: ""And what good does that do to us?""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""You have our attention.""]** — Mówca: **Player**
> ""You have our attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: ""I have established nine points parallel to the demands o..."*)

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. All the party, and I mean, not even Albin wants us to decrease the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: ""Not wrong. The ten percent threshold is what that allowe..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold to some degree.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold to some degree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: ""That's a possibility. It might make the reformists more ..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: ""A decrease would definitely hurt our position in the fut..."*)

### Węzeł `[176]`
Mówca: **Petr Vectern**
> ""Two major left parties; the Socialist Party and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""Decreasing the threshold might mean opening their way in..."*)

### Węzeł `[177]`
Mówca: **Petr Vectern**
> ""Well, we don't. I doubt that any of the judges would support such changes just like that. But they can surely be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: ""We'll need to reach out to Judge Edmonds and her centris..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""We could simply increase it.""]** — Mówca: **Player**
> ""We could simply increase it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""10% seems already too high for many, sir. An increase ma..."*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player: ""We could simply increase it.""*)
  - -> `[174]` (*Player: ""We should definitely work to decrease the threshold to s..."*)
  - -> `[175]` (*Player: ""Do you think it would really hurt the party?""*)
  - -> `[55]` (*Player: ""A decrease is out of the question.""*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible. We could try working with them but it is simpler to keep the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""Yes, but this is a delicate matter. All the party, and I..."*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> ""A decrease would definitely hurt our position in the future. If another party is elected to the Assembly, our projected vote would be closer to the real vote, which is significantly lesser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Petr Vectern: ""Two major left parties; the Socialist Party and the Work..."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""10% seems already too high for many, sir. An increase may bring too much attention on the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: ""But if we keep the same voter base, say a 15% threshold ..."*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""That's a possibility. It might make the reformists more willing to consider the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Petr Vectern: ""But don't forget that the Socialist party and the Worker..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Petr Vectern: ""We will definitely need to work with some of the Old Gua..."*)

### Węzeł `[185]`
Mówca: **Petr Vectern**
> ""We will definitely need to work with some of the Old Guard aligned judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""So, we don't even have a vote in the Court?""*)
  - -> `[81]` (*Player: ""Who do you think would be willing to support these chang..."*)
  - -> `[85]` (*Player: ""I'm sure they can be bought.""*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""We'll start with Section 1. Reformists want your absolute veto power to be removed, or at least, limited. We could potentially give them what they want by limiting it. It wouldn't cause problems since we already have the majority in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""Or better yet, we could change the article according to ..."*)

### Węzeł `[187]`
Mówca: **Petr Vectern**
> ""This is a point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We can break the power of the Old Guards with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucian Galade: ""According to such change, constitutional amendments will..."*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""I'll move on to the second point then. The new Constitution should remove the Supreme Court out of the constitutional amendment process. Not only popular, it would also strengthen our position against the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Petr Vectern: ""This is a point that was unanimously agreed on by all pa..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Petr Vectern: ""We will definitely need to work with some of the Old Gua..."*)

### Węzeł `[190]`
Mówca: **Petr Vectern**
> ""I think we can reach out to Judge Edmonds. And in extension, Mr. Dalton and Mr. Martin. They aren't working together with the Old Guards, as far as we know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""We will also need to get more votes from the conservativ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LateDictatorKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "LateDictatorKeyFigureHub"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""Can we pass it through the Supreme Court?""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Can we possibly reach a two-thirds majority in the Assem..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
