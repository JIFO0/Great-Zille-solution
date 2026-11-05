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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""I will support the new Constitution.""** | `[23]` **Lucian Galade**: ""Now we should wrap this up. Sin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Nia Morgna**: ""That's great to hear, Mr. Presi..." |
| `[17]` | **""We will eventually remove his influence.""** | `[75]` **Petr Vectern**: ""However, the conservatives woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Nia Morgna**: ""We'll need to break the power o..." |
| `[26]` | **""I won't support these reforms. We'll work with the Old Guard to block them.""** | `[23]` **Lucian Galade**: ""Now we should wrap this up. Sin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Petr Vectern**: ""Well... That one is a controver..." |
| `[27]` | **""Can we reach a two-thirds majority in the Assembly?""** | `[8]` **Lucian Galade**: ""If we can fully reach an agreem..."<br>`[99]` **Petr Vectern**: ""Yes, those three don't seem to ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false` | *Brak zmian stanu* | `[34]` **Lucian Galade**: ""If you can get Frens Ricter to ..." |
| `[28]` | **""How many votes do they have?""** | `[75]` **Petr Vectern**: ""However, the conservatives woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Petr Vectern**: ""The conservatives have around 4..." |
| `[31]` | **""Is it possible to pass the Supreme Court?""** | `[8]` **Lucian Galade**: ""If we can fully reach an agreem..."<br>`[99]` **Petr Vectern**: ""Yes, those three don't seem to ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false` | *Brak zmian stanu* | `[38]` **Lucian Galade**: ""They are the biggest obstacle. ..." |
| `[33]` | **""I'm sure the rest can be bribed.""** | `[59]` **Nia Morgna**: ""Two of the judges are friends o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucian Galade**: ""We can't just bribe the Old Gua..." |
| `[37]` | **""Who else would be willing to support reforms?""** | `[59]` **Nia Morgna**: ""Two of the judges are friends o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Nia Morgna**: ""I think Judge Edmonds can be pe..." |
| `[39]` | **""So, we only have 3 votes out of 11?""** | `[59]` **Nia Morgna**: ""Two of the judges are friends o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Nia Morgna**: ""Three votes, yes. But I believe..." |
| `[51]` | **""Do you think they can be persuaded?""** | `[75]` **Petr Vectern**: ""However, the conservatives woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Petr Vectern**: ""I'm sure it's possible. But reg..." |
| `[53]` | **""We did it before for the elections. We can do it again.""** | `[67]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[55]` | **""Let's go through the draft.""** | `[8]` **Lucian Galade**: ""If we can fully reach an agreem..."<br>`[99]` **Petr Vectern**: ""Yes, those three don't seem to ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[95]` **Lucian Galade**: ""Of course."" |
| `[56]` | **""I disagree. We'll push for comprehensive reforms.""** | `[54]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Nia Morgna**: ""I'm with you on this, Mr. Presi..." |
| `[58]` | **""I agree. Let's keep the changes small and manageable.""** | `[54]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Nia Morgna**: ""As long as we address the main ..." |
| `[60]` | **""They have valid concerns that we need to look at.""** | `[54]` **Petr Vectern**: ""I'd say keeping everything in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Nia Morgna**: ""I'll keep working with them and..." |
| `[69]` | **""What are the demands?""** | `[8]` **Lucian Galade**: ""If we can fully reach an agreem..."<br>`[99]` **Petr Vectern**: ""Yes, those three don't seem to ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true` | *Brak zmian stanu* | `[96]` **Lucian Galade**: ""We should run-down each of the ..." |
| `[70]` | **""They will not be allowed to dictate the negotiations.""** | `[85]` **Nia Morgna**: ""My suggestion is to add a claus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Petr Vectern**: ""This is one of the starting poi..." |
| `[74]` | **""This is already what we wanted to do.""** | `[72]` **Nia Morgna**: ""Constitutional amendments will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Nia Morgna**: ""Yes. This will ensure that ther..." |
| `[76]` | **""I can't disagree with that.""** | `[72]` **Nia Morgna**: ""Constitutional amendments will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Nia Morgna**: ""Glad to hear it."" |
| `[78]` | **""And what good does that do to us?""** | `[72]` **Nia Morgna**: ""Constitutional amendments will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Nia Morgna**: ""We will be ensuring that there ..." |
| `[81]` | **""The loopholes give the President too much power.""** | `[85]` **Nia Morgna**: ""My suggestion is to add a claus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Nia Morgna**: ""Whatever you decide it's import..." |
| `[83]` | **""We need the Court to even pass this change. Why would they support this?""** | `[72]` **Nia Morgna**: ""Constitutional amendments will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Nia Morgna**: ""Most of them won't. But we alre..." |
| `[84]` | **""We will convince the leads.""** | `[67]` **Lucian Galade**: ""But it will be tough to unite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Petr Vectern**: ""Albin Clavin and his reformist ..." |
| `[88]` | **""They will surely support a just cause for the country and its future.""** | `[61]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "Lucian looked sceptical." |
| `[89]` | **""All means are to be considered in order to succeed.""** | `[61]` **Petr Vectern**: ""We should reach out to the judg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Nia was taken aback by the state..." |
| `[101]` | **""I stand in agreement with Mr. Ricter. The vetoes should be removed.""** | `[85]` **Nia Morgna**: ""My suggestion is to add a claus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Nia Morgna**: ""Whatever you decide it's import..." |

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
  - -> `[8]` (*Lucian Galade: ""If we can fully reach an agreement with the reformists, ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Nia Morgna: ""I'm with you on this, Mr. President.""*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention = false"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""I will support the new Constitution.""]** — Mówca: **Player**
> ""I will support the new Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Nia Morgna: ""That's great to hear, Mr. President.""*)

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""That's great to hear, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention = true"*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""Most people find the Supreme Court's absolute authority over constitutional changes dangerous. Look at the situation we currently have, Mr. President. The Judiciary has power over every branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: ""That's why the Old Guard have bargaining chips over us.""*)

### Węzeł `[7]`
Mówca: **Nia Morgna**
> ""We will be ensuring that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: ""Most people find the Supreme Court's absolute authority ..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""If we can fully reach an agreement with the reformists, we will be very strong in the Assembly to propose the change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "ReformistKeyFigureHub"*)

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Apart from these two critical points they have other maj..."*)

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""Yes. This will ensure that there won't be another politically motivated Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Apart from these two critical points they have other maj..."*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""That's why the Old Guard have bargaining chips over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Apart from these two critical points they have other maj..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""We can't just bribe the Old Guards. Judge Garaci and the Chief Justice Hawker will do their best to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""But we might try and bribe the centrists of the Court. I..."*)

### Węzeł `[13]`
Mówca: **Nia Morgna**
> ""Most of them won't. But we already talked about my vote and a possible agreement with Isabel which may change things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Apart from these two critical points they have other maj..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Nia Morgna: ""I'll present your input to the committee. In a few month..."*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Well, regardless of what Mr. Rayne decides, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[16]`
Mówca: **Nia Morgna**
> ""I'll present your input to the committee. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""We will eventually remove his influence.""]** — Mówca: **Player**
> ""We will eventually remove his lasting influence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Nia Morgna: ""We'll need to break the power of the Old Guard within US..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""Now we should wrap this up. Since we evaluated the point..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: ""Now we have a better picture of your intentions, sir. I ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ReformistKeyFigureHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)

### Węzeł `[22]`
Mówca: **Nia Morgna**
> ""We'll need to break the power of the Old Guard within USP first. Most of the conservative wing are still loyal to their Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Petr Vectern: ""Most of their support is necessary to be able to amend t..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""Now we should wrap this up. Since we evaluated the points, I'd like to hear your input, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""I will support the new Constitution.""*)
  - -> `[26]` (*Player: ""I won't support these reforms. We'll work with the Old G..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ReformistKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "ReformistKeyFigureHub"*)

### Węzeł `[25]`
Mówca: **Nia Morgna**
> ""This is yet another point that was unanimously agreed on by all parties. Tarquin Soll established this rule to protect his '29 Constitution. We all know most of the judges are still his pawns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""Constitutional amendments will still be very difficult t..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""I won't support these reforms. We'll work with the Old Guard to block them.""]** — Mówca: **Player**
> ""I won't support these reforms. We'll work with the Old Guard to block them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "Jump to: [BackToAutocrat]"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Can we reach a two-thirds majority in the Assembly?""]** — Mówca: **Player**
> ""Can we reach a two-thirds majority in the Assembly?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[99]` (Petr Vectern), `[100]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""If you can get Frens Ricter to work with you on this, ou..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""How many votes do they have?""]** — Mówca: **Player**
> ""How many votes do they have in total?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Petr Vectern: ""The conservatives have around 40 seats. There are many u..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BackToAutocrat]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""Well... That one is a controversial one. I doubt that US..."*)

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Even though Mr. Ricter put on a whole show about why vetoes should completely be removed, the committee has almost unanimously agreed on fixing the loopholes, thus limiting presidential vetoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Nia Morgna: ""My suggestion is to add a clause detailing the methods t..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Is it possible to pass the Supreme Court?""]** — Mówca: **Player**
> ""Is it possible to pass this through the Supreme Court?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[99]` (Petr Vectern), `[100]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""They are the biggest obstacle. Even if we pass the Assem..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Nia Morgna: ""I'll present your input to the committee. In a few month..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I'm sure the rest can be bribed.""]** — Mówca: **Player**
> ""I'm sure the rest can be bribed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""We can't just bribe the Old Guards. Judge Garaci and the..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""If you can get Frens Ricter to work with you on this, our only problem would be uniting our own party. We'll never be able to get NFP to work with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""We need the majority of our 130 seats in the Assembly to..."*)

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Apart from these two critical points they have other major demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Nia Morgna: ""They want to reform the appointment procedures of the mi..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reformist Branch Start`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""Of course.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Who else would be willing to support reforms?""]** — Mówca: **Player**
> ""Who else would be willing to support reforms?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""I think Judge Edmonds can be persuaded. And in extension..."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""They are the biggest obstacle. Even if we pass the Assembly, the Chief Justice will do his best to block our amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: ""We need at least 6 of the 11 judges to vote for the prop..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""So, we only have 3 votes out of 11?""]** — Mówca: **Player**
> ""So, we only have 3 votes out of 11?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Nia Morgna: ""Three votes, yes. But I believe that Judge Edmonds can b..."*)

### Węzeł `[40]`
Mówca: **Nia Morgna**
> ""They want to reform the appointment procedures of the ministers. Mr. Ricter clarified that the Assembly should have a say in the formation of the council of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""That is something that a majority in our party also supp..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""What are the demands?""*)
  - -> `[55]` (*Player: ""Let's go through the draft.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == true && BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Well, Mr. Ricter also talked about abolishing the Member of Honor rights of Tarquin Soll that gives him absolute immunity and makes him a permanent member of the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""Well... That one is a controversial one. I doubt that US..."*)

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""That is something that a majority in our party also supports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Nia Morgna: ""Well, Mr. Ricter also talked about abolishing the Member..."*)

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""I'm sure it's possible. But regardless of my opinion, we *need* to persuade most of them to support us for passing an amendment to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: ""And there is only one person who is key to make them bac..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""We'll go through each of the main demands of the committ..."*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""Well... That one is a controversial one. I doubt that USP would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: ""Immunity of the Justices, the impeachment of the preside..."*)

### Węzeł `[49]`
Mówca: **Petr Vectern**
> ""The conservatives have around 40 seats. There are many unaligned people and some of your "loyalists" might decide to show their true faces too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: ""So we need as many of the conservatives to support us. A..."*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""Immunity of the Justices, the impeachment of the president, limiting the power of the presidential decrees... All of this came up during the committee meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Nia Morgna: ""Yes, reformists expect big reforms while our faction in ..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Do you think they can be persuaded?""]** — Mówca: **Player**
> ""Do you really think they can be persuaded?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: ""I'm sure it's possible. But regardless of my opinion, we..."*)

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""Yes, reformists expect big reforms while our faction in the USP are not very keen on pushing changes that are too great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""I'd say keeping everything in the middle ground is the s..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""We did it before for the elections. We can do it again.""]** — Mówca: **Player**
> ""We did it before for the elections. We can do it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""Albin Clavin and his reformist wing would be supporting ..."*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""I'd say keeping everything in the middle ground is the safest bet. No need to agitate anyone too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""I disagree. We'll push for comprehensive reforms.""*)
  - -> `[58]` (*Player: ""I agree. Let's keep the changes small and manageable.""*)
  - -> `[60]` (*Player: ""They have valid concerns that we need to look at.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Let's go through the draft.""]** — Mówca: **Player**
> ""Let's go through the draft details.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[99]` (Petr Vectern), `[100]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: ""Of course.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I disagree. We'll push for comprehensive reforms.""]** — Mówca: **Player**
> ""I disagree. We'll push for comprehensive reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Nia Morgna: ""I'm with you on this, Mr. President.""*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""But we might try and bribe the centrists of the Court. I think we might get Mr. Dalton and Mr. Martin with a bribe. The toughest will be Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: ""Yes, we'll need to talk to Judge Edmonds. If we can get ..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I agree. Let's keep the changes small and manageable.""]** — Mówca: **Player**
> ""I agree. Let's keep the changes small and manageable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Nia Morgna: ""As long as we address the main issues, I also agree.""*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""Two of the judges are friends of mine, and of similar opinion about the reforms. Consider them with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""So, we only have 3 votes out of 11?""*)
  - -> `[37]` (*Player: ""Who else would be willing to support reforms?""*)
  - -> `[33]` (*Player: ""I'm sure the rest can be bribed.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""They have valid concerns that we need to look at.""]** — Mówca: **Player**
> ""They have valid concerns that we need to look at.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: ""I'll keep working with them and keep you updated, Mr. Pr..."*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""We should reach out to the judges in secret. Some of them might be willing to break rank to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""All means are to be considered in order to succeed.""*)
  - -> `[88]` (*Player: ""They will surely support a just cause for the country an..."*)

### Węzeł `[62]`
Mówca: **Nia Morgna**
> ""I'm with you on this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""We need at least 6 of the 11 judges to vote for the proposal. But Mr. Hawker has enormous influence over the judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: ""We should reach out to the judges in secret. Some of the..."*)

### Węzeł `[64]`
Mówca: **Nia Morgna**
> ""As long as we address the main issues, I also agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "Jump to: [ReformistKeyFigureHub]"*)

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""I'll keep working with them and keep you updated, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""But it will be tough to unite the USP with all the divisive wings that have formed. You must make them follow you loyally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""We did it before for the elections. We can do it again.""*)
  - -> `[84]` (*Player: ""We will convince the leads.""*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""We need the majority of our 130 seats in the Assembly to vote in favour. With PFJP's full support of 70 votes, we will easily surpass the needed 166.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""But it will be tough to unite the USP with all the divis..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""What are the demands?""]** — Mówca: **Player**
> ""What are the final demands?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == true  and  Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[99]` (Petr Vectern), `[100]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""We should run-down each of the main demands of the commi..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""They will not be allowed to dictate the negotiations.""]** — Mówca: **Player**
> ""They will not be allowed to dictate the negotiations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""This is one of the starting points of the whole discussi..."*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""Albin Clavin and his reformist wing would be supporting you. He already weighed in heavily in the committee meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""However, the conservatives would be tough to break. The ..."*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""Constitutional amendments will still be very difficult to accomplish with a reform like this, particularly because we will keep the two-thirds vote system to be able to propose a change. However, the judiciary will not have the final say in the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""This is already what we wanted to do.""*)
  - -> `[76]` (*Player: ""I can't disagree with that.""*)
  - -> `[83]` (*Player: ""We need the Court to even pass this change. Why would th..."*)
  - -> `[78]` (*Player: ""And what good does that do to us?""*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""I think Judge Edmonds can be persuaded. And in extension, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Nia Morgna: ""They weren't really blinded by the Sollist ideology.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""This is already what we wanted to do.""]** — Mówca: **Player**
> ""This is already what our administration wanted to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Nia Morgna: ""Yes. This will ensure that there won't be another politi..."*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""However, the conservatives would be tough to break. The influence of Soll is still living strong in the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""We will eventually remove his influence.""*)
  - -> `[28]` (*Player: ""How many votes do they have?""*)
  - -> `[51]` (*Player: ""Do you think they can be persuaded?""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that statement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""Glad to hear it.""*)

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""They weren't really blinded by the Sollist ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Petr Vectern: ""Yes, those three don't seem to be working directly with ..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""And what good does that do to us?""]** — Mówca: **Player**
> ""And what good does that do to us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Nia Morgna: ""We will be ensuring that there won't be another politica..."*)

### Węzeł `[79]`
Mówca: **Nia Morgna**
> ""Three votes, yes. But I believe that Judge Edmonds can be persuaded as well. She and two other judges, Mr. Dalton and Mr. Martin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Nia Morgna: ""They weren't really blinded by the Sollist ideology.""*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""We'll go through each of the main demands of the committee, and get your input. Mrs. Morgna can explain them further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""We'll start with the first *red line*. The new Constitut..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The loopholes give the President too much power.""]** — Mówca: **Player**
> ""The loopholes give the President too much power which could be misused.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Nia Morgna: ""Whatever you decide it's important to get a balanced pic..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""We'll start with the first *red line*. The new Constitution will fix the loopholes regarding the president's absolute veto powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""Even though Mr. Ricter put on a whole show about why vet..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""We need the Court to even pass this change. Why would they support this?""]** — Mówca: **Player**
> ""We need the Court to even pass this change. Why on earth would they support this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Nia Morgna: ""Most of them won't. But we already talked about my vote ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We will convince the leads.""]** — Mówca: **Player**
> ""We will convince the leads.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""Albin Clavin and his reformist wing would be supporting ..."*)

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""My suggestion is to add a clause detailing the methods the Assembly may override a veto with some sort of a super-majority. One person should never be able to block the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: ""I stand in agreement with Mr. Ricter. The vetoes should ..."*)
  - -> `[81]` (*Player: ""The loopholes give the President too much power.""*)
  - -> `[70]` (*Player: ""They will not be allowed to dictate the negotiations.""*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""So we need as many of the conservatives to support us. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""Gloria Tory. She's well respected by the Sollists. She'l..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ReformistKeyFigureHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "ReformistKeyFigureHub"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""They will surely support a just cause for the country and its future.""]** — Mówca: **Player**
> ""They will surely support a just cause for the country and its future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Lucian looked sceptical."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""All means are to be considered in order to succeed.""]** — Mówca: **Player**
> ""All means are to be considered in order to succeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Nia was taken aback by the statement."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "Jump to: [ReformistKeyFigureHub]"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Nia was taken aback by the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Nia Morgna: ""According to the Constitution, I am a member of the Supr..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""The second one is about the judiciary. The new Constitution will remove the Supreme Court's right to vote on legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Nia Morgna: ""This is yet another point that was unanimously agreed on..."*)

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""Gloria Tory. She's well respected by the Sollists. She'l..."*)

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""According to the Constitution, I am a member of the Supreme Court, which means we already have one vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""Two of the judges are friends of mine, and of similar op..."*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""We'll go through each of the main demands of the committ..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""We should run-down each of the main demands of the committee, and get your input first. Mrs. Morgna can explain them further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""We'll start with the first *red line*. The new Constitut..."*)

### Węzeł `[97]`
Mówca: **Petr Vectern**
> ""I don't think this is up to discussion for any reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""The second one is about the judiciary. The new Constitut..."*)

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""I also have reasons to think she might be in Orso's pocket. She will be tough to break, but we'll need her help to get the conservative support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 = ..."*)

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""Yes, those three don't seem to be working directly with the Chief Justice Hawker. If we can get to Isabel Edmonds, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = ..."*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Yes, we'll need to talk to Judge Edmonds. If we can get to her, we might get the 6 votes needed. That's our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 = ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""I stand in agreement with Mr. Ricter. The vetoes should be removed.""]** — Mówca: **Player**
> ""I stand in agreement with Mr. Ricter. The vetoes should be removed altogether.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Nia Morgna: ""Whatever you decide it's important to get a balanced pic..."*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""This is one of the starting points of the whole discussion about changing the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Petr Vectern: ""I don't think this is up to discussion for any reformists.""*)

### Węzeł `[103]`
Mówca: **Nia Morgna**
> ""Whatever you decide it's important to get a balanced picture. We will be making history by changing the '29 Constitution of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""The second one is about the judiciary. The new Constitut..."*)

### Węzeł `[104]`
Mówca: **Petr Vectern**
> ""Most of their support is necessary to be able to amend the Constitution. And there is only one person who is key to make them back us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""Gloria Tory. She's well respected by the Sollists. She'l..."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucian looked sceptical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Nia Morgna: ""According to the Constitution, I am a member of the Supr..."*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""Gloria Tory. She's well respected by the Sollists. She'll be our biggest obstacle in the Assembly and her demands will be extensive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Nia Morgna: ""I also have reasons to think she might be in Orso's pock..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ==..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Is it possible to pass the Supreme Court?""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ==..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 ..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""Can we reach a two-thirds majority in the Assembly?""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Reforms_Listened_KeyFigure01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
