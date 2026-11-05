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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Of course, Uncle.""** | `[3]` **Hugo Toras**: ""May I have a quick word with you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Hugo Toras**: ""You've published the evidence e..." |
| `[5]` | **""Please.""** | `[3]` **Hugo Toras**: ""May I have a quick word with you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Hugo Toras**: ""You've published the evidence e..." |
| `[6]` | **""Is there something wrong?""** | `[3]` **Hugo Toras**: ""May I have a quick word with you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Hugo Toras**: ""You tell me, Romus..."" |
| `[7]` | **""Not now, Hugo.""** | `[3]` **Hugo Toras**: ""May I have a quick word with you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Despite my words he leaned in an..." |
| `[12]` | **""Don't worry. I will order his release immediately.""** | `[11]` **Hugo Toras**: ""So I must ask you. When will Ri..."<br>`[15]` **Hugo Toras**: ""I don't understand, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = false; Variable["Riz...` | `[34]` **Narrator**: "My uncle heaved a sigh of relief." |
| `[13]` | **""We are still not completely sure that he's innocent.""** | `[11]` **Hugo Toras**: ""So I must ask you. When will Ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Hugo Toras**: ""You're not sure? Even after fin..." |
| `[14]` | **""He will be freed when I say he will be freed. You are in no position to make dema..."** | `[11]` **Hugo Toras**: ""So I must ask you. When will Ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "His face turned bitter." |
| `[22]` | **""He and Su Omina may have still played some role. We need to investigate this furt..."** | `[15]` **Hugo Toras**: ""I don't understand, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Hugo Toras**: ""Rico would never collaborate wi..." |
| `[23]` | **""He was not involved in the Zille bombing. But he may be guilty of other crimes.""** | `[15]` **Hugo Toras**: ""I don't understand, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Hugo Toras**: ""I assure you that he is not. An..." |
| `[25]` | **""I am sorry. But I can't release your son.""** | `[24]` **Hugo Toras**: ""Rico would never collaborate wi..."<br>`[35]` **Hugo Toras**: ""I assure you that he is not. An..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "His face turned bitter." |
| `[26]` | **""He shall only walk free once he has been completely cleared of all wrongdoing.""** | `[24]` **Hugo Toras**: ""Rico would never collaborate wi..."<br>`[35]` **Hugo Toras**: ""I assure you that he is not. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "His face turned bitter." |
| `[27]` | **""You are right. He will be freed immediately.""** | `[24]` **Hugo Toras**: ""Rico would never collaborate wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = false; Variable["Riz...` | `[34]` **Narrator**: "My uncle heaved a sigh of relief." |
| `[28]` | **""Be careful with what you're about to say, Hugo.""** | `[35]` **Hugo Toras**: ""I assure you that he is not. An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "His face turned bitter." |
| `[36]` | **""I will be honest with you. Rico is a necessary sacrifice that must be made in ord..."** | `[11]` **Hugo Toras**: ""So I must ask you. When will Ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Hugo Toras**: ""What?!"" |
| `[39]` | **""Fine. If it makes you happy, I will order his release.""** | `[15]` **Hugo Toras**: ""I don't understand, Your Majesty.""<br>`[38]` **Hugo Toras**: ""We have proven to the world tha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_Arrested"] = false; Variable["Riz...` | `[34]` **Narrator**: "My uncle heaved a sigh of relief." |
| `[40]` | **""This is a private matter between myself and President Smolak. Do not attempt to i..."** | `[38]` **Hugo Toras**: ""We have proven to the world tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "His face turned bitter." |

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
  - -> `[3]` (*Hugo Toras: ""May I have a quick word with you?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""You're not sure? Even after finding indisputable proof t..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""May I have a quick word with you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""Of course, Uncle.""*)
  - -> `[5]` (*Player_Romus: ""Please.""*)
  - -> `[6]` (*Player_Romus: ""Is there something wrong?""*)
  - -> `[7]` (*Player_Romus: ""Not now, Hugo.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, Uncle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""You've published the evidence everywhere. Lespian intell..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""You've published the evidence everywhere. Lespian intell..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something wrong?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""You tell me, Romus...""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not now, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Despite my words he leaned in and kept speaking."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Despite my words he leaned in and kept speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""You've published the evidence everywhere. Lespian intell..."*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""You tell me, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""You've published the evidence everywhere. Lespian intell..."*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""You've published the evidence everywhere. Lespian intelligence planted the bomb in Zille. As I suspected from the beginning, my son had nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""So I must ask you. When will Ricardus be freed?""*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""So I must ask you. When will Ricardus be freed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""Don't worry. I will order his release immediately.""*)
  - -> `[13]` (*Player_Romus: ""We are still not completely sure that he's innocent.""*)
  - -> `[36]` (*Player_Romus: ""I will be honest with you. Rico is a necessary sacrifice..."*)
  - -> `[14]` (*Player_Romus: ""He will be freed when I say he will be freed. You are in..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I will order his release immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[15]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = false; RiziaDLC.Rico_Pardoned = ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are still not completely sure that he's innocent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""You're not sure? Even after finding indisputable proof t..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He will be freed when I say he will be freed. You are in no position to make demands, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "His face turned bitter."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""I don't understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""Don't worry. I will order his release immediately.""*)
  - -> `[39]` (*Player_Romus: ""Fine. If it makes you happy, I will order his release.""*)
  - -> `[22]` (*Player_Romus: ""He and Su Omina may have still played some role. We need..."*)
  - -> `[23]` (*Player_Romus: ""He was not involved in the Zille bombing. But he may be ..."*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""You're not sure? Even after finding indisputable proof that Lespia was the true culprit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""I don't understand, Your Majesty.""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Even if Rico were not my son, it does us no good to have a member of House Toras in prison. An innocent one at that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He was losing control of the volume of his voice. He quic..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "His face turned bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""Even if Rico were not my son, it does us no good to have..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested = false; RiziaDLC.Rico_Pardoned = true;
RiziaDLCSupport.News_Turn08_RH_RicoPardoned = true;
RiziaDLCSupport.News_Turn08_V_RicoPardoned = true;
RiziaDLCSupport.Journal_Turn08_RicoPardon = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = false;
Variable["RiziaDLC.Rico_Pardoned"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_RicoPardoned"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_RicoPardoned"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_RicoPardon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "My uncle heaved a sigh of relief."*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""Thank you, Your Majesty. From the bottom of my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""It does us no good to have a member of House Toras in pr..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""It does us no good to have a member of House Toras in prison. An innocent one, at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He swiftly stepped in front of me and motioned towards th..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He and Su Omina may have still played some role. We need to investigate this further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Rico would never collaborate with Lespia, Your Majesty.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was not involved in the Zille bombing. But he may be guilty of other crimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""I assure you that he is not. And besides, suspicions alo..."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Rico would never collaborate with Lespia, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""You are right. He will be freed immediately.""*)
  - -> `[26]` (*Player_Romus: ""He shall only walk free once he has been completely clea..."*)
  - -> `[25]` (*Player_Romus: ""I am sorry. But I can't release your son.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. But I can't release your son.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras), `[35]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "His face turned bitter."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He shall only walk free once he has been completely cleared of all wrongdoing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras), `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "His face turned bitter."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right. He will be freed immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = false; RiziaDLC.Rico_Pardoned = ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful with what you're about to say, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "His face turned bitter."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "He was losing control of the volume of his voice. He quickly stopped himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""We will talk later. The council is waiting for us.""*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""We will talk later. The council is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_RicoNotPardoned = true;"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "He swiftly stepped in front of me and motioned towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""Come now. The council is waiting for us.""*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Come now. The council is waiting for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_RicoNotPardoned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_RicoNotPardoned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "My uncle heaved a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""Thank you, Your Majesty. From the bottom of my heart.""*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""I assure you that he is not. And besides, suspicions alone do not justify his detention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""He shall only walk free once he has been completely clea..."*)
  - -> `[25]` (*Player_Romus: ""I am sorry. But I can't release your son.""*)
  - -> `[28]` (*Player_Romus: ""Be careful with what you're about to say, Hugo.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. Rico is a necessary sacrifice that must be made in order for Zille to be returned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Hugo Toras: ""What?!""*)

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""What?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""We have proven to the world that Lespia was the true cul..."*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""We have proven to the world that Lespia was the true culprit. If Wiktor Smolak doesn't return Zille in the face of that proof, the Alliance of Nations will surely force him to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Fine. If it makes you happy, I will order his release.""*)
  - -> `[25]` (*Player_Romus: ""I am sorry. But I can't release your son.""*)
  - -> `[40]` (*Player_Romus: ""This is a private matter between myself and President Sm..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. If it makes you happy, I will order his release.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested = false; RiziaDLC.Rico_Pardoned = ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a private matter between myself and President Smolak. Do not attempt to intervene in it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "His face turned bitter."*)
