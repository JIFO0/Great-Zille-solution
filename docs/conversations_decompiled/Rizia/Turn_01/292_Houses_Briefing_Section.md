# Rizia/Turn 1/Houses Briefing Section

- **ID konwersacji:** `292`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/292_Houses_Briefing_Section.md`
- **Liczba węzłów dialogowych:** 201
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_PRCampaign`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras`
- `RiziaDLCIsolated.Turn01_Toras_Imperii`
- `RiziaDLCIsolated.Turn01_Toras_Iza`
- `RiziaDLCIsolated.Turn01_Toras_Valenqiris`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon`
- `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras`
- `RiziaDLCIsolated.Turn01_Toras_Imperii`
- `RiziaDLCIsolated.Turn01_Toras_Iza`
- `RiziaDLCIsolated.Turn01_Toras_Valenqiris`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[291] Rizia/Turn 1/A_TorasPoliticalOverview** (../Turn_01/291_A_TorasPoliticalOverview.md), Węzeł `[408]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""House Toras?""** | `[3]` **Hugo Toras**: ""While I'm on the subject, a wor..."<br>`[49]` **Hugo Toras**: ""As for the others...""<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false` | `LookAt("Rizia_City_Monqiz");` | `[7]` **Hugo Toras**: ""Our family currently controls t..." |
| `[5]` | **""House Sazon?""** | `[3]` **Hugo Toras**: ""While I'm on the subject, a wor..."<br>`[49]` **Hugo Toras**: ""As for the others...""<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false` | `LookAt("Rizia_City_Sallabes");` | `[8]` **Hugo Toras**: ""Aside from Iza, which is now un..." |
| `[6]` | **""House Azaro?""** | `[3]` **Hugo Toras**: ""While I'm on the subject, a wor..."<br>`[49]` **Hugo Toras**: ""As for the others...""<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false` | `LookAt("Rizia_City_Montaklar");` | `[11]` **Hugo Toras**: ""Ah, yes. The rulers of Cardesse..." |
| `[12]` | **""I had no idea.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""His daughter Lucita, the Duches..." |
| `[16]` | **""Yes, I was saddened to hear. He taught me everything I know.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""His daughter Lucita, the Duches..." |
| `[17]` | **""Yes. A shame I never got to know him.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | `Variable["RiziaDLC.Prologue_Studied"] == true`<br>`(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""His daughter Lucita, the Duches..." |
| `[18]` | **""I hope the new war councilor is less of a hawk.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[19]` **Hugo Toras**: ""His daughter Lucita, the Duches..." |
| `[21]` | **""My father was too soft on the Sazons. I'll keep them in line.""** | `[10]` **Hugo Toras**: ""But the return of Angelica's bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Hugo Toras**: ""At the moment, they're the weak..." |
| `[22]` | **""He cannot be a duke and claim to represent democratic values at the same time.""** | `[10]` **Hugo Toras**: ""But the return of Angelica's bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Hugo Toras**: ""A contradiction, isn't it? He d..." |
| `[23]` | **""He lost that title when his father orchestrated my kidnapping.""** | `[10]` **Hugo Toras**: ""But the return of Angelica's bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Hugo Toras**: ""Lucas was a rogue agent. Or so ..." |
| `[24]` | **""Why? Cardesse-Montaklar is large and powerful enough.""** | `[20]` **Hugo Toras**: ""You should also know that facti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""No matter your feelings on the ..." |
| `[25]` | **""The Azaros are warmongers, to a man. Or woman.""** | `[20]` **Hugo Toras**: ""You should also know that facti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Hugo Toras**: ""Maybe so, but given the house's..." |
| `[26]` | **""I won't let House Azaro down. I'll finish what the General started.""** | `[20]` **Hugo Toras**: ""You should also know that facti..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[30]` **Hugo Toras**: ""Be careful. We all know how the..." |
| `[27]` | **""Pales hasn't been part of Rizia for over a century. It's a lost cause.""** | `[20]` **Hugo Toras**: ""You should also know that facti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""No matter your feelings on the ..." |
| `[44]` | **""I wouldn't blame them for siding with him after House Toras stole Iza from them.""** | `[10]` **Hugo Toras**: ""But the return of Angelica's bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Hugo Toras**: ""They betrayed our house and our..." |
| `[70]` | **""How is Valenqiris doing, now that I've left?""** | `[7]` **Hugo Toras**: ""Our family currently controls t..."<br>`[185]` **Hugo Toras**: ""From what I've been hearing, th..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false` | *Brak zmian stanu* | `[71]` **Hugo Toras**: ""Stable as always. With you on t..." |
| `[78]` | **""You'll go when I tell you to go.""** | `[77]` **Vina Toras**: ""In a few years, maybe. I still ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[86]` **Narrator**: "Vina's face flushed." |
| `[79]` | **""You're already smarter than I was when I became Duke. But it's your decision.""** | `[77]` **Vina Toras**: ""In a few years, maybe. I still ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[81]` **Narrator**: "Vina blushed." |
| `[80]` | **""Good. I'm not ready for you to live so far away.""** | `[77]` **Vina Toras**: ""In a few years, maybe. I still ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Vina smiled." |
| `[89]` | **""If I allow her to.""** | `[72]` **Hugo Toras**: ""Of course, Princess Vina is eli..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[94]` **Hugo Toras**: ""That goes without saying."" |
| `[90]` | **""She's already smarter than I was when I became Duke. But I don't want her living ..."** | `[72]` **Hugo Toras**: ""Of course, Princess Vina is eli..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""Completely understandable."" |
| `[91]` | **""That depends on whom she marries.""** | `[72]` **Hugo Toras**: ""Of course, Princess Vina is eli..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[92]` **Hugo Toras**: ""I'm fully aware of that."" |
| `[95]` | **""What's really going on in Iza? Has Rico been well-received as Duke?""** | `[7]` **Hugo Toras**: ""Our family currently controls t..."<br>`[185]` **Hugo Toras**: ""From what I've been hearing, th..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false` | `LookAt("Rizia_City_Iza");` | `[96]` **Narrator**: "Hugo's face hardened." |
| `[102]` | **""What about Rizia Imperii? We control that too, don't we?""** | `[7]` **Hugo Toras**: ""Our family currently controls t..."<br>`[185]` **Hugo Toras**: ""From what I've been hearing, th..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false` | `LookAt("Rizia_City_PorteDrazon");` | `[114]` **Hugo Toras**: ""Yes, Porte Drazon and its metro..." |
| `[116]` | **""Nonsense. It's the corporations who should be concerned with winning *my* favor.""** | `[115]` **Hugo Toras**: ""You don't need to worry about p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Hugo Toras**: ""A healthy perspective, Your Maj..." |
| `[117]` | **""Is Su Omina still based there?""** | `[101]` **Hugo Toras**: ""Considering the circumstances, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""They are. In fact, the group to..."<br>`[192]` **Hugo Toras**: ""They are working with Ricardus ..." |
| `[119]` | **""It's not the Wehzeks who are the danger. It's bigotry.""** | `[101]` **Hugo Toras**: ""Considering the circumstances, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Hugo Toras**: ""The crime statistics are not bi..." |
| `[120]` | **""I'll find a way to help him out.""** | `[101]` **Hugo Toras**: ""Considering the circumstances, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[122]` **Hugo Toras**: ""That would be most kind of you."" |
| `[124]` | **""Understood. If our economy takes a hit, another uprising won't be far behind.""** | `[115]` **Hugo Toras**: ""You don't need to worry about p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Hugo Toras**: ""Precisely."" |
| `[125]` | **""Doesn't House Toras run any corporations?""** | `[115]` **Hugo Toras**: ""You don't need to worry about p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Hugo Toras**: ""Some minor relations do. But mo..." |
| `[140]` | **""Got it. That's all.""** | `[7]` **Hugo Toras**: ""Our family currently controls t..."<br>`[185]` **Hugo Toras**: ""From what I've been hearing, th..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true) == false` | *Brak zmian stanu* | `[141]` **Narrator**: "Hugo nodded approvingly." |
| `[149]` | **""The power balance between the houses is fragile enough. Adding so much land to Br..."** | `[148]` **Hugo Toras**: ""Lest we forget, Wehlen is sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""As king, you have the authority..." |
| `[150]` | **""That's very presumptuous of them.""** | `[148]` **Hugo Toras**: ""Lest we forget, Wehlen is sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""As king, you have the authority..." |
| `[151]` | **""I can use it as a bargaining chip. Stay loyal to the crown, or no Zille for House..."** | `[148]` **Hugo Toras**: ""Lest we forget, Wehlen is sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Hugo Toras**: ""Now you're thinking like a king."" |
| `[154]` | **""I don't see any downside to that.""** | `[148]` **Hugo Toras**: ""Lest we forget, Wehlen is sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Hugo Toras**: ""It's a lot of land, including t..." |
| `[157]` | **""Father was fond of him.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""His daughter Lucita, the Duches..." |
| `[170]` | **""Exile's too good for her. Why can't I just have her killed?""** | `[169]` **Hugo Toras**: ""As for Angelica herself... she ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[172]` **Narrator**: "Hugo's lip twitched." |
| `[175]` | **""She did nothing wrong. Why does she still have to suffer for it after all these y..."** | `[169]` **Hugo Toras**: ""As for Angelica herself... she ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Hugo Toras**: ""The Sazon matriarch is a powerf..." |
| `[178]` | **""If Angelica is in exile and Manus has not laid claim to the Duke position, who's ..."** | `[169]` **Hugo Toras**: ""As for Angelica herself... she ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "Hugo checked his notes." |
| `[186]` | **""No need to continue. I'm up to speed on the houses' activities.""** | `[3]` **Hugo Toras**: ""While I'm on the subject, a wor..."<br>`[49]` **Hugo Toras**: ""As for the others...""<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Hugo gave a short sniff." |
| `[196]` | **""May God bless him with a full recovery.""** | `[156]` **Hugo Toras**: ""You must be aware of their patr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Hugo Toras**: ""Indeed."" |

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
  - -> `[3]` (*Hugo Toras: ""While I'm on the subject, a word about our houses.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""While I'm on the subject, a word about our houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Houses Hub"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""House Toras?""]** — Mówca: **Player_Romus**
> ""House Toras?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras), `[49]` (Hugo Toras), `[50]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_Monqiz");"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""House Sazon?""]** — Mówca: **Player_Romus**
> ""House Sazon?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras), `[49]` (Hugo Toras), `[50]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_Sallabes");"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""House Azaro?""]** — Mówca: **Player_Romus**
> ""House Azaro?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras), `[49]` (Hugo Toras), `[50]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_Montaklar");"*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""Our family currently controls the province of Valenqiris as well as the city-state of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Toras Hub"*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Aside from Iza, which is now under Rico's governance, all of Brenas is still their territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""The nobles there swore fealty to the crown in exchange f..."*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""The nobles there swore fealty to the crown in exchange for keeping a hold on their cities and their estates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""But the return of Angelica's boy could test that loyalty..."*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""But the return of Angelica's boy could test that loyalty. He is their rightful duke, after all, even if he does not admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""My father was too soft on the Sazons. I'll keep them in ..."*)
  - -> `[22]` (*Player_Romus: ""He cannot be a duke and claim to represent democratic va..."*)
  - -> `[23]` (*Player_Romus: ""He lost that title when his father orchestrated my kidna..."*)
  - -> `[44]` (*Player_Romus: ""I wouldn't blame them for siding with him after House To..."*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Ah, yes. The rulers of Cardesse-Montaklar, and the stewards of the Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Hugo Toras: ""You must be aware of their patriarch Taddeus' poor healt..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""Yes, I was saddened to hear. He taught me everything I k..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I was saddened to hear. He taught me everything I know.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Yes. A shame I never got to know him.""]** — Mówca: **Player_Romus**
> ""Yes. A shame I never got to know him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true` AND `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I hope the new war councilor is less of a hawk.""]** — Mówca: **Player_Romus**
> ""I hope the new war councilor is less of a hawk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1"*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""His daughter Lucita, the Duchess of Montaklar, was selected to take his place as war and security councilor. You'll meet her later today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""You should also know that factions within her province h..."*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""You should also know that factions within her province have begun calling for the return of Pales. Again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""Why? Cardesse-Montaklar is large and powerful enough.""*)
  - -> `[25]` (*Player_Romus: ""The Azaros are warmongers, to a man. Or woman.""*)
  - -> `[26]` (*Player_Romus: ""I won't let House Azaro down. I'll finish what the Gener..."*)
  - -> `[27]` (*Player_Romus: ""Pales hasn't been part of Rizia for over a century. It's..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was too soft on the Sazons. I'll keep them in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""At the moment, they're the weakest of the three houses. ..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He cannot be a duke and claim to represent democratic values at the same time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""A contradiction, isn't it? He discourages his fellow Del..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He lost that title when his father orchestrated my kidnapping.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Lucas was a rogue agent. Or so the rest of the house cla..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Cardesse-Montaklar is large and powerful enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""No matter your feelings on the subject, I'd advise you t..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros are warmongers, to a man. Or woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""Maybe so, but given the house's military might, I'd advi..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't let House Azaro down. I'll finish what the General started.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales hasn't been part of Rizia for over a century. It's a lost cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""No matter your feelings on the subject, I'd advise you t..."*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""A contradiction, isn't it? He discourages his fellow Delegates from using the title, but has yet to officially renounce it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Hugo Toras: ""As for Angelica herself... she remains in exile. As she ..."*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""No matter your feelings on the subject, I'd advise you to take the house's concerns seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Be careful. We all know how the last campaign against the Grand Duchy ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""Maybe so, but given the house's military might, I'd advise you to take their concerns seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Houses Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == ..."*)
  - -> `[186]` (*Player_Romus: ""No need to continue. I'm up to speed on the houses' acti..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras =..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""House Toras?""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Lucas was a rogue agent. Or so the rest of the house claims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Hugo Toras: ""As for Angelica herself... she remains in exile. As she ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon =..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""House Sazon?""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == ..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro =..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""House Azaro?""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""At the moment, they're the weakest of the three houses. You'd do well to ensure they stay that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Hugo Toras: ""As for Angelica herself... she remains in exile. As she ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't blame them for siding with him after House Toras stole Iza from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""They betrayed our house and our king. What else could ha..."*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""They betrayed our house and our king. What else could have been done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Hugo Toras: ""As for Angelica herself... she remains in exile. As she ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras =..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_PorteDrazon");"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""As for the others...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras =..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""And finally...""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""As for the others...""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""Be careful. We all know how the last campaign against th..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Houses Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Houses Hub"*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""As for the others...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Houses Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Houses Hub"*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Well. I hope that was helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Hugo glanced at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras =..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_PorteDrazon");"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == ..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras =..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""And finally...""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""As for the others...""*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is Valenqiris doing, now that I've left?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[185]` (Hugo Toras), `[118]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Hugo Toras: ""Stable as always. With you on the throne, me as Grand Vi..."*)

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""Stable as always. With you on the throne, me as Grand Vizier and Rico in Iza, the governing seat has been filled by our distant cousin Hubertus. You recall him, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""Of course, Princess Vina is eligible to take his place a..."*)

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Of course, Princess Vina is eligible to take his place as the reigning Duchess once she is deemed fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He nodded at my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Vina Toras: ""In a few years, maybe. I still don't feel ready.""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He nodded at my daughter."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""If I allow her to.""*)
  - -> `[90]` (*Player_Romus: ""She's already smarter than I was when I became Duke. But..."*)
  - -> `[91]` (*Player_Romus: ""That depends on whom she marries.""*)

### Węzeł `[77]`
Mówca: **Vina Toras**
> ""In a few years, maybe. I still don't feel ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""You'll go when I tell you to go.""*)
  - -> `[79]` (*Player_Romus: ""You're already smarter than I was when I became Duke. Bu..."*)
  - -> `[80]` (*Player_Romus: ""Good. I'm not ready for you to live so far away.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll go when I tell you to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're already smarter than I was when I became Duke. But it's your decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I'm not ready for you to live so far away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Vina smiled."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Vina blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""Thank you, Father.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Vina blushed."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Vina smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Vina Toras: ""Don't worry, Father. I'm here.""*)

### Węzeł `[84]`
Mówca: **Vina Toras**
> ""Don't worry, Father. I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Hugo tapped his fingers on the table."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Vina's face flushed."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Vina's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Vina Toras: ""Of course, Father.""*)

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""Of course, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Hugo tapped his fingers on the table."*)

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""Thank you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Hugo tapped his fingers on the table."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I allow her to.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""That goes without saying.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's already smarter than I was when I became Duke. But I don't want her living so far away.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""Completely understandable.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That depends on whom she marries.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""I'm fully aware of that.""*)

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""I'm fully aware of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""In any case, Your Majesty, I don't expect any trouble in..."*)

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""Completely understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""In any case, Your Majesty, I don't expect any trouble in..."*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""That goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""In any case, Your Majesty, I don't expect any trouble in..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's really going on in Iza? Has Rico been well-received as Duke?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[185]` (Hugo Toras), `[118]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_Iza");"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Hugo's face hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Hugo Toras: ""Iza has been difficult since the Sazon rebellion. Even m..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Hugo tapped his fingers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""In any case, Your Majesty, I don't expect any trouble in..."*)

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""In any case, Your Majesty, I don't expect any trouble in Valenqiris during your reign. It remains the wealthiest of Rizia's provinces, and the least affected by crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Hugo Toras: ""Make sure their lives don't get any less comfortable, an..."*)

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""Iza has been difficult since the Sazon rebellion. Even more so since the Wehzek population there exploded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""Any effort to restore the rights and privileges of nativ..."*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Any effort to restore the rights and privileges of native Rizians is met with resistance. The students at Iza University are leading the charge, I believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""Considering the circumstances, I believe my son is doing..."*)

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Considering the circumstances, I believe my son is doing just fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Is Su Omina still based there?""*)
  - -> `[119]` (*Player_Romus: ""It's not the Wehzeks who are the danger. It's bigotry.""*)
  - -> `[120]` (*Player_Romus: ""I'll find a way to help him out.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about Rizia Imperii? We control that too, don't we?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[185]` (Hugo Toras), `[118]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_PorteDrazon");"*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""As for the other houses...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon =..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "LookAt("Rizia_City_PorteDrazon");"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true && RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  and  Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Houses Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Houses Hub"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == ..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon =..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Hugo Toras: ""And finally...""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon == true ||RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon"] == true  or Variable["RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""As for the other houses...""*)

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""And finally...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "Jump to: [Houses Hub]"*)

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""Make sure their lives don't get any less comfortable, and the local nobility will stay loyal to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_PRCampaign == true"*)

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""Yes, Porte Drazon and its metropolitan area are controlled by the central government, and therefore House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""You don't need to worry about pleasing our house in this..."*)

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""You don't need to worry about pleasing our house in this region, though. It's more crucial to retain the favor of the major corporations that are based here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Nonsense. It's the corporations who should be concerned ..."*)
  - -> `[124]` (*Player_Romus: ""Understood. If our economy takes a hit, another uprising..."*)
  - -> `[125]` (*Player_Romus: ""Doesn't House Toras run any corporations?""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. It's the corporations who should be concerned with winning *my* favor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Hugo Toras: ""A healthy perspective, Your Majesty.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is Su Omina still based there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""They are. In fact, the group took to the streets in celebration of your coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza = true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not the Wehzeks who are the danger. It's bigotry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""The crime statistics are not bigoted, Your Majesty. If w..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll find a way to help him out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo += 1"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""That would be most kind of you.""*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""That would be most kind of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza = true"*)

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""The crime statistics are not bigoted, Your Majesty. If we do not acknowledge this problem, it will get worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza = true"*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Understood. If our economy takes a hit, another uprising won't be far behind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Hugo Toras: ""Precisely.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Doesn't House Toras run any corporations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Hugo Toras: ""Some minor relations do. But most of our house's wealth ..."*)

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""Some minor relations do. But most of our house's wealth comes from our land and natural gas holdings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""The Pales Administrative District is also under the juri..."*)

### Węzeł `[127]`
Mówca: **Hugo Toras**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""The Pales Administrative District is also under the juri..."*)

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""A healthy perspective, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""The Pales Administrative District is also under the juri..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Toras Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Valenqiris == false"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza == false"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Imperii == false"*)
  - -> `[140]` (*Player_Romus: ""Got it. That's all.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Valenqiris == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Valenqiris == false"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Toras_Valenqiris == false)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Valenqiris == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""How is Valenqiris doing, now that I've left?""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Toras_Valenqiris == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Iza == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza == false"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Toras_Iza == false)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Iza == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""What's really going on in Iza? Has Rico been well-receiv..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Toras_Iza == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Imperii == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Imperii == false"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Toras_Imperii == false)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Imperii == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""What about Rizia Imperii? We control that too, don't we?""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Toras_Imperii == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Valenqiris = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Valenqiris"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras Hub]"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Got it. That's all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[185]` (Hugo Toras), `[118]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Hugo nodded approvingly."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Hugo nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedToras = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Toras Hub"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Iza = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Iza"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras Hub]"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Toras Hub"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Toras_Imperii = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Toras_Imperii"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "Jump to: [Toras Hub]"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Toras Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Toras Hub"*)

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""The Pales Administrative District is also under the jurisdiction of Rizia Imperii since we won it back in the Reclamation War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Imperii = true"*)

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""Lest we forget, Wehlen is scheduled to return Zille to Rizia next year. The Sazons expect the region to become part of their province, as it was before the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: ""The power balance between the houses is fragile enough. ..."*)
  - -> `[150]` (*Player_Romus: ""That's very presumptuous of them.""*)
  - -> `[151]` (*Player_Romus: ""I can use it as a bargaining chip. Stay loyal to the cro..."*)
  - -> `[154]` (*Player_Romus: ""I don't see any downside to that.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The power balance between the houses is fragile enough. Adding so much land to Brenas would upset it beyond repair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""As king, you have the authority to make Zille part of th..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very presumptuous of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""As king, you have the authority to make Zille part of th..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can use it as a bargaining chip. Stay loyal to the crown, or no Zille for House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Hugo Toras: ""Now you're thinking like a king.""*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""As king, you have the authority to make Zille part of the central government, similar to Rizia Imperii. An option to keep in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon = true"*)

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""Now you're thinking like a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon = true"*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see any downside to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Hugo Toras: ""It's a lot of land, including two strategic harbors. All..."*)

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""It's a lot of land, including two strategic harbors. Allowing the Sazons to regain the power they had before the uprising would be unwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedSazon = true"*)

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""You must be aware of their patriarch Taddeus' poor health. The General suffered a stroke just prior to King Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[196]` (*Player_Romus: ""May God bless him with a full recovery.""*)
  - -> `[12]` (*Player_Romus: ""I had no idea.""*)
  - -> `[18]` (*Player_Romus: ""I hope the new war councilor is less of a hawk.""*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father was fond of him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_Sallabes");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_Sallabes");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Aside from Iza, which is now under Rico's governance, al..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_Monqiz");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_Monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""Our family currently controls the province of Valenqiris..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_Iza");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_Iza");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Hugo's face hardened."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_PorteDrazon");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_PorteDrazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Hugo Toras: ""Yes, Porte Drazon and its metropolitan area are controll..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_Montaklar");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_Montaklar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Ah, yes. The rulers of Cardesse-Montaklar, and the stewa..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""Well. I hope that was helpful.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Rizia_City_PorteDrazon");`
- **Efekt skryptowy (`userScript`):** `LookAt("Rizia_City_PorteDrazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Hugo glanced at the clock."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_ArmedForces == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Hugo Toras: ""You've already made strengthening the Rizian armed force..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_ArmedForces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_ArmedForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro = true"*)

### Węzeł `[168]`
Mówca: **Hugo Toras**
> ""You've already made strengthening the Rizian armed forces a high priority. That should endear you to them right off the bat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Houses_ListenedAzaro = true"*)

### Węzeł `[169]`
Mówca: **Hugo Toras**
> ""As for Angelica herself... she remains in exile. As she should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Exile's too good for her. Why can't I just have her kill..."*)
  - -> `[175]` (*Player_Romus: ""She did nothing wrong. Why does she still have to suffer..."*)
  - -> `[178]` (*Player_Romus: ""If Angelica is in exile and Manus has not laid claim to ..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exile's too good for her. Why can't I just have her killed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Hugo's lip twitched."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Hugo's lip twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""Aside from the fact that doing so would turn all of Bren..."*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Aside from the fact that doing so would turn all of Brenas against you... there is no evidence she did anything wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Hugo Toras: ""There are even whispers that she turned her husband in n..."*)

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""There are even whispers that she turned her husband in not to save her own skin, but to aid in the monarchy's preservation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""Lest we forget, Wehlen is scheduled to return Zille to R..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She did nothing wrong. Why does she still have to suffer for it after all these years?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""The Sazon matriarch is a powerful figure, Your Majesty. ..."*)

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""The Sazon matriarch is a powerful figure, Your Majesty. Even all these years later, she commands the loyalty of the entire province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""I do not deny that she could be a useful ally. But only ..."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I do not deny that she could be a useful ally. But only as long as you stay on her house's good side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""Lest we forget, Wehlen is scheduled to return Zille to R..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Angelica is in exile and Manus has not laid claim to the Duke position, who's officially in charge of Brenas now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Hugo checked his notes."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Hugo checked his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hugo Toras: ""A lesser relation by the name of Leona. She reigns from ..."*)

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""A lesser relation by the name of Leona. She reigns from Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Hugo Toras: ""But it is Manus and Angelica that the rest of the Sazons..."*)

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""But it is Manus and Angelica that the rest of the Sazons take their cues from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""Lest we forget, Wehlen is scheduled to return Zille to R..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_PRCampaign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_PRCampaign == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Focus_PRCampaign == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_PRCampaign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Hugo Toras: ""From what I've been hearing, the PR campaign you spearhe..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Focus_PRCampaign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Focus_PRCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Valenqiris = true"*)

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""From what I've been hearing, the PR campaign you spearheaded over the last several years endeared you to them greatly. Keep up the good work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Valenqiris = true"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to continue. I'm up to speed on the houses' activities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras), `[49]` (Hugo Toras), `[50]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Hugo gave a short sniff."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Hugo gave a short sniff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Hugo Toras: ""I see. Then this will be a short meeting indeed.""*)

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""I see. Then this will be a short meeting indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""They are. In fact, the group took to the streets in cele..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Hugo Toras: ""They are working with Ricardus to preserve whatever frag..."*)

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""They are working with Ricardus to preserve whatever fragile order exists in the city, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Toras_Iza = true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""Yes. A shame I never got to know him.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God bless him with a full recovery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Indeed.""*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""Father was fond of him.""*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""His daughter Lucita, the Duchess of Montaklar, was selec..."*)
