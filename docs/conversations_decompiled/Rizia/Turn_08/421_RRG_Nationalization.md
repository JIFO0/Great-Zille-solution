# Rizia/Turn 8/RRG Nationalization

- **ID konwersacji:** `421`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/421_RRG_Nationalization.md`
- **Liczba węzłów dialogowych:** 155
- **Liczba wyborów gracza:** 14

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[80]** Elena Werner
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.HODElection_RustyInfluence_RNC`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_ExposedViaAlvarez`
- `RiziaDLC.Rusty_GrantROGStake`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_RRG_Nationalization`
- `RiziaDLC.Energy_Modifier_SoldROGStake`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_GrantROGStake`
- `RiziaDLCSupport.Journal_Turn08_Decision_RustyLespiaAgentArrest_Arrest`
- `RiziaDLCSupport.News_Turn08_V_RRGNationalization`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[437]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""It doesn't matter. A traitor's a traitor.""** | `[4]` **Elena Werner**: ""However, most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucita Azaro**: ""Agreed. This document alone is ..."<br>`[13]` **Titus Gordion**: ""The information here is more th..."<br>*(oraz 1 innych odgałęzień)* |
| `[6]` | **""The Rizian state owns a significant part of RRG. How could we have let this go un..."** | `[4]` **Elena Werner**: ""However, most of the pertinent ..."<br>`[128]` **Elena Werner**: ""Although most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Elena Werner**: ""A corporation as large as RRG p..." |
| `[7]` | **""Lespia has lied to us about a great many things. Why not this?""** | `[4]` **Elena Werner**: ""However, most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Elena Werner**: ""We've verified what little info..." |
| `[8]` | **""Covering up Lespia's involvement in the Wehlen bombing was a huge favor. This is ..."** | `[4]` **Elena Werner**: ""However, most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucita Azaro**: ""This document alone is more tha..."<br>`[32]` **Titus Gordion**: ""The information here is more th..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **""On second thought, Rusty has proven himself loyal to the Crown in the past. Perha..."** | `[38]` **Hugo Toras**: ""At long last, the time has come.""<br>`[44]` **Hugo Toras**: ""Montoro's Arcasian guards can't..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Rusty_Allied"] == true` | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""I heard that he had a hand in t..."<br>`[55]` **Hugo Toras**: ""The only loyalty I've witnessed..." |
| `[43]` | **""I confess I'm curious to hear Rusty's side of the story.""** | `[38]` **Hugo Toras**: ""At long last, the time has come.""<br>`[44]` **Hugo Toras**: ""Montoro's Arcasian guards can't..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Elena Werner**: ""As am I."" |
| `[46]` | **""I can't say I'm happy about this revelation. But I will enjoy hearing Rusty beg f..."** | `[38]` **Hugo Toras**: ""At long last, the time has come.""<br>`[44]` **Hugo Toras**: ""Montoro's Arcasian guards can't..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Elena Werner**: ""We do have significant leverage..." |
| `[47]` | **""I take no pleasure in this. We had the chance to hold Lespia to account for its w..."** | `[38]` **Hugo Toras**: ""At long last, the time has come.""<br>`[44]` **Hugo Toras**: ""Montoro's Arcasian guards can't..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true` | *Brak zmian stanu* | `[49]` **Elena Werner**: ""Mr. Montoro may well still have..." |
| `[68]` | **""I agree completely. By order of the king, Russello Montoro is to be placed under ..."** | `[62]` **Lucita Azaro**: ""Yes, I don't even understand wh..."<br>`[63]` **Titus Gordion**: ""Swift action is certainly warra..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rusty_Arrested"] = true; Variable["Riz...`<br>`Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0; Va...`<br>*(+1 skryptów)* | `[86]` **Lucita Azaro**: ""Perfect. I'll oversee the opera..." |
| `[71]` | **""We won't arrest him yet. I want to see what information we can get out of him fir..."** | `[62]` **Lucita Azaro**: ""Yes, I don't even understand wh..."<br>`[63]` **Titus Gordion**: ""Swift action is certainly warra..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Hugo Toras**: ""Your Majesty, I am firmly convi..." |
| `[72]` | **""Mr. Montoro is more useful to me outside of prison than in it. We'll hold off on ..."** | `[62]` **Lucita Azaro**: ""Yes, I don't even understand wh..."<br>`[63]` **Titus Gordion**: ""Swift action is certainly warra..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Rusty_Allied"] == true` | *Brak zmian stanu* | `[82]` **Hugo Toras**: ""Your Majesty, I am firmly convi..." |
| `[76]` | **""Grand Wiseman Ignacius has spoken the truth. God rewards those who forgive.""** | `[62]` **Lucita Azaro**: ""Yes, I don't even understand wh..."<br>`[63]` **Titus Gordion**: ""Swift action is certainly warra..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""But does He also not smile when..." |
| `[129]` | **""Such treachery to the Crown must not go unpunished.""** | `[128]` **Elena Werner**: ""Although most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucita Azaro**: ""Agreed. This document alone is ..."<br>`[13]` **Titus Gordion**: ""The information here is more th..."<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **""If Lespia has been meddling in Rizia's affairs, they shouldn't be allowed to get ..."** | `[128]` **Elena Werner**: ""Although most of the pertinent ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Lucita Azaro**: ""Agreed. But our first step shou..."<br>`[135]` **Titus Gordion**: ""Agreed. But our first step shou..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""This appears to be a list of financial transactions performed by Rizian Royal Gold on behalf of the Lespian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Elena Werner: ""However, most of the pertinent details have been blacked..."*)

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""However, most of the pertinent details have been blacked out. We know that money was moved, but not to whom or for what purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""It doesn't matter. A traitor's a traitor.""*)
  - -> `[6]` (*Player_Romus: ""The Rizian state owns a significant part of RRG. How cou..."*)
  - -> `[7]` (*Player_Romus: ""Lespia has lied to us about a great many things. Why not..."*)
  - -> `[8]` (*Player_Romus: ""Covering up Lespia's involvement in the Wehlen bombing w..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. A traitor's a traitor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian state owns a significant part of RRG. How could we have let this go undetected?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Elena Werner), `[128]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Elena Werner: ""A corporation as large as RRG performs thousands of tran..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia has lied to us about a great many things. Why not this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Elena Werner: ""We've verified what little information we could. It all ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Covering up Lespia's involvement in the Wehlen bombing was a huge favor. This is all we get in return?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""Agreed. This document alone is more than enough to put M..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Agreed. This document alone is more than enough to put Montoro behind bars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[13]`
Mówca: **Titus Gordion**
> ""The information here is more than enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Titus Gordion: ""The information here is more than enough to justify Mr. ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Taddeus Azaro: ""I agree. With this evidence, we can put Montoro behind b..."*)

### Węzeł `[17]`
Mówca: **Taddeus Azaro**
> ""I agree. With this evidence, we can put Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[18]`
Mówca: **Elena Werner**
> ""A corporation as large as RRG performs thousands of transactions per week. It's not unusual for one or two to fly under the radar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""Compromising Rizia's national security right under our n..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""Compromising Rizia's national security right under our nose. The man deserves to rot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Montoro's Arcasian guards can't save him now. The time h..."*)

### Węzeł `[23]`
Mówca: **Titus Gordion**
> ""It's not on par with Duchess Azaro's betrayal. But it's a flagrant breach of national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Montoro's Arcasian guards can't save him now. The time h..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Titus Gordion: ""It's not on par with Duchess Azaro's betrayal. But it's ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Taddeus Azaro: ""This is an unforgivable security breach, Your Majesty. O..."*)

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""This is an unforgivable security breach, Your Majesty. Our forces should have been more vigilant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""The fault lies entirely with Mr. Montoro. His Arcasian g..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""This document alone is more than enough to put Montoro b..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""This document alone is more than enough to put Montoro behind bars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""The information here is more than enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Titus Gordion: ""The information here is more than enough to justify Mr. ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Taddeus Azaro: ""*If* Lespia can be trusted, this document alone is enoug..."*)

### Węzeł `[36]`
Mówca: **Taddeus Azaro**
> ""*If* Lespia can be trusted, this document alone is enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[37]`
Mówca: **Elena Werner**
> ""We've verified what little information we could. It all checks out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""At long last, the time has come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[46]` (*Player_Romus: ""I can't say I'm happy about this revelation. But I will ..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[43]` (*Player_Romus: ""I confess I'm curious to hear Rusty's side of the story.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, Rusty has proven himself loyal to the Crown in the past. Perhaps he deserves a second chance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaD..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""On second thought, Rusty has proven himself loyal to the..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I confess I'm curious to hear Rusty's side of the story.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Elena Werner: ""As am I.""*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Montoro's Arcasian guards can't save him now. The time has come to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[46]` (*Player_Romus: ""I can't say I'm happy about this revelation. But I will ..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[43]` (*Player_Romus: ""I confess I'm curious to hear Rusty's side of the story.""*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""The fault lies entirely with Mr. Montoro. His Arcasian guards can't save him now. The time has come to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[46]` (*Player_Romus: ""I can't say I'm happy about this revelation. But I will ..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[43]` (*Player_Romus: ""I confess I'm curious to hear Rusty's side of the story.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't say I'm happy about this revelation. But I will enjoy hearing Rusty beg for his life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Elena Werner: ""We do have significant leverage over Mr. Montoro now. If..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I take no pleasure in this. We had the chance to hold Lespia to account for its wrongdoing, and we gave it up just to reel in a small fish.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Elena Werner: ""Mr. Montoro may well still have access to the original c..."*)

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""If we spare him from arrest, perhaps we can persuade him to hand them over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Sal nodded solemnly."*)

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""Mr. Montoro may well still have access to the original copies of these files, or others that could expose the extent of Lespia's actions against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Elena Werner: ""If we spare him from arrest, perhaps we can persuade him..."*)

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""We do have significant leverage over Mr. Montoro now. If we were to spare him from arrest, we would secure his unconditional loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaD..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HODElection_RustyInfluence_RNC == true && Rizi..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""I heard that he had a hand in the Rizian National Coalit..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""The only loyalty I've witnessed from that man is his dev..."*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I heard that he had a hand in the Rizian National Coalition's election gains. But they would have won just as easily without him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Elena Werner: ""Whatever he may or may not have done in the past, sparin..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""The only loyalty I've witnessed from that man is his devotion to hideous cravats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Elena Werner: ""Whatever he may or may not have done in the past, sparin..."*)

### Węzeł `[56]`
Mówca: **Elena Werner**
> ""Whatever he may or may not have done in the past, sparing him from arrest would secure his and RRG's full cooperation in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)

### Węzeł `[57]`
Mówca: **Elena Werner**
> ""Perhaps he could even lead us to the uncensored versions of these files.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Sal nodded solemnly."*)

### Węzeł `[58]`
Mówca: **Laurento Esquibel**
> ""A lovely thought, Grand Wiseman. But now that Prime Minister Alvarez has given us evidence of Rusty's dealings with Lespia, he'll be expecting us to take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucita Azaro: ""Yes, I don't even understand why we're still talking abo..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""Yes, I don't even understand why we're still talking about this. We should imprison Montoro and put his company under state control as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
Mówca: **Titus Gordion**
> ""Swift action is certainly warranted. As is the immediate nationalization of Mr. Montoro's company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Titus Gordion: ""Swift action is certainly warranted. As is the immediate..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Taddeus Azaro: ""You've hit the nail on the head, Esquibel. We imprison M..."*)

### Węzeł `[67]`
Mówca: **Taddeus Azaro**
> ""You've hit the nail on the head, Esquibel. We imprison Montoro and put his company under state control. It's as simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. By order of the king, Russello Montoro is to be placed under immediate arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[63]` (Titus Gordion), `[67]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Arrested = true; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""We do not know the circumstances under which this lost soul acted. Forgiving him would surely bring us one step closer to Golconda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Sal nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Sal Ignacius: ""We do not know the circumstances under which this lost s..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't arrest him yet. I want to see what information we can get out of him first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[63]` (Titus Gordion), `[67]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Your Majesty, I am firmly convinced that letting this ma..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro is more useful to me outside of prison than in it. We'll hold off on arresting him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[63]` (Titus Gordion), `[67]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Your Majesty, I am firmly convinced that letting this ma..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Allied == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Mr. Montoro is more useful to me outside of prison than ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Wiseman Ignacius has spoken the truth. God rewards those who forgive.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucita Azaro), `[63]` (Titus Gordion), `[67]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""But does He also not smile when justice is meted out in ..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""Grand Wiseman Ignacius has spoken the truth. God rewards..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Arrested = true;
RiziaDLCSupport.Journal_Turn08_Decision_RustyLespiaAgentArrest_Arrest = true; RiziaDLC.Enable_RRG_Nationalization = true;
RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest = true;
RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rusty_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Decision_RustyLespiaAgentArrest_Arrest"] = true;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_RRGNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_GrantROGStake == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");

// Enables codex entry with the name in database`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
-- Enables codex entry with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""Your Majesty, I am firmly convinced that letting this man walk free is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""Even discounting his treachery, Mr. Montoro has made a m..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucita Azaro: ""Perfect. I'll oversee the operation myself.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""Perfect. I'll oversee the operation myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""A wise decision. I'll alert our security forces at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Titus Gordion: ""A wise decision. I'll alert our security forces at once.""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Taddeus saluted."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Taddeus saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Taddeus Azaro: ""Consider it done.""*)

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""But does He also not smile when justice is meted out in His name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""Even discounting his treachery, Mr. Montoro has made a m..."*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Even discounting his treachery, Mr. Montoro has made a mockery of everything this kingdom has stood for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""The King has spoken, Your Grace.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""The King has spoken, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""I'll dispatch extra security forces to Bronaz. We'll wat..."*)

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Your Grace, I'm afraid the King has spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Titus Gordion: ""I'll dispatch extra security forces to Bronaz. We'll wat..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Titus Gordion: ""Your Grace, I'm afraid the King has spoken.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Taddeus Azaro: ""The King has spoken, Your Grace.""*)

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""The King has spoken, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Taddeus Azaro: ""I'll dispatch extra security forces to Bronaz. We'll wat..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_GrantROGStake == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_GrantROGStake == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_GrantROGStake == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_GrantROGStake == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_GrantROGStake"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Modifier_SoldROGStake = 0; RiziaDLC.Rusty..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_GrantROGStake == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_GrantROGStake"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Business_RusselloMontoro_Arr..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Modifier_SoldROGStake = 0;
RiziaDLC.Rusty_GrantROGStake = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0;
Variable["RiziaDLC.Rusty_GrantROGStake"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Business_RusselloMontoro_Arr..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_ExposedViaAlvarez == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Elena Werner: ""This appears to be a list of financial transactions perf..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_ExposedViaAlvarez == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Elena Werner: ""This appears to be a list referencing payments tied to e..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_ExposedViaAlvarez == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""I take no pleasure in this. We had the chance to hold Le..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_ExposedViaAlvarez == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
Mówca: **Elena Werner**
> ""As am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Elena Werner: ""This information gives us significant leverage against h..."*)

### Węzeł `[118]`
Mówca: **Elena Werner**
> ""This information gives us significant leverage against his corporation. Perhaps a light touch is preferable to moving in with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Sal nodded solemnly."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_ExposedViaAlvarez == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Laurento Esquibel: ""A lovely thought, Grand Wiseman. But now that Prime Mini..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_ExposedViaAlvarez == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Laurento Esquibel: ""A lovely thought, Grand Wiseman. But more to the point, ..."*)

### Węzeł `[122]`
Mówca: **Laurento Esquibel**
> ""A lovely thought, Grand Wiseman. But more to the point, if we have the chance to trade our intelligence on Mr. Montoro for incriminating details regarding Lespia, we should do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""On the other hand, if Mr. Montoro doesn't have any usefu..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_ExposedViaAlvarez == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_ExposedViaAlvarez == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_ExposedViaAlvarez == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Elena Werner: ""Perhaps he could even lead us to the uncensored versions..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_ExposedViaAlvarez == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Laurento Esquibel: ""Perhaps he could even provide us with more damning evide..."*)

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""Perhaps he could even provide us with more damning evidence of Lespia's past misdeeds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Sal nodded solemnly."*)

### Węzeł `[127]`
Mówca: **Elena Werner**
> ""This appears to be a list referencing payments tied to extensive re-training of former Rizian Royal Gold employees — employees who later secured key roles in our energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Elena Werner: ""Although most of the pertinent details have been blacked..."*)

### Węzeł `[128]`
Mówca: **Elena Werner**
> ""Although most of the pertinent details have been blacked out, we suspect these transactions were performed by Mr. Montoro himself on behalf of the Lespian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""Such treachery to the Crown must not go unpunished.""*)
  - -> `[6]` (*Player_Romus: ""The Rizian state owns a significant part of RRG. How cou..."*)
  - -> `[130]` (*Player_Romus: ""If Lespia has been meddling in Rizia's affairs, they sho..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such treachery to the Crown must not go unpunished.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Lespia has been meddling in Rizia's affairs, they shouldn't be allowed to get away with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucita Azaro: ""Agreed. But our first step should be to put Mr. Montoro ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
Mówca: **Titus Gordion**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Titus Gordion: ""Agreed. But our first step should be to put Mr. Montoro ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Taddeus Azaro: ""Agreed. But our first step should be to put Mr. Montoro ..."*)

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""At long last, the time has come.""*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""On the other hand, if Mr. Montoro doesn't have any useful information, we'll have thrown away our shot at nationalizing his company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucita Azaro: ""Our security forces will keep a close watch on the man, ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lucita Azaro: ""But there's always the risk he'll get wind of all this a..."*)

### Węzeł `[146]`
Mówca: **Titus Gordion**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Titus Gordion: ""But there's always the risk he'll get wind of all this a..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Titus Gordion: ""Our security forces will keep a close watch on the man, ..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Taddeus Azaro: ""Our security forces will keep a close watch on the man, ..."*)

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Taddeus Azaro: ""But there's always the risk he'll get wind of all this a..."*)

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[153]`
Mówca: **Taddeus Azaro**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""I agree completely. By order of the king, Russello Monto..."*)
  - -> `[71]` (*Player_Romus: ""We won't arrest him yet. I want to see what information ..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Allied == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
