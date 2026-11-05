# Sordland/Turn07/HOS NOT NATIONALISED AT ALL

- **ID konwersacji:** `137`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/137_HOS_NOT_NATIONALISED_AT_ALL.md`
- **Liczba węzłów dialogowych:** 144
- **Liczba wyborów gracza:** 17

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
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Malenyevist`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MikailAven`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Walter_Enemy`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Sued_WalterTusk`
- `BaseGameSupport.Journal_Turn07_ImprisonedTusk`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“You are right. Guards! Some time in Antel Rock Prison will teach him.”"** | `[102]` **Walter Tusk**: "“You little...”"<br>`[106]` **Marcel Koronti**: "“An animal is most dangerous whe..." | `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[37]` **Narrator**: "Two guards waiting outside enter..." |
| `[18]` | **"“That's enough, both of you.”"** | `[14]` **Walter Tusk**: "“Your time will come. Be sure of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Walter Tusk**: "“I'm not the one who put us in t..." |
| `[19]` | **"“You are right. Guards! Mr. Tusk will join Mr. Aven in Antel Rock Prison.”"** | `[102]` **Walter Tusk**: "“You little...”"<br>`[106]` **Marcel Koronti**: "“An animal is most dangerous whe..." | `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[37]` **Narrator**: "Two guards waiting outside enter..." |
| `[20]` | **"“Marcel. Shut up.”"** | `[14]` **Walter Tusk**: "“Your time will come. Be sure of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Marcel Koronti**: "“My apologies. Of course, Mr. Pr..." |
| `[21]` | **"“Marcel is right. You are done, Walter.”"** | `[14]` **Walter Tusk**: "“Your time will come. Be sure of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Marcel Koronti**: "“You heard the President, Walter.”" |
| `[42]` | **"“Mr. Tusk. I've already showed you what I'm capable of. You will stand down... or ..."** | `[102]` **Walter Tusk**: "“You little...”"<br>`[106]` **Marcel Koronti**: "“An animal is most dangerous whe..." | `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false` | *Brak zmian stanu* | `[23]` **Walter Tusk**: "“Or else what?"" |
| `[49]` | **"“No need for escalation. He doesn't have any power anymore.”"** | `[102]` **Walter Tusk**: "“You little...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Marcel Koronti**: "“I wouldn't underestimate what h..." |
| `[59]` | **"“Just sign it already.”"** | `[53]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“I have to make sure I understan..." |
| `[60]` | **"“Stalling won't change the outcome.”"** | `[53]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“I have to make sure I understan..." |
| `[61]` | **"“Is there a problem?”"** | `[53]` **Narrator**: "And again..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“I have to make sure I understan..." |
| `[77]` | **"“No. There is no need.”"** | `[106]` **Marcel Koronti**: "“An animal is most dangerous whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Marcel Koronti**: "“Very well.”" |
| `[109]` | **"“Don't forget. This could've gone much worse for you.”"** | `[108]` **Walter Tusk**: "“We will see about that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Walter Tusk**: "“Thanks for the reminder, Mr. Ra..." |
| `[113]` | **"“No hard feelings, Walter.”"** | `[108]` **Walter Tusk**: "“We will see about that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Walter Tusk**: "“Not at all.”" |
| `[114]` | **"“Thanks for being cooperative.”"** | `[108]` **Walter Tusk**: "“We will see about that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Walter Tusk**: "“I will see you later.”" |
| `[119]` | **"“I'm a few steps ahead of you, Marcel. I've launched an investigation that will un..."** | `[102]` **Walter Tusk**: "“You little...”"<br>`[106]` **Marcel Koronti**: "“An animal is most dangerous whe..." | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[120]` **Player**: ""And yours, in case you get on m..."<br>`[121]` **Player**: ""You can't hide anything from me..." |
| `[120]` | **""And yours, in case you get on my bad side.""** | `[119]` **Player**: "“I'm a few steps ahead of you, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "Marcel looked at me disbelievingly." |
| `[121]` | **""You can't hide anything from me, Walter.""** | `[119]` **Player**: "“I'm a few steps ahead of you, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "Walter snorted." |

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
  - -> `[3]` (*Narrator: "Marcel was watching Walter with a vile smirk on his face."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Marcel was watching Walter with a vile smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: "“Aren't you enjoying this a bit too much?”"*)

### Węzeł `[4]`
Mówca: **Walter Tusk**
> "“Aren't you enjoying this a bit too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“Come now, Walter. No need to be a sore loser.”"*)

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“Come now, Walter. No need to be a sore loser.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Marcel Koronti: "“And watch your words. You are right in front of the Pres..."*)

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“And watch your words. You are right in front of the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Walter Tusk: "“You little snake. You are just like your father.“"*)

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“You little snake. You are just like your father.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“Whatever you say won't change the fact that you are done..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Walter Tusk), `[106]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Two guards waiting outside entered the room immediately a..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true && BaseGame.Be..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true && BaseGame...."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Walter Tusk: "“You are putting me in a difficult position.”"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Walter Tusk: "“I will never forget what you have done to me.”"*)

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You can't make anyone do anything anymore, you toothless old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Walter angrily stuffed the agreement in his briefcase and..."*)

### Węzeł `[13]`
Mówca: **Marcel Koronti**
> "“And Korontis always keep their word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Cuffed by the two guards, Walter Tusk left the room. Marc..."*)

### Węzeł `[14]`
Mówca: **Walter Tusk**
> "“Your time will come. Be sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“Marcel. Shut up.”"*)
  - -> `[18]` (*Player: "“That's enough, both of you.”"*)
  - -> `[21]` (*Player: "“Marcel is right. You are done, Walter.”"*)

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“Whatever you say won't change the fact that you are done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Walter Tusk: "“Your time will come. Be sure of that.”"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Cuffed by the two guards, Walter Tusk left the room. Marcel left shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Rela..."*)

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“No matter what, I have my honor as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Marcel Koronti: "“And Korontis always keep their word.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“That's enough, both of you.”"]** — Mówca: **Player**
> "“That's enough, both of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“I'm not the one who put us in this position, Mr. Preside..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You are right. Guards! Mr. Tusk will join Mr. Aven in Antel Rock Prison.”"]** — Mówca: **Player**
> "“You are right. Guards! Mr. Tusk will join Mr. Aven in Antel Rock Prison.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Walter Tusk), `[106]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Two guards waiting outside entered the room immediately a..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Marcel. Shut up.”"]** — Mówca: **Player**
> "“Marcel. Shut up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Marcel Koronti: "“My apologies. Of course, Mr. President.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Marcel is right. You are done, Walter.”"]** — Mówca: **Player**
> "“Marcel is right. You are done, Walter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Marcel Koronti: "“You heard the President, Walter.”"*)

### Węzeł `[22]`
Mówca: **Marcel Koronti**
> "“I am not you, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Marcel Koronti: "“No matter what, I have my honor as a Koronti.”"*)

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Walter Tusk: "“Do you know who I am?""*)

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“I'm not the one who put us in this position, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: "“Mr. Tusk. You heard the President.”"*)

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Marcel Koronti: "“I am not you, Walter.”"*)

### Węzeł `[26]`
Mówca: **Marcel Koronti**
> "“My apologies. Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“Now then. Before the conversation is derailed any furthe..."*)

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“See, Walter?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Marcel Koronti: "“This is called graciousness and mercy.”"*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“Mr. Tusk. You heard the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“Now then. Before the conversation is derailed any furthe..."*)

### Węzeł `[29]`
Mówca: **Marcel Koronti**
> "“You heard the President, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“Now then. Before the conversation is derailed any furthe..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“Mr. Tusk. I've already showed you what I'm capable of. Y..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Now then. Before the conversation is derailed any further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Lucian moved over to Walter and fanned the agreement pape..."*)

### Węzeł `[34]`
Mówca: **Walter Tusk**
> "“Mr. Rayne! You are being played by this man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“Mark my words. One day he will turn on you as well.”"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Walter stuffed the agreement in his briefcase and exited the room, closing the door with a loud bang. Marcel left shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Lucian moved over to Walter and fanned the agreement papers out in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: "“Mr. Tusk. Here is the agreement that pertains to the nat..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Two guards waiting outside entered the room immediately and grabbed Walter Tusk's arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Walter Tusk: "“No. No, no no.""*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“Mr. Tusk. Here is the agreement that pertains to the nationalization of Bergia Steel and the transfer of the entirety of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He pointed to various sections on various pages of the do..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Walter angrily stuffed the agreement in his briefcase and left the meeting room. Marcel followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Walter Tusk: "“Mr. Rayne! You are being played by this man.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "He pointed to various sections on various pages of the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Mr. Tusk. I've already showed you what I'm capable of. You will stand down... or else.""]** — Mówca: **Player**
> "“Mr. Tusk. I've already showed you what I'm capable of. You will stand down... or else.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Walter Tusk), `[106]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Walter Tusk: "“Or else what?""*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Walter Tusk: "“I won't sign anything without reading it first.”"*)

### Węzeł `[44]`
Mówca: **Walter Tusk**
> "“I won't sign anything without reading it first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He started going through the papers."*)

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“Rayne. I hope I never see your face again in my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Walter stuffed the agreement in his briefcase and exited ..."*)

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“I will destroy you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Marcel Koronti: "“Good luck doing that behind bars.”"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He started going through the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "When he finished, he turned back to the first page and we..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "When he finished, he turned back to the first page and went over the whole stack again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "And again..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“No need for escalation. He doesn't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. He doesn't have any power anymore.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Marcel Koronti: "“I wouldn't underestimate what he can do, Mr. President.”"*)

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Marcel Koronti: "“See, Walter?”"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "And again..."*)

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Walter Tusk: "“Rayne. I hope I never see your face again in my life.”"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Just sign it already.”"*)
  - -> `[60]` (*Player: "“Stalling won't change the outcome.”"*)
  - -> `[61]` (*Player: "“Is there a problem?”"*)

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Marcel!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Walter Tusk: "“I will destroy you!""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MikailAven == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“You are right. Guards! Mr. Tusk will join Mr. Aven in An..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MikailAven == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“You are right. Guards! Some time in Antel Rock Prison wi..."*)

### Węzeł `[58]`
Mówca: **Walter Tusk**
> "“I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Walter Tusk: "“Your time will come too, Mr. President. Believe me.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Just sign it already.”"]** — Mówca: **Player**
> "“Just sign it already.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Stalling won't change the outcome.”"]** — Mówca: **Player**
> "“Stalling won't change the outcome.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Is there a problem?”"]** — Mówca: **Player**
> "“Is there a problem?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“I have to make sure I understand an agreement that takes..."*)

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“And Korontis always keep their word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“Don't underestimate me.”"*)

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“I will make sure to pay a visit sometime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: "“Marcel!”"*)

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Walter Tusk: "“I've been chewing up and spitting out Sordish politician..."*)

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“I have to make sure I understand an agreement that takes my whole life's effort away from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He started checking his pockets."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He started checking his pockets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Walter Tusk: "“I don't have a pen.”"*)

### Węzeł `[67]`
Mówca: **Walter Tusk**
> "“You can't do this to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)

### Węzeł `[68]`
Mówca: **Walter Tusk**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Marcel immediately produced a pen from his pocket and put..."*)

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“Thanks for the reminder, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: "“I will see you later.”"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Marcel immediately produced a pen from his pocket and put it in front of Walter with a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The pen had a large Heart of Sordland symbol with the nam..."*)

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“No matter what, I have my honor as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Marcel Koronti: "“And Korontis always keep their word.”"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The pen had a large Heart of Sordland symbol with the name of the company engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“There you go.”"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Walter packed his belongings and furiously exited the room, slamming the door loudly. Marcel followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“There you go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“Serves you right. Good riddance, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Marcel Koronti: "“I will make sure to pay a visit sometime.”"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Walter reluctantly signed the papers after letting out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Marcel Koronti: "“My pen, please.”"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Marcel Koronti: "“Very well.”"*)

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“My pen, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Walter Tusk: "“Take your damn pen.”"*)

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“I wouldn't underestimate what he can do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Marcel Koronti: "“An animal is most dangerous when it is cornered. A man w..."*)

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Take your damn pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He turned to me."*)

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“This is called graciousness and mercy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Marcel Koronti: "“Two traits that you have never had.”"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true && BaseGame.Be..."*)

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“I am not you, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Marcel Koronti: "“No matter what, I have my honor as a Koronti.”"*)

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Marcel Koronti: "“You can't make anyone do anything anymore, you toothless..."*)

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Marcel Koronti: "“Serves you right. Good riddance, Walter.”"*)

### Węzeł `[86]`
Mówca: **Walter Tusk**
> "“You are putting me in a difficult position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Walter Tusk: "“However, I understand.”"*)

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“I will see you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Walter Tusk: "“And this isn't over, Marcel. Next time I see you, I will..."*)

### Węzeł `[88]`
Mówca: **Walter Tusk**
> "“Not at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: "“I will see you later.”"*)

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“However, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Walter Tusk: "“This could've turned out much worse for me *and* you if ..."*)

### Węzeł `[90]`
Mówca: **Walter Tusk**
> "“Your time will come too, Mr. President. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Marcel Koronti: "“Did you just threaten the President of Sordland?”"*)

### Węzeł `[91]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. Are you just going to stay silent in the face of these blatant threats?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Marcel Koronti: "“He needs to be punished swiftly. Surely you can't let hi..."*)

### Węzeł `[92]`
Mówca: **Walter Tusk**
> "“This could've turned out much worse for me *and* you if not for our...friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Walter Tusk: "“The paperwork is done so I will take my leave, President.”"*)

### Węzeł `[93]`
Mówca: **Walter Tusk**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Marcel Koronti: "“I am not you, Walter.”"*)

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“Did you just threaten the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Marcel Koronti: "“This is ridiculous! Know your place!”"*)

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“And this isn't over, Marcel. Next time I see you, I will make you beg me for forgiveness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Marcel Koronti: "“Hah.”"*)

### Węzeł `[96]`
Mówca: **Walter Tusk**
> "“The paperwork is done so I will take my leave, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Walter Tusk: "“Be careful about this weasel.”"*)

### Węzeł `[97]`
Mówca: **Walter Tusk**
> ""Fuck off, Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: ""I'll see you both in hell.""*)

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“This is ridiculous! Know your place!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Marcel Koronti: "“Mr. Rayne. Are you just going to stay silent in the face..."*)

### Węzeł `[99]`
Mówca: **Walter Tusk**
> "“No. No, no no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Walter Tusk: "“You can't do this to me.”"*)

### Węzeł `[100]`
Mówca: **Walter Tusk**
> "“Be careful about this weasel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Marcel Koronti: "“Your words hold no weight, old man.”"*)

### Węzeł `[101]`
Mówca: **Walter Tusk**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Walter Tusk: "“Get your hands off of me!”"*)

### Węzeł `[102]`
Mówca: **Walter Tusk**
> "“You little...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“No need for escalation. He doesn't have any power anymore.”"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[103]`
Mówca: **Walter Tusk**
> "“President Rayne. You are being played by Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Walter Tusk: "“Mark my words. One day he will turn on you as well.”"*)

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“Your words hold no weight, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Walter Tusk: "“We will see about that.”"*)

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“He needs to be punished swiftly. Surely you can't let him speak to you like that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Walter Tusk: "“You little...”"*)

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“An animal is most dangerous when it is cornered. A man with Tusk's connections would prove...difficult in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“No. There is no need.”"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“I've been chewing up and spitting out Sordish politicians since you were in diapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Marcel Koronti: "“I wonder how you'll do that now that you don't have any ..."*)

### Węzeł `[108]`
Mówca: **Walter Tusk**
> "“We will see about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“Thanks for being cooperative.”"*)
  - -> `[113]` (*Player: "“No hard feelings, Walter.”"*)
  - -> `[109]` (*Player: "“Don't forget. This could've gone much worse for you.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Don't forget. This could've gone much worse for you.”"]** — Mówca: **Player**
> "“Don't forget. This could've gone much worse for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“Thanks for the reminder, Mr. Rayne.”"*)

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“I wonder how you'll do that now that you don't have any teeth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Walter Tusk: ""Fuck off, Koronti.""*)

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“Two traits that you have never had.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Walter Tusk: "“Your words don't work on me, snake.”"*)

### Węzeł `[112]`
Mówca: **Walter Tusk**
> "“Your words don't work on me, snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Walter Tusk: "“President Rayne. You are being played by Marcel.”"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“No hard feelings, Walter.”"]** — Mówca: **Player**
> "“No hard feelings, Walter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Walter Tusk: "“Not at all.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: "“I will see you later.”"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Relations_Walter_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true;
Variable["BaseGame.Relations_Walter_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_ImprisonedTusk = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“I'm a few steps ahead of you, Marcel. I've launched an i..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I'm a few steps ahead of you, Marcel. I've launched an investigation that will uncover all of Mr. Tusk's secrets.""]** — Mówca: **Player**
> "“I'm a few steps ahead of you, Marcel. I've launched an investigation that will uncover all of Mr. Tusk's secrets.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Walter Tusk), `[106]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""And yours, in case you get on my bad side.""*)
  - -> `[121]` (*Player: ""You can't hide anything from me, Walter.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""And yours, in case you get on my bad side.""]** — Mówca: **Player**
> ""And yours, in case you get on my bad side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Marcel looked at me disbelievingly."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""You can't hide anything from me, Walter.""]** — Mówca: **Player**
> ""You can't hide anything from me, Walter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Walter snorted."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Marcel looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[123]`
Mówca: **Marcel Koronti**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Marcel Koronti: ""Don't forget I know a thing or two about you as well.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Walter Tusk: ""Listen, you halfwit. Even if I did have something to hid..."*)

### Węzeł `[127]`
Mówca: **Walter Tusk**
> ""We both do. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: ""I'll see you both in hell.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Walter Tusk: ""We both do. Watch your back, Rayne.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Walter Tusk: ""Listen, you halfwit. Even if I did have something to hid..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Walter snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Walter Tusk: ""Listen, you halfwit. Even if I did have something to hid..."*)

### Węzeł `[132]`
Mówca: **Walter Tusk**
> ""Listen, you halfwit. Even if I did have something to hide, I've got an army of lawyers that can disprove it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Marcel Koronti: "“I wonder if they will stand by you when you don't have e..."*)

### Węzeł `[133]`
Mówca: **Marcel Koronti**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Walter Tusk: "“Don't underestimate me.”"*)

### Węzeł `[134]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: ""I'll see you both in hell.""*)

### Węzeł `[135]`
Mówca: **Walter Tusk**
> ""I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Sued_WalterTusk = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_ImprisonedTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Sued_WalterTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Sued_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Walter packed his belongings and furiously exited the roo..."*)

### Węzeł `[138]`
Mówca: **Walter Tusk**
> "“You Malenyevist goat!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Walter Tusk: "“Dictator!”"*)

### Węzeł `[139]`
Mówca: **Walter Tusk**
> "“You totalist donkey!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Walter Tusk: "“Dictator!”"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 12"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 12)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 12`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Walter Tusk: "“You Malenyevist goat!”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 12)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Walter Tusk: "“You totalist donkey!”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Walter reluctantly signed the papers after letting out a ..."*)
