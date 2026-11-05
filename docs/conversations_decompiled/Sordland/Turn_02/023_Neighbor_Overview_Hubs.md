# Sordland/Turn02/Neighbor Overview Hubs

- **ID konwersacji:** `23`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/023_Neighbor_Overview_Hubs.md`
- **Liczba węzłów dialogowych:** 158
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland`
- `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen`
- `SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome`
- `SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat`
- `SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[22] Sordland/Turn02/FPnT_DiplomacyOverview** (../Turn_02/022_FPnT_DiplomacyOverview.md), Węzeł `[69]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“I was young and I made a mistake.”"** | `[108]` **Iosef Lancea**: "“In fact, there had been a simil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Iosef Lancea**: "“You paid the price for your mis..." |
| `[7]` | **"“Let's move on.”"** | `[5]` **Deivid Wisci**: "“I will start by providing a bri..."<br>`[141]` **Lucian Galade**: "“We should remember that we prom..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true` | *Brak zmian stanu* | `[31]` **Deivid Wisci**: "“Two important neighbouring coun..." |
| `[20]` | **"“I'd like to hear about Agnolia.”"** | `[5]` **Deivid Wisci**: "“I will start by providing a bri..."<br>`[141]` **Lucian Galade**: "“We should remember that we prom..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false` | *Brak zmian stanu* | `[23]` **Deivid Wisci**: "“Our *brotherly* nation to our n..." |
| `[21]` | **"“I want to know more about Valgsland.”"** | `[5]` **Deivid Wisci**: "“I will start by providing a bri..."<br>`[141]` **Lucian Galade**: "“We should remember that we prom..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false` | *Brak zmian stanu* | `[24]` **Deivid Wisci**: "“Our cousins of old across the M..." |
| `[22]` | **"“What's the latest situation in Wehlen?”"** | `[5]` **Deivid Wisci**: "“I will start by providing a bri..."<br>`[141]` **Lucian Galade**: "“We should remember that we prom..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false` | *Brak zmian stanu* | `[25]` **Deivid Wisci**: "“It is tumultuous in the south, ..." |
| `[42]` | **"“What about Lespia?”"** | `[31]` **Deivid Wisci**: "“Two important neighbouring coun..."<br>`[44]` **Lucian Galade**: "“There are hundreds of very priv..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false` | `LookAt("Sordland_Country_Lespia");` | `[39]` **Deivid Wisci**: "“Our southern neighbour is align..." |
| `[43]` | **"“What is the situation with Rumburg?”"** | `[31]` **Deivid Wisci**: "“Two important neighbouring coun..."<br>`[44]` **Lucian Galade**: "“There are hundreds of very priv..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false` | `LookAt("Sordland_Country_Rumburg");` | `[41]` **Deivid Wisci**: "“Now to the most troublesome nat..." |
| `[57]` | **"“We'll think about his request. The matter is still on the table.”"** | `[56]` **Deivid Wisci**: "“Unsurprisingly, the Agnolian Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Deivid Wisci**: "“We could secure them as allies ..." |
| `[58]` | **"“A more comprehensive trade deal sounds beneficial to all sides.”"** | `[56]` **Deivid Wisci**: "“Unsurprisingly, the Agnolian Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Deivid Wisci**: "“Both sides could gain from it b..." |
| `[60]` | **"“It's not easy to forget about the Great Fire of Conriat. Thousands of lives were ..."** | `[59]` **Deivid Wisci**: "“Recently, the relationship has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Deivid Wisci**: "“Holding grudges about the past ..." |
| `[61]` | **"“Breaking the ice with Valgsland could be good, if we are to rise diplomatically.”"** | `[59]` **Deivid Wisci**: "“Recently, the relationship has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Deivid Wisci**: "“I agree they could be potential..." |
| `[65]` | **"“A trade agreement with them would improve stability and increase mutual trade.”"** | `[64]` **Deivid Wisci**: "“But if we want to help them, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Deivid Wisci**: "“There would be many bargaining ..." |
| `[66]` | **"“Why help such a disorganized state? Not sure about what we can do to help them.”"** | `[64]` **Deivid Wisci**: "“But if we want to help them, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Deivid Wisci**: "“It does pose many risks, but we..." |
| `[68]` | **"“I will take your advice in consideration.”"** | `[67]` **Deivid Wisci**: "“They are strong and have the mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Deivid Wisci**: "“These types of nations will alw..." |
| `[69]` | **"“Rumburg is and always will be a rogue like state. Nothing can be done about them.”"** | `[67]` **Deivid Wisci**: "“They are strong and have the mo..."<br>`[51]` **Deivid Wisci**: "“This covers the overview of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Deivid Wisci**: "“We can act in our limits and ma..." |
| `[70]` | **"“Lespia is a sleeping giant. We should not awake them.”"** | `[52]` **Deivid Wisci**: "“Our past relations have been gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Deivid Wisci**: "“They surely are a powerful nati..." |
| `[71]` | **"“They keep turning a blind eye towards the region. Thinking that Lespia is above i..."** | `[52]` **Deivid Wisci**: "“Our past relations have been gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Deivid Wisci**: "“The Lespian mentality is influe..." |
| `[81]` | **"“I did what was right.”"** | `[108]` **Iosef Lancea**: "“In fact, there had been a simil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Iosef Lancea**: "“Soldiers do not decide on what ..." |
| `[92]` | **"“We must prevent them from interfering in our affairs.”"** | `[67]` **Deivid Wisci**: "“They are strong and have the mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Deivid Wisci**: "“They have shown similar behavio..." |
| `[94]` | **"“Allying with the richest regional nation could be beneficial.”"** | `[52]` **Deivid Wisci**: "“Our past relations have been gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Deivid Wisci**: "“It could be but it would also m..." |
| `[97]` | **"“The Rumburg threat is one of our top priorities. You can be assured of that.”"** | `[95]` **Narrator**: "Iosef looked stern and full of r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Deivid Wisci**: "“We are always in dialogue with ..." |
| `[100]` | **"“I think the threat is far too overblown.”"** | `[95]` **Narrator**: "Iosef looked stern and full of r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Deivid Wisci**: "“I agree, some in our government..." |
| `[102]` | **"“Our values are too different with Lespia. It will be hard to see eye to eye.”"** | `[73]` **Narrator**: "Lucian cleared his throat." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Deivid Wisci**: "“I completely agree. Lespia has ..." |
| `[104]` | **"“The Capitalism of Lespia is inspirational to me. Look at their economic power.”"** | `[73]` **Narrator**: "Lucian cleared his throat." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Deivid Wisci**: "“Everything comes at a cost. In ..." |
| `[110]` | **"“Past is past. Let's move on.”"** | `[108]` **Iosef Lancea**: "“In fact, there had been a simil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "He opened his mouth to say somet..." |
| `[111]` | **"“And you made me sleep in a prison cell for it. I will never forget that.”"** | `[108]` **Iosef Lancea**: "“In fact, there had been a simil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Iosef Lancea**: "“That is the point of disciplina..." |
| `[118]` | **"“We should maintain the existing agreement. We can't lose our advantage.”"** | `[56]` **Deivid Wisci**: "“Unsurprisingly, the Agnolian Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Deivid Wisci**: "“That would be the most pragmati..." |
| `[130]` | **"“I'm sceptical about relaxed immigration.”"** | `[29]` **Iosef Lancea**: "“In addition, a relaxed immigrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Iosef Lancea**: "“You should be. We have already ..." |
| `[131]` | **"“I'm supportive of relaxed immigration.”"** | `[29]` **Iosef Lancea**: "“In addition, a relaxed immigrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Iosef Lancea**: "“I would re-think the matter ser..." |
| `[133]` | **"“Sordland paid enough by housing millions of refugees during the Wehlen Civil War...."** | `[64]` **Deivid Wisci**: "“But if we want to help them, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Deivid Wisci**: "“And when we had our civil war, ..." |
| `[135]` | **"“We shouldn't take any sides between the regional powers.”"** | `[59]` **Deivid Wisci**: "“Recently, the relationship has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Deivid Wisci**: "“It could lead us to be squeezed..." |
| `[137]` | **"“The strait is of high strategic value to us.”"** | `[63]` **Lucian Galade**: "“This causes significant risks t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucian Galade**: "“Iosef, the Navy is keeping an e..." |
| `[139]` | **"“We can't expect the worst.”"** | `[63]` **Lucian Galade**: "“This causes significant risks t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucian Galade**: "“Iosef, the Navy is keeping an e..." |

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
  - -> `[5]` (*Deivid Wisci: "“I will start by providing a brief overview of our curren..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“Rumburg is and always will be a rogue like state. Nothin..."*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I was young and I made a mistake.”"]** — Mówca: **Player**
> "“I was young and I made a mistake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: "“You paid the price for your mistake so it doesn't matter..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Overview Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true..."*)

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“I will start by providing a brief overview of our current status with our neighbours. What would you like to start with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "Overview Hub"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "Jump to: [Overview Hub]"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Let's move on.”"]** — Mówca: **Player**
> "“Let's move on.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci), `[141]` (Lucian Galade), `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Two important neighbouring countries remain. Lespia and ..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Overview Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "Overview Hub"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "“I want to know more about Valgsland.”"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "Jump to: [Overview Hub]"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "Jump to: [Overview Hub]"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“What's the latest situation in Wehlen?”"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == fa..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“I'd like to hear about Agnolia.”"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I'd like to hear about Agnolia.”"]** — Mówca: **Player**
> "“I'd like to hear about Agnolia.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci), `[141]` (Lucian Galade), `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deivid Wisci: "“Our *brotherly* nation to our north-east, Agnolia. They ..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I want to know more about Valgsland.”"]** — Mówca: **Player**
> "“I want to know more about Valgsland.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci), `[141]` (Lucian Galade), `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Deivid Wisci: "“Our cousins of old across the Markian Sea wish to have g..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“What's the latest situation in Wehlen?”"]** — Mówca: **Player**
> "“What's the latest situation in Wehlen?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci), `[141]` (Lucian Galade), `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deivid Wisci: "“It is tumultuous in the south, as always. Wiktor Smolak ..."*)

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Our *brotherly* nation to our north-east, Agnolia. They are still diplomatically non-aligned and probably has one of the most democratic systems between our neighbours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Agnolia");"*)

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Our cousins of old across the Markian Sea wish to have good relations with us. As we all know, Valgsland is a socialist republic aligned with United Contana. They are an important regional player.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Valgsland");"*)

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“It is tumultuous in the south, as always. Wiktor Smolak is expanding his powers among protests from Wehzek people. However, he is quite positive about a normalisation of relationship between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Wehlen");"*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“Additionally, the latest numbers indicate that currently, a million Agno-Sordish citizens live in the Agnland region of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: "“Which creates a link between foreign policy and our inte..."*)

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“They haven't been in good standing with us for the past two hundred years. Recently, they have also joined the Communist Contanan Security Pact, subjugating themselves to United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Iosef Lancea: "“On top of that, territorial issues have been flaring up ..."*)

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Our main goal should be to avoid a refugee crisis like the late 1920’s. That civil war had major security and economic repercussions on Sordish soil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Iosef Lancea: "“One of the demands of President Smolak was to tighten ou..."*)

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> "“In addition, a relaxed immigration policy was one of Agnolia's main requests. Which is unacceptable. Most of the migrants in our country haven't even assimilated into Sordish culture. Adding more won't help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“I'm sceptical about relaxed immigration.”"*)
  - -> `[131]` (*Player: "“I'm supportive of relaxed immigration.”"*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Unfortunately, billions of Sordish Ren worth of cargo is transported close to Valgslandian maritime borders on the Markian Sea and the Grey Strait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“This causes significant risks to our imports and exports..."*)

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Two important neighbouring countries remain. Lespia and Rumburg. Which would you like to hear about first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Overview Hub 2"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Overview Hub 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true ..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“What about Lespia?”"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == fa..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“What is the situation with Rumburg?”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Deivid Wisci**
> "“Our southern neighbour is aligning itself more and more with Arcasia. Lespia is currently led by Prime Minister Patricio Alvarez.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“They are the jewel of the continent and the second large..."*)

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“You paid the price for your mistake so it doesn't matter anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He opened his mouth to continue but Deivid cut in."*)

### Węzeł `[41]`
Mówca: **Deivid Wisci**
> "“Now to the most troublesome nation; Rumburg. A constitutional monarchy led by Queen Beatrice Livingston.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "SharedSupport.Codex_History_ImportantEvents_AnnexationOfD..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“What about Lespia?”"]** — Mówca: **Player**
> "“What about Lespia?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == false`
- **Kontekst wejściowy (poprzednik):** `[31]` (Deivid Wisci), `[44]` (Lucian Galade), `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Lespia");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“What is the situation with Rumburg?”"]** — Mówca: **Player**
> "“What is the situation with Rumburg?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == false`
- **Kontekst wejściowy (poprzednik):** `[31]` (Deivid Wisci), `[44]` (Lucian Galade), `[105]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Rumburg");"*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“There are hundreds of very privileged oligarchs who invest inside and outside of Lespia. Some made significant business investments in the cities of Benfi and Valgen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia = true"*)

### Węzeł `[45]`
Mówca: **Deivid Wisci**
> "“I am certain that the recession has a lot to do with their retraction of investments. Once they see that money isn't in the picture they vanish rather quickly because they are capitalists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Iosef Lancea: "“They have shown a selfish attitude during the Wehlen Civ..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> "“We could use their aggressive attitude against them by convincing the international community.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Lucian grabbed the Lachaven Times newspaper and put his f..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“While Thornbourgh openly denies such claims, their past and current actions make it clear that they want to destabilize us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Iosef Lancea: "“The weapons caches found by our intelligence agency clea..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "Jump to: [Overview Hub 2]"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "Jump to: [Overview Hub 2]"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Overview Hub 2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Overview Hub 2"*)

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“This covers the overview of the current situation. We will move on to our trade choice and the response to Rumburg's diplomatic escalation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();  // Turns off look at mode"*)

### Węzeł `[52]`
Mówca: **Deivid Wisci**
> "“Our past relations have been great but during the last decade, their investments to Sordland dwindled due to our instability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“Allying with the richest regional nation could be benefi..."*)
  - -> `[70]` (*Player: "“Lespia is a sleeping giant. We should not awake them.”"*)
  - -> `[71]` (*Player: "“They keep turning a blind eye towards the region. Thinki..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true ..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == tru..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deivid Wisci: "“This covers the overview of the current situation. We wi..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia == true && BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Lespia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“Unsurprisingly, the Agnolian Prime Minister Maartin Van Hoorten is expecting better cooperation through a new, fairer trade deal with us. It was one of his election mandates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“We'll think about his request. The matter is still on th..."*)
  - -> `[58]` (*Player: "“A more comprehensive trade deal sounds beneficial to all..."*)
  - -> `[118]` (*Player: "“We should maintain the existing agreement. We can't lose..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We'll think about his request. The matter is still on the table.”"]** — Mówca: **Player**
> "“We'll think about his request. The matter is still on the table.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Deivid Wisci: "“We could secure them as allies if we make concessions in..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“A more comprehensive trade deal sounds beneficial to all sides.”"]** — Mówca: **Player**
> "“A more comprehensive trade deal sounds beneficial to all sides.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Deivid Wisci: "“Both sides could gain from it but Agnolia has more to wi..."*)

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“Recently, the relationship has warmed up thanks to Emmerich Hegel. As a result, diplomatic talks can be conducted in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“It's not easy to forget about the Great Fire of Conriat...."*)
  - -> `[61]` (*Player: "“Breaking the ice with Valgsland could be good, if we are..."*)
  - -> `[135]` (*Player: "“We shouldn't take any sides between the regional powers.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It's not easy to forget about the Great Fire of Conriat. Thousands of lives were lost that day.”"]** — Mówca: **Player**
> "“It's not easy to forget about the Great Fire of Conriat. Thousands of lives were lost that day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Deivid Wisci: "“Holding grudges about the past wouldn't be a logical str..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Breaking the ice with Valgsland could be good, if we are to rise diplomatically.”"]** — Mówca: **Player**
> "“Breaking the ice with Valgsland could be good, if we are to rise diplomatically.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Deivid Wisci: "“I agree they could be potential allies in my opinion. Th..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Lucian looked slightly worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“Unfortunately, billions of Sordish Ren worth of cargo is..."*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“This causes significant risks to our imports and exports in the case of a deterioration in relations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“The strait is of high strategic value to us.”"*)
  - -> `[139]` (*Player: "“We can't expect the worst.”"*)

### Węzeł `[64]`
Mówca: **Deivid Wisci**
> "“But if we want to help them, we must not treat refugees like we did in the '30s. I still can’t stomach the inhumanity those people suffered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“A trade agreement with them would improve stability and ..."*)
  - -> `[66]` (*Player: "“Why help such a disorganized state? Not sure about what ..."*)
  - -> `[133]` (*Player: "“Sordland paid enough by housing millions of refugees dur..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“A trade agreement with them would improve stability and increase mutual trade.”"]** — Mówca: **Player**
> "“A trade agreement with them would improve stability and increase mutual trade.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Deivid Wisci: "“There would be many bargaining chips discussed, but Wehl..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Why help such a disorganized state? Not sure about what we can do to help them.”"]** — Mówca: **Player**
> "“Why help such a disorganized state? I'm not even sure what we can do to help them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Deivid Wisci: "“It does pose many risks, but we could ensure that we hav..."*)

### Węzeł `[67]`
Mówca: **Deivid Wisci**
> "“They are strong and have the motivation, as well as the means, to damage us. We shouldn't give them any reasons to pursue aggression.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“I will take your advice in consideration.”"*)
  - -> `[69]` (*Player: "“Rumburg is and always will be a rogue like state. Nothin..."*)
  - -> `[92]` (*Player: "“We must prevent them from interfering in our affairs.”"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I will take your advice in consideration.”"]** — Mówca: **Player**
> "“I will take your advice in consideration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Deivid Wisci: "“These types of nations will always try to make up a casu..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Rumburg is and always will be a rogue like state. Nothing can be done about them.”"]** — Mówca: **Player**
> "“Rumburg is and always will be a rogue-like state. Nothing can be done about them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Deivid Wisci), `[51]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Deivid Wisci: "“We can act in our limits and make sure we are prepared f..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Lespia is a sleeping giant. We should not awake them.”"]** — Mówca: **Player**
> "“Lespia is a sleeping giant. We should not awake them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Deivid Wisci: "“They surely are a powerful nation. Despite that, they do..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“They keep turning a blind eye towards the region. Thinking that Lespia is above it all.”"]** — Mówca: **Player**
> "“They keep turning a blind eye towards the region, thinking that Lespia is above it all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Deivid Wisci: "“The Lespian mentality is influenced by a certain aura of..."*)

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“They have shown a selfish attitude during the Wehlen Civil War by closing their borders and funnelling refugees to cross into Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Lucian cleared his throat."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Lucian cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Our values are too different with Lespia. It will be har..."*)
  - -> `[104]` (*Player: "“The Capitalism of Lespia is inspirational to me. Look at..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == tr..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“Let's move on.”"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia == true  || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland == true || BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia"] == true   or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland"] == true  or  Variable["BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“The weapons caches found by our intelligence agency clearly shows what their goals are. Our military must be steadfast and our diplomacy valiant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Iosef looked stern and full of resolve."*)

### Węzeł `[78]`
Mówca: **Deivid Wisci**
> "“It is in our national interest to prevent the formation of a failed state on our western border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“Wehlen has been increasingly aligning itself towards the..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“They are the jewel of the continent and the second largest economy in Eastern Merkopa. Though wealthy, Lespia suffers from excessive economic inequality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Deivid Wisci: "“Our past relations have been great but during the last d..."*)

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“I highly advise caution and calculated action against Rumburg. Our military must be prepared, the threat is real.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Deivid Wisci: "“They are strong and have the motivation, as well as the ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I did what was right.”"]** — Mówca: **Player**
> "“I did what was right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Iosef Lancea: "“Soldiers do not decide on what is right. Soldiers do wha..."*)

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“Soldiers do not decide on what is right. Soldiers do what they are told to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He opened his mouth to continue but Deivid cut in."*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“We are actively monitoring the sea routes and cargo ships. For now, there is no immediate threat. But we don't know what can happen in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Valgsland = true"*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“Wehlen has been increasingly aligning itself towards the communist alliance, another point to analyse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Wehlen = true"*)

### Węzeł `[85]`
Mówca: **Deivid Wisci**
> "“Our focus should be on the current matters. The Bludish minority is very large inside Wehlen too, which is a factor to consider.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Deivid Wisci: "“It is in our national interest to prevent the formation ..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He opened his mouth to say something but Deivid cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Deivid Wisci: "“Our focus should be on the current matters. The Bludish ..."*)

### Węzeł `[87]`
Mówca: **Deivid Wisci**
> "“They surely are a powerful nation. Despite that, they don't tend to meddle in the region and haven't for a long time, with the exception of Wehlen. Let's not antagonize them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Deivid Wisci: "“I am certain that the recession has a lot to do with the..."*)

### Węzeł `[88]`
Mówca: **Deivid Wisci**
> "“The Lespian mentality is influenced by a certain aura of heroism and specialism. Their moral compass is different from ours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Deivid Wisci: "“I am certain that the recession has a lot to do with the..."*)

### Węzeł `[89]`
Mówca: **Deivid Wisci**
> "“These types of nations will always try to make up a casus belli, a reason to declare war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“While Thornbourgh openly denies such claims, their past ..."*)

### Węzeł `[90]`
Mówca: **Deivid Wisci**
> "“We can act in our limits and make sure we are prepared for anything. Sword rattling is not advised in my opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“While Thornbourgh openly denies such claims, their past ..."*)

### Węzeł `[91]`
Mówca: **Deivid Wisci**
> "“They have shown similar behaviour to their neighbouring countries before but we must be cautious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“While Thornbourgh openly denies such claims, their past ..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We must prevent them from interfering in our affairs.”"]** — Mówca: **Player**
> "“We must prevent them from interfering in our affairs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Deivid Wisci: "“They have shown similar behaviour to their neighbouring ..."*)

### Węzeł `[93]`
Mówca: **Deivid Wisci**
> "“It could be but it would also mean that we would draw closer to the Arcasia block and near the Arcasian Treaty Organisation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Deivid Wisci: "“I am certain that the recession has a lot to do with the..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Allying with the richest regional nation could be beneficial.”"]** — Mówca: **Player**
> "“Allying with the richest regional nation could be beneficial.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Deivid Wisci: "“It could be but it would also mean that we would draw cl..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Iosef looked stern and full of resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "“The Rumburg threat is one of our top priorities. You can..."*)
  - -> `[100]` (*Player: "“I think the threat is far too overblown.”"*)

### Węzeł `[96]`
Mówca: **Deivid Wisci**
> "“We are always in dialogue with our Rumburg ambassador to make sure a channel is open to solve disputes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: "“We could use their aggressive attitude against them by c..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“The Rumburg threat is one of our top priorities. You can be assured of that.”"]** — Mówca: **Player**
> "“The Rumburg threat is one of our top priorities. You can be assured of that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Deivid Wisci: "“We are always in dialogue with our Rumburg ambassador to..."*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“Either way, treading carefully with them would be the safest bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Lucian grabbed the Lachaven Times newspaper and put his f..."*)

### Węzeł `[99]`
Mówca: **Deivid Wisci**
> "“I agree, some in our government are taking the issue out of proportion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“Either way, treading carefully with them would be the sa..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I think the threat is far too overblown.”"]** — Mówca: **Player**
> "“I think the threat is far too overblown.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Deivid Wisci: "“I agree, some in our government are taking the issue out..."*)

### Węzeł `[101]`
Mówca: **Deivid Wisci**
> "“I completely agree. Lespia has for a long time benefited from us through our old tariffs. They are after exploitation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“There are hundreds of very privileged oligarchs who inve..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Our values are too different with Lespia. It will be hard to see eye to eye.”"]** — Mówca: **Player**
> "“Our values are too different with Lespia. It will be hard to see eye to eye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Deivid Wisci: "“I completely agree. Lespia has for a long time benefited..."*)

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“Everything comes at a cost. In Lespia the cost is wealth inequality but business people are getting richer and richer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“There are hundreds of very privileged oligarchs who inve..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“The Capitalism of Lespia is inspirational to me. Look at their economic power.”"]** — Mówca: **Player**
> "“The Capitalism of Lespia is inspirational to me. Look at their economic power.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Deivid Wisci: "“Everything comes at a cost. In Lespia the cost is wealth..."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“Their abrupt announcement about the closure of the Rumburg consulate in Lachaven is yet another step in their escalation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Rumburg = true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome = true`
- **Efekt skryptowy (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_AnnexationOfDome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Iosef Lancea: "“I highly advise caution and calculated action against Ru..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Lucian grabbed the Lachaven Times newspaper and put his finger on the article about the latest diplomatic incident."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: "“Their abrupt announcement about the closure of the Rumbu..."*)

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“In fact, there had been a similar refugee situation in the past. Even Mr. President himself chose to disobey direct orders from his commanding officer at the time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“I was young and I made a mistake.”"*)
  - -> `[110]` (*Player: "“Past is past. Let's move on.”"*)
  - -> `[111]` (*Player: "“And you made me sleep in a prison cell for it. I will ne..."*)
  - -> `[81]` (*Player: "“I did what was right.”"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He was right, I did remember that winter. I remembered the despair in the refugees' eyes when we forcefully escorted them back to the Wehlen border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Deivid Wisci: "“It is in our national interest to prevent the formation ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Past is past. Let's move on.”"]** — Mówca: **Player**
> "“Past is past. Let's move on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He opened his mouth to say something but Deivid cut in."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“And you made me sleep in a prison cell for it. I will never forget that.”"]** — Mówca: **Player**
> "“And you made me sleep in a prison cell for it. I will never forget that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Iosef Lancea: "“That is the point of disciplinary action.”"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He opened his mouth to continue but Deivid cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Deivid Wisci: "“Our focus should be on the current matters. The Bludish ..."*)

### Węzeł `[113]`
Mówca: **Iosef Lancea**
> "“That is the point of disciplinary action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He opened his mouth to continue but Deivid cut in."*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“Which creates a link between foreign policy and our internal affairs. These people have suffered socio-economically, which led them to crime and other problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Iosef Lancea: "“In addition, a relaxed immigration policy was one of Agn..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Economic stagnation is a worry for them. Their primary issue is their heavy reliance on foreign investment from us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Deivid Wisci: "“Agnolia is our most friendly neighbour. We have been all..."*)

### Węzeł `[116]`
Mówca: **Deivid Wisci**
> "“It's also the most significant sea power in almost all of Merkopa. It is the only country that can rival the superpowers with their navy. We had hostile relations with them after several wars in the 19th century, which we wouldn't want to experience again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Deivid Wisci: "“Recently, the relationship has warmed up thanks to Emmer..."*)

### Węzeł `[117]`
Mówca: **Deivid Wisci**
> "“Despite purging the Wehzek communists, reports indicate that they have been warming up to Contanan international aid. As you know, Wehlen’s stability was always a concern for the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Deivid Wisci: "“But if we want to help them, we must not treat refugees ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“We should maintain the existing agreement. We can't lose our advantage.”"]** — Mówca: **Player**
> "“We should maintain the existing agreement. We can't lose our advantage.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Deivid Wisci: "“That would be the most pragmatic choice. Our export tari..."*)

### Węzeł `[119]`
Mówca: **Deivid Wisci**
> "“We could secure them as allies if we make concessions in a new agreement. Rumburg is our common threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“Additionally, the latest numbers indicate that currently..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Military_Order_Accomplished == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He was right, I did remember that winter. I remembered th..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Military_Order_Accomplished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He was right, I did remember that winter. I remembered ho..."*)

### Węzeł `[123]`
Mówca: **Iosef Lancea**
> "“On top of that, territorial issues have been flaring up between Agnolia and Valgsland because of the Heljiland Island. The Sordish Navy is very concerned with this volatile situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Lucian looked slightly worried."*)

### Węzeł `[124]`
Mówca: **Deivid Wisci**
> "“Both sides could gain from it but Agnolia has more to win than us. They want to protect their weaker industries which we are profiting from selling our goods to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“Additionally, the latest numbers indicate that currently..."*)

### Węzeł `[125]`
Mówca: **Deivid Wisci**
> "“That would be the most pragmatic choice. Our export tariffs to Agnolia are incredibly low under the current agreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“Additionally, the latest numbers indicate that currently..."*)

### Węzeł `[126]`
Mówca: **Deivid Wisci**
> "“Holding grudges about the past wouldn't be a logical strategy if we are focusing on pragmatic foreign policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“They haven't been in good standing with us for the past ..."*)

### Węzeł `[127]`
Mówca: **Deivid Wisci**
> "“There would be many bargaining chips discussed, but Wehlen could be a new partner in the region. We would also invest in stability there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Deivid Wisci: "“Our main goal should be to avoid a refugee crisis like t..."*)

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“You should be. We have already witnessed several society shifting waves of migration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“I would re-think the matter seriously because it has great influence on our society and values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I'm sceptical about relaxed immigration.”"]** — Mówca: **Player**
> "“I'm sceptical about relaxed immigration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Iosef Lancea: "“You should be. We have already witnessed several society..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I'm supportive of relaxed immigration.”"]** — Mówca: **Player**
> "“I'm supportive of relaxed immigration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Iosef Lancea: "“I would re-think the matter seriously because it has gre..."*)

### Węzeł `[132]`
Mówca: **Deivid Wisci**
> "“And when we had our civil war, they were there for us. That is how refugee rights work internationally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Deivid Wisci: "“Our main goal should be to avoid a refugee crisis like t..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Sordland paid enough by housing millions of refugees during the Wehlen Civil War. No more.”"]** — Mówca: **Player**
> "“Sordland paid enough by housing millions of refugees during the Wehlen Civil War. No more.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Deivid Wisci: "“And when we had our civil war, they were there for us. T..."*)

### Węzeł `[134]`
Mówca: **Deivid Wisci**
> "“It does pose many risks, but we could ensure that we have more influence in the region by increasing our trade and border security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Deivid Wisci: "“Our main goal should be to avoid a refugee crisis like t..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“We shouldn't take any sides between the regional powers.”"]** — Mówca: **Player**
> "“We shouldn't take any sides between the regional powers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Deivid Wisci: "“It could lead us to be squeezed between the two with no ..."*)

### Węzeł `[136]`
Mówca: **Deivid Wisci**
> "“I agree they could be potential allies in my opinion. The situation in the region necessitates that we find allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“They haven't been in good standing with us for the past ..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“The strait is of high strategic value to us.”"]** — Mówca: **Player**
> "“The strait is of high strategic value to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: "“Iosef, the Navy is keeping an eye on the situation from ..."*)

### Węzeł `[138]`
Mówca: **Deivid Wisci**
> "“It could lead us to be squeezed between the two with no protection. It's a potential situation to be considered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Iosef Lancea: "“They haven't been in good standing with us for the past ..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“We can't expect the worst.”"]** — Mówca: **Player**
> "“We can't expect the worst.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: "“Iosef, the Navy is keeping an eye on the situation from ..."*)

### Węzeł `[140]`
Mówca: **Lucian Galade**
> "“Iosef, the Navy is keeping an eye on the situation from a distance, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“We are actively monitoring the sea routes and cargo ship..."*)

### Węzeł `[141]`
Mówca: **Lucian Galade**
> "“We should remember that we promised to tighten our immigration laws in the election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion = true`
- **Efekt skryptowy (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_HeljiIslandInvasion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: "“Economic stagnation is a worry for them. Their primary i..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat = true`
- **Efekt skryptowy (`userScript`):** `Variable["SharedSupport.Codex_History_ImportantEvents_GreatFireOfConriat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Deivid Wisci: "“It's also the most significant sea power in almost all o..."*)

### Węzeł `[144]`
Mówca: **Lucian Galade**
> "“We should remember that we promised to keep our immigration laws relaxed in the election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_Hub_Agnolia = true"*)

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“Agnolia is our most friendly neighbour. We have been allies for the longest time after Rumburg's actions in the region. This fact needs to be a part of the equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“Unsurprisingly, the Agnolian Prime Minister Maartin Van ..."*)

### Węzeł `[146]`
Mówca: **Iosef Lancea**
> "“One of the demands of President Smolak was to tighten our immigration laws, so the political refugees don't escape to Sordland. There has been a recent purge that pushed many Bludish to flee to Bergia. It is definitely troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Iosef Lancea: "“Gumren Outpost has regained its importance due to this. ..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: "“We should remember that we promised to keep our immigrat..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: "“We should remember that we promised to tighten our immig..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "He was right, I did remember that winter. I remembered how cold it was when I let the refugees slip through. I was discharged of my duties as a result, by Major Iosef Lancea, no less, spending the rest of my service cleaning toilets and sleeping in a cell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“In fact, there had been a similar refugee situation in t..."*)

### Węzeł `[151]`
Mówca: **Iosef Lancea**
> "“Gumren Outpost has regained its importance due to this. I'm sure you would remember that winter at the border outpost, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Agnolia");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Agnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "SharedSupport.Codex_History_ImportantEvents_HeljiIslandIn..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();

// Turns off look at mode`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();
-- Turns off look at mode;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Valgsland");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "SharedSupport.Codex_History_ImportantEvents_GreatFireOfCo..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Wehlen");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Wehlen");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Deivid Wisci: "“Despite purging the Wehzek communists, reports indicate ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Lespia");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Deivid Wisci: "“Our southern neighbour is aligning itself more and more ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Rumburg");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Rumburg");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Deivid Wisci: "“Now to the most troublesome nation; Rumburg. A constitut..."*)
