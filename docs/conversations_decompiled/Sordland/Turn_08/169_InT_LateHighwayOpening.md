# Sordland/Turn08/InT_LateHighwayOpening

- **ID konwersacji:** `169`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/169_InT_LateHighwayOpening.md`
- **Liczba węzłów dialogowych:** 182
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
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn08_LateHighwayOpening`
- `BaseGameSupport.News_Turn08_E_H3_SSC_NoShow`
- `BaseGameSupport.News_Turn08_E_H3_SSC_Show`
- `BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_E_H3_Taurus_Show`
- `BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow`
- `BaseGameSupport.News_Turn08_HP_H3_SSC_Show`
- `BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_HP_H3_Taurus_Show`
- `GameCondition.Turn08_InT_LateOpening`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"** | `[108]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lucian Galade**: "“Of course. We'll hold the cerem..." |
| `[10]` | **"“I agree. I'll hit the road.""** | `[108]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;` | `[13]` **Lucian Galade**: "“Very well.”" |
| `[16]` | **"“It will be a good opportunity for exposure.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucian Galade**: "“Agreed. Every single press outl..." |
| `[17]` | **"“Like the good old campaign days.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: "“Things were certainly easier ba..." |
| `[18]` | **"“Nothing like a cheerful crowd. Looking forward to it.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucian Galade**: "“I think all of us are.”" |
| `[21]` | **"Signal for Lucian to begin the ceremony."** | `[27]` **Narrator**: "We took our places onstage." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: "“Brothers and sisters of Sordland!”" |
| `[28]` | **"“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I walked to the podium to addres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "The chanting from the crowd cont..." |
| `[31]` | **"“Citizens! Welcome to the opening ceremony of the H-3 Highway.”"** | `[33]` **Player_Italic**: "I walked to the podium to addres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "The chanting from the crowd cont..." |
| `[32]` | **"“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I walked to the podium to addres..." | `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false` | *Brak zmian stanu* | `[34]` **Narrator**: "The chanting from the crowd inte..." |
| `[33]` | **"Walk up to the podium."** | `[30]` **Lucian Galade**: "“Without further ado, I invite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: "“Citizens! Welcome to the openin..."<br>`[28]` **Player**: "“People of Sordland! Welcome to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[36]` | **"“At the beginning of this journey, we promised jobs and opportunity. We kept our p..."** | `[34]` **Narrator**: "The chanting from the crowd inte..."<br>`[35]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "“The aim with the H-3 was to cre..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." |
| `[37]` | **"“Trust me, our work is far from over. This project is only the beginning.”"** | `[34]` **Narrator**: "The chanting from the crowd inte..."<br>`[35]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: "“The aim with the H-3 was to cre..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." |
| `[38]` | **"“The aim with the H-3 was to create economic growth in East Nargis and Agnland.”"** | `[36]` **Player**: "“At the beginning of this journe..."<br>`[37]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "“Thanks to this highway, travel ..."<br>`[56]` **Player**: "“This highway has brought and wi..." |
| `[39]` | **"“Our intention with the H-3 was to ensure citizens an easier commute between Lacha..."** | `[36]` **Player**: "“At the beginning of this journe..."<br>`[37]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Player**: "“Thanks to this highway, travel ..."<br>`[56]` **Player**: "“This highway has brought and wi..." |
| `[44]` | **"“None of this would be possible without the sound advice of my Interior Minister L..."** | `[56]` **Player**: "“This highway has brought and wi..."<br>`[57]` **Player**: "“Thanks to this highway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Lileas walked up to me and leane..." |
| `[45]` | **"“I must thank the brilliant mind behind the highway project, the esteemed Minister..."** | `[56]` **Player**: "“This highway has brought and wi..."<br>`[57]` **Player**: "“Thanks to this highway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "Symon walked up to me." |
| `[48]` | **"“Ensuring the success of this project wasn't just one of my presidential goals. I ..."** | `[56]` **Player**: "“This highway has brought and wi..."<br>`[57]` **Player**: "“Thanks to this highway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "The crowd began cheering my name." |
| `[51]` | **"Cut the ribbon."** | `[89]` **Narrator**: "Symon handed me a pair of oversi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Symon Holl**: "“Congratulations to all. Hopeful..." |
| `[56]` | **"“This highway has brought and will continue to bring thousands of new jobs.""** | `[38]` **Player**: "“The aim with the H-3 was to cre..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: "“None of this would be possible ..."<br>`[48]` **Player**: "“Ensuring the success of this pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"“Thanks to this highway, travel between Lachaven and Arvory is twice as fast and i..."** | `[38]` **Player**: "“The aim with the H-3 was to cre..."<br>`[39]` **Player**: "“Our intention with the H-3 was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: "“None of this would be possible ..."<br>`[48]` **Player**: "“Ensuring the success of this pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"Enter the car."** | `[90]` **Lucian Galade**: "“The drive to Arvory should take..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." |
| `[59]` | **"“I'd like Lileas with me.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lileas Graf**: "“I'm honored. It will be lovely ..." |
| `[60]` | **"“I will drive the car on my own.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lucian Galade**: "“As you wish. I'll see you in Ar..." |
| `[62]` | **"“I want to have Symon in the lead car.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Symon Holl**: "“This isn't necessary, but I won..." |
| `[64]` | **"“Lucian, come ride with me.”"** | `[63]` **Lucian Galade**: "“Who do you want to travel with,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Lucian Galade**: "“Thank you, Mr. President. It wi..." |
| `[78]` | **"“Symon, you deserve the credit. After all, it was you who came up with the project.”"** | `[77]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lileas Graf**: "“The people have been waiting a ..." |
| `[79]` | **"“Thank you for your kind words. It truly means a good deal.”"** | `[77]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lileas Graf**: "“The people have been waiting a ..." |
| `[97]` | **"“We couldn't have done this without our excellent team.”"** | `[105]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“Indeed.”" |
| `[98]` | **"Nod."** | `[105]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lucian Galade**: "“Let's move on to our plans for ..." |
| `[101]` | **"“Good work.”"** | `[105]` **Lileas Graf**: "“Well done.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“Indeed.”" |
| `[109]` | **"“I guess we can't avoid that.”"** | `[15]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Symon Holl**: "“On another note. It goes withou..." |
| `[110]` | **"“Thank you.”"** | `[77]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lileas Graf**: "“The people have been waiting a ..." |
| `[112]` | **"“See you at the ceremony.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We dispersed to begin our indivi..." |
| `[113]` | **"“Goodbye for now.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We dispersed to begin our indivi..." |
| `[114]` | **"“Once again, good work everyone.”"** | `[19]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "We dispersed to begin our indivi..." |
| `[124]` | **"“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"** | `[33]` **Player_Italic**: "I walked to the podium to addres..." | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true` | *Brak zmian stanu* | `[34]` **Narrator**: "The chanting from the crowd inte..." |

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
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I, together with project leads Symon and Lileas, met to discuss how to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Lucian stood up."*)

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Image is everything, Symon. I agree this would bolster the President's reputation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: "“I think so too. Mr. President?”"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The day before the grand opening ceremony of the H-3 Highway, we arrived in Lachaven to begin preparations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Although the delay had taken its toll on our morale, it w..."*)

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. The highway speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lileas Graf: "“Image is everything, Symon. I agree this would bolster t..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_InT_LateOpening = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "It was a great victory for my administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LateHighwayOpening = true;..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“Of course. We'll hold the ceremony and open the highway ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I agree. I'll hit the road.""]** — Mówca: **Player**
> "“I agree. I'll hit the road.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show = true"*)

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“The people will be satisfied. More importantly, so will businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Additionally, a large crowd has been invited to the cere..."*)

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“Sounds good. It would display unity and strength if we were all together in the convoy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Additionally, a large crowd has been invited to the cere..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lileas Graf: "“Sounds good. It would display unity and strength if we w..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Of course. We'll hold the ceremony and open the highway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“The people will be satisfied. More importantly, so will ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd has been invited to the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Nothing like a cheerful crowd. Looking forward to it.”"*)
  - -> `[16]` (*Player: "“It will be a good opportunity for exposure.”"*)
  - -> `[17]` (*Player: "“Like the good old campaign days.”"*)
  - -> `[109]` (*Player: "“I guess we can't avoid that.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: "“Agreed. Every single press outlet has of course been not..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: "“Things were certainly easier back then.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“I think all of us are.”"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“See you at the ceremony.”"*)
  - -> `[113]` (*Player: "“Goodbye for now.”"*)
  - -> `[114]` (*Player: "“Once again, good work everyone.”"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "We dispersed to begin our individual preparations for the big day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The next morning, a stage had been erected next to the en..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Signal for Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "I gave Lucian the green light and the opening address began."
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
> "The next morning, a stage had been erected next to the entrance of the highway in downtown Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "The weather was warm and unusually calm for the windy por..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“I welcome you Lachaveners today as a proud servant of th..."*)

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President. Lachaven! It is great to be here today among you industrious people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“This project is a perfect example of the capacity and ca..."*)

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Symon Holl: "“Our aim with this project was obvious: to improve the sp..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "We took our places onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Italic: "Signal for Lucian to begin the ceremony."*)

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
  - -> `[33]` (*Player_Italic: "Walk up to the podium."*)

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
**[WYBÓR GRACZA: "Walk up to the podium."]** — Mówca: **Player_Italic**
> "I walked to the podium to address the crowd. Cameras flashed around me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[31]` (*Player: "“Citizens! Welcome to the opening ceremony of the H-3 Hig..."*)
  - -> `[28]` (*Player: "“People of Sordland! Welcome to the opening ceremony of t..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The chanting from the crowd intensified. Some were yelling the motto of Lachaven: Liberty until eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“At the beginning of this journey, we promised jobs and o..."*)
  - -> `[37]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "The chanting from the crowd continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“At the beginning of this journey, we promised jobs and o..."*)
  - -> `[37]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“The aim with the H-3 was to create economic growth in Ea..."*)
  - -> `[39]` (*Player: "“Our intention with the H-3 was to ensure citizens an eas..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“The aim with the H-3 was to create economic growth in Ea..."*)
  - -> `[39]` (*Player: "“Our intention with the H-3 was to ensure citizens an eas..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“The aim with the H-3 was to create economic growth in East Nargis and Agnland.”"]** — Mówca: **Player**
> "“The aim with the H-3 was to create economic growth in East Nargis and Agnland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“Thanks to this highway, travel between Lachaven and Arvo..."*)
  - -> `[56]` (*Player: "“This highway has brought and will continue to bring thou..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Our intention with the H-3 was to ensure citizens an easier commute between Lachaven and Arvory.”"]** — Mówca: **Player**
> "“Our intention with the H-3 was to ensure citizens an easier commute between Lachaven and Arvory.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“Thanks to this highway, travel between Lachaven and Arvo..."*)
  - -> `[56]` (*Player: "“This highway has brought and will continue to bring thou..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "As soon as we left, the highway opened to the public and thousands began using it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "//"*)

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
  - -> `[54]` (*Lucian Galade: "“Your car is ready.”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "As soon as we left, the highway opened to the public and ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“None of this would be possible without the sound advice of my Interior Minister Lileas Graf. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without the sound advice of my Interior Minister Lileas Graf. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Lileas walked up to me and leaned into the microphone."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I must thank the brilliant mind behind the highway project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“I must thank the brilliant mind behind the highway project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Symon walked up to me."*)

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“After we cut that ribbon and you drive on the highway, you can judge our success for yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Symon continued to speak about how this project was a ste..."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“United we stand and divided we fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lileas continued to speak about the strength that comes f..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Ensuring the success of this project wasn't just one of my presidential goals. I made it my personal priority.""]** — Mówca: **Player**
> "“Ensuring the success of this project wasn't just one of my presidential goals. I made it my personal priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "The crowd began cheering my name."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Lileas walked up to me and leaned into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lileas Graf: "“Thank you, Mr. President. Lachaven! It is great to be he..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Symon walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Symon Holl: "“Thanks, Mr. President.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon, triggering cheers from the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“Congratulations to all. Hopefully this is one of many su..."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“Congratulations to all. Hopefully this is one of many successes to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lileas Graf: "“It's a good moment indeed. It gives us pride as a nation..."*)

### Węzeł `[53]`
Mówca: **Lileas Graf**
> "“It's a good moment indeed. It gives us pride as a nation. One big step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“Your car is ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“The drive to Arvory should take about four hours. We'll ..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A 40-meter-long red ribbon stretched across it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Symon handed me a pair of oversized scissors."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“This highway has brought and will continue to bring thousands of new jobs.""]** — Mówca: **Player**
> "“This highway has brought and will continue to bring thousands of new jobs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“None of this would be possible without the sound advice ..."*)
  - -> `[48]` (*Player: "“Ensuring the success of this project wasn't just one of ..."*)
  - -> `[45]` (*Player: "“I must thank the brilliant mind behind the highway proje..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Thanks to this highway, travel between Lachaven and Arvory is twice as fast and infinitely more comfortable.""]** — Mówca: **Player**
> "“Thanks to this highway, travel between Lachaven and Arvory is twice as fast and infinitely more comfortable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“None of this would be possible without the sound advice ..."*)
  - -> `[48]` (*Player: "“Ensuring the success of this project wasn't just one of ..."*)
  - -> `[45]` (*Player: "“I must thank the brilliant mind behind the highway proje..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Enter the car."]** — Mówca: **Player_Italic**
> "I entered the car and sat in the driver's seat. The crowd was trying to catch a glimpse of me through the window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Who do you want to travel with, Mr. President?”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“I'd like Lileas with me.”"]** — Mówca: **Player**
> "“I'd like Lileas with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“I'm honored. It will be lovely to arrive in Arvory with ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I will drive the car on my own.”"]** — Mówca: **Player**
> "“I will drive the car on my own.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“As you wish. I'll see you in Arvory.”"*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I'm honored. It will be lovely to arrive in Arvory with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "I revved the engine. Lileas waved to the press photograph..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I want to have Symon in the lead car.”"]** — Mówca: **Player**
> "“I want to have Symon in the lead car.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Symon Holl: "“This isn't necessary, but I won't refuse. We can talk ab..."*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Lucian, come ride with me.”"*)
  - -> `[62]` (*Player: "“I want to have Symon in the lead car.”"*)
  - -> `[59]` (*Player: "“I'd like Lileas with me.”"*)
  - -> `[60]` (*Player: "“I will drive the car on my own.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Lucian, come ride with me.”"]** — Mówca: **Player**
> "“Lucian, come ride with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“Thank you, Mr. President. It will be a good opportunity ..."*)

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“This isn't necessary, but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I revved the engine. Symon smiled awkwardly at the press ..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“As you wish. I'll see you in Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I revved the engine and waved to the press photographers ..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I revved the engine. Lucian waved at the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The new highway was in pristine condition. The ride to Ar..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "I revved the engine. Symon smiled awkwardly at the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The new highway was in pristine condition. The ride to Ar..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "I revved the engine. Lileas waved to the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The new highway was in pristine condition. The ride to Ar..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I revved the engine and waved to the press photographers as I drove onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The new highway was in pristine condition. The ride to Ar..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "The new highway was in pristine condition. The ride to Arvory was the smoothest I'd ever had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "After an uneventful four hours, we were welcomed by a thr..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "After an uneventful four hours, we were welcomed by a throng of Arvory citizens and Mayor Eric Niel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "As soon as we left, the highway opened to the public and ..."*)

### Węzeł `[73]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Symon Holl: "“Beginning with the President who put his trust in me, I ..."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“I think all of us are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[77]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank everyone involved in the H-3.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“Symon, you deserve the credit. After all, it was you who..."*)
  - -> `[79]` (*Player: "“Thank you for your kind words. It truly means a good deal.”"*)
  - -> `[110]` (*Player: "“Thank you.”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Symon, you deserve the credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve the credit. After all, it was you who came up with the project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“The people have been waiting a long time for this.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“The people have been waiting a long time for this.""*)

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“The people have been waiting a long time for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: "“We will need to show our best face tomorrow. I'll make s..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Lileas continued to speak about the strength that comes from unity and the positive change the highway would bring to Agnland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "After she was done with her speech, Lucian took Lileas's ..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Symon continued to speak about how this project was a stepping stone towards a Sordish economic recovery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "After he was done with his speech, Lucian took Symon's pl..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Lucian took my place on the stage to close the ceremony."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "The weather was warm and unusually calm for the windy port city. Spirits were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Despite Lachaven's strong PFJP presence, a huge crowd of ..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Despite Lachaven's strong PFJP presence, a huge crowd of supporters had turned out. Lucian must have brought in some ringers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "We took our places onstage."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“I welcome you Lachaveners today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Lucian's voice echoed in the square next to the highway. ..."*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“This project is a perfect example of the capacity and capabilities of Sordland as a nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“United we stand and divided we fall.”"*)

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“Our aim with this project was obvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Symon Holl: "“After we cut that ribbon and you drive on the highway, y..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon handed me a pair of oversized scissors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RibbonCut");"*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“The drive to Arvory should take about four hours. We'll be right behind you in the motorcade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Enter the car."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_AverageTransportation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "It was a great victory for my administration."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_WeakTransportation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_AverageTransportation = true"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: "“First of all...”"*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: "“This day may have arrived later than expected, but it do..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“This day may have arrived later than expected, but it doesn't change the fact that we are here now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: "“This is still a big success. Congratulations, everyone.”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: "“Well done.”"*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“I have a plan for how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“The president himself shall make the maiden voyage from ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. From a public relations viewpoint, we can certainly capitalize on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“I have a plan for how to do that.”"*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“It's been a long time since the last successful infrastr..."*)

### Węzeł `[105]`
Mówca: **Lileas Graf**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“Good work.”"*)
  - -> `[97]` (*Player: "“We couldn't have done this without our excellent team.”"*)
  - -> `[98]` (*Player_Italic: "Nod."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“The president himself shall make the maiden voyage from Lachaven to Arvory along with his motorcade. If he agrees, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: "“What are your thoughts?”"*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Symon Holl: "“I don't support anything beyond the opening ceremony. Th..."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I agree. I'll hit the road.""*)
  - -> `[9]` (*Player: "“I'd prefer we just do the opening ceremony. No need for ..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I guess we can't avoid that.”"]** — Mówca: **Player**
> "“I guess we can't avoid that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“The people have been waiting a long time for this.""*)

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“We will need to show our best face tomorrow. I'll make sure that our focus on improving business and logistics is relayed by whatever means necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Alright then. We have a lot of work to do. See you in th..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We dispersed to begin our individual preparations for the..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We dispersed to begin our individual preparations for the..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We dispersed to begin our individual preparations for the..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "After he was done with his speech, Lucian took Symon's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "After she was done with her speech, Lucian took Lileas's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Lachaven! There you have it!”"*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Citizens of Lachaven! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: "“As promised, Anton Rayne -- the 4th President of Sordlan..."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne -- the 4th President of Sordland -- has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "We walked towards the entrance of the highway next to the..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "We walked towards the entrance of the highway next to the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A 40-meter-long red ribbon stretched across it."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“Fellow Free Lachaveners! Welcome to the opening ceremony..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“Lachaveners! Welcome to the opening ceremony of the H-3 ..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The chanting from the crowd intensified. Some were yellin..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Although the delay had taken its toll on our morale, it was still a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CeremonialScissors");"*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“This is still a big success. Congratulations, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: "“To many more projects like this.”"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LateHighwayOpening = true;
BaseGame.Policy_Economy_HighwayProject = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LateHighwayOpening"] = true;
Variable["BaseGame.Policy_Economy_HighwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_InT_LateOpening = true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved = true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_E_H3_Taurus_Show = true; Base..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow = true; B..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_E_H3_SSC_Show = true;
BaseGameSupport.News_Turn08_HP_H3_SSC_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_H3_SSC_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_H3_SSC_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_E_H3_SSC_Show = true; BaseGam..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow = true; Base..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow = true;
BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_E_H3_Taurus_Show = true;
BaseGameSupport.News_Turn08_HP_H3_Taurus_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_H3_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_H3_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow = true;
BaseGameSupport.News_Turn08_E_H3_SSC_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_H3_SSC_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good opportunity to talk about the election campaign preparations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I revved the engine. Lucian waved at the press photograph..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The day before the grand opening ceremony of the H-3 High..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Highway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","Progress_Highway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRo..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRoadNetwork");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_LackofRoadNetwork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Arvory", "City_Logistica..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Arvory", "City_LogisticalIssues");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBu..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Lenkurg","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_HighLevels..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Laren", "City_DecreasingPov..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusi..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

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
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "It was a great victory for my administration."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBu..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBus..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_Decreasing..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == tr..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian and I, together with project leads Symon and Lilea..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lenkurg", "2.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lenkurg","2.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lenkurg","0.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Arvory", "5.1");"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lenkurg", "2.1");"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Arvory", "5.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Arvory","5.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Arvory", "1.35");"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Arvory", "1.35");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Arvory","1.35");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lachaven", "83.5");"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lachaven", "83.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lachaven", "3.4");"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lachaven", "3.4");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Hig..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RibbonCut");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Italic: "Cut the ribbon."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
