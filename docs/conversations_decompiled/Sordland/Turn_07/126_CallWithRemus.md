# Sordland/Turn07/CallWithRemus

- **ID konwersacji:** `126`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/126_CallWithRemus.md`
- **Liczba węzłów dialogowych:** 62
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Aids_Election`
- `BaseGame.YoungSords_Aids_Security`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[86]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""I'm already working on it, but I may require some help with getting rid of Orso H..."** | `[4]` **Remus Holstron**: ""How may I help you?""<br>`[24]` **Remus Holstron**: ""Everything is running smoothly...." | `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true` | *Brak zmian stanu* | `[29]` **Remus Holstron**: ""I see..."" |
| `[9]` | **""I may require some help with getting rid of Orso Hawker.""** | `[4]` **Remus Holstron**: ""How may I help you?"" | `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false` | *Brak zmian stanu* | `[31]` **Remus Holstron**: ""I see..."" |
| `[10]` | **""Security in Sordland is still concerning. I require your help with boosting our s..."** | `[4]` **Remus Holstron**: ""How may I help you?""<br>`[24]` **Remus Holstron**: ""Everything is running smoothly...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Remus Holstron**: ""We can surely help with that, M..." |
| `[12]` | **""It's the President speaking.""** | `[11]` **Remus Holstron**: ""Who is this?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Remus Holstron**: ""Oh, Mr. President. How nice of ..." |
| `[13]` | **""It's Anton Rayne.""** | `[11]` **Remus Holstron**: ""Who is this?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Remus Holstron**: ""Oh, Mr. President. How nice of ..." |
| `[14]` | **""Your secret partner.""** | `[11]` **Remus Holstron**: ""Who is this?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Remus Holstron**: ""Oh, Mr. President. How nice of ..." |
| `[15]` | **""The one who knocks.""** | `[11]` **Remus Holstron**: ""Who is this?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Remus Holstron**: ""What?"" |
| `[18]` | **""The elections are approaching. I require your help with our... campaign.""** | `[4]` **Remus Holstron**: ""How may I help you?""<br>`[24]` **Remus Holstron**: ""Everything is running smoothly...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Remus Holstron**: ""We can surely help with that, M..." |
| `[22]` | **""I just wanted to ask if everything was going well on your side.""** | `[4]` **Remus Holstron**: ""How may I help you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Remus Holstron**: ""Oh, thank you, Mr. President."" |
| `[25]` | **""No, thank you. Maybe another time.""** | `[24]` **Remus Holstron**: ""Everything is running smoothly...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Remus Holstron**: ""Uhm... Okay."" |
| `[38]` | **""You are late. Why is the Chief Justice still around?""** | `[4]` **Remus Holstron**: ""How may I help you?"" | `(Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false` | *Brak zmian stanu* | `[39]` **Remus Holstron**: ""We are talking about one of the..." |
| `[43]` | **""Good. I'll be expecting the news.""** | `[42]` **Remus Holstron**: ""I'll discuss this with the guys."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true; V...` | `[58]` **Remus Holstron**: ""Great."" |
| `[44]` | **""That settles it then.""** | `[42]` **Remus Holstron**: ""I'll discuss this with the guys."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true; V...` | `[58]` **Remus Holstron**: ""Great."" |
| `[45]` | **""Maybe you got me wrong, Mr. Holstron. Let's just cancel this whole thing. This wa..."** | `[42]` **Remus Holstron**: ""I'll discuss this with the guys."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Remus Holstron**: ""Oh? Okay..."" |
| `[50]` | **""Consider it done. Prove your worth.""** | `[49]` **Remus Holstron**: ""The security situation will qui..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.YoungSords_Aids_Security"] = true; Var...` | `[58]` **Remus Holstron**: ""Great."" |
| `[51]` | **""Come to think of it, maybe this isn't the best idea.""** | `[49]` **Remus Holstron**: ""The security situation will qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Remus Holstron**: ""Oh? Okay."" |
| `[56]` | **""Understood. Just tell me whenever you need the money.""** | `[55]` **Remus Holstron**: ""But we may ask you to transfer ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.YoungSords_Aids_Election"] = true; Var...` | `[58]` **Remus Holstron**: ""Great."" |
| `[57]` | **""Come to think of it, maybe this isn't the best idea.""** | `[55]` **Remus Holstron**: ""But we may ask you to transfer ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Remus Holstron**: ""Oh? Okay."" |

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
  - -> `[3]` (*Narrator: "Remus responded in a low voice."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Remus responded in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Remus Holstron: ""Who is this?""*)

### Węzeł `[4]`
Mówca: **Remus Holstron**
> ""How may I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Kill_OrsoHawker == false"*)
  - -> `[10]` (*Player: ""Security in Sordland is still concerning. I require your..."*)
  - -> `[18]` (*Player: ""The elections are approaching. I require your help with ..."*)
  - -> `[22]` (*Player: ""I just wanted to ask if everything was going well on you..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already working on it, but I may require some help with getting rid of Orso Hawker. I don't trust the deep state elements inside the Forces.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron), `[24]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Remus Holstron: ""I see...""*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""I'm already working on it, but I may require some help w..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may require some help with getting rid of Orso Hawker.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Remus Holstron: ""I see...""*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Security in Sordland is still concerning. I require your help with boosting our security forces.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron), `[24]` (Remus Holstron), `[61]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Remus Holstron: ""We can surely help with that, Mr. Rayne.""*)

### Węzeł `[11]`
Mówca: **Remus Holstron**
> ""Who is this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""It's the President speaking.""*)
  - -> `[13]` (*Player: ""It's Anton Rayne.""*)
  - -> `[14]` (*Player: ""Your secret partner.""*)
  - -> `[15]` (*Player: ""The one who knocks.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's the President speaking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Remus Holstron: ""Oh, Mr. President. How nice of you to call.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's Anton Rayne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Remus Holstron: ""Oh, Mr. President. How nice of you to call.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your secret partner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Remus Holstron: ""Oh, Mr. President. How nice of you to call.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The one who knocks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Remus Holstron: ""What?""*)

### Węzeł `[16]`
Mówca: **Remus Holstron**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Remus Holstron: ""Oh, Mr. President. How nice of you to call.""*)

### Węzeł `[17]`
Mówca: **Remus Holstron**
> ""Oh, Mr. President. How nice of you to call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Remus Holstron: ""How may I help you?""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The elections are approaching. I require your help with our... campaign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron), `[24]` (Remus Holstron), `[61]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Remus Holstron: ""We can surely help with that, Mr. Rayne.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.YoungSords_Aids_Security"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Remus Holstron: ""Great.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Election = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.YoungSords_Aids_Election"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Remus Holstron: ""Great.""*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Kill_OrsoHawker = true;
BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true;
Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Remus Holstron: ""Great.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I just wanted to ask if everything was going well on your side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Remus Holstron: ""Oh, thank you, Mr. President.""*)

### Węzeł `[23]`
Mówca: **Remus Holstron**
> ""Oh, thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Remus Holstron: ""Everything is running smoothly. But is there something y..."*)

### Węzeł `[24]`
Mówca: **Remus Holstron**
> ""Everything is running smoothly. But is there something you need from us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)
  - -> `[10]` (*Player: ""Security in Sordland is still concerning. I require your..."*)
  - -> `[18]` (*Player: ""The elections are approaching. I require your help with ..."*)
  - -> `[25]` (*Player: ""No, thank you. Maybe another time.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, thank you. Maybe another time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Remus Holstron: ""Uhm... Okay.""*)

### Węzeł `[26]`
Mówca: **Remus Holstron**
> ""Uhm... Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Remus Holstron: ""Well, if that was all, I'll have to go back to my work n..."*)

### Węzeł `[27]`
Mówca: **Remus Holstron**
> ""Well, if that was all, I'll have to go back to my work now, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Remus Holstron: ""Have a nice day.""*)

### Węzeł `[28]`
Mówca: **Remus Holstron**
> ""Have a nice day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The line dropped dead."*)

### Węzeł `[29]`
Mówca: **Remus Holstron**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Remus Holstron: ""You are right not to trust them.""*)

### Węzeł `[30]`
Mówca: **Remus Holstron**
> ""You are right not to trust them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Remus Holstron: ""Maybe we can help you with that.""*)

### Węzeł `[31]`
Mówca: **Remus Holstron**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Remus Holstron: ""I knew this was coming.""*)

### Węzeł `[32]`
Mówca: **Remus Holstron**
> ""I knew this was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Remus Holstron: ""Maybe we can help you with that.""*)

### Węzeł `[33]`
Mówca: **Remus Holstron**
> ""Maybe we can help you with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Remus Holstron: ""Mr. Hawker is proving to be an unreliable partner to us ..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Kill_OrsoHawker == false"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.YoungSords_Kill_OrsoHawker == false)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: ""I may require some help with getting rid of Orso Hawker.""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.YoungSords_Kill_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""You are late. Why is the Chief Justice still around?""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are late. Why is the Chief Justice still around?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Remus Holstron: ""We are talking about one of the most protected men in So..."*)

### Węzeł `[39]`
Mówca: **Remus Holstron**
> ""We are talking about one of the most protected men in Sordland here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Remus Holstron: ""Have some patience.""*)

### Węzeł `[40]`
Mówca: **Remus Holstron**
> ""Have some patience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Remus Holstron: ""Is there anything else you need?""*)

### Węzeł `[41]`
Mówca: **Remus Holstron**
> ""Mr. Hawker is proving to be an unreliable partner to us as well. I'm not against the idea of sending a message through him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Remus Holstron: ""I'll discuss this with the guys.""*)

### Węzeł `[42]`
Mówca: **Remus Holstron**
> ""I'll discuss this with the guys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Good. I'll be expecting the news.""*)
  - -> `[44]` (*Player: ""That settles it then.""*)
  - -> `[45]` (*Player: ""Maybe you got me wrong, Mr. Holstron. Let's just cancel ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good. I'll be expecting the news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Kill_OrsoHawker = true; BaseGame.Turn..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That settles it then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Kill_OrsoHawker = true; BaseGame.Turn..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe you got me wrong, Mr. Holstron. Let's just cancel this whole thing. This was a misunderstanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Remus Holstron: ""Oh? Okay...""*)

### Węzeł `[46]`
Mówca: **Remus Holstron**
> ""Oh? Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Remus Holstron: ""Well, if that was all, I'll have to go back to my work n..."*)

### Węzeł `[47]`
Mówca: **Remus Holstron**
> ""We can surely help with that, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Remus Holstron: ""If you can persuade Ms. Graf to restructure the forces t..."*)

### Węzeł `[48]`
Mówca: **Remus Holstron**
> ""If you can persuade Ms. Graf to restructure the forces to integrate us through a separate division...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Remus Holstron: ""The security situation will quickly improve.""*)

### Węzeł `[49]`
Mówca: **Remus Holstron**
> ""The security situation will quickly improve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""Consider it done. Prove your worth.""*)
  - -> `[51]` (*Player: ""Come to think of it, maybe this isn't the best idea.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Consider it done. Prove your worth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security = true; BaseGameSupport..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, maybe this isn't the best idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Remus Holstron: ""Oh? Okay.""*)

### Węzeł `[52]`
Mówca: **Remus Holstron**
> ""Oh? Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Remus Holstron: ""Well, if that was all, I'll have to go back to my work n..."*)

### Węzeł `[53]`
Mówca: **Remus Holstron**
> ""We can surely help with that, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Remus Holstron: ""You can count on the Young Sords to *protect* the ballot..."*)

### Węzeł `[54]`
Mówca: **Remus Holstron**
> ""You can count on the Young Sords to *protect* the ballots and the integrity of the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Remus Holstron: ""But we may ask you to transfer some funds to us in the f..."*)

### Węzeł `[55]`
Mówca: **Remus Holstron**
> ""But we may ask you to transfer some funds to us in the future to be able to organize efficiently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Understood. Just tell me whenever you need the money.""*)
  - -> `[57]` (*Player: ""Come to think of it, maybe this isn't the best idea.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Understood. Just tell me whenever you need the money.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Election = true; BaseGameSupport..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, maybe this isn't the best idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Remus Holstron: ""Oh? Okay.""*)

### Węzeł `[58]`
Mówca: **Remus Holstron**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Remus Holstron: ""You'll see the results whenever they're ready.""*)

### Węzeł `[59]`
Mówca: **Remus Holstron**
> ""You'll see the results whenever they're ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Remus Holstron: ""It was nice catching up with you, Mr. President. Take ca..."*)

### Węzeł `[60]`
Mówca: **Remus Holstron**
> ""It was nice catching up with you, Mr. President. Take care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The line dropped dead."*)

### Węzeł `[61]`
Mówca: **Remus Holstron**
> ""Is there anything else you need?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""Security in Sordland is still concerning. I require your..."*)
  - -> `[18]` (*Player: ""The elections are approaching. I require your help with ..."*)
