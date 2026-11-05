# Sordland/Turn09/Personal_PetrFuneral

- **ID konwersacji:** `187`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/187_Personal_PetrFuneral.md`
- **Liczba węzłów dialogowych:** 146
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[28]** Evelyn Vectern
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral`
- `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral`
- `BaseGameSupport.News_Turn09_HP_Petr_StateFuneral`
- `BaseGameSupport.News_Turn09_R_Petr_StateFuneral`
- `GameCondition.Turn09_Personal_PetrFuneral`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“He killed himself, Deana.""** | `[11]` **Deana**: "“Papa? Tell me the truth!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Deana**: "“But... but why?"" |
| `[12]` | **""He... fell. It was an accident.""** | `[11]` **Deana**: "“Papa? Tell me the truth!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Deana**: "“Like when I fall off my bike?”" |
| `[13]` | **"“You will understand when you are older.”"** | `[11]` **Deana**: "“Papa? Tell me the truth!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Deana**: "“That's not fair. I'm almost 12."" |
| `[18]` | **""I can't sugar-coat reality for her forever, Monica.""** | `[20]` **Monica**: "“It's better to remember Uncle P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "The driver's window rolled down." |
| `[19]` | **"“Your mother is right, Deana. Sorry.”"** | `[20]` **Monica**: "“It's better to remember Uncle P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "The driver's window rolled down." |
| `[21]` | **"Do not reply."** | `[20]` **Monica**: "“It's better to remember Uncle P..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "The driver's window rolled down." |
| `[32]` | **"“My condolences.”"** | `[30]` **Narrator**: "They hugged once again. Evelyn w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Evelyn Vectern**: "“Thank you, Anton.”" |
| `[33]` | **"Hug her."** | `[30]` **Narrator**: "They hugged once again. Evelyn w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Evelyn Vectern**: "“I know there's nothing either o..." |
| `[36]` | **"“I can't believe he's gone.”"** | `[30]` **Narrator**: "They hugged once again. Evelyn w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Evelyn Vectern**: "“I know there's nothing either o..." |
| `[46]` | **"“Today, we mourn Petr Vectern. The Fourth Vice President of Sordland and...”"** | `[43]` **Narrator**: "One of the soldiers took the fla..."<br>`[45]` **Narrator**: "The priest completed his ceremon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Player**: "“...a true Sord who strived to a..."<br>`[48]` **Player**: "“...a very successful statesman ..."<br>*(oraz 1 innych odgałęzień)* |
| `[47]` | **"“...a true Sord who strived to achieve the best for his country against all odds.”"** | `[46]` **Player**: "“Today, we mourn Petr Vectern. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Player**: "“God's word says no man can be p..."<br>`[52]` **Player**: "“We drank together. Cried togeth..."<br>*(oraz 1 innych odgałęzień)* |
| `[48]` | **"“...a very successful statesman with whom I worked very closely over many years.""** | `[46]` **Player**: "“Today, we mourn Petr Vectern. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Player**: "“God's word says no man can be p..."<br>`[52]` **Player**: "“We drank together. Cried togeth..."<br>*(oraz 1 innych odgałęzień)* |
| `[49]` | **"“...my brother. Our bond was not a bond of blood. It was something stronger. It wa..."** | `[46]` **Player**: "“Today, we mourn Petr Vectern. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Player**: "“God's word says no man can be p..."<br>`[52]` **Player**: "“We drank together. Cried togeth..."<br>*(oraz 1 innych odgałęzień)* |
| `[50]` | **"“He was there with me from the very beginning. He swore he would support our cause..."** | `[47]` **Player**: "“...a true Sord who strived to a..."<br>`[48]` **Player**: "“...a very successful statesman ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player**: "“Despite his unconscionable acti..."<br>`[53]` **Player**: "“Though we did not always see ey..."<br>*(oraz 1 innych odgałęzień)* |
| `[51]` | **"“God's word says no man can be perfect. And Petr was certainly no exception.”"** | `[47]` **Player**: "“...a true Sord who strived to a..."<br>`[48]` **Player**: "“...a very successful statesman ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player**: "“Despite his unconscionable acti..."<br>`[53]` **Player**: "“Though we did not always see ey..."<br>*(oraz 1 innych odgałęzień)* |
| `[52]` | **"“We drank together. Cried together. Laughed together. Fought together.”"** | `[47]` **Player**: "“...a true Sord who strived to a..."<br>`[48]` **Player**: "“...a very successful statesman ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player**: "“Despite his unconscionable acti..."<br>`[53]` **Player**: "“Though we did not always see ey..."<br>*(oraz 1 innych odgałęzień)* |
| `[53]` | **"“Though we did not always see eye to eye, I owe Petr everything. I wouldn't be Pre..."** | `[50]` **Player**: "“He was there with me from the v..."<br>`[51]` **Player**: "“God's word says no man can be p..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player**: "“The past is past. We must alway..."<br>`[56]` **Player**: "“The path he paved will go down ..."<br>*(oraz 1 innych odgałęzień)* |
| `[54]` | **"“Despite his unconscionable actions towards the very end of his life, I choose to ..."** | `[50]` **Player**: "“He was there with me from the v..."<br>`[51]` **Player**: "“God's word says no man can be p..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player**: "“The past is past. We must alway..."<br>`[56]` **Player**: "“The path he paved will go down ..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **"“We must all remember him not at his worst, but for the good deeds he has done.""** | `[50]` **Player**: "“He was there with me from the v..."<br>`[51]` **Player**: "“God's word says no man can be p..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player**: "“The past is past. We must alway..."<br>`[56]` **Player**: "“The path he paved will go down ..."<br>*(oraz 1 innych odgałęzień)* |
| `[56]` | **"“The path he paved will go down in history.”"** | `[53]` **Player**: "“Though we did not always see ey..."<br>`[54]` **Player**: "“Despite his unconscionable acti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Player**: "“Morning shall come!”"<br>`[59]` **Player**: "“Thank you.”"<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"“Never before Sordland had a Vice President like Petr. Never again will it.""** | `[53]` **Player**: "“Though we did not always see ey..."<br>`[54]` **Player**: "“Despite his unconscionable acti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Player**: "“Morning shall come!”"<br>`[59]` **Player**: "“Thank you.”"<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **"“The past is past. We must always look to the future. That's what he would've want..."** | `[53]` **Player**: "“Though we did not always see ey..."<br>`[54]` **Player**: "“Despite his unconscionable acti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Player**: "“Morning shall come!”"<br>`[59]` **Player**: "“Thank you.”"<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"“Thank you.”"** | `[56]` **Player**: "“The path he paved will go down ..."<br>`[57]` **Player**: "“Never before Sordland had a Vic..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Amid the applause, I went back t..." |
| `[60]` | **"“Farewell brother. You will be missed.”"** | `[56]` **Player**: "“The path he paved will go down ..."<br>`[57]` **Player**: "“Never before Sordland had a Vic..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Amid the applause, I went back t..." |
| `[61]` | **"“Morning shall come!”"** | `[56]` **Player**: "“The path he paved will go down ..."<br>`[57]` **Player**: "“Never before Sordland had a Vic..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "Everyone in the crowd yelled: "V..." |
| `[78]` | **"“It's raining.”"** | `[77]` **Narrator**: "Surprised, I checked my face. My..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Narrator**: "She looked up to the sky." |
| `[79]` | **"“Yes.”"** | `[77]` **Narrator**: "Surprised, I checked my face. My..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Narrator**: "She hugged my leg." |
| `[80]` | **"“No, I'm not.”"** | `[77]` **Narrator**: "Surprised, I checked my face. My..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Monica**: "“Come on Deana. Let's go.”" |
| `[86]` | **"Leave a bottle of whiskey on the grave."** | `[85]` **Narrator**: "The coffin was fully lowered and..." | *Brak (Dostępna bezwarunkowo)* | `DisableCollectionItem("CollectionItem_WhiskeyBottle");` | `[88]` **Narrator**: "I stayed there by myself for ano..." |
| `[87]` | **"Leave."** | `[85]` **Narrator**: "The coffin was fully lowered and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "The sun finally set after painti..."<br>`[89]` **Narrator**: "The sun finally set after painti..." |
| `[104]` | **""Thank you, Serge.""** | `[103]` **Serge Wolkner**: ""My deepest condolences. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Serge went outside and opened ou..." |
| `[105]` | **""We weren't at the end.""** | `[103]` **Serge Wolkner**: ""My deepest condolences. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Serge went outside and opened ou..." |
| `[106]` | **""You're right. We were.""** | `[103]` **Serge Wolkner**: ""My deepest condolences. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "Serge went outside and opened ou..." |
| `[107]` | **""I know what you mean.""** | `[35]` **Evelyn Vectern**: "“I know there's nothing either o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Evelyn swallowed hard. Her eyes ..." |
| `[108]` | **""It's not your fault, Evelyn.""** | `[35]` **Evelyn Vectern**: "“I know there's nothing either o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Evelyn swallowed hard. Her eyes ..." |
| `[109]` | **""You shouldn't feel guilty. And neither should I.""** | `[35]` **Evelyn Vectern**: "“I know there's nothing either o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Evelyn swallowed hard. Her eyes ..." |
| `[115]` | **"Hug Monica."** | `[10]` **Narrator**: "She turned her head to look out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "She recoiled at my touch."<br>`[122]` **Narrator**: "She hugged me back tightly." |
| `[116]` | **"Hug Deana."** | `[10]` **Narrator**: "She turned her head to look out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Deana**: "“Papa? Tell me the truth!”" |
| `[117]` | **"Don't do anything."** | `[10]` **Narrator**: "She turned her head to look out ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Deana**: "“Papa? Tell me the truth!”" |

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
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our convoy pulled up to the gates of the Public Cemetery in Erlory -- Petr's hometown. Monica and Deana were beside me in the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Monica looked numb and empty. Deana appeared to be deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Evelyn Vectern", "Former Second Lad..."*)

### Węzeł `[5]`
Mówca: **Deana**
> "“But how did Uncle Petr die? Why won't anyone tell me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Monica looked like she was about to cry."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“He killed himself, Deana.""]** — Mówca: **Player**
> "“He killed himself, Deana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deana: "“But... but why?""*)

### Węzeł `[7]`
Mówca: **Monica**
> "“He...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Monica: "“It doesn't matter, sweetheart.”"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Monica looked like she was about to cry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Monica: "“He...”"*)

### Węzeł `[9]`
Mówca: **Monica**
> "“It doesn't matter, sweetheart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "She turned her head to look out the window, hiding her te..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "She turned her head to look out the window, hiding her tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Italic: "Hug Monica."*)
  - -> `[116]` (*Player_Italic: "Hug Deana."*)
  - -> `[117]` (*Player_Italic: "Don't do anything."*)

### Węzeł `[11]`
Mówca: **Deana**
> "“Papa? Tell me the truth!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“You will understand when you are older.”"*)
  - -> `[12]` (*Player: ""He... fell. It was an accident.""*)
  - -> `[6]` (*Player: "“He killed himself, Deana.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""He... fell. It was an accident.""]** — Mówca: **Player**
> ""He... fell. It was an accident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Deana: "“Like when I fall off my bike?”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“You will understand when you are older.”"]** — Mówca: **Player**
> "“You will understand when you are older.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deana: "“That's not fair. I'm almost 12.""*)

### Węzeł `[14]`
Mówca: **Deana**
> "“But... but why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Monica: "“Anton! She is still too young.”"*)

### Węzeł `[15]`
Mówca: **Deana**
> "“Like when I fall off my bike?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Monica: ""No, honey. Nothing like that.""*)

### Węzeł `[16]`
Mówca: **Deana**
> "“That's not fair. I'm almost 12.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The driver's window rolled down."*)

### Węzeł `[17]`
Mówca: **Monica**
> "“Anton! She is still too young.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Monica: "“It's better to remember Uncle Petr by the way he lived, ..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I can't sugar-coat reality for her forever, Monica.""]** — Mówca: **Player**
> ""I can't sugar-coat reality for her forever, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The driver's window rolled down."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Your mother is right, Deana. Sorry.”"]** — Mówca: **Player**
> "“Your mother is right, Deana. Sorry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The driver's window rolled down."*)

### Węzeł `[20]`
Mówca: **Monica**
> "“It's better to remember Uncle Petr by the way he lived, not by the way he died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“Your mother is right, Deana. Sorry.”"*)
  - -> `[18]` (*Player: ""I can't sugar-coat reality for her forever, Monica.""*)
  - -> `[21]` (*Player_Italic: "Do not reply."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply. Deana looked as confused as she had before."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The driver's window rolled down."*)

### Węzeł `[22]`
Mówca: **Monica**
> ""No, honey. Nothing like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The driver's window rolled down."*)

### Węzeł `[23]`
Mówca: **Serge Wolkner**
> "“We have arrived, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Serge Wolkner: ""My deepest condolences. I know you and Mr. Vectern were ..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The driver's window rolled down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Serge Wolkner: "“We have arrived, Mr. President.”"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Serge went outside and opened our door. As soon as we stepped out, camera flashes went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Evelyn Vectern was waiting for us. Upon seeing her, Monic..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Evelyn Vectern was waiting for us. Upon seeing her, Monica ran up to her and they hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Monica: "“Evelyn. I'm so sorry. How are you holding up?”"*)

### Węzeł `[27]`
Mówca: **Monica**
> "“Evelyn. I'm so sorry. How are you holding up?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Evelyn Vectern: "“So-so. It's hard to play the bereaved widow, knowing the..."*)

### Węzeł `[28]`
Mówca: **Evelyn Vectern**
> "“So-so. It's hard to play the bereaved widow, knowing the kind of man he really was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Evelyn Vectern: "“But still. We were married almost 20 years, Monica.”"*)

### Węzeł `[29]`
Mówca: **Evelyn Vectern**
> "“But still. We were married almost 20 years, Monica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Evelyn Vectern: "“And the way he died...It's just too...sudden.”"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "They hugged once again. Evelyn wiped her tears and patted Deana on the head before turning to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“My condolences.”"*)
  - -> `[36]` (*Player: "“I can't believe he's gone.”"*)
  - -> `[33]` (*Player_Italic: "Hug her."*)

### Węzeł `[31]`
Mówca: **Evelyn Vectern**
> "“And the way he died...It's just too...sudden.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "They hugged once again. Evelyn wiped her tears and patted..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“My condolences.”"]** — Mówca: **Player**
> "“My condolences.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Evelyn Vectern: "“Thank you, Anton.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I hugged her. She took my hands in hers as she pulled back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Evelyn Vectern: "“I know there's nothing either of us could have done. But..."*)

### Węzeł `[34]`
Mówca: **Evelyn Vectern**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Evelyn Vectern: "“I know there's nothing either of us could have done. But..."*)

### Węzeł `[35]`
Mówca: **Evelyn Vectern**
> "“I know there's nothing either of us could have done. But I still can't help feeling responsible for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""You shouldn't feel guilty. And neither should I.""*)
  - -> `[108]` (*Player: ""It's not your fault, Evelyn.""*)
  - -> `[107]` (*Player: ""I know what you mean.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I can't believe he's gone.”"]** — Mówca: **Player**
> "“I can't believe he's gone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Evelyn Vectern: "“I know there's nothing either of us could have done. But..."*)

### Węzeł `[37]`
Mówca: **Evelyn Vectern**
> "“All right. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "The four of us -- Evelyn, Monica, Deana and I -- took our places towards the front of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "From afar, we heard the sound of military boots approachi..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "From afar, we heard the sound of military boots approaching. A soldier was leading a group with a large framed photo of Petr in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Behind him followed other soldiers, marching alongside a ..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Behind him followed other soldiers, marching alongside a cart with a carved goat on the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "On top of the cart, wrapped in a Sordish flag, was the co..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "On top of the cart, wrapped in a Sordish flag, was the coffin of Petr Vectern. The Fourth Vice President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The group stopped in front of us. They lifted the coffin ..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The group stopped in front of us. They lifted the coffin up off the cart and laid it down on a platform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "One of the soldiers took the flag, folded it and presente..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "One of the soldiers took the flag, folded it and presented it to me. I walked behind the podium to deliver my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Today, we mourn Petr Vectern. The Fourth Vice President ..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "The crowd was sparse -- Petr hadn't had many friends left by the end. His father and brothers lifted the coffin on their shoulders and brought it to the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "The priest completed his ceremony. It was time for me to ..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "The priest completed his ceremony. It was time for me to make a speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Today, we mourn Petr Vectern. The Fourth Vice President ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Today, we mourn Petr Vectern. The Fourth Vice President of Sordland and...”"]** — Mówca: **Player**
> "“Today, we mourn Petr Vectern. The Fourth Vice President of Sordland and...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "“...a true Sord who strived to achieve the best for his c..."*)
  - -> `[48]` (*Player: "“...a very successful statesman with whom I worked very c..."*)
  - -> `[49]` (*Player: "“...my brother. Our bond was not a bond of blood. It was ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“...a true Sord who strived to achieve the best for his country against all odds.”"]** — Mówca: **Player**
> "“...a true Sord who strived to achieve the best for his country against all odds.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“God's word says no man can be perfect. And Petr was cert..."*)
  - -> `[52]` (*Player: "“We drank together. Cried together. Laughed together. Fou..."*)
  - -> `[50]` (*Player: "“He was there with me from the very beginning. He swore h..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“...a very successful statesman with whom I worked very closely over many years.""]** — Mówca: **Player**
> "“...a very successful statesman with whom I worked very closely over many years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“God's word says no man can be perfect. And Petr was cert..."*)
  - -> `[52]` (*Player: "“We drank together. Cried together. Laughed together. Fou..."*)
  - -> `[50]` (*Player: "“He was there with me from the very beginning. He swore h..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“...my brother. Our bond was not a bond of blood. It was something stronger. It was a bond of friendship and camaraderie.”"]** — Mówca: **Player**
> "“...my brother. Our bond was not a bond of blood. It was something stronger. It was a bond of friendship and camaraderie.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“God's word says no man can be perfect. And Petr was cert..."*)
  - -> `[52]` (*Player: "“We drank together. Cried together. Laughed together. Fou..."*)
  - -> `[50]` (*Player: "“He was there with me from the very beginning. He swore h..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“He was there with me from the very beginning. He swore he would support our cause until the end.”"]** — Mówca: **Player**
> "“He was there with me from the very beginning. He swore he would support our cause until the end.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player), `[48]` (Player), `[49]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“Despite his unconscionable actions towards the very end ..."*)
  - -> `[53]` (*Player: "“Though we did not always see eye to eye, I owe Petr ever..."*)
  - -> `[55]` (*Player: "“We must all remember him not at his worst, but for the g..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“God's word says no man can be perfect. And Petr was certainly no exception.”"]** — Mówca: **Player**
> "“God's word says no man can be perfect. And Petr was certainly no exception.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player), `[48]` (Player), `[49]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“Despite his unconscionable actions towards the very end ..."*)
  - -> `[53]` (*Player: "“Though we did not always see eye to eye, I owe Petr ever..."*)
  - -> `[55]` (*Player: "“We must all remember him not at his worst, but for the g..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“We drank together. Cried together. Laughed together. Fought together.”"]** — Mówca: **Player**
> "“We drank together. Cried together. Laughed together. Fought together.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player), `[48]` (Player), `[49]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“Despite his unconscionable actions towards the very end ..."*)
  - -> `[53]` (*Player: "“Though we did not always see eye to eye, I owe Petr ever..."*)
  - -> `[55]` (*Player: "“We must all remember him not at his worst, but for the g..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Though we did not always see eye to eye, I owe Petr everything. I wouldn't be President if not for him.”"]** — Mówca: **Player**
> "“Though we did not always see eye to eye, I owe Petr everything. I wouldn't be President if not for him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[51]` (Player), `[52]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“The past is past. We must always look to the future. Tha..."*)
  - -> `[56]` (*Player: "“The path he paved will go down in history.”"*)
  - -> `[57]` (*Player: "“Never before Sordland had a Vice President like Petr. Ne..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Despite his unconscionable actions towards the very end of his life, I choose to remember him as he was.”"]** — Mówca: **Player**
> "“Despite his unconscionable actions towards the very end of his life, I choose to remember him as he was.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[51]` (Player), `[52]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“The past is past. We must always look to the future. Tha..."*)
  - -> `[56]` (*Player: "“The path he paved will go down in history.”"*)
  - -> `[57]` (*Player: "“Never before Sordland had a Vice President like Petr. Ne..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“We must all remember him not at his worst, but for the good deeds he has done.""]** — Mówca: **Player**
> "“We must all remember him not at his worst, but for the good deeds he has done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[51]` (Player), `[52]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“The past is past. We must always look to the future. Tha..."*)
  - -> `[56]` (*Player: "“The path he paved will go down in history.”"*)
  - -> `[57]` (*Player: "“Never before Sordland had a Vice President like Petr. Ne..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“The path he paved will go down in history.”"]** — Mówca: **Player**
> "“The path he paved will go down in history.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player), `[54]` (Player), `[55]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“Morning shall come!”"*)
  - -> `[59]` (*Player: "“Thank you.”"*)
  - -> `[60]` (*Player: "“Farewell brother. You will be missed.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Never before Sordland had a Vice President like Petr. Never again will it.""]** — Mówca: **Player**
> "“Never before Sordland had a Vice President like Petr. Never again will it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player), `[54]` (Player), `[55]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“Morning shall come!”"*)
  - -> `[59]` (*Player: "“Thank you.”"*)
  - -> `[60]` (*Player: "“Farewell brother. You will be missed.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“The past is past. We must always look to the future. That's what he would've wanted.”"]** — Mówca: **Player**
> "“The past is past. We must always look to the future. That's what he would've wanted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player), `[54]` (Player), `[55]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“Morning shall come!”"*)
  - -> `[59]` (*Player: "“Thank you.”"*)
  - -> `[60]` (*Player: "“Farewell brother. You will be missed.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player), `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Amid the applause, I went back to join Monica and Deana."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Farewell brother. You will be missed.”"]** — Mówca: **Player**
> "“Farewell brother. You will be missed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player), `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Amid the applause, I went back to join Monica and Deana."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Morning shall come!”"]** — Mówca: **Player**
> "“Morning shall come!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player), `[57]` (Player), `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Everyone in the crowd yelled: "Victory is close!""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Everyone in the crowd yelled: "Victory is close!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Amid the applause, I went back to join Monica and Deana."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Amid the applause, I went back to join Monica and Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "As I walked past Evelyn, she mouthed the words: "Thank you"."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "As I walked past Evelyn, she mouthed the words: "Thank you"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Trumpets cut through the silence. Stern-looking soldiers ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The priest's voice cut through the silence. Everyone join..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Trumpets cut through the silence. Stern-looking soldiers formed a line and held their rifles in front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "One after another, ten shots rang out. With each shot, I ..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "One after another, ten shots rang out. With each shot, I shuddered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I had known Petr for almost 30 years. The time we spent t..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I felt a tug on my left arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Deana: "“Are you crying?”"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "The priest's voice cut through the silence. Everyone joined in the prayer he was chanting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Looking at the coffin, I shuddered."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Looking at the coffin, I shuddered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The coffin started to be lowered into the grave."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The coffin started to be lowered into the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I had known Petr for almost 30 years. The time we spent t..."*)

### Węzeł `[74]`
Mówca: **Deana**
> "“Are you crying?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Surprised, I checked my face. My eyes were wet."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "I had known Petr for almost 30 years. The time we spent together flashed back before my eyes. The good memories and bad ones. All of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "It didn't matter anymore. He was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I felt a tug on my left arm."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Surprised, I checked my face. My eyes were wet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“It's raining.”"*)
  - -> `[79]` (*Player: "“Yes.”"*)
  - -> `[80]` (*Player: "“No, I'm not.”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It's raining.”"]** — Mówca: **Player**
> "“It's raining.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "She looked up to the sky."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Yes.”"]** — Mówca: **Player**
> "“Yes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "She hugged my leg."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“No, I'm not.”"]** — Mówca: **Player**
> "“No, I'm not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Monica: "“Come on Deana. Let's go.”"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "She looked up to the sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Deana: "“Papa, it's not raini-.”"*)

### Węzeł `[82]`
Mówca: **Deana**
> "“Papa, it's not raini-.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Monica: "“Come on Deana. Let's go.”"*)

### Węzeł `[83]`
Mówca: **Monica**
> "“Come on Deana. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "The coffin was fully lowered and the tombstone placed. Th..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "She hugged my leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Monica: "“Come on Deana. Let's go.”"*)

### Węzeł `[85]`
Mówca: **Narrator**
> "The coffin was fully lowered and the tombstone placed. The crowd began dispersing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Italic: "Leave a bottle of whiskey on the grave."*)
  - -> `[87]` (*Player_Italic: "Leave."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "Leave a bottle of whiskey on the grave."]** — Mówca: **Player_Italic**
> "I left a bottle on the grave. Erlory 30-year-old. His favorite."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "DisableCollectionItem("CollectionItem_WhiskeyBottle")"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Leave."]** — Mówca: **Player_Italic**
> "I left as well."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == tr..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "I stayed there by myself for another half hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == tr..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "The sun finally set after painting the sky blood red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral = true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Our convoy pulled up to the gates of the National Cemeter..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Our convoy pulled up to the gates of the Public Cemetery ..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
Mówca: **Narrator**
> "Our convoy pulled up to the gates of the National Cemetery in Erlorly -- Petr's hometown. Monica and Deana were beside me in the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "The news of Petr's death had hit Franc especially hard. Rather than attend the funeral, he had taken a few days off from school to have time to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Monica looked numb and empty. Deana appeared to be deep i..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "The news of Petr's death had hit Franc especially hard. R..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "The news of Petr's death had hit Franc especially hard. R..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "The news of Petr's death had hit Franc especially hard. Rather than attend the funeral, he had taken a few days of personal leave from the army to have time to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Monica looked numb and empty. Deana appeared to be deep i..."*)

### Węzeł `[103]`
Mówca: **Serge Wolkner**
> ""My deepest condolences. I know you and Mr. Vectern were very close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""We weren't at the end.""*)
  - -> `[106]` (*Player: ""You're right. We were.""*)
  - -> `[104]` (*Player: ""Thank you, Serge.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Thank you, Serge.""]** — Mówca: **Player**
> ""Thank you, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Serge went outside and opened our door. As soon as we ste..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""We weren't at the end.""]** — Mówca: **Player**
> ""We weren't at the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Serge went outside and opened our door. As soon as we ste..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You're right. We were.""]** — Mówca: **Player**
> ""You're right. We were.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Serge went outside and opened our door. As soon as we ste..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I know what you mean.""]** — Mówca: **Player**
> ""I know what you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Evelyn swallowed hard. Her eyes filled with resolve."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""It's not your fault, Evelyn.""]** — Mówca: **Player**
> ""It's not your fault, Evelyn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Evelyn swallowed hard. Her eyes filled with resolve."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""You shouldn't feel guilty. And neither should I.""]** — Mówca: **Player**
> ""You shouldn't feel guilty. And neither should I.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Evelyn swallowed hard. Her eyes filled with resolve."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Evelyn swallowed hard. Her eyes filled with resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Evelyn Vectern: "“All right. Let's go.”"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "It didn't matter anymore. He was gone. Because of me."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "It didn't matter anymore. He was gone."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "It didn't matter anymore. He was gone. Because of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I felt a tug on my left arm."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Hug Monica."]** — Mówca: **Player_Italic**
> "I reached over to give Monica a hug."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < 0"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Hug Deana."]** — Mówca: **Player_Italic**
> "I wrapped an arm around my daughter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deana: "“Papa? Tell me the truth!”"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "Don't do anything."]** — Mówca: **Player_Italic**
> "I sat there, silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deana: "“Papa? Tell me the truth!”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < 0"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion < 0)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "She recoiled at my touch."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "She hugged me back tightly."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "She recoiled at my touch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deana: "“Papa? Tell me the truth!”"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "She hugged me back tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deana: "“Papa? Tell me the truth!”"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "The four of us -- Evelyn, Monica, Deana and I -- took our..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "The four of us -- Evelyn, Monica, Deana and I -- took our..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "The four of us -- Evelyn, Monica, Deana and I -- took our places in front of the Vectern family plot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "The crowd was sparse -- Petr hadn't had many friends left..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Petr_StateFuneral = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Petr_StateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral = true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == tr..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  and  Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The sun finally set after painting the sky blood red."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  and  Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The sun finally set after painting the sky blood red."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "The sun finally set after painting the sky blood red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia =..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Petr_StateFuneral = true;"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_Petr_StateFuneral = true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_R_Petr_StateFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_R_Petr_StateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Petr_StateFuneral = true;"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableCollectionItem("CollectionItem_WhiskeyBottle")`
- **Efekt skryptowy (`userScript`):** `DisableCollectionItem("CollectionItem_WhiskeyBottle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I stayed there by myself for another half hour."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Evelyn Vectern", "Former Second Lady");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Evelyn Vectern","Former Second Lady");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deana: "“But how did Uncle Petr die? Why won't anyone tell me?”"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
