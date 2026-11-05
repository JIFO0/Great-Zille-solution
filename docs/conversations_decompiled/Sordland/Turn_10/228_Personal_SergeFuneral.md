# Sordland/Turn10/Personal_SergeFuneral

- **ID konwersacji:** `228`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/228_Personal_SergeFuneral.md`
- **Liczba węzłów dialogowych:** 95
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral`
- `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral`
- `BaseGame.Ending_Coup`
- `BaseGame.Relations_Serge_Acquaintance`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Relations_Serge_GoodLuckCharm`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Serge_GoodLuckCharm`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed`
- `BaseGameSupport.News_Turn10_HP_Serge_Funeral`
- `BaseGameSupport.News_Turn10_LT_Serge_Funeral`
- `BaseGameSupport.News_Turn10_ST_Serge_Funeral`
- `GameCondition.Turn10_Personal_SergeFuneral`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“I will hold my own umbrella.”"** | `[5]` **Narrator**: "He offered to carry my umbrella." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "Under the watchful eyes of secur..."<br>`[7]` **Narrator**: "Under the watchful eyes of secur..." |
| `[6]` | **"Let him carry your umbrella."** | `[5]` **Narrator**: "He offered to carry my umbrella." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "Under the watchful eyes of secur..."<br>`[7]` **Narrator**: "Under the watchful eyes of secur..." |
| `[18]` | **"“Today, we are mourning a hero of our nation.”"** | `[19]` **Narrator**: "I looked around at everyone's fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **"“Today, we have gathered here to mourn the man who saved my life.”"** | `[19]` **Narrator**: "I looked around at everyone's fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **"“Today, we are sending off a friend, a husband and a father.”"** | `[19]` **Narrator**: "I looked around at everyone's fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **"“Serge Wolkner was a true Sord. He was honest, proud and brave.”"** | `[18]` **Player**: "“Today, we are mourning a hero o..."<br>`[21]` **Player**: "“Today, we are gathered here to ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player**: "“I wouldn't be able to find a si..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych odgałęzień)* |
| `[24]` | **"“Serge Wolkner was more than a simple driver for me. He was a real friend.”"** | `[18]` **Player**: "“Today, we are mourning a hero o..."<br>`[21]` **Player**: "“Today, we are gathered here to ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player**: "“I wouldn't be able to find a si..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **"“Serge Wolkner was loved by many and he will be missed dearly.”"** | `[18]` **Player**: "“Today, we are mourning a hero o..."<br>`[21]` **Player**: "“Today, we are gathered here to ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player**: "“I wouldn't be able to find a si..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych odgałęzień)* |
| `[26]` | **"“I will always cherish the moments I spent with him.”"** | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: "“I will be forever burdened with..."<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **"“He has left us too soon.”"** | `[26]` **Player**: "“I will always cherish the momen..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "“His death will be avenged. This..."<br>`[35]` **Player**: "“The family he has left behind w..."<br>*(oraz 1 innych odgałęzień)* |
| `[28]` | **"“His memory is engraved in all of our minds and hearts. We must remember him well.”"** | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: "“I will be forever burdened with..."<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **"“I wouldn't be able to find a single person who did not enjoy his company.”"** | `[23]` **Player**: "“Serge Wolkner was a true Sord. ..."<br>`[24]` **Player**: "“Serge Wolkner was more than a s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player**: "“I will be forever burdened with..."<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych odgałęzień)* |
| `[30]` | **"“I will never forget that I am standing here right now because of his sacrifice.”"** | `[26]` **Player**: "“I will always cherish the momen..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "“His death will be avenged. This..."<br>`[35]` **Player**: "“The family he has left behind w..."<br>*(oraz 1 innych odgałęzień)* |
| `[31]` | **"“I will be forever burdened with the fact that this happened because of me.”"** | `[26]` **Player**: "“I will always cherish the momen..."<br>`[28]` **Player**: "“His memory is engraved in our m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player**: "“His death will be avenged. This..."<br>`[35]` **Player**: "“The family he has left behind w..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **"“I am granting him the title, 'Hero of Sordland'.”"** | `[33]` **Player**: "“I swear to cherish the life he ..."<br>`[34]` **Player**: "“His death will be avenged. This..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "“May his memory last forever.”"<br>`[38]` **Player**: "“Farewell, brother.”"<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **"“I swear to cherish the life he has once again granted me with.”"** | `[27]` **Player**: "“He has left us too soon.”"<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"“His death will be avenged. This, I promise.”"** | `[27]` **Player**: "“He has left us too soon.”"<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych odgałęzień)* |
| `[35]` | **"“The family he has left behind will have the full support of the government.”"** | `[27]` **Player**: "“He has left us too soon.”"<br>`[30]` **Player**: "“I will never forget that I am s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych odgałęzień)* |
| `[36]` | **"“I am granting him the military rank of Major.”"** | `[33]` **Player**: "“I swear to cherish the life he ..."<br>`[34]` **Player**: "“His death will be avenged. This..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "“May his memory last forever.”"<br>`[38]` **Player**: "“Farewell, brother.”"<br>*(oraz 1 innych odgałęzień)* |
| `[37]` | **"“In these dark times, we need to come together in unity.”"** | `[33]` **Player**: "“I swear to cherish the life he ..."<br>`[34]` **Player**: "“His death will be avenged. This..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Player**: "“May his memory last forever.”"<br>`[38]` **Player**: "“Farewell, brother.”"<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **"“Farewell, brother.”"** | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "The casket started to be lowered." |
| `[39]` | **"“Thank you for your service, Serge.”"** | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "The casket started to be lowered." |
| `[40]` | **"“May his memory last forever.”"** | `[32]` **Player**: "“I am granting him the title, 'H..."<br>`[36]` **Player**: "“I am granting him the military ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "The casket started to be lowered." |
| `[48]` | **"Keep the watch."** | `[47]` **Narrator**: "At first I didn't believe it, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "As the casket hit the ground, mo..." |
| `[49]` | **"Give the watch to Serge's son."** | `[47]` **Narrator**: "At first I didn't believe it, bu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] = false;`<br>`DisableCollectionItem("CollectionItem_Pocketwatch");` | `[52]` **Narrator**: "As the casket hit the ground, mo..." |
| `[50]` | **"Place the watch on his grave."** | `[47]` **Narrator**: "At first I didn't believe it, bu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] = false;`<br>`DisableCollectionItem("CollectionItem_Pocketwatch");` | `[52]` **Narrator**: "As the casket hit the ground, mo..." |
| `[57]` | **"Wipe their tears."** | `[14]` **Narrator**: "Little Anton was crying silently..."<br>`[15]` **Narrator**: "Little Georg was crying silently..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "“Your father was a great man. Do..."<br>`[61]` **Player**: "“It's okay to cry. Let it all out.”"<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"Pat them on their heads."** | `[14]` **Narrator**: "Little Anton was crying silently..."<br>`[15]` **Narrator**: "Little Georg was crying silently..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "“Your father was a great man. Do..."<br>`[61]` **Player**: "“It's okay to cry. Let it all out.”"<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"Give them a hug."** | `[14]` **Narrator**: "Little Anton was crying silently..."<br>`[15]` **Narrator**: "Little Georg was crying silently..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player**: "“Your father was a great man. Do..."<br>`[61]` **Player**: "“It's okay to cry. Let it all out.”"<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **"“Your father was a great man. Don't ever forget that.”"** | `[57]` **Player_Italic**: "I wiped their tears."<br>`[58]` **Player_Italic**: "I patted them on their heads."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "They were too young to experienc..." |
| `[61]` | **"“It's okay to cry. Let it all out.”"** | `[57]` **Player_Italic**: "I wiped their tears."<br>`[58]` **Player_Italic**: "I patted them on their heads."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "They were too young to experienc..." |
| `[62]` | **"“Ms. Wolkner. I will never forget your husband's service and his heroic sacrifice.""** | `[83]` **Narrator**: "She was wearing an elegant black..."<br>`[87]` **Narrator**: "She was wearing a simple but wel..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |
| `[63]` | **"“I am so sorry, Suzan.”"** | `[83]` **Narrator**: "She was wearing an elegant black..."<br>`[87]` **Narrator**: "She was wearing a simple but wel..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |
| `[64]` | **"“My condolences.”"** | `[88]` **Narrator**: "She was wearing a simple but wel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |
| `[66]` | **"“You must be strong.”"** | `[57]` **Player_Italic**: "I wiped their tears."<br>`[58]` **Player_Italic**: "I patted them on their heads."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "They were too young to experienc..." |
| `[89]` | **""Don't worry. I'll make sure you and your children are still well cared for.""** | `[83]` **Narrator**: "She was wearing an elegant black..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |
| `[93]` | **""I wish I could have done more. He deserved it.""** | `[83]` **Narrator**: "She was wearing an elegant black..."<br>`[87]` **Narrator**: "She was wearing a simple but wel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |
| `[94]` | **""Don't worry. I'll make sure the children are still well cared for.""** | `[87]` **Narrator**: "She was wearing a simple but wel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We hugged and she cried on my sh..." |

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
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Rain");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I will hold my own umbrella.”"]** — Mówca: **Player**
> "“I will hold my own umbrella.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "It was raining as my car came to a stop by the Holsord Grand Cemetery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseG..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He offered to carry my umbrella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“I will hold my own umbrella.”"*)
  - -> `[6]` (*Player_Italic: "Let him carry your umbrella."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Let him carry your umbrella."]** — Mówca: **Player_Italic**
> "I let him carry my umbrella."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Under the watchful eyes of security officers, I started walking amidst the gravestones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "A small crowd of family and friends gathered around the f..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "A small crowd of family and friends gathered around the final resting place of Serge Wolkner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Some in the media were calling him a hero: the brave driv..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Some in the media were calling him a hero: the brave driver who saved the president by sacrificing his life. It was true."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Despite my protests, security wouldn't permit a larger fu..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I walked up to his widow, Suzan. I had never met her in person before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Little Anton was crying silently next to his sister, Erica."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Little Georg was crying silently next to his sister, Erica."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Little Anton was crying silently next to his sister, Erica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Wipe their tears."*)
  - -> `[58]` (*Player_Italic: "Pat them on their heads."*)
  - -> `[59]` (*Player_Italic: "Give them a hug."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Little Georg was crying silently next to his sister, Erica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Wipe their tears."*)
  - -> `[58]` (*Player_Italic: "Pat them on their heads."*)
  - -> `[59]` (*Player_Italic: "Give them a hug."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "They were too young to experience the pain of losing a father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I walked over to stand next to the priest, who stepped ba..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I walked over to stand next to the priest, who stepped back upon my arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I looked around at everyone's faces."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Today, we are mourning a hero of our nation.”"]** — Mówca: **Player**
> "“Today, we are mourning a hero of our nation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Serge Wolkner was a true Sord. He was honest, proud and ..."*)
  - -> `[24]` (*Player: "“Serge Wolkner was more than a simple driver for me. He w..."*)
  - -> `[25]` (*Player: "“Serge Wolkner was loved by many and he will be missed de..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I looked around at everyone's faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "“Today, we have gathered here to mourn the man who saved ..."*)
  - -> `[18]` (*Player: "“Today, we are mourning a hero of our nation.”"*)
  - -> `[22]` (*Player: "“Today, we are sending off a friend, a husband and a fath..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Despite my protests, security wouldn't permit a larger funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I walked up to his widow, Suzan. I had never met her in p..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Today, we have gathered here to mourn the man who saved my life.”"]** — Mówca: **Player**
> "“Today, we are gathered here to mourn the man who saved my life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Serge Wolkner was a true Sord. He was honest, proud and ..."*)
  - -> `[24]` (*Player: "“Serge Wolkner was more than a simple driver for me. He w..."*)
  - -> `[25]` (*Player: "“Serge Wolkner was loved by many and he will be missed de..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Today, we are sending off a friend, a husband and a father.”"]** — Mówca: **Player**
> "“Today, we are sending off a friend, a husband and a father.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Serge Wolkner was a true Sord. He was honest, proud and ..."*)
  - -> `[24]` (*Player: "“Serge Wolkner was more than a simple driver for me. He w..."*)
  - -> `[25]` (*Player: "“Serge Wolkner was loved by many and he will be missed de..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Serge Wolkner was a true Sord. He was honest, proud and brave.”"]** — Mówca: **Player**
> "“Serge Wolkner was a true Sord. He was honest, proud and brave.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“I wouldn't be able to find a single person who did not e..."*)
  - -> `[28]` (*Player: "“His memory is engraved in all of our minds and hearts. W..."*)
  - -> `[26]` (*Player: "“I will always cherish the moments I spent with him.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Serge Wolkner was more than a simple driver for me. He was a real friend.”"]** — Mówca: **Player**
> "“Serge Wolkner was more than a simple driver for me. He was a real friend.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“I wouldn't be able to find a single person who did not e..."*)
  - -> `[28]` (*Player: "“His memory is engraved in all of our minds and hearts. W..."*)
  - -> `[26]` (*Player: "“I will always cherish the moments I spent with him.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Serge Wolkner was loved by many and he will be missed dearly.”"]** — Mówca: **Player**
> "“Serge Wolkner was loved by many and he will be missed dearly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“I wouldn't be able to find a single person who did not e..."*)
  - -> `[28]` (*Player: "“His memory is engraved in all of our minds and hearts. W..."*)
  - -> `[26]` (*Player: "“I will always cherish the moments I spent with him.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I will always cherish the moments I spent with him.”"]** — Mówca: **Player**
> "“I will always cherish the moments I spent with him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“I will be forever burdened with the fact that this happe..."*)
  - -> `[30]` (*Player: "“I will never forget that I am standing here right now be..."*)
  - -> `[27]` (*Player: "“He has left us too soon.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“He has left us too soon.”"]** — Mówca: **Player**
> "“He has left us too soon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[28]` (Player), `[29]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“His death will be avenged. This, I promise.”"*)
  - -> `[35]` (*Player: "“The family he has left behind will have the full support..."*)
  - -> `[33]` (*Player: "“I swear to cherish the life he has once again granted me..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“His memory is engraved in all of our minds and hearts. We must remember him well.”"]** — Mówca: **Player**
> "“His memory is engraved in our minds and hearts. We must remember him well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“I will be forever burdened with the fact that this happe..."*)
  - -> `[30]` (*Player: "“I will never forget that I am standing here right now be..."*)
  - -> `[27]` (*Player: "“He has left us too soon.”"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I wouldn't be able to find a single person who did not enjoy his company.”"]** — Mówca: **Player**
> "“I wouldn't be able to find a single person who did not enjoy his company.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player), `[24]` (Player), `[25]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“I will be forever burdened with the fact that this happe..."*)
  - -> `[30]` (*Player: "“I will never forget that I am standing here right now be..."*)
  - -> `[27]` (*Player: "“He has left us too soon.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I will never forget that I am standing here right now because of his sacrifice.”"]** — Mówca: **Player**
> "“I will never forget that I am standing here right now because of his sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[28]` (Player), `[29]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“His death will be avenged. This, I promise.”"*)
  - -> `[35]` (*Player: "“The family he has left behind will have the full support..."*)
  - -> `[33]` (*Player: "“I swear to cherish the life he has once again granted me..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“I will be forever burdened with the fact that this happened because of me.”"]** — Mówca: **Player**
> "“I will be forever burdened with the fact that this happened because of me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[28]` (Player), `[29]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“His death will be avenged. This, I promise.”"*)
  - -> `[35]` (*Player: "“The family he has left behind will have the full support..."*)
  - -> `[33]` (*Player: "“I swear to cherish the life he has once again granted me..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“I am granting him the title, 'Hero of Sordland'.”"]** — Mówca: **Player**
> "“I am granting him the title, 'Hero of Sordland'.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[34]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“May his memory last forever.”"*)
  - -> `[38]` (*Player: "“Farewell, brother.”"*)
  - -> `[39]` (*Player: "“Thank you for your service, Serge.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“I swear to cherish the life he has once again granted me with.”"]** — Mówca: **Player**
> "“I swear to cherish the life he has once again granted me with.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“I am granting him the title, 'Hero of Sordland'.”"*)
  - -> `[36]` (*Player: "“I am granting him the military rank of Major.”"*)
  - -> `[37]` (*Player: "“In these dark times, we need to come together in unity.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“His death will be avenged. This, I promise.”"]** — Mówca: **Player**
> "“His death will be avenged. This, I promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“I am granting him the title, 'Hero of Sordland'.”"*)
  - -> `[36]` (*Player: "“I am granting him the military rank of Major.”"*)
  - -> `[37]` (*Player: "“In these dark times, we need to come together in unity.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“The family he has left behind will have the full support of the government.”"]** — Mówca: **Player**
> "“The family he has left behind will have the full support of the government.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“I am granting him the title, 'Hero of Sordland'.”"*)
  - -> `[36]` (*Player: "“I am granting him the military rank of Major.”"*)
  - -> `[37]` (*Player: "“In these dark times, we need to come together in unity.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I am granting him the military rank of Major.”"]** — Mówca: **Player**
> "“I am granting him the military rank of Major.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[34]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“May his memory last forever.”"*)
  - -> `[38]` (*Player: "“Farewell, brother.”"*)
  - -> `[39]` (*Player: "“Thank you for your service, Serge.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“In these dark times, we need to come together in unity.”"]** — Mówca: **Player**
> "“In these dark times, we need to come together in unity.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player), `[34]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“May his memory last forever.”"*)
  - -> `[38]` (*Player: "“Farewell, brother.”"*)
  - -> `[39]` (*Player: "“Thank you for your service, Serge.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Farewell, brother.”"]** — Mówca: **Player**
> "“Farewell, brother.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The casket started to be lowered."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Thank you for your service, Serge.”"]** — Mówca: **Player**
> "“Thank you for your service, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The casket started to be lowered."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“May his memory last forever.”"]** — Mówca: **Player**
> "“May his memory last forever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[36]` (Player), `[37]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The casket started to be lowered."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The casket started to be lowered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_GoodLuckCharm == true"*)

### Węzeł `[42]`
Mówca: **Narrator**
> "I put my hand in my pocket and pulled out the watch Serge once gave me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I recalled that he said it protected his father from the ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_GoodLuckCharm == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_GoodLuckCharm == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_GoodLuckCharm == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_GoodLuckCharm == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "I put my hand in my pocket and pulled out the watch Serge..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_GoodLuckCharm == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_GoodLuckCharm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the casket hit the ground, mourners sprinkled handfuls..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I recalled that he said it protected his father from the evil of this world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "At first I didn't believe it, but now I did."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "At first I didn't believe it, but now I did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Italic: "Keep the watch."*)
  - -> `[49]` (*Player_Italic: "Give the watch to Serge's son."*)
  - -> `[50]` (*Player_Italic: "Place the watch on his grave."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Keep the watch."]** — Mówca: **Player_Italic**
> "I kept the watch and put it back in my pocket."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the casket hit the ground, mourners sprinkled handfuls..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Give the watch to Serge's son."]** — Mówca: **Player_Italic**
> "I walked over to Serge's son and gave him the watch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_GoodLuckCharm = false"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Place the watch on his grave."]** — Mówca: **Player_Italic**
> "I placed the watch on Serge's grave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_GoodLuckCharm = false"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_GoodLuckCharm = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "DisableCollectionItem("CollectionItem_Pocketwatch")"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "As the casket hit the ground, mourners sprinkled handfuls of dirt on Serge's grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "His wife and children hugged each other."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "His wife and children hugged each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "I realized it was time for me to leave."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "I realized it was time for me to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "As I turned my back on Serge's final resting place, I loo..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "It started pouring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_Personal_SergeFuneral = true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_Personal_SergeFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_SergeWolkner = fa..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Wipe their tears."]** — Mówca: **Player_Italic**
> "I wiped their tears."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“Your father was a great man. Don't ever forget that.”"*)
  - -> `[61]` (*Player: "“It's okay to cry. Let it all out.”"*)
  - -> `[66]` (*Player: "“You must be strong.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Pat them on their heads."]** — Mówca: **Player_Italic**
> "I patted them on their heads."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“Your father was a great man. Don't ever forget that.”"*)
  - -> `[61]` (*Player: "“It's okay to cry. Let it all out.”"*)
  - -> `[66]` (*Player: "“You must be strong.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Give them a hug."]** — Mówca: **Player_Italic**
> "I gave them a hug."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“Your father was a great man. Don't ever forget that.”"*)
  - -> `[61]` (*Player: "“It's okay to cry. Let it all out.”"*)
  - -> `[66]` (*Player: "“You must be strong.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Your father was a great man. Don't ever forget that.”"]** — Mówca: **Player**
> "“Your father was a great man. Don't ever forget that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Italic), `[58]` (Player_Italic), `[59]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "They were too young to experience the pain of losing a fa..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“It's okay to cry. Let it all out.”"]** — Mówca: **Player**
> "“It's okay to cry. Let it all out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Italic), `[58]` (Player_Italic), `[59]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "They were too young to experience the pain of losing a fa..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Ms. Wolkner. I will never forget your husband's service and his heroic sacrifice.""]** — Mówca: **Player**
> "“Ms. Wolkner. I will never forget your husband's service and his heroic sacrifice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I am so sorry, Suzan.”"]** — Mówca: **Player**
> "“I am so sorry, Suzan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“My condolences.”"]** — Mówca: **Player**
> "“My condolences.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "We hugged and she cried on my shoulder. I crouched next to Serge's children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“You must be strong.”"]** — Mówca: **Player**
> "“You must be strong.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Italic), `[58]` (Player_Italic), `[59]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "They were too young to experience the pain of losing a fa..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "As I turned my back on Serge's final resting place, I looked up at the dark clouds above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "It started pouring."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "My new driver opened the door. I had forgotten his name already."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He offered to carry my umbrella."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseG..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_Funeral_Attend == true && (Bas..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true  and  (Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true  or   Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I was losing track of how many funerals I had attended by..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true  and  (Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true  or   Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "My new driver opened the door. I had forgotten his name a..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "I was losing track of how many funerals I had attended by now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "My new driver opened the door. I had forgotten his name a..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Under the watchful eyes of security officers in military ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Under the watchful eyes of security officers, I started w..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Under the watchful eyes of security officers in military uniforms, I started walking amidst the gravestones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "A small crowd of family and friends gathered around the f..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_ST_Serge_Funeral = true; BaseGameSupport.News_Turn10_LT_Serge_Funeral = true; BaseGameSupport.News_Turn10_HP_Serge_Funeral = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_Serge_Funeral"] = true;
Variable["BaseGameSupport.News_Turn10_LT_Serge_Funeral"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Serge_Funeral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_SergeWolkner = false; BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_ST_Serge_Funeral = true; Base..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableCollectionItem("CollectionItem_Pocketwatch")`
- **Efekt skryptowy (`userScript`):** `DisableCollectionItem("CollectionItem_Pocketwatch");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As the casket hit the ground, mourners sprinkled handfuls..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Rain");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Rain");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was raining as my car came to a stop by the Holsord Gr..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "She was wearing an elegant black dress and a beautiful diamond necklace. She thanked me for everything I'd done for her family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I wish I could have done more. He deserved it.""*)
  - -> `[89]` (*Player: ""Don't worry. I'll make sure you and your children are st..."*)
  - -> `[63]` (*Player: "“I am so sorry, Suzan.”"*)
  - -> `[62]` (*Player: "“Ms. Wolkner. I will never forget your husband's service ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "She was wearing an elegant black dress and a beautiful di..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Acquaintance == true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "She was wearing a simple but well-fitting black dress and holding a portrait of Serge in her arms. She thanked me for everything I'd done for her children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I wish I could have done more. He deserved it.""*)
  - -> `[94]` (*Player: ""Don't worry. I'll make sure the children are still well ..."*)
  - -> `[63]` (*Player: "“I am so sorry, Suzan.”"*)
  - -> `[62]` (*Player: "“Ms. Wolkner. I will never forget your husband's service ..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "She was wearing a simple but well-fitting black dress and holding a portrait of Serge in her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“I am so sorry, Suzan.”"*)
  - -> `[62]` (*Player: "“Ms. Wolkner. I will never forget your husband's service ..."*)
  - -> `[64]` (*Player: "“My condolences.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I'll make sure you and your children are still well cared for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Acquaintance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Acquaintance == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Acquaintance == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Acquaintance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Acquaintance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "She was wearing a simple but well-fitting black dress and..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Acquaintance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Acquaintance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "She was wearing a simple but well-fitting black dress and..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish I could have done more. He deserved it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I'll make sure the children are still well cared for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We hugged and she cried on my shoulder. I crouched next t..."*)
