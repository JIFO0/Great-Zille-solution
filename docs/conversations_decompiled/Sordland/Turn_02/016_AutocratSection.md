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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 1

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Nia_Opposition`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[24]` (Lucian Galade): `Variable["BaseGame.Relations_Nia_Opposition"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `14` (*Sordland/Turn02/A_ReformBriefing*), Węzeł `[97]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Let's get back to the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Be careful with what you decide to do, Mrs. Morgna.""]** — Mówca: **Player**
> ""Be careful with what you decide to do, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Reformist Branch Start])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `17` (*Sordland/Turn02/ReformistSection*), Węzeł `[36]`

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""I can't believe you are supporting this too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""While I respect her, I doubt that she's capable of creating major obstacles for us. But we have to keep close eyes on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""That's true. We have bigger fish to catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""She's not our main problem here.""]** — Mówca: **Player**
> ""She's not our main problem here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Oh she will. I don't think she has that in her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I will make sure she stays in line.""]** — Mówca: **Player**
> ""I will make sure she stays in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Yes, keep an eye on her. We can't let her sabotage us.""]** — Mówca: **Player**
> ""Yes, keep an eye on her. We can't let her sabotage us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""We already know that the Old Guards will block any reforms to the Constitution. So, they would definitely want to work with you to preserve it, if that's still what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""I... Don't get me wrong. I am with you. I was only saying that you could go over the draft. I didn't notice if that came out wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[16]`
Mówca: **Petr Vectern**
> ""Maybe we can first go over the draft of the amendments that the committee prepared for reforms. You do not have to approve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[20]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
> ""Let's not go that far, Mrs. Morgna. I'm sure we can figure something out. If Mr. President can get Orso Hawker to work with him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Fine. Let's hear it.""]** — Mówca: **Player**
> ""Fine. Let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""That's troublesome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I've heard the security reports. Now is not the time for reform.""]** — Mówca: **Player**
> ""I've heard the security reports. Now is not the time for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""I just do not trust the Chief Justice in delivering any promises. I'm afraid that ignoring the demands for reform might create some future problems for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[22]`
Mówca: **Narrator**
> "She left the room and slammed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""So what do you suggest we do?""]** — Mówca: **Player**
> ""So what do you suggest we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""I think we can figure something out. You can call a meeting with Orso Hawker. We are not here to destroy the legacy of Tarquin Soll. Why not work with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You too?""]** — Mówca: **Player**
> ""You too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""I understand, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[28]`
Mówca: **Narrator**
> "She gave a fake smile and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[29]`
Mówca: **Narrator**
> "She gave a fake smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""With all due respect, Mr. President. You are being gullible in thinking you can survive by leaning against the remnants of Soll's autocracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""Work with the reformists on writing a more democratic Constitution for Sordland. Change cannot be stopped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How about you, Petr?""]** — Mówca: **Player**
> ""How about you, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[33]`
Mówca: **Narrator**
> "She didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Good day to you too, Mrs. Morgna.""]** — Mówca: **Player**
> ""Good day to you too, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I will be watching you.""]** — Mówca: **Player**
> ""I will be watching you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's proceed to the draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[35]`
  - -> `[34]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Come now, I can't have you all go against me on this.""]** — Mówca: **Player**
> ""Come now, I can't have you all go against me on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[39]`
Mówca: **Narrator**
> "She looked at me in shock. She had no words to say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I appreciate your thoughts. Now let's move on.""]** — Mówca: **Player**
> ""I appreciate your thoughts. Now let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[41]`
Mówca: **Nia Morgna**
> ""With all due respect, I will take my leave from this meeting. I don't think I have anything to add anymore, and I won't sit here and listen to plans of tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""You cannot stop change from happening, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""Even though I do not trust the Chief Justice, I think we can set up a meeting with him to discuss working together to handle the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Narrator**
> "She grabbed her notes and went towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""So you came here to tell me not to do this.""]** — Mówca: **Player**
> ""So you came here to tell me not to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""I do not. I have already explained Mr. President my position on working with the Old Guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[40]`
  - -> `[38]`
  - -> `[32]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Nia stood up with rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BackToAutocrat)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""I can't believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""I'm sorry you feel that way, Mr. President. But I thought you picked me because you wanted to bring justice to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Blocking the way of the reforms will create many enemies for us. Our best bet would definitely be working with the Old Guards...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""YES. I thought I already explained myself.""]** — Mówca: **Player**
> ""YES. I thought I already explained myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""I am disappointed in you, Mrs. Morgna.""]** — Mówca: **Player**
> ""I am disappointed in you, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""No, let's try to work with the reformists on a new Constitution.""]** — Mówca: **Player**
> ""No, let's try to work with the reformists on a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Watch your words, Mrs. Morgna.""]** — Mówca: **Player**
> ""Watch your words, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[58]`
Mówca: **Nia Morgna**
> ""With all due respect, I have to say that I feel disappointed. I thought this administration was going to bring real change. It seems Sollism still lives on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[64]`
  - -> `[53]`
  - -> `[23]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""Excuse me gentlemen. The reforms are not just *some* problem, they are absolutely necessary to democratize this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Okay. Let's see what these suggested reforms are.""]** — Mówca: **Player**
> ""Okay. Let's see what these suggested reforms are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Look, I will not reform the Constitution. We have other problems.""]** — Mówca: **Player**
> ""Look, I will not reform the Constitution. We have other problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""So we're officially against the constitutional reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[65]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Looks like it.""]** — Mówca: **Player**
> ""Looks like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Sollism will never die.""]** — Mówca: **Player**
> ""Sollism will never die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Not *officially.*""]** — Mówca: **Player**
> ""Not *officially.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Reformist Branch Start])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `17` (*Sordland/Turn02/ReformistSection*), Węzeł `[36]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Reformist Branch Start])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `17` (*Sordland/Turn02/ReformistSection*), Węzeł `[36]`
