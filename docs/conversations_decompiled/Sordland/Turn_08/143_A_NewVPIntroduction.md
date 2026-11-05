# Sordland/Turn08/A_NewVPIntroduction

- **ID konwersacji:** `143`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/143_A_NewVPIntroduction.md`
- **Liczba węzłów dialogowych:** 159
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory
- **[38]** Lucian Galade
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.CurrentSpeaker_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Media_Censored`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.CurrentSpeaker_Albin`
- `BaseGame.CurrentSpeaker_Remus`
- `BaseGame.Petr_isVP`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina`
- `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus`
- `BaseGameSupport.News_Turn08_HP_VP_Gloria`
- `BaseGameSupport.News_Turn08_HP_VP_Lucian`
- `BaseGameSupport.News_Turn08_R_VP_Albin`
- `BaseGameSupport.News_Turn08_R_VP_Gloria`
- `BaseGameSupport.News_Turn08_R_VP_Lucian`
- `GameCondition.Turn08_A_NewVPIntroduction`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“I don't want to cause further division among Sords because of this.”"** | `[16]` **Lucian Galade**: "“Your presence at this event wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucian Galade**: "“As I said, I believe this is an..." |
| `[17]` | **"“Why should I attend a Bludish anniversary?”"** | `[16]` **Lucian Galade**: "“Your presence at this event wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: "“It would send a clear message t..." |
| `[18]` | **"“You are right.”"** | `[16]` **Lucian Galade**: "“Your presence at this event wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "Lucian nodded." |
| `[44]` | **"“How is it going? Are you settled in yet?”"** | `[37]` **Albin Clavin**: "“Very well, Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Albin Clavin**: "“Getting there, Mr. President. T..." |
| `[45]` | **"“I want you ready to work as soon as possible.”"** | `[37]` **Albin Clavin**: "“Very well, Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Albin Clavin**: "“As you wish, Mr. President. Tha..." |
| `[46]` | **"“Albin! Good to see you.”"** | `[37]` **Albin Clavin**: "“Very well, Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Albin Clavin**: "“Good to see you too, Mr. Presid..." |
| `[50]` | **"“Gloria! Good to see you.”"** | `[33]` **Gloria Tory**: "“Mr. President. Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Gloria Tory**: "“Good to see you too, Mr. Presid..." |
| `[51]` | **"“I want you ready to work as soon as possible.”"** | `[33]` **Gloria Tory**: "“Mr. President. Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Gloria Tory**: "“As you wish, Mr. President. Tha..." |
| `[52]` | **"“How is it going? Are you settled in yet?”"** | `[33]` **Gloria Tory**: "“Mr. President. Mr. Galade.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Gloria Tory**: "“Getting there, Mr. President. T..." |
| `[58]` | **"“Lucian, do as your Vice President says.”"** | `[57]` **Albin Clavin**: "“True, but I am your superior, *..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "He turned to me with surprise." |
| `[63]` | **"“We work with requests here, Mr. Clavin. Not orders.”"** | `[57]` **Albin Clavin**: "“True, but I am your superior, *..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Albin Clavin**: "“Then I request. Mr. Galade, cou..." |
| `[64]` | **"“Albin. Go deliver it yourself. We are busy.”"** | `[57]` **Albin Clavin**: "“True, but I am your superior, *..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Albin Clavin**: "“I see. I will do that then. Tha..." |
| `[72]` | **"“Lucian, do as your Vice President says.”"** | `[56]` **Gloria Tory**: "“It was just a simple request, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "He turned to me with surprise." |
| `[75]` | **"“Gloria. Go talk to the Staff Secretary yourself. We are busy.”"** | `[56]` **Gloria Tory**: "“It was just a simple request, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Gloria Tory**: "“I see. I will do that then. Tha..." |
| `[78]` | **"“That's the job of an office secretary, Mrs. Tory. Not our chief strategist.”"** | `[56]` **Gloria Tory**: "“It was just a simple request, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Gloria Tory**: "“I know. As I said, it was just ..." |
| `[95]` | **"“Be quick.”"** | `[86]` **Lucian Galade**: "“We shall discuss the Aschraf ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucian Galade**: "“As you wish.”" |
| `[97]` | **"“Good luck.”"** | `[86]` **Lucian Galade**: "“We shall discuss the Aschraf ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Lucian Galade**: "“Thank you.”" |
| `[99]` | **"“It's good to have you as my Vice President, Lucian.""** | `[86]` **Lucian Galade**: "“We shall discuss the Aschraf ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lucian Galade**: "“And I am glad to have you as my..." |
| `[103]` | **"“Glad to have you here, Albin.”"** | `[90]` **Albin Clavin**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Albin Clavin**: "“Thank you.”" |
| `[104]` | **"“I'm expecting good work from you. Do not disappoint me.”"** | `[90]` **Albin Clavin**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Albin Clavin**: "“I assure you I will not.”" |
| `[105]` | **"“I want you to try to get along with Lucian.”"** | `[90]` **Albin Clavin**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Albin Clavin**: "“I will do my best.”" |
| `[113]` | **"“I'm expecting good work from you. Do not disappoint me.”"** | `[93]` **Gloria Tory**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Gloria Tory**: "“I assure you I will not.”" |
| `[114]` | **"“Glad to have you here, Gloria.”"** | `[93]` **Gloria Tory**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Gloria Tory**: "“Thank you.”" |
| `[118]` | **"“I want you to try to get along with Lucian.”"** | `[93]` **Gloria Tory**: "“I will stop by as soon as this ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gloria Tory**: "“I will do my best.”" |

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
  - -> `[9]` (*Narrator: "Lucian and I were on our way to my office. I was holding ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_VicePresident"..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_VicePresident"..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_VicePresident"..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Lucian and I were on our way to my office. I was holding a mug of coffee in one hand and a folder of various documents in the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_isVP = false"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I don't want to cause further division among Sords because of this.”"]** — Mówca: **Player**
> "“I don't want to cause further division among Sords because of this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“As I said, I believe this is an opportunity to portray y..."*)

### Węzeł `[11]`
Mówca: **Gloria Tory**
> "“Be careful with that box!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "She noticed us and immediately made her way to us."*)

### Węzeł `[12]`
Mówca: **Albin Clavin**
> "“You can leave it there. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He noticed us and immediately made his way to us."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "As we turned a corner, Lucian spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“The Aschraf anniversary is coming up soon. The most impo..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The Aschraf anniversary is coming up soon. The most important day for the Bludish populace. Watani Aschraf is one of their symbols, as you know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“Your presence at this event would show your desire for a..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Be careful with that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: "“Mr. President, this move requires my personal attention.""*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“Your presence at this event would show your desire for a more unified Sordland. We will reap the benefits if you decide to go, I'm sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I don't want to cause further division among Sords becau..."*)
  - -> `[17]` (*Player: "“Why should I attend a Bludish anniversary?”"*)
  - -> `[18]` (*Player: "“You are right.”"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Why should I attend a Bludish anniversary?”"]** — Mówca: **Player**
> "“Why should I attend a Bludish anniversary?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“It would send a clear message to the Bludish. Your Presi..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“You are right.”"]** — Mówca: **Player**
> "“You are right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian nodded."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“As I said, I believe this is an opportunity to portray yourself as a unifier, not a divider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "We rounded another corner to reach the last corridor lead..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“It would send a clear message to the Bludish. Your President is with you. This will alleviate tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "We rounded another corner to reach the last corridor lead..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "We rounded another corner to reach the last corridor lead..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "We rounded another corner to reach the last corridor leading to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Lucian suddenly stopped in front of one of the doors. The..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian suddenly stopped in front of one of the doors. The plaque that once said 'Vice President Petr Vectern' had been removed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The door was halfway open, and I could see a few workers ..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The door was halfway open, and I could see a few workers moving boxes around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I heard Albin's voice from inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Albin Clavin", "Vice President");"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I heard Gloria's voice from behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gloria Tory: "“Be careful with that box!”"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Another handyman dropped a heavy-looking box on the desk. A crunching sound was heard from within."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Be careful with that!”"*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“Mr. President, this move requires my personal attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“We shall discuss the Aschraf matter later.""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Lucian Galade'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Lucian Galade", "Vice President");"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Gloria Tory'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Gloria Tory", "Vice President");"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Albin Clavin'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I heard Albin's voice from inside."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "She noticed us and immediately made her way to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: "“Mr. President. Mr. Galade.”"*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“Mr. President. Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“How is it going? Are you settled in yet?”"*)
  - -> `[51]` (*Player: "“I want you ready to work as soon as possible.”"*)
  - -> `[50]` (*Player: "“Gloria! Good to see you.”"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He noticed us and immediately made his way to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Albin Clavin: "“Mr. President. Lucian.”"*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“That is Mr. Galade to you Mr. *Vice President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Albin Clavin: "“Very well, Mr. Galade.”"*)

### Węzeł `[36]`
Mówca: **Albin Clavin**
> "“Mr. President. Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: "“That is Mr. Galade to you Mr. *Vice President*.”"*)

### Węzeł `[37]`
Mówca: **Albin Clavin**
> "“Very well, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“How is it going? Are you settled in yet?”"*)
  - -> `[45]` (*Player: "“I want you ready to work as soon as possible.”"*)
  - -> `[46]` (*Player: "“Albin! Good to see you.”"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Lucian's upper lip curled. He and Albin stared at each other down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“I am not your servant, Mr. Clavin.”"*)

### Węzeł `[39]`
Mówca: **Albin Clavin**
> "“Mr. Galade. Please deliver this to my secretary. This needs to be in the hands of the Justice Committee as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Lucian's upper lip curled. He and Albin stared at each ot..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian's upper lip curled. He and Gloria stared at each other down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: "“I am not your servant, Mrs. Tory.”"*)

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“Mr. Galade. Could you talk to the Staff Secretary for me to get the furniture sorted here? I have a few more boxes coming in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lucian's upper lip curled. He and Gloria stared at each o..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“I am not your servant, Mr. Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Albin Clavin: "“True, but I am your superior, *Lucian*.”"*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“I am not your servant, Mrs. Tory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Gloria Tory: "“It was just a simple request, Mr. Galade. I don't know w..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“How is it going? Are you settled in yet?”"]** — Mówca: **Player**
> "“How is it going? Are you settled in yet?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Albin Clavin: "“Getting there, Mr. President. That reminds me...”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I want you ready to work as soon as possible.”"]** — Mówca: **Player**
> "“I want you ready to work as soon as possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Albin Clavin: "“As you wish, Mr. President. That reminds me...”"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Albin! Good to see you.”"]** — Mówca: **Player**
> "“Albin! Good to see you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Albin Clavin: "“Good to see you too, Mr. President. I'm almost ready to ..."*)

### Węzeł `[47]`
Mówca: **Albin Clavin**
> "“Getting there, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Albin Clavin: "“Mr. Galade. Please deliver this to my secretary. This ne..."*)

### Węzeł `[48]`
Mówca: **Albin Clavin**
> "“As you wish, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Albin Clavin: "“Mr. Galade. Please deliver this to my secretary. This ne..."*)

### Węzeł `[49]`
Mówca: **Albin Clavin**
> "“Good to see you too, Mr. President. I'm almost ready to get to work. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Albin Clavin: "“Mr. Galade. Please deliver this to my secretary. This ne..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Gloria! Good to see you.”"]** — Mówca: **Player**
> "“Gloria! Good to see you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Gloria Tory: "“Good to see you too, Mr. President. I'm almost ready to ..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“I want you ready to work as soon as possible.”"]** — Mówca: **Player**
> "“I want you ready to work as soon as possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gloria Tory: "“As you wish, Mr. President. That reminds me...”"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“How is it going? Are you settled in yet?”"]** — Mówca: **Player**
> "“How is it going? Are you settled in yet?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Gloria Tory: "“Getting there, Mr. President. That reminds me...”"*)

### Węzeł `[53]`
Mówca: **Gloria Tory**
> "“Good to see you too, Mr. President. I'm almost ready to get to work. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“Mr. Galade. Could you talk to the Staff Secretary for me..."*)

### Węzeł `[54]`
Mówca: **Gloria Tory**
> "“As you wish, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“Mr. Galade. Could you talk to the Staff Secretary for me..."*)

### Węzeł `[55]`
Mówca: **Gloria Tory**
> "“Getting there, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“Mr. Galade. Could you talk to the Staff Secretary for me..."*)

### Węzeł `[56]`
Mówca: **Gloria Tory**
> "“It was just a simple request, Mr. Galade. I don't know what's with you but I don't like your attitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“Lucian, do as your Vice President says.”"*)
  - -> `[78]` (*Player: "“That's the job of an office secretary, Mrs. Tory. Not ou..."*)
  - -> `[75]` (*Player: "“Gloria. Go talk to the Staff Secretary yourself. We are ..."*)

### Węzeł `[57]`
Mówca: **Albin Clavin**
> "“True, but I am your superior, *Lucian*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“Lucian, do as your Vice President says.”"*)
  - -> `[63]` (*Player: "“We work with requests here, Mr. Clavin. Not orders.”"*)
  - -> `[64]` (*Player: "“Albin. Go deliver it yourself. We are busy.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Lucian, do as your Vice President says.”"]** — Mówca: **Player**
> "“Lucian, do as your Vice President says.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He turned to me with surprise."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“But, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: "“Very well. I will do it.”"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He turned to me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: "“But, Mr. President...”"*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“Very well. I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“For the Aschraf matter, I will present you with our opti..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "He walked out in a huff, leaving me alone with Albin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Albin Clavin: "“Well then. I must get back to tidying up this room. Than..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“We work with requests here, Mr. Clavin. Not orders.”"]** — Mówca: **Player**
> "“We work with requests here, Mr. Clavin. Not orders.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Albin Clavin: "“Then I request. Mr. Galade, could you *please* deliver t..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Albin. Go deliver it yourself. We are busy.”"]** — Mówca: **Player**
> "“Albin. Go deliver it yourself. We are busy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Albin Clavin: "“I see. I will do that then. Thank you for stopping by.”"*)

### Węzeł `[65]`
Mówca: **Albin Clavin**
> "“Then I request. Mr. Galade, could you *please* deliver this to my secretary? Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Fine. I'll take it.”"*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Fine. I'll take it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“I will see you later, Mr. President.”"*)

### Węzeł `[67]`
Mówca: **Albin Clavin**
> "“I see. I will do that then. Thank you for stopping by.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He turned his back on us. Lucian had an uncharacteristic ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He turned his back on us. Lucian had an uncharacteristic smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The two of us continued to my office to talk about our As..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "He walked out, leaving me alone with Albin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Albin Clavin: "“Well then. I must get back to tidying up this room. Than..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“I will see you later, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: "“For the Aschraf matter, I will present you with our opti..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "The two of us continued to my office to talk about our Aschraf strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Another long day was waiting for me."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Lucian, do as your Vice President says.”"]** — Mówca: **Player**
> "“Lucian, do as your Vice President says.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He turned to me with surprise."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He turned to me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: "“But, Mr. President...”"*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“I will see you later. Mr. President and Mrs. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: "“I will present you with our options on the Aschraf matte..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Gloria. Go talk to the Staff Secretary yourself. We are busy.”"]** — Mówca: **Player**
> "“Gloria. Go talk to the Staff Secretary yourself. We are busy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gloria Tory: "“I see. I will do that then. Thank you for stopping by.”"*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“But, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: "“Very well. I will do it.”"*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Very well. I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“I will present you with our options on the Aschraf matte..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“That's the job of an office secretary, Mrs. Tory. Not our chief strategist.”"]** — Mówca: **Player**
> "“That's the job of an office secretary, Mrs. Tory. Not our chief strategist.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gloria Tory: "“I know. As I said, it was just a simple request. I do no..."*)

### Węzeł `[79]`
Mówca: **Gloria Tory**
> "“I know. As I said, it was just a simple request. I do not understand why it's becoming such a huge deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“Very well... I will do it.”"*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Very well... I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“I will see you later. Mr. President and Mrs. Vice Presid..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "He walked out, leaving me alone with Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gloria Tory: "“Well then. I must get back to the move. Thank you for vi..."*)

### Węzeł `[82]`
Mówca: **Gloria Tory**
> "“I see. I will do that then. Thank you for stopping by.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "She turned her back on us. Lucian had an uncharacteristic..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "She turned her back on us. Lucian had an uncharacteristic smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "The two of us continued to my office to talk about our As..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "He left in a huff. I turned to Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gloria Tory: "“Well then. I must get back to the move. Thank you for vi..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "The two of us continued to my office to talk about our Aschraf strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Another long day was waiting for me."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“We shall discuss the Aschraf matter later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "“Good luck.”"*)
  - -> `[95]` (*Player: "“Be quick.”"*)
  - -> `[99]` (*Player: "“It's good to have you as my Vice President, Lucian.""*)

### Węzeł `[87]`
Mówca: **Albin Clavin**
> "“Well then. I must get back to tidying up this room. Thank you for visiting, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Albin Clavin: "“I will stop by as soon as this is done.”"*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“For the Aschraf matter, I will present you with our options later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“For the Aschraf matter, I will present you with our options later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He walked out, leaving me alone with Albin."*)

### Węzeł `[90]`
Mówca: **Albin Clavin**
> "“I will stop by as soon as this is done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“I'm expecting good work from you. Do not disappoint me.”"*)
  - -> `[103]` (*Player: "“Glad to have you here, Albin.”"*)
  - -> `[105]` (*Player: "“I want you to try to get along with Lucian.”"*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“I will present you with our options on the Aschraf matter later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Opinion -= 1"*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“I will present you with our options on the Aschraf matter later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He walked out, leaving me alone with Gloria."*)

### Węzeł `[93]`
Mówca: **Gloria Tory**
> "“I will stop by as soon as this is done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "“I'm expecting good work from you. Do not disappoint me.”"*)
  - -> `[114]` (*Player: "“Glad to have you here, Gloria.”"*)
  - -> `[118]` (*Player: "“I want you to try to get along with Lucian.”"*)

### Węzeł `[94]`
Mówca: **Gloria Tory**
> "“Well then. I must get back to the move. Thank you for visiting, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gloria Tory: "“I will stop by as soon as this is done.”"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Be quick.”"]** — Mówca: **Player**
> "“Be quick about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: "“As you wish.”"*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "I entered my office and asked Sylvia for a second cup of ..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "I entered my office and asked Sylvia for a second cup of ..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“It's good to have you as my Vice President, Lucian.""]** — Mówca: **Player**
> "“It's good to have you as my Vice President, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“And I am glad to have you as my President, sir.”"*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“And I am glad to have you as my President, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "I entered my office and asked Sylvia for a second cup of ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_NewVPIntroduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_NewVPIntroduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Another long day was waiting for me."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Glad to have you here, Albin.”"]** — Mówca: **Player**
> "“Glad to have you here, Albin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Albin Clavin: "“Thank you.”"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I'm expecting good work from you. Do not disappoint me.”"]** — Mówca: **Player**
> "“I'm expecting good work from you. Do not disappoint me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Albin Clavin: "“I assure you I will not.”"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I want you to try to get along with Lucian.”"]** — Mówca: **Player**
> "“I want you to try to get along with Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Albin Clavin: "“I will do my best.”"*)

### Węzeł `[106]`
Mówca: **Albin Clavin**
> "“I assure you I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Albin bowed and went into his room."*)

### Węzeł `[107]`
Mówca: **Albin Clavin**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Albin bowed and went into his room."*)

### Węzeł `[108]`
Mówca: **Albin Clavin**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Albin bowed and went into his room."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Albin bowed and went into his room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I entered my office and asked Sylvia for a second cup of ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another long day was waiting for me."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_NewVPIntroduction = true"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_NewVPIntroduction = true"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I'm expecting good work from you. Do not disappoint me.”"]** — Mówca: **Player**
> "“I'm expecting good work from you. Do not disappoint me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Gloria Tory: "“I assure you I will not.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Glad to have you here, Gloria.”"]** — Mówca: **Player**
> "“Glad to have you here, Gloria.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Gloria Tory: "“Thank you.”"*)

### Węzeł `[115]`
Mówca: **Gloria Tory**
> "“I assure you I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Gloria nodded at me and went into her room."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Gloria nodded at me and went into her room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I entered my office and asked Sylvia for a second cup of ..."*)

### Węzeł `[117]`
Mówca: **Gloria Tory**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Gloria nodded at me and went into her room."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“I want you to try to get along with Lucian.”"]** — Mówca: **Player**
> "“I want you to try to get along with Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gloria Tory: "“I will do my best.”"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_NewVPIntroduction = true"*)

### Węzeł `[120]`
Mówca: **Gloria Tory**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Gloria nodded at me and went into her room."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Another long day was waiting for me."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "He left in a huff. I turned to Gloria."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "He walked out in a huff, leaving me alone with Albin."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Albin == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.CurrentSpeaker_Albin == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.CurrentSpeaker_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_Speaker", ..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.CurrentSpeaker_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.CurrentSpeaker_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_VP_Albin = true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_VP_Albin = true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_VP_Albin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_VP_Gloria = true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_VP_Gloria = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_VP_Lucian = true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_VP_Lucian = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Lucian"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "One of them saw us, bowed his head and changed the name t..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_VP_Albin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_VP_Gloria = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_VP_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_VP_Lucian = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_VP_Lucian"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_VP_Albin = true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin = true; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_VP_Gloria = true;"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_isVP = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "As we turned a corner, Lucian spoke."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_AlbinClavin");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_AlbinClavin");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Albin == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_GloriaTory");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_GloriaTory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_Speaker", ..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_LucianGalade");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_LucianGalade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_VP_Lucian = true;"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_Speaker", "Legislative_RemusHolstron");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_Speaker","Legislative_RemusHolstron");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Albin = false;
BaseGame.CurrentSpeaker_Remus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.CurrentSpeaker_Albin"] = false;
Variable["BaseGame.CurrentSpeaker_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_5", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_5","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Albin = false; BaseGame.CurrentSp..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_3", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_GrandNat..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_Speaker", "Legislative_AlbinClavin");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_Speaker","Legislative_AlbinClavin");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.CurrentSpeaker_Albin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.CurrentSpeaker_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_GrandNat..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_3", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.CurrentSpeaker_Albin = true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Lucian Galade", "Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Lucian Galade","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Another handyman dropped a heavy-looking box on the desk...."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Gloria Tory", "Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Gloria Tory","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I heard Gloria's voice from behind him."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Albin Clavin", "Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Albin Clavin","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Albin Clavin: "“You can leave it there. Thank you.”"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
