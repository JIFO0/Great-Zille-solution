# Sordland/Turn01/InT_Infrastructure

- **ID konwersacji:** `8`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/008_InT_Infrastructure.md`
- **Liczba węzłów dialogowych:** 144
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGameIsolated.Turn01_EnT_Listened_Highway`
- `BaseGameIsolated.Turn01_EnT_Listened_Railway`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGameIsolated.Turn01_EnT_Listened_Highway`
- `BaseGameIsolated.Turn01_EnT_Listened_Railway`
- `BaseGameSupport.Journal_Turn01_PickedHighway`
- `BaseGameSupport.Journal_Turn01_PickedRailway`
- `GameCondition.Turn01_InT_Infrastructure`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“What can we focus on?”"** | `[3]` **Symon Holl**: "“Mr. President, we need to focus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Symon Holl**: "“On the one hand, businessmen ar..." |
| `[8]` | **"“The H-3 highway project.”"** | `[33]` **Symon Holl**: "“So, which one do you want to he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Symon Holl**: "“The H-3 project aims to improve..." |
| `[11]` | **"“The L-1 high-speed rail project.”"** | `[33]` **Symon Holl**: "“So, which one do you want to he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Symon Holl**: "“Your predecessor Alphonso faile..." |
| `[13]` | **""We can't leave the request of Eric Niel -- a party member -- unanswered.""** | `[25]` **Lileas Graf**: "“He told us that even trucks are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Lileas Graf**: "“I know him personally and can v..." |
| `[14]` | **"“I agree. This could also hurt the local businesses.”"** | `[25]` **Lileas Graf**: "“He told us that even trucks are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lileas Graf**: "“It is, bless their souls. I'm h..." |
| `[15]` | **"“Agreed. The superpowers have led the way with their high-quality technology. We'v..."** | `[24]` **Gus Manger**: "“News about the new electric tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Gus Manger**: "“Only technological advancement ..." |
| `[16]` | **"“This could also empower businesses and bring investments.”"** | `[24]` **Gus Manger**: "“News about the new electric tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Gus Manger**: "“This should be our priority, gr..." |
| `[18]` | **"“That must be cumbersome for the citizens.""** | `[25]` **Lileas Graf**: "“He told us that even trucks are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lileas Graf**: "“It is, bless their souls. I'm h..." |
| `[19]` | **"“The major cities of Sordland need more infrastructure to support their growing po..."** | `[24]` **Gus Manger**: "“News about the new electric tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Gus Manger**: "“This should be our priority, gr..." |
| `[21]` | **"Look at the map."** | `[20]` **Symon Holl**: "“Let's take a more detailed look..." | *Brak (Dostępna bezwarunkowo)* | `LookAt("Sordland_City_Lachaven"); ;` | `[130]` **Lileas Graf**: "“The H-3 highway route starts he..." |
| `[22]` | **"“I have decided on the H-3 highway project to improve the infrastructure in our po..."** | `[113]` **Symon Holl**: "“Excellent. What will your final..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn01_InT_Investment_Highway"] = true;`<br>`LookAt("Sordland_City_Arvory"); ;`<br>*(+1 skryptów)* | `[43]` **Lileas Graf**: "“Thank God. I knew that you woul..." |
| `[23]` | **"“I have decided on the L-1 high-speed rail project to improve the connection betwe..."** | `[113]` **Symon Holl**: "“Excellent. What will your final..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn01_InT_Investment_Railway"] = true;`<br>`LookAt("Sordland_City_Holsord"); ;`<br>*(+1 skryptów)* | `[44]` **Gus Manger**: "“The right choice, Mr. President.”" |
| `[28]` | **"Look at the map."** | `[27]` **Symon Holl**: "“Our plan is to upgrade the old ..." | *Brak (Dostępna bezwarunkowo)* | `LookAt("Sordland_City_Holsord"); ;` | `[133]` **Gus Manger**: "“The planned construction starts..." |
| `[30]` | **"“Thank you all for your contributions and thoughts.”"** | `[29]` **Symon Holl**: "“The Ministry estimates that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Lileas Graf**: "“See you soon, Mr. Rayne.”" |
| `[31]` | **"“Good. Is there anything else?”"** | `[29]` **Symon Holl**: "“The Ministry estimates that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Symon Holl**: "“This should be all, Mr. Preside..." |
| `[35]` | **"“We must prove our capabilities. The people must know that this administration can..."** | `[59]` **Symon Holl**: "“What really matters is that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Symon Holl**: "“To that point, I defined two im..." |
| `[36]` | **"“We must improve the economy of the nation and bring it out of recession.”"** | `[59]` **Symon Holl**: "“What really matters is that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Symon Holl**: "“To that point, I defined two im..." |
| `[39]` | **"“Very interesting. But I still want to hear about the highway project.”"** | `[106]` **Symon Holl**: "“Businessmen in the region will ..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false` | *Brak zmian stanu* | `[9]` **Symon Holl**: "“The H-3 project aims to improve..." |
| `[40]` | **"“Very interesting. But I still want to hear about the railway project.”"** | `[107]` **Lileas Graf**: "“Our citizens will be quite plea..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false` | *Brak zmian stanu* | `[10]` **Symon Holl**: "“Your predecessor Alphonso faile..." |
| `[41]` | **"“I have settled on a decision.”"** | `[106]` **Symon Holl**: "“Businessmen in the region will ..."<br>`[107]` **Lileas Graf**: "“Our citizens will be quite plea..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false`<br>`Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false` | `LookAt("Sordland_City_Lachaven"); ;` | `[113]` **Symon Holl**: "“Excellent. What will your final..." |
| `[42]` | **"Nod."** | `[3]` **Symon Holl**: "“Mr. President, we need to focus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Symon Holl**: "“On the one hand, businessmen ar..." |
| `[58]` | **"“Agreed.”"** | `[3]` **Symon Holl**: "“Mr. President, we need to focus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Symon Holl**: "“On the one hand, businessmen ar..." |
| `[61]` | **"“We need to pick the most profitable option for economic growth.”"** | `[5]` **Lileas Graf**: "“On the other hand, citizens are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Gus Manger**: "“Which is obviously connecting o..." |
| `[62]` | **"“The citizens and their demands matter the most.”"** | `[5]` **Lileas Graf**: "“On the other hand, citizens are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lileas Graf**: "“Their demands are just. The dir..." |
| `[63]` | **"“We need to heed the calls of our businesses in these days of recession.”"** | `[5]` **Lileas Graf**: "“On the other hand, citizens are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Gus Manger**: "“Agreed. Improving the rail conn..." |
| `[67]` | **"“Yes, we should link these rural areas in the middle with the major cities of Sord..."** | `[116]` **Gus Manger**: "“The L-1 will significantly boos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lileas Graf**: "“We are talking about the wealth..." |
| `[68]` | **"“I believe this would benefit Sordish businesses and Sordland as a whole.”"** | `[116]` **Gus Manger**: "“The L-1 will significantly boos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lileas Graf**: "“For the wealthy and middle-clas..." |
| `[69]` | **"“Investing in regions that are already developed makes little sense.”"** | `[116]` **Gus Manger**: "“The L-1 will significantly boos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lileas Graf**: "“I completely agree. Our attenti..." |
| `[70]` | **"“We should no longer neglect a key region for our trade with Agnolia.”"** | `[73]` **Lileas Graf**: "“As mayor, I saw the central gov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Gus Manger**: "“Sure. But most goods flow to La..." |
| `[71]` | **"“Our Agno-Sordish citizens should be respected as Sords like all of us.”"** | `[73]` **Lileas Graf**: "“As mayor, I saw the central gov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Gus Manger**: "“Yes, there should be no prefere..." |
| `[72]` | **"“It makes little sense to put investments in such a remote region.”"** | `[73]` **Lileas Graf**: "“As mayor, I saw the central gov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Gus Manger**: "“That is why we should initiate ..." |
| `[102]` | **""I'm not fully convinced yet. Please explain further.""** | `[24]` **Gus Manger**: "“News about the new electric tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Symon Holl**: "“Our plan is to upgrade the old ..." |
| `[105]` | **"“I'm not sure if this region should be a priority for us right now.”"** | `[25]` **Lileas Graf**: "“He told us that even trucks are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Symon Holl**: "“Let's take a more detailed look..." |

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
  - -> `[99]` (*Narrator: "The view towards the Markian Sea from Lachaven was nothin..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“Mr. President, we need to focus on boosting the economy as quickly as possible. One of the fastest ways to achieve this is through infrastructure projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“What can we focus on?”"*)
  - -> `[42]` (*Player_Italic: "Nod."*)
  - -> `[58]` (*Player: "“Agreed.”"*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“On the one hand, businessmen are complaining about the slow logistical rail network between Holsord and Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Lileas started talking as soon as Symon took a breath."*)

### Węzeł `[5]`
Mówca: **Lileas Graf**
> "“On the other hand, citizens are criticizing the lack of a proper highway connection between Lachaven and Arvory. The narrow roads by the seaside are not only dangerous but also difficult to traverse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“We need to heed the calls of our businesses in these day..."*)
  - -> `[61]` (*Player: "“We need to pick the most profitable option for economic ..."*)
  - -> `[62]` (*Player: "“The citizens and their demands matter the most.”"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“What can we focus on?”"]** — Mówca: **Player**
> "“What can we focus on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“On the one hand, businessmen are complaining about the s..."*)

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“To that point, I defined two important projects for your attention. The H-3 Highway project and the L-1 High-speed railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Mr. Holl repositioned himself on his chair."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“The H-3 highway project.”"]** — Mówca: **Player**
> "“The H-3 highway project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“The H-3 project aims to improve the abysmal state of the..."*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“The H-3 project aims to improve the abysmal state of the road network in the Agnland region bordering Agnolia. The area is home to several million Agno-Sordish and Sordish citizens, who currently feel neglected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Highway = true"*)

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Your predecessor Alphonso failed to deliver on this campaign promise. But now, we have the opportunity to start the construction of a groundbreaking railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway = true"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“The L-1 high-speed rail project.”"]** — Mówca: **Player**
> "“The L-1 high-speed rail project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: "“Your predecessor Alphonso failed to deliver on this camp..."*)

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“There are no proper highway connections to and from Agnland. The mayor of Arvory, Eric Niel, has been asking for a bigger budget to develop the regional infrastructure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lileas Graf: "“He told us that even trucks are having a hard time trave..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""We can't leave the request of Eric Niel -- a party member -- unanswered.""]** — Mówca: **Player**
> ""We can't leave the request of Eric Niel -- a party member -- unanswered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“I know him personally and can vouch that he is a trustwo..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I agree. This could also hurt the local businesses.”"]** — Mówca: **Player**
> "“I agree. This could also hurt the local businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: "“It is, bless their souls. I'm happy we're thinking alike..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Agreed. The superpowers have led the way with their high-quality technology. We've got to keep up.”"]** — Mówca: **Player**
> "“Agreed. The superpowers have led the way with their high-quality technology. We've got to keep up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Gus Manger: "“Only technological advancement will give us an edge in t..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“This could also empower businesses and bring investments.”"]** — Mówca: **Player**
> "“This could also empower businesses and bring investments.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gus Manger: "“This should be our priority, growth and development opti..."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“As you know, our current trains cannot meet the standards of today. As many other countries adopt new electric engine technology to power up their trains, we're falling behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gus Manger: "“News about the new electric trains in United Contana has..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“That must be cumbersome for the citizens.""]** — Mówca: **Player**
> "“That must be cumbersome for the citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: "“It is, bless their souls. I'm happy we're thinking alike..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“The major cities of Sordland need more infrastructure to support their growing populations.”"]** — Mówca: **Player**
> "“The major cities of Sordland need more infrastructure to support their growing populations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gus Manger: "“This should be our priority, growth and development opti..."*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“Let's take a more detailed look at the upgrade proposal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Italic: "Look at the map."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Look at the map."]** — Mówca: **Player_Italic**
> "Lileas was pointing at Lachaven."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Lachaven");"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I have decided on the H-3 highway project to improve the infrastructure in our poorer regions.”"]** — Mówca: **Player**
> "“I have decided on the H-3 highway project to improve the infrastructure in our poorer regions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I have decided on the L-1 high-speed rail project to improve the connection between our most productive cities.”"]** — Mówca: **Player**
> "“I have decided on the L-1 high-speed rail project to improve the connection between our most productive cities.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway = true"*)

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“News about the new electric trains in United Contana has piqued our businesses' interest. They too want to transport resources and material from Holsord to Lachaven with great speed and efficiency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“Agreed. The superpowers have led the way with their high..."*)
  - -> `[16]` (*Player: "“This could also empower businesses and bring investments.”"*)
  - -> `[19]` (*Player: "“The major cities of Sordland need more infrastructure to..."*)
  - -> `[102]` (*Player: ""I'm not fully convinced yet. Please explain further.""*)

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“He told us that even trucks are having a hard time travelling through the main roads. The increased traffic is causing trouble for people commuting in and out of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""We can't leave the request of Eric Niel -- a party membe..."*)
  - -> `[18]` (*Player: "“That must be cumbersome for the citizens.""*)
  - -> `[14]` (*Player: "“I agree. This could also hurt the local businesses.”"*)
  - -> `[105]` (*Player: "“I'm not sure if this region should be a priority for us ..."*)

### Węzeł `[26]`
Mówca: **Gus Manger**
> "“From there, it will go to Anrica first...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Gelsord");"*)

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Our plan is to upgrade the old L-1 line from Holsord to Lachaven. It will transform into a high-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Italic: "Look at the map."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Look at the map."]** — Mówca: **Player_Italic**
> "Gus was pointing at Holsord while Symon was looking attentively."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Holsord");"*)

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“The Ministry estimates that construction will be completed in two years if every step going forward is executed successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: "“Thank you all for your contributions and thoughts.”"*)
  - -> `[31]` (*Player: "“Good. Is there anything else?”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Thank you all for your contributions and thoughts.”"]** — Mówca: **Player**
> "“Thank you all for your contributions and thoughts. Have a good day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: "“See you soon, Mr. Rayne.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good. Is there anything else?”"]** — Mówca: **Player**
> "“Good. Is there anything else?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Symon Holl: "“This should be all, Mr. President.”"*)

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“The negotiations will begin in the middle of this year. You will be able to award the contract to a corporation of your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Symon Holl: "“The Ministry estimates that construction will be complet..."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“So, which one do you want to hear about first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“The H-3 highway project.”"*)
  - -> `[11]` (*Player: "“The L-1 high-speed rail project.”"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Mr. Holl repositioned himself on his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Symon Holl: "“The ministry can only support one project at a time with..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“We must prove our capabilities. The people must know that this administration can get things done.”"]** — Mówca: **Player**
> "“We must prove our capabilities. The people must know that this administration can get things done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: "“To that point, I defined two important projects for your..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“We must improve the economy of the nation and bring it out of recession.”"]** — Mówca: **Player**
> "“We must improve the economy of the nation and bring it out of recession.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: "“To that point, I defined two important projects for your..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Holsord");"*)

### Węzeł `[38]`
Mówca: **Symon Holl**
> "“This should be all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: "“See you soon, Mr. Rayne.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Very interesting. But I still want to hear about the highway project.”"]** — Mówca: **Player**
> "“Very interesting. But I still want to hear about the highway project.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Jump to: [Symon Holl: "“The H-3 project aims to improve t..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Very interesting. But I still want to hear about the railway project.”"]** — Mówca: **Player**
> "“Very interesting. But I still want to hear about the railway project.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "Jump to: [Symon Holl: "“Your predecessor Alphonso failed ..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“I have settled on a decision.”"]** — Mówca: **Player**
> "“I have settled on a decision.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false` AND `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Symon Holl), `[107]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Lachaven");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“On the one hand, businessmen are complaining about the s..."*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“Thank God. I knew that you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lachaven", "Progress_Highwa..."*)

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“The right choice, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Holsord", "Progress_Railway..."*)

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“See you soon, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gus Manger: "“Have a nice day, Mr. President.”"*)

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“Have a nice day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Railway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“As you know, our current trains cannot meet the standard..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Highway == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Highway == false"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Highway == false)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Highway == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“I have settled on a decision.”"*)
  - -> `[39]` (*Player: "“Very interesting. But I still want to hear about the hig..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Highway == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway == true && B..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Symon Holl: "“The H-3 project aims to improve th..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“The H-3 project aims to improve the abysmal state of the..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Highway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Symon Holl: "“There are no proper highway connections to and from Agnl..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Railway == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Railway == false)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Railway == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“Very interesting. But I still want to hear about the rai..."*)
  - -> `[41]` (*Player: "“I have settled on a decision.”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Railway == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway == true && B..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Symon Holl: "“Your predecessor Alphonso failed t..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: "“Your predecessor Alphonso failed to deliver on this camp..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_InT_Infrastructure = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_InT_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Agreed.”"]** — Mówca: **Player**
> "“Agreed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“On the one hand, businessmen are complaining about the s..."*)

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“What really matters is that your first economic act accomplishes something tangible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“We must prove our capabilities. The people must know tha..."*)
  - -> `[36]` (*Player: "“We must improve the economy of the nation and bring it o..."*)

### Węzeł `[60]`
Mówca: **Gus Manger**
> "“The mayor of Anrica, Curtan Leste, also requested this project to be prioritized.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Symon Holl: "“Businessmen in the region will be very content, which in..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“We need to pick the most profitable option for economic growth.”"]** — Mówca: **Player**
> "“We need to pick the most profitable option for economic growth.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Gus Manger: "“Which is obviously connecting our two most economically ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“The citizens and their demands matter the most.”"]** — Mówca: **Player**
> "“The citizens and their demands matter the most.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lileas Graf: "“Their demands are just. The dire situation of the road i..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“We need to heed the calls of our businesses in these days of recession.”"]** — Mówca: **Player**
> "“We need to heed the calls of our businesses in these days of recession.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“Agreed. Improving the rail connection from Holsord to La..."*)

### Węzeł `[64]`
Mówca: **Lileas Graf**
> "“It is not businesspeople who are suffering now, but ordinary folk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“What really matters is that your first economic act acco..."*)

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“Agreed. Improving the rail connection from Holsord to Lachaven would be much more beneficial to our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lileas Graf: "“It is not businesspeople who are suffering now, but ordi..."*)

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“Which is obviously connecting our two most economically powerful cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lileas Graf: "“It is not businesspeople who are suffering now, but ordi..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Yes, we should link these rural areas in the middle with the major cities of Sordland.”"]** — Mówca: **Player**
> "“Yes, we should link these rural areas in the middle with the major cities of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lileas Graf: "“We are talking about the wealthiest regions and forgetti..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I believe this would benefit Sordish businesses and Sordland as a whole.”"]** — Mówca: **Player**
> "“I believe this would benefit Sordish businesses and Sordland as a whole.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“For the wealthy and middle-class citizens of these regio..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Investing in regions that are already developed makes little sense.”"]** — Mówca: **Player**
> "“Investing in regions that are already developed makes little sense.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lileas Graf: "“I completely agree. Our attentions must be diverted to t..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“We should no longer neglect a key region for our trade with Agnolia.”"]** — Mówca: **Player**
> "“We should no longer neglect a key region for our trade with Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gus Manger: "“Sure. But most goods flow to Lachaven and Holsord, which..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Our Agno-Sordish citizens should be respected as Sords like all of us.”"]** — Mówca: **Player**
> "“Our Agno-Sordish citizens should be respected as Sords like all of us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: "“Yes, there should be no preference or separation among S..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“It makes little sense to put investments in such a remote region.”"]** — Mówca: **Player**
> "“It makes little sense to put investments in such a remote region.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger: "“That is why we should initiate the L-1 project.”"*)

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“As mayor, I saw the central government continuously neglect our country's Agno-Sordish-dominated regions. Is this administration going to continue that kind of negligence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“We should no longer neglect a key region for our trade w..."*)
  - -> `[71]` (*Player: "“Our Agno-Sordish citizens should be respected as Sords l..."*)
  - -> `[72]` (*Player: "“It makes little sense to put investments in such a remot..."*)

### Węzeł `[74]`
Mówca: **Lileas Graf**
> "“We are talking about the wealthiest regions and forgetting about Agnland, which needs the investment far more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gus Manger: "“The mayor of Anrica, Curtan Leste, also requested this p..."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“For the wealthy and middle-class citizens of these regions, but not for the poor dears who wouldn't be able to afford the increased ticket prices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gus Manger: "“The mayor of Anrica, Curtan Leste, also requested this p..."*)

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“I completely agree. Our attentions must be diverted to the needy. The H-3 is a much more logical plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gus Manger: "“The mayor of Anrica, Curtan Leste, also requested this p..."*)

### Węzeł `[77]`
Mówca: **Gus Manger**
> "“Sure. But most goods flow to Lachaven and Holsord, which means we should give more importance to logistics there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“It has to be pointed out that the highway would be less ..."*)

### Węzeł `[78]`
Mówca: **Gus Manger**
> "“Yes, there should be no preference or separation among Sordish citizens. Meaning we should think about what's best for the country overall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“It has to be pointed out that the highway would be less ..."*)

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“That is why we should initiate the L-1 project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“It has to be pointed out that the highway would be less ..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_InT_Infrastructure = true"*)

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“The ministry can only support one project at a time with our current capacity and budget. Let's move on to the details of each.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“So, which one do you want to hear about first?”"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Lileas started talking as soon as Symon took a breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lileas Graf: "“On the other hand, citizens are criticizing the lack of ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway == true && B..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Railway == true &&..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == true  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“I have settled on a decision.”"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Railway == true && BaseGameIsolated.Turn01_EnT_Listened_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Railway"] == true  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Highway"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_InT_Infrastructure = true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_InT_Infrastructure = true"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Evening settled on the beautiful coastline of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_InT_Infrastructure = true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Evening settled on the beautiful coastline of Lachaven."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "But enjoying the luxurious mansion wasn't the main reason of our visit. We gathered the economic team here to discuss the new infrastructure investment project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Half an hour had already passed since the start of the me..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The view towards the Markian Sea from Lachaven was nothing short of exquisite. The seaside state residence fittingly named the Blue Mansion was large, fine and accommodating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "But enjoying the luxurious mansion wasn't the main reason..."*)

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Their demands are just. The dire situation of the road infrastructure between Lachaven and Arvory can't be neglected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Gus Manger: "“But the return in investment will be low. Our concern sh..."*)

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“But the return in investment will be low. Our concern should be economic growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lileas Graf: "“It is not businesspeople who are suffering now, but ordi..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""I'm not fully convinced yet. Please explain further.""]** — Mówca: **Player**
> ""I'm not fully convinced yet. Please explain further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Our plan is to upgrade the old L-1 line from Holsord to ..."*)

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“I know him personally and can vouch that he is a trustworthy member of our party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“Let's take a more detailed look at the upgrade proposal.”"*)

### Węzeł `[104]`
Mówca: **Lileas Graf**
> "“It is, bless their souls. I'm happy we're thinking alike on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“Let's take a more detailed look at the upgrade proposal.”"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I'm not sure if this region should be a priority for us right now.”"]** — Mówca: **Player**
> "“I'm not sure if this region should be a priority for us right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“Let's take a more detailed look at the upgrade proposal.”"*)

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“Businessmen in the region will be very content, which in turn will increase investments and employment. Therefore I will recommend the L-1 high-speed rail project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Highway == false"*)

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Our citizens will be quite pleased if we successfully accomplish this. Besides, if we enter trade talks with Agnolia, they will see the investment as a positive sign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Railway == false"*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“I have to disagree. it will increase the speed of transportation throughout the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lileas Graf: "“Our citizens will be quite pleased if we successfully ac..."*)

### Węzeł `[109]`
Mówca: **Gus Manger**
> "“Only technological advancement will give us an edge in the international arena.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Our plan is to upgrade the old L-1 line from Holsord to ..."*)

### Węzeł `[110]`
Mówca: **Gus Manger**
> "“This should be our priority, growth and development optimization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Our plan is to upgrade the old L-1 line from Holsord to ..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Half an hour had already passed since the start of the meeting. Unfortunately I did not even have the chance to have my usual afternoon coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Looking at the view from the windows, I let my mind drift..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Looking at the view from the windows, I let my mind drift for a couple of seconds. Symon's voice brought me back into the ongoing discussion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Symon Holl: "“Mr. President, we need to focus on boosting the economy ..."*)

### Węzeł `[113]`
Mówca: **Symon Holl**
> "“Excellent. What will your final choice be, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“I have decided on the H-3 highway project to improve the..."*)
  - -> `[23]` (*Player: "“I have decided on the L-1 high-speed rail project to imp..."*)

### Węzeł `[114]`
Mówca: **Gus Manger**
> "“...and then connect to Gelsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Lachaven");"*)

### Węzeł `[115]`
Mówca: **Gus Manger**
> "“After which it will reach Lachaven, our economic powerhouse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He leaned forward."*)

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“The L-1 will significantly boost the economies of the newly linked cities and even the rural areas in between. Lachaven is our primary port, so the goods unloaded there will be transported to Holsord much faster.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“Yes, we should link these rural areas in the middle with..."*)
  - -> `[68]` (*Player: "“I believe this would benefit Sordish businesses and Sord..."*)
  - -> `[69]` (*Player: "“Investing in regions that are already developed makes li..."*)

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“...from there it goes all the way to Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lileas Graf: "“As a result, the road network towards the Agnolian capit..."*)

### Węzeł `[118]`
Mówca: **Lileas Graf**
> "“As a result, the road network towards the Agnolian capital Staalport will also improve substantially.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "She paused and leaned forward in her chair."*)

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“It has to be pointed out that the highway would be less beneficial in the short term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“I have to disagree. it will increase the speed of transp..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "She paused and leaned forward in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_PickedHighway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PickedHighway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: "“Thank God. I knew that you would see reason.”"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_PickedRailway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PickedRailway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“The right choice, Mr. President.”"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Arvory");"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Lachaven", "Progress_Highway");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","Progress_Highway");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Holsord", "Progress_Railway");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","Progress_Railway");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Lachaven");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lileas Graf: "“The H-3 highway route starts here in Lachaven...""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lileas Graf: "“As mayor, I saw the central government continuously negl..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Lenkurg");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Lenkurg");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lileas Graf: ""...and from there it leads to Lenkurg...""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Arvory");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Arvory");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lileas Graf: "“...from there it goes all the way to Arvory.”"*)

### Węzeł `[130]`
Mówca: **Lileas Graf**
> "“The H-3 highway route starts here in Lachaven...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Lenkurg");"*)

### Węzeł `[131]`
Mówca: **Lileas Graf**
> ""...and from there it leads to Lenkurg...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Arvory");"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Holsord");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Holsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“The planned construction starts right here at the capital.""*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“The planned construction starts right here at the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_City_Anrica");"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Anrica");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Anrica");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Gus Manger: "“From there, it will go to Anrica first...”"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Gelsord");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Gelsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Gus Manger: "“...and then connect to Gelsord.”"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Lachaven");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Gus Manger: "“After which it will reach Lachaven, our economic powerho..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Gus Manger: "“The L-1 will significantly boost the economies of the ne..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Symon Holl: "“The negotiations will begin in the middle of this year. ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Lachaven");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Lachaven");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Symon Holl: "“Excellent. What will your final choice be, Mr. President?”"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Arvory");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Arvory");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_PickedHighway = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_City_Holsord");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_City_Holsord");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_PickedRailway = true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
