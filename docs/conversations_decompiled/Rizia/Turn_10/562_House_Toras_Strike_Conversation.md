# Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/House Toras Strike/House Toras Strike Conversation

- **ID konwersacji:** `562`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/562_House_Toras_Strike_Conversation.md`
- **Liczba węzłów dialogowych:** 361
- **Liczba wyborów gracza:** 74

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Hubertus_Arrested`
- `RiziaDLC.Hubertus_Executed`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Iza_RicoControlsPolice`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn09_Coup_Warning`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[524]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 23

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[12]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo...`
- Węzeł `[47]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico...`
- Węzeł `[84]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo...`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo...`
- Węzeł `[98]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico...`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo...`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico...`
- Węzeł `[170]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico...`
- *...oraz 15 innych węzłów ze skryptami.*

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
  - -> `[51]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `559` (*Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation*), Węzeł `[524]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> "“Family loyalty? You abandoned that the moment you took the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Well, then let me save you the trouble." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""Well, then let me save you the trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped over to the table and penned my name to the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let it be known that from this day forward, Hugo, you shall no longer hold your title, nor shall Ricardus or Hubertus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The Toras men stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""You always did have a way with words. Tell it to the judge." [Gesture at Titus to arrest him.]"]** — Mówca: **Player_Romus**
> ""You always did have a way with words. Tell it to the judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only stain on our bloodline is you. Titus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations. Your blood is worth no more than that of a commoner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Henceforth, I erase all your rights, privileges, and noble standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Hugo turned to Titus. There was panic in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Titus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Titus Gordion**
> ""I'm sorry, old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "A flicker of hesitation crossed Titus' face, but with a steadying breath, he pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[17]`
Mówca: **Narrator**
> "His jaw clenched tightly as Hugo's body crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not what I meant, Titus. Oh well. Too late now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false || RiziaDLC.Rico_Executed == false || RiziaDLC.Hubertus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  or  Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.Hubertus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let it be known that from this day forward, Hugo, Ricardus, and Hubertus Toras shall no longer hold your noble title, even posthumously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false  and  (Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false && (RiziaDLC.Rico_Executed == false && RiziaDLC.BirthdayGathering_Invited_Rico == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false  and  (Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hubertus_Executed"] == false  and (Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hubertus_Executed == false &&(RiziaDLC.Rico_Executed == false || RiziaDLC.BirthdayGathering_Invited_Rico == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hubertus_Executed"] == false  and (Variable["RiziaDLC.Rico_Executed"] == false  or  Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Rico and Hubertus stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Hubertus stood in stunned silence, his face a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Hugo and Hubertus stood in stunned silence, their faces a mix of disbelief and shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hubertus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hubertus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[38]`
Mówca: **Rico Toras**
> ""FATHER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[42]`
  - -> `[39]`
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something you'd like to add, Cousin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Rico Toras**
> ""You'll go to hell for this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sins of the family will not be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save your tears, Rico. Your father’s legacy is no longer of concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Take him out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are lucky that I've spared your life, cousin. Don't ever forget this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I nodded to Titus. The muzzle of his gun flashed, and Rico was silenced forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[48]`
  - -> `[21]`
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Arrest him immediately!""]** — Mówca: **Player_Romus**
> ""Arrest him immediately!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God... I've wanted to do that for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'Goodbye, Ricardus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Enough of this nonsense." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""Enough of this nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I turned to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[60]`
  - -> `[56]`
  - -> `[245]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Now’s your chance, Uncle. Show me family loyalty above everything else and admit what you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Rico Toras**
> ""Father. You don't need to explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Quiet, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Hugo took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "Stare at him."]** — Mówca: **Player_Romus_Italic**
> "I stared him down, not uttering a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you've now recognized the seriousness of your situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""If you're expecting some sort of admission, you won't get anything out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“What say you, House Toras? Is there anything you'd like to confess before the Lord?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tarnished it may be, but *my* bloodline will be just fine. Though, I can't say the same for *yours*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I looked to Titus, a single, silent command passing between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Without hesitation, he raised his gun and fired. A single shot echoed through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Rico’s body crumpled lifelessly to the floor, blood pooling around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Hugo screamed, his face pale with horror as he watched his son fall. Hubertus sat frozen, his mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""You… How could you? YOU KILLED MY SON!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Hugo fell to the floor and took Rico in his arms, rocking him back and forth. His face was ashen and hollow, eyes locked on his son’s lifeless form."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, take him into custody -- immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Titus motioned to several nearby men in uniform, who picked Hugo off the ground, tied his hands behind his back and escorted him to the far wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, see to it that he joins his son in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Before I could register what had happened, Hugo hit the floor, dead -- the shot from Titus’s gun still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Hubertus stared at the blood on the floor, his mouth trembling in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The truth, Hubertus. I’ll have it now, one way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you finally ready to admit what you've done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Hubertus_Hub_1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[78]`
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hubertus_Hub_1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Hubertus looked petrified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""I don't have time for this." [Sign the decree to revoke House Toras' titles.]"]** — Mówca: **Player_Romus**
> ""I don't have time for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""There’s nothing to judge! You hear me? My conscience is clear! Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[88]`
  - -> `[89]`
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy that clean conscience in the dark cell waiting for you. Perhaps it’ll keep you company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only self-righteousness were a defense. Shame it’s not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your conscience may be clear, but your hands are stained. And I will see that justice is done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, letting silence be my answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Hugo thrashed against the guards’ grip, his voice rising in protest, as they tied his hands behind his back and hauled him to the far side of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[96]`
Mówca: **Rico Toras**
> ""You fucking monster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Hubertus Toras**
> ""Ricardus! Do not test His Majesty's patience further!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Hugo_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[100]`
Mówca: **Rico Toras**
> ""What is there to lose? Can't you see he's set on destroying us all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`
  - -> `[128]`
  - -> `[131]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Rico redirected his anger toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Rico Toras**
> ""You know what you are? You’re just a scared little man hiding behind all this -- what, power? Fear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Rico Toras**
> ""You're got nothing but weakness in you! You’re no king of mine!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Before I could react, Rico spat in my face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[107]`
  - -> `[106]`
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the last mistake you'll ever make. Titus. Shoot him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bit too eager to make your point, don’t you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest him at once!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "Remain calm."]** — Mówca: **Player_Romus_Italic**
> "I displayed no outward reaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""Your Majesty, this man has defied the King of Rizia to his face -- an act demanding the gravest consequence. How do you wish me to proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[112]`
  - -> `[111]`
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Titus grabbed Rico by his hair and yanked him back, eliciting a cry of pain from my insubordinate cousin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down, Titus. He is no threat anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put him behind bars to get his perspective sorted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not necessary, Titus. Small creatures may snap at a lion’s heel, but the lion remains unmoved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He has committed treason. For that, he must pay with his life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Rico_Executed_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Rico_Executed_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“From henceforth, the Toras family shall have no claim to Valenqiris. There is only the Crown.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[118]`
Mówca: **Rico Toras**
> ""Go on, throw me behind bars! It won’t change the truth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[120]`
Mówca: **Narrator**
> "He barely had time to curse me before two guards seized him and dragged him back to the area where Hugo was being held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I directed my attention toward Hubertus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Hubertus stared at the blood on the floor, his mouth quivering in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hubertus_Hub_1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[124]`
Mówca: **Narrator**
> "I turned my attention toward Hubertus, who looked petrified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hubertus_Hub_1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do go on. I’m fascinated to hear what else you have to say... while you still have the chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Don't you know that monsters have a way of making nightmares real? Guards, take him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you'd like to join your father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Rico looked away, swallowing hard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Rico Toras**
> ""My apologies. I was out of line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“A monster? Is that the best you've got, Rico? If that’s all you see, then perhaps you’re not paying attention.” [Execute Rico]"]** — Mówca: **Player_Romus**
> "“A monster? Is that the best you've got, Rico? If that’s all you see, then perhaps you’re not paying attention.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Rico_Executed_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Iza_RicoControlsPolice"] == true  or  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Iza_RicoControlsPolice == true || RiziaDLC.Rico_PoliceChief_PorteDrazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Iza_RicoControlsPolice"] == true  or  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What say you, Hubertus? Anything you'd like to add?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now's your chance to apologize too, Hubertus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only one of you apologized. Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Hubertus_Hub_2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hubertus_Hub_2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> "“Your father would have been ashamed to see what you've become -- a ruler who'd cast his own family aside in pursuit of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[163]`
  - -> `[299]`
  - -> `[296]`
  - -> `[258]`

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""The only thing I have to 'confess' is that I swore my fealty to a king who never returned it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""I gave you my trust, Romus. And for family to betray family... that wound never heals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Rico Toras**
> ""He never deserved your loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""That's enough, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but if you want some sort of admission, you'll get nothing out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[151]`
  - -> `[150]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether you speak or not, the outcome remains the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your stubbornness is almost admirable. Almost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I almost pity you, Uncle -- holding on to pride as everything else crumbles around you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I swore undying loyalty to you, as family should, but you gave me nothing in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Hugo Toras**
> ""'Stubbornness?' No. It's conviction. Something you traded away the moment you put that crown on your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""You speak of pride as if it’s a failing, but after today, it seems it might be all I have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Hugo Toras**
> ""And for family to betray family... that wound never heals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[157]`
Mówca: **Rico Toras**
> ""Father. You don't need to explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""Quiet, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drop the act, Hugo. I know it was you who killed Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think would have disappointed him more? What I've become, or the cowardice you've embraced?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think your little moral lecture matters at this point, you’re gravely mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""Cowardice?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[166]`
Mówca: **Hugo Toras**
> ""What do you take me for, my nephew?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""Damn it, Romus. Do you even hear yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[168]`
Mówca: **Rico Toras**
> ""You’ll rot in hell for this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[169]`
Mówca: **Rico Toras**
> ""You’ll burn for what you've done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Rico_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Before he could get a word out, two guards seized him and hauled him to the far side of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[172]`
Mówca: **Narrator**
> "I turned to Hubertus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[173]`
Mówca: **Hubertus Toras**
> ""Please, Your Majesty. I'm sure we can amicably resolve any grievances you have with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Hubertus Toras**
> ""There's still time to make this right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Rico_Executed_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[176]`
Mówca: **Lucita Azaro**
> ""I suggest you stop now, Your Grace--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Hugo held up a hand, silencing her, before turning his gaze back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo and Rico, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo and Rico, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Lucita's gaze lingered on Hugo, as if struggling to process what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Yes, leverage is everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes things fall into place when you have the proper leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but let’s not get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that the simplest approach can often be the most effective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Her frustration was evident, but she said nothing further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I never imagined you would take it this far, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[213]`
  - -> `[204]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Hubertus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Rico_Arrested == true || RiziaDLC.Hubertus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Hubertus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[223]`
Mówca: **Lucita Azaro**
> ""Well, that went more smoothly than anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[210]`
  - -> `[212]`

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Naturally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Your Majesty... I never imagined you would take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[213]`
  - -> `[204]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Lucita stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""I truly hope you're right, for all our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true  or  Variable["RiziaDLC.Hubertus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == true || RiziaDLC.Rico_Executed == true || RiziaDLC.Hubertus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true  or  Variable["RiziaDLC.Rico_Executed"] == true  or  Variable["RiziaDLC.Hubertus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but I refuse to play along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[151]`
  - -> `[240]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether you play or not, the outcome remains the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""I don't know what your game is, Romus, but I refuse to be a part of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now's your chance, Uncle. Prove to me that family loyalty comes before all else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Rico Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Rico Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Rico Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[256]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father never gave a damn about me, and neither did you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every action I've taken has been for Rizia -- and Rizia alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[259]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[260]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Place him under arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shoot him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Narrator**
> "For the first time, I saw terror in my guardsman's eyes, betraying his usual composed demeanor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[263]`
Mówca: **Narrator**
> "Disgust was written all over his face. I looked at Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[266]`
  - -> `[265]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Titus. Shoot him." [Point to Rico]"]** — Mówca: **Player_Romus**
> ""Titus. Shoot him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's over, Hugo. Under the authority vested in me as king, I place you under arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Here, I'll save you the trouble." [Sign the decree to revoke House Toras' titles and seize Valenqiris]"]** — Mówca: **Player_Romus**
> ""Here, I'll save you the trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras_Signature_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras_Signature_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras_Signature_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Rico sprang from his seat, but armed men quickly descended upon him, pinning him to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Take him out as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Arrest_Hugo_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Arrest_Hugo_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Toras_Signature_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[275]`
Mówca: **Hugo Toras**
> ""May the Divine curse your soul, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""I'm sorry, old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[277]`
Mówca: **Narrator**
> "A flicker of hesitation crossed Titus' face, but with a steadying breath, he pulled the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[281]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[86]`
  - -> `[75]`

### Węzeł `[285]`
Mówca: **Sevrio Castellanus**
> ""May he find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[86]`
  - -> `[75]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Without a moment's hesitation, his guardsmen grabbed Hugo and dragged him toward the back wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[287]`
Mówca: **Narrator**
> "Sevrio grabbed Hugo and dragged him toward the back wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[288]`
Mówca: **Narrator**
> "I nodded to Titus, who gave the signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[292]`
Mówca: **Sevrio Castellanus**
> ""You know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[293]`
Mówca: **Narrator**
> "I nodded to Titus, who gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Toras_Signature_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Arrest_Hugo_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""What?! How dare you even--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Narrator**
> "He recoiled in anger. When he spoke again, it was without passion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""All these years, I have done nothing but stand by you and your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Hugo Toras**
> ""When the rest of our family called your mother a gold-digging harlot -- not without merit, mind you -- who came to her defense?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""All those years you were unfaithful to your wife -- who do you think helped keep that a secret?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""I didn't say a word when you and your butler revealed your shameful *proclivities* to the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
Mówca: **Hugo Toras**
> ""I never said a word about your barely disguised *proclivities*, despite them being an affront to God and nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_WeddingDate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_WeddingDate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_WeddingDate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""And even when you sent my son to his doom--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "His voice caught in his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Did I lash out? No! I gracefully stepped down to continue serving House Toras from afar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true || RiziaDLC.Rico_Deposed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[327]`
Mówca: **Hugo Toras**
> ""Even when you humiliated my only son--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Narrator**
> "His voice caught in his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""Even then, I chose to serve you rather than lash out in defense of his honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""Even when your daughter made a mockery of my son on their wedding day--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Narrator**
> "He looked at Rico, who was practically seething."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""Yes, there were times when House Toras entreated me to take your place as the rightful king, and times when I dared to dream of how I would rule in your stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""But I never, ever would have gone so far as to contemplate rising against you, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""Until now. You have simply gone too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[349]`
  - -> `[345]`
  - -> `[344]`

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Yes, there were times when I dared to dream of how I would rule in your stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[342]`
Mówca: **Narrator**
> "With quivering hands, Hubertus made his way to the table and signed the decree revoking House Toras' titles and transferring its lands to the Crown's ownership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am willing to go even further. Sign the papers or face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you admit it. House Toras is guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why can't you just admit it? You murdered King Valero!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps my harshness towards you has been misguided. But I cannot turn back now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Narrator**
> "Hugo's face was full of indescribable sadness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Hugo Toras**
> ""Do what you must. But no matter how much you tarnish our bloodline, I will not betray the honor of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[197]`
  - -> `[4]`
  - -> `[8]`

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""NO!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Toras_StripTitles"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[22]`
  - -> `[11]`
  - -> `[117]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hubertus_Hub_2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
