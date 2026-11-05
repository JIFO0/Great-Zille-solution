# Sordland/Turn09/KatarinaTalks

- **ID konwersacji:** `200`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/200_KatarinaTalks.md`
- **Liczba węzłów dialogowych:** 253
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[53]** Katarina Horten

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn08_HarsherSecurity_Signed`
- `BaseGame.Bill_Turn09_StrongWomensRights_Signed`
- `BaseGame.Bill_Turn09_WeakWomensRights_Signed`
- `BaseGame.CurrentSpeaker_Katarina`
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_PresiPower_Default_DeSollinisation`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn08_HarsherSecurity_Signed`
- `BaseGame.Bill_Turn09_LighterSecurity_Signed`
- `BaseGame.CurrentSpeaker_Katarina`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.LateGameCrisis`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Policy_Order_DetentionWithoutTrial`
- `BaseGame.Policy_Order_SuspendedProtests`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGame.Sollist`
- `BaseGame.Turn09_Detained_Katarina`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_Peaceful_Deal_Failed`
- `BaseGame.Unrest_Peaceful_Deal_Promised`
- `BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten`
- `BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten_Detained`
- `BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser`
- `BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser_Dismissed`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus`
- `BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland`
- `BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland_KatarinaArrested`
- `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Decree`
- `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_DetainKatarina`
- `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Promise`
- `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Refuse`
- `BaseGameSupport.News_Turn09_HP_Emergency_Revoked`
- `BaseGameSupport.News_Turn09_HP_FreedomsAct_Decree`
- `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Decree`
- `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_DecreeDuringEmergency`
- `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Detained`
- `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_NoSupport`
- `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Support`
- `BaseGameSupport.News_Turn09_R_Emergency_Revoked`
- `BaseGameSupport.News_Turn09_R_FreedomsAct_Decree`
- `BaseGameSupport.News_Turn09_ST_Emergency_Revoked_Media`
- `BaseGameSupport.News_Turn09_ST_Emergency_Revoked_NoMedia`
- `BaseGameSupport.Report_Turn09_Erzaren_Emergency_Revoked`
- `BaseGameSupport.Report_Turn09_Holsord_Emergency_Revoked`
- `BaseGameSupport.Report_Turn09_Jen_Emergency_Revoked`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[197] Sordland/Turn09/A_Talks** (../Turn_09/197_A_Talks.md), Węzeł `[59]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""Just make your point. You are falling into diatribe.""** | `[28]` **Katarina Horten**: ""But they did. This is a huge ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Katarina Horten**: ""You already know about the issu..." |
| `[8]` | **""People? How about you? What do you earn from inciting unrest?""** | `[6]` **Katarina Horten**: ""People are finally calling out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Katarina Horten**: ""You are getting this all wrong,..." |
| `[10]` | **""I've done everything for my people.""** | `[6]` **Katarina Horten**: ""People are finally calling out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Katarina Horten**: ""Maybe your values are different..." |
| `[11]` | **""I respect that, Mrs. Horten. That's why we're here to have a discussion.""** | `[6]` **Katarina Horten**: ""People are finally calling out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Katarina Horten**: ""Yes."" |
| `[16]` | **""What you are doing is illegal. We are in an emergency.""** | `[6]` **Katarina Horten**: ""People are finally calling out ..." | `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true` | *Brak zmian stanu* | `[17]` **Katarina Horten**: ""This is precisely why we had to..." |
| `[29]` | **""I've seen them, Mrs. Horten. And I want to help.""** | `[28]` **Katarina Horten**: ""But they did. This is a huge ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Katarina Horten**: ""You already know about the issu..." |
| `[30]` | **""Nonsense. They are coming together because of people like you.""** | `[28]` **Katarina Horten**: ""But they did. This is a huge ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Katarina Horten**: ""You think they cannot distingui..." |
| `[36]` | **""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""** | `[40]` **Katarina Horten**: ""The police state Soll created s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Katarina Horten**: ""This has become a systemic prob..." |
| `[42]` | **""These policemen acted on their own accord. We never gave them such orders.""** | `[40]` **Katarina Horten**: ""The police state Soll created s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Katarina Horten**: ""This has become a systemic prob..." |
| `[43]` | **""I've already defunded the police. What more can I do?""** | `[40]` **Katarina Horten**: ""The police state Soll created s..." | `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true` | *Brak zmian stanu* | `[41]` **Katarina Horten**: ""The problem isn't their funding..." |
| `[47]` | **""I'm ready to do something about this.""** | `[40]` **Katarina Horten**: ""The police state Soll created s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Katarina Horten**: ""I'm glad to hear it."" |
| `[60]` | **""I'm ready to do something about this.""** | `[59]` **Katarina Horten**: ""The police state Soll created l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Katarina Horten**: ""I'm glad to hear it."" |
| `[61]` | **""These policemen acted on their own accord. We never gave them such orders.""** | `[59]` **Katarina Horten**: ""The police state Soll created l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Katarina Horten**: ""You gave them more authority th..." |
| `[62]` | **""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""** | `[59]` **Katarina Horten**: ""The police state Soll created l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Katarina Horten**: ""You gave them more authority th..." |
| `[63]` | **""Sordland had serious security problems. These laws were necessary.""** | `[59]` **Katarina Horten**: ""The police state Soll created l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Katarina Horten**: ""So, you are fine with killing y..." |
| `[77]` | **""I can help you with these. What is in this Freedom Act?""** | `[76]` **Katarina Horten**: ""It must be implemented.""<br>`[83]` **Katarina Horten**: ""We know what your powers are. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "She straightened her back." |
| `[78]` | **""I can't dismiss Mr. Greiser just like that. He was doing his job.""** | `[76]` **Katarina Horten**: ""It must be implemented."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Katarina Horten**: ""You seem not to understand the ..." |
| `[79]` | **""Out of the question.""** | `[76]` **Katarina Horten**: ""It must be implemented."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "A muscle in her jaw twitched." |
| `[84]` | **""This country still has a functioning government. I can't listen to the demands of..."** | `[83]` **Katarina Horten**: ""We know what your powers are. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Katarina Horten**: ""Mob?"" |
| `[85]` | **""I'm sorry, Mrs. Horten. But I can't do it. You need to compromise.""** | `[83]` **Katarina Horten**: ""We know what your powers are. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Katarina Horten**: ""I thought you invited me here t..." |
| `[89]` | **""You might be right... What's in this Freedom Act?""** | `[88]` **Katarina Horten**: ""The people have made many compr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "She straightened her back." |
| `[90]` | **""I think they are being manipulated by people like you, Mrs. Horten. I doubt that ..."** | `[81]` **Katarina Horten**: ""You will continue the tradition..."<br>`[88]` **Katarina Horten**: ""The people have made many compr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Katarina Horten**: ""How dare you even suggest that?"" |
| `[91]` | **""I'm the president, Mrs. Horten. And I made my decision.""** | `[88]` **Katarina Horten**: ""The people have made many compr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "A muscle in her jaw twitched." |
| `[92]` | **""Be careful with your tone, Mrs. Horten. You are speaking to the president.""** | `[81]` **Katarina Horten**: ""You will continue the tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Katarina Horten**: ""It seems power have consumed you."" |
| `[93]` | **""The meeting is over.""** | `[81]` **Katarina Horten**: ""You will continue the tradition..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Katarina Horten**: ""It seems power have consumed you."" |
| `[105]` | **""The state of emergency remains.""** | `[76]` **Katarina Horten**: ""It must be implemented."" | `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true` | *Brak zmian stanu* | `[80]` **Narrator**: "A muscle in her jaw twitched." |
| `[109]` | **""Okay, I agree to all of your demands. I'll sign it.""** | `[108]` **Katarina Horten**: ""And the police's right to stop ..." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_...`<br>`Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[113]` | **""Okay, I agree to all of your demands. I'll support your bill too. And I promise t..."** | `[108]` **Katarina Horten**: ""And the police's right to stop ..." | `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false` | `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_...`<br>`Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] = true...`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[114]` | **""No. That is too much to ask.""** | `[108]` **Katarina Horten**: ""And the police's right to stop ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "A muscle in her jaw twitched." |
| `[119]` | **""Please leave my office.""** | `[116]` **Katarina Horten**: ""You cannot think clearly, Mr. P..."<br>`[118]` **Katarina Horten**: ""Yet you are losing it all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "She stood up." |
| `[120]` | **""I'm not losing anything. But you'll lose something if you continue speaking to me..."** | `[116]` **Katarina Horten**: ""You cannot think clearly, Mr. P..."<br>`[118]` **Katarina Horten**: ""Yet you are losing it all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "She stood up." |
| `[121]` | **""I care about the people, Mrs. Horten. But politics is more complicated than that.""** | `[116]` **Katarina Horten**: ""You cannot think clearly, Mr. P..."<br>`[118]` **Katarina Horten**: ""Yet you are losing it all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Katarina Horten**: ""What's complicated about the ty..." |
| `[134]` | **""Guards! Show Mrs. Horten the way out.""** | `[136]` **Katarina Horten**: ""Enough with this Sollism!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Katarina Horten**: ""What!?"" |
| `[137]` | **""Please calm down.""** | `[136]` **Katarina Horten**: ""Enough with this Sollism!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "She looked at me one last time a..." |
| `[138]` | **""Guards! Detain her immediately.""** | `[136]` **Katarina Horten**: ""Enough with this Sollism!"" | `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true` | *Brak zmian stanu* | `[157]` **Katarina Horten**: ""What!?"" |
| `[142]` | **""The meeting is over, Mrs. Horten. Please don't embarrass yourself further.""** | `[136]` **Katarina Horten**: ""Enough with this Sollism!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "She looked at me one last time a..." |
| `[213]` | **""I did. And I still do. We are on the same side, Ms. Horten.""** | `[212]` **Katarina Horten**: ""Did you mean any of what you sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Katarina Horten**: ""You dare to say that after what..."<br>`[224]` **Katarina Horten**: ""Not anymore, Mr. President."" |
| `[214]` | **""Times and positions change, Ms. Horten. If you want to enter politics, that's the..."** | `[212]` **Katarina Horten**: ""Did you mean any of what you sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Katarina Horten**: ""That's a cop-out, Mr. President..." |
| `[215]` | **""Your people had me in a corner, Ms. Horten. I had to lie if I wanted to get out o..."** | `[212]` **Katarina Horten**: ""Did you mean any of what you sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Katarina Horten**: ""Well, today I want the truth."" |
| `[216]` | **""Did *you* learn anything, Ms. Horten? Speak against the President of Sordland, an..."** | `[211]` **Katarina Horten**: ""Did you learn nothing from our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Narrator**: "She flinched in shock, then quic..." |
| `[217]` | **""My aim has never been to silence the people of Sordland. I'm here talking to you,..."** | `[211]` **Katarina Horten**: ""Did you learn nothing from our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Katarina Horten**: ""That's the very least you can d..."<br>`[228]` **Katarina Horten**: ""That's the very least you can d..." |
| `[218]` | **""What I learned in Narbel is that the President of Sordland will face criticism ev..."** | `[211]` **Katarina Horten**: ""Did you learn nothing from our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Katarina Horten**: ""You weren't trying very hard wh..."<br>`[219]` **Katarina Horten**: ""You're not trying very hard, Mr..." |

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
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Katarina Horten: ""The police state Soll created lives on more powerful tha..."*)

### Węzeł `[3]`
Mówca: **Katarina Horten**
> ""So, Mr. President... You are not willing to resign, but willing to talk to the protesters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "She was a rising figure in Sordish politics, especially d..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "She was a rising figure in Sordish politics, especially due to her involvement in organizing the largest women's marches."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)

### Węzeł `[5]`
Mówca: **Katarina Horten**
> ""Let me remind you, this is not a regular protest. This is a movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Katarina Horten: ""People are finally calling out for the change they've be..."*)

### Węzeł `[6]`
Mówca: **Katarina Horten**
> ""People are finally calling out for the change they've been denied for so long. Your administration and your party left them no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""I've done everything for my people.""*)
  - -> `[11]` (*Player: ""I respect that, Mrs. Horten. That's why we're here to ha..."*)
  - -> `[8]` (*Player: ""People? How about you? What do you earn from inciting un..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Just make your point. You are falling into diatribe.""]** — Mówca: **Player**
> ""Just make your point. You are falling into diatribe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Katarina Horten: ""You already know about the issues that made people take ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""People? How about you? What do you earn from inciting unrest?""]** — Mówca: **Player**
> ""People? How about you? What do you earn from inciting unrest?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Katarina Horten: ""You are getting this all wrong, Mr. President. I do not ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "It seemed like she was navigating the protests very cleverly and knew how to make people come together. She had somehow become the spokesperson for these massive "Soll Square Protests" against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""I've done everything for my people.""]** — Mówca: **Player**
> ""I've done everything for my people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Katarina Horten: ""Maybe your values are different from what they want.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I respect that, Mrs. Horten. That's why we're here to have a discussion.""]** — Mówca: **Player**
> ""I respect that, Mrs. Horten. That's why we're here to have a discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Katarina Horten: ""Yes.""*)

### Węzeł `[12]`
Mówca: **Katarina Horten**
> ""Did you even look at these people, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Katarina Horten: ""You brought people from all walks of life together. Peop..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: ""What you are doing is illegal. We are in an emergency.""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WYBÓR GRACZA: ""What you are doing is illegal. We are in an emergency.""]** — Mówca: **Player**
> ""What you are doing is illegal. We are in an emergency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Katarina Horten: ""This is precisely why we had to speak out, Mr. President.""*)

### Węzeł `[17]`
Mówca: **Katarina Horten**
> ""This is precisely why we had to speak out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Katarina Horten: ""You cannot take away the right to protest. This is an in..."*)

### Węzeł `[18]`
Mówca: **Katarina Horten**
> ""You cannot take away the right to protest. This is an infringement on our basic rights as citizens of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "She pointed out the window."*)

### Węzeł `[19]`
Mówca: **Katarina Horten**
> ""You are getting this all wrong, Mr. President. I do not *earn* anything from this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Katarina Horten: ""Nor am I inciting any unrest.""*)

### Węzeł `[20]`
Mówca: **Katarina Horten**
> ""Nor am I inciting any unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "She pointed out the window."*)

### Węzeł `[21]`
Mówca: **Katarina Horten**
> ""You think they cannot distinguish right from wrong? That they always need a leader figure to organize?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Katarina Horten: ""You are tremendously wrong. You must accept that people ..."*)

### Węzeł `[22]`
Mówca: **Katarina Horten**
> ""You are tremendously wrong. You must accept that people do not support you anymore, Mr. President. You've done wrong by them. By all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "She frowned."*)

### Węzeł `[23]`
Mówca: **Katarina Horten**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Katarina Horten: ""And I appreciate that.""*)

### Węzeł `[24]`
Mówca: **Katarina Horten**
> ""And I appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Katarina Horten: ""You already know about the issues that made people take ..."*)

### Węzeł `[25]`
Mówca: **Katarina Horten**
> ""Maybe your values are different from what they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "She pointed out the window."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "She pointed out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Katarina Horten: ""Did you even look at these people, Mr. President?""*)

### Węzeł `[27]`
Mówca: **Katarina Horten**
> ""You brought people from all walks of life together. People you'd never think would come together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Katarina Horten: ""But they did. This is a huge achievement. I can at least..."*)

### Węzeł `[28]`
Mówca: **Katarina Horten**
> ""But they did. This is a huge achievement. I can at least give you credit for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""Just make your point. You are falling into diatribe.""*)
  - -> `[29]` (*Player: ""I've seen them, Mrs. Horten. And I want to help.""*)
  - -> `[30]` (*Player: ""Nonsense. They are coming together because of people lik..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""I've seen them, Mrs. Horten. And I want to help.""]** — Mówca: **Player**
> ""I've seen them, Mrs. Horten. And I want to help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Katarina Horten: ""You already know about the issues that made people take ..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Nonsense. They are coming together because of people like you.""]** — Mówca: **Player**
> ""Nonsense. They are coming together because of people like you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Katarina Horten: ""You think they cannot distinguish right from wrong? That..."*)

### Węzeł `[31]`
Mówca: **Katarina Horten**
> ""You already know about the issues that made people take to the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Katarina Horten: ""We don't believe you can fix them anymore. That's why th..."*)

### Węzeł `[32]`
Mówca: **Katarina Horten**
> ""We don't believe you can fix them anymore. That's why they're asking for your resignation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She looked at me with a single arched eyebrow."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She looked at me with a single arched eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Katarina Horten: ""But I don't think that's going to happen. Nor it is help..."*)

### Węzeł `[34]`
Mówca: **Katarina Horten**
> ""But I don't think that's going to happen. Nor it is helpful at this moment. Elections are getting close anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Katarina Horten: ""Instead, I want you to make amends.""*)

### Węzeł `[35]`
Mówca: **Narrator**
> "She frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Katarina Horten: ""You already know about the issues that made people take ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""]** — Mówca: **Player**
> ""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Katarina Horten: ""This has become a systemic problem.""*)

### Węzeł `[37]`
Mówca: **Katarina Horten**
> ""Instead, I want you to make amends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)

### Węzeł `[38]`
Mówca: **Katarina Horten**
> ""When peaceful protesters went out to Soll Square to voice their opinion a few weeks ago, your police nearly beat them to death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Katarina Horten: ""This isn't about your policies anymore. This is about de..."*)

### Węzeł `[39]`
Mówca: **Katarina Horten**
> ""This isn't about your policies anymore. This is about democracy and the fundamental right to be free. To be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Katarina Horten: ""The police state Soll created still lives on. Every pres..."*)

### Węzeł `[40]`
Mówca: **Katarina Horten**
> ""The police state Soll created still lives on. Every president who takes the seat feels obliged to use that force. It needs to stop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""You can't blame the actions of a couple of policeman on ..."*)
  - -> `[42]` (*Player: ""These policemen acted on their own accord. We never gave..."*)
  - -> `[47]` (*Player: ""I'm ready to do something about this.""*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)

### Węzeł `[41]`
Mówca: **Katarina Horten**
> ""The problem isn't their funding. It goes deeper than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Katarina Horten: ""The problem is a systemic one. The police feels that the..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""These policemen acted on their own accord. We never gave them such orders.""]** — Mówca: **Player**
> ""These policemen acted on their own accord. We never gave them such orders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Katarina Horten: ""This has become a systemic problem.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I've already defunded the police. What more can I do?""]** — Mówca: **Player**
> ""I've already defunded the police. What more can I do?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true`
- **Kontekst wejściowy (poprzednik):** `[40]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Katarina Horten: ""The problem isn't their funding. It goes deeper than that.""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""I've already defunded the police. What more can I do?""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn04_SnO_LE_Interior_Decreased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I'm ready to do something about this.""]** — Mówca: **Player**
> ""I'm ready to do something about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Katarina Horten: ""I'm glad to hear it.""*)

### Węzeł `[48]`
Mówca: **Katarina Horten**
> ""This has become a systemic problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Katarina Horten: ""You might not have given such orders, but the police fee..."*)

### Węzeł `[49]`
Mówca: **Katarina Horten**
> ""You might not have given such orders, but the police feels that they have the right to partake in such actions. And they do not suffer any consequences for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[50]`
Mówca: **Katarina Horten**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Katarina Horten: ""The problem is a systemic one. The police feels that the..."*)

### Węzeł `[51]`
Mówca: **Katarina Horten**
> ""The problem is a systemic one. The police feels that they have the right to partake in such actions. And they do not suffer any consequences for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[52]`
Mówca: **Katarina Horten**
> ""We want those responsible to be tried. We want justice to be served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Katarina Horten: ""Firstly, we want the dismissal of Karl Greiser, the Chie..."*)

### Węzeł `[53]`
Mówca: **Katarina Horten**
> ""Firstly, we want the dismissal of Karl Greiser, the Chief of Police, for his use of excessive force...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)

### Węzeł `[57]`
Mówca: **Katarina Horten**
> ""When peaceful protesters went out to Soll Square to voice their opinion a few weeks ago, your police beat people to their deaths!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Katarina Horten: ""This isn't about any of your other policies anymore. You..."*)

### Węzeł `[58]`
Mówca: **Katarina Horten**
> ""This isn't about any of your other policies anymore. You finally formed your police state. This is about democracy and the fundamental right to be free. To be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Katarina Horten: ""The police state Soll created lives on more powerful tha..."*)

### Węzeł `[59]`
Mówca: **Katarina Horten**
> ""The police state Soll created lives on more powerful than ever. Every president who takes the seat feels obliged to use that force. It needs to stop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""You can't blame the actions of a couple of policeman on ..."*)
  - -> `[61]` (*Player: ""These policemen acted on their own accord. We never gave..."*)
  - -> `[60]` (*Player: ""I'm ready to do something about this.""*)
  - -> `[63]` (*Player: ""Sordland had serious security problems. These laws were ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""I'm ready to do something about this.""]** — Mówca: **Player**
> ""I'm ready to do something about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Katarina Horten: ""I'm glad to hear it.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""These policemen acted on their own accord. We never gave them such orders.""]** — Mówca: **Player**
> ""These policemen acted on their own accord. We never gave them such orders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Katarina Horten: ""You gave them more authority than ever. How are you deny..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""]** — Mówca: **Player**
> ""You can't blame the actions of a couple of policeman on the whole state. Nor on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Katarina Horten: ""You gave them more authority than ever. How are you deny..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Sordland had serious security problems. These laws were necessary.""]** — Mówca: **Player**
> ""Sordland had serious security problems. These laws were necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Katarina Horten: ""So, you are fine with killing your own citizens?""*)

### Węzeł `[64]`
Mówca: **Katarina Horten**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Katarina Horten: ""We must start by undoing your security laws.""*)

### Węzeł `[65]`
Mówca: **Katarina Horten**
> ""You gave them more authority than ever. How are you denying your part in this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Katarina Horten: ""Your security laws must be undone.""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Katarina Horten: ""...And we demand that your harsher security laws be undo..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Katarina Horten: ""...And we demand that Tarquin Soll's security package la..."*)

### Węzeł `[69]`
Mówca: **Katarina Horten**
> ""So, you are fine with killing your own citizens?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Katarina Horten: ""Your security laws must be undone.""*)

### Węzeł `[70]`
Mówca: **Katarina Horten**
> ""Your security laws must be undone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "She clenched her fists."*)

### Węzeł `[71]`
Mówca: **Katarina Horten**
> ""We must start by undoing your security laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Katarina Horten: ""The problem is a systemic one. The police feels that the..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "She clenched her fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Katarina Horten: ""This has become a systemic problem.""*)

### Węzeł `[73]`
Mówca: **Katarina Horten**
> ""...And we demand that your harsher security laws be undone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Katarina Horten: ""We worked together with the independent MPs on a new Fre..."*)

### Węzeł `[74]`
Mówca: **Katarina Horten**
> ""...And we demand that Tarquin Soll's security package laws be undone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Katarina Horten: ""We worked together with the independent MPs on a new Fre..."*)

### Węzeł `[75]`
Mówca: **Katarina Horten**
> ""We worked together with the independent MPs on a new Freedom Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Katarina Horten: ""It must be implemented.""*)

### Węzeł `[76]`
Mówca: **Katarina Horten**
> ""It must be implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I can help you with these. What is in this Freedom Act?""*)
  - -> `[78]` (*Player: ""I can't dismiss Mr. Greiser just like that. He was doing..."*)
  - -> `[79]` (*Player: ""Out of the question.""*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I can help you with these. What is in this Freedom Act?""]** — Mówca: **Player**
> ""I can help you with these. What is in this Freedom Act?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Katarina Horten), `[83]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "She straightened her back."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I can't dismiss Mr. Greiser just like that. He was doing his job.""]** — Mówca: **Player**
> ""I can't dismiss Mr. Greiser just like that. He was doing his job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Katarina Horten: ""You seem not to understand the situation, Mr. President.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Out of the question.""]** — Mówca: **Player**
> ""Out of the question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A muscle in her jaw twitched."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "A muscle in her jaw twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Katarina Horten: ""You will continue the traditions of not giving a damn ab..."*)

### Węzeł `[81]`
Mówca: **Katarina Horten**
> ""You will continue the traditions of not giving a damn about the people!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I think they are being manipulated by people like you, M..."*)
  - -> `[92]` (*Player: ""Be careful with your tone, Mrs. Horten. You are speaking..."*)
  - -> `[93]` (*Player: ""The meeting is over.""*)

### Węzeł `[82]`
Mówca: **Katarina Horten**
> ""You seem not to understand the situation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Katarina Horten: ""We know what your powers are. And these are the people's..."*)

### Węzeł `[83]`
Mówca: **Katarina Horten**
> ""We know what your powers are. And these are the people's demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I can help you with these. What is in this Freedom Act?""*)
  - -> `[84]` (*Player: ""This country still has a functioning government. I can't..."*)
  - -> `[85]` (*Player: ""I'm sorry, Mrs. Horten. But I can't do it. You need to c..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""This country still has a functioning government. I can't listen to the demands of every mob.""]** — Mówca: **Player**
> ""This country still has a functioning government. I can't listen to the demands of every mob.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Katarina Horten: ""Mob?""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I'm sorry, Mrs. Horten. But I can't do it. You need to compromise.""]** — Mówca: **Player**
> ""I'm sorry, Mrs. Horten. But I can't do it. You need to compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Katarina Horten: ""I thought you invited me here to make compromises.""*)

### Węzeł `[86]`
Mówca: **Katarina Horten**
> ""Mob?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A muscle in her jaw twitched."*)

### Węzeł `[87]`
Mówca: **Katarina Horten**
> ""I thought you invited me here to make compromises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Katarina Horten: ""The people have made many compromises, Mr. President. Th..."*)

### Węzeł `[88]`
Mówca: **Katarina Horten**
> ""The people have made many compromises, Mr. President. They stayed silent for decades. Now, it is your turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""You might be right... What's in this Freedom Act?""*)
  - -> `[90]` (*Player: ""I think they are being manipulated by people like you, M..."*)
  - -> `[91]` (*Player: ""I'm the president, Mrs. Horten. And I made my decision.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""You might be right... What's in this Freedom Act?""]** — Mówca: **Player**
> ""You might be right... What's in this Freedom Act?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "She straightened her back."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I think they are being manipulated by people like you, Mrs. Horten. I doubt that these are their genuine demands.""]** — Mówca: **Player**
> ""I think they are being manipulated by people like you, Mrs. Horten. I doubt that these are their genuine demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Katarina Horten), `[88]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Katarina Horten: ""How dare you even suggest that?""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""I'm the president, Mrs. Horten. And I made my decision.""]** — Mówca: **Player**
> ""I'm the president, Mrs. Horten. And I made my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A muscle in her jaw twitched."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Be careful with your tone, Mrs. Horten. You are speaking to the president.""]** — Mówca: **Player**
> ""Be careful with your tone, Mrs. Horten. You are speaking to the president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Katarina Horten: ""It seems power have consumed you.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""The meeting is over.""]** — Mówca: **Player**
> ""The meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Katarina Horten: ""It seems power have consumed you.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "She straightened her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Katarina Horten: ""Firstly, no person will be detained without proper trial.""*)

### Węzeł `[95]`
Mówca: **Katarina Horten**
> ""Firstly, no person will be detained without proper trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Katarina Horten: ""Investigating private property will require warrants iss..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Katarina Horten: ""You must end the state of emergency now.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Katarina Horten: ""We want those responsible to be tried. We want justice t..."*)

### Węzeł `[99]`
Mówca: **Katarina Horten**
> ""You must end the state of emergency now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Katarina Horten: ""We demand that you return from this mistake and respect ..."*)

### Węzeł `[100]`
Mówca: **Katarina Horten**
> ""We demand that you return from this mistake and respect our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Katarina Horten: ""We also demand the dismissal of Karl Greiser, the Chief ..."*)

### Węzeł `[101]`
Mówca: **Katarina Horten**
> ""We also demand the dismissal of Karl Greiser, the Chief of Police, for his use of excessive force...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""The state of emergency remains.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WYBÓR GRACZA: ""The state of emergency remains.""]** — Mówca: **Player**
> ""The state of emergency remains.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Kontekst wejściowy (poprzednik):** `[76]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A muscle in her jaw twitched."*)

### Węzeł `[106]`
Mówca: **Katarina Horten**
> ""Investigating private property will require warrants issued by judges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Katarina Horten: ""The loopholes that give the police the right to use exce..."*)

### Węzeł `[107]`
Mówca: **Katarina Horten**
> ""The loopholes that give the police the right to use excessive force will be removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Katarina Horten: ""And the police's right to stop and frisk anyone will be ..."*)

### Węzeł `[108]`
Mówca: **Katarina Horten**
> ""And the police's right to stop and frisk anyone will be taken away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[114]` (*Player: ""No. That is too much to ask.""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Okay, I agree to all of your demands. I'll sign it.""]** — Mówca: **Player**
> ""Okay, I agree to all of your demands. I'll sign it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[108]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""Okay, I agree to all of your demands. I'll sign it.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""Okay, I agree to all of your demands. I'll support your ..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Okay, I agree to all of your demands. I'll support your bill too. And I promise to sign it if it passes the Assembly.""]** — Mówca: **Player**
> ""Okay, I agree to all of your demands. I'll support your bill too. And I promise to sign it if it passes the Assembly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[108]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""No. That is too much to ask.""]** — Mówca: **Player**
> ""No. That is too much to ask.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "A muscle in her jaw twitched."*)

### Węzeł `[115]`
Mówca: **Katarina Horten**
> ""How dare you even suggest that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Katarina Horten: ""You cannot think clearly, Mr. President. You are losing ..."*)

### Węzeł `[116]`
Mówca: **Katarina Horten**
> ""You cannot think clearly, Mr. President. You are losing it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""I care about the people, Mrs. Horten. But politics is mo..."*)
  - -> `[120]` (*Player: ""I'm not losing anything. But you'll lose something if yo..."*)
  - -> `[119]` (*Player: ""Please leave my office.""*)

### Węzeł `[117]`
Mówca: **Katarina Horten**
> ""It seems power have consumed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Katarina Horten: ""Yet you are losing it all.""*)

### Węzeł `[118]`
Mówca: **Katarina Horten**
> ""Yet you are losing it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""I care about the people, Mrs. Horten. But politics is mo..."*)
  - -> `[120]` (*Player: ""I'm not losing anything. But you'll lose something if yo..."*)
  - -> `[119]` (*Player: ""Please leave my office.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Please leave my office.""]** — Mówca: **Player**
> ""Please leave my office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Katarina Horten), `[118]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She stood up."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I'm not losing anything. But you'll lose something if you continue speaking to me like that.""]** — Mówca: **Player**
> ""I'm not losing anything. But you'll lose something if you continue speaking to me like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Katarina Horten), `[118]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She stood up."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I care about the people, Mrs. Horten. But politics is more complicated than that.""]** — Mówca: **Player**
> ""I care about the people, Mrs. Horten. But politics is more complicated than that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Katarina Horten), `[118]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Katarina Horten: ""What's complicated about the tyranny of the state?""*)

### Węzeł `[122]`
Mówca: **Katarina Horten**
> ""What's complicated about the tyranny of the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She stood up."*)

### Węzeł `[123]`
Mówca: **Katarina Horten**
> ""You are a fake. And you claim to be a socialist. You tried portraying yourself as a supporter of the working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She clenched her fists."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "She stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Katarina Horten: ""You are a fake. And you claim to be a socialist. You tri..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || B..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || B..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true ||..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Katarina Horten: ""You are a fake. And you tried portraying yourself as a s..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true || BaseGame.Bill_Turn09_StrongWomensRights_Signed == true || BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  or  Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Katarina Horten: ""You are a fake. You are no democrat. You tried portrayin..."*)

### Węzeł `[131]`
Mówca: **Katarina Horten**
> ""You are a fake. And you tried portraying yourself as a supporter of women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She clenched her fists."*)

### Węzeł `[132]`
Mówca: **Katarina Horten**
> ""But you support nobody. Only you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Katarina Horten: ""Enough with this Sollism!""*)

### Węzeł `[133]`
Mówca: **Katarina Horten**
> ""You are a fake. You are no democrat. You tried portraying yourself as the champion of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She clenched her fists."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Guards! Show Mrs. Horten the way out.""]** — Mówca: **Player**
> ""Guards! Show Mrs. Horten the way out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Katarina Horten: ""What!?""*)

### Węzeł `[135]`
Mówca: **Narrator**
> "She clenched her fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Katarina Horten: ""But you support nobody. Only you.""*)

### Węzeł `[136]`
Mówca: **Katarina Horten**
> ""Enough with this Sollism!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[137]` (*Player: ""Please calm down.""*)
  - -> `[142]` (*Player: ""The meeting is over, Mrs. Horten. Please don't embarrass..."*)
  - -> `[134]` (*Player: ""Guards! Show Mrs. Horten the way out.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Please calm down.""]** — Mówca: **Player**
> ""Please calm down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "She looked at me one last time and quickly walked towards..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Guards! Detain her immediately.""]** — Mówca: **Player**
> ""Guards! Detain her immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Kontekst wejściowy (poprzednik):** `[136]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Katarina Horten: ""What!?""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""Guards! Detain her immediately.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""The meeting is over, Mrs. Horten. Please don't embarrass yourself further.""]** — Mówca: **Player**
> ""The meeting is over, Mrs. Horten. Please don't embarrass yourself further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "She looked at me one last time and quickly walked towards..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "She looked at me one last time and quickly walked towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Failed = true; BaseGame.Pub..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Promised = true; BaseGame.Fired_KarlGreiser = true;
BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser_Dismissed = true;
BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser = false;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Promised"] = true;
Variable["BaseGame.Fired_KarlGreiser"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser"] = false;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_LighterSecurity_Signed = true; BaseGame.Fired_KarlGreiser = true; BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser_Dismissed = true;
BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser = false;
BaseGame.Public_Opinion += 4; BaseGame.Democratic += 2; BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] = true;
Variable["BaseGame.Fired_KarlGreiser"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_KarlGreiser"] = false;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped = true; BaseGameSupport.Jou..."*)

### Węzeł `[146]`
Mówca: **Katarina Horten**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "The guards immediately came inside and took her by the arms."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "The guards immediately came inside and took her by the arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Failed = true; BaseGame.Pub..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Failed = true;
BaseGame.Public_Opinion -= 2;
BaseGame.Democratic -= 2;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Failed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Failed = true;
BaseGame.Public_Opinion -= 2;
BaseGame.Democratic -= 2;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Failed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[150]`
Mówca: **Katarina Horten**
> ""You are doing the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "We went through the documents and discussed how we would ..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "We went through the documents and discussed how we would proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Karl Greiser", "Former Chief of Pol..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "After we settled on our next actions, I signed the necessary papers and gave them to her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "As soon as we were done, she immediately stood up and bow..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "As soon as we were done, she immediately stood up and bowed her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Katarina Horten: ""Thank you.""*)

### Węzeł `[154]`
Mówca: **Katarina Horten**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Deal_Failed = true; BaseGame.Turn09_Detained_Katarina = true;
BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten_Detained = true;
BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten = false;
BaseGame.Public_Opinion -= 4;
BaseGame.Democratic -= 4;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Deal_Failed"] = true;
Variable["BaseGame.Turn09_Detained_Katarina"] = true;
Variable["BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten_Detained"] = true;
Variable["BaseGameSupport.Codex_Characters_Assembly_KatarinaHorten"] = false;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 4;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Political_LabourUnion..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "The guards immediately came inside and took her by the arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Failed = true; BaseGame.Tur..."*)

### Węzeł `[157]`
Mówca: **Katarina Horten**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "The guards immediately came inside and took her by the arms."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped = true; BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Decree = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_UnrestStopped"] = true;
Variable["BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Promise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Promise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Refuse = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_Refuse"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_DetainKatarina = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic_DetainKatarina"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn08_HarsherSecurity_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn08_HarsherSecurity_Signed = false"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser = true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend = false;
BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = false;
BaseGame.Reform_EmergencyDecree_PoliceAuthority = false;
BaseGame.Reform_EmergencyDecree_SuspendedProtests = false;
BaseGame.Reform_Law_Decrees_Default = true;
BaseGame.Reform_Law_Decrees_Stronger = false;
BaseGame.Policy_Law_Decree_Stronger = false;
BaseGame.Policy_Law_Decree_Default = true; BaseGame.Policy_Order_Authority = false; BaseGame.Policy_Order_DetentionWithoutTrial = false; BaseGame.Policy_Order_SuspendedProtests = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] = false;
Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] = false;
Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] = false;
Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Default"] = true;
Variable["BaseGame.Policy_Order_Authority"] = false;
Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = false;
Variable["BaseGame.Policy_Order_SuspendedProtests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Fired_KarlGreiser"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Katarina Horten: ""You are doing the right thing.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_ST_Emergency_Revoked_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Emergency_Revoked_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_Emergency_Revoked = true; B..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Holsord_Emergency_Revoked = true; BaseGameSupport.Report_Turn09_Erzaren_Emergency_Revoked = true; BaseGameSupport.Report_Turn09_Jen_Emergency_Revoked = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_Emergency_Revoked"] = true;
Variable["BaseGameSupport.Report_Turn09_Erzaren_Emergency_Revoked"] = true;
Variable["BaseGameSupport.Report_Turn09_Jen_Emergency_Revoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend = false; ..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_ST_Emergency_Revoked_Media = ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_R_Emergency_Revoked = true; BaseGameSupport.News_Turn09_HP_Emergency_Revoked = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_R_Emergency_Revoked"] = true;
Variable["BaseGameSupport.News_Turn09_HP_Emergency_Revoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_Emergency_Revoked =..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_ST_Emergency_Revoked_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Emergency_Revoked_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_Emergency_Revoked = true; B..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_DecreeDuringEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_DecreeDuringEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_FreedomsAct_Decree = true;..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Decree = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_FreedomsAct_Decree = true;..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Support = true;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Support"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Deal_Promised = true; BaseGame.F..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_NoSupport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_NoSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Detained = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic_Detained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_FreedomsAct_Decree = true; BaseGameSupport.News_Turn09_R_FreedomsAct_Decree = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = true;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_FreedomsAct_Decree"] = true;
Variable["BaseGameSupport.News_Turn09_R_FreedomsAct_Decree"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusAllCities("City_WidespreadProtests");  /..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_ST_Emergency_Revoked_NoMedia ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_Emergency_Revoked = true; B..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Katarina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Katarina == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.CurrentSpeaker_Katarina == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Katarina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.CurrentSpeaker_Katarina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_Speaker", ..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.CurrentSpeaker_Katarina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.CurrentSpeaker_Katarina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland = false; BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland_KatarinaArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland"] = false;
Variable["BaseGameSupport.Codex_Organisations_Political_LabourUnionOfSordland_KatarinaArrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Katarina == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker = true; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_Peaceful_Diplomatic..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_Speaker", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_Speaker","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Katarina = false"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Katarina = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.CurrentSpeaker_Katarina"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_GrandNat..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Karl Greiser", "Former Chief of Police");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Karl Greiser","Former Chief of Police");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "After we settled on our next actions, I signed the necess..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusAllCities("City_WidespreadProtests");

// Removes given token status from ALL cities`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusAllCities("City_WidespreadProtests");
-- Removes given token status from ALL cities;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_LighterSecurity_Signed = true; BaseG..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_Extraction_AddressProtestors =..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Katarina Horten: ""So, Mr. President... It's been a while.""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Katarina Horten: ""So, Mr. President... You are not willing to resign, but ..."*)

### Węzeł `[205]`
Mówca: **Katarina Horten**
> ""So, Mr. President... It's been a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Since our last confrontation, Katarina had become a rising figure in Sordish politics, organizing large women's marches as well as the massive "Soll Square Protests" against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Calm == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Katarina Horten: ""When you spoke in front of the Gasom headquarters, you m..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Calm == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Katarina Horten: ""Did you learn nothing from our protests in Narbel? You c..."*)

### Węzeł `[210]`
Mówca: **Katarina Horten**
> ""When you spoke in front of the Gasom headquarters, you made it seem as if we were on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Katarina Horten: ""Did you mean any of what you said back then?""*)

### Węzeł `[211]`
Mówca: **Katarina Horten**
> ""Did you learn nothing from our protests in Narbel? You cannot silence the people of Sordland, President Rayne. No matter how hard you try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player: ""Did *you* learn anything, Ms. Horten? Speak against the ..."*)
  - -> `[217]` (*Player: ""My aim has never been to silence the people of Sordland...."*)
  - -> `[218]` (*Player: ""What I learned in Narbel is that the President of Sordla..."*)

### Węzeł `[212]`
Mówca: **Katarina Horten**
> ""Did you mean any of what you said back then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""I did. And I still do. We are on the same side, Ms. Hort..."*)
  - -> `[214]` (*Player: ""Times and positions change, Ms. Horten. If you want to e..."*)
  - -> `[215]` (*Player: ""Your people had me in a corner, Ms. Horten. I had to lie..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I did. And I still do. We are on the same side, Ms. Horten.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Times and positions change, Ms. Horten. If you want to enter politics, that's the first thing you should know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Katarina Horten: ""That's a cop-out, Mr. President. You have knowingly comp..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your people had me in a corner, Ms. Horten. I had to lie if I wanted to get out of there alive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Katarina Horten: ""Well, today I want the truth.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Did *you* learn anything, Ms. Horten? Speak against the President of Sordland, and you'll meet the wrong end of a nightstick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "She flinched in shock, then quickly recomposed herself."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My aim has never been to silence the people of Sordland. I'm here talking to you, aren't I?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What I learned in Narbel is that the President of Sordland will face criticism even if he is trying to do everything right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Katarina Horten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[219]`
Mówca: **Katarina Horten**
> ""You're not trying very hard, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[220]`
Mówca: **Katarina Horten**
> ""That's the very least you can do, Mr. President. Especially after having my colleague Mr. Stahler arrested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "She flinched in shock, then quickly recomposed herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[222]`
Mówca: **Katarina Horten**
> ""Well, today I want the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[223]`
Mówca: **Katarina Horten**
> ""That's a cop-out, Mr. President. You have knowingly compromised the ideals you expressed to me back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[224]`
Mówca: **Katarina Horten**
> ""Not anymore, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Katarina Horten: ""That's the very least you can do, Mr. President. Especia..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Katarina Horten: ""That's the very least you can do, Mr. President.""*)

### Węzeł `[228]`
Mówca: **Katarina Horten**
> ""That's the very least you can do, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Katarina Horten: ""You weren't trying very hard when you had my colleague M..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Katarina Horten: ""You're not trying very hard, Mr. President.""*)

### Węzeł `[232]`
Mówca: **Katarina Horten**
> ""You weren't trying very hard when you had my colleague Mr. Stahler arrested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Katarina Horten: ""You dare to say that after what you did to Mr. Stahler?""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Katarina Horten: ""Not anymore, Mr. President.""*)

### Węzeł `[236]`
Mówca: **Katarina Horten**
> ""You dare to say that after what you did to Mr. Stahler?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == f..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "It seemed like she was navigating the protests very cleve..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "It seemed like she was navigating the protests very cleve..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "It seemed like she was navigating the protests very cleverly and knew how to make people come together. She had somehow become the spokesperson for these massive "Maroon Square Protests" against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Katarina Horten: ""Let me remind you, this is not a regular protest. This i..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == f..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Katarina Horten: ""When peaceful protesters went out to Soll Square to voic..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Katarina Horten: ""When peaceful protesters went out to Maroon Square to vo..."*)

### Węzeł `[244]`
Mówca: **Katarina Horten**
> ""When peaceful protesters went out to Maroon Square to voice their opinion a few weeks ago, your police nearly beat them to death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Katarina Horten: ""This isn't about your policies anymore. This is about de..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == f..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Katarina Horten: ""When peaceful protesters went out to Soll Square to voic..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Katarina Horten: ""When peaceful protesters went out to Maroon Square to vo..."*)

### Węzeł `[248]`
Mówca: **Katarina Horten**
> ""When peaceful protesters went out to Maroon Square to voice their opinion a few weeks ago, your police beat people to their deaths!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Katarina Horten: ""This isn't about any of your other policies anymore. You..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_DeSollinisation == false"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_DeSollinisation == f..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_DeSollinisation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Since our last confrontation, Katarina had become a risin..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_DeSollinisation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_DeSollinisation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Since our last confrontation, Katarina had become a risin..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Since our last confrontation, Katarina had become a rising figure in Sordish politics, organizing large women's marches as well as the massive "Maroon Square Protests" against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)
