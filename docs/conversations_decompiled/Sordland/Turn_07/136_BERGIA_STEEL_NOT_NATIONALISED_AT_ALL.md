# Sordland/Turn07/BERGIA STEEL NOT NATIONALISED AT ALL

- **ID konwersacji:** `136`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/136_BERGIA_STEEL_NOT_NATIONALISED_AT_ALL.md`
- **Liczba węzłów dialogowych:** 158
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Malenyevist`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Sued_MarcelKoronti`
- `BaseGameSupport.Journal_Turn07_ImprisonedMarcel`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“No. There is no need.”"** | `[26]` **Walter Tusk**: "“An animal is most dangerous whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Walter Tusk**: "“Very well.”" |
| `[8]` | **"“You are right. Guards! Some time in Antel Rock Prison will teach him.”"** | `[26]` **Walter Tusk**: "“An animal is most dangerous whe..."<br>`[93]` **Marcel Koronti**: "“You son of a--”" | `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[13]` **Narrator**: "Two guards entered the room imme..." |
| `[25]` | **"“Mr. Koronti. I've showed you what I'm capable of. You will not threaten me... or ..."** | `[26]` **Walter Tusk**: "“An animal is most dangerous whe..."<br>`[93]` **Marcel Koronti**: "“You son of a--”" | `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false` | *Brak zmian stanu* | `[27]` **Marcel Koronti**: "“Or else what?"" |
| `[35]` | **"“No need for escalation. He doesn't have any power anymore.”"** | `[93]` **Marcel Koronti**: "“You son of a--”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Walter Tusk**: "“I wouldn't underestimate what h..." |
| `[48]` | **"“No hard feelings, Marcel.”"** | `[101]` **Marcel Koronti**: "“But as you still left me with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Marcel Koronti**: "“In our line of business, there ..." |
| `[60]` | **"“If I were you, I would worry about myself first.”"** | `[51]` **Marcel Koronti**: "“If you think you will end up un..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Marcel Koronti**: "“Right back at you.”" |
| `[61]` | **"“You have no power.”"** | `[51]` **Marcel Koronti**: "“If you think you will end up un..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“Do you think taking over my com..." |
| `[70]` | **"“I have no such illusions. But it is worth it to get rid of you.”"** | `[51]` **Marcel Koronti**: "“If you think you will end up un..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Marcel Koronti**: "“Wishful thinking.”" |
| `[76]` | **"“Don't forget. This could've gone much worse for you.”"** | `[101]` **Marcel Koronti**: "“But as you still left me with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Marcel Koronti**: "“And for you as well.”" |
| `[84]` | **"“Just sign it already.”"** | `[80]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Marcel Koronti**: "“I have to make sure I understan..." |
| `[90]` | **"“Stalling won't change the outcome.”"** | `[80]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Marcel Koronti**: "“I have to make sure I understan..." |
| `[95]` | **"“Is there a problem?”"** | `[80]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Marcel Koronti**: "“I have to make sure I understan..." |
| `[103]` | **"“Thanks for being cooperative.”"** | `[101]` **Marcel Koronti**: "“But as you still left me with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Marcel Koronti**: "“I will take my leave then.”" |
| `[122]` | **""Yes, that's why I only took a minority share.""** | `[118]` **Marcel Koronti**: ""Do you know how hard I've worke..." | `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2` | *Brak zmian stanu* | `[125]` **Marcel Koronti**: ""So you stabbed me in the back b..." |
| `[123]` | **""I don't need your deal now that I have your company.""** | `[118]` **Marcel Koronti**: ""Do you know how hard I've worke..." | `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false` | *Brak zmian stanu* | `[130]` **Narrator**: "Marcel's face darkened." |
| `[124]` | **""I don't need your deal anymore. The papers love me.""** | `[118]` **Marcel Koronti**: ""Do you know how hard I've worke..." | `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2` | *Brak zmian stanu* | `[128]` **Marcel Koronti**: ""Do they, now? We'll see about t..." |
| `[128]` | **""Do they, now? We'll see about that.""** | `[124]` **Player**: ""I don't need your deal anymore...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Marcel Koronti**: ""The deal is over. And so is you..." |
| `[129]` | **""And I appreciate that. But not as much as I appreciate your shares.""** | `[118]` **Marcel Koronti**: ""Do you know how hard I've worke..." | `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false` | *Brak zmian stanu* | `[130]` **Narrator**: "Marcel's face darkened." |
| `[135]` | **"“I'm a few steps ahead of you, Walter. I've launched an investigation that will un..."** | `[26]` **Walter Tusk**: "“An animal is most dangerous whe..."<br>`[93]` **Marcel Koronti**: "“You son of a--”" | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[137]` **Player**: ""And yours, in case you get on m..."<br>`[139]` **Player**: ""You can't hide anything from me..." |
| `[137]` | **""And yours, in case you get on my bad side.""** | `[135]` **Player**: "“I'm a few steps ahead of you, W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "Walter looked at me disbelievingly." |
| `[139]` | **""You can't hide anything from me, Koronti.""** | `[135]` **Player**: "“I'm a few steps ahead of you, W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Marcel snorted." |

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
  - -> `[34]` (*Narrator: "Walter was watching Marcel with a vile smirk on his face."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Cuffed by the two guards, Marcel Koronti left the room. Walter Tusk followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti = true; BaseGame.R..."*)

### Węzeł `[4]`
Mówca: **Walter Tusk**
> "“I am not you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Cuffed by the two guards, Marcel Koronti left the room. W..."*)

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“Mr. President! You are being played by this man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Marcel Koronti: "“Mark my words. One day he will turn on you as well.”"*)

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: "“I am not you, Marcel.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Walter Tusk: "“Very well.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk), `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Two guards entered the room immediately and started to ap..."*)

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“No. No, no, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Marcel Koronti: "“You can't do this to me.”"*)

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“You can't do this to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“Mr. President! You are being played by this man.”"*)

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You totalist dog!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Marcel Koronti: "“Dictator!”"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Two guards entered the room immediately and started to apprehend Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Marcel Koronti: "“No. No, no, no.""*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Marcel packed his belongings and furiously exited the room, closing the door loudly. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“I will destroy you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Walter Tusk: "“Good luck doing that behind bars.”"*)

### Węzeł `[16]`
Mówca: **Marcel Koronti**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Marcel Koronti: "“Get your hands off of me!”"*)

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Walter Tusk: "“Serves you right. Good riddance, Marcel.”"*)

### Węzeł `[18]`
Mówca: **Marcel Koronti**
> "“Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Walter chuckled."*)

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“Serves you right. Good riddance, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“I will make sure to pay a visit sometime.”"*)

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I will make sure to pay a visit sometime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Marcel Koronti: "“Walter!”"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“You are right. Guards! Some time in Antel Rock Prison wi..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“Mr. Koronti. I've showed you what I'm capable of. You wi..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“Walter!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“I will destroy you!”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Mr. Koronti. I've showed you what I'm capable of. You will not threaten me... or else.""]** — Mówca: **Player**
> "“Mr. Koronti. I've showed you what I'm capable of. You will not threaten me... or else.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk), `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Marcel Koronti: "“Or else what?""*)

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“An animal is most dangerous when he is cornered. A man like Marcel would prove...difficult in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“No. There is no need.”"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Marcel Koronti: "“Do you know who I am?""*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He turned back towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Marcel Koronti: ""I'll see you both in hell.""*)

### Węzeł `[29]`
Mówca: **Marcel Koronti**
> "“Fuck off, Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He turned back towards me."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Marcel packed his belongings and furiously exited the room, closing the door loudly. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Sued_MarcelKoronti = true"*)

### Węzeł `[31]`
Mówca: **Walter Tusk**
> "“I'll tell you who you are, Marcel. You're a petulant child who's not fit to shit in his father's toilet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Marcel Koronti: "“Fuck off, Tusk.""*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Walter chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Walter Tusk: "“I'll tell you who you are, Marcel. You're a petulant chi..."*)

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“There you go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Walter was watching Marcel with a vile smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Walter Tusk: "“Did you think you could go behind my back, boy?”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“No need for escalation. He doesn't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. He doesn't have any power anymore.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Walter Tusk: "“I wouldn't underestimate what he can do, President.”"*)

### Węzeł `[36]`
Mówca: **Walter Tusk**
> "“Did you think you could go behind my back, boy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Walter Tusk: "“Come on. I wouldn't be in my position if I didn't know h..."*)

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“No. I am not happy at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Marcel Koronti: "“But as you still left me with a significant portion of m..."*)

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“Come on. I wouldn't be in my position if I didn't know how to play my cards right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Walter Tusk: "“You still have a lot to learn.”"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Marcel reluctantly signed the papers after letting out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“My pen, please.”"*)

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“You still have a lot to learn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Walter Tusk: "“Now that Daddy isn't around to hold your hand.”"*)

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“My pen, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Marcel Koronti: "“Take your stupid pen.”"*)

### Węzeł `[42]`
Mówca: **Walter Tusk**
> "“Now that Daddy isn't around to hold your hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Marcel Koronti: "“Shut up, Walter.”"*)

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“Take your stupid pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He turned to me, eyes blazing.""*)

### Węzeł `[44]`
Mówca: **Marcel Koronti**
> "“Shut up, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 2"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 2"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization == 2)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "He turned to me."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization == 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“Gentlemen. Before the conversation is derailed further...”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“No hard feelings, Marcel.”"]** — Mówca: **Player**
> "“No hard feelings, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Marcel Koronti: "“In our line of business, there is no place for feelings.”"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Marcel Koronti: "“If you think you will end up unscathed after this, think..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "He turned to me, eyes blazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[51]`
Mówca: **Marcel Koronti**
> "“If you think you will end up unscathed after this, think again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“If I were you, I would worry about myself first.”"*)
  - -> `[61]` (*Player: "“You have no power.”"*)
  - -> `[70]` (*Player: "“I have no such illusions. But it is worth it to get rid ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Walter immediately produced a pen from his pocket and put it in front of Marcel with a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The pen had a large Bergia Steel symbol with the name of ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization <= 1"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization <= 1)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Marcel Koronti: "“Mr. President. I am not happy.”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Marcel Koronti: "“You can forget about getting re-elected, Mr. *President*.”"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The pen had a large Bergia Steel symbol with the name of the company engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Walter Tusk: "“There you go.”"*)

### Węzeł `[57]`
Mówca: **Walter Tusk**
> "“Mr. President. Are you just going to stay silent in the face of these blatant threats?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Walter Tusk: "“He needs to be punished swiftly. Surely you can't let hi..."*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“I have to make sure I understand an agreement that takes my whole life's effort away from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He started checking his pockets."*)

### Węzeł `[59]`
Mówca: **Marcel Koronti**
> "“Mr. President. I am not happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Marcel Koronti: "“No. I am not happy at all.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“If I were you, I would worry about myself first.”"]** — Mówca: **Player**
> "“If I were you, I would worry about myself first.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Marcel Koronti: "“Right back at you.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“You have no power.”"]** — Mówca: **Player**
> "“You have no power.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“Do you think taking over my company will end me?”"*)

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Walter Tusk: "“See, Marcel?”"*)

### Węzeł `[63]`
Mówca: **Walter Tusk**
> "“See, Marcel?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Walter Tusk: "“This is called graciousness and mercy.”"*)

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“This is called graciousness and mercy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Two traits that you have never had.”"*)

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Two traits that you have never had.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Marcel Koronti: "“Your words don't work on me, Tusk.”"*)

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> "“Your words don't work on me, Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Marcel Koronti: "“Mr. President. You are being played.”"*)

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Mr. President. You are being played.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Marcel Koronti: "“Mark my words. One day he will turn on you as well.”"*)

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“I am not you, Marcel.”"*)

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“I am not you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Marcel Koronti: "“Mr. President. Walter. I'll see you both in hell.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I have no such illusions. But it is worth it to get rid of you.”"]** — Mówca: **Player**
> "“I have no such illusions. But it is worth it to get rid of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Marcel Koronti: "“Wishful thinking.”"*)

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“Wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“Gentlemen. Before the conversation is derailed further...”"*)

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Right back at you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“Gentlemen. Before the conversation is derailed further...”"*)

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“Do you think taking over my company will end me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“Gentlemen. Before the conversation is derailed further...”"*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Walter immediately produced a pen from his pocket and put..."*)

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“You can forget about getting re-elected, Mr. *President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Marcel Koronti: "“I will make sure it doesn't happen.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Don't forget. This could've gone much worse for you.”"]** — Mówca: **Player**
> "“Don't forget. This could've gone much worse for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“And for you as well.”"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He started checking his pockets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“I don't have a pen.”"*)

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“Mr. President. Walter. I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Marcel packed his belongings and furiously exited the roo..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“Gentlemen. Before the conversation is derailed further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Lucian moved over to Marcel and fanned out the agreement ..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Just sign it already.”"*)
  - -> `[90]` (*Player: "“Stalling won't change the outcome.”"*)
  - -> `[95]` (*Player: "“Is there a problem?”"*)

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“I will make sure it doesn't happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Here is the agreement that pertains to the nationalization of HOS and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He pointed to various sections on various pages of the do..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Lucian moved over to Marcel and fanned out the agreement papers in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“Mr. Koronti. Here is the agreement that pertains to the ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Just sign it already.”"]** — Mówca: **Player**
> "“Just sign it already.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Walter Tusk: "“Go cry about it in one of your silly newspapers. Oh, wai..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Marcel Koronti: "“Don't you realize that I know everything about you?”"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Walter Tusk: "“Did you just threaten the President of Sordland?”"*)

### Węzeł `[89]`
Mówca: **Marcel Koronti**
> "“I've been keeping a tight lid on secrets that could end you. Wouldn't it be a shame if they got out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Walter Tusk: "“Did you just threaten the President of Sordland?”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Stalling won't change the outcome.”"]** — Mówca: **Player**
> "“Stalling won't change the outcome.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[91]`
Mówca: **Walter Tusk**
> "“He needs to be punished swiftly. Surely you can't let him speak to you like that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Marcel Koronti: "“You son of a--”"*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Marcel Koronti: "“I won't sign anything without reading it first.”"*)

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“You son of a--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“No need for escalation. He doesn't have any power anymore.”"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "He pointed to various sections on various pages of the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Is there a problem?”"]** — Mówca: **Player**
> "“Is there a problem?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“And for you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“I will take my leave then.”"*)

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“I wouldn't underestimate what he can do, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Walter Tusk: "“An animal is most dangerous when he is cornered. A man l..."*)

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“I won't sign anything without reading it first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He started going through the papers."*)

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“I will take my leave then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Marcel Koronti: "“And Walter, next time I see you, you'll be begging me fo..."*)

### Węzeł `[100]`
Mówca: **Walter Tusk**
> "“Go cry about it in one of your silly newspapers. Oh, wait -- they aren't yours anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Marcel packed his belongings and left the meeting room. W..."*)

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“But as you still left me with a significant portion of my company, let's say that I am ready to put this unfortunate decision behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“Thanks for being cooperative.”"*)
  - -> `[48]` (*Player: "“No hard feelings, Marcel.”"*)
  - -> `[76]` (*Player: "“Don't forget. This could've gone much worse for you.”"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Marcel packed his belongings and left the meeting room. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“I will take my leave then.”"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "When he finished, he turned back to the first page and went over the whole stack again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "And again..."*)

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“This is ridiculous! Know your place, little boy!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Walter Tusk: "“Mr. President. Are you just going to stay silent in the ..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He started going through the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "When he finished, he turned back to the first page and we..."*)

### Węzeł `[107]`
Mówca: **Marcel Koronti**
> "“Don't you realize that I know everything about you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Marcel Koronti: "“I've been keeping a tight lid on secrets that could end ..."*)

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“And Walter, next time I see you, you'll be begging me for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Walter Tusk: "“Hah.”"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "And again..."*)

### Węzeł `[110]`
Mówca: **Walter Tusk**
> "“Did you just threaten the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Walter Tusk: "“This is ridiculous! Know your place, little boy!”"*)

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“In our line of business, there is no place for feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“I will take my leave then.”"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti = true; BaseGame.Relations_Marcel_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_ImprisonedMarcel = true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Sued_MarcelKoronti = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Sued_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Marcel Koronti: ""We had a deal, Rayne.""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization <= 1"*)

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> ""We had a deal, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Marcel Koronti: ""Do you know how hard I've worked for you? How much sleep..."*)

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> ""Do you know how hard I've worked for you? How much sleep I've lost cleaning up your messes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization >= 2"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization >= 2"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization >= 2)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Yes, that's why I only took a minority share.""*)
  - -> `[124]` (*Player: ""I don't need your deal anymore. The papers love me.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""I don't need your deal now that I have your company.""*)
  - -> `[129]` (*Player: ""And I appreciate that. But not as much as I appreciate y..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Yes, that's why I only took a minority share.""]** — Mówca: **Player**
> ""Yes, that's why I only took a minority share.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Marcel Koronti: ""So you stabbed me in the back but failed to put the knif..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I don't need your deal now that I have your company.""]** — Mówca: **Player**
> ""I don't need your deal now that I have your company.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Marcel's face darkened."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I don't need your deal anymore. The papers love me.""]** — Mówca: **Player**
> ""I don't need your deal anymore. The papers love me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Marcel Koronti: ""Do they, now? We'll see about that.""*)

### Węzeł `[125]`
Mówca: **Marcel Koronti**
> ""So you stabbed me in the back but failed to put the knife in all the way. Big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: ""The deal is over. And so is your presidency.""*)

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> ""The deal is over. And so is your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = false"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Walter Tusk: "“Did you just threaten the President of Sordland?”"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Do they, now? We'll see about that.""]** — Mówca: **Marcel Koronti**
> ""Do they, now? We'll see about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: ""The deal is over. And so is your presidency.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""And I appreciate that. But not as much as I appreciate your shares.""]** — Mówca: **Player**
> ""And I appreciate that. But not as much as I appreciate your shares.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Marcel's face darkened."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Marcel's face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Marcel Koronti: ""A traitor and an idiot. Impressive.""*)

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> ""A traitor and an idiot. Impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Marcel Koronti: "“Don't you realize that I know everything about you?”"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: "“I'm a few steps ahead of you, Walter. I've launched an i..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[135]`
**[WYBÓR GRACZA: "“I'm a few steps ahead of you, Walter. I've launched an investigation that will uncover all of Marcel's secrets.""]** — Mówca: **Player**
> "“I'm a few steps ahead of you, Walter. I've launched an investigation that will uncover all of Marcel's secrets.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk), `[93]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""And yours, in case you get on my bad side.""*)
  - -> `[139]` (*Player: ""You can't hide anything from me, Koronti.""*)

### Węzeł `[136]`
Mówca: **Marcel Koronti**
> ""I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Marcel packed his belongings and furiously exited the roo..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""And yours, in case you get on my bad side.""]** — Mówca: **Player**
> ""And yours, in case you get on my bad side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Walter looked at me disbelievingly."*)

### Węzeł `[138]`
Mówca: **Walter Tusk**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""You can't hide anything from me, Koronti.""]** — Mówca: **Player**
> ""You can't hide anything from me, Koronti.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Marcel snorted."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Marcel Koronti: ""That makes two of us. Watch your back, Rayne.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Marcel Koronti: ""Listen, you coward. Even if I did have something to hide..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Walter looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Marcel Koronti: ""I'll see you both in hell.""*)

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> ""Listen, you coward. Even if I did have something to hide, I've got an army of lawyers that can disprove it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Walter Tusk: "“I wonder if they will stand by you when you don't have e..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Marcel snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Marcel Koronti: ""Listen, you coward. Even if I did have something to hide..."*)

### Węzeł `[147]`
Mówca: **Walter Tusk**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Marcel Koronti: "“Don't underestimate me.”"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Walter Tusk: ""Don't forget I know a thing or two about you as well.""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Marcel Koronti: ""Listen, you coward. Even if I did have something to hide..."*)

### Węzeł `[151]`
Mówca: **Marcel Koronti**
> ""That makes two of us. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Marcel Koronti: ""I'll see you both in hell.""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_ImprisonedMarcel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 12)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Marcel Koronti: "“You Malenyevist pig!”"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 12)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Marcel Koronti: "“You totalist dog!”"*)

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“You Malenyevist pig!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Marcel Koronti: "“Dictator!”"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Marcel reluctantly signed the papers after letting out a ..."*)
