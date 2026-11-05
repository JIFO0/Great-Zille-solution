# Sordland/Turn06/InT_HighwayOpening

- **ID konwersacji:** `80`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/080_InT_HighwayOpening.md`
- **Liczba węzłów dialogowych:** 187
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Agnland`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn06_HighwayOpening`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show`
- `GameCondition.Turn06_InT_Opening`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“I'd prefer we just do the opening ceremony. No need for senseless show.”"** | `[111]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lucian Galade**: "“Of course. We'll do the ceremon..." |
| `[10]` | **"“I agree. There is much to gain.”"** | `[111]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;` | `[13]` **Lucian Galade**: "“Very well.”" |
| `[16]` | **"“It will be a good opportunity for exposure.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: "“Agreed. Every single press outl..." |
| `[17]` | **"“Like the good campaign days.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: "“Things were certainly easier ba..." |
| `[18]` | **"“Nothing like a cheerful crowd. Looking forward to it.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucian Galade**: "“I think all of us do.”" |
| `[21]` | **"Signal Lucian to begin the ceremony."** | `[27]` **Narrator**: "We began moving towards the stag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: "“Brothers and sisters of Sordland!”" |
| `[28]` | **"“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I moved up to the stage to addre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "The chanting from the crowd cont..." |
| `[31]` | **"“Citizens! Welcome to the opening ceremony of the H-3 Highway.”"** | `[33]` **Player_Italic**: "I moved up to the stage to addre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "The chanting from the crowd cont..." |
| `[32]` | **"“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I moved up to the stage to addre..." | `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false` | *Brak zmian stanu* | `[34]` **Narrator**: "The chanting from the crowd inte..." |
| `[33]` | **"Move up to the stage."** | `[30]` **Lucian Galade**: "“Without further ado, I invite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: "“Citizens! Welcome to the openin..."<br>`[28]` **Player**: "“People of Sordland! Welcome to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[36]` | **"“At the beginning of this journey we promised jobs and opportunity. We kept our pr..."** | `[34]` **Narrator**: "The chanting from the crowd inte..."<br>`[35]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "“The aim with the H-3 was to imp..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." |
| `[37]` | **"“Trust me, our work is far from over. This project is only the beginning of good t..."** | `[34]` **Narrator**: "The chanting from the crowd inte..."<br>`[35]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "“The aim with the H-3 was to imp..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." |
| `[38]` | **"“The aim with the H-3 was to improve logistics to aid businesses to create economi..."** | `[36]` **Player**: "“At the beginning of this journe..."<br>`[37]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "“This highway brings down travel..."<br>`[56]` **Player**: "“This highway brings thousands o..." |
| `[39]` | **"“Our intention with the H-3 was to serve our citizens who were having a hard time ..."** | `[36]` **Player**: "“At the beginning of this journe..."<br>`[37]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "“This highway brings down travel..."<br>`[56]` **Player**: "“This highway brings thousands o..." |
| `[44]` | **"“None of this would be possible without my colleague with sound advice, the Minist..."** | `[56]` **Player**: "“This highway brings thousands o..."<br>`[57]` **Player**: "“This highway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Lileas walked up to me and leane..." |
| `[45]` | **"“We have to thank the mind behind the highway project for it all, the esteemed Min..."** | `[56]` **Player**: "“This highway brings thousands o..."<br>`[57]` **Player**: "“This highway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "Symon walked up to me." |
| `[48]` | **"“I took time off from my duties to personally manage the project to success.”"** | `[56]` **Player**: "“This highway brings thousands o..."<br>`[57]` **Player**: "“This highway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "The crowd began cheering my name." |
| `[51]` | **"Cut the ribbon."** | `[91]` **Narrator**: "Symon gave me a pair of large sc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Symon Holl**: "“Congratulations to all. It was ..." |
| `[56]` | **"“This highway brings thousands of new jobs! Many unemployed citizens have benefite..."** | `[38]` **Player**: "“The aim with the H-3 was to imp..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: "“None of this would be possible ..."<br>`[48]` **Player**: "“I took time off from my duties ..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"“This highway brings down travel time by half! Travelling between Lachaven and Arv..."** | `[38]` **Player**: "“The aim with the H-3 was to imp..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: "“None of this would be possible ..."<br>`[48]` **Player**: "“I took time off from my duties ..."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"Enter car."** | `[92]` **Lucian Galade**: "“The drive to Arvory should take..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." |
| `[59]` | **"“I'd like Lileas with me.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lileas Graf**: "“I'm honored. It will be great t..." |
| `[60]` | **"“I will drive the car on my own.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: "“Sure. We will all be following ..." |
| `[62]` | **"“I want to have Symon in the lead car.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Symon Holl**: "“This isn't necessary but I won'..." |
| `[64]` | **"“Lucian, you would be my preference.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lucian Galade**: "“Thank you, Mr. President. It wi..."<br>`[149]` **Lucian Galade**: "“Thank you, Mr. President. It wi..." |
| `[80]` | **"“Symon, you deserve a lot of credit. After all, it was you who came up with the pr..."** | `[79]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lileas Graf**: "“Finally people got what they wa..." |
| `[81]` | **"“Thank you for your kind words. It truly means a good deal.”"** | `[79]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lileas Graf**: "“Finally people got what they wa..." |
| `[100]` | **"“We couldn't have done this without our excellent team.”"** | `[108]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: "“Indeed.”" |
| `[101]` | **"Nod."** | `[108]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Lucian Galade**: "“Let's move on to our plans for ..." |
| `[104]` | **"“Good work.”"** | `[108]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: "“Indeed.”" |
| `[112]` | **"“I guess we can't help it.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Symon stepped in for a comment." |
| `[113]` | **"“Thank you.”"** | `[79]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lileas Graf**: "“Finally people got what they wa..." |
| `[115]` | **"“See you at the ceremony.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "The team left, leaving the rest ..." |
| `[116]` | **"“Goodbye for now.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "The team left, leaving the rest ..." |
| `[117]` | **"“Once again, good work everyone.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "The team left, leaving the rest ..." |
| `[127]` | **"“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I moved up to the stage to addre..." | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true` | *Brak zmian stanu* | `[34]` **Narrator**: "The chanting from the crowd inte..." |

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
  - -> `[5]` (*Narrator: "Arriving in Lachaven for the grand opening ceremony of th..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon and Lileas who heavily assisted the project were with me alongside Lucian to decide on how to proceed tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CeremonialScissors");"*)

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Involving the President could be beneficial for his image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: "“I think so too. Mr. President?”"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Arriving in Lachaven for the grand opening ceremony of the H-3 Highway was a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Symon and Lileas who heavily assisted the project were wi..."*)

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. Actions speak for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lileas Graf: "“Involving the President could be beneficial for his image.”"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_InT_Opening = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_InT_Opening"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Today was a great victory for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime = true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless show.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless show.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“Of course. We'll do the ceremony and open the highway to..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I agree. There is much to gain.”"]** — Mówca: **Player**
> "“I agree. There is much to gain.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show = true"*)

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“The people will be satisfied. More importantly, so will businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Additionally, a large crowd is invited for the ceremony ..."*)

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“Sounds good. It would display unity and strength if we were all together in the convoy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Additionally, a large crowd is invited for the ceremony ..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lileas Graf: "“Sounds good. It would display unity and strength if we w..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Of course. We'll do the ceremony and open the highway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“The people will be satisfied. More importantly, so will ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd is invited for the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Nothing like a cheerful crowd. Looking forward to it.”"*)
  - -> `[16]` (*Player: "“It will be a good opportunity for exposure.”"*)
  - -> `[17]` (*Player: "“Like the good campaign days.”"*)
  - -> `[112]` (*Player: "“I guess we can't help it.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: "“Agreed. Every single press outlet has of course been not..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Like the good campaign days.”"]** — Mówca: **Player**
> "“Like the good campaign days.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: "“Things were certainly easier back then.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: "“I think all of us do.”"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do tomorrow. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“See you at the ceremony.”"*)
  - -> `[116]` (*Player: "“Goodbye for now.”"*)
  - -> `[117]` (*Player: "“Once again, good work everyone.”"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "The team left, leaving the rest of the evening to prepare for the big day tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The next day a stage had been erected next to the entranc..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Signal Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "We were all ready to begin the ceremony. I gave the green-light and the opening address began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“Brothers and sisters of Sordland!”"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "The next day a stage had been erected next to the entrance of the highway in the down-town."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The calm and warm weather created a positive mood in the ..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“I welcome you, Lachaveners today as a proud servant of t..."*)

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President. Lachaven! It is great to be here today among you industrious people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“This project is a perfect example of the capacity and ca..."*)

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Symon Holl: "“Our aim with this project is obvious, to improve the spe..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "We began moving towards the stage as the excitement was growing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Italic: "Signal Lucian to begin the ceremony."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "The chanting from the crowd continued."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Lucian's voice echoed in the square next to the highway. Hundreds of Sordland and USP flags began to wave as the cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“Without further ado, I invite the President of Sordland ..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Italic: "Move up to the stage."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Citizens! Welcome to the opening ceremony of the H-3 Highway.”"]** — Mówca: **Player**
> "“Citizens! Welcome to the opening ceremony of the H-3 Highway!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "The chanting from the crowd continued."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The chanting from the crowd intensified. Some were yellin..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Move up to the stage."]** — Mówca: **Player_Italic**
> "I moved up to the stage to address the crowd. The press were taking dozens of pictures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[31]` (*Player: "“Citizens! Welcome to the opening ceremony of the H-3 Hig..."*)
  - -> `[28]` (*Player: "“People of Sordland! Welcome to the opening ceremony of t..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The chanting from the crowd intensified. Some were yelling the motto of Lachaven; Liberty until eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“At the beginning of this journey we promised jobs and op..."*)
  - -> `[37]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "The chanting from the crowd continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“At the beginning of this journey we promised jobs and op..."*)
  - -> `[37]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“The aim with the H-3 was to improve logistics to aid bus..."*)
  - -> `[39]` (*Player: "“Our intention with the H-3 was to serve our citizens who..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“The aim with the H-3 was to improve logistics to aid bus..."*)
  - -> `[39]` (*Player: "“Our intention with the H-3 was to serve our citizens who..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“The aim with the H-3 was to improve logistics to aid businesses to create economic growth in East Nargis and Agnland.”"]** — Mówca: **Player**
> "“The aim with the H-3 was to improve logistics to aid businesses to create economic growth in East Nargis and Agnland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“This highway brings down travel time by half! Travelling..."*)
  - -> `[56]` (*Player: "“This highway brings thousands of new jobs! Many unemploy..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Our intention with the H-3 was to serve our citizens who were having a hard time travelling between Lachaven and Arvory.”"]** — Mówca: **Player**
> "“Our intention with the H-3 was to serve our citizens who were having a hard time travelling between Lachaven and Arvory.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“This highway brings down travel time by half! Travelling..."*)
  - -> `[56]` (*Player: "“This highway brings thousands of new jobs! Many unemploy..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "The highway officially opened to the public and thousands began utilising it as soon as we left the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: "“Your car is prepared and ready.”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The highway officially opened to the public and thousands..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“None of this would be possible without my colleague with sound advice, the Minister of the Interior Lileas Graf. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without my colleague with sound advice, the Minister of the Interior Lileas Graf. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Lileas walked up to me and leaned on the microphone."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We have to thank the mind behind the highway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“We have to thank the mind behind the highway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Symon walked up to me."*)

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“I'm sure each one of you will be proud of the achievements made during the project once we cut that ribbon and you can drive or travel on the highway yourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Symon mentioned the beginning of a Sordish economic recov..."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“United we stand and divided we fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Lileas brought attention to the strength that comes from ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I took time off from my duties to personally manage the project to success.”"]** — Mówca: **Player**
> "“I took time off from my duties to personally manage the project to success.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "The crowd began cheering my name."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Lileas walked up to me and leaned on the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lileas Graf: "“Thank you, Mr. President. Lachaven! It is great to be he..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Symon walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Symon Holl: "“Thanks, Mr. President.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon which led to a huge wave of cheering from the crowd. Many flashes went off at the same time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“Congratulations to all. It was a solid and fruitful effo..."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“Congratulations to all. It was a solid and fruitful effort. Hopefully with much more to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lileas Graf: "“It's a good moment indeed. It gives us pride as a nation..."*)

### Węzeł `[53]`
Mówca: **Lileas Graf**
> "“It's a good moment indeed. It gives us pride as a nation. One big step behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“Your car is prepared and ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: "“The drive to Arvory should take about four hours and the..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A forty meter long red ribbon was hanging over it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Symon gave me a pair of large scissors to commence the op..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“This highway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the highway.”"]** — Mówca: **Player**
> "“This highway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the highway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“None of this would be possible without my colleague with..."*)
  - -> `[48]` (*Player: "“I took time off from my duties to personally manage the ..."*)
  - -> `[45]` (*Player: "“We have to thank the mind behind the highway project for..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“This highway brings down travel time by half! Travelling between Lachaven and Arvory is now faster and more comfortable.”"]** — Mówca: **Player**
> "“This highway brings down travel time by half! Travelling between Lachaven and Arvory is now faster and more comfortable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“None of this would be possible without my colleague with..."*)
  - -> `[48]` (*Player: "“I took time off from my duties to personally manage the ..."*)
  - -> `[45]` (*Player: "“We have to thank the mind behind the highway project for..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Enter car."]** — Mówca: **Player_Italic**
> "I entered the car and sat on the driver's seat. The crowd was trying to catch a glimpse of me sitting at the front."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Who do you want to travel with, Mr. President?”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“I'd like Lileas with me.”"]** — Mówca: **Player**
> "“I'd like Lileas with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“I'm honored. It will be great to arrive in Arvory with t..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I will drive the car on my own.”"]** — Mówca: **Player**
> "“I will drive the car on my own.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Sure. We will all be following in our vehicles. See you ..."*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I'm honored. It will be great to arrive in Arvory with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "As we began driving out of the opening ceremony area and ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I want to have Symon in the lead car.”"]** — Mówca: **Player**
> "“I want to have Symon in the lead car.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Symon Holl: "“This isn't necessary but I won't refuse. We can talk abo..."*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Lucian, you would be my preference.”"*)
  - -> `[62]` (*Player: "“I want to have Symon in the lead car.”"*)
  - -> `[59]` (*Player: "“I'd like Lileas with me.”"*)
  - -> `[60]` (*Player: "“I will drive the car on my own.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Lucian, you would be my preference.”"]** — Mówca: **Player**
> "“Lucian, you would be my preference.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“This isn't necessary but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "As we began driving out of the opening ceremony area and ..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey to talk about how the Supreme Court will react to the legal challenge by Mr. Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "As we began driving out of the opening ceremony area and ..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Sure. We will all be following in our vehicles. See you in Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As we began driving out of the opening ceremony area and ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Lucian who looked serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The new highway was in pristine condition and quality."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Symon who smiled to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The new highway was in pristine condition and quality."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Lileas who waved to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The new highway was in pristine condition and quality."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me driving by myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The new highway was in pristine condition and quality."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The new highway was in pristine condition and quality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "It was the best driving experience one could have nowaday..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "After the relaxing four hour drive to Arvory, we were welcomed by celebratory citizens and Mayor Eric Niel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The highway officially opened to the public and thousands..."*)

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Symon Holl: "“Beginning with the President who put trust in me, I want..."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“I think all of us do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Symon stepped in for a comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“Beginning with the President who put trust in me, I want to thank all involved in H-3.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Symon, you deserve a lot of credit. After all, it was yo..."*)
  - -> `[81]` (*Player: "“Thank you for your kind words. It truly means a good deal.”"*)
  - -> `[113]` (*Player: "“Thank you.”"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“Finally people got what they wanted for a long time.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“Finally people got what they wanted for a long time.”"*)

### Węzeł `[82]`
Mówca: **Lileas Graf**
> "“Finally people got what they wanted for a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“We will need to show our best face tomorrow. I'll make s..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Lileas brought attention to the strength that comes from unity. She then mentioned the positive change the highway creates for Agnland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "After she was done with her speech, Lucian took Lileas's ..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Symon mentioned the beginning of a Sordish economic recovery and the plans to stop the recession altogether."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "After he was done with his speech, Lucian took Symon's pl..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Lucian took my place on the stage to close the ceremony."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "The calm and warm weather created a positive mood in the usually breezy Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "The crowd was large but still smaller than some rallies d..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "The crowd was large but still smaller than some rallies due to the strong PFJP presence here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "We began moving towards the stage as the excitement was g..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“I welcome you, Lachaveners today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Lucian's voice echoed in the square next to the highway. ..."*)

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“This project is a perfect example of the capacity and capabilities of Sordland as a nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“United we stand and divided we fall.”"*)

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“Our aim with this project is obvious, to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Symon Holl: "“I'm sure each one of you will be proud of the achievemen..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Symon gave me a pair of large scissors to commence the opening. The crowd was watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RibbonCut");"*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“The drive to Arvory should take about four hours and the rest of the motorcade will follow you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Enter car."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "It was the best driving experience one could have nowadays while providing the best traction and least noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "After the relaxing four hour drive to Arvory, we were wel..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_AverageTransportation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Today was a great victory for the administration."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_WeakTransportation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_AverageTransportation = true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_HighwayOpening = true; Bas..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“First of all...”"*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: "“Congratulations everyone.”"*)

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“Congratulations everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: "“To many more projects like this.”"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Well done.”"*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“If Mr. President accepts, a drive from Lachaven to Arvor..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. There is good reason to capitalise on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“I have a plan on how to do that.”"*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“It's been a long time since the last successful infrastr..."*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“Good work.”"*)
  - -> `[100]` (*Player: "“We couldn't have done this without our excellent team.”"*)
  - -> `[101]` (*Player_Italic: "Nod."*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“If Mr. President accepts, a drive from Lachaven to Arvory should do the trick. After the motorcade takes off, the road will be open to the public.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“What are your thoughts?”"*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Symon Holl: "“I don't support anything beyond the opening ceremony. Ac..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I agree. There is much to gain.”"*)
  - -> `[9]` (*Player: "“I'd prefer we just do the opening ceremony. No need for ..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I guess we can't help it.”"]** — Mówca: **Player**
> "“I guess we can't help it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“Finally people got what they wanted for a long time.”"*)

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“We will need to show our best face tomorrow. I'll make sure that our focus on improving business and logistics is relayed to wherever necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Alright then. We have a lot of work to do tomorrow. See ..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "After he was done with his speech, Lucian took Symon's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "After she was done with her speech, Lucian took Lileas's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Citizens of Lachaven! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucian Galade: "“As promised, Anton Rayne—the 4th President of Sordland—h..."*)

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne—the 4th President of Sordland—has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "We moved towards the entrance of the highway next to the ..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "We moved towards the entrance of the highway next to the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A forty meter long red ribbon was hanging over it."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: "“Fellow Free Lachaveners! Welcome to the opening ceremony..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“Lachaveners! Welcome to the opening ceremony of the H-3 ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The chanting from the crowd intensified. Some were yellin..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_HighwayOpening = true;
BaseGame.Policy_Economy_HighwayProject = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] = true;
Variable["BaseGame.Policy_Economy_HighwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_InT_Opening = true; BaseGame.Public_..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show = tr..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow = ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show =..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// filler node`
- **Efekt skryptowy (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Agnland += 1;"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Thank you, Mr. President. It will be a good journey to t..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“Thank you, Mr. President. It will be a good journey to t..."*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey to talk about the reforms and our efforts to pass both the assembly and the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "As we began driving out of the opening ceremony area and ..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Agnland += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Highway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","Progress_Highway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRo..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRoadNetwork");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_LackofRoadNetwork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Arvory", "City_Logistica..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Arvory", "City_LogisticalIssues");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Lenkurg","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_HighLevels..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Laren", "City_DecreasingPov..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusi..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBu..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBus..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_Decreasing..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBu..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_RapidGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBu..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RibbonCut");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Italic: "Cut the ribbon."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Lucian stood up."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lenkurg", "2.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lenkurg","2.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lenkurg","0.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Arvory", "5.1");"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lenkurg", "2.1");"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Hig..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Arvory", "5.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Arvory","5.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Arvory", "1.35");"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Arvory", "1.35");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Arvory","1.35");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lachaven", "83.5");"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lachaven", "83.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lachaven", "3.4");"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lachaven", "3.4");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
