# Sordland/Turn07/NOTES

- **ID konwersacji:** `122`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/122_NOTES.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 34

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[35]** Gus Manger
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_A`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_A`

### Skoki między-konwersacyjne:
- Węzeł `[89]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[90]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[95]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[111]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[114]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[116]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[137]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Our priority will be the investigation of the Court. We'll start working on a def..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Lucian nodded in agreement. Ciar..." |
| `[19]` | **""We proved our capabilities already. Now we are ready to enact more reforms.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: ""Next, I will start campaigning ..."<br>`[32]` **Player**: ""Soon I'll be enacting major ref..."<br>*(oraz 1 innych odgałęzień)* |
| `[20]` | **""My next plan is to use my emergency powers to enact major reforms.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Nia narrowed her eyes skeptically." |
| `[30]` | **""We must also do something about the BFF.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A...` | `[126]` **Narrator**: "Iosef stood up." |
| `[31]` | **""Next, I will start campaigning for a transition to parliamentary democracy.""** | `[19]` **Player**: ""We proved our capabilities alre..." | `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[40]` **Narrator**: "Lileas spread out her arms and l..." |
| `[32]` | **""Soon I'll be enacting major reforms with my new powers.""** | `[19]` **Player**: ""We proved our capabilities alre..." | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`<br>`((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[38]` | **""We will start campaigning for bigger changes.""** | `[19]` **Player**: ""We proved our capabilities alre..." | `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`<br>`((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[42]` **Narrator**: "The cabinet looked at me with cu..." |
| `[55]` | **""I will campaign for the transition into a parliamentary system.""** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false` | *Brak zmian stanu* | `[40]` **Narrator**: "Lileas spread out her arms and l..." |
| `[59]` | **""I will campaign for strengthening the executive further.""** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false` | *Brak zmian stanu* | `[61]` **Narrator**: "Nia spread out her arms and look..." |
| `[60]` | **""Your lack of idealism is saddening. We can't develop if we don't even try.""** | `[48]` **Gus Manger**: ""Sordish reality is quite differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Deivid looked at Gus." |
| `[63]` | **""We will continue our privatization and fully integrate Sordland into the free mar..."** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `Variable["BaseGame.EconomicDirection_Privatization"] == true` | *Brak zmian stanu* | `[88]` **Lileas Graf**: ""I see. Further destruction of o..." |
| `[64]` | **""The presidential system is flawed. Look at our history.""** | `[48]` **Gus Manger**: ""Sordish reality is quite differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Deivid looked at Gus." |
| `[65]` | **""I will hear no discussions. This will be our focus.""** | `[48]` **Gus Manger**: ""Sordish reality is quite differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: ""The Constitution is not a toy. ..." |
| `[71]` | **""I will hear no discussions. This will be our focus.""** | `[70]` **Nia Morgna**: ""I cannot let this country be sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: ""The Constitution is not a toy. ..." |
| `[72]` | **""You can try to stop me. Don't forget that you are working for me.""** | `[70]` **Nia Morgna**: ""I cannot let this country be sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "Nobody responded. Nia was furious." |
| `[73]` | **""You are hurting me, Mrs. Morgna. Do you really see me as an authoritarian?""** | `[70]` **Nia Morgna**: ""I cannot let this country be sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Nia Morgna**: ""Yes, Mr. President. I will no l..."<br>`[106]` **Nia Morgna**: ""You are showing the tendency, M..." |
| `[80]` | **""We will continue our nationalization and fully take control of the means of produ..."** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `Variable["BaseGame.EconomicDirection_Nationalization"] == true`<br>`(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false` | *Brak zmian stanu* | `[93]` **Lileas Graf**: ""I see. Very Bold."" |
| `[81]` | **""More social policies.""** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: ""I see."" |
| `[85]` | **""We will pursue the nationalisation of the means of production.""** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`<br>`(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`<br>`(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false` | *Brak zmian stanu* | `[87]` **Lileas Graf**: ""I see."" |
| `[86]` | **""We will pursue further free market reforms.""** | `[54]` **Lileas Graf**: ""And what kind of changes are th..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`<br>`(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`<br>`(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false` | *Brak zmian stanu* | `[88]` **Lileas Graf**: ""I see. Further destruction of o..." |
| `[97]` | **""Thank you for your support, Mr. Wisci.""** | `[96]` **Deivid Wisci**: ""I fully support rewriting the w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "He smiled. Nobody else responded." |
| `[104]` | **""Fine. I will no longer stay idle about disloyalty either. We'll talk about this v..."** | `[100]` **Nia Morgna**: ""Yes, Mr. President. I will no l..."<br>`[106]` **Nia Morgna**: ""You are showing the tendency, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Nia Morgna**: ""Whatever you say, Mr. President."" |
| `[105]` | **""We'll talk about this later, Mrs. Morgna. Let's move on for now, shall we?""** | `[100]` **Nia Morgna**: ""Yes, Mr. President. I will no l..."<br>`[106]` **Nia Morgna**: ""You are showing the tendency, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "She did not respond." |
| `[107]` | **""Frankly, I don't care. I've told you our focus and that's it.""** | `[100]` **Nia Morgna**: ""Yes, Mr. President. I will no l..."<br>`[106]` **Nia Morgna**: ""You are showing the tendency, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "She did not respond." |
| `[110]` | **""Let's not argue about this now, Mrs. Graf.""** | `[88]` **Lileas Graf**: ""I see. Further destruction of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lileas Graf**: ""Whatever you say, *Mr. Presiden..." |
| `[113]` | **""Why can't you be more like Lucian, Mrs. Walda?""** | `[119]` **Lucian Galade**: ""I'm already working on it, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Ciara Walda**: ""With all due respect, I'm not g..." |
| `[117]` | **""Frankly, I don't care what you think. Our focus has been decided.""** | `[88]` **Lileas Graf**: ""I see. Further destruction of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lileas Graf**: ""Whatever you say, *Mr. Presiden..." |
| `[120]` | **""Thank you Lucian. Please make sure the whole team is on the same page with us.""** | `[119]` **Lucian Galade**: ""I'm already working on it, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "Lucian nodded. Nobody else respo..." |
| `[121]` | **""I will be using my powers to their limits.""** | `[41]` **Narrator**: "Nia narrowed her eyes skeptically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "Lucian nodded in agreement." |
| `[123]` | **""Frankly, I don't care what you think. We have bigger problems here.""** | `[122]` **Ciara Walda**: ""With all due respect, I'm not g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: ""The Constitution is not a toy. ..." |
| `[127]` | **""I want Mrs. Graf to put the region of Bergia under heavy surveillance.""** | `[125]` **Iosef Lancea**: ""Yes sir. It is of utmost import..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Lileas Graf**: ""As you wish."" |
| `[128]` | **""I want to establish peace talks with the group.""** | `[125]` **Iosef Lancea**: ""Yes sir. It is of utmost import..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Iosef Lancea**: ""Sir, I would advise against it...." |
| `[132]` | **""I want you to just try and reach out to them. We should be diplomatic.""** | `[136]` **Lileas Graf**: ""So we're going to sit on a tabl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Narrator**: "Lucian stepped up." |
| `[138]` | **""They are fighting us because the state has never listened to them before.""** | `[136]` **Lileas Graf**: ""So we're going to sit on a tabl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Lileas Graf**: ""I can't believe you are justify..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "ConstitutionChanged"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "ConstitutionFailed"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Our priority will be the investigation of the Court. We'll start working on a defence.""]** — Mówca: **Player**
> ""Our priority will be the investigation of the Court. We'll start working on a defence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Lucian nodded in agreement. Ciara gave me a mocking stare."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "EmergencyStopped"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "ImpeachmentPossibility"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "EmergencyContinues"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "ImpeachmentPossibility"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We proved our capabilities already. Now we are ready to enact more reforms.""]** — Mówca: **Player**
> ""We proved our capabilities already. Now we are ready to enact more reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""My next plan is to use my emergency powers to enact major reforms.""]** — Mówca: **Player**
> ""My next plan is to use my emergency powers to enact major reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Nia narrowed her eyes skeptically."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame...."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGam..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Next, I will start campaigning for a transition to parli..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Soon I'll be enacting major reforms with my new powers.""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""We will start campaigning for bigger changes.""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_C..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 0  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""We must also do something about the BFF.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 0  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We must also do something about the BFF.""]** — Mówca: **Player**
> ""We must also do something about the BFF.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_PlansHub_A = true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Next, I will start campaigning for a transition to parliamentary democracy.""]** — Mówca: **Player**
> ""Next, I will start campaigning for a transition to parliamentary democracy.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lileas spread out her arms and looked at me in disbelief."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""Soon I'll be enacting major reforms with my new powers.""]** — Mówca: **Player**
> ""Soon I'll be enacting major reforms with my new powers.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true` AND `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ConstitutionChanged`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ConstitutionFailed`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EmergencyContinues`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ImpeachmentPossibility`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EmergencyStopped`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA: ""We will start campaigning for bigger changes.""]** — Mówca: **Player**
> ""We will start campaigning for bigger changes.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false` AND `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The cabinet looked at me with curiosity."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Lucian nodded in agreement. Ciara gave me a mocking stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Ciara Walda: ""I believe the decision that led to these investigations ..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Lileas spread out her arms and looked at me in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: ""This is getting ridiculous, Mr. President.""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Nia narrowed her eyes skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""I will be using my powers to their limits.""*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The cabinet looked at me with curiosity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lileas Graf: ""And what kind of changes are these?""*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> ""This is getting ridiculous, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> ""The Constitution is not a toy. You can't just play with it and change it however you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: ""With all due respect, I believe you are not seeing thing..."*)

### Węzeł `[45]`
Mówca: **Lileas Graf**
> ""With all due respect, I believe you are not seeing things clearly anymore, Mr. President. I'm concerned about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "As Petr was about to respond, Gus cut in."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "As Petr was about to respond, Gus cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: ""In this rare occasion, I have to admit that I agree with..."*)

### Węzeł `[47]`
Mówca: **Gus Manger**
> ""In this rare occasion, I have to admit that I agree with Mrs. Graf here. It's important not to get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gus Manger: ""Sordish reality is quite different than what's being sai..."*)

### Węzeł `[48]`
Mówca: **Gus Manger**
> ""Sordish reality is quite different than what's being said here. Let's not kid ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""Your lack of idealism is saddening. We can't develop if ..."*)
  - -> `[65]` (*Player: ""I will hear no discussions. This will be our focus.""*)
  - -> `[64]` (*Player: ""The presidential system is flawed. Look at our history.""*)

### Węzeł `[49]`
Mówca: **Ciara Walda**
> ""I believe the decision that led to these investigations was taken without the counsel of Council of Ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Ciara Walda: ""And there is only one signature on that emergency decree..."*)

### Węzeł `[50]`
Mówca: **Ciara Walda**
> ""And there is only one signature on that emergency decree, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Petr stood up."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Petr stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: ""What are you trying to say, Mrs. Walda? Don't overstep y..."*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""What are you trying to say, Mrs. Walda? Don't overstep your boundaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Ciara Walda: ""I just don't see how we could be of any help under such ..."*)

### Węzeł `[53]`
Mówca: **Ciara Walda**
> ""I just don't see how we could be of any help under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Lucian stepped up."*)

### Węzeł `[54]`
Mówca: **Lileas Graf**
> ""And what kind of changes are these?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)
  - -> `[81]` (*Player: ""More social policies.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I will campaign for the transition into a parliamentary system.""]** — Mówca: **Player**
> ""I will campaign for the transition into a parliamentary system.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lileas spread out her arms and looked at me in disbelief."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true && BaseGame.Refo..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I will campaign for the transition into a parliamentary ..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""I will campaign for strengthening the executive further.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I will campaign for strengthening the executive further.""]** — Mówca: **Player**
> ""I will campaign for strengthening the executive further.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Nia spread out her arms and looked at me in disbelief. Ju..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Your lack of idealism is saddening. We can't develop if we don't even try.""]** — Mówca: **Player**
> ""Your lack of idealism is saddening. We can't develop if we don't even try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Deivid looked at Gus."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Nia spread out her arms and looked at me in disbelief. Just as she was about to speak, Lileas jumped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: ""This is getting ridiculous, Mr. President.""*)

### Węzeł `[62]`
Mówca: **Lileas Graf**
> ""With all due respect, I believe you are not seeing things clearly anymore, Mr. President. I'm concerned about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "As Petr was about to respond, Nia cut in."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We will continue our privatization and fully integrate Sordland into the free market.""]** — Mówca: **Player**
> ""We will continue our privatization and fully integrate Sordland into the free market.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: ""I see. Further destruction of our economy.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""The presidential system is flawed. Look at our history.""]** — Mówca: **Player**
> ""The presidential system is flawed. Look at our history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Deivid looked at Gus."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I will hear no discussions. This will be our focus.""]** — Mówca: **Player**
> ""I will hear no discussions. This will be our focus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> ""This is getting ridiculous, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""The Constitution is not a toy. You can't just play with it and change it however you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lileas Graf: ""With all due respect, I believe you are not seeing thing..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "As Petr was about to respond, Nia cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Nia Morgna: ""In this rare occasion, I have to admit that I agree with..."*)

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""In this rare occasion, I have to admit that I agree with Mrs. Graf here. It's important not to get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Nia Morgna: ""I cannot let this country be shaped according to one man..."*)

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""I cannot let this country be shaped according to one man's ideals again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""You are hurting me, Mrs. Morgna. Do you really see me as..."*)
  - -> `[71]` (*Player: ""I will hear no discussions. This will be our focus.""*)
  - -> `[72]` (*Player: ""You can try to stop me. Don't forget that you are workin..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I will hear no discussions. This will be our focus.""]** — Mówca: **Player**
> ""I will hear no discussions. This will be our focus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You can try to stop me. Don't forget that you are working for me.""]** — Mówca: **Player**
> ""You can try to stop me. Don't forget that you are working for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Nobody responded. Nia was furious."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You are hurting me, Mrs. Morgna. Do you really see me as an authoritarian?""]** — Mówca: **Player**
> ""You are hurting me, Mrs. Morgna. Do you really see me as an authoritarian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame...."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Privatization == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""We will continue our privatization and fully integrate S..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""We will continue our nationalization and fully take cont..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""We will continue our nationalization and fully take control of the means of production.""]** — Mówca: **Player**
> ""We will continue our nationalization and fully take control of the means of production.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true` AND `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lileas Graf: ""I see. Very Bold.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""More social policies.""]** — Mówca: **Player**
> ""More social policies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: ""I see.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""We will pursue the nationalisation of the means of produ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""We will pursue further free market reforms.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We will pursue the nationalisation of the means of production.""]** — Mówca: **Player**
> ""We will pursue the nationalization of the means of production.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` AND `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false` AND `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: ""I see.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We will pursue further free market reforms.""]** — Mówca: **Player**
> ""We will pursue further free market reforms.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` AND `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false` AND `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: ""I see. Further destruction of our economy.""*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""I see. Further destruction of our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)
  - -> `[110]` (*Player: ""Let's not argue about this now, Mrs. Graf.""*)
  - -> `[117]` (*Player: ""Frankly, I don't care what you think. Our focus has been..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Deivid looked at Gus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Deivid Wisci: ""Mr. President is right.""*)

### Węzeł `[92]`
Mówca: **Deivid Wisci**
> ""Mr. President is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Deivid Wisci: ""I fully support rewriting the whole Constitution and est..."*)

### Węzeł `[93]`
Mówca: **Lileas Graf**
> ""I see. Very Bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lileas Graf: ""Maybe too bold.""*)

### Węzeł `[94]`
Mówca: **Lileas Graf**
> ""Maybe too bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[96]`
Mówca: **Deivid Wisci**
> ""I fully support rewriting the whole Constitution and establish a more democratic parliamentary system in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""Thank you for your support, Mr. Wisci.""*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Thank you for your support, Mr. Wisci.""]** — Mówca: **Player**
> ""Thank you for your support, Mr. Wisci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "He smiled. Nobody else responded."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Nobody responded. Nia was furious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "He smiled. Nobody else responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""Yes, Mr. President. I will no longer be silent about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""Fine. I will no longer stay idle about disloyalty either..."*)
  - -> `[105]` (*Player: ""We'll talk about this later, Mrs. Morgna. Let's move on ..."*)
  - -> `[107]` (*Player: ""Frankly, I don't care. I've told you our focus and that'..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame...."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true || BaseGam..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""Yes, Mr. President. I will no longer be silent about it.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""You are showing the tendency, Mr. President.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Fine. I will no longer stay idle about disloyalty either. We'll talk about this very soon.""]** — Mówca: **Player**
> ""Fine. I will no longer stay idle about disloyalty either. We'll talk about this very soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Nia Morgna), `[106]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Nia Morgna: ""Whatever you say, Mr. President.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Morgna. Let's move on for now, shall we?""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Morgna. Let's move on for now, shall we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Nia Morgna), `[106]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "She did not respond."*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""You are showing the tendency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""Fine. I will no longer stay idle about disloyalty either..."*)
  - -> `[105]` (*Player: ""We'll talk about this later, Mrs. Morgna. Let's move on ..."*)
  - -> `[107]` (*Player: ""Frankly, I don't care. I've told you our focus and that'..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Frankly, I don't care. I've told you our focus and that's it.""]** — Mówca: **Player**
> ""Frankly, I don't care. I've told you our focus and that's it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Nia Morgna), `[106]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "She did not respond."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "She did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[109]`
Mówca: **Nia Morgna**
> ""Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's not argue about this now, Mrs. Graf.""]** — Mówca: **Player**
> ""Let's not argue about this now, Mrs. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: ""Whatever you say, *Mr. President*.""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[112]`
Mówca: **Lileas Graf**
> ""Whatever you say, *Mr. President*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Why can't you be more like Lucian, Mrs. Walda?""]** — Mówca: **Player**
> ""Why can't you be more like Lucian, Mrs. Walda?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Ciara Walda: ""With all due respect, I'm not going to respond to that.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Lucian nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. Our focus has been decided.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. Our focus has been decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: ""Whatever you say, *Mr. President*.""*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Lucian stepped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""I'm already working on it, Mr. President.""*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""I'm already working on it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""Thank you Lucian. Please make sure the whole team is on ..."*)
  - -> `[113]` (*Player: ""Why can't you be more like Lucian, Mrs. Walda?""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thank you Lucian. Please make sure the whole team is on the same page with us.""]** — Mówca: **Player**
> ""Thank you Lucian. Please make sure the whole team is on the same page with us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Lucian nodded. Nobody else responded."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I will be using my powers to their limits.""]** — Mówca: **Player**
> ""I will be using my powers to their limits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Lucian nodded in agreement."*)

### Węzeł `[122]`
Mówca: **Ciara Walda**
> ""With all due respect, I'm not going to respond to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)
  - -> `[123]` (*Player: ""Frankly, I don't care what you think. We have bigger pro..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. We have bigger problems here.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. We have bigger problems here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Lucian nodded. Nobody else responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[125]`
Mówca: **Iosef Lancea**
> ""Yes sir. It is of utmost importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""I want Mrs. Graf to put the region of Bergia under heavy..."*)
  - -> `[128]` (*Player: ""I want to establish peace talks with the group.""*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Iosef stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Iosef Lancea: ""Yes sir. It is of utmost importance.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I want Mrs. Graf to put the region of Bergia under heavy surveillance.""]** — Mówca: **Player**
> ""I want Mrs. Graf to put the region of Bergia under heavy surveillance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lileas Graf: ""As you wish.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""I want to establish peace talks with the group.""]** — Mówca: **Player**
> ""I want to establish peace talks with the group.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Iosef Lancea: ""Sir, I would advise against it. They are our enemies.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_PlansHub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Iosef stood up."*)

### Węzeł `[130]`
Mówca: **Lileas Graf**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 2"*)

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> ""Sir, I would advise against it. They are our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lileas Graf: ""So we're going to sit on a table with murderers now? No ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I want you to just try and reach out to them. We should be diplomatic.""]** — Mówca: **Player**
> ""I want you to just try and reach out to them. We should be diplomatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Lucian stepped up."*)

### Węzeł `[133]`
Mówca: **Lileas Graf**
> ""I can't believe you are justifying the murders of our Sordish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Lucian stepped up."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Lucian stepped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: ""I'll look into it, sir.""*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""I'll look into it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)

### Węzeł `[136]`
Mówca: **Lileas Graf**
> ""So we're going to sit on a table with murderers now? No deal will benefit those who died in their acts of terror.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""I want you to just try and reach out to them. We should ..."*)
  - -> `[138]` (*Player: ""They are fighting us because the state has never listene..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SecondPlan]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""The Constitution is not a toy. You can't just play with ..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""They are fighting us because the state has never listened to them before.""]** — Mówca: **Player**
> ""They are fighting us because the state has never listened to them before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lileas Graf: ""I can't believe you are justifying the murders of our So..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "Jump to: [SecondPlan]"*)
