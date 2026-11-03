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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 5

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Energy_Modifier_SoldROGStake`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[80]` (Paskal Beniwoll): `Variable["RiziaDLC.Rusty_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn08_Decision_Rus...`
- Węzeł `[81]` (Paskal Beniwoll): `EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested"); -- Enables codex entry with the...`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0; Variable["RiziaDLC.Rusty_GrantROGStake"] =...`
- Węzeł `[140]` (Paskal Beniwoll): `--;`
- Węzeł `[154]` (Paskal Beniwoll): `--;`

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
  - -> `[111]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `419` (*Rizia/Turn 8/A_GeneralCouncilMeeting*), Węzeł `[437]`

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""This appears to be a list of financial transactions performed by Rizian Royal Gold on behalf of the Lespian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""However, most of the pertinent details have been blacked out. We know that money was moved, but not to whom or for what purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. A traitor's a traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian state owns a significant part of RRG. How could we have let this go undetected?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia has lied to us about a great many things. Why not this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Covering up Lespia's involvement in the Wehlen bombing was a huge favor. This is all we get in return?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Agreed. This document alone is more than enough to put Montoro behind bars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[13]`
Mówca: **Titus Gordion**
> ""The information here is more than enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Taddeus Azaro**
> ""I agree. With this evidence, we can put Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[18]`
Mówca: **Elena Werner**
> ""A corporation as large as RRG performs thousands of transactions per week. It's not unusual for one or two to fly under the radar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""Compromising Rizia's national security right under our nose. The man deserves to rot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[23]`
Mówca: **Titus Gordion**
> ""It's not on par with Duchess Azaro's betrayal. But it's a flagrant breach of national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Taddeus Azaro**
> ""This is an unforgivable security breach, Your Majesty. Our forces should have been more vigilant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""This document alone is more than enough to put Montoro behind bars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""The information here is more than enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Taddeus Azaro**
> ""*If* Lespia can be trusted, this document alone is enough to justify Mr. Montoro's arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Elena Werner**
> ""We've verified what little information we could. It all checks out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""At long last, the time has come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[114]`
  - -> `[43]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, Rusty has proven himself loyal to the Crown in the past. Perhaps he deserves a second chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I confess I'm curious to hear Rusty's side of the story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Montoro's Arcasian guards can't save him now. The time has come to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[114]`
  - -> `[43]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""The fault lies entirely with Mr. Montoro. His Arcasian guards can't save him now. The time has come to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[114]`
  - -> `[43]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't say I'm happy about this revelation. But I will enjoy hearing Rusty beg for his life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I take no pleasure in this. We had the chance to hold Lespia to account for its wrongdoing, and we gave it up just to reel in a small fish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""If we spare him from arrest, perhaps we can persuade him to hand them over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""Mr. Montoro may well still have access to the original copies of these files, or others that could expose the extent of Lespia's actions against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""We do have significant leverage over Mr. Montoro now. If we were to spare him from arrest, we would secure his unconditional loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HODElection_RustyInfluence_RNC == true && RiziaDLC.HouseElections_RNCWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I heard that he had a hand in the Rizian National Coalition's election gains. But they would have won just as easily without him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""The only loyalty I've witnessed from that man is his devotion to hideous cravats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Elena Werner**
> ""Whatever he may or may not have done in the past, sparing him from arrest would secure his and RRG's full cooperation in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[57]`
Mówca: **Elena Werner**
> ""Perhaps he could even lead us to the uncensored versions of these files.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[58]`
Mówca: **Laurento Esquibel**
> ""A lovely thought, Grand Wiseman. But now that Prime Minister Alvarez has given us evidence of Rusty's dealings with Lespia, he'll be expecting us to take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""Yes, I don't even understand why we're still talking about this. We should imprison Montoro and put his company under state control as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[63]`
Mówca: **Titus Gordion**
> ""Swift action is certainly warranted. As is the immediate nationalization of Mr. Montoro's company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Taddeus Azaro**
> ""You've hit the nail on the head, Esquibel. We imprison Montoro and put his company under state control. It's as simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree completely. By order of the king, Russello Montoro is to be placed under immediate arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""We do not know the circumstances under which this lost soul acted. Forgiving him would surely bring us one step closer to Golconda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Sal nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't arrest him yet. I want to see what information we can get out of him first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro is more useful to me outside of prison than in it. We'll hold off on arresting him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Wiseman Ignacius has spoken the truth. God rewards those who forgive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested = true;
RiziaDLCSupport.Journal_Turn08_Decision_RustyLespiaAgentArrest_Arrest = true; RiziaDLC.Enable_RRG_Nationalization = true;
RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest = true;
RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rusty_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Decision_RustyLespiaAgentArrest_Arrest"] = true;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_RRGNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");

// Enables codex entry with the name in database)*
- **Efekt (`userScript`):** `EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
-- Enables codex entry with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""Your Majesty, I am firmly convinced that letting this man walk free is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""Perfect. I'll oversee the operation myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""A wise decision. I'll alert our security forces at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Taddeus saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""But does He also not smile when justice is meted out in His name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Even discounting his treachery, Mr. Montoro has made a mockery of everything this kingdom has stood for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""The King has spoken, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Your Grace, I'm afraid the King has spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""The King has spoken, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""I'll dispatch extra security forces to Bronaz. We'll watch his every move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_GrantROGStake == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_GrantROGStake == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_GrantROGStake"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_GrantROGStake == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_GrantROGStake"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Modifier_SoldROGStake = 0;
RiziaDLC.Rusty_GrantROGStake = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0;
Variable["RiziaDLC.Rusty_GrantROGStake"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_ExposedViaAlvarez == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_ExposedViaAlvarez == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
Mówca: **Elena Werner**
> ""As am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Elena Werner**
> ""This information gives us significant leverage against his corporation. Perhaps a light touch is preferable to moving in with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_ExposedViaAlvarez == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Laurento Esquibel**
> ""A lovely thought, Grand Wiseman. But more to the point, if we have the chance to trade our intelligence on Mr. Montoro for incriminating details regarding Lespia, we should do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_ExposedViaAlvarez == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_ExposedViaAlvarez == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_ExposedViaAlvarez"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""Perhaps he could even provide us with more damning evidence of Lespia's past misdeeds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[127]`
Mówca: **Elena Werner**
> ""This appears to be a list referencing payments tied to extensive re-training of former Rizian Royal Gold employees — employees who later secured key roles in our energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Elena Werner**
> ""Although most of the pertinent details have been blacked out, we suspect these transactions were performed by Mr. Montoro himself on behalf of the Lespian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[6]`
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such treachery to the Crown must not go unpunished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Lespia has been meddling in Rizia's affairs, they shouldn't be allowed to get away with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Titus Gordion**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Taddeus Azaro**
> ""Agreed. But our first step should be to put Mr. Montoro behind bars and restore RRG's rightful ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""On the other hand, if Mr. Montoro doesn't have any useful information, we'll have thrown away our shot at nationalizing his company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
Mówca: **Titus Gordion**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""Our security forces will keep a close watch on the man, even if we don't arrest him right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Taddeus Azaro**
> ""But there's always the risk he'll get wind of all this and flee. I suggest we take swift action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[71]`
  - -> `[73]`
  - -> `[77]`
