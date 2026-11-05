# Sordland/Turn05/NOTES

- **ID konwersacji:** `69`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/069_NOTES.md`
- **Liczba węzłów dialogowych:** 73
- **Liczba wyborów gracza:** 17

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGameIsolated.Turn05_Admin_Mayor_Fire`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGameIsolated.Turn05_Admin_Mayor_Fire`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“By taking away his mayorship. Let's reach out to Lileas to have him removed.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;` | `[4]` **Lucian Galade**: "“Taking the fight to him is the ..." |
| `[12]` | **"“I want him fired for his actions, Lileas.”"** | `[8]` **Lileas Graf**: "“Yet I cannot possibly fathom ho..."<br>`[17]` **Lileas Graf**: "“How can I help?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lileas Graf**: "“I'm against administrative inte..."<br>`[18]` **Lileas Graf**: "“It could be accomplished, but i..." |
| `[13]` | **"“What do you think about removing him from his mayorship?”"** | `[8]` **Lileas Graf**: "“Yet I cannot possibly fathom ho..."<br>`[17]` **Lileas Graf**: "“How can I help?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lileas Graf**: "“I'm against administrative inte..."<br>`[18]` **Lileas Graf**: "“It could be accomplished, but i..." |
| `[21]` | **"“We can repair that trust in the near future. But right now we need this man weake..."** | `[18]` **Lileas Graf**: "“It could be accomplished, but i..."<br>`[19]` **Lileas Graf**: "“I'm against administrative inte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lileas Graf**: ""At the expense of yet more pres..." |
| `[23]` | **"“Your personal support and weight is needed. This needs to look as if it came from..."** | `[18]` **Lileas Graf**: "“It could be accomplished, but i..."<br>`[19]` **Lileas Graf**: "“I'm against administrative inte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lileas Graf**: "“I appreciate that you hold me i..." |
| `[26]` | **"“We'll keep in touch.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: "“Goodbye.”" |
| `[27]` | **"“Very much appreciated, Lileas.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: "“Goodbye.”" |
| `[30]` | **"“Maybe it will blow over. You might be right.”"** | `[67]` **Lileas Graf**: ""It's just one noisy mayor. Perh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lileas Graf**: "“With time it should. I must exc..." |
| `[32]` | **"“I don't see Iosef accepting this.”"** | `[37]` **Lileas Graf**: "“Yet I would gladly support you...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lileas Graf**: "“Well, he just might have to agr..." |
| `[34]` | **"“I haven't heard of this before.”"** | `[37]` **Lileas Graf**: "“Yet I would gladly support you...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lileas Graf**: "“I'm still working on the propos..." |
| `[38]` | **"“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"** | `[35]` **Lileas Graf**: "“I'm still working on the propos..."<br>`[36]` **Lileas Graf**: "“Well, he just might have to agr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lileas_GendermariePromise"] ...` | `[42]` **Lileas Graf**: "“Excellent. I'll make arrangemen..." |
| `[39]` | **"“I can't make that promise. Iosef would be furious.”"** | `[35]` **Lileas Graf**: "“I'm still working on the propos..."<br>`[36]` **Lileas Graf**: "“Well, he just might have to agr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lileas Graf**: "“That is unfortunate. In that ca..." |
| `[43]` | **"“I'm disappointed in the lack of support from you. I expected more.”"** | `[67]` **Lileas Graf**: ""It's just one noisy mayor. Perh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lileas Graf**: "“I support you as much as I am a..." |
| `[53]` | **"“Yes please.”"** | `[57]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Livia Suno**: "“As you wish.”" |
| `[54]` | **"“That would be appreciated.”"** | `[57]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Livia Suno**: "“I'll let you know once I have h..." |
| `[65]` | **"“All right, we'll take away his mayorship. Let's reach out to Lileas to have him r..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;` | `[58]` **Lucian Galade**: "“Taking the fight to him is the ..." |
| `[70]` | **"“After what you said about my wife? No.”"** | `[37]` **Lileas Graf**: "“Yet I would gladly support you...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lileas Graf**: "“That is unfortunate. In that ca..." |

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
**[WYBÓR GRACZA: "“By taking away his mayorship. Let's reach out to Lileas to have him removed.”"]** — Mówca: **Player**
> "“By taking away his mayorship. Let's reach out to Lileas to have him removed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_Admin_Mayor_Fire = true"*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Taking the fight to him is the right approach. Proactive behavior will benefit us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Petr Vectern: "“Lileas is his superior -- she ought to side with us and ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Fire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Taking the fight to him is the right approach. Proactive..."*)

### Węzeł `[6]`
Mówca: **Lileas Graf**
> "“Hello, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: "“Let me take a guess. You're calling me about the Curtan ..."*)

### Węzeł `[7]`
Mówca: **Petr Vectern**
> "“Lileas is his superior -- she ought to side with us and remove him from his post. I'll ask Livia to call her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Petr left the room and came back with Livia. She had on a..."*)

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“Yet I cannot possibly fathom how I'm related to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“What do you think about removing him from his mayorship?”"*)
  - -> `[12]` (*Player: "“I want him fired for his actions, Lileas.”"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lileas Graf: "“I'm against administrative intervention in local governm..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lileas Graf: "“It could be accomplished, but it would hurt the trust th..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I want him fired for his actions, Lileas.”"]** — Mówca: **Player**
> "“I want him fired for his actions, Lileas.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lileas Graf), `[17]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“What do you think about removing him from his mayorship?”"]** — Mówca: **Player**
> "“What do you think about removing him from his mayorship?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lileas Graf), `[17]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: "“How can I help?”"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lileas Graf: "“Yet I cannot possibly fathom how I'm related to this.”"*)

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“How can I help?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“What do you think about removing him from his mayorship?”"*)
  - -> `[12]` (*Player: "“I want him fired for his actions, Lileas.”"*)

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“It could be accomplished, but it would hurt the trust the mayors have placed in me and the Ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Your personal support and weight is needed. This needs t..."*)
  - -> `[21]` (*Player: "“We can repair that trust in the near future. But right n..."*)

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I'm against administrative intervention in local governments, especially in a city like Anrica. We'll lose trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Your personal support and weight is needed. This needs t..."*)
  - -> `[21]` (*Player: "“We can repair that trust in the near future. But right n..."*)

### Węzeł `[20]`
Mówca: **Lileas Graf**
> "“I appreciate that you hold me in such high esteem, but I'm reluctant about this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: "“This isn't even counting my personal feelings about the ..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“We can repair that trust in the near future. But right now we need this man weakened.”"]** — Mówca: **Player**
> "“We can repair that trust in the near future. But right now we need this man weakened.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lileas Graf), `[19]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lileas Graf: ""At the expense of yet more pressure on myself and my sta..."*)

### Węzeł `[22]`
Mówca: **Lileas Graf**
> ""At the expense of yet more pressure on myself and my staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: "“This isn't even counting my personal feelings about the ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Your personal support and weight is needed. This needs to look as if it came from you.”"]** — Mówca: **Player**
> "“Your personal support and weight is needed. This needs to look as if it came from you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lileas Graf), `[19]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lileas Graf: "“I appreciate that you hold me in such high esteem, but I..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Lileas hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“She won't upset the mayors at all costs, even one who insulted the First Lady. So much for female solidarity!”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
**[WYBÓR GRACZA: "“We'll keep in touch.”"]** — Mówca: **Player**
> "“We'll keep in touch.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Goodbye.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Very much appreciated, Lileas.”"]** — Mówca: **Player**
> "“Very much appreciated, Lileas.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Goodbye.”"*)

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“I support you as much as I am able to. I must excuse myself now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Goodbye.”"*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“That was a waste of valuable time. But at least Lileas revealed her ambitions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: "“She won't upset the mayors at all costs, even one who in..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Maybe it will blow over. You might be right.”"]** — Mówca: **Player**
> "“Maybe it will blow over. You might be right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: "“With time it should. I must excuse myself now.""*)

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“With time it should. I must excuse myself now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Goodbye.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“I don't see Iosef accepting this.”"]** — Mówca: **Player**
> "“I don't see Iosef accepting this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lileas Graf: "“Well, he just might have to agree if the President of So..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Lileas sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lileas Graf: "“Yet I would gladly support you... if you back my plan to..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I haven't heard of this before.”"]** — Mówca: **Player**
> "“I haven't heard of this before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: "“I'm still working on the proposal and legal backing for ..."*)

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“I'm still working on the proposal and legal backing for it. I was going to mention it later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“I will support you in the Gendarmerie authority transfer..."*)
  - -> `[39]` (*Player: "“I can't make that promise. Iosef would be furious.”"*)

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“Well, he just might have to agree if the President of Sordland tells him to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“I will support you in the Gendarmerie authority transfer..."*)
  - -> `[39]` (*Player: "“I can't make that promise. Iosef would be furious.”"*)

### Węzeł `[37]`
Mówca: **Lileas Graf**
> "“Yet I would gladly support you... if you back my plan to put the Gendarmerie under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“I haven't heard of this before.”"*)
  - -> `[32]` (*Player: "“I don't see Iosef accepting this.”"*)
  - -> `[70]` (*Player: "“After what you said about my wife? No.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"]** — Mówca: **Player**
> "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf), `[36]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise = true; Base..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I can't make that promise. Iosef would be furious.”"]** — Mówca: **Player**
> "“I can't make that promise. Iosef would be furious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf), `[36]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lileas Graf: "“That is unfortunate. In that case there is not much I ca..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanAskedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lileas Graf: "“Excellent. I'll make arrangements to remove the mayor fr..."*)

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“That is unfortunate. In that case there is not much I can do, Mr. President.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Lileas Graf**
> "“Excellent. I'll make arrangements to remove the mayor from his post.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA: "“I'm disappointed in the lack of support from you. I expected more.”"]** — Mówca: **Player**
> "“I'm disappointed in the lack of support from you. I expected more.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lileas Graf: "“I support you as much as I am able to. I must excuse mys..."*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Lileas hung up the phone."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Let's hope this arrangement won't backfire on us. It's true that Iosef will object.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: "“In the short term, though, we need to make Leste's remov..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lileas_GendermariePromise == true )"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“Let's hope this arrangement won't backfire on us. It's t..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lileas_GendermariePromise == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“That was a waste of valuable time. But at least Lileas r..."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“In the short term, though, we need to make Leste's removal seem as necessary as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: "“I'll prepare our press release.”"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The Minister of the Interior was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lileas Graf: "“Hello, Mr. President.”"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the phone lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Minister of the Interior was on the line."*)

### Węzeł `[52]`
Mówca: **Livia Suno**
> "“I'll let you know once I have her on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Livia Suno: "“I'd be careful, though. I doubt Mrs. Graf will remove Ma..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Yes please.”"]** — Mówca: **Player**
> "“Yes please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Livia Suno: "“As you wish.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Livia Suno: "“I'll let you know once I have her on the line.”"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Petr left the room and came back with Livia. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Livia Suno: "“Mr. Vectern told me what happened. Should I connect you ..."*)

### Węzeł `[56]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Livia Suno: "“I'd be careful, though. I doubt Mrs. Graf will remove Ma..."*)

### Węzeł `[57]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you with the Interior Minster directly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Yes please.”"*)
  - -> `[54]` (*Player: "“That would be appreciated.”"*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“Taking the fight to him is the right approach. Proactive behavior will benefit us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: "“Lileas is his superior -- she ought to side with us and ..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“Lileas is his superior -- she ought to side with us and remove him from his post. I'll ask Livia to call her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "A few minutes later, the phone lit up. The Minister of th..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "A few minutes later, the phone lit up. The Minister of the Interior was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lileas Graf: "“Hello, Mr. President.”"*)

### Węzeł `[61]`
Mówca: **Livia Suno**
> "“I'd be careful, though. I doubt Mrs. Graf will remove Mayor Leste without asking for something in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Petr grinned. Lucian looked outraged."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Fire == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_Admin_Mayor_Fire == false"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_Admin_Mayor_Fire == false)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Fire == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“All right, we'll take away his mayorship. Let's reach ou..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_Admin_Mayor_Fire == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA: "“All right, we'll take away his mayorship. Let's reach out to Lileas to have him removed.”"]** — Mówca: **Player**
> "“All right, we'll take away his mayorship. Let's reach out to Lileas to have him removed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_Admin_Mayor_Fire = true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Fire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Fire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: "“Taking the fight to him is the right approach. Proactive..."*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""It's just one noisy mayor. Perhaps you have nothing to worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“I'm disappointed in the lack of support from you. I expe..."*)
  - -> `[30]` (*Player: "“Maybe it will blow over. You might be right.”"*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“I'll prepare our press release.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“Let me take a guess. You're calling me about the Curtan Leste situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“After what you said about my wife? No.”"]** — Mówca: **Player**
> "“After what you said about my wife? No.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lileas Graf: "“That is unfortunate. In that case there is not much I ca..."*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> "“This isn't even counting my personal feelings about the matter. Mr. Rayne, I chose a political career at the expense of becoming a mother. Your wife did not. Leste was right -- her place is at home, not on that stage.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Speak to Lileas, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Livia left the room to arrange the call. A few minutes la..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Speak to Lileas, Mr. President. Unless you'd rather take..."*)
