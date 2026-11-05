# Sordland/Turn07/WhatAreYourIntentions

- **ID konwersacji:** `110`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/110_WhatAreYourIntentions.md`
- **Liczba węzłów dialogowych:** 119
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Law_Veto_Removed`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[111] Sordland/Turn07/WhatIsYourNextMove** (../Turn_07/111_WhatIsYourNextMove.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""I'm trying not to lose the support of the people. This is their will.""** | `[6]` **Isabel Edmonds**: ""Tell me, Mr. President. What ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Isabel Edmonds**: ""Then why would you not include ..."<br>`[65]` **Isabel Edmonds**: ""Oh yes. People wanted the Supre..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""I know that I can't do a lot. But I'm doing my best to start the change.""** | `[6]` **Isabel Edmonds**: ""Tell me, Mr. President. What ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Isabel Edmonds**: ""I see your intentions but this ..."<br>`[47]` **Isabel Edmonds**: ""Starting a change by eliminatin..."<br>*(oraz 1 innych odgałęzień)* |
| `[9]` | **""I only want a strong Sordland.""** | `[6]` **Isabel Edmonds**: ""Tell me, Mr. President. What ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Isabel Edmonds**: ""Strong? You are weakening both ..."<br>`[112]` **Isabel Edmonds**: ""Perhaps this proposal is only m..."<br>*(oraz 1 innych odgałęzień)* |
| `[10]` | **""We need a better democracy. That's all I'm striving for.""** | `[6]` **Isabel Edmonds**: ""Tell me, Mr. President. What ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Isabel Edmonds**: ""I see your intentions but this ..."<br>`[28]` **Isabel Edmonds**: ""Better democracy by eliminating..."<br>*(oraz 2 innych odgałęzień)* |
| `[12]` | **""The threshold is what keeps the extremist parties outside.""** | `[66]` **Isabel Edmonds**: ""Maybe you only care about a cer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Isabel Edmonds**: ""Well, that's true to some exten..." |
| `[13]` | **""The Assembly is the most democratic institution that we have.""** | `[107]` **Isabel Edmonds**: ""I don't agree with this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Isabel Edmonds**: ""But what happens when they have..." |
| `[27]` | **""We must eventually transform into the parliamentary system.""** | `[15]` **Isabel Edmonds**: ""But what happens when they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Isabel Edmonds**: ""So is that your intention after..." |
| `[35]` | **""The MP's are elected. If they have a majority, then we must respect that decision.""** | `[69]` **Isabel Edmonds**: ""But this will also result in th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[34]` **Isabel Edmonds**: ""I completely disagree with that..." |
| `[37]` | **""I think that era is closing. We have many popular parties now.""** | `[69]` **Isabel Edmonds**: ""But this will also result in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Isabel Edmonds**: ""That's not really convincing, i..." |
| `[41]` | **""You are right to have concerns. But this is the way forward.""** | `[69]` **Isabel Edmonds**: ""But this will also result in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Isabel Edmonds**: ""That's not really convincing, i..." |
| `[48]` | **""There are still checks and balances.""** | `[15]` **Isabel Edmonds**: ""But what happens when they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Isabel Edmonds**: ""I don't see any in this proposal."" |
| `[68]` | **""Not my intention. But if there is demand, we must consider it.""** | `[91]` **Isabel Edmonds**: ""Is that one of your intentions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Isabel Edmonds**: ""Of course it's not your intenti..." |
| `[77]` | **""Is the elective dictatorship we have is better?""** | `[15]` **Isabel Edmonds**: ""But what happens when they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Isabel Edmonds**: ""Is that what you call it?"" |
| `[80]` | **""I thought you would agree to that. I believed that respectable Justices like you ..."** | `[92]` **Isabel Edmonds**: ""Why did you include that in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Isabel Edmonds**: ""Look. I am in opposition to the..." |
| `[81]` | **""It depends on the circumstances.""** | `[91]` **Isabel Edmonds**: ""Is that one of your intentions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Isabel Edmonds**: ""What a convincing answer, Mr. P..." |
| `[84]` | **""This will pave the way for a parliamentary democracy.""** | `[107]` **Isabel Edmonds**: ""I don't agree with this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Isabel Edmonds**: ""So is that your intention after..." |
| `[88]` | **""Yes. We must eventually decrease the threshold.""** | `[91]` **Isabel Edmonds**: ""Is that one of your intentions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Isabel Edmonds**: ""I see."" |
| `[89]` | **""Yes. That is the future for Sordland.""** | `[24]` **Isabel Edmonds**: ""So is that your intention after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Isabel Edmonds**: ""Maybe you are right about that...." |
| `[93]` | **""I thought the Court could see reason.""** | `[92]` **Isabel Edmonds**: ""Why did you include that in the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[85]` **Isabel Edmonds**: ""How? This is an attack against ..." |
| `[95]` | **""I think the presidential system is what damaged our republic.""** | `[24]` **Isabel Edmonds**: ""So is that your intention after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Isabel Edmonds**: ""Maybe you are right about that...." |
| `[99]` | **""I don't think this is the right time for such reform. It can create a political c..."** | `[66]` **Isabel Edmonds**: ""Maybe you only care about a cer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Isabel Edmonds**: ""Well, that's true to some exten..." |
| `[101]` | **""That can be addressed later.""** | `[66]` **Isabel Edmonds**: ""Maybe you only care about a cer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Isabel Edmonds**: ""Is that one of your intentions ..." |
| `[103]` | **""Sometimes that's the sad reality. I need to care for myself and the party too.""** | `[66]` **Isabel Edmonds**: ""Maybe you only care about a cer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Isabel Edmonds**: ""I like your honesty, Mr. Presid..." |
| `[105]` | **""The Assembly has long been overshadowed. They need all the power to make laws.""** | `[107]` **Isabel Edmonds**: ""I don't agree with this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Isabel Edmonds**: ""But what happens when they have..." |
| `[106]` | **""That's not my intention but my hope for the future.""** | `[24]` **Isabel Edmonds**: ""So is that your intention after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Isabel Edmonds**: ""Interesting. But I am not sure ..." |
| `[108]` | **""I've had to take my chances. We need it to clean up the Old Guard.""** | `[92]` **Isabel Edmonds**: ""Why did you include that in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Isabel Edmonds**: ""Look. I am in opposition to the..." |

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
  - -> `[6]` (*Isabel Edmonds: ""Tell me, Mr. President. What are your real intentions?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Isabel Edmonds: ""Oh yes. People wanted the Supreme Court Justices to be i..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && (BaseGam..."*)

### Węzeł `[6]`
Mówca: **Isabel Edmonds**
> ""Tell me, Mr. President. What are your real intentions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""We need a better democracy. That's all I'm striving for.""*)
  - -> `[8]` (*Player: ""I know that I can't do a lot. But I'm doing my best to s..."*)
  - -> `[9]` (*Player: ""I only want a strong Sordland.""*)
  - -> `[7]` (*Player: ""I'm trying not to lose the support of the people. This i..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I'm trying not to lose the support of the people. This is their will.""]** — Mówca: **Player**
> ""I'm trying not to lose the support of the people. This is their will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true || BaseGame..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I know that I can't do a lot. But I'm doing my best to start the change.""]** — Mówca: **Player**
> ""I know that I can't do a lot. But I'm doing my best to start the change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""I only want a strong Sordland.""]** — Mówca: **Player**
> ""I only want a strong Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""We need a better democracy. That's all I'm striving for.""]** — Mówca: **Player**
> ""We need a better democracy. That's all I'm striving for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[11]`
Mówca: **Isabel Edmonds**
> ""I see your intentions but this is not the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Isabel Edmonds: ""You are giving the Assembly all the authority with this ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""The threshold is what keeps the extremist parties outside.""]** — Mówca: **Player**
> ""The threshold is what keeps the extremist parties outside the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Isabel Edmonds: ""Well, that's true to some extent. Don't get me wrong, I ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""The Assembly is the most democratic institution that we have.""]** — Mówca: **Player**
> ""The Assembly is the most democratic institution that we have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Isabel Edmonds: ""But what happens when they have no checks on them?""*)

### Węzeł `[14]`
Mówca: **Narrator**
> "She smiled a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Isabel Edmonds: ""I guess it's a fitting description.""*)

### Węzeł `[15]`
Mówca: **Isabel Edmonds**
> ""But what happens when they have no checks on them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""Is the elective dictatorship we have is better?""*)
  - -> `[27]` (*Player: ""We must eventually transform into the parliamentary syst..."*)
  - -> `[48]` (*Player: ""There are still checks and balances.""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Isabel Edmonds: ""You are giving the Assembly all the authority with this ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Isabel Edmonds: ""Better democracy by eliminating the Justices whenever yo..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && (BaseGam..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Isabel Edmonds: ""I see your intentions but this is not the way forward.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Isabel Edmonds: ""I completely disagree with that. Not all decisions made ..."*)

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""So is that your intention after all? Bringing parliamentary democracy to Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""Yes. That is the future for Sordland.""*)
  - -> `[95]` (*Player: ""I think the presidential system is what damaged our repu..."*)
  - -> `[106]` (*Player: ""That's not my intention but my hope for the future.""*)

### Węzeł `[25]`
Mówca: **Isabel Edmonds**
> ""You are giving the Assembly all the authority with this proposal with no checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Isabel Edmonds: ""I don't agree with this.""*)

### Węzeł `[26]`
Mówca: **Isabel Edmonds**
> ""That's not really convincing, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We must eventually transform into the parliamentary system.""]** — Mówca: **Player**
> ""We must eventually transform into the parliamentary system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Isabel Edmonds: ""So is that your intention after all? Bringing parliament..."*)

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""Better democracy by eliminating the Justices whenever you want? By binding the Court to the Assembly to do their bidding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> ""The Constitution must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""I don't see how this proposal democratizes anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && (BaseGam..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && (BaseG..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Isabel Edmonds: ""I don't see how this proposal democratizes anything.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Isabel Edmonds: ""For some reason, I doubt that.""*)

### Węzeł `[34]`
Mówca: **Isabel Edmonds**
> ""I completely disagree with that. Not all decisions made by the majority are supposed to be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Isabel Edmonds: ""The Constitution must be respected.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""The MP's are elected. If they have a majority, then we must respect that decision.""]** — Mówca: **Player**
> ""The MP's are elected. If they have a majority, then we must respect that decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[36]`
Mówca: **Isabel Edmonds**
> ""For some reason, I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""I think that era is closing. We have many popular parties now.""]** — Mówca: **Player**
> ""I think that era is closing. We have many popular parties now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Isabel Edmonds: ""That's not really convincing, is it?""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Isabel Edmonds: ""I see your intentions but this is not the way forward.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You are right to have concerns. But this is the way forward.""]** — Mówca: **Player**
> ""You are right to have concerns. But this is the way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Isabel Edmonds: ""That's not really convincing, is it?""*)

### Węzeł `[42]`
Mówca: **Isabel Edmonds**
> ""...But let's say this proposal goes through...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Isabel Edmonds: ""Starting a change by eliminating the Justices whenever y..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Isabel Edmonds: ""The proposal doesn't contain any democratic reforms abou..."*)

### Węzeł `[47]`
Mówca: **Isabel Edmonds**
> ""Starting a change by eliminating the Justices whenever you want? Is this the change?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Isabel Edmonds: ""Why did you include that in the proposal, knowing that y..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""There are still checks and balances.""]** — Mówca: **Player**
> ""There are still checks and balances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Isabel Edmonds: ""I don't see any in this proposal.""*)

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Isabel Edmonds: ""Strong? You are weakening both the executive and the jud..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[55]`
Mówca: **Isabel Edmonds**
> ""Strong? You are weakening both the executive and the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[56]`
Mówca: **Isabel Edmonds**
> ""I don't see any in this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[57]`
Mówca: **Isabel Edmonds**
> ""I don't see how this proposal helps with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true || BaseGame..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == true || BaseGa..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Isabel Edmonds: ""Then why would you not include a decrease in our electio..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[62]`
Mówca: **Isabel Edmonds**
> ""Maybe you are right about that. But I still don't think if this proposal would help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[63]`
Mówca: **Isabel Edmonds**
> ""Then why would you not include a decrease in our election threshold that everybody outside of your own party finds ridiculous?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Isabel Edmonds: ""Maybe you only care about a certain part of the populati..."*)

### Węzeł `[64]`
Mówca: **Isabel Edmonds**
> ""I like your honesty, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[65]`
Mówca: **Isabel Edmonds**
> ""Oh yes. People wanted the Supreme Court Justices to be impeached by the Assembly whenever they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Isabel Edmonds: ""I am sure this is what takes up everybody's mind.""*)

### Węzeł `[66]`
Mówca: **Isabel Edmonds**
> ""Maybe you only care about a certain part of the population, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""The threshold is what keeps the extremist parties outside.""*)
  - -> `[99]` (*Player: ""I don't think this is the right time for such reform. It..."*)
  - -> `[101]` (*Player: ""That can be addressed later.""*)
  - -> `[103]` (*Player: ""Sometimes that's the sad reality. I need to care for mys..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Not my intention. But if there is demand, we must consider it.""]** — Mówca: **Player**
> ""Not my intention. But if there is demand, we must consider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Isabel Edmonds: ""Of course it's not your intention.""*)

### Węzeł `[69]`
Mówca: **Isabel Edmonds**
> ""But this will also result in the same, Mr. President. What happens if a party holds an absolute majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""You are right to have concerns. But this is the way forw..."*)
  - -> `[37]` (*Player: ""I think that era is closing. We have many popular partie..."*)
  - -> `[35]` (*Player: ""The MP's are elected. If they have a majority, then we m..."*)

### Węzeł `[70]`
Mówca: **Isabel Edmonds**
> ""I am sure this is what takes up everybody's mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[71]`
Mówca: **Isabel Edmonds**
> ""I guess it's a fitting description.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Isabel Edmonds: ""But this will also result in the same, Mr. President. Wh..."*)

### Węzeł `[72]`
Mówca: **Isabel Edmonds**
> ""I don't find it believable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[73]`
Mówca: **Isabel Edmonds**
> ""Interesting. But I am not sure if this proposal would help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Isabel Edmonds: ""Maybe you only care about a certain part of the populati..."*)

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""Is that what you call it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "She smiled a little."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Isabel Edmonds: ""Why did you include that in the proposal, knowing that y..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Is the elective dictatorship we have is better?""]** — Mówca: **Player**
> ""Is the elective dictatorship we have is better?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Isabel Edmonds: ""Is that what you call it?""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[79]`
Mówca: **Isabel Edmonds**
> ""Of course it's not your intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Isabel Edmonds: ""I like your honesty, Mr. President.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""I thought you would agree to that. I believed that respectable Justices like you are against the Old Guard.""]** — Mówca: **Player**
> ""I thought you would agree to that. I believed that respectable Justices like you are against the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Isabel Edmonds: ""Look. I am in opposition to them and definitely stand ag..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""It depends on the circumstances.""]** — Mówca: **Player**
> ""It depends on the circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Isabel Edmonds: ""What a convincing answer, Mr. President.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Isabel Edmonds: ""How? This is an attack against the Court...""*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""This will pave the way for a parliamentary democracy.""]** — Mówca: **Player**
> ""This will pave the way for a parliamentary democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Isabel Edmonds: ""So is that your intention after all? Bringing parliament..."*)

### Węzeł `[85]`
Mówca: **Isabel Edmonds**
> ""How? This is an attack against the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Isabel Edmonds: ""Why did you include that in the proposal, knowing that y..."*)

### Węzeł `[87]`
Mówca: **Isabel Edmonds**
> ""Look. I am in opposition to them and definitely stand against their dominance. But this is not the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Yes. We must eventually decrease the threshold.""]** — Mówca: **Player**
> ""Yes. We must eventually decrease the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Yes. That is the future for Sordland.""]** — Mówca: **Player**
> ""Yes. That is the future for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Isabel Edmonds: ""Maybe you are right about that. But I still don't think ..."*)

### Węzeł `[90]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[91]`
Mówca: **Isabel Edmonds**
> ""Is that one of your intentions then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: ""Yes. We must eventually decrease the threshold.""*)
  - -> `[81]` (*Player: ""It depends on the circumstances.""*)
  - -> `[68]` (*Player: ""Not my intention. But if there is demand, we must consid..."*)

### Węzeł `[92]`
Mówca: **Isabel Edmonds**
> ""Why did you include that in the proposal, knowing that you need our vote?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""I've had to take my chances. We need it to clean up the ..."*)
  - -> `[80]` (*Player: ""I thought you would agree to that. I believed that respe..."*)
  - -> `[93]` (*Player: ""I thought the Court could see reason.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I thought the Court could see reason.""]** — Mówca: **Player**
> ""I thought the Court could see reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[94]`
Mówca: **Isabel Edmonds**
> ""What a convincing answer, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I think the presidential system is what damaged our republic.""]** — Mówca: **Player**
> ""I think the presidential system is what damaged our republic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Isabel Edmonds: ""Maybe you are right about that. But I still don't think ..."*)

### Węzeł `[96]`
Mówca: **Isabel Edmonds**
> ""The proposal doesn't contain any democratic reforms about the elections, decrees nor the minister procedures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Isabel Edmonds: ""You can't just throw words like that.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I don't think this is the right time for such reform. It can create a political crisis.""]** — Mówca: **Player**
> ""I don't think this is the right time for such reform. It can create a political crisis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Isabel Edmonds: ""Well, that's true to some extent. Don't get me wrong, I ..."*)

### Węzeł `[100]`
Mówca: **Isabel Edmonds**
> ""I actually agree with that. We can't let the Malenyevist nor separatist parties to enter the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""That can be addressed later.""]** — Mówca: **Player**
> ""That can be addressed later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Isabel Edmonds: ""Is that one of your intentions then?""*)

### Węzeł `[102]`
Mówca: **Isabel Edmonds**
> ""You can't just throw words like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Sometimes that's the sad reality. I need to care for myself and the party too.""]** — Mówca: **Player**
> ""Sometimes that's the sad reality. I need to care for myself and the party too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Isabel Edmonds: ""I like your honesty, Mr. President.""*)

### Węzeł `[104]`
Mówca: **Isabel Edmonds**
> ""Well, that's true to some extent. Don't get me wrong, I am not against the current threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Isabel Edmonds: ""I actually agree with that. We can't let the Malenyevist..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""The Assembly has long been overshadowed. They need all the power to make laws.""]** — Mówca: **Player**
> ""The Assembly has long been overshadowed. They need all the power to make laws.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Isabel Edmonds: ""But what happens when they have no checks on them?""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""That's not my intention but my hope for the future.""]** — Mówca: **Player**
> ""That's not my intention but my hope for the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Isabel Edmonds: ""Interesting. But I am not sure if this proposal would he..."*)

### Węzeł `[107]`
Mówca: **Isabel Edmonds**
> ""I don't agree with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""The Assembly has long been overshadowed. They need all t..."*)
  - -> `[13]` (*Player: ""The Assembly is the most democratic institution that we ..."*)
  - -> `[84]` (*Player: ""This will pave the way for a parliamentary democracy.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I've had to take my chances. We need it to clean up the Old Guard.""]** — Mówca: **Player**
> ""I've had to take my chances. We need it to clean up the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Isabel Edmonds: ""Look. I am in opposition to them and definitely stand ag..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Isabel Edmonds: ""Perhaps this proposal is only making you stronger. And a..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Isabel Edmonds: ""I don't see how this proposal helps with that.""*)

### Węzeł `[112]`
Mówca: **Isabel Edmonds**
> ""Perhaps this proposal is only making you stronger. And a little too strong at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""...But let's say this proposal goes through...""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && (BaseGam..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && (BaseG..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Isabel Edmonds: ""Oh yes. People wanted to make you king.""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Isabel Edmonds: ""I don't find it believable.""*)

### Węzeł `[117]`
Mówca: **Isabel Edmonds**
> ""Oh yes. People wanted to make you king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Isabel Edmonds: ""Maybe you only care about a certain part of the populati..."*)
