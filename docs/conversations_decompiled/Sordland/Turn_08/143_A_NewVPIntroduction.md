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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 26

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Lucian_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[101]` (Albin Clavin): `Variable["GameCondition.Turn08_A_NewVPIntroduction"] = true;`
- Węzeł `[122]` (Albin Clavin): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[123]` (Albin Clavin): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[130]` (Albin Clavin): `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- Węzeł `[134]` (Albin Clavin): `Variable["BaseGameSupport.News_Turn08_R_VP_Gloria"] = true;`
- Węzeł `[138]` (Albin Clavin): `Variable["BaseGameSupport.News_Turn08_R_VP_Lucian"] = true;`
- Węzeł `[139]` (Albin Clavin): `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- Węzeł `[140]` (Albin Clavin): `Variable["BaseGameSupport.News_Turn08_HP_VP_Gloria"] = true;`
- *...oraz 18 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Albin Clavin)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[5]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[8]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Lucian and I were on our way to my office. I was holding a mug of coffee in one hand and a folder of various documents in the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I don't want to cause further division among Sords because of this.”"]** — Mówca: **Player**
> "“I don't want to cause further division among Sords because of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[11]`
Mówca: **Gloria Tory**
> "“Be careful with that box!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[12]`
Mówca: **Albin Clavin**
> "“You can leave it there. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[13]`
Mówca: **Narrator**
> "As we turned a corner, Lucian spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The Aschraf anniversary is coming up soon. The most important day for the Bludish populace. Watani Aschraf is one of their symbols, as you know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Be careful with that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“Your presence at this event would show your desire for a more unified Sordland. We will reap the benefits if you decide to go, I'm sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Why should I attend a Bludish anniversary?”"]** — Mówca: **Player**
> "“Why should I attend a Bludish anniversary?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“You are right.”"]** — Mówca: **Player**
> "“You are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“As I said, I believe this is an opportunity to portray yourself as a unifier, not a divider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“It would send a clear message to the Bludish. Your President is with you. This will alleviate tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "We rounded another corner to reach the last corridor leading to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian suddenly stopped in front of one of the doors. The plaque that once said 'Vice President Petr Vectern' had been removed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The door was halfway open, and I could see a few workers moving boxes around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I heard Albin's voice from inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I heard Gloria's voice from behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Another handyman dropped a heavy-looking box on the desk. A crunching sound was heard from within."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“Mr. President, this move requires my personal attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[29]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Lucian Galade'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[30]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Gloria Tory'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[31]`
Mówca: **Narrator**
> "One of them saw us, bowed his head and changed the name tag on the door to 'Vice President Albin Clavin'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[32]`
Mówca: **Narrator**
> "She noticed us and immediately made her way to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“Mr. President. Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[50]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He noticed us and immediately made his way to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“That is Mr. Galade to you Mr. *Vice President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Albin Clavin**
> "“Mr. President. Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
Mówca: **Albin Clavin**
> "“Very well, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Lucian's upper lip curled. He and Albin stared at each other down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Albin Clavin**
> "“Mr. Galade. Please deliver this to my secretary. This needs to be in the hands of the Justice Committee as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian's upper lip curled. He and Gloria stared at each other down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“Mr. Galade. Could you talk to the Staff Secretary for me to get the furniture sorted here? I have a few more boxes coming in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“I am not your servant, Mr. Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“I am not your servant, Mrs. Tory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“How is it going? Are you settled in yet?”"]** — Mówca: **Player**
> "“How is it going? Are you settled in yet?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I want you ready to work as soon as possible.”"]** — Mówca: **Player**
> "“I want you ready to work as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Albin! Good to see you.”"]** — Mówca: **Player**
> "“Albin! Good to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Albin Clavin**
> "“Getting there, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[48]`
Mówca: **Albin Clavin**
> "“As you wish, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[49]`
Mówca: **Albin Clavin**
> "“Good to see you too, Mr. President. I'm almost ready to get to work. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Gloria! Good to see you.”"]** — Mówca: **Player**
> "“Gloria! Good to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“I want you ready to work as soon as possible.”"]** — Mówca: **Player**
> "“I want you ready to work as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“How is it going? Are you settled in yet?”"]** — Mówca: **Player**
> "“How is it going? Are you settled in yet?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Gloria Tory**
> "“Good to see you too, Mr. President. I'm almost ready to get to work. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[54]`
Mówca: **Gloria Tory**
> "“As you wish, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[55]`
Mówca: **Gloria Tory**
> "“Getting there, Mr. President. That reminds me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[56]`
Mówca: **Gloria Tory**
> "“It was just a simple request, Mr. Galade. I don't know what's with you but I don't like your attitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[78]`
  - -> `[75]`

### Węzeł `[57]`
Mówca: **Albin Clavin**
> "“True, but I am your superior, *Lucian*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Lucian, do as your Vice President says.”"]** — Mówca: **Player**
> "“Lucian, do as your Vice President says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“But, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He turned to me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“Very well. I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[62]`
Mówca: **Narrator**
> "He walked out in a huff, leaving me alone with Albin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“We work with requests here, Mr. Clavin. Not orders.”"]** — Mówca: **Player**
> "“We work with requests here, Mr. Clavin. Not orders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Albin. Go deliver it yourself. We are busy.”"]** — Mówca: **Player**
> "“Albin. Go deliver it yourself. We are busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Albin Clavin**
> "“Then I request. Mr. Galade, could you *please* deliver this to my secretary? Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Fine. I'll take it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
Mówca: **Albin Clavin**
> "“I see. I will do that then. Thank you for stopping by.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "He turned his back on us. Lucian had an uncharacteristic smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Narrator**
> "He walked out, leaving me alone with Albin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“I will see you later, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[71]`
Mówca: **Narrator**
> "The two of us continued to my office to talk about our Aschraf strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Lucian, do as your Vice President says.”"]** — Mówca: **Player**
> "“Lucian, do as your Vice President says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He turned to me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“I will see you later. Mr. President and Mrs. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Gloria. Go talk to the Staff Secretary yourself. We are busy.”"]** — Mówca: **Player**
> "“Gloria. Go talk to the Staff Secretary yourself. We are busy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“But, Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Very well. I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“That's the job of an office secretary, Mrs. Tory. Not our chief strategist.”"]** — Mówca: **Player**
> "“That's the job of an office secretary, Mrs. Tory. Not our chief strategist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Gloria Tory**
> "“I know. As I said, it was just a simple request. I do not understand why it's becoming such a huge deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Very well... I will do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[81]`
Mówca: **Narrator**
> "He walked out, leaving me alone with Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[82]`
Mówca: **Gloria Tory**
> "“I see. I will do that then. Thank you for stopping by.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "She turned her back on us. Lucian had an uncharacteristic smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Narrator**
> "He left in a huff. I turned to Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[85]`
Mówca: **Narrator**
> "The two of us continued to my office to talk about our Aschraf strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“We shall discuss the Aschraf matter later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[95]`
  - -> `[99]`

### Węzeł `[87]`
Mówca: **Albin Clavin**
> "“Well then. I must get back to tidying up this room. Thank you for visiting, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“For the Aschraf matter, I will present you with our options later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“For the Aschraf matter, I will present you with our options later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[90]`
Mówca: **Albin Clavin**
> "“I will stop by as soon as this is done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[103]`
  - -> `[105]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“I will present you with our options on the Aschraf matter later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“I will present you with our options on the Aschraf matter later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[93]`
Mówca: **Gloria Tory**
> "“I will stop by as soon as this is done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[118]`

### Węzeł `[94]`
Mówca: **Gloria Tory**
> "“Well then. I must get back to the move. Thank you for visiting, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Be quick.”"]** — Mówca: **Player**
> "“Be quick about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“It's good to have you as my Vice President, Lucian.""]** — Mówca: **Player**
> "“It's good to have you as my Vice President, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“And I am glad to have you as my President, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_NewVPIntroduction = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_NewVPIntroduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[102]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Glad to have you here, Albin.”"]** — Mówca: **Player**
> "“Glad to have you here, Albin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I'm expecting good work from you. Do not disappoint me.”"]** — Mówca: **Player**
> "“I'm expecting good work from you. Do not disappoint me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I want you to try to get along with Lucian.”"]** — Mówca: **Player**
> "“I want you to try to get along with Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Albin Clavin**
> "“I assure you I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Albin Clavin**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Albin Clavin**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Albin bowed and went into his room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I'm expecting good work from you. Do not disappoint me.”"]** — Mówca: **Player**
> "“I'm expecting good work from you. Do not disappoint me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Glad to have you here, Gloria.”"]** — Mówca: **Player**
> "“Glad to have you here, Gloria.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Gloria Tory**
> "“I assure you I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Gloria nodded at me and went into her room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
Mówca: **Gloria Tory**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“I want you to try to get along with Lucian.”"]** — Mówca: **Player**
> "“I want you to try to get along with Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Another long day was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[120]`
Mówca: **Gloria Tory**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I entered my office and asked Sylvia for a second cup of coffee to wake me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[123]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[124]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.CurrentSpeaker_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.CurrentSpeaker_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.CurrentSpeaker_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[126]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.CurrentSpeaker_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.CurrentSpeaker_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[127]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[130]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_VP_Albin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[131]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[134]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_VP_Gloria = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[135]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[138]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_VP_Lucian = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Lucian"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[139]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_VP_Albin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_VP_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[140]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_VP_Gloria = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_VP_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[141]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_VP_Lucian = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_VP_Lucian"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[142]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin = true; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina = false; BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_NoSpeaker"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerAlbin"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerKatarina"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_GrandNationalAssembly_SpeakerRemus"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.Petr_isVP = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[145]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_AlbinClavin");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_AlbinClavin");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[146]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_GloriaTory");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_GloriaTory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_VicePresident", "Cabinet_VicePresident_LucianGalade");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_VicePresident","Cabinet_VicePresident_LucianGalade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[148]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_Speaker", "Legislative_RemusHolstron");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_Speaker","Legislative_RemusHolstron");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.CurrentSpeaker_Albin = false;
BaseGame.CurrentSpeaker_Remus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.CurrentSpeaker_Albin"] = false;
Variable["BaseGame.CurrentSpeaker_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_5", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_5","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[151]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_3", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[152]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_Speaker", "Legislative_AlbinClavin");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_Speaker","Legislative_AlbinClavin");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: BaseGame.CurrentSpeaker_Albin = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.CurrentSpeaker_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[154]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Legislative", "Position_NotableMember_3", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[155]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Lucian Galade", "Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Lucian Galade","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[156]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Gloria Tory", "Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Gloria Tory","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[157]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Albin Clavin", "Vice President");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Albin Clavin","Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[158]`
Mówca: **Albin Clavin**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
