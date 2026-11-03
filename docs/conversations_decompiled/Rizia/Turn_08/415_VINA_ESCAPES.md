# Rizia/Turn 8/VINA ESCAPES

- **ID konwersacji:** `415`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/415_VINA_ESCAPES.md`
- **Liczba węzłów dialogowych:** 176
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Law_Homosexuality_Banned`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement`
- `RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[414] Rizia/Turn 8/P_NightBeforeWedding** (../Turn_08/414_P_NightBeforeWedding.md), Węzeł `[784]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[33]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement"] = true;`
- Węzeł `[109]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion");`
- Węzeł `[123]` (Paskal Beniwoll): `RemoveConversant("Pabel Adria");`
- Węzeł `[174]` (Paskal Beniwoll): `RemoveConversant("Estela Toras");`
- Węzeł `[175]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `414` (*Rizia/Turn 8/P_NightBeforeWedding*), Węzeł `[784]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I entered the palace's residential wing and began making my way to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "As I neared Vina's door, I thought I heard her speaking to someone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I was about to step closer when I felt a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Pabel Adria**
> ""Your Majesty! There you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Pabel Adria**
> ""I'm afraid there's an urgent matter regarding wedding seating arrangements. This way, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Titus shadowed us as Pabel steered me back down the hall towards my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[17]`
  - -> `[77]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seating arrangements? Is that a euphemism for something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need to check in on Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better be quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't you figure it out yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Pabel Adria**
> ""I've been trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Pabel Adria**
> ""It will be. Hopefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He shook his head briskly and withdrew a seating diagram from his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Pabel Adria**
> ""This will only be a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He withdrew a seating diagram from his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""At table 12, we have delegations from Agard, Qinal, the Free Cities and Nahrburk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Pabel Adria**
> ""Our guests from Qinal and the Free Cities refuse to sit next to each other or directly across from one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Pabel Adria**
> ""The Qinali, meanwhile, would like to sit directly to the left of our guest from Nahrburk, who in turn has asked to sit across from the Agardian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[29]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Easy. Going clockwise, it's Agard, Qinal, Nahrburk, Free Cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. How about Free Cities, Nahrburk, Agard, Qinal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From the top of the table, it's Narhburk, Qinal, Agard, Free Cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea. Ask someone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Pabel Adria**
> ""Perfect. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Pabel made a note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[34]`
Mówca: **Pabel Adria**
> ""I'm sorry, Your Majesty. I was afraid of causing an international scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Pabel Adria**
> ""This must be a very emotional time for you. I still remember Her Highness' birth celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[44]`
  - -> `[46]`
  - -> `[41]`

### Węzeł `[36]`
Mówca: **Pabel Adria**
> ""I'm afraid there's an urgent matter regarding the seating arrangements for tomorrow's diplomatic luncheon. This way please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That just means you're getting old, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing romantic about tomorrow. It's a political event, nothing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have the congratulatory cigar you gave me. You must have saved up for it for months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All sparrows have to leave the nest sometime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Narrator**
> "I detected a slight nervous quiver in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[48]`
Mówca: **Narrator**
> "From just down the hall, I heard the sound of barking. Bruno."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Huh. You were there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Pabel Adria**
> ""Lespia's finest. The import taxes were horrendous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Pabel Adria**
> ""I was serving just beneath the head butler at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this really such an urgent matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel, where is Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Pabel Adria**
> ""No, I suppose it wasn't. Forgive me for wasting your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[59]`
Mówca: **Pabel Adria**
> ""Very well. I've gotten all your clothes ready for tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[60]`
Mówca: **Pabel Adria**
> ""She's been in her room this entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[61]`
Mówca: **Narrator**
> "I rushed back down the hallway to Vina's room. Bruno was standing there, barking in front of a wide-open door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "I rushed back down the hallway to Vina's room. Her door was wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "I went inside and saw that the window was open as well. My mother was standing in front of it, her face pale as a sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[69]`
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHERE IS SHE?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "Look out the window."]** — Mówca: **Player_Romus_Italic**
> "I looked out the window at the palace gardens below. Nobody was there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you let her run away?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""I... I don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Estela Toras**
> ""No, of course not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Estela Toras**
> ""I... I have no idea what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Estela Toras**
> ""I came here to give her some motherly advice ahead of her wedding. I opened the door, and she was gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're hosting a diplomatic luncheon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Pabel Adria**
> ""Apparently, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""I knew she'd been feeling down lately, so I came to check up on her. I opened the door, and she was gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`
  - -> `[90]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lying. I heard her talking to someone in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""TITUS! FIND HER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She can't have gone far. The palace grounds are under heavy security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Titus spoke into his radio. I struggled to make out the words on the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""I'm already on it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Titus Gordion**
> ""I'm communicating with my fellow guards now, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she didn't want to get married, she could have just told me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she wasn't happy, she could have just told me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""She did tell you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""Interesting. Perhaps she was on the phone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[93]`
Mówca: **Estela Toras**
> ""She did tell you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""I've received word that one of my men left his shift early just now. He was complaining of indigestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Track him down. See that he gets what's coming to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to find him, Titus. I want my daughter back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So she had an accomplice. I thought you Golden Guards were incorruptible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[98]`
Mówca: **Titus Gordion**
> ""I tried to reach him, but he's already turned his radio off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[96]`
  - -> `[97]`
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's that easy for someone to escape the palace?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Estela Toras**
> ""Everybody has a weakness, darling. Even Captain Gordion here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Titus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""I'll try my best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""Your Majesty, Palas Rezna's security systems are designed to keep intruders out. Not to keep princesses in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""Right now, the goal is getting Princess Vina back. We can discuss the particulars later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""I'm going to talk to the guards at the gates. See if I can find out more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He dashed out, leaving me alone with my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`
  - -> `[117]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel had a hand in this, didn't he? Where did he go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seriously, Mother. Did you help her escape?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me where she is, or I'll tell everyone you're a Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell am I supposed to do now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[118]`
Mówca: **Narrator**
> "My mother shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""Your butler knows every nook and cranny of this palace, including the secret passageways. If he played any role in her escape, he's long gone by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""How many times must I tell you? She was already gone when I came in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Estela Toras**
> ""Go on, then. I honestly don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[122]`
Mówca: **Estela Toras**
> ""You could track her down. But she'll only try to escape again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Engaged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Engaged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Estela Toras**
> ""Your real problem is telling the rest of the continent that Rizia's big royal wedding is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[137]`
  - -> `[148]`
  - -> `[152]`
  - -> `[139]`

### Węzeł `[128]`
Mówca: **Estela Toras**
> ""Your real problem is explaining to the international press that the Kingdom of Rizia can't hold on to its princesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[139]`
  - -> `[143]`

### Węzeł `[129]`
Mówca: **Estela Toras**
> ""If she did drive off with that guard, they could have gone anywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[130]`
Mówca: **Narrator**
> "My mother shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shit. All that wartime sympathy, literally out the window.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[132]`
Mówca: **Narrator**
> "There was pain in his eyes as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Homosexuality_Banned"] == true  and  (Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Homosexuality_Banned"] == true  and  (Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[136]`
Mówca: **Pabel Adria**
> ""Good night, Romus. And good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is just cold feet. She'll come back eventually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Titus does manage to track her down, I'll have her beheaded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll make me look like a monster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is just a tantrum. I'm sure she'll come back eventually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Hugo. What do I tell Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Axel. What do I tell Axel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was all my fault. I should have listened to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""If she doesn't, it'll be the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""You tell him that the Rizia-Pales reunion everyone's been waiting for will have to happen another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[155]`
Mówca: **Estela Toras**
> ""You tell him that he's your new successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""If she doesn't, it'll be the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""Not to mention our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[158]`
Mówca: **Estela Toras**
> ""But perhaps that's a small price to pay for Her Highness' happiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""It's too late now. You can consider this the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[160]`
Mówca: **Estela Toras**
> ""If you do, that'll be the end of your line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Estela Toras**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[165]`
Mówca: **Estela Toras**
> ""What's more, our family's line of succession will be most definitively over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[166]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Estela Toras**
> ""But perhaps that's a small price to pay for Her Highness' happiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Estela Toras**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[173]`
Mówca: **Narrator**
> "She slowly walked away, lost in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
