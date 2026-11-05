# Sordland/Turn07/HOS AND BERGIA STEEL FULLY NATIONALISED

- **ID konwersacji:** `135`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/135_HOS_AND_BERGIA_STEEL_FULLY_NATIONALISED.md`
- **Liczba węzłów dialogowych:** 154
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Malenyevist`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Fled_WalterTusk`
- `BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“Keep the pen. A gift from me and a reminder.”"** | `[93]` **Marcel Koronti**: "“Now what?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Marcel Koronti**: "“Rest assured. I will never forg..." |
| `[12]` | **"“Insanely clever.”"** | `[10]` **Marcel Koronti**: "“Completely nationalizing Sordla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Walter Tusk**: "“This is nonsense.”" |
| `[13]` | **"“Stop whining. You are both done for.”"** | `[10]` **Marcel Koronti**: "“Completely nationalizing Sordla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Walter Tusk**: "“Mr. President. I beg you to ret..." |
| `[14]` | **"“I have already made my decision.”"** | `[10]` **Marcel Koronti**: "“Completely nationalizing Sordla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Walter Tusk**: "“This is nonsense.”" |
| `[29]` | **"“No. There is no need.”"** | `[16]` **Lucian Galade**: "“With their connections and infl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Marcel Koronti**: "“Mr. President. Who are you real..." |
| `[38]` | **"“We *had* a deal.”"** | `[37]` **Narrator**: "Walter scrutinized Marcel closely." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Marcel Koronti**: "“No. This can't be.”" |
| `[39]` | **"“Wake up. I just used you, Marcel.”"** | `[37]` **Narrator**: "Walter scrutinized Marcel closely." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Marcel Koronti**: "“No. This can't be.”" |
| `[40]` | **"“You have exhausted your usefulness.”"** | `[37]` **Narrator**: "Walter scrutinized Marcel closely." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Marcel Koronti**: "“No. This can't be.”" |
| `[59]` | **"“I played you like a fiddle.”"** | `[57]` **Walter Tusk**: "“I couldn't be more wrong.”"<br>`[73]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“Screw you.”" |
| `[60]` | **"“It's over, Walter.”"** | `[57]` **Walter Tusk**: "“I couldn't be more wrong.”"<br>`[73]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“Screw you.”" |
| `[61]` | **"“Good riddance.”"** | `[57]` **Walter Tusk**: "“I couldn't be more wrong.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“Screw you.”" |
| `[70]` | **"“Give me back my pen.”"** | `[93]` **Marcel Koronti**: "“Now what?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "Marcel halfheartedly extended hi..." |
| `[77]` | **"“And look at where we are now.”"** | `[73]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“Screw you.”" |
| `[88]` | **"“You are right. Guards! Some time in Antel Rock Prison will teach him.”"** | `[16]` **Lucian Galade**: "“With their connections and infl..."<br>`[85]` **Lucian Galade**: "“Mr. President, we can't let the..." | `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[108]` **Narrator**: "Two guards waiting outside enter..." |
| `[89]` | **"“Mr. Koronti and Mr. Tusk. I've showed you both what I'm capable of. You will not ..."** | `[16]` **Lucian Galade**: "“With their connections and infl..."<br>`[85]` **Lucian Galade**: "“Mr. President, we can't let the..." | `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false` | *Brak zmian stanu* | `[96]` **Marcel Koronti**: "“Or else what?"" |
| `[90]` | **"“Get up, come closer and give me back my pen.”"** | `[114]` **Narrator**: "Marcel halfheartedly extended hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Marcel got up from his seat and ..." |
| `[92]` | **"“Lucian.”"** | `[114]` **Narrator**: "Marcel halfheartedly extended hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "He grabbed the pen from Marcel's..." |
| `[97]` | **"Hand him your own pen."** | `[95]` **Walter Tusk**: "“Neither do I."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Walter Tusk**: "“There is no way out of this, is..." |
| `[105]` | **"“No.”"** | `[101]` **Walter Tusk**: "“There is no way out of this, is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Walter sighed." |
| `[106]` | **"“Sign it or else.”"** | `[101]` **Walter Tusk**: "“There is no way out of this, is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Walter sighed." |
| `[112]` | **"“No need for escalation. They don't have any power anymore.”"** | `[85]` **Lucian Galade**: "“Mr. President, we can't let the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: "“I wouldn't underestimate what t..." |
| `[116]` | **"“I don't need your deal now that I have your company.”"** | `[37]` **Narrator**: "Walter scrutinized Marcel closely." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Marcel Koronti**: "“No. This can't be.”" |
| `[120]` | **"“Don't you worry, Lucian. I've launched an investigation that will uncover all of ..."** | `[16]` **Lucian Galade**: "“With their connections and infl..."<br>`[85]` **Lucian Galade**: "“Mr. President, we can't let the..." | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[122]` **Player**: ""I'm going to gather enough evid..."<br>`[123]` **Player**: ""You gentlemen can't hide anythi..." |
| `[122]` | **""I'm going to gather enough evidence to throw you in jail for life.""** | `[120]` **Player**: "“Don't you worry, Lucian. I've l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "Marcel looked at me disbelievingly." |
| `[123]` | **""You gentlemen can't hide anything from me.""** | `[120]` **Player**: "“Don't you worry, Lucian. I've l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "Walter snorted." |

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
  - -> `[7]` (*Narrator: "The two oligarchs looked at each other and then at me."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Walter Tusk**
> "“You are making a terrible mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Marcel Koronti: "“To put it mildly. You can't just take away our entire li..."*)

### Węzeł `[4]`
Mówca: **Marcel Koronti**
> "“To put it mildly. You can't just take away our entire life's work and expect no repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Walter Tusk: "“This might be one of those rare moments where we are ali..."*)

### Węzeł `[5]`
Mówca: **Walter Tusk**
> "“This might be one of those rare moments where we are aligned, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Marcel Koronti: "“Well, it's rare a president does something this colossal..."*)

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“Well, it's rare a president does something this colossally stupid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Marcel Koronti: "“Completely nationalizing Sordland's two biggest private ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The two oligarchs looked at each other and then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Walter Tusk: "“You are making a terrible mistake.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Keep the pen. A gift from me and a reminder.”"]** — Mówca: **Player**
> "“Keep the pen. A gift from me and a reminder.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Marcel Koronti: "“Rest assured. I will never forget what you have done to ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Marcel buried his head in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Completely nationalizing Sordland's two biggest private corporations? Are you insane?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“Insanely clever.”"*)
  - -> `[14]` (*Player: "“I have already made my decision.”"*)
  - -> `[13]` (*Player: "“Stop whining. You are both done for.”"*)

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“I've been chewing up and spitting out Sordish politicians since you were in diapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""I wonder how you'll do that now that you don't have any ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Insanely clever.”"]** — Mówca: **Player**
> "“Insanely clever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Walter Tusk: "“This is nonsense.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Stop whining. You are both done for.”"]** — Mówca: **Player**
> "“Stop whining. You are both done for.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Walter Tusk: "“Mr. President. I beg you to rethink this decision.”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I have already made my decision.”"]** — Mówca: **Player**
> "“I have already made my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Walter Tusk: "“This is nonsense.”"*)

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“If we are going down, you are going down with us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“Most of the Assembly eats out of my hand.”"*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“With their connections and influence, they could cause us untold difficulties down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“No. There is no need.”"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“I swear on my name as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“If we are going down, you are going down with us.”"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Lucian fanned the agreement papers out in front of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“Mr. Koronti. Mr. Tusk. Here are the agreements that pert..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Mr. Tusk. Here are the agreements that pertain to the nationalization and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He pointed to various sections and pages in the stack of ..."*)

### Węzeł `[20]`
Mówca: **Marcel Koronti**
> "“I know everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“If we are going down, you are going down with us.”"*)

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“This is nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Walter Tusk: "“Mr. President. I beg you to rethink this decision.”"*)

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“Mr. President. I beg you to rethink this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Lucian fanned the agreement papers out in front of them."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Marcel and Walter packed their belongings and furiously exited the room, closing the door loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti = true; BaseGame.Turn0..."*)

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Most of the Assembly eats out of my hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“You will learn what it means to hurt Walter Tusk, Presid..."*)

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Rest assured. I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Your time will come too, Rayne. Believe me.”"*)

### Węzeł `[26]`
Mówca: **Marcel Koronti**
> "“Don't you realize how much dirt I have on you? You will pay for backstabbing me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Marcel Koronti: "“I swear on my name as a Koronti.”"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Marcel Koronti: "“Mr. President. Who are you really doing this for?""*)

### Węzeł `[30]`
Mówca: **Marcel Koronti**
> "“Don't you realize how much dirt I have on you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Marcel Koronti: "“I know everything.”"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Marcel Koronti: "“I thought we had a deal!”"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Marcel Koronti: "“This is absolutely ridiculous! I can't do it. I just can..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Cuffed by the two guards, Walter Tusk and Marcel Koronti left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Turn..."*)

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“I thought we had a deal!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Walter scrutinized Marcel closely."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Cuffed by the two guards, Walter Tusk and Marcel Koronti ..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Walter scrutinized Marcel closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“We *had* a deal.”"*)
  - -> `[39]` (*Player: "“Wake up. I just used you, Marcel.”"*)
  - -> `[40]` (*Player: "“You have exhausted your usefulness.”"*)
  - -> `[116]` (*Player: "“I don't need your deal now that I have your company.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“We *had* a deal.”"]** — Mówca: **Player**
> "“We *had* a deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Marcel Koronti: "“No. This can't be.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Wake up. I just used you, Marcel.”"]** — Mówca: **Player**
> "“Wake up. I just used you, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Marcel Koronti: "“No. This can't be.”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“You have exhausted your usefulness.”"]** — Mówca: **Player**
> "“You have exhausted your usefulness.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Marcel Koronti: "“No. This can't be.”"*)

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“You will learn what it means to hurt Walter Tusk, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: "“Guards!”"*)

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“I will destroy you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“Good luck doing that behind bars.”"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Marcel and Walter packed their belongings and exited the room, closing the door loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[44]`
Mówca: **Marcel Koronti**
> "“No. This can't be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Marcel buried his head in his hands."*)

### Węzeł `[45]`
Mówca: **Marcel Koronti**
> "“You!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Marcel Koronti: "“I will destroy you!”"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Marcel Koronti: "“Don't you realize how much dirt I have on you? You will ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Marcel Koronti: "“Don't you realize how much dirt I have on you?""*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Marcel buried his head in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Guards!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Two guards immediately entered the room."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Marcel turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Marcel Koronti: "“You!”"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Walter Tusk: "“I knew this would happen. I should've trusted my gut fee..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“I had a gut feeling, President. I knew you were not to b..."*)

### Węzeł `[55]`
Mówca: **Walter Tusk**
> "“I knew this would happen. I should've trusted my gut feeling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Walter Tusk: "“Shame on me for actually believing we could work together.”"*)

### Węzeł `[56]`
Mówca: **Walter Tusk**
> "“Shame on me for actually believing we could work together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Walter Tusk: "“I couldn't be more wrong.”"*)

### Węzeł `[57]`
Mówca: **Walter Tusk**
> "“I couldn't be more wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“It's over, Walter.”"*)
  - -> `[61]` (*Player: "“Good riddance.”"*)
  - -> `[59]` (*Player: "“I played you like a fiddle.”"*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Marcel turned to me."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“I played you like a fiddle.”"]** — Mówca: **Player**
> "“I played you like a fiddle.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Walter Tusk), `[73]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It's over, Walter.”"]** — Mówca: **Player**
> "“It's over, Walter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Walter Tusk), `[73]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“We will do everything we can to make sure you never get a second term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[63]`
Mówca: **Walter Tusk**
> "“I will be blunt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Walter Tusk: "“We will do everything we can to make sure you never get ..."*)

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“Get your hands off of me!”"*)

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“Gentlemen, don't make this more difficult.”"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Marcel's shoulders slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Marcel Koronti: "“I--”"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Walter ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Walter Tusk: ""Marcel, I've had just about enough of Sordland. Wouldn't..."*)

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Mr. President. Who are you really doing this for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Marcel Koronti: "“Mark my words. Whoever put you up to this, I'm sure they..."*)

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“I had a gut feeling, President. I knew you were not to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: "“I knew you would end up destroying everything Sordland s..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Give me back my pen.”"]** — Mówca: **Player**
> "“Give me back my pen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Marcel halfheartedly extended his arm across the table. T..."*)

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“I knew you would end up destroying everything Sordland stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Walter Tusk: "“I should've destroyed you when I had the chance.”"*)

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“For your sake, I hope I never see your face again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Walter Tusk: ""Marcel, I've had just about enough of Sordland. Wouldn't..."*)

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“I should've destroyed you when I had the chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“It's over, Walter.”"*)
  - -> `[59]` (*Player: "“I played you like a fiddle.”"*)
  - -> `[77]` (*Player: "“And look at where we are now.”"*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Your time will come too, Rayne. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Walter Tusk: "“I will be blunt.”"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Two guards immediately entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: "“Mr. President, we can't let them threaten you like this.”"*)

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“You totalist dog!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Walter Tusk: "“Dictator!”"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“And look at where we are now.”"]** — Mówca: **Player**
> "“And look at where we are now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""I wonder how you'll do that now that you don't have any teeth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Walter ignored him."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I wouldn't underestimate what they can do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“With their connections and influence, they could cause u..."*)

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“This is absolutely ridiculous! I can't do it. I just can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Marcel buried his head in his hands."*)

### Węzeł `[81]`
Mówca: **Walter Tusk**
> "“We will never forget what you have done to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Your time will come too, Rayne. Believe me.”"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Marcel got up from his seat and gave me the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Walter Tusk: "“We will never forget what you have done to us.”"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "He grabbed the pen from Marcel's hands and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Walter Tusk: "“We will never forget what you have done to us.”"*)

### Węzeł `[84]`
Mówca: **Walter Tusk**
> "“You can't do this to me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> "“Mr. President, we can't let them threaten you like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“No need for escalation. They don't have any power anymore.”"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“Gentlemen, don't make this more difficult.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“Sign the papers.”"*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Sign the papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Marcel's shoulders slumped in defeat."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach them.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade), `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Two guards waiting outside entered the room immediately a..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Mr. Koronti and Mr. Tusk. I've showed you both what I'm capable of. You will not threaten me... or else.""]** — Mówca: **Player**
> "“Mr. Koronti and Mr. Tusk. I've showed you both what I'm capable of. You will not threaten me... or else.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade), `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“Or else what?""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Get up, come closer and give me back my pen.”"]** — Mówca: **Player**
> "“Get up, come closer and give me back my pen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Marcel got up from his seat and gave me the pen."*)

### Węzeł `[91]`
Mówca: **Marcel Koronti**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Marcel Koronti: "“I don't have a pen.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Lucian.”"]** — Mówca: **Player**
> "“Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He grabbed the pen from Marcel's hands and gave it to me."*)

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“Now what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“Keep the pen. A gift from me and a reminder.”"*)
  - -> `[70]` (*Player: "“Give me back my pen.”"*)

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Walter Tusk: "“Neither do I.""*)

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“Neither do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Italic: "Hand him your own pen."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Marcel Koronti: "“Do you know who we are?""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Hand him your own pen."]** — Mówca: **Player_Italic**
> "I handed him my own pen with the Presidential sigil on it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Walter Tusk: "“There is no way out of this, is there?”"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“You are right. Guards! Some time in Antel Rock Prison wi..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“Mr. Koronti and Mr. Tusk. I've showed you both what I'm ..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[101]`
Mówca: **Walter Tusk**
> "“There is no way out of this, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“No.”"*)
  - -> `[106]` (*Player: "“Sign it or else.”"*)

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“No. No, no, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Walter Tusk: "“You can't do this to me!”"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Marcel signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Marcel Koronti: "“Now what?”"*)

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“Do you know who we are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Walter Tusk: "“I've been chewing up and spitting out Sordish politician..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Walter sighed."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Sign it or else.”"]** — Mówca: **Player**
> "“Sign it or else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Walter sighed."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Walter sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Walter Tusk: "“Fine. I will sign it.”"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Two guards waiting outside entered the room immediately and started to apprehend Marcel Koronti and Walter Tusk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Marcel Koronti: "“No. No, no, no.""*)

### Węzeł `[109]`
Mówca: **Walter Tusk**
> "“I'll tell you this, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Walter Tusk: "“For your sake, I hope I never see your face again.""*)

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Mark my words. Whoever put you up to this, I'm sure they'll turn on you one day as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Walter Tusk: "“I'll tell you this, President.”"*)

### Węzeł `[111]`
Mówca: **Walter Tusk**
> "“Fine. I will sign it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "In a painfully slow manner, he signed the documents. He h..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“No need for escalation. They don't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. They don't have any power anymore.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“I wouldn't underestimate what they can do, Mr. President.”"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "In a painfully slow manner, he signed the documents. He handed my pen to Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Marcel halfheartedly extended his arm across the table. The pen was still too far away to reach."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“Lucian.”"*)
  - -> `[90]` (*Player: "“Get up, come closer and give me back my pen.”"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Turn07_Detained_MarcelKoronti = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true;
Variable["BaseGame.Turn07_Detained_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Enemy = true; BaseGame.Relation..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I don't need your deal now that I have your company.”"]** — Mówca: **Player**
> "“I don't need your deal now that I have your company.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Marcel Koronti: "“No. This can't be.”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“Don't you worry, Lucian. I've launched an investigation ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Don't you worry, Lucian. I've launched an investigation that will uncover all of their dirty secrets.""]** — Mówca: **Player**
> "“Don't you worry, Lucian. I've launched an investigation that will uncover all of their dirty secrets.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Lucian Galade), `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""I'm going to gather enough evidence to throw you in jail..."*)
  - -> `[123]` (*Player: ""You gentlemen can't hide anything from me.""*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Marcel looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I'm going to gather enough evidence to throw you in jail for life.""]** — Mówca: **Player**
> ""I'm going to gather enough evidence to throw you in jail for life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Marcel looked at me disbelievingly."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""You gentlemen can't hide anything from me.""]** — Mówca: **Player**
> ""You gentlemen can't hide anything from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Walter snorted."*)

### Węzeł `[124]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Marcel Koronti: "“Or me.""*)

### Węzeł `[125]`
Mówca: **Walter Tusk**
> ""That makes two of us. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Walter Tusk: ""I'll see you and your trained monkey in hell.""*)

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Walter Tusk: ""That makes two of us. Watch your back, Rayne.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: ""Listen, you halfwit. Even if I did have something to hid..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Walter snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[131]`
Mówca: **Lucian Galade**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Walter Tusk: "“Don't underestimate me.”"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: ""Don't forget I know a thing or two about you as well.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: ""Listen, you halfwit. Even if I did have something to hid..."*)

### Węzeł `[135]`
Mówca: **Walter Tusk**
> ""Listen, you halfwit. Even if I did have something to hide, I've got an army of lawyers and half the Assembly on my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: "“I wonder if they will stand by you when you don't have e..."*)

### Węzeł `[136]`
Mówca: **Marcel Koronti**
> "“Or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Walter Tusk: ""I'll see you and your trained monkey in hell.""*)

### Węzeł `[137]`
Mówca: **Walter Tusk**
> ""I'll see you and your trained monkey in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Lucian didn't move. I saw a muscle in his jaw twitch."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Lucian didn't move. I saw a muscle in his jaw twitch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti = true; BaseGame.Turn0..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti = true;
BaseGame.Turn07_Fled_WalterTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true;
Variable["BaseGame.Turn07_Fled_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti = true;
BaseGame.Turn07_Fled_WalterTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true;
Variable["BaseGame.Turn07_Fled_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Enemy = true; BaseGame.Relation..."*)

### Węzeł `[141]`
Mówca: **Walter Tusk**
> ""Marcel, I've had just about enough of Sordland. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Marcel Koronti: ""I couldn't have put it better myself. I hear the weather..."*)

### Węzeł `[142]`
Mówca: **Marcel Koronti**
> ""I couldn't have put it better myself. I hear the weather in Arcasia is lovely this time of year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Walter looked at me."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Walter looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Walter Tusk: ""I'll see you and your trained monkey in hell.""*)

### Węzeł `[144]`
Mówca: **Walter Tusk**
> ""Marcel, I've had just about enough of Sordland. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Marcel Koronti: ""I couldn't have put it better myself. I hear the weather..."*)

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> ""I couldn't have put it better myself. I hear the weather in Arcasia is lovely this time of year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Marcel and Walter packed their belongings and furiously e..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Enemy = true; BaseGame.Relations_Marcel_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Enemy"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk = ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Enemy = true; BaseGame.Relations_Marcel_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Enemy"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Marcel and Walter packed their belongings and exited the ..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 12)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Marcel Koronti: "“You Malenyevist pig!”"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 12)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Marcel Koronti: "“You totalist dog!”"*)

### Węzeł `[152]`
Mówca: **Marcel Koronti**
> "“You Malenyevist pig!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Walter Tusk: "“Dictator!”"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Marcel signed the papers."*)
