# Rizia/ABOLISHLOCALPOLICE/ABOLISHLOCALPOLICE Conversation

- **ID konwersacji:** `580`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (ABOLISHLOCALPOLICE)`
- **Lokalizacja pliku:** `Rizia/Decrees/580_ABOLISHLOCALPOLICE_Conversation.md`
- **Liczba węzłów dialogowych:** 104
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Hugo_DecreeCounsel_Happened`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_DeclareIntention_WeakStatement`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`
- `RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[53]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Not this again, Hugo...""** | `[4]` **Hugo Toras**: ""Crime doesn't wait for bureaucr..." | `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0` | *Brak zmian stanu* | `[13]` **Narrator**: "He leveled his gaze at me and sp..." |
| `[9]` | **""I completely disagree.""** | `[4]` **Hugo Toras**: ""Crime doesn't wait for bureaucr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "He leveled his gaze at me and sp..." |
| `[10]` | **""And what's your advice?""** | `[4]` **Hugo Toras**: ""Crime doesn't wait for bureaucr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "He leveled his gaze at me and sp..." |
| `[11]` | **""And yet I cannot allow the provinces to control security independently, as if the..."** | `[4]` **Hugo Toras**: ""Crime doesn't wait for bureaucr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Hugo Toras**: ""Stripping the provinces of thei..." |
| `[12]` | **""Then you must already know why centralization is necessary.""** | `[4]` **Hugo Toras**: ""Crime doesn't wait for bureaucr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Hugo Toras**: ""That depends on what you consid..." |
| `[23]` | **"I'm completely aware, Hugo. I don't expect them to be happy about this.""** | `[20]` **Hugo Toras**: ""After your abolition of provinc..."<br>`[22]` **Hugo Toras**: ""To remove their control of inte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Hugo Toras**: ""A cornered noble isn't going to..." |
| `[24]` | **""This isn't an attack on provinces. It's about strengthening the central police fo..."** | `[22]` **Hugo Toras**: ""To remove their control of inte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""You have to tell that to the Ro..." |
| `[25]` | **""So you're against it?""** | `[20]` **Hugo Toras**: ""After your abolition of provinc..."<br>`[22]` **Hugo Toras**: ""To remove their control of inte..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Hugo Toras**: ""I am only against making change..." |
| `[26]` | **""I don't care what the Houses think.""** | `[20]` **Hugo Toras**: ""After your abolition of provinc..."<br>`[22]` **Hugo Toras**: ""To remove their control of inte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""Then you should start."" |
| `[27]` | **""Nobles never act vindictively. They're paragons of reason and rationality.""** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "He chuckled but his expression r..." |
| `[28]` | **""Tipping point for what exactly?""** | `[20]` **Hugo Toras**: ""After your abolition of provinc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""You know what I'm talking about..." |
| `[41]` | **""Why are you so concerned? With both their military and police forces gone, they w..."** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` | *Brak zmian stanu* | `[49]` **Hugo Toras**: ""That's what worries me."" |
| `[45]` | **""Then I need to abolish their military forces as well.""** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false` | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""Well, if your goal is to make e..." |
| `[46]` | **""You have a point. It might be risky to push this so quickly.""** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Hugo Toras**: ""Not only risky. In these times,..."<br>`[60]` **Hugo Toras**: ""Then take the time to do it rig..." |
| `[47]` | **""Do you have a solution, Hugo, or just more warnings?""** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Hugo Toras**: ""This decree will not solve our ..."<br>`[75]` **Hugo Toras**: ""I am merely doing my job, Romus."" |
| `[48]` | **""That is why I will act first and strip them of the means to challenge the Crown.""** | `[30]` **Hugo Toras**: ""Because the moment they believe..."<br>`[35]` **Hugo Toras**: ""The moment they believe you're ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""Then just be sure they don’t fe..." |
| `[84]` | **"Sign the decree."** | `[94]` **Narrator**: "I took a look at the decree." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Order_SecurityIntel_RemoveProvincialPolice"); ;`<br>`Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["Rizi...` | `[88]` **Hugo Toras**: ""Very well... I'll send out the ..." |
| `[86]` | **""You've given me a lot to consider. I'll hold off on the decree for now.""** | `[73]` **Narrator**: "He looked at me in the eye."<br>`[94]` **Narrator**: "I took a look at the decree." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Hugo Toras**: ""I understand."" |
| `[87]` | **""I see your point, Hugo, but I've already decided to sign this.""** | `[73]` **Narrator**: "He looked at me in the eye." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Hugo Toras**: ""I've given you my counsel, but ..." |
| `[91]` | **""I would appreciate it if my Grand Vizier supported my decisions.""** | `[73]` **Narrator**: "He looked at me in the eye." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Hugo Toras**: ""I've given you my counsel, but ..." |
| `[95]` | **""I wouldn't expect anything different.""** | `[36]` **Hugo Toras**: ""Having said that, I will suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I took a look at the decree." |
| `[96]` | **""Good to know.""** | `[36]` **Hugo Toras**: ""Having said that, I will suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I took a look at the decree." |
| `[97]` | **""Thank you, Hugo.""** | `[36]` **Hugo Toras**: ""Having said that, I will suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "I took a look at the decree." |
| `[98]` | **""I need you to trust me on this, Hugo.""** | `[73]` **Narrator**: "He looked at me in the eye." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Hugo Toras**: ""I've given you my counsel, but ..." |

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
  - -> `[3]` (*Hugo Toras: ""The provincial police may not be perfect, but they are t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""If only they were all like House Toras. Alas, they are n..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""The provincial police may not be perfect, but they are the first line of defense against disorder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""Crime doesn't wait for bureaucracy. Drugs, migrants and ..."*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""Crime doesn't wait for bureaucracy. Drugs, migrants and illegal cargo slipping through weak borders... These are not issues that solve themselves with a signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 0"*)
  - -> `[9]` (*Player_Romus: ""I completely disagree.""*)
  - -> `[11]` (*Player_Romus: ""And yet I cannot allow the provinces to control security..."*)
  - -> `[12]` (*Player_Romus: ""Then you must already know why centralization is necessa..."*)
  - -> `[10]` (*Player_Romus: ""And what's your advice?""*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 0"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened > 0 )"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Not this again, Hugo...""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened > 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not this again, Hugo...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He leveled his gaze at me and spoke with a calm but press..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I completely disagree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He leveled his gaze at me and spoke with a calm but press..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what's your advice?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He leveled his gaze at me and spoke with a calm but press..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet I cannot allow the provinces to control security independently, as if they rule themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""Stripping the provinces of their forces overnight is not..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you must already know why centralization is necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""That depends on what you consider more dangerous. Fragme..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He leveled his gaze at me and spoke with a calm but pressing tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""Stripping the provinces of their forces overnight is not..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""That depends on what you consider more dangerous. Fragmented policing, or a sudden vacuum in law enforcement that will make the Houses furious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""Stripping the provinces of their forces overnight is not..."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""Stripping the provinces of their forces overnight is not a good idea, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""It may strengthen the national government, but it will w..."*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""It may strengthen the national government, but it will weaken security in ways we cannot afford.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""After your abolition of provincial levies, I'm afraid th..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""This will be seen as an attack against the autonomy of t..."*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""After your abolition of provincial levies, I'm afraid this may act as the tipping point for the other Houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""So you're against it?""*)
  - -> `[28]` (*Player_Romus: ""Tipping point for what exactly?""*)
  - -> `[26]` (*Player_Romus: ""I don't care what the Houses think.""*)
  - -> `[23]` (*Player_Romus: "I'm completely aware, Hugo. I don't expect them to be hap..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""This will be seen as an attack against the autonomy of the provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""To remove their control of internal security would be se..."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""To remove their control of internal security would be seen as an attack to consolidate power under your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""So you're against it?""*)
  - -> `[26]` (*Player_Romus: ""I don't care what the Houses think.""*)
  - -> `[23]` (*Player_Romus: "I'm completely aware, Hugo. I don't expect them to be hap..."*)
  - -> `[24]` (*Player_Romus: ""This isn't an attack on provinces. It's about strengthen..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "I'm completely aware, Hugo. I don't expect them to be happy about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras), `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""A cornered noble isn't going to be merely *unhappy*. We ..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't an attack on provinces. It's about strengthening the central police forces.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""You have to tell that to the Royal Houses who would be l..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're against it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras), `[22]` (Hugo Toras), `[30]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""I am only against making changes without accounting for ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what the Houses think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras), `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""Then you should start.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobles never act vindictively. They're paragons of reason and rationality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He chuckled but his expression remained neutral."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tipping point for what exactly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""You know what I'm talking about, Romus.""*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""Then you should start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""Because the moment they believe you're casting them asid..."*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Because the moment they believe you're casting them aside, they will also stop caring about the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""So you're against it?""*)
  - -> `[46]` (*Player_Romus: ""You have a point. It might be risky to push this so quic..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[47]` (*Player_Romus: ""Do you have a solution, Hugo, or just more warnings?""*)
  - -> `[27]` (*Player_Romus: ""Nobles never act vindictively. They're paragons of reaso..."*)
  - -> `[48]` (*Player_Romus: ""That is why I will act first and strip them of the means..."*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""A cornered noble isn't going to be merely *unhappy*. We shouldn't let them become desperate enough to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""The moment they believe you're casting them aside, they ..."*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""You have to tell that to the Royal Houses who would be losing control over their own security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""The moment they believe you're casting them aside, they ..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""You know what I'm talking about, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""The moment they believe you're casting them aside, they ..."*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""I am only against making changes without accounting for the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""The moment they believe you're casting them aside, they may stop voicing their discontent in letters and start acting on it with force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""So you're against it?""*)
  - -> `[46]` (*Player_Romus: ""You have a point. It might be risky to push this so quic..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[47]` (*Player_Romus: ""Do you have a solution, Hugo, or just more warnings?""*)
  - -> `[27]` (*Player_Romus: ""Nobles never act vindictively. They're paragons of reaso..."*)
  - -> `[48]` (*Player_Romus: ""That is why I will act first and strip them of the means..."*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Having said that, I will support your decision, no matter the course you choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports =..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""If this decree weakens rather than strengthens our hold ..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""If this decree weakens rather than strengthens our hold on the kingdom, then yes, I am against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He looked at me in the eye."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are you so concerned? With both their military and police forces gone, they will have no power to contest the Crown.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""That's what worries me.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""Why are you so concerned? With both their military and p..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Then I need to abolish their military forces as well.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I need to abolish their military forces as well.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Well, if your goal is to make every Royal House panic at..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have a point. It might be risky to push this so quickly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a solution, Hugo, or just more warnings?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is why I will act first and strip them of the means to challenge the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""Then just be sure they don’t feel it all at once.""*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""That's what worries me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""They won't have power in the way they used to, but power..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""They won't have power in the way they used to, but power doesn't disappear overnight. If they feel threatened, they'll fight with whatever they have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Well, if your goal is to make every Royal House panic at once, that would certainly do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "He chuckled but his expression remained neutral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""If only they were all like House Toras. Alas, they are n..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""If only they were all like House Toras. Alas, they are not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Then just be sure they don’t feel it all at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""If they feel threatened, they'll fight with everything t..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""If they feel threatened, they'll fight with everything they have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""I'm afraid I must counsel against this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He looked at me in the eye."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_De..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""I am merely doing my job, Romus.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""This decree will not solve our current problems, only ma..."*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Then take the time to do it right. No need to turn a smart move into a reckless one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""And with the radicals taking to the streets, this isn't ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""This decree will not solve our current problems, only ma..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_De..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Having said that, I will support your decision, no matte..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""I'm afraid I must counsel against this.""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_De..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Having said that, I will support your decision, no matte..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""If this decree weakens rather than strengthens our hold ..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He looked at me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""I see your point, Hugo, but I've already decided to sign..."*)
  - -> `[91]` (*Player_Romus: ""I would appreciate it if my Grand Vizier supported my de..."*)
  - -> `[98]` (*Player_Romus: ""I need you to trust me on this, Hugo.""*)
  - -> `[86]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""This decree will not solve our current problems, only make them worse. My advice is to let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""I'm afraid I must counsel against this.""*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""I am merely doing my job, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Having said that, I will support your decision, no matte..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""And with the radicals taking to the streets, this isn't something I can support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""Not while protests are already spreading.""*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""Not while protests are already spreading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""I'm afraid I must counsel against this.""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""Not only risky. In these times, it's a death wish.""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || (RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Reform_DeclareIntention_Public == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  (Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""Then take the time to do it right. No need to turn a sma..."*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""Not only risky. In these times, it's a death wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Order_SecurityIntel_RemoveProvincialPolice");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Order_SecurityIntel_RemoveProvincialPolice");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports =..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Order_SecurityIntel_RemoveProvincialPolice");"*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator), `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see your point, Hugo, but I've already decided to sign this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""I've given you my counsel, but the decision is yours to ..."*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""Very well... I'll send out the new orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""I'll see you later.""*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""It's very likely for the best.""*)

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""It's very likely for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "I gave him the unsigned decree and called an end to our m..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would appreciate it if my Grand Vizier supported my decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""I've given you my counsel, but the decision is yours to ..."*)

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""I've given you my counsel, but the decision is yours to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "I gave him the unsigned decree and called an end to our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[86]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't expect anything different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need you to trust me on this, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""I've given you my counsel, but the decision is yours to ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""Thank you, Hugo.""*)
  - -> `[96]` (*Player_Romus: ""Good to know.""*)
  - -> `[95]` (*Player_Romus: ""I wouldn't expect anything different.""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports =..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_CounselIgnored += 1"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RoyalDecrees_RemovePolice_HugoSupports"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Very well... I'll send out the new orders.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Very well... I'll send out the new orders.""*)
