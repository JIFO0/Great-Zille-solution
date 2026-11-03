# Rizia/Turn 9/Morella Derdia Mediation

- **ID konwersacji:** `436`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/436_Morella_Derdia_Mediation.md`
- **Liczba węzłów dialogowych:** 403
- **Liczba wyborów gracza:** 63

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[95]** Player_Romus *(Gracz)*
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.MITZ_Concession_DerdianBorderAssistance`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed`
- `RiziaDLC.Policy_Law_Monarchy_Absolute`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure`
- `RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[435] Rizia/Turn 9/FPnT_Mediation** (../Turn_09/435_FPnT_Mediation.md), Węzeł `[6]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 18

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Paskal Beniwoll): `AddConversant("Alma Saltana"); AddConversant("Jorga Azmal");`
- Węzeł `[21]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[138]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[192]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] = true; EnactDecree("Religio...`
- Węzeł `[268]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower...`
- Węzeł `[269]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- Węzeł `[278]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- *...oraz 10 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `435` (*Rizia/Turn 9/FPnT_Mediation*), Węzeł `[6]`

### Węzeł `[3]`
Mówca: **Narrator**
> "A knock came on the door. Prime Minister Saltana and Supreme Wiseman Azmal had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "A lot had happened since I promised the Derdian and Morellan leaders that I would mediate between them. But I was still determined to find a solution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
Mówca: **Narrator**
> "They and a handful of their ministers joined myself and Laurento around the conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[14]`
  - -> `[15]`
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So. Here we all are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to begin with a short prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The Supreme Wiseman's eyes shone with delight. His Morellan counterpart crossed her arms impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Alma Saltana**
> ""If you must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Alma Saltana");
AddConversant("Jorga Azmal");)*
- **Efekt (`userScript`):** `AddConversant("Alma Saltana");
AddConversant("Jorga Azmal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies, gentleman. Shall we get right to it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you both for joining me. I am confident we can accomplish great things today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
Mówca: **Alma Saltana**
> ""Gladly, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we gather today, I pray that we do not let our trivial differences blind us. For we are but one people, united by God's enduring love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""O Divine Creator, bless this mediation table and all who are seated at it. Help them to open their hearts and minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord, guide me in my sacred duty of finding communion between the nations of the former Empire of Moridia, that we may come together against the greater powers who wish us harm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""Halaita, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Azmal and Saltana looked at each other uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[23]`
Mówca: **Alma Saltana**
> ""Yes. Here we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Laurento tented his fingers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He opened a folder and pulled out a map of Derdia, Rizia and Morella with a diagram drawn on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""We call this St. Wruhec's Corridor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""Each year, a select number of Derdians with an appropriate prayer visa will be allowed into Morella via this specific channel. It includes the most important sanctuaries on the Golcondist pilgrimage route.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia re-allowed Derdian Golcondists into our places of worship with no ill consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Alma Saltana**
> ""Rizia shares no borders with Derdia. The only reason you have not been overwhelmed by an influx of so-called pilgrims is because we have been holding them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""The route continues into Rizia, where Derdian pilgrims have been permitted for some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The Supreme Wiseman leaned forward and scrutinized the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""This route ends at Lauante. After which, I suppose, we are to march into the sea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go home the way you came. It's not that difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may continue into Rizia, as long as you agree to respect our blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not at all. I fully plan on allowing Golcondists to worship in Rizia as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Both Azmal and Saltana glowered at me. The Morellan prime minister cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Alma Saltana**
> ""{RiziaDLCText.SaltanaToPlayer}, you cannot really expect Morella to allow in Golcondist pilgrims while barring them from your own sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[163]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our Wruhecist community is larger than Morella's. There is greater potential for disruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid revoking our blasphemy law is out of the question. The Wruhecist Sanctuary is very powerful in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is in the middle of a war. I don't want to make any sudden policy changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Azmal raised his eyebrows skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Jorga Azmal**
> ""You plan on it. I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""You will forgive me if I don't place much stock in your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[190]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Saltana looked at us both uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Laurento cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Laurento Esquibel**
> ""We all know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Concession_DerdianBorderAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Concession_DerdianBorderAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Laurento Esquibel**
> ""Your countries have been engaged in border disputes for years. Rizia has promised to help you find a common solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""Rizia has formed energy partnerships with both of your countries. It would behoove us all to find a solution to your border disputes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Jorga Azmal**
> ""Rizia has proven itself an unreliable energy partner. Why should we trust you as a mediator?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Saltana smiled coolly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Alma Saltana**
> ""Funny, Mr. Azmal. Rizia has failed to meet its energy promises to us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Alma Saltana**
> ""It seems we have one thing in common after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[84]`
  - -> `[86]`
  - -> `[93]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[76]`
Mówca: **Alma Saltana**
> ""Rizia has proven itself an unreliable energy partner. Why should we trust you as a mediator?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[86]`
  - -> `[93]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The Morellan prime minister nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Alma Saltana**
> ""A pipeline runs between Derdia and Morella now. If these insurgencies continue, our economies and image will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[82]`
Mówca: **Alma Saltana**
> ""It is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[83]`
Mówca: **Alma Saltana**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now is not the time to talk about the energy situation. You may bring it up with me later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am truly sorry that our conflict with Pales interfered with our promised energy deliveries. Once we have won, I will repay you triplefold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our energy deliveries were impeded by circumstances beyond my control. I sincerely apologize for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have more than that in common. It was only a few generations ago that the Moridians were one people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Azmal nodded vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Precisely, Your Majesty. Which is why it is so ludicrous that Derdians are being denied entrance into Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have a choice, do you? It's Rizia or nobody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Saltana pursed her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Azmal gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Narrator**
> "She looked over at Azmal. He reluctantly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Alma Saltana**
> ""Very well. Let's continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[104]`
Mówca: **Jorga Azmal**
> ""Very well. Let's continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Jorga Azmal**
> ""Insurgencies! It's exactly that kind of language that has made me reluctant to deal with you, Madam Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Alma Saltana**
> ""Are you sure it's my language you have a problem with, Mr. Azmal? Not the fact that I'm a woman who holds more power than you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[122]`
  - -> `[136]`
  - -> `[140]`

### Węzeł `[107]`
Mówca: **Alma Saltana**
> ""We would gladly welcome you if you behaved yourselves. Instead, we get raids, insurgencies...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Alma Saltana**
> ""Even if it's not currently in use, a pipeline runs between Derdia and Morella now. If these insurgencies continue, our economies and image will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Alma Saltana**
> ""With or without a Rizian energy deal, it is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will address the Supreme Wiseman using his full title, Prime Minister Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Her face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Alma Saltana**
> ""Forgive me, Your Majesty. But I am adamantly opposed to the intrusion of religion into statecraft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Jorga Azmal**
> ""And yet you cannot deny those who do believe in a higher power the right to worship as their ancestors have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[28]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[121]`
Mówca: **Jorga Azmal**
> ""Both of you are, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's obviously only one way to solve this. A Duel of Generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "Laurento turned pale. Saltana burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Alma Saltana**
> ""A king who just married his daughter to his cousin is proposing a duel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Alma Saltana**
> ""A king who just married off his daughter to expand his territory is proposing a duel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Alma Saltana**
> ""A duel. Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Alma Saltana**
> ""I'm here to talk politics, gentleman. Not play some sort of... game of thrones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Jorga Azmal**
> ""A duel won't be necessary, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Jorga Azmal**
> ""This is a problem with an easy solution. Allow Derdian Golcondists the freedom to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind the Prime Minister's language, Supreme Wiseman. You must admit that the violent conduct of your people at the Morellan border has not been justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Narrator**
> "His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[139]`
Mówca: **Jorga Azmal**
> ""I will admit no such thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop squabbling at once, both of you. Your conduct is befitting of kindergarteners, not world leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Both Saltana and Azmal looked down at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Jorga Azmal**
> ""Forgive me, Your Majesty. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Jorga Azmal**
> ""You may both run godless countries yourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[147]`
Mówca: **Jorga Azmal**
> ""You may not believe in God yourself, Ms. Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it the right to worship you are after, or is it Morella's resources? We have not forgotten the Meftiem invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The borders between Derdia and Morella were drawn only recently. They do feel rather arbitrary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Alma Saltana**
> ""And yet they are there for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What Derdians do hardly falls under the category of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Jorga Azmal**
> ""That was the work of rogue actors. And furthermore, it occurred long before my appointment as Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[153]`
Mówca: **Jorga Azmal**
> ""You are still under the sway of your Grand Wiseman, I see. Even after having arrested him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Jorga Azmal**
> ""You are still under the sway of your Grand Wiseman, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[158]`
Mówca: **Laurento Esquibel**
> ""Supreme Wiseman, Madam Prime Minister. This is the solution my department has devised for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[159]`
Mówca: **Narrator**
> "His finger traced a thick black line from the Derdian-Morellan border towards the Antacean coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[160]`
Mówca: **Jorga Azmal**
> ""If you don't mind, I would like to have more than a mere assurance from you before agreeing to anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[190]`

### Węzeł `[161]`
Mówca: **Jorga Azmal**
> ""Then I cannot agree to your plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Alma Saltana**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're in a delicate situation with Wehlen at the moment. I don't want to make any sudden policy changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[167]`
Mówca: **Alma Saltana**
> ""If you believe disruption is a concern at all, then I cannot agree to this plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Jorga Azmal**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So be it. I tried my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Wait. I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Wait. I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Wait. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Wait. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing I can do. That was my kingdom's best effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sal_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sal_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Very well. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Very well. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. An assurance is all I can give you right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Jorga Azmal**
> ""Then I cannot agree to this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Alma Saltana**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like your attitude, Supreme Wiseman. I will promise you nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[191]`
Mówca: **Jorga Azmal**
> ""How fortunate, Your Majesty. I knew you would see the light someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw = true; EnactDecree("Religion_RemoveGolcondistBlasphemyLaw");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] = true;
EnactDecree("Religion_RemoveGolcondistBlasphemyLaw");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[193]`
Mówca: **Jorga Azmal**
> ""I am not certain I believe you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Alma Saltana**
> ""Thank you anyway for your hard work, Mr. Esquibel. This corridor would have been an ideal compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Laurento Esquibel**
> ""Thank you, Madam Prime Minister. It may still be an option in the future, even if it is not possible today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[330]`
  - -> `[329]`
  - -> `[322]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Saltana eyed me suspiciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Alma Saltana**
> ""How do we know the Derdians will stick to the route as they pass through Morella?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower > 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower > 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower > 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I will send a company from the Rizian Armed Forces to grant the pilgrims secure passage." [Manpower -250]"]** — Mówca: **Player_Romus**
> ""I will send a company from the Rizian Armed Forces to grant the pilgrims secure passage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""The Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whoever violates the agreement will face the most severe of consequences. My kingdom will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[213]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[218]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[294]`
  - -> `[261]`

### Węzeł `[219]`
Mówca: **Jorga Azmal**
> ""How do *we* know the Morellans will not attempt to block it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[201]`
  - -> `[242]`
  - -> `[272]`

### Węzeł `[220]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[294]`
  - -> `[261]`

### Węzeł `[225]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[294]`
  - -> `[261]`

### Węzeł `[226]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[230]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[231]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[282]`
  - -> `[261]`

### Węzeł `[236]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[282]`
  - -> `[261]`

### Węzeł `[237]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[282]`
  - -> `[261]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[239]`
Mówca: **Laurento Esquibel**
> ""Thank you both for your swift willingness to compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""Such solutions always seem easy when it's a third party proposing them, don't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[241]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[248]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[253]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[285]`
  - -> `[288]`

### Węzeł `[258]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[285]`
  - -> `[288]`

### Węzeł `[259]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[285]`
  - -> `[288]`

### Węzeł `[260]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you're both out of luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[262]`
Mówca: **Laurento Esquibel**
> ""We'll assemble a team from all three of our countries to begin the creation of the corridor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[312]`
  - -> `[307]`
  - -> `[304]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Fine. We will send *two* army companies." [-500 Manpower]"]** — Mówca: **Player_Romus**
> ""Fine. We will send *two* army companies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Fine. We will pour twice as much funding into security as planned." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. We will pour twice as much funding into security as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Fine. A company from the Rizian Armed Forces will be physically present to grant the pilgrims secure passage." [Manpower -250]"]** — Mówca: **Player_Romus**
> ""Fine. A company from the Rizian Armed Forces will be physically present to grant the pilgrims secure passage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""If you insist, the Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If you insist, the Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[267]`
Mówca: **Narrator**
> "The two of them looked at each other. Each gave a short, approving nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower -= 250)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""In addition to the military reinforcements, we will contract a team of independent security officers." [-250 Manpower, -1 Budget]"]** — Mówca: **Player_Romus**
> ""In addition to the military reinforcements, we will contract a team of independent security officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[271]`
**[WYBÓR GRACZA: ""In addition to the security firm, we ourselves will send a company from the Rizian Armed Forces." [-1 Budget, -250 Manpower]"]** — Mówca: **Player_Romus**
> ""In addition to the security firm, we ourselves will send a company from the Rizian Armed Forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just going to have to trust each other, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Narrator**
> "The two of them looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Jorga Azmal**
> ""I should have known this would not be a serious plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[338]`
  - -> `[343]`

### Węzeł `[275]`
Mówca: **Narrator**
> "Saltana's brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Alma Saltana**
> ""Even if the corridor ends at Rizia's holy sites...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really thought we could erase a century's worth of resentment in five minutes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower >= 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower >= 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 500)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 500)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 500`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower >= 500))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 500) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1; RiziaDLC.Resources_Military_Manpower -= 250)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower -= 500)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 500;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower -= 250)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[301]`
Mówca: **Laurento Esquibel**
> ""That's it, then? You agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Morella and Derdia can come to a diplomatic agreement this quickly, I have high hopes for the Intermerkopum alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana, I hope this means that I can count on your cooperation during the final MITZ vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord has truly blessed us on this day. Rejoice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your hard work, Laurento. This was truly a team effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Laurento Esquibel**
> ""You honor me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[314]`
Mówca: **Narrator**
> "She smiled mysteriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Alma Saltana**
> ""We will see, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Jorga Azmal**
> ""Halaita!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Alma Saltana**
> ""...Yes. Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Laurento Esquibel**
> ""Agreed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Laurento checked his pocketwatch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[320]`
Mówca: **Narrator**
> "The two of them looked away from each other. Laurento attempted to mask his disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's fine. We don't need Morella and Derdia to get along for the Intermerkopum alliance to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alas, the Lord has not blessed us on this day. Perhaps we did something to anger Him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana, I hope I can still count on your cooperation during the final MITZ vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thanks anyway, Laurento. This was a great idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""You honor me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[332]`
Mówca: **Narrator**
> "Her expression betrayed no emotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[333]`
Mówca: **Alma Saltana**
> ""No comment, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Laurento Esquibel**
> ""I must say it would have helped, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Laurento checked his pocketwatch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[336]`
Mówca: **Alma Saltana**
> ""We will see, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, wait. I do have one idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[341]`
Mówca: **Alma Saltana**
> ""Yes, {Salutations.SaltanaToPlayer} ?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[201]`
  - -> `[242]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Suddenly the man who believes in an invisible person in the sky doesn't have faith in his own neighbor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[346]`
Mówca: **Narrator**
> "Azmal gasped indignantly. Saltana laughed out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must take a leap of faith, Supreme Wiseman. What would St. Wruhec have done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Jorga Azmal**
> ""As Wruhec himself said, the firmest bridge of trust may still be eroded by the waters of deceit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Narrator**
> "Saltana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Laurento Esquibel**
> ""We still have the Derdia-Wehlen mediations scheduled for today. Perhaps a short break?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[354]`
Mówca: **Laurento Esquibel**
> ""We are finished here. I am truly sorry we were not able to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Narrator**
> "The Derdian Supreme Wiseman and Morellan prime minister rose and shook both of our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Jorga Azmal**
> ""May God be with you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Narrator**
> "They and their entourages were escorted out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[359]`
Mówca: **Jorga Azmal**
> ""Yes, thank you. I must clear my head of prejudice after what just occurred.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Narrator**
> "The Morellan prime minister rose and shook our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "She and her entourage were escorted out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[366]`
Mówca: **Laurento Esquibel**
> ""We still have the Derdia-Wehlen mediations scheduled for today. Perhaps a short break?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
Mówca: **Laurento Esquibel**
> ""I'd like to go over a detail or two about that first. I'll escort you to the door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Narrator**
> "She and her entourage followed him out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[369]`
Mówca: **Jorga Azmal**
> ""Yes, thank you. This was surprisingly pleasant, but I do not expect our interaction with President Smolak to go as smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Narrator**
> "The Morellan prime minister rose and shook our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[372]`
Mówca: **Laurento Esquibel**
> ""We are finished here. I am happy Rizia was able to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Narrator**
> "The Morellan prime minister rose from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success = true; RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed = true; RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[378]`
Mówca: **Alma Saltana**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Alma Saltana**
> ""We in Morella have been paying attention to Rizia's internal politics. Your increasingly authoritarian policies leave us wondering about your reliability as a mediator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`
  - -> `[385]`
  - -> `[386]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Monarchy_Absolute"] == true  and  (Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Country_QuelledProtests"] >= 4)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Monarchy_Absolute"] == true  and  (Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Country_QuelledProtests"] >= 4)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have a choice, do you? It's Rizia or nobody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has always been an absolute monarchy, Ms. Saltana. You just chose to ignore it when it suited you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns, but they're not germane to today's conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have no idea what you're talking about. The people of my country enjoy a great many freedoms. More than Morella, in fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Narrator**
> "She gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Alma Saltana**
> ""Excuse me? That's just not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Laurento Esquibel**
> ""Madam Prime Minister, whatever our internal situation, we remain committed to finding a diplomatic compromise between your country and Derdia. And we are willing to put our money where our mouth is, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Narrator**
> "Laurento laughed nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[391]`
Mówca: **Alma Saltana**
> ""No? I'd like to know just what kind of monarchy I'm dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[392]`
Mówca: **Jorga Azmal**
> ""Derdia appreciates that commitment, Mr. Esquibel. As well as your tough but fair treatment of dissenters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Saltana sighed reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Alma Saltana**
> ""All right. Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Alma Saltana**
> ""Derdia and Morella are now connected by an energy pipeline. If Derdians continue to violate our borders, the economies and our images of both nations will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[399]`
Mówca: **Alma Saltana**
> ""It is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Alma Saltana");)*
- **Efekt (`userScript`):** `RemoveConversant("Alma Saltana");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Alma Saltana");
RemoveConversant("Jorga Azmal");)*
- **Efekt (`userScript`):** `RemoveConversant("Alma Saltana");
RemoveConversant("Jorga Azmal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Alma Saltana");)*
- **Efekt (`userScript`):** `RemoveConversant("Alma Saltana");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
