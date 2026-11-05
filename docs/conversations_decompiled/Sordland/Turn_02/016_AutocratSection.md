# Sordland/Turn02/AutocratSection

- **ID konwersacji:** `16`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/016_AutocratSection.md`
- **Liczba węzłów dialogowych:** 68
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Nia_Opposition`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[14] Sordland/Turn02/A_ReformBriefing** (../Turn_02/014_A_ReformBriefing.md), Węzeł `[97]`
- Węzeł `[5]` -> **[17] Sordland/Turn02/ReformistSection** (../Turn_02/017_ReformistSection.md), Węzeł `[36]`
- Węzeł `[66]` -> **[17] Sordland/Turn02/ReformistSection** (../Turn_02/017_ReformistSection.md), Węzeł `[36]`
- Węzeł `[67]` -> **[17] Sordland/Turn02/ReformistSection** (../Turn_02/017_ReformistSection.md), Węzeł `[36]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Be careful with what you decide to do, Mrs. Morgna.""** | `[37]` **Nia Morgna**: ""Have a good day."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "She gave a fake smile." |
| `[9]` | **""She's not our main problem here.""** | `[7]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Petr Vectern**: ""That's true. We have bigger fis..." |
| `[12]` | **""I will make sure she stays in line.""** | `[7]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: ""Oh she will. I don't think she ..." |
| `[13]` | **""Yes, keep an eye on her. We can't let her sabotage us.""** | `[7]` **Lucian Galade**: ""While I respect her, I doubt th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucian Galade**: ""Of course, sir."" |
| `[18]` | **""Fine. Let's hear it.""** | `[16]` **Petr Vectern**: ""Maybe we can first go over the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Of course, sir. Let's proceed t..." |
| `[20]` | **""I've heard the security reports. Now is not the time for reform.""** | `[16]` **Petr Vectern**: ""Maybe we can first go over the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Lucian Galade**: ""So we're officially against the..." |
| `[23]` | **""So what do you suggest we do?""** | `[58]` **Nia Morgna**: ""With all due respect, I have to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Nia Morgna**: ""Work with the reformists on wri..." |
| `[26]` | **""You too?""** | `[16]` **Petr Vectern**: ""Maybe we can first go over the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Petr Vectern**: ""I... Don't get me wrong. I am w..." |
| `[32]` | **""How about you, Petr?""** | `[46]` **Lucian Galade**: ""I do not. I have already explai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Petr Vectern**: ""I think we can figure something..." |
| `[34]` | **""Good day to you too, Mrs. Morgna.""** | `[37]` **Nia Morgna**: ""Have a good day."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "She gave a fake smile and left t..." |
| `[35]` | **""I will be watching you.""** | `[37]` **Nia Morgna**: ""Have a good day."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "She gave a fake smile." |
| `[38]` | **""Come now, I can't have you all go against me on this.""** | `[46]` **Lucian Galade**: ""I do not. I have already explai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Nia Morgna**: ""With all due respect, Mr. Presi..." |
| `[40]` | **""I appreciate your thoughts. Now let's move on.""** | `[46]` **Lucian Galade**: ""I do not. I have already explai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Nia Morgna**: ""With all due respect, Mr. Presi..." |
| `[45]` | **""So you came here to tell me not to do this.""** | `[46]` **Lucian Galade**: ""I do not. I have already explai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Nia Morgna**: ""With all due respect, Mr. Presi..." |
| `[52]` | **""YES. I thought I already explained myself.""** | `[62]` **Lucian Galade**: ""So we're officially against the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Lucian Galade**: ""Of course, sir."" |
| `[53]` | **""I am disappointed in you, Mrs. Morgna.""** | `[58]` **Nia Morgna**: ""With all due respect, I have to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Nia Morgna**: ""I'm sorry you feel that way, Mr..." |
| `[54]` | **""No, let's try to work with the reformists on a new Constitution.""** | `[62]` **Lucian Galade**: ""So we're officially against the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Of course, sir. Let's proceed t..." |
| `[56]` | **""Watch your words, Mrs. Morgna.""** | `[58]` **Nia Morgna**: ""With all due respect, I have to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "She didn't respond." |
| `[60]` | **""Okay. Let's see what these suggested reforms are.""** | `[15]` **Petr Vectern**: ""I... Don't get me wrong. I am w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Of course, sir. Let's proceed t..." |
| `[61]` | **""Look, I will not reform the Constitution. We have other problems.""** | `[15]` **Petr Vectern**: ""I... Don't get me wrong. I am w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Lucian Galade**: ""So we're officially against the..." |
| `[63]` | **""Looks like it.""** | `[62]` **Lucian Galade**: ""So we're officially against the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""I see."" |
| `[64]` | **""Sollism will never die.""** | `[58]` **Nia Morgna**: ""With all due respect, I have to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "She looked at me in shock. She h..." |
| `[65]` | **""Not *officially.*""** | `[62]` **Lucian Galade**: ""So we're officially against the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucian Galade**: ""I see."" |

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
  - -> `[14]` (*Lucian Galade: ""We already know that the Old Guards will block any refor..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Let's get back to the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Be careful with what you decide to do, Mrs. Morgna.""]** — Mówca: **Player**
> ""Be careful with what you decide to do, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "She gave a fake smile."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reformist Branch Start]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Of course, sir. Let's proceed to the draft.""*)

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""I can't believe you are supporting this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""I do not. I have already explained Mr. President my posi..."*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""While I respect her, I doubt that she's capable of creating major obstacles for us. But we have to keep close eyes on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""Yes, keep an eye on her. We can't let her sabotage us.""*)
  - -> `[12]` (*Player: ""I will make sure she stays in line.""*)
  - -> `[9]` (*Player: ""She's not our main problem here.""*)

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""That's true. We have bigger fish to catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Let's get back to the topic.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""She's not our main problem here.""]** — Mówca: **Player**
> ""She's not our main problem here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Petr Vectern: ""That's true. We have bigger fish to catch.""*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Let's get back to the topic.""*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Oh she will. I don't think she has that in her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Let's get back to the topic.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I will make sure she stays in line.""]** — Mówca: **Player**
> ""I will make sure she stays in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: ""Oh she will. I don't think she has that in her.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Yes, keep an eye on her. We can't let her sabotage us.""]** — Mówca: **Player**
> ""Yes, keep an eye on her. We can't let her sabotage us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""We already know that the Old Guards will block any reforms to the Constitution. So, they would definitely want to work with you to preserve it, if that's still what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Nia Morgna: ""I can't believe you are supporting this too.""*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""I... Don't get me wrong. I am with you. I was only saying that you could go over the draft. I didn't notice if that came out wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""Okay. Let's see what these suggested reforms are.""*)
  - -> `[61]` (*Player: ""Look, I will not reform the Constitution. We have other ..."*)

### Węzeł `[16]`
Mówca: **Petr Vectern**
> ""Maybe we can first go over the draft of the amendments that the committee prepared for reforms. You do not have to approve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""You too?""*)
  - -> `[20]` (*Player: ""I've heard the security reports. Now is not the time for..."*)
  - -> `[18]` (*Player: ""Fine. Let's hear it.""*)

### Węzeł `[17]`
Mówca: **Petr Vectern**
> ""Let's not go that far, Mrs. Morgna. I'm sure we can figure something out. If Mr. President can get Orso Hawker to work with him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: ""I just do not trust the Chief Justice in delivering any ..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Fine. Let's hear it.""]** — Mówca: **Player**
> ""Fine. Let's hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reformist Branch Start]"*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""That's troublesome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: ""While I respect her, I doubt that she's capable of creat..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I've heard the security reports. Now is not the time for reform.""]** — Mówca: **Player**
> ""I've heard the security reports. Now is not the time for reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""So we're officially against the constitutional reforms?""*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""I just do not trust the Chief Justice in delivering any promises. I'm afraid that ignoring the demands for reform might create some future problems for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""Excuse me gentlemen. The reforms are not just *some* pro..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "She left the room and slammed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""So what do you suggest we do?""]** — Mówca: **Player**
> ""So what do you suggest we do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Nia Morgna: ""Work with the reformists on writing a more democratic Co..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""That's troublesome.""*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""I think we can figure something out. You can call a meeting with Orso Hawker. We are not here to destroy the legacy of Tarquin Soll. Why not work with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: ""I just do not trust the Chief Justice in delivering any ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You too?""]** — Mówca: **Player**
> ""You too?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""I... Don't get me wrong. I am with you. I was only sayin..."*)

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "She left the room and slammed the door behind her."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "She gave a fake smile and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "She gave a fake smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Nia Morgna: ""I understand, Mr. President.""*)

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""With all due respect, Mr. President. You are being gullible in thinking you can survive by leaning against the remnants of Soll's autocracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Petr Vectern: ""Let's not go that far, Mrs. Morgna. I'm sure we can figu..."*)

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""Work with the reformists on writing a more democratic Constitution for Sordland. Change cannot be stopped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: ""Maybe we can first go over the draft of the amendments t..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How about you, Petr?""]** — Mówca: **Player**
> ""How about you, Petr?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""I think we can figure something out. You can call a meet..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: ""Maybe we can first go over the draft of the amendments t..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Good day to you too, Mrs. Morgna.""]** — Mówca: **Player**
> ""Good day to you too, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "She gave a fake smile and left the room."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I will be watching you.""]** — Mówca: **Player**
> ""I will be watching you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "She gave a fake smile."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's proceed to the draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reformist Branch Start]"*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Be careful with what you decide to do, Mrs. Morgna.""*)
  - -> `[35]` (*Player: ""I will be watching you.""*)
  - -> `[34]` (*Player: ""Good day to you too, Mrs. Morgna.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Come now, I can't have you all go against me on this.""]** — Mówca: **Player**
> ""Come now, I can't have you all go against me on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""With all due respect, Mr. President. You are being gulli..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "She looked at me in shock. She had no words to say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: ""Maybe we can first go over the draft of the amendments t..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I appreciate your thoughts. Now let's move on.""]** — Mówca: **Player**
> ""I appreciate your thoughts. Now let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""With all due respect, Mr. President. You are being gulli..."*)

### Węzeł `[41]`
Mówca: **Nia Morgna**
> ""With all due respect, I will take my leave from this meeting. I don't think I have anything to add anymore, and I won't sit here and listen to plans of tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Nia Morgna: ""You cannot stop change from happening, Mr. President.""*)

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""You cannot stop change from happening, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "She grabbed her notes and went towards the door."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Even though I do not trust the Chief Justice, I think we can set up a meeting with him to discuss working together to handle the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: ""I can't believe this!""*)

### Węzeł `[44]`
Mówca: **Narrator**
> "She grabbed her notes and went towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""Have a good day.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""So you came here to tell me not to do this.""]** — Mówca: **Player**
> ""So you came here to tell me not to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""With all due respect, Mr. President. You are being gulli..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""I do not. I have already explained Mr. President my position on working with the Old Guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""So you came here to tell me not to do this.""*)
  - -> `[40]` (*Player: ""I appreciate your thoughts. Now let's move on.""*)
  - -> `[38]` (*Player: ""Come now, I can't have you all go against me on this.""*)
  - -> `[32]` (*Player: ""How about you, Petr?""*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Nia stood up with rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Nia Morgna: ""With all due respect, I will take my leave from this mee..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BackToAutocrat`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""I see.""*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""I can't believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Nia stood up with rage."*)

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""I'm sorry you feel that way, Mr. President. But I thought you picked me because you wanted to bring justice to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: ""Maybe we can first go over the draft of the amendments t..."*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Blocking the way of the reforms will create many enemies for us. Our best bet would definitely be working with the Old Guards...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""Even though I do not trust the Chief Justice, I think we..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""YES. I thought I already explained myself.""]** — Mówca: **Player**
> ""YES. I thought I already explained myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""I am disappointed in you, Mrs. Morgna.""]** — Mówca: **Player**
> ""I am disappointed in you, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Nia Morgna: ""I'm sorry you feel that way, Mr. President. But I though..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""No, let's try to work with the reformists on a new Constitution.""]** — Mówca: **Player**
> ""No, let's try to work with the reformists on a new Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Of course, sir. Let's proceed to the draft.""*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""Blocking the way of the reforms will create many enemies..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Watch your words, Mrs. Morgna.""]** — Mówca: **Player**
> ""Watch your words, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She didn't respond."*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""Blocking the way of the reforms will create many enemies..."*)

### Węzeł `[58]`
Mówca: **Nia Morgna**
> ""With all due respect, I have to say that I feel disappointed. I thought this administration was going to bring real change. It seems Sollism still lives on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Watch your words, Mrs. Morgna.""*)
  - -> `[64]` (*Player: ""Sollism will never die.""*)
  - -> `[53]` (*Player: ""I am disappointed in you, Mrs. Morgna.""*)
  - -> `[23]` (*Player: ""So what do you suggest we do?""*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""Excuse me gentlemen. The reforms are not just *some* problem, they are absolutely necessary to democratize this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: ""With all due respect, I have to say that I feel disappoi..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Okay. Let's see what these suggested reforms are.""]** — Mówca: **Player**
> ""Okay. Let's see what these suggested reforms are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reformist Branch Start]"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Look, I will not reform the Constitution. We have other problems.""]** — Mówca: **Player**
> ""Look, I will not reform the Constitution. We have other problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: ""So we're officially against the constitutional reforms?""*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""So we're officially against the constitutional reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""Looks like it.""*)
  - -> `[65]` (*Player: ""Not *officially.*""*)
  - -> `[52]` (*Player: ""YES. I thought I already explained myself.""*)
  - -> `[54]` (*Player: ""No, let's try to work with the reformists on a new Const..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Looks like it.""]** — Mówca: **Player**
> ""Looks like it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""I see.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Sollism will never die.""]** — Mówca: **Player**
> ""Sollism will never die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "She looked at me in shock. She had no words to say."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Not *officially.*""]** — Mówca: **Player**
> ""Not *officially.*""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: ""I see.""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reformist Branch Start]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Of course, sir. Let's proceed to the draft.""*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reformist Branch Start]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Of course, sir. Let's proceed to the draft.""*)
