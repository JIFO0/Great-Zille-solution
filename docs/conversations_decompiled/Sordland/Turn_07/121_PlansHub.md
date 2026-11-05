# Sordland/Turn07/PlansHub

- **ID konwersacji:** `121`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/121_PlansHub.md`
- **Liczba węzłów dialogowych:** 122
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_B`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_C`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_D`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_E`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso`
- `BaseGame.Turn07_Results_Decision_NewJusticesList`
- `BaseGame.Turn07_Results_Decision_RallyAgainstSC`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn07_Results_Focus_Campaign`
- `BaseGame.Turn07_Results_Focus_Economy`
- `BaseGame.Turn07_Results_Focus_Party`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_B`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_C`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_D`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_E`
- `BaseGameSupport.Journal_Turn07_Results_CampaignFocus`
- `BaseGameSupport.Journal_Turn07_Results_EconomyFocus`
- `BaseGameSupport.Journal_Turn07_Results_NewJusticesList`
- `BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso`
- `BaseGameSupport.Journal_Turn07_Results_PartyFocus`
- `BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC`
- `BaseGameSupport.Journal_Turn07_Results_TrySoll`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[45]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""We must rally the people against the Supreme Court. That would put pressure on th..."** | `[53]` **Player**: ""If there are no comments, I wan..." | `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false` | `Variable["BaseGameSupport.Journal_Turn07_Results_RallyAga...`<br>`Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC...` | `[108]` **Narrator**: "Lucian put on his glasses to ins..." |
| `[7]` | **""The public opinion is concerning. We must focus on campaigning for the next elect..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "Lucian nodded in agreement." |
| `[8]` | **""We must focus on raising our public opinion and start campaigning for the next el..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "Lucian nodded in agreement." |
| `[12]` | **""The state of our economy is very concerning. It must be our focus to achieve quic..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Symon nodded in agreement." |
| `[13]` | **""Economy will be our number one priority until the end of our term. We will aim to..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Symon nodded in agreement." |
| `[14]` | **""It's time to focus on changing our party as a whole. I will add a new vision in o..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "The cabinet looked uneasy. Lilea..." |
| `[22]` | **""Sordland needs to become an economic powerhouse.""** | `[17]` **Narrator**: "Symon nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Almost everybody seemed to be in..." |
| `[23]` | **""We can't get elected if we do not improve the economy.""** | `[17]` **Narrator**: "Symon nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Almost everybody seemed to be in..." |
| `[24]` | **""We should focus on eliminating poverty and homelessness.""** | `[17]` **Narrator**: "Symon nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "Almost everybody seemed to be in..." |
| `[31]` | **""We must convince the public that the emergency was useful.""** | `[16]` **Narrator**: "Lucian nodded in agreement." | `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | `[35]` **Narrator**: "There was a mixed response, but ..." |
| `[32]` | **""We should put more focus on our constitutional victory.""** | `[16]` **Narrator**: "Lucian nodded in agreement." | `Variable["BaseGame.Reform_Reform_Court_Success"] == true`<br>`Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "There was a mixed response, but ..." |
| `[33]` | **""We should blame the opposition for the failure of the reforms.""** | `[16]` **Narrator**: "Lucian nodded in agreement." | `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`<br>`Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "There was a mixed response, but ..." |
| `[34]` | **""We can't get elected if we do not convince the public in some way.""** | `[16]` **Narrator**: "Lucian nodded in agreement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "There was a mixed response, but ..." |
| `[37]` | **""It's time USP shifts away from Sollism.""** | `[21]` **Lileas Graf**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lileas Graf**: ""I see. And the party leadership..." |
| `[38]` | **""As I said, I will reform our party platform.""** | `[21]` **Lileas Graf**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lileas Graf**: ""I see. And the party leadership..." |
| `[40]` | **""You see, I am the current chairman Mrs. Graf...""** | `[39]` **Lileas Graf**: ""I see. And the party leadership..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lileas Graf**: ""You are right about that. Howev..." |
| `[41]` | **""Do you not agree with that, Mrs. Graf?""** | `[39]` **Lileas Graf**: ""I see. And the party leadership..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: ""You'll learn about my thoughts ..." |
| `[42]` | **""I just wanted to announce this earlier, so you are aware. I won't change my mind.""** | `[39]` **Lileas Graf**: ""I see. And the party leadership..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "I turned to the others." |
| `[43]` | **""If there are no comments, let's move on with the meeting.""** | `[107]` **Narrator**: "I turned to the others."<br>`[35]` **Narrator**: "There was a mixed response, but ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[49]` | **""Thank you for your comments.""** | `[48]` **Lileas Graf**: ""That was the extent of my comme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "I turned to the others." |
| `[50]` | **""Frankly, I don't care what you think. It has already been decided.""** | `[48]` **Lileas Graf**: ""That was the extent of my comme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "I turned to the others." |
| `[53]` | **""If there are no comments, I want to talk about another plan.""** | `[107]` **Narrator**: "I turned to the others."<br>`[35]` **Narrator**: "There was a mixed response, but ..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false` | *Brak zmian stanu* | `[69]` **Player**: ""On a second thought, let's just..."<br>`[3]` **Player**: ""We must rally the people agains..."<br>*(oraz 3 innych odgałęzień)* |
| `[60]` | **""Now that we can, we will start an investigation on Tarquin Soll. It was long over..."** | `[53]` **Player**: ""If there are no comments, I wan..." | `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false`<br>`(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false` | `Variable["BaseGameSupport.Journal_Turn07_Results_TrySoll"...`<br>`Variable["BaseGame.Turn07_Results_Decision_TrySoll"] = tr...` | `[89]` **Narrator**: "Iosef narrowed his eyes and star..." |
| `[64]` | **""We can finally impeach Justices. Let's organize the Assembly against the Chief Ju..."** | `[53]` **Player**: ""If there are no comments, I wan..." | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false` | `Variable["BaseGameSupport.Journal_Turn07_Results_Organise...`<br>`Variable["BaseGame.Turn07_Results_Decision_AssemblyAgains...` | `[111]` **Narrator**: "Lucian put on his glasses to ins..." |
| `[68]` | **""With the new laws, I can reshuffle the Supreme Court. I want a list of names.""** | `[53]` **Player**: ""If there are no comments, I wan..." | `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false`<br>`(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false` | `Variable["BaseGameSupport.Journal_Turn07_Results_NewJusti...`<br>`Variable["BaseGame.Turn07_Results_Decision_NewJusticesLis...` | `[111]` **Narrator**: "Lucian put on his glasses to ins..." |
| `[69]` | **""On a second thought, let's just move on with the meeting before it gets too late.""** | `[53]` **Player**: ""If there are no comments, I wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[93]` | **""A lot of people suffered under Soll. Justice must be served.""** | `[92]` **Lileas Graf**: ""I cannot believe this administr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Lileas Graf**: ""I thought you respected Sollism..."<br>`[99]` **Lileas Graf**: ""He will not sit idly against yo..." |
| `[94]` | **""Thank you for your comments but I have already decided.""** | `[92]` **Lileas Graf**: ""I cannot believe this administr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Lileas Graf**: ""I thought you respected Sollism..."<br>`[99]` **Lileas Graf**: ""He will not sit idly against yo..." |
| `[100]` | **""Let's just move on, Mrs. Graf.""** | `[99]` **Lileas Graf**: ""He will not sit idly against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Player**: ""If there are no comments, let's..."<br>`[53]` **Player**: ""If there are no comments, I wan..." |
| `[101]` | **""He is an old man, Mrs. Graf. What is he going to do?""** | `[99]` **Lileas Graf**: ""He will not sit idly against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "She did not respond." |
| `[103]` | **""I asked you something.""** | `[102]` **Narrator**: "She did not respond." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lileas Graf**: ""You are right, Mr. President. *..." |
| `[106]` | **""You've heard me.""** | `[21]` **Lileas Graf**: ""I'm sorry?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lileas Graf**: ""I see. And the party leadership..." |
| `[121]` | **"Stay silent."** | `[102]` **Narrator**: "She did not respond." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Then I looked at everyone else t..." |

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
  - -> `[14]` (*Player: ""It's time to focus on changing our party as a whole. I w..."*)
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 10"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy < 5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We must rally the people against the Supreme Court. That would put pressure on their investigation.""]** — Mówca: **Player**
> ""We must rally the people against the Supreme Court. That would put pressure on their investigation.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC = true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 10"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < 10)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""The public opinion is concerning. We must focus on campa..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: ""We must focus on raising our public opinion and start ca..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""The public opinion is concerning. We must focus on campaigning for the next election already.""]** — Mówca: **Player**
> ""The public opinion is concerning. We must focus on campaigning for the next election already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Lucian nodded in agreement."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""We must focus on raising our public opinion and start campaigning for the next election already.""]** — Mówca: **Player**
> ""We must focus on raising our public opinion and start campaigning for the next election already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Lucian nodded in agreement."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy < 5"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy < 5)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""The state of our economy is very concerning. It must be ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""Economy will be our number one priority until the end of..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""The state of our economy is very concerning. It must be our focus to achieve quick economic development.""]** — Mówca: **Player**
> ""The state of our economy is very concerning. It must be our focus to achieve quick economic development.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Symon nodded in agreement."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Economy will be our number one priority until the end of our term. We will aim to boost it further.""]** — Mówca: **Player**
> ""Economy will be our number one priority until the end of our term. We will aim to boost it further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Symon nodded in agreement."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""It's time to focus on changing our party as a whole. I will add a new vision in our manifesto.""]** — Mówca: **Player**
> ""It's time to focus on changing our party as a whole. I will add a new vision in our manifesto.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The cabinet looked uneasy. Lileas spoke with a concerned ..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The cabinet looked uneasy. Lileas spoke with a concerned look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_PartyFocus = true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Lucian nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_CampaignFocus = true"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Symon nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_EconomyFocus = true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Party = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lileas Graf: ""I'm sorry?""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Campaign = true;
BaseGame.Public_Opinion += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Campaign"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[34]` (*Player: ""We can't get elected if we do not convince the public in..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Economy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Focus_Economy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""Sordland needs to become an economic powerhouse.""*)
  - -> `[23]` (*Player: ""We can't get elected if we do not improve the economy.""*)
  - -> `[24]` (*Player: ""We should focus on eliminating poverty and homelessness.""*)

### Węzeł `[21]`
Mówca: **Lileas Graf**
> ""I'm sorry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""It's time USP shifts away from Sollism.""*)
  - -> `[38]` (*Player: ""As I said, I will reform our party platform.""*)
  - -> `[106]` (*Player: ""You've heard me.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Sordland needs to become an economic powerhouse.""]** — Mówca: **Player**
> ""Sordland needs to become an economic powerhouse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Almost everybody seemed to be in agreement with me."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We can't get elected if we do not improve the economy.""]** — Mówca: **Player**
> ""We can't get elected if we do not improve the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Almost everybody seemed to be in agreement with me."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""We should focus on eliminating poverty and homelessness.""]** — Mówca: **Player**
> ""We should focus on eliminating poverty and homelessness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Almost everybody seemed to be in agreement with me."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""We must convince the public that the emergency was useful.""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""We should put more focus on our constitutional victory.""*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""We should blame the opposition for the failure of the re..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""We must convince the public that the emergency was useful.""]** — Mówca: **Player**
> ""We must convince the public that the emergency was useful.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "There was a mixed response, but the majority seemed to be..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""We should put more focus on our constitutional victory.""]** — Mówca: **Player**
> ""We should put more focus on our constitutional victory.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true` AND `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "There was a mixed response, but the majority seemed to be..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""We should blame the opposition for the failure of the reforms.""]** — Mówca: **Player**
> ""We should blame the opposition for the failure of the reforms.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` AND `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "There was a mixed response, but the majority seemed to be..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""We can't get elected if we do not convince the public in some way.""]** — Mówca: **Player**
> ""We can't get elected if we do not convince the public in some way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "There was a mixed response, but the majority seemed to be..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "There was a mixed response, but the majority seemed to be in agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Almost everybody seemed to be in agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""It's time USP shifts away from Sollism.""]** — Mówca: **Player**
> ""It's time USP shifts away from Sollism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: ""I see. And the party leadership will agree with that?""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""As I said, I will reform our party platform.""]** — Mówca: **Player**
> ""As I said, I will reform our party platform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: ""I see. And the party leadership will agree with that?""*)

### Węzeł `[39]`
Mówca: **Lileas Graf**
> ""I see. And the party leadership will agree with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""You see, I am the current chairman Mrs. Graf...""*)
  - -> `[41]` (*Player: ""Do you not agree with that, Mrs. Graf?""*)
  - -> `[42]` (*Player: ""I just wanted to announce this earlier, so you are aware..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""You see, I am the current chairman Mrs. Graf...""]** — Mówca: **Player**
> ""You see, I am the current chairman Mrs. Graf...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: ""You are right about that. However, the party does not be..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Do you not agree with that, Mrs. Graf?""]** — Mówca: **Player**
> ""Do you not agree with that, Mrs. Graf?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""You'll learn about my thoughts if you bring your suggest..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I just wanted to announce this earlier, so you are aware. I won't change my mind.""]** — Mówca: **Player**
> ""I just wanted to announce this earlier, so you are aware. I won't change my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I turned to the others."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""If there are no comments, let's move on with the meeting.""]** — Mówca: **Player**
> ""If there are no comments, let's move on with the meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SecondPlan`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && BaseGame.Re..."*)
  - -> `[43]` (*Player: ""If there are no comments, let's move on with the meeting.""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "SecondPlan"*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> ""You'll learn about my thoughts if you bring your suggestions to the leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: ""That was the extent of my comments. We can move on.""*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> ""You are right about that. However, the party does not belong to you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""You'll learn about my thoughts if you bring your suggest..."*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> ""That was the extent of my comments. We can move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""Frankly, I don't care what you think. It has already bee..."*)
  - -> `[49]` (*Player: ""Thank you for your comments.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Thank you for your comments.""]** — Mówca: **Player**
> ""Thank you for your comments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I turned to the others."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. It has already been decided.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. It has already been decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I turned to the others."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "SecondPlan"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "SecondPlan"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""If there are no comments, I want to talk about another plan.""]** — Mówca: **Player**
> ""If there are no comments, I want to talk about another plan.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator), `[35]` (Narrator), `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && BaseGame.Re..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[69]` (*Player: ""On a second thought, let's just move on with the meeting..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && BaseGame.Re..."*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == false && BaseGame...."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""We must rally the people against the Supreme Court. That..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGa..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGa..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Honorary_Abolished == true || Base..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""Now that we can, we will start an investigation on Tarqu..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Now that we can, we will start an investigation on Tarquin Soll. It was long overdue.""]** — Mówca: **Player**
> ""Now that we can, we will start an investigation on Tarquin Soll. It was long overdue.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false` AND `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_TrySoll = true; Ba..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""We can finally impeach Justices. Let's organize the Asse..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""We can finally impeach Justices. Let's organize the Assembly against the Chief Justice.""]** — Mówca: **Player**
> ""We can finally impeach Justices. Let's organize the Assembly against the Chief Justice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAg..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == tru..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""With the new laws, I can reshuffle the Supreme Court. I ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
**[WYBÓR GRACZA: ""With the new laws, I can reshuffle the Supreme Court. I want a list of names.""]** — Mówca: **Player**
> ""With the new laws, I can reshuffle the Supreme Court. I want a list of names.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false` AND `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_NewJusticesList = ..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""On a second thought, let's just move on with the meeting before it gets too late.""]** — Mówca: **Player**
> ""On a second thought, let's just move on with the meeting before it gets too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Yes, sir. I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""I'll start making the necessary arrangements.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_RallyAgainstSC = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_RallyAgainstSC"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Lucian put on his glasses to inspect the documents in fro..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_C = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Iosef narrowed his eyes and stared at me. I couldn't help..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Lucian put on his glasses to inspect the documents in fro..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_NewJusticesList = true; BaseGameIsolated.Turn07_CourtResults_PlansHub_E = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Results_Decision_NewJusticesList"] = true;
Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Lucian put on his glasses to inspect the documents in fro..."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Yes, sir. I'll start working on it immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He wrote on the document and put down his pen after."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "SecondPlan"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false && BaseGame.Re..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == false && BaseGame...."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""If there are no comments, I want to talk about another p..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == false && BaseGame.Reform_Autocrat_Path == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_B == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_B"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGa..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGa..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Honorary_Abolished == true || Base..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""If there are no comments, I want to talk about another p..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true) && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_C == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_C"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""If there are no comments, I want to talk about another p..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_D == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_D"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == tru..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""If there are no comments, I want to talk about another p..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Reform_Court_Success == true && BaseGameIsolated.Turn07_CourtResults_PlansHub_E == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_E"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Narrator**
> "Iosef narrowed his eyes and stared at me. I couldn't help but feel uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Lileas stood up and took a long look at the ministers aro..."*)

### Węzeł `[90]`
Mówca: **Lileas Graf**
> ""I have no words. And nobody else is going to react?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lileas Graf: ""I cannot believe this administration comes from the Unit..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Lileas stood up and took a long look at the ministers around the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lileas Graf: ""I have no words. And nobody else is going to react?""*)

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""I cannot believe this administration comes from the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""A lot of people suffered under Soll. Justice must be ser..."*)
  - -> `[94]` (*Player: ""Thank you for your comments but I have already decided.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""A lot of people suffered under Soll. Justice must be served.""]** — Mówca: **Player**
> ""A lot of people suffered under Soll. Justice must be served.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 8"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Thank you for your comments but I have already decided.""]** — Mówca: **Player**
> ""Thank you for your comments but I have already decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 8"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 8"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Sollist >= 8)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: ""I thought you respected Sollism. It seems I was complete..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Sollist >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""He will not sit idly against your attacks, Mr. President.""*)

### Węzeł `[98]`
Mówca: **Lileas Graf**
> ""I thought you respected Sollism. It seems I was completely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""He will not sit idly against your attacks, Mr. President.""*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""He will not sit idly against your attacks, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: ""He is an old man, Mrs. Graf. What is he going to do?""*)
  - -> `[100]` (*Player: ""Let's just move on, Mrs. Graf.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Let's just move on, Mrs. Graf.""]** — Mówca: **Player**
> ""Let's just move on, Mrs. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""He is an old man, Mrs. Graf. What is he going to do?""]** — Mówca: **Player**
> ""He is an old man, Mrs. Graf. What is he going to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "She did not respond."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "She did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: ""I asked you something.""*)
  - -> `[121]` (*Player_Italic: "Stay silent."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I asked you something.""]** — Mówca: **Player**
> ""I asked you something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: ""You are right, Mr. President. *As always*. Let's just mo..."*)

### Węzeł `[104]`
Mówca: **Lileas Graf**
> ""You are right, Mr. President. *As always*. Let's just move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "She sighed deeply. I looked at the cabinet to measure the..."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""I'll start making the necessary arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He wrote on the document and put down his pen after."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You've heard me.""]** — Mówca: **Player**
> ""You've heard me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: ""I see. And the party leadership will agree with that?""*)

### Węzeł `[107]`
Mówca: **Narrator**
> "I turned to the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian put on his glasses to inspect the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""Yes, sir. I agree.""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He wrote on the document and put down his pen after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He wrote on the document and put down his pen after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Lucian put on his glasses to inspect the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""Yes, sir. I'll start working on it immediately.""*)

### Węzeł `[112]`
Mówca: **Narrator**
> "She sighed deeply. I looked at the cabinet to measure their reactions. No one said anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Then I looked at everyone else to measure their reactions. No one said anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_CampaignFocus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_CampaignFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign = true; BaseGame.P..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_PartyFocus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_PartyFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Party = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_EconomyFocus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_EconomyFocus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Economy = true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_OrganiseAssemblyAgainstOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso = tr..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_NewJusticesList = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_NewJusticesList"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_NewJusticesList = true; ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_RallyAgainstSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_RallyAgainstSC = true; B..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_TrySoll = true;
BaseGame.Public_Opinion -= 5;
BaseGame.Bludish_Opinion += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_TrySoll"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll = true; BaseGame..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I looked at her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Then I looked at everyone else to measure their reactions..."*)
