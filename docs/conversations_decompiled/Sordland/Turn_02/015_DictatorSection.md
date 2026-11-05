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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""We need to work closely with NFP, they are our only potential partners.""** | `[26]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Lucian Galade**: ""I'll keep working with them and..." |
| `[5]` | **""And what good does that do to us?""** | `[59]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Petr Vectern**: ""We will be ensuring that the Su..." |
| `[14]` | **""You are part of my cabinet. You wouldn't dare.""** | `[134]` **Nia Morgna**: ""I cannot allow a more authorita..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Nia Morgna**: ""I meant no disrespect, Mr. Pres..." |
| `[21]` | **""I disagree. We'll push for comprehensive reforms.""** | `[26]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Lucian Galade**: ""I'm with you on this, Mr. Presi..." |
| `[24]` | **""I agree. Let's keep the changes small and manageable.""** | `[26]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: ""As long as we accomplish our go..." |
| `[30]` | **""We will do what's necessary to get them in line.""** | `[42]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Nia was taken aback by the state..." |
| `[32]` | **""They will surely support a just cause for the country and its future.""** | `[42]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Lucian looked sceptical." |
| `[33]` | **""I'm sure they will.""** | `[42]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Lucian looked sceptical." |
| `[40]` | **""Can we pass it through the Supreme Court?""** | `[29]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[132]` **Lucian Galade**: ""Anything else, sir?""<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false` | *Brak zmian stanu* | `[108]` **Lucian Galade**: ""They are the biggest obstacle. ..." |
| `[41]` | **""Can we possibly reach a two-thirds majority in the Assembly?""** | `[29]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[132]` **Lucian Galade**: ""Anything else, sir?""<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false` | *Brak zmian stanu* | `[102]` **Lucian Galade**: ""We'll never be able to get PFJP..." |
| `[45]` | **""I understand.""** | `[82]` **Nia Morgna**: ""I meant no disrespect, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: ""Let's move on."" |
| `[49]` | **""We need the Court to even pass this change. Why on earth would they support this?""** | `[59]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Petr Vectern**: ""Most of them won't. But we alre..." |
| `[50]` | **""I can't disagree with that.""** | `[59]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Lucian Galade**: ""Glad to hear it, sir."" |
| `[51]` | **""This is already what we wanted to do.""** | `[59]` **Lucian Galade**: ""According to such change, const..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""Yes. This will ensure that the ..." |
| `[53]` | **""Did you already work on a plan?""** | `[29]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[132]` **Lucian Galade**: ""Anything else, sir?""<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[75]` **Lucian Galade**: ""Yes, Mr. President."" |
| `[56]` | **""You have our attention.""** | `[43]` **Lucian Galade**: ""Now if we are going with this d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Nia Morgna**: ""Okay then. Let's see what we're..." |
| `[57]` | **""We did it before for the elections. We can unite it again.""** | `[105]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[61]` | **""We'll talk about this later.""** | `[71]` **Nia Morgna**: ""I'm starting to doubt that, Mr...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyF...` | `[41]` **Player**: ""Can we possibly reach a two-thi..."<br>`[40]` **Player**: ""Can we pass it through the Supr..."<br>*(oraz 2 innych odgałęzień)* |
| `[67]` | **""Let's proceed.""** | `[43]` **Lucian Galade**: ""Now if we are going with this d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Nia Morgna**: ""Okay then. Let's see what we're..." |
| `[69]` | **""Do not doubt me, Nia.""** | `[71]` **Nia Morgna**: ""I'm starting to doubt that, Mr...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "She raised an eyebrow." |
| `[76]` | **""Yes, keep an eye on her. We can't let her sabotage us.""** | `[74]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lucian Galade**: ""Of course, sir."" |
| `[77]` | **""I'm sure we can work something out with you, Mrs. Morgna.""** | `[82]` **Nia Morgna**: ""I meant no disrespect, Mr. Pres..."<br>`[141]` **Nia Morgna**: ""I'm sorry, Mr. President but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Nia Morgna**: ""I'm starting to doubt that, Mr...." |
| `[78]` | **""I will make sure she stays in line.""** | `[74]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Petr Vectern**: ""Oh she will. I don't think she ..." |
| `[79]` | **""I'm sure they can be bought.""** | `[52]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""I'm afraid it would be tough to..." |
| `[80]` | **""She's not our main problem here.""** | `[74]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Petr Vectern**: ""That's true. We have bigger fis..." |
| `[81]` | **""Who do you think would be willing to support these changes?""** | `[52]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Petr Vectern**: ""I think we can reach out to Jud..." |
| `[84]` | **""So, we don't even have a vote in the Court?""** | `[52]` **Petr Vectern**: ""We will definitely need to work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Petr Vectern**: ""Well, we don't. I doubt that an..." |
| `[89]` | **""Do you think they can be persuaded?""** | `[136]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Petr Vectern**: ""I'm sure it's possible. But reg..." |
| `[95]` | **""Be careful with what you decide to do, Mrs. Morgna.""** | `[47]` **Nia Morgna**: ""I wish you a good day, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "She gave a fake smile." |
| `[96]` | **""I'll make sure they follow me.""** | `[105]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[97]` | **""Good day to you too, Mrs. Morgna.""** | `[47]` **Nia Morgna**: ""I wish you a good day, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "She gave a fake smile and left t..." |
| `[99]` | **""I will be watching you.""** | `[47]` **Nia Morgna**: ""I wish you a good day, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "She gave a fake smile." |
| `[110]` | **""Let's get into the details of our *reforms.*""** | `[29]` **Lucian Galade**: ""That said, we should try to rea..."<br>`[132]` **Lucian Galade**: ""Anything else, sir?""<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[90]` **Lucian Galade**: ""Of course."" |
| `[114]` | **""I like the idea. What kind of loopholes do you have in mind?""** | `[129]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Lucian Galade**: ""Well, we could define a process..." |
| `[116]` | **""We could limit the vetoes and package it as a great reform.""** | `[129]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Petr Vectern**: ""I like the idea. Maybe we could..." |
| `[117]` | **""I'll show them true leadership.""** | `[136]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Petr Vectern**: ""I know you will. If you can get..." |
| `[118]` | **""No. We don't need to change the Article about vetoes.""** | `[129]` **Lucian Galade**: ""Or better yet, we could change ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Petr Vectern**: ""I agree. If we're going against..." |
| `[128]` | **""Yes, Mrs. Morgna. I am a Sollist.""** | `[141]` **Nia Morgna**: ""I'm sorry, Mr. President but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "She did not even try to respond." |
| `[130]` | **""Frankly, I don't care.""** | `[82]` **Nia Morgna**: ""I meant no disrespect, Mr. Pres..."<br>`[141]` **Nia Morgna**: ""I'm sorry, Mr. President but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "Petr coughed." |
| `[133]` | **""Come now, Mrs. Morgna. There's no need for that.""** | `[134]` **Nia Morgna**: ""I cannot allow a more authorita..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Nia Morgna**: ""I meant no disrespect, Mr. Pres..." |
| `[135]` | **""How many votes do they have?""** | `[136]` **Petr Vectern**: ""However, the conservatives may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Petr Vectern**: ""The conservatives have around 4..." |
| `[140]` | **""But we need more executive powers to bring bigger change.""** | `[134]` **Nia Morgna**: ""I cannot allow a more authorita..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Nia Morgna**: ""I'm sorry, Mr. President but th..." |

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
  - -> `[12]` (*Lucian Galade: ""There are some people in USP who would support a new Con..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "Jump to: [DictatorKeyFigureHub]"*)

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""I'll keep working with them and keep you updated, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We need to work closely with NFP, they are our only potential partners.""]** — Mówca: **Player**
> ""We need to work closely with NFP, they are our only potential partners.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""I'll keep working with them and keep you updated, Mr. Pr..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Petr Vectern: ""We will be ensuring that the Supreme Court can no longer..."*)

### Węzeł `[6]`
Mówca: **Petr Vectern**
> ""We will be ensuring that the Supreme Court can no longer block constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""Most people already find the Supreme Court's absolute au..."*)

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Most of them won't. But we already talked about a possible agreement with Isabel which may change things. We could potentially get Heron and the Sollist judges as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Apart from these two critical points we could address a ..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Apart from these two critical points we could address a ..."*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Most people already find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Petr Vectern: ""That's why the Old Guard have bargaining chips over us.""*)

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Apart from these two critical points we could address a ..."*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Yes. This will ensure that the Supreme Court will no longer have absolute power over legislation. We can persuade the other parties with this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Apart from these two critical points we could address a ..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""There are some people in USP who would support a new Constitution with more executive powers. Getting the support of the NFP nationalists is our best bet on this path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""That said, we should try to reach a common ground with t..."*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her and Judge Garaci, we might be able to get enough votes. They have major influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Nia Morgna: ""According to the Constitution, I am a member of the Supr..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""You are part of my cabinet. You wouldn't dare.""]** — Mówca: **Player**
> ""You are part of my cabinet. You wouldn't dare.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Nia Morgna: ""I meant no disrespect, Mr. President. But you should be ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Apart from these two critical points we could address a lot of the issues already in discussion for our own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""NFP want to reform the appointment procedures of the min..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""NFP want to reform the appointment procedures of the ministers. Mr. Kibener clarified that the Assembly should have a say in the formation of the council of ministers. They are a potential ally so this is an important demand to consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: ""That is something that a majority in our party also supp..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""We could address the term limits and election threshold as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""Well... That one is a controversial one. I doubt that US..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""That is something that a majority in our party also supports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""We could address the term limits and election threshold ..."*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""Well... That one is a controversial one. I doubt that USP would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""Immunity of the Justices, the impeachment of the preside..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Immunity of the Justices, the impeachment of the president, the power of the presidential decrees... All of these are in the realm of possibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""If we can establish a proper balance and get the support..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I disagree. We'll push for comprehensive reforms.""]** — Mówca: **Player**
> ""I disagree. We'll push for comprehensive reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""I'm with you on this, Mr. President.""*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together with all the cabinet to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'm with you on this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I agree. Let's keep the changes small and manageable.""]** — Mówca: **Player**
> ""I agree. Let's keep the changes small and manageable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""As long as we accomplish our goals, I also agree.""*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""If we can establish a proper balance and get the support of the NFP, you can gain a lot from these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: ""I'd say keeping everything in the middle ground is the s..."*)

### Węzeł `[26]`
Mówca: **Petr Vectern**
> ""I'd say keeping everything in the middle ground is the safest bet. No need to agitate anyone too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I disagree. We'll push for comprehensive reforms.""*)
  - -> `[24]` (*Player: ""I agree. Let's keep the changes small and manageable.""*)
  - -> `[4]` (*Player: ""We need to work closely with NFP, they are our only pote..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""As long as we accomplish our goals, I also agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[28]`
Mówca: **Nia Morgna**
> ""What? You were working on a different draft while we worked in the committee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""That is correct. Mr. President had *stronger* ideas. Sur..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""That said, we should try to reach a common ground with the conservative wing of our party to be able to propose such changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "DictatorKeyFigureHub"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We will do what's necessary to get them in line.""]** — Mówca: **Player**
> ""We will do what's necessary to get them in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Nia was taken aback by the statement."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DictatorKeyFigureHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Lucian looked sceptical."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I'm sure they will.""]** — Mówca: **Player**
> ""I'm sure they will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Lucian looked sceptical."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: ""We will definitely need to work with some of the Old Gua..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""Did you already work on a plan?""*)
  - -> `[110]` (*Player: ""Let's get into the details of our *reforms.*""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: ""We will definitely need to work with some of the Old Gua..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""That is correct. Mr. President had *stronger* ideas. Surely, I couldn't work with the reform committee. No offence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""Now if we are going with this direction, I'll need every..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Can we pass it through the Supreme Court?""]** — Mówca: **Player**
> ""Can we pass it through the Supreme Court?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[132]` (Lucian Galade), `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: ""They are the biggest obstacle. Even if we pass the Assem..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Can we possibly reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we possibly reach a two-thirds majority in the Assembly?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[132]` (Lucian Galade), `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""We'll never be able to get PFJP to work with us. But if ..."*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""We will do what's necessary to get them in line.""*)
  - -> `[32]` (*Player: ""They will surely support a just cause for the country an..."*)
  - -> `[33]` (*Player: ""I'm sure they will.""*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Now if we are going with this direction, I'll need everybody to focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Let's proceed.""*)
  - -> `[56]` (*Player: ""You have our attention.""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I understand.""]** — Mówca: **Player**
> ""I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""Let's move on.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Lucian pulled out a huge dossier from his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Nia Morgna: ""What? You were working on a different draft while we wor..."*)

### Węzeł `[47]`
Mówca: **Nia Morgna**
> ""I wish you a good day, Mr. President. We'll see what happens in the Assembly and the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""Be careful with what you decide to do, Mrs. Morgna.""*)
  - -> `[99]` (*Player: ""I will be watching you.""*)
  - -> `[97]` (*Player: ""Good day to you too, Mrs. Morgna.""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "She spoke with a gentle tone but her face couldn't hide her disappointment and anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: ""We have established two points parallel to the demands o..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why on earth would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Petr Vectern: ""Most of them won't. But we already talked about a possib..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: ""Glad to hear it, sir.""*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: ""Yes. This will ensure that the Supreme Court will no lon..."*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""We will definitely need to work with some of the Old Guard aligned judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""So, we don't even have a vote in the Court?""*)
  - -> `[81]` (*Player: ""Who do you think would be willing to support these chang..."*)
  - -> `[79]` (*Player: ""I'm sure they can be bought.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Did you already work on a plan?""]** — Mówca: **Player**
> ""Did you already work on a plan?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[132]` (Lucian Galade), `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""Yes, Mr. President.""*)

### Węzeł `[54]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be tough to bribe the Old Guards. Chief Justice Hawker will do their best to undermine us. But maybe we can get to Heron Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""We can also try to "persuade" the centrists of the Court..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""You have our attention.""]** — Mówca: **Player**
> ""You have our attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Nia Morgna: ""Okay then. Let's see what we're talking about here.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can unite it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can unite it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Albin Clavin and his reformist wing will be completely a..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: ""We should reach out to the judges in secret. Some of the..."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""According to such change, constitutional amendments will still require the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""This is already what we wanted to do.""*)
  - -> `[50]` (*Player: ""I can't disagree with that.""*)
  - -> `[49]` (*Player: ""We need the Court to even pass this change. Why on earth..."*)
  - -> `[5]` (*Player: ""And what good does that do to us?""*)

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""This is a point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We can break the power of the Old Guards with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""According to such change, constitutional amendments will..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""We'll talk about this later.""]** — Mówca: **Player**
> ""We'll talk about this later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I'll move on to the second point then. The new Constitution should remove the Supreme Court out of the constitutional amendment process. Not only popular, it would also strengthen our position against the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Petr Vectern: ""This is a point that was unanimously agreed on by all pa..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DictatorKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "DictatorKeyFigureHub"*)

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""That's true. We have bigger fish to catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "Jump to: [DictatorKeyFigureHub]"*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Oh she will. I don't think she has that in her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Let's proceed.""]** — Mówca: **Player**
> ""Let's proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Nia Morgna: ""Okay then. Let's see what we're talking about here.""*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""I'll move on to the second point then. The new Constitut..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Do not doubt me, Nia.""]** — Mówca: **Player**
> ""Do not doubt me, Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "She raised an eyebrow."*)

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""According to the Constitution, I am a member of the Supreme Court, which means you already have one vote against this. I already know two of the judges who are with me, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: ""Come now, Mrs. Morgna. You said you were open to discuss..."*)

### Węzeł `[71]`
Mówca: **Nia Morgna**
> ""I'm starting to doubt that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""We'll talk about this later.""*)
  - -> `[69]` (*Player: ""Do not doubt me, Nia.""*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""I can't believe you are all in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Nia Morgna: ""With all due respect, I will take my leave from this mee..."*)

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""That's troublesome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""While I respect her, I doubt that she's capable of creat..."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""While I respect her, I doubt that she's capable of creating major obstacles for us. But we have to keep close eyes on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Yes, keep an eye on her. We can't let her sabotage us.""*)
  - -> `[78]` (*Player: ""I will make sure she stays in line.""*)
  - -> `[80]` (*Player: ""She's not our main problem here.""*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Lucian pulled out a huge dossier from his briefcase."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Yes, keep an eye on her. We can't let her sabotage us.""]** — Mówca: **Player**
> ""Yes, keep an eye on her. We can't let her sabotage us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm sure we can work something out with you, Mrs. Morgna.""]** — Mówca: **Player**
> ""I'm sure we can work something out with you, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna), `[141]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Nia Morgna: ""I'm starting to doubt that, Mr. President.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I will make sure she stays in line.""]** — Mówca: **Player**
> ""I will make sure she stays in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""Oh she will. I don't think she has that in her.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I'm sure they can be bought.""]** — Mówca: **Player**
> ""I'm sure they can be bought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""I'm afraid it would be tough to bribe the Old Guards. Ch..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""She's not our main problem here.""]** — Mówca: **Player**
> ""She's not our main problem here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Petr Vectern: ""That's true. We have bigger fish to catch.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Who do you think would be willing to support these changes?""]** — Mówca: **Player**
> ""Who do you think would be willing to support these changes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: ""I think we can reach out to Judge Edmonds. And in extens..."*)

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""I meant no disrespect, Mr. President. But you should be aware of my position, and that it is final.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""I understand.""*)
  - -> `[77]` (*Player: ""I'm sure we can work something out with you, Mrs. Morgna.""*)
  - -> `[130]` (*Player: ""Frankly, I don't care.""*)

### Węzeł `[83]`
Mówca: **Narrator**
> "She left the room and slammed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""So, we don't even have a vote in the Court?""]** — Mówca: **Player**
> ""So, we don't even have a vote in the Court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Petr Vectern: ""Well, we don't. I doubt that any of the judges would sup..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: ""That's troublesome.""*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""Come now, Mrs. Morgna. You said you were open to discuss Mr. President's version of the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Nia Morgna: ""Of course, Mr. Vectern. But I already have a strong opin..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "She gave a fake smile and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[88]`
Mówca: **Nia Morgna**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "She left the room and slammed the door behind her."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you think they can be persuaded?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""I'm sure it's possible. But regardless of my opinion, we..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Lucian pulled out a huge dossier from his briefcase."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "She gave a fake smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Nia Morgna: ""I understand, Mr. President.""*)

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""Well, we don't. I doubt that any of the judges would support such changes just like that. But they can surely be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Petr Vectern: ""We'll need to reach out to Judge Edmonds and her centris..."*)

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""I think we can reach out to Judge Edmonds. And in extension, Mr. Dalton and Mr. Martin. They aren't working together with the Old Guards, as far as we know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""We will also need to get more votes from the conservativ..."*)

### Węzeł `[94]`
Mówca: **Petr Vectern**
> ""I know you will. If you can get their support, we'll have enough votes to amend the Constitution, counting we have the support of Mr. Kibener too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Petr Vectern: ""And there is another key person who can help us get thei..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Be careful with what you decide to do, Mrs. Morgna.""]** — Mówca: **Player**
> ""Be careful with what you decide to do, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "She gave a fake smile."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I'll make sure they follow me.""]** — Mówca: **Player**
> ""I'll make sure they follow me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Albin Clavin and his reformist wing will be completely a..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Good day to you too, Mrs. Morgna.""]** — Mówca: **Player**
> ""Good day to you too, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "She gave a fake smile and left the room."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Petr Vectern: ""And there is one key person who can help us get their su..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I will be watching you.""]** — Mówca: **Player**
> ""I will be watching you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "She gave a fake smile."*)

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""You must be talking about Gloria Tory. She's well respected by the Sollists. She's the biggest problem in our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""But judging by what Mr. President is trying to do, I bel..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "She took her notes and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Nia Morgna: ""I wish you a good day, Mr. President. We'll see what hap..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""We'll never be able to get PFJP to work with us. But if you can get Kesaro Kibener to work with you on this, our only remaining problem would be uniting our own party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""We need the majority of our 130 seats in the Assembly to..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. But without NFP's support of 40 votes, we can never surpass the needed 166. Mr. Kibener's full support as well as our party is needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""But it will be tough to unite the USP with all the divis..."*)

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""With all due respect, I will take my leave from this meeting. I don't think I have anything to add anymore. I cannot associate with plans of tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "She took her notes and stood up."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""We did it before for the elections. We can unite it again.""*)
  - -> `[96]` (*Player: ""I'll make sure they follow me.""*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""You could technically choose to take no action instead of signing or vetoing it. Without a proper definition of the process, it would be perfectly legal for you to ignore a bill indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Nia Morgna: ""A pocket veto? You think that's clever, Mr. Galade but a..."*)

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""A pocket veto? You think that's clever, Mr. Galade but anybody who understands the law would see that hole. There is no way the reformists would be deceived by that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Nia Morgna: ""With all due respect, I will take my leave from this mee..."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""We need at least 6 of the 11 judges to vote for the prop..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Petr coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's get into the details of our *reforms.*""]** — Mówca: **Player**
> ""Let's get into the details of our *reforms.*""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade), `[132]` (Lucian Galade), `[22]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""Of course.""*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""We have established two points parallel to the demands of the reformists. I'll go through each of them and get your input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""We'll start with Section 1. Reformists want your absolut..."*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""But judging by what Mr. President is trying to do, I believe you can find common ground under Sollism. The problem will not be her but me, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Nia Morgna: ""I cannot allow a more authoritarian Constitution to be m..."*)

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""You must be talking about Gloria Tory. She's well respec..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I like the idea. What kind of loopholes do you have in mind?""]** — Mówca: **Player**
> ""I like the idea. What kind of loopholes do you have in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: ""Well, we could define a process for the Assembly to over..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""We can also try to "persuade" the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Yes, we'll need to talk to Judge Edmonds. If we can get ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""We could limit the vetoes and package it as a great reform.""]** — Mówca: **Player**
> ""We could limit the vetoes and package it as a great reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Petr Vectern: ""I like the idea. Maybe we could convince some of the ref..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I'll show them true leadership.""]** — Mówca: **Player**
> ""I'll show them true leadership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Petr Vectern: ""I know you will. If you can get their support, we'll hav..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""No. We don't need to change the Article about vetoes.""]** — Mówca: **Player**
> ""No. We don't need to change the Article about vetoes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Petr Vectern: ""I agree. If we're going against the reformists anyway, w..."*)

### Węzeł `[119]`
Mówca: **Petr Vectern**
> ""And there is another key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""You must be talking about Gloria Tory. She's well respec..."*)

### Węzeł `[120]`
Mówca: **Petr Vectern**
> ""I like the idea. Maybe we could convince some of the reformists with that. But it all depends on the whole changes. It could be better not to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""I can't believe you are all in this.""*)

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""We'll need to reach out to Judge Edmonds and her centrist wing. We can get three votes from them. They don't seem to be in the pocket of the Old Guard and they are definitely not reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""We will also need to get more votes from the conservativ..."*)

### Węzeł `[122]`
Mówca: **Petr Vectern**
> ""I agree. If we're going against the reformists anyway, why even bother giving concessions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""I can't believe you are all in this.""*)

### Węzeł `[123]`
Mówca: **Nia Morgna**
> ""Okay then. Let's see what we're talking about here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "She spoke with a gentle tone but her face couldn't hide h..."*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""Well, we could define a process for the Assembly to override your vetoes with a supermajority. While this limits your veto capabilities, if we do not define a time limit for the President to act on a bill...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: ""You could technically choose to take no action instead o..."*)

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing will be completely against you. He already responded negatively in the committee meetings. But I think he will still be open to discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Petr Vectern: ""However, the conservatives may be persuaded easier. The ..."*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""We will also need to get more votes from the conservative judges. I believe Heron Garaci might be the weakest link of the Old Guards. He can help us get the 6 votes needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Nia Morgna: ""According to the Constitution, I am a member of the Supr..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "She did not even try to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Yes, Mrs. Morgna. I am a Sollist.""]** — Mówca: **Player**
> ""Yes, Mrs. Morgna. I am a Sollist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "She did not even try to respond."*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Or better yet, we could change the article according to their demands but establish new loopholes for you to hold your veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""I like the idea. What kind of loopholes do you have in m..."*)
  - -> `[116]` (*Player: ""We could limit the vetoes and package it as a great refo..."*)
  - -> `[118]` (*Player: ""No. We don't need to change the Article about vetoes.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Frankly, I don't care.""]** — Mówca: **Player**
> ""Frankly, I don't care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna), `[141]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Petr coughed."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DictatorKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "DictatorKeyFigureHub"*)

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""Anything else, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [DictatorKeyFigureHub]"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Come now, Mrs. Morgna. There's no need for that.""]** — Mówca: **Player**
> ""Come now, Mrs. Morgna. There's no need for that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Nia Morgna: ""I meant no disrespect, Mr. President. But you should be ..."*)

### Węzeł `[134]`
Mówca: **Nia Morgna**
> ""I cannot allow a more authoritarian Constitution to be made. There is no way I can support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""You are part of my cabinet. You wouldn't dare.""*)
  - -> `[133]` (*Player: ""Come now, Mrs. Morgna. There's no need for that.""*)
  - -> `[140]` (*Player: ""But we need more executive powers to bring bigger change.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""The conservatives have around 40 seats. If you can get t..."*)

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""However, the conservatives may be persuaded easier. The influence of Soll is still living strong in the party. They might follow you if they respect you as a strong leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""I'll show them true leadership.""*)
  - -> `[135]` (*Player: ""How many votes do they have?""*)
  - -> `[89]` (*Player: ""Do you think they can be persuaded?""*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""We'll start with Section 1. Reformists want your absolute veto power to be removed, or at least, limited. We could potentially give them what they want by limiting it. It wouldn't cause problems since we already have the majority in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""Or better yet, we could change the article according to ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Lucian cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucian Galade: ""Anything else, sir?""*)

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is one key person who can help us get their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""You must be talking about Gloria Tory. She's well respec..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""But we need more executive powers to bring bigger change.""]** — Mówca: **Player**
> ""But we need more executive powers to bring bigger change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Nia Morgna: ""I'm sorry, Mr. President but that's the Sollist talking ..."*)

### Węzeł `[141]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President but that's the Sollist talking point. I won't be convinced by that argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I'm sure we can work something out with you, Mrs. Morgna.""*)
  - -> `[130]` (*Player: ""Frankly, I don't care.""*)
  - -> `[128]` (*Player: ""Yes, Mrs. Morgna. I am a Sollist.""*)

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. If you can get the unaligned to support us, along with our "loyalists" we'll have enough votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Petr Vectern: ""So we need as many of the conservatives to support us. A..."*)

### Węzeł `[143]`
Mówca: **Nia Morgna**
> ""Of course, Mr. Vectern. But I already have a strong opinion about what it contains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Lucian cut in."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""Can we possibly reach a two-thirds majority in the Assem..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""Can we pass it through the Supreme Court?""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
