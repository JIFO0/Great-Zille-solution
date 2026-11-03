# Rizia/Turn 8/HugoConfronts/HugoConfronts Conversation

- **ID konwersacji:** `593`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/593_HugoConfronts_Conversation.md`
- **Liczba węzłów dialogowych:** 41
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_RicoNotPardoned`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Pardoned`
- `RiziaDLCSupport.Journal_Turn08_RicoPardon`
- `RiziaDLCSupport.News_Turn08_RH_RicoPardoned`
- `RiziaDLCSupport.News_Turn08_V_RicoPardoned`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[16]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[19]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_Arrested"] = false; Variable["RiziaDLC.Rico_Pardoned"] = true; Variable["...`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_RicoNotPardoned"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `419` (*Rizia/Turn 8/A_GeneralCouncilMeeting*), Węzeł `[16]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""May I have a quick word with you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, Uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not now, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Despite my words he leaned in and kept speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""You tell me, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""You've published the evidence everywhere. Lespian intelligence planted the bomb in Zille. As I suspected from the beginning, my son had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""So I must ask you. When will Ricardus be freed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[36]`
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I will order his release immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are still not completely sure that he's innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He will be freed when I say he will be freed. You are in no position to make demands, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""I don't understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[39]`
  - -> `[22]`
  - -> `[23]`

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""You're not sure? Even after finding indisputable proof that Lespia was the true culprit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Even if Rico were not my son, it does us no good to have a member of House Toras in prison. An innocent one at that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[18]`
Mówca: **Narrator**
> "His face turned bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested = false; RiziaDLC.Rico_Pardoned = true;
RiziaDLCSupport.News_Turn08_RH_RicoPardoned = true;
RiziaDLCSupport.News_Turn08_V_RicoPardoned = true;
RiziaDLCSupport.Journal_Turn08_RicoPardon = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = false;
Variable["RiziaDLC.Rico_Pardoned"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_RicoPardoned"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_RicoPardoned"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_RicoPardon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""Thank you, Your Majesty. From the bottom of my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""It does us no good to have a member of House Toras in prison. An innocent one, at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He and Su Omina may have still played some role. We need to investigate this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was not involved in the Zille bombing. But he may be guilty of other crimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Rico would never collaborate with Lespia, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[26]`
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. But I can't release your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He shall only walk free once he has been completely cleared of all wrongdoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. He will be freed immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful with what you're about to say, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[29]`
Mówca: **Narrator**
> "He was losing control of the volume of his voice. He quickly stopped himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""We will talk later. The council is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "He swiftly stepped in front of me and motioned towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Come now. The council is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_RicoNotPardoned = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_RicoNotPardoned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[34]`
Mówca: **Narrator**
> "My uncle heaved a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""I assure you that he is not. And besides, suspicions alone do not justify his detention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[25]`
  - -> `[28]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. Rico is a necessary sacrifice that must be made in order for Zille to be returned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""What?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""We have proven to the world that Lespia was the true culprit. If Wiktor Smolak doesn't return Zille in the face of that proof, the Alliance of Nations will surely force him to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[25]`
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. If it makes you happy, I will order his release.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a private matter between myself and President Smolak. Do not attempt to intervene in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
