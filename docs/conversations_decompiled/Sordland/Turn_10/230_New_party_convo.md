# Sordland/Turn10/New party convo

- **ID konwersacji:** `230`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/230_New_party_convo.md`
- **Liczba węzłów dialogowych:** 140
- **Liczba wyborów gracza:** 27

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_SordishProsperityParty`
- `BaseGame.Turn08_Action_Party_Ultranationalist`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[231] Sordland/Turn10/Term plans** (../Turn_10/231_Term_plans.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""The USP is stuck in the past. I founded a new party to turn Sordland into the mod..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lileas Graf**: ""No, you founded it because you ..." |
| `[26]` | **""My new party is a chance to return Sordland to its Sollist roots. The Colonel of ..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true` | *Brak zmian stanu* | `[40]` **Lileas Graf**: ""How can you possibly say that a..."<br>`[41]` **Lileas Graf**: ""Preposterous. Any follower of S..." |
| `[27]` | **""The USP has forgotten who it serves: the Sordish people. With my new party, every..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Archetype_DemocraticRayne"] == true`<br>`(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false` | *Brak zmian stanu* | `[75]` **Frens Ricter**: ""If you really wanted Sordland t..."<br>`[76]` **Manoly Suheil**: ""If you really wanted Sordland t..."<br>*(oraz 1 innych odgałęzień)* |
| `[28]` | **""The USP has forgotten what the 'S' in its name stands for. My new party will put ..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Kesaro Kibener**: ""Any true Sordish patriot would ..."<br>`[58]` **Remus Holstron**: ""Your allegiances show where you..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **""In a word, money. The USP has had a chokehold on the economy for too long. It's t..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lileas Graf**: ""Spoken like a true puppet of th..."<br>`[39]` **Frens Ricter**: ""By nationalizing them, you mean..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **""I can be proud of my country without being a bigot.""** | `[54]` **Kesaro Kibener**: ""Any true Sordish patriot would ..."<br>`[58]` **Remus Holstron**: ""Your allegiances show where you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Kesaro Kibener**: ""Such crude language, Mr. Presid..."<br>`[123]` **Remus Holstron**: ""Come over here and say that to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **""The NFP doesn't think big enough. My party will crush all of Sordland's enemies.""** | `[54]` **Kesaro Kibener**: ""Any true Sordish patriot would ..."<br>`[58]` **Remus Holstron**: ""Your allegiances show where you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Kesaro Kibener**: ""Big ambitions for such a unimag..."<br>`[133]` **Remus Holstron**: ""Not if we crush you with our ir..."<br>*(oraz 1 innych odgałęzień)* |
| `[62]` | **""To be honest, I just plain don't like the NFP.""** | `[54]` **Kesaro Kibener**: ""Any true Sordish patriot would ..."<br>`[58]` **Remus Holstron**: ""Your allegiances show where you..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Kesaro Kibener**: ""Such crude language, Mr. Presid..."<br>`[123]` **Remus Holstron**: ""Come over here and say that to ..."<br>*(oraz 1 innych odgałęzień)* |
| `[63]` | **""I'm prepared to ally with the NFP.""** | `[54]` **Kesaro Kibener**: ""Any true Sordish patriot would ..."<br>`[58]` **Remus Holstron**: ""Your allegiances show where you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Kesaro Kibener**: ""Not now. It's too risky.""<br>`[114]` **Remus Holstron**: ""Never. Not after what happened ..." |
| `[64]` | **""I liked Soll's ideas. Not the man himself.""** | `[40]` **Lileas Graf**: ""How can you possibly say that a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Lileas Graf**: ""You traitor!"" |
| `[65]` | **""Not after the way I was betrayed.""** | `[41]` **Lileas Graf**: ""Preposterous. Any follower of S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Lileas Graf**: ""Saving one's own party is hardl..." |
| `[66]` | **""No. It's time to take his ideas and bring them into our modern age.""** | `[41]` **Lileas Graf**: ""Preposterous. Any follower of S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lileas Graf**: ""All this talk of modernity, yet..." |
| `[67]` | **""Honestly, I just couldn't stomach the thought of you as president.""** | `[41]` **Lileas Graf**: ""Preposterous. Any follower of S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lileas Graf**: ""The feeling is mutual."" |
| `[68]` | **""Soll betrayed his own ideals. He had to go.""** | `[40]` **Lileas Graf**: ""How can you possibly say that a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Lileas Graf**: ""You traitor!"" |
| `[78]` | **""To be honest, I just plain don't like the PFJP.""** | `[75]` **Frens Ricter**: ""If you really wanted Sordland t..."<br>`[76]` **Manoly Suheil**: ""If you really wanted Sordland t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lileas Graf**: ""At last, something we agree on."" |
| `[79]` | **""I'm prepared to ally with the PFJP.""** | `[75]` **Frens Ricter**: ""If you really wanted Sordland t..."<br>`[76]` **Manoly Suheil**: ""If you really wanted Sordland t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Frens Ricter**: ""Not now. It's too risky.""<br>`[100]` **Manoly Suheil**: ""Never. Not after what happened ..." |
| `[80]` | **""No, the PFJP is too capitalist for my tastes.""** | `[75]` **Frens Ricter**: ""If you really wanted Sordland t..."<br>`[76]` **Manoly Suheil**: ""If you really wanted Sordland t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Frens Ricter**: ""Fair enough. There's room in th..."<br>`[105]` **Manoly Suheil**: ""Fair enough. There's room in th..."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **""The PFJP is too globalist for me. I want to keep the focus on Sordland.""** | `[75]` **Frens Ricter**: ""If you really wanted Sordland t..."<br>`[76]` **Manoly Suheil**: ""If you really wanted Sordland t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Frens Ricter**: ""Fair enough. There's room in th..."<br>`[105]` **Manoly Suheil**: ""Fair enough. There's room in th..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""The USP cannot admit that Malenyev had the right idea. My party will finally brin..."** | `[21]` **Moderator**: ""What exactly does the Democrat ..."<br>`[22]` **Moderator**: ""What exactly does the Liberal P..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Archetype_ComradeRayne"] == true`<br>`(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`<br>`(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false` | *Brak zmian stanu* | `[83]` **Denis Stahler**: ""Any true communist would have j..." |
| `[84]` | **""I'm prepared to ally with the Communist Party.""** | `[83]` **Denis Stahler**: ""Any true communist would have j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Denis Stahler**: ""That doesn't change the fact th..." |
| `[85]` | **""To be honest, I just plain don't like the Communist Party.""** | `[83]` **Denis Stahler**: ""Any true communist would have j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Denis Stahler**: ""Then you've just lost yourself ..." |
| `[86]` | **""Your party is too radical, Stahler. I'm willing to make compromises to achieve ou..."** | `[83]` **Denis Stahler**: ""Any true communist would have j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Denis Stahler**: ""Then you've just lost yourself ..." |
| `[87]` | **""Any true communist would not have gone against Leon Malenyev.""** | `[83]` **Denis Stahler**: ""Any true communist would have j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Denis Stahler**: ""But if you really pay attention..." |
| `[89]` | **""I'm so happy I don't have to put up with another four years of you.""** | `[88]` **Lileas Graf**: ""No, you founded it because you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Lileas Graf**: ""I'm going to enjoy crushing you..." |
| `[90]` | **""I still respect you, Lileas. I had hoped we could settle this like adults.""** | `[88]` **Lileas Graf**: ""No, you founded it because you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Lileas Graf**: ""You were such a bright boy, Pre..." |
| `[91]` | **""I was happy to lose. It gave me the excuse to do what I'd wanted to for years.""** | `[88]` **Lileas Graf**: ""No, you founded it because you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Lileas Graf**: ""I'm going to enjoy crushing you..." |
| `[92]` | **""That was the initial reason, yes. But I've had time to develop my platform.""** | `[88]` **Lileas Graf**: ""No, you founded it because you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Lileas Graf**: ""You were such a bright boy, Pre..." |

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
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "New Party Convo"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Moderator**
> ""I'd like to begin by giving President Rayne a chance to speak about his decision to form a new party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_DemocratParty == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_DemocratParty == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_DemocratParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Moderator: ""What exactly does the Democrat Party have to offer that ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_DemocratParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_LiberalParty == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_LiberalParty == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_LiberalParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Moderator: ""What exactly does the Liberal Party have to offer that t..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_LiberalParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_MaroonParty == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_MaroonParty == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_MaroonParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Moderator: ""What exactly does the Maroon Party have to offer that th..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_MaroonParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_SordishProsperityParty == true"*)

### Węzeł `[13]`
Mówca: **Moderator**
> ""On to the next question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_SordishProsperityParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.NewParty_SordishProsperityParty == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NewParty_SordishProsperityParty == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NewParty_SordishProsperityParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NewParty_SordishProsperityParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Moderator: ""What exactly does the Sordish Prosperity Party have to o..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NewParty_SordishProsperityParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NewParty_SordishProsperityParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Moderator: ""What exactly does the People's Party have to offer that ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: ""Spoken like a true puppet of the Oligarchs.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""The USP is stuck in the past. I founded a new party to turn Sordland into the modern, competitive nation it is destined to become.""]** — Mówca: **Player**
> ""The USP is stuck in the past. I founded a new party to turn Sordland into the modern, competitive nation it is destined to become.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: ""No, you founded it because you could not admit you had l..."*)

### Węzeł `[21]`
Mówca: **Moderator**
> ""What exactly does the Democrat Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[29]` (*Player: ""In a word, money. The USP has had a chokehold on the eco..."*)
  - -> `[28]` (*Player: ""The USP has forgotten what the 'S' in its name stands fo..."*)
  - -> `[20]` (*Player: ""The USP is stuck in the past. I founded a new party to t..."*)

### Węzeł `[22]`
Mówca: **Moderator**
> ""What exactly does the Liberal Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[29]` (*Player: ""In a word, money. The USP has had a chokehold on the eco..."*)
  - -> `[28]` (*Player: ""The USP has forgotten what the 'S' in its name stands fo..."*)
  - -> `[20]` (*Player: ""The USP is stuck in the past. I founded a new party to t..."*)

### Węzeł `[23]`
Mówca: **Moderator**
> ""What exactly does the Maroon Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[29]` (*Player: ""In a word, money. The USP has had a chokehold on the eco..."*)
  - -> `[28]` (*Player: ""The USP has forgotten what the 'S' in its name stands fo..."*)
  - -> `[20]` (*Player: ""The USP is stuck in the past. I founded a new party to t..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `New Party Convo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Moderator: ""I'd like to begin by giving President Rayne a chance to ..."*)

### Węzeł `[25]`
Mówca: **Moderator**
> ""What exactly does the Sordish Prosperity Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[29]` (*Player: ""In a word, money. The USP has had a chokehold on the eco..."*)
  - -> `[28]` (*Player: ""The USP has forgotten what the 'S' in its name stands fo..."*)
  - -> `[20]` (*Player: ""The USP is stuck in the past. I founded a new party to t..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""My new party is a chance to return Sordland to its Sollist roots. The Colonel of 20 years ago would not recognize what the USP has become today.""]** — Mówca: **Player**
> ""My new party is a chance to return Sordland to its Sollist roots. The Colonel of 20 years ago would not recognize what the USP has become today.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true ||..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""The USP has forgotten who it serves: the Sordish people. With my new party, everyone will have a voice.""]** — Mówca: **Player**
> ""The USP has forgotten who it serves: the Sordish people. With my new party, everyone will have a voice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true` AND `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""The USP has forgotten what the 'S' in its name stands for. My new party will put Sordland first.""]** — Mówca: **Player**
> ""The USP has forgotten what the 'S' in its name stands for. My new party will put Sordland first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""In a word, money. The USP has had a chokehold on the economy for too long. It's time to give Sordish businesses a chance to thrive.""]** — Mówca: **Player**
> ""In a word, money. The USP has had a chokehold on the economy for too long. It's time to give Sordish businesses a chance to thrive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The moderator motioned for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Moderator: ""On to the next question.""*)

### Węzeł `[31]`
Mówca: **Lileas Graf**
> ""Spoken like a true puppet of the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[32]`
Mówca: **Moderator**
> ""What exactly does the People's Party have to offer that the USP did not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[29]` (*Player: ""In a word, money. The USP has had a chokehold on the eco..."*)
  - -> `[28]` (*Player: ""The USP has forgotten what the 'S' in its name stands fo..."*)
  - -> `[20]` (*Player: ""The USP is stuck in the past. I founded a new party to t..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Frens Ricter: ""By nationalizing them, you mean? Ridiculous!""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Manoly Suheil: ""By nationalizing them, you mean? Ridiculous!""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true ||..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lileas Graf: ""How can you possibly say that after what you did to him?""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lileas Graf: ""Preposterous. Any follower of Soll would stay true to th..."*)

### Węzeł `[39]`
Mówca: **Frens Ricter**
> ""By nationalizing them, you mean? Ridiculous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[40]`
Mówca: **Lileas Graf**
> ""How can you possibly say that after what you did to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""I liked Soll's ideas. Not the man himself.""*)
  - -> `[68]` (*Player: ""Soll betrayed his own ideals. He had to go.""*)

### Węzeł `[41]`
Mówca: **Lileas Graf**
> ""Preposterous. Any follower of Soll would stay true to the party he founded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Not after the way I was betrayed.""*)
  - -> `[66]` (*Player: ""No. It's time to take his ideas and bring them into our ..."*)
  - -> `[67]` (*Player: ""Honestly, I just couldn't stomach the thought of you as ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true || BaseGame.Turn0..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true || BaseGame.Tur..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""My new party is a chance to return Sordland to its Solli..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true || BaseGame.Turn08_Action_Party_Ultranationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_DemocraticRayne == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_DemocraticRayne == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_DemocraticRayne == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_DemocraticRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""The USP has forgotten who it serves: the Sordish people...."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_DemocraticRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""The USP cannot admit that Malenyev had the right idea. M..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Kesaro Kibener: ""Any true Sordish patriot would have joined the NFP. You'..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[54]`
Mówca: **Kesaro Kibener**
> ""Any true Sordish patriot would have joined the NFP. You're in this for yourself, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""To be honest, I just plain don't like the NFP.""*)
  - -> `[60]` (*Player: ""I can be proud of my country without being a bigot.""*)
  - -> `[61]` (*Player: ""The NFP doesn't think big enough. My party will crush al..."*)
  - -> `[63]` (*Player: ""I'm prepared to ally with the NFP.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Remus Holstron: ""Your allegiances show where your petty priorities lie. T..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: ""Ah, so you eliminated the NFP leadership so you could ta..."*)

### Węzeł `[58]`
Mówca: **Remus Holstron**
> ""Your allegiances show where your petty priorities lie. This is not about the rise of the Sordish people but your own individual ego, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""To be honest, I just plain don't like the NFP.""*)
  - -> `[60]` (*Player: ""I can be proud of my country without being a bigot.""*)
  - -> `[61]` (*Player: ""The NFP doesn't think big enough. My party will crush al..."*)
  - -> `[63]` (*Player: ""I'm prepared to ally with the NFP.""*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""Ah, so you eliminated the NFP leadership so you could take on its values for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""To be honest, I just plain don't like the NFP.""*)
  - -> `[60]` (*Player: ""I can be proud of my country without being a bigot.""*)
  - -> `[61]` (*Player: ""The NFP doesn't think big enough. My party will crush al..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""I can be proud of my country without being a bigot.""]** — Mówca: **Player**
> ""I can be proud of my country without being a bigot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Kesaro Kibener), `[58]` (Remus Holstron), `[59]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""The NFP doesn't think big enough. My party will crush all of Sordland's enemies.""]** — Mówca: **Player**
> ""The NFP doesn't think big enough. My party will crush all of Sordland's enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Kesaro Kibener), `[58]` (Remus Holstron), `[59]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the NFP.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Kesaro Kibener), `[58]` (Remus Holstron), `[59]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the NFP.""]** — Mówca: **Player**
> ""I'm prepared to ally with the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Kesaro Kibener), `[58]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I liked Soll's ideas. Not the man himself.""]** — Mówca: **Player**
> ""I liked Soll's ideas. Not the man himself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lileas Graf: ""You traitor!""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Not after the way I was betrayed.""]** — Mówca: **Player**
> ""Not after the way I was betrayed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lileas Graf: ""Saving one's own party is hardly a 'betrayal' --""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""No. It's time to take his ideas and bring them into our modern age.""]** — Mówca: **Player**
> ""No. It's time to take his ideas and bring them into our modern age.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lileas Graf: ""All this talk of modernity, yet you--""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Honestly, I just couldn't stomach the thought of you as president.""]** — Mówca: **Player**
> ""Honestly, I just couldn't stomach the thought of you as president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lileas Graf: ""The feeling is mutual.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Soll betrayed his own ideals. He had to go.""]** — Mówca: **Player**
> ""Soll betrayed his own ideals. He had to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lileas Graf: ""You traitor!""*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Frens Ricter: ""If you really wanted Sordland to have a chance at democr..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manoly Suheil: ""If you really wanted Sordland to have a chance at democr..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lileas Graf: ""Ah, so you eliminated the PFJP leadership so you could t..."*)

### Węzeł `[75]`
Mówca: **Frens Ricter**
> ""If you really wanted Sordland to have a chance at democracy, you would have endorsed the PFJP after your Congress loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""The PFJP is too globalist for me. I want to keep the foc..."*)
  - -> `[80]` (*Player: ""No, the PFJP is too capitalist for my tastes.""*)
  - -> `[78]` (*Player: ""To be honest, I just plain don't like the PFJP.""*)
  - -> `[79]` (*Player: ""I'm prepared to ally with the PFJP.""*)

### Węzeł `[76]`
Mówca: **Manoly Suheil**
> ""If you really wanted Sordland to have a chance at democracy, you would have endorsed the PFJP after your Congress loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""The PFJP is too globalist for me. I want to keep the foc..."*)
  - -> `[80]` (*Player: ""No, the PFJP is too capitalist for my tastes.""*)
  - -> `[78]` (*Player: ""To be honest, I just plain don't like the PFJP.""*)
  - -> `[79]` (*Player: ""I'm prepared to ally with the PFJP.""*)

### Węzeł `[77]`
Mówca: **Lileas Graf**
> ""Ah, so you eliminated the PFJP leadership so you could take on its values for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""The PFJP is too globalist for me. I want to keep the foc..."*)
  - -> `[80]` (*Player: ""No, the PFJP is too capitalist for my tastes.""*)
  - -> `[78]` (*Player: ""To be honest, I just plain don't like the PFJP.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the PFJP.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Frens Ricter), `[76]` (Manoly Suheil), `[77]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: ""At last, something we agree on.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the PFJP.""]** — Mówca: **Player**
> ""I'm prepared to ally with the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Frens Ricter), `[76]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""No, the PFJP is too capitalist for my tastes.""]** — Mówca: **Player**
> ""No, the PFJP is too capitalist for my tastes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Frens Ricter), `[76]` (Manoly Suheil), `[77]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The PFJP is too globalist for me. I want to keep the focus on Sordland.""]** — Mówca: **Player**
> ""The PFJP is too globalist for me. I want to keep the focus on Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Frens Ricter), `[76]` (Manoly Suheil), `[77]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""The USP cannot admit that Malenyev had the right idea. My party will finally bring communism to Sordland:""]** — Mówca: **Player**
> ""The USP cannot admit that Malenyev had the right idea. My party will finally bring communism to Sordland:""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"] == true` AND `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false` AND `(Variable["BaseGame.Archetype_SollistRayne"] == true  or  Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Moderator), `[22]` (Moderator), `[23]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Denis Stahler: ""Any true communist would have joined the Communist Party..."*)

### Węzeł `[83]`
Mówca: **Denis Stahler**
> ""Any true communist would have joined the Communist Party. You're in this for yourself, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Any true communist would not have gone against Leon Male..."*)
  - -> `[86]` (*Player: ""Your party is too radical, Stahler. I'm willing to make ..."*)
  - -> `[85]` (*Player: ""To be honest, I just plain don't like the Communist Party.""*)
  - -> `[84]` (*Player: ""I'm prepared to ally with the Communist Party.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I'm prepared to ally with the Communist Party.""]** — Mówca: **Player**
> ""I'm prepared to ally with the Communist Party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Denis Stahler: ""That doesn't change the fact that--""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""To be honest, I just plain don't like the Communist Party.""]** — Mówca: **Player**
> ""To be honest, I just plain don't like the Communist Party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Denis Stahler: ""Then you've just lost yourself an ally. In fact--""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Your party is too radical, Stahler. I'm willing to make compromises to achieve our goals.""]** — Mówca: **Player**
> ""Your party is too radical, Stahler. I'm willing to make compromises to achieve our goals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Denis Stahler: ""Then you've just lost yourself an ally. In fact--""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Any true communist would not have gone against Leon Malenyev.""]** — Mówca: **Player**
> ""Any true communist would not have gone against Leon Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Denis Stahler: ""But if you really pay attention to what Marcia said--""*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""No, you founded it because you could not admit you had lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""I'm so happy I don't have to put up with another four ye..."*)
  - -> `[90]` (*Player: ""I still respect you, Lileas. I had hoped we could settle..."*)
  - -> `[91]` (*Player: ""I was happy to lose. It gave me the excuse to do what I'..."*)
  - -> `[92]` (*Player: ""That was the initial reason, yes. But I've had time to d..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""I'm so happy I don't have to put up with another four years of you.""]** — Mówca: **Player**
> ""I'm so happy I don't have to put up with another four years of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lileas Graf: ""I'm going to enjoy crushing you at the polls.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I still respect you, Lileas. I had hoped we could settle this like adults.""]** — Mówca: **Player**
> ""I still respect you, Lileas. I had hoped we could settle this like adults.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lileas Graf: ""You were such a bright boy, President Rayne. What happen..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""I was happy to lose. It gave me the excuse to do what I'd wanted to for years.""]** — Mówca: **Player**
> ""I was happy to lose. It gave me the excuse to do what I'd wanted to for years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lileas Graf: ""I'm going to enjoy crushing you at the polls.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""That was the initial reason, yes. But I've had time to develop my platform.""]** — Mówca: **Player**
> ""That was the initial reason, yes. But I've had time to develop my platform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lileas Graf: ""You were such a bright boy, President Rayne. What happen..."*)

### Węzeł `[93]`
Mówca: **Denis Stahler**
> ""That doesn't change the fact that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[94]`
Mówca: **Denis Stahler**
> ""But if you really pay attention to what Marcia said--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[95]`
Mówca: **Denis Stahler**
> ""Then you've just lost yourself an ally. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Frens Ricter: ""Not now. It's too risky.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Manoly Suheil: ""Never. Not after what happened to--""*)

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""Not now. It's too risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[100]`
Mówca: **Manoly Suheil**
> ""Never. Not after what happened to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Frens Ricter: ""Fair enough. There's room in the Assembly for both our p..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[104]`
Mówca: **Frens Ricter**
> ""Fair enough. There's room in the Assembly for both our parties. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[105]`
Mówca: **Manoly Suheil**
> ""Fair enough. There's room in the Assembly for both our parties. In fact--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manoly Suheil: ""Fair enough. There's room in the Assembly for both our p..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: ""At last, something we agree on.""*)

### Węzeł `[109]`
Mówca: **Lileas Graf**
> ""At last, something we agree on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Kesaro Kibener: ""Not now. It's too risky.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Remus Holstron: ""Never. Not after what happened to--""*)

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Not now. It's too risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[114]`
Mówca: **Remus Holstron**
> ""Never. Not after what happened to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Kesaro Kibener: ""Such crude language, Mr. President.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Remus Holstron: ""Come over here and say that to my face. I doubt that you..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lileas Graf: ""A valid sentiment.""*)

### Węzeł `[121]`
Mówca: **Lileas Graf**
> ""I'm going to enjoy crushing you at the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[122]`
Mówca: **Lileas Graf**
> ""You were such a bright boy, President Rayne. What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[123]`
Mówca: **Remus Holstron**
> ""Come over here and say that to my face. I doubt that you have the same will as we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[124]`
Mówca: **Kesaro Kibener**
> ""Such crude language, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[125]`
Mówca: **Lileas Graf**
> ""A valid sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[126]`
Mówca: **Lileas Graf**
> ""With my help, you could have. You don't have a prayer now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Kesaro Kibener: ""Big ambitions for such a unimaginative party.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Remus Holstron: ""Not if we crush you with our iron will first.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lileas Graf: ""With my help, you could have. You don't have a prayer now.""*)

### Węzeł `[133]`
Mówca: **Remus Holstron**
> ""Not if we crush you with our iron will first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Big ambitions for such a unimaginative party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[135]`
Mówca: **Lileas Graf**
> ""You traitor!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[136]`
Mówca: **Lileas Graf**
> ""Saving one's own party is hardly a 'betrayal' --""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[137]`
Mówca: **Lileas Graf**
> ""All this talk of modernity, yet you--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[138]`
Mówca: **Lileas Graf**
> ""The feeling is mutual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)

### Węzeł `[139]`
Mówca: **Manoly Suheil**
> ""By nationalizing them, you mean? Ridiculous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The moderator motioned for silence."*)
