# Rizia/Turn 7/A_HouseOfDelegatesII

- **ID konwersacji:** `384`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/384_A_HouseOfDelegatesII.md`
- **Liczba węzłów dialogowych:** 430
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit`
- `RiziaDLC.Decision_Turn07_InviteSalToHOD`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Hostage`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLCSupport.Journal_RD_WarProfitsTax`
- `RiziaDLCSupport.News_RD_RH_WarProfitsTax`
- `RiziaDLCSupport.News_RD_V_WarProfitsTax`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War`
- `RiziaDLCSupport.News_Turn07_RH_MateusDeath`
- `RiziaDLCSupport.News_Turn07_V_MateusDeath`

### Skoki między-konwersacyjne:
- Węzeł `[138]` -> **[385] Rizia/Turn 7/Pales War Update And Tax** (../Turn_07/385_Pales_War_Update_And_Tax.md), Węzeł `[1]`
- Węzeł `[141]` -> **[385] Rizia/Turn 7/Pales War Update And Tax** (../Turn_07/385_Pales_War_Update_And_Tax.md), Węzeł `[1]`
- Węzeł `[143]` -> **[386] Rizia/Turn 7/Zille Treaty Discussion** (../Turn_07/386_Zille_Treaty_Discussion.md), Węzeł `[1]`
- Węzeł `[144]` -> **[386] Rizia/Turn 7/Zille Treaty Discussion** (../Turn_07/386_Zille_Treaty_Discussion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 24

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCSupport.Journal_RD_WarProfitsTax`
- `RiziaDLCSupport.News_RD_RH_WarProfitsTax`
- `RiziaDLCSupport.News_RD_V_WarProfitsTax`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War"] = true;`
- Węzeł `[10]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious"] = true;`
- Węzeł `[14]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious"] = true;`
- Węzeł `[391]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[392]` (Paskal Beniwoll): `AddConversant("Manus Sazon"); -- Adds the conversant with the character name in database;`
- Węzeł `[393]` (Paskal Beniwoll): `AddConversant("Daria de Rava");`
- Węzeł `[395]` (Paskal Beniwoll): `AddConversant("Daria de Rava"); -- Adds the conversant with the character name in database;`
- Węzeł `[399]` (Paskal Beniwoll): `AddConversant("Manus Sazon");`
- *...oraz 16 innych węzłów ze skryptami.*

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
  - -> `[424]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_StateReligion_Wruhecism == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Once more, I took my seat next to Hugo in the middle of the House of Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[16]`
Mówca: **Narrator**
> "My uncle seemed to be in a grim mood today. He watched with agitation as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""Are you sure it's a good idea to be here today, Your Majesty? You have every right to shutter the House of Delegates while the war is ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[24]`
Mówca: **Narrator**
> "My uncle watched with agitation as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""Your first visit to the House of Delegates since the RPP took over as majority party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And give my enemies in ATO more ammunition against me? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't blindly fight a war without knowing what's going on in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Failing to appease my citizens now will lead to mutiny down the line. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""I hope they behave themselves in front of their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[76]`
  - -> `[77]`
  - -> `[84]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. It's not what Vina would have wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not as long as my daughter's lover is one of the speakers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Narrator**
> "Hugo rubbed his forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""Right. About that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Narrator**
> "His expression saddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""I am truly sorry, Romus. But the hostage situation with Her Highness is all the more reason why...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "A gavel banged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[43]`
Mówca: **Narrator**
> "My uncle watched with a smile as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RNCWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I think we'll find a lot more supporters of the Crown since the last time we were here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""I'm relieved that the RPP's historic gains six years ago were a mere anomaly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[61]`
  - -> `[68]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""We appease them by winning. Which we actually might have a chance at, if we focus and apply ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""That's what the reports from your Council are for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Your enemies already have formed their opinions about monarchies. Keeping our symbolic parliament open is not going to change them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Of course, the Delegates' advice is invaluable in times of peace. But I just think that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Manus Sazon, positioned behind the House Speaker podium, carefully put the wooden mallet aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Daria de Rava, positioned behind the House Speaker podium, put the wooden mallet aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[58]`
Mówca: **Narrator**
> "My uncle watched calmly as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""I don't see many fresh faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""It's a relief that the RPP didn't manage to make any gains over last time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[61]`
  - -> `[68]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Phew. What a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps Manus Sazon's charisma is wearing off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""One can only hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Unfortunate that our minority speaker managed to retain his position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if that wasn't the case, I'm under no obligation to take the party's advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""That's true. But we don't want them getting big ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't mind hearing a little more from the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""As long as Manus Sazon is still minority speaker, you will hear plenty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will if they want to keep their heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their movement is undeniable now. Perhaps we should start listening to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Throw them a scrap or two. But we can't let them have the whole roast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""There's over 50 of them. Beheading that many politicians would be... well, I would rather not say 'satisfying', but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about it. The party and I have an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""Actually, that does worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they want to throw a tantrum, I'll let them. They still don't have any real power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""As the majority speaker of the House of Delegates, I hereby call this session to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "He bowed in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Thank you for coming in the middle of this turbulent time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""Thank you for coming, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Manus looked down at his podium with a slight frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Manus Sazon**
> ""At His Majesty's request, Grand Wiseman Ignacius will open today's session with a short prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[98]`
Mówca: **Daria de Rava**
> ""I call this meeting of the House of Delegates to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She bowed in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Daria de Rava**
> ""Thank you for coming in the middle of this turbulent time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Daria de Rava**
> ""Thank you for coming, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Daria looked down at her notes with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Daria de Rava**
> ""At His Majesty's request, Grand Wiseman Ignacius will open today's session with a short prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "All Delegates' eyes followed Sal as he rose from the back row of seats and slowly walked to the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Standing between Manus and Daria, he opened his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Sal Ignacius**
> ""Dearest brothers and sisters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Sal Ignacius**
> ""As we gather here today, we call upon the spirit of St. Wruhec and the guidance of the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Sal Ignacius**
> ""May the great Nur bestow upon us the clarity of mind and purity of intent necessary to serve our people with honor and integrity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Sal Ignacius**
> ""We pray for the day when swords can be sheathed and harmony restored, when our troops return to their homes, and peace reigns once more in our lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Sal Ignacius**
> ""We pray for the courage to face our challenges, and the wisdom to choose paths that lead to prosperity and peace for our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Sal Ignacius**
> ""God bless this assembly, and God bless our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
Mówca: **Narrator**
> "He lowered his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words. May you all take them to heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Narrator**
> "The Delegates murmured the word as well. Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[126]`
Mówca: **Narrator**
> "The Delegates solemnly applauded. Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[127]`
Mówca: **Narrator**
> "The Delegates murmured "Halaita" as Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Manus waited until the Grand Wiseman sat down before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Daria waited until the Grand Wiseman sat down before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""Yes, thank you, Grand Wiseman. That was... enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""Yes, thank you, Grand Wiseman. We will not forget the role of God in these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Narrator**
> "He flipped open a binder on his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Narrator**
> "She flipped open a binder on her podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `385` (*Rizia/Turn 7/Pales War Update And Tax*), Węzeł `[1]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `385` (*Rizia/Turn 7/Pales War Update And Tax*), Węzeł `[1]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""The first item on our agenda is an update on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `386` (*Rizia/Turn 7/Zille Treaty Discussion*), Węzeł `[1]`

### Węzeł `[144]`
Mówca: **Daria de Rava**
> ""The first item on our agenda is an update on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `386` (*Rizia/Turn 7/Zille Treaty Discussion*), Węzeł `[1]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Manus closed the binder and looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""That concludes today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Daria closed her binder and looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""That concludes today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[228]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""Unless, of course, His Majesty had any closing remarks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[161]`
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In fact, I do. House Speaker Sazon, esteemed delegates...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I do not. This is your space, not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "Manus nodded gratefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[163]`
Mówca: **Narrator**
> "The Delegates were all listening closely to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[168]`
  - -> `[179]`
  - -> `[180]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that the RPP now holds a delegate majority. However, that does not give you free rein to speak critically of your King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[188]`
  - -> `[198]`
  - -> `[194]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the criticism you have expressed today and will take it to heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[184]`
  - -> `[198]`

### Węzeł `[169]`
Mówca: **Sal Ignacius**
> ""It would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Once more, Sal walked over to stand between the two House speakers. This time, he took each one by the hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Sal Ignacius**
> ""My beloved Delegates, do not let your differences prevent you from recognizing the Divine in each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Sal Ignacius**
> ""Remember, we are but one people, watching over this kingdom by the great grace of our God, duty-bound to carry His truths into the mortal realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[175]`
  - -> `[176]`
  - -> `[174]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the truths of His emissary, your sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, let us not forget that some of those truths are more truthful than others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your wisdom is inspiring, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[177]`
Mówca: **Sal Ignacius**
> ""Hrm. Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Hugo and everyone else in the room repeated the word after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank you for bringing my attention to the plight of the less fortunate in my kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[184]`
  - -> `[198]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of your constant negativity. The next time we convene in these chambers, I would like to hear only good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[188]`
  - -> `[198]`
  - -> `[194]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not forget that you are here to serve me. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can expect prompt action from the Crown regarding the matters you brought up today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that we are at war. And during a war, you stand behind your king no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what is going on around us, we cannot neglect our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As members of one of the world's few remaining monarchist governments, I expect you to stand behind me no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is by my sword you live. I could have this assembly dissolved at any moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can serve my people a lot more easily when I am not surrounded by constant disagreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my hope that the majority and opposition can find common ground. Otherwise, we are all lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[200]`
  - -> `[203]`
  - -> `[213]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, my comrades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bid you farewell until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, see you for dinner at ours next week.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Hugo and the Delegates repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Hugo and the Delegates quietly repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[216]`
Mówca: **Narrator**
> "The Delegates looked puzzled. A few applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Manus' face reddened. He nodded and left his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[218]`
Mówca: **Narrator**
> "The Delegates politely applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""Then until next time, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Narrator**
> "I repeated the phrase along with Hugo and the other Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""It is not my wisdom, but that of the heavens above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[223]`
Mówca: **Narrator**
> "My uncle and I remained seated as the session adjourned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[298]`
  - -> `[309]`
  - -> `[295]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In fact, I do. Madame Speaker, esteemed delegates...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I do not. This is your space, not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Daria nodded graciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[231]`
Mówca: **Narrator**
> "The Delegates were all listening closely to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[236]`
  - -> `[260]`
  - -> `[261]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that the RNC now holds a delegate majority. However, that does not give you free rein to speak critically of your King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[243]`
  - -> `[284]`
  - -> `[262]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the criticism you have expressed today and will take it to heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[251]`
  - -> `[284]`

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""It would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Once more, Sal walked over to stand between the two House speakers. This time, he took each one by the hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Sal Ignacius**
> ""My beloved Delegates, do not let your differences prevent you from recognizing the Divine in each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""Remember, we are but one people, watching over this kingdom by the great grace of our God, duty-bound to carry His truths into the mortal realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[255]`
  - -> `[257]`
  - -> `[242]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the truths of His emissary, your sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not forget that you are here to serve me. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can expect prompt action from the Crown regarding the matters you brought up today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what is going on around us, we cannot neglect our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As members of one of the world's few remaining monarchist governments, I expect you to stand behind me no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is by my sword you live. I could have this assembly dissolved at any moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, let us not forget that some of those truths are more truthful than others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that we are at war. And during a war, you stand behind your king no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your wisdom is inspiring, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Hugo and everyone else in the room repeated the word after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[259]`
Mówca: **Sal Ignacius**
> ""Hrm. Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank you for bringing my attention to the plight of the less fortunate in my kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[251]`
  - -> `[284]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of your constant negativity. The next time we convene in these chambers, I would like to hear only good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[243]`
  - -> `[284]`
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[265]`
Mówca: **Narrator**
> "The Delegates looked puzzled. A few applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, my comrades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bid you farewell until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, see you for dinner at ours next week.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[271]`
Mówca: **Sal Ignacius**
> ""It is not my wisdom, but that of the heavens above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Hugo and the Delegates quietly repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can serve my people a lot more easily when I am not surrounded by constant disagreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my hope that the majority and opposition can find common ground. Otherwise, we are all lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[277]`
  - -> `[273]`
  - -> `[283]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Hugo and the Delegates repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Manus' face reddened. He nodded and left his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[287]`
Mówca: **Narrator**
> "The Delegates politely applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[288]`
Mówca: **Daria de Rava**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Narrator**
> "I repeated the phrase along with Hugo and the other Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[290]`
Mówca: **Daria de Rava**
> ""Then until next time, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Daria de Rava**
> ""Unless, of course, His Majesty had any closing remarks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well. Seems like Rizia is doing better than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a waste of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're screwed, aren't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[301]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So everybody loves me. That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""To hear the Sazon boy tell it, yes. But do you trust him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""I would not put it so crassly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""Be careful, Your Majesty. You cannot afford to fall into complacency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House of Delegates? More like House of Irrelevance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd better get to work passing decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""Apparently, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""Be careful how much you capitulate to the RPP. Their victory is already getting to Mr. Sazon's head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""The RNC has some good proposals. But you needn't give Baroness de Rava everything she is asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Hugo suppressed a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Hugo Toras**
> ""I keep telling you, Your Majesty. Your presence is not required at these sessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`
  - -> `[351]`
  - -> `[352]`

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""To put it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any thoughts on today's session, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""The Sazon boy is getting overconfident since his election win. I would be careful of how much you capitulate to his party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[327]`
Mówca: **Narrator**
> "He kept his eyes on the Delegates as they left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Hugo Toras**
> ""Having said that... the concerns he raised about the public's discontent were valid. We should find a way to mollify them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Hugo Toras**
> ""The concerns he raised about public discontent were overblown, if you ask me. I would not worry about the state of the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""And I don't trust his assessment of public opinion. The whispers I've been hearing tell a very different story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""Having said that, I do trust his assessment of the public's opinion. It is consistent with what I've been hearing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Baroness de Rava is handling the House as capably as ever. But a certain opposition speaker is getting a little too confident for comfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Narrator**
> "He kept his eyes on the Delegates as they left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[343]`
Mówca: **Narrator**
> "He picked up his attache case and paused to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[344]`
Mówca: **Hugo Toras**
> ""Having said that... the concerns raised about the public's discontent were valid. We should find a way to mollify them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Hugo Toras**
> ""The concerns that were raised about public discontent are overblown, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. I just felt like a good laugh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. The Delegates need to be reminded whom they answer to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was kidding. It's always useful to hear how the public is doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're absolutely right. I should listen to you more often.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""As long as you remember that what you're hearing may not reflect the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""You have more pressing priorities than laughter, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Ideally, my presence should serve as that reminder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[356]`
Mówca: **Hugo Toras**
> ""I am your Grand Vizier. Trust me to fulfill my function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""It's been a while since the two of us caught up. I hope you'll do me the honor of paying me a private visit once you're back from your trip to Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[360]`
  - -> `[387]`
  - -> `[366]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have something to say to me, you should say it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as no wine is involved, I'd love to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as wine is involved, I'd love to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Derdians don't kill me? Sure thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Hugo Toras**
> ""There are some matters that are best kept in the family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The honor would be all mine, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Narrator**
> "Hugo rose and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Hugo Toras**
> ""Until then, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[369]`
Mówca: **Narrator**
> "I stayed in my seat until the room was completely empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Narrator**
> "Was Manus right? Was my public happy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Narrator**
> "And if he was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[378]`
Mówca: **Narrator**
> "Was Daria right? Was my public happy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Narrator**
> "And if she was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[383]`
Mówca: **Narrator**
> "Was Manus right? Was my public unhappy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Narrator**
> "And if he was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Was Daria right? Was my public unhappy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Narrator**
> "And if she was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't promise you anything. Who knows if I'll make it back from Derdia alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Daria de Rava");)*
- **Efekt (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[394]`
Mówca: **Narrator**
> "Daria forced a smile from behind the opposition podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Daria de Rava");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `AddConversant("Daria de Rava");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Daria de Rava**
> ""Yes. On behalf of both of our parties, your presence is much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[397]`
Mówca: **Narrator**
> "She nodded at Manus, who flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[398]`
Mówca: **Narrator**
> "Manus nodded his assent from his usual place behind the opposition podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[400]`
Mówca: **Narrator**
> "Daria flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaDLCSupport.News_Turn07_V_MateusDeath = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_RH_MateusDeath"] = true;
Variable["RiziaDLCSupport.News_Turn07_V_MateusDeath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_RD_WarProfitsTax = true; RiziaDLCSupport.News_RD_RH_WarProfitsTax = true;
RiziaDLCSupport.News_RD_V_WarProfitsTax = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_RD_WarProfitsTax"] = true;
Variable["RiziaDLCSupport.News_RD_RH_WarProfitsTax"] = true;
Variable["RiziaDLCSupport.News_RD_V_WarProfitsTax"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Facing parliament after the elections", "House of Delegates", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Facing parliament after the elections","House of Delegates","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Hugo Toras**
> ""It's been a while since the two of us caught up. I hope you'll do me the honor of paying me a private visit one of these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[360]`
  - -> `[366]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
