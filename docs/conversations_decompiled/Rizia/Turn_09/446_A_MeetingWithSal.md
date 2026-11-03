# Rizia/Turn 9/A_MeetingWithSal

- **ID konwersacji:** `446`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/446_A_MeetingWithSal.md`
- **Liczba węzłów dialogowych:** 441
- **Liczba wyborów gracza:** 86

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PipelineNatDes_DeployWG`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths`
- `RiziaDLC.Policy_RD_Law_EstablishReligiousCourts`
- `RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith`
- `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation`
- `RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed`
- `RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_WruhecistCommunity_Happy`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony`
- `RiziaDLC.WruhecistSanctuariesConstructed`
- `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Theocracy_None`
- `RiziaDLC.Theocracy_Partial`
- `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy`
- `RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`
- `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony`
- `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice`
- `RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier`
- `RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed`
- `RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony`
- `RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony`
- `RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 29

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[8]` (Paskal Beniwoll): `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- Węzeł `[9]` (Paskal Beniwoll): `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- Węzeł `[20]` (Paskal Beniwoll): `AddConversant("Sal Ignacius");`
- Węzeł `[26]` (Paskal Beniwoll): `AddConversant("Sal Ignacius");`
- Węzeł `[35]` (Paskal Beniwoll): `AddConversant("Sal Ignacius");`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] = true;`
- Węzeł `[118]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] = true;`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] = true;`
- *...oraz 21 innych węzłów ze skryptami.*

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
  - -> `[440]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Narrator**
> "As I stood in the Benievon Archsanctuary, I marveled at the Lake of Reflection. Its waters flowed through naturally formed channels, weaving through the sanctuary's heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Narrator**
> "As I stood in the Benievon Archsanctuary, I marveled at the Lake of Reflection. Its waters flowed through naturally formed channels, weaving through the sanctuary's heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The Archsanctuary had been constructed around these canals, incorporating their presence in its design."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[11]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, hoping for clarity amidst the echoes of protests resounding incessantly within my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Even in this oasis of calm, I could find no respite from the turmoil that plagued my realm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[13]`
Mówca: **Narrator**
> "With a furrowed brow, I attempted to silence the internal clamor, but the tumult of voices only grew louder -- perhaps a trial of faith in itself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "My hands clenched into fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[15]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Throw nearby chalice."]** — Mówca: **Player_Romus_Italic**
> "In a moment of unchecked anger, I seized a nearby chalice and hurled it across the Archsanctuary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Take a deep breath."]** — Mówca: **Player_Romus_Italic**
> "I closed my eyes and took a deep breath to calm my rising frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, shut up, will you?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "My voice echoed through the grand hall, though it was only meant for the empty air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Sal Ignacius**
> ""I didn't say anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[21]`
Mówca: **Narrator**
> "I turned and faced the Grand Wiseman, who I hadn't heard enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Grand Wiseman. I didn't hear you come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For God's sake, don't sneak up on me like that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wasn't referring to you, Grand Wiseman, but rather to the shouts of protests spreading across the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[25]`
Mówca: **Narrator**
> "It was then that I noticed Sal standing nearby. With a gentle grace, he retrieved the fallen chalice and approached, holding it out to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> ""I believe you dropped something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`
  - -> `[50]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God forgive me for that outburst.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ever heard of knocking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Sal Ignacius**
> ""Forgive me, Your Majesty. I thought you heard me come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Sal Ignacius**
> ""If you don't mind my asking, what seems to be the trouble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[71]`
  - -> `[73]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "Don't take chalice."]** — Mówca: **Player_Romus_Italic**
> "I didn't take the chalice back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Sal waited a moment before setting the chalice down on a nearby altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "Take chalice."]** — Mówca: **Player_Romus_Italic**
> "I took back the chalice and set it on the altar where I got it from."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Sal Ignacius**
> ""There you are, Your Majesty. I was looking for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[37]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, you found me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you need?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations. You win the prize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[43]`
Mówca: **Sal Ignacius**
> ""I came to inform you that the ceremony is set to begin within the hour, so we'll need to start letting people into the Archsanctuary soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He was referring to the graduation of the latest batch of Wruhec's Guardians cadets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Despite the Board of Trustees' initial resistance, they eventually committed to incorporating the Guardians' doctrine into the school's standard curriculum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Thus, the ceremony provided a convenient excuse for my visit to Benievon amidst the unrest in Porte Drazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, I lost my temper. I've got a lot on my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Sal Ignacius**
> ""No need to apologize, Your Majesty. I can only imagine the pressure you're under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[32]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "With a furrowed brow, I attempted to silence the internal clamor, but the tumult of voices only grew louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface. Its serenity stood in quiet defiance to the echoes of protests resounding incessantly within my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me. I didn't hear you come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do I owe the pleasure, Grand Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[62]`
Mówca: **Sal Ignacius**
> ""No need to apologize, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[63]`
Mówca: **Sal Ignacius**
> ""I hope I'm not interrupting. Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""Not necessarily, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Sal Ignacius**
> ""Lucky me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[66]`
Mówca: **Sal Ignacius**
> ""I just wanted to inform you that the ceremony is set to begin within the hour, so we'll need to start letting people into the Archsanctuary soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[67]`
Mówca: **Sal Ignacius**
> ""Ah, I see. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[68]`
Mówca: **Sal Ignacius**
> ""Not a problem Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""My apologies. I didn't mean to startle you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[70]`
Mówca: **Narrator**
> "My newly established religious security force was headquartered at the nearby Benievon Academy, a prestigious institution renowned for catering to the noble and elite class of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must have noticed the unrest in our kingdom. I fear Rizia is on the verge of an uprising once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm troubled by the seemingly endless stream of issues plaguing our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""Very well. I won't press the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[75]`
Mówca: **Sal Ignacius**
> ""Ah, yes. It saddens me to see our people losing faith in their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[76]`
Mówca: **Sal Ignacius**
> ""As am I, Your Majesty. It saddens me that our people are losing faith in their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The sound of the Archsantuary doors opening drew our attention to the front entrance, where people began trickling inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Sal and I stepped away from the main aisle, allowing the flow of individuals to pass without obstruction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[79]`
Mówca: **Sal Ignacius**
> ""Uncertainty breeds turmoil, but faith endures. No matter how restless the times, I believe God will guide us through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[80]`
  - -> `[82]`
  - -> `[87]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I shared your optimism. Just thinking about it makes my head explode.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every day, I hope for a peaceful resolution. However, I'm concerned that we may need to consider more assertive measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These agitators mistake tolerance for weakness. It's a misunderstanding I intend to rectify.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every day, I offer prayers for a peaceful resolution. Yet, I cannot help but fear that more assertive measures may become necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It just feels like we've exhausted all available resources -- that nothing I do ever satisfies them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""Your Majesty, while it may seem that way, we mustn't lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty. Maintaining order and authority is essential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""It's normal to feel overwhelmed, but remember, you're never alone. God is always with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Sal Ignacius**
> ""I share your hope for peace, but I also understand your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Even in the darkest hours, there's always a glimmer of hope that the odds, no matter how daunting they may seem, will be overcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""And for what it's worth, you have me, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Our attention was drawn to the majestic tones of an organ that resonated throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Cadet_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[103]`
  - -> `[100]`
  - -> `[109]`
  - -> `[210]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, how long does their training last?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are a select few wearing different uniforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know. We can speak more about them some other time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many are there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
Mówca: **Sevrio Castellanus**
> ""There are over 2,500, Your Majesty -- a mere fraction of the cadets enrolled across Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[113]`
Mówca: **Sevrio Castellanus**
> ""Those are the elite cadets, Your Majesty, known as 'The Devout.' They are the most dedicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Sevrio Castellanus**
> ""Physical fitness and defense training lasts for 10 weeks, followed by an additional 6 weeks of spiritual training, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[115]`
Mówca: **Sevrio Castellanus**
> ""Each one has endured a rigorous spiritual experience of seven days and nights, staring into the Lake of Reflection without food or water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Sevrio Castellanus**
> ""This experience makes them officers and leaders among their peers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Cadet_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[121]`
Mówca: **Sevrio Castellanus**
> ""It would be my pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Once the cadets had finished taking their respective seats, the Wiseman of Benievon stepped into the pulpit and began his commencement address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Sevrio Castellanus**
> ""If I may speak freely... given the civil upheaval we're seeing, I feel there is a solution that's not being used to its full potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLC.PipelineNatDes_DeployWG"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLC.PipelineNatDes_DeployWG"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[127]`
Mówca: **Narrator**
> "He gestured subtly to the cadets in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians. As you know, we've been tasked with faith-based humanitarian work--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[129]`
Mówca: **Sevrio Castellanus**
> ""But we could be doing more. Much more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Sevrio Castellanus**
> ""Perhaps it's time for us to set aside the plowshares and to wield the sword of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[137]`
  - -> `[131]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wruhec's Guardians have proven their dedication and capability, and are a force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Sevrio Castellanus**
> ""Yes, I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Sevrio Castellanus**
> ""Legally speaking, you have the authority to deploy Wruhec's Guardians to maintain order and uphold God's divine law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Sevrio Castellanus**
> ""As you are God's representative on earth, earthly laws are no different from godly laws, and vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Sevrio Castellanus**
> ""Disregard of divine laws is punishable on earth as it is in the eyes of the Almighty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Ensure that Wruhec's Guardians are given everything they need." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Ensure that Wruhec's Guardians are given everything they need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you certain that deploying them to quell unrest is the right course of action?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, legally speaking, Captain Gordion and I have the authority to deploy Wruhec's Guardians to maintain order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Sevrio Castellanus**
> ""As the appointed representative of God on earth, you have the power to enforce divine laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[146]`
  - -> `[140]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But using them for such purposes... I worry about public backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Sevrio Castellanus**
> ""I understand your hesitation, but in times of crisis, we must be prepared to take necessary measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must do what is necessary to restore peace and order. See to it that Wruhec's Guardians are prepared for their new duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sword of justice. Are you advocating for violence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Sevrio Castellanus**
> ""I am advocating for the restoration of order, so that our kingdom may continue on the path that has been ordained for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Sevrio Castellanus**
> ""As the earthly representative of God, you have the legal means to authorize the Guardians to use as much force as necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[146]`
  - -> `[140]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but using them for such purposes... It feels like a drastic measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Sevrio Castellanus**
> ""I understand your hesitation, Your Majesty. But the situation seems dire to me, and we must consider all available options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your perspective, Sevrio. But I'm not inclined to deploy Wruhec's Guardians in this manner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Sevrio Castellanus**
> ""Understood, Your Majesty. I will ensure that our cadets persist in their current endeavors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[150]`
Mówca: **Sevrio Castellanus**
> ""Of course, Your Majesty. I'll ensure the Wruhec's Guardians are prepared to fulfill their new responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty. I will see to it that the Wruhec's Guardians are fully prepared to uphold justice and restore order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I get that. But just because we *can* deploy them doesn't mean that we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Deploying Wruhec's Guardians in such a manner will only worsen the problem. We need peaceful solutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Sevrio Castellanus**
> ""I fear the time for peace is rapidly coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = true; RiziaDLC.Theocracy_Partial = true;
RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians = true;
RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] = true;
Variable["RiziaDLC.Theocracy_Partial"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[157]`
Mówca: **Sal Ignacius**
> ""Your Majesty... with the formation of the Guardians, we came one step closer to bringing God's will to Rizia. But now I must humbly beg you to take a leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. What is it that you are asking of me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm on board with implementing theocratic reforms. What would you have me do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all the same to me. Expressing religious devotion publicly is one thing. But I won't put Wruhecism front and center in government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[161]`
Mówca: **Sal Ignacius**
> ""God be praised! I knew you envisioned this kingdom's future as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[162]`
Mówca: **Narrator**
> "As if ordained from heaven, the organ, once again, came to life. Everyone stood and began singing a hymn, their voices reverberating throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Sal Ignacius**
> ""Please excuse me, Your Majesty. I must now attend to my duties at the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Sal made his way into the congregation, and I observed the procession. Each cadet approached Sal, who reverently collected the holy water from the sacred pool into a chalice from which to drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Sal Ignacius**
> ""Unless you'd like to do it yourself, given your divine appointment as Rizia's spiritual leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be my honor. I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go ahead. I wouldn't want to deprive you of your sacred duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No thanks. But I appreciate the offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course! Just give me clear instructions on what needs to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Each cadet took their turn to partake in this sacred ritual, a symbol of their commitment and dedication to their faith and kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[174]`
Mówca: **Narrator**
> "He drank, bathed in the kaleidoscopic light from the stained-glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[176]`
Mówca: **Narrator**
> "As I made my way towards the mass of recruits, Sal briefed me on what to do before I joined him in distributing the holy water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[177]`
Mówca: **Narrator**
> "As each individual approached one by one, they did so with reverence, bowing as they neared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Narrator**
> "The one I recently threw across the room. Nevertheless..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Every cadet approached to partake in this sacred ritual, symbolizing their commitment and dedication to both their faith and their kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[186]`
Mówca: **Narrator**
> "The one I recently threw across the room. Nevertheless..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[188]`
Mówca: **Sal Ignacius**
> ""Nothing less and nothing more than the complete integration of Wruhecism into the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[189]`
Mówca: **Sal Ignacius**
> ""It seems our goals are not as in aligned as I thought. If that's the case, I have nothing more to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NoTheocracy_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NoTheocracy_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
Mówca: **Narrator**
> "The Grand Wiseman bowed politely before leaving my side as I continued to watch the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Narrator**
> "One motivational speech and several songs later, I observed the procession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_None = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_None"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[195]`
Mówca: **Narrator**
> "The Archsanctuary had been built around these canals, embracing their presence in its design."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, hoping to find spiritual clarity as legend said it would provide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, and I observed an old man I hardly recognized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "It was then I saw another familiar face in the water's reflection. Grand Wiseman Sal Ignacius."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[202]`
Mówca: **Narrator**
> "I had been invited here to witness the results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Before long, the majestic tones of an organ resonated throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[208]`
Mówca: **Sevrio Castellanus**
> ""This represents the third graduating class of the Benievon Academy, the most prestigious among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Sevrio Castellanus**
> ""If my memory serves me correctly, your uncle is an alumnus of the Academy. The old version of it, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "Say nothing and observe them."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent as the cadets kept filing in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "He gazed fondly at the cadets before us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Sal Ignacius**
> ""During Alignment of the Six Stars, I mentioned my willingness to advise you in a closer capacity. Are you ready to place a Grand Wiseman into the role of Grand Vizier?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[257]`
  - -> `[268]`

### Węzeł `[221]`
Mówca: **Narrator**
> "He gazed reverently at Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""Just as your Grand Vizier must be a man of God, so must all your advisors be versed in Wruhecist principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[306]`
  - -> `[309]`
  - -> `[313]`
  - -> `[315]`

### Węzeł `[223]`
Mówca: **Sal Ignacius**
> ""What do you say, Your Majesty? Shall we walk this path together, as in the stories of old?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[225]`
  - -> `[224]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot commit to any of this. You are asking for far too much. Sorry, Sal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can meet in the middle. Petition for Grand Vizier when the current Royal Council term ends, and I give you my word I will consider you for the position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shall. Rizia will be a holy Wruhecist kingdom, governed by messengers of God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[227]`
Mówca: **Sal Ignacius**
> ""It seems our goals are not as in aligned as I thought. If that's the case, and there's no changing your mind otherwise, I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NoTheocracy_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Partial = true; RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Sal Ignacius**
> ""Excellent! You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""I shall begin the preparations for our transformation immediately. Rizia is blessed to have you as our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full = true; RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards = true; 
RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier = true; RiziaDLC.Situation_Order_Unrest_NationalDestabilization = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Theocracy_Full"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier"] = true;
Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[233]`
Mówca: **Sal Ignacius**
> ""Bless you, Your Majesty! This decision heralds a new era for our kingdom, one where divine guidance illuminates our path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdatePlayerCountryGovernment("Theocratic Monarchy");)*
- **Efekt (`userScript`):** `UpdatePlayerCountryGovernment("Theocratic Monarchy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""It's wise to remain vigilant and consider all options. Even the less peaceful ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[238]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians can serve as a strong deterrent against further violence and unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[239]`
Mówca: **Sevrio Castellanus**
> ""We can help maintain stability and prevent further escalation of violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""As Grand Vizier, I can provide invaluable guidance on both state and soul, guaranteeing the prosperity of our realm in worldly matters and in matters of the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[241]`
Mówca: **Sal Ignacius**
> ""I'm to distribute the holy water to the new recruits, the final step to becoming a Wruhec's Guardian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Each cadet approached Sal, who reverently collected the holy water from the sacred pool into a chalice from which to drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Meanwhile, I carefully scooped up the holy water from the sacred pool into a chalice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At least the two of us still have the Lord on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize you were paying that much attention to earthly goings-on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your spiritual advice, Grand Wiseman. But when it comes to placating the populace, I'd rather consult with my council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Sal Ignacius**
> ""As is your right. Just remember that heaven and earth are more closely linked than they appear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[249]`
Mówca: **Sal Ignacius**
> ""The Lord and His holy messengers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[250]`
Mówca: **Sal Ignacius**
> ""I listen to our people, Your Majesty. When they have grievances, it is the Sanctuary whom they turn to first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those who go against the Crown will bear the full brunt of my vengeance. End of story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my doubts about replacing my uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[256]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that you mention it, the position has been vacant for some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a new Grand Vizier after my uncle's resignation. But I can't simply appoint you without considering other candidates. There are rules that have to be followed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo is a religious man himself. What if I were to keep him on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to the idea. Your advice has never steered me wrong thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[264]`
Mówca: **Sal Ignacius**
> ""You still don't understand, my king. The only rules that matter are God's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[265]`
Mówca: **Sal Ignacius**
> ""Indeed. This was predestined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[266]`
Mówca: **Sal Ignacius**
> ""You may keep him as an advisor, of course. But for our holy kingdom to succeed, the Grand Vizier position must be filled by a holy servant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[267]`
Mówca: **Sal Ignacius**
> ""It's only natural to have doubts. But listen to what your heart tells you. What the visions have prophesized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced this entire scheme isn't a power grab on your part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Sal Ignacius**
> ""If I could suggest someone else, I would. But I have spent my life as a conduit between the Crown and the heavens. I can think of no one else more qualified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[270]`
Mówca: **Sal Ignacius**
> ""I have only carried the word of God to your ears, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[271]`
Mówca: **Sal Ignacius**
> ""Next. there is the matter of your so-called Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[272]`
Mówca: **Sal Ignacius**
> ""In my eyes, it has never been fitting for the King of Rizia to surround himself with such an obvious symbol of material wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""All of your guardsmen must shed their golden trappings and become Wruhec's Guardians. I know Captain Gordion will agree with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[284]`
  - -> `[276]`
  - -> `[277]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are asking me to break centuries of Rizian royal tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Sal Ignacius**
> ""Decades, at most. Don't forget that your grandmother did away with the Golden Guard entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if they don't want to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[280]`
Mówca: **Sal Ignacius**
> ""Just imagine the members of the expanded Golden Guard working as one with Sevrio and our cadets here. It will be beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[281]`
Mówca: **Narrator**
> "He gestured down at the cadets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Sal Ignacius**
> ""I am sure replacements can be arranged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that makes sense. I shall be protected by a holy army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course he will. This is what you and he wanted from the beginning, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Sal Ignacius**
> ""We would never discuss such topics behind your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Sal Ignacius**
> ""But Captain Gordion's reverence for the Divine is obvious. With the Golden Guard fully subsumed into Wruhec's Guardians, his leadership will be one of our most powerful tools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[287]`
Mówca: **Narrator**
> "He lowered his voice even further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Sal Ignacius**
> ""Finally, Your Majesty... we will need to restructure the Royal Council under the guidance of the clergy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't imagine a priest would know more about war and security than Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[296]`
Mówca: **Narrator**
> "He spoke in a mysterious tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Sal Ignacius**
> ""The lady Azaro has a different role to play, Your Majesty. A far more important one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[298]`
Mówca: **Sal Ignacius**
> ""The lady Azaro knows nothing of God, Your Majesty. I have seen it in her eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is religious. I should keep him on as security councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Sal Ignacius**
> ""He is needed as Captain of the Wruhec's Guardians, Your Majesty. The Council will be a distraction from that role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The military wouldn't stand for it if I removed General Taddeus from the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Sal Ignacius**
> ""Perhaps General Azaro will enjoy the chance to lead the military from his home province, without his council role to distract him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't kick Elena and Laurento off the Royal Council. They've been there since I was a child.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Both Ms. Werner and Mr. Esquibel have led honorable lives in service to the crown. They have earned a happy retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't imagine the House of Delegates would be happy with that change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
Mówca: **Sal Ignacius**
> ""The Delegates' opinion is of no consequence. It never was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where will I find councilors with religious as well as state expertise? We can't reach Golconda if we tank the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Sal Ignacius**
> ""Don't you worry about that. The Lord will guide us forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At last. Sanctuary and state, working together as a single all-powerful apparatus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Sal Ignacius**
> ""As the ancient scripture foretold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[317]`
Mówca: **Sal Ignacius**
> ""When that time comes, I know you will choose wisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AssassinationOrdered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AssassinationOrdered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AssassinationOrdered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Sal Ignacius**
> ""Their late leader has become a false saint. They're using his martyrdom as an excuse to wreak havoc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Sal Ignacius**
> ""Their leader is a false idol. His followers blindly worship him, though he is leading them nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[326]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Dastnurists and Golcondists are marching with the revolutionaries. They have abandoned their Nurist values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Dastnurists are marching with the revolutionaries. They have abandoned their Nurist values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[334]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Golcondists are marching with the revolutionaries. Proof at last that they were never true Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Next to me, Sevrio serenely surveyed his army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[142]`
  - -> `[148]`
  - -> `[136]`

### Węzeł `[337]`
Mówca: **Narrator**
> "He lowered his voice to an intense whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.WruhecistSanctuariesConstructed > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.WruhecistSanctuariesConstructed > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.WruhecistSanctuariesConstructed"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.WruhecistSanctuariesConstructed > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.WruhecistSanctuariesConstructed"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[344]`
Mówca: **Sal Ignacius**
> ""With the sanctuaries you've built, the doctrine of Wruhecism has reached into every corner of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[345]`
Mówca: **Sal Ignacius**
> ""The university you sanctioned has created a new generation of learned men and women who will go forth and spread His will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Sal Ignacius**
> ""A long time ago, I had a vision of Rizia's future. I believe it is finally about to come to life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Sal Ignacius**
> ""Our precious children are now being blessed with the wisdom of St. Wruhec before they even learn the alphabet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Sal Ignacius**
> ""With your government's encouragement, Wruhecist religious organizations are growing and flourishing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Narrator**
> "A shiver ran through him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> ""It is time, Your Majesty. Time for the old structures to crumble, and for the great golden pillar of Golconda to rise from the ruins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[357]`
  - -> `[359]`
  - -> `[159]`
  - -> `[364]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am ready, Grand Wiseman. Show me the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Sal Ignacius**
> ""With pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to turn me on? Because it's working.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Sal Ignacius**
> ""Earthly desire has no place in this. I am speaking of the full integration of Wruhecism into the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no... this is all too much. You're trying to turn Rizia into Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Narrator**
> "The tone of his voice changed abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Sal Ignacius**
> ""You should know better than that, Your Majesty. Derdia's theocracy relies on keeping followers in the dark. Ours will shine God's light upon all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[160]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me precisely what you have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[368]`
Mówca: **Narrator**
> "After the last cadet had sipped the water, Sevrio quietly approached Sal as well. The wiscerer whispered a benediction and gently raised the chalice to my guardsman's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[369]`
Mówca: **Narrator**
> "After the last cadet had sipped the water, Sevrio quietly approached me as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[376]`
  - -> `[374]`
  - -> `[375]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God has big plans for you. Are you ready?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the name of St. Wruhec, I do bestow upon thee this holiest of blessings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thirsty, are we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're proud of these graduates. May they serve the kingdom well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Sevrio Castellanus**
> ""They will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[378]`
Mówca: **Sevrio Castellanus**
> ""Ready as I can be, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[379]`
Mówca: **Sevrio Castellanus**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Narrator**
> "He didn't laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Narrator**
> "I raised the chalice to my guardsman's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Narrator**
> "He drank, bathed in the kaleidoscopic light from the sanctuary's stained-glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[383]`
Mówca: **Narrator**
> "Captains Sevrio Castellanus and Titus Gordion walked in, their heads held high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Narrator**
> "They took their places on either side of Sal and myself as a continuous line of Wruhec's Guardian cadets began marching down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");
AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");
AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[386]`
Mówca: **Narrator**
> "With another blast from the organ, the Wiseman finished his address. Sevrio stepped forward and began affixing star-shaped pins to each individual cadet's collar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Narrator**
> "Sevrio leaned in and spoke in a hushed tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[388]`
Mówca: **Narrator**
> "As the ceremony continued, Sal turned to me once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[389]`
Mówca: **Narrator**
> "I had never felt so alive, so full of purpose. The time had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Narrator**
> "I felt full of pride -- in the Guardians, and in myself for sending them out into the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[394]`
Mówca: **Narrator**
> "Sevrio leaned closer, lowering his voice to a whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true;)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PipelineNatDes_DeployWG == true;)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PipelineNatDes_DeployWG == true;))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[398]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, if I may speak freely -- I wanted to say how honored I am by the trust you've placed in the Wruhec’s Guardians to quell the civil unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Sevrio Castellanus**
> ""My men are steadfast in their duty, not just to the realm, but to the divine order itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Sevrio Castellanus**
> ""To restore peace is to uphold the will of God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[403]`
  - -> `[402]`
  - -> `[404]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've handled yourselves admirably during these trying times, Sevrio. I expected nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your devotion is commendable, but there is still much to be done. I trust the Wruhec's Guardians will see this through to the very end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With righteousness on our side, there is no doubt that we will prevail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacred or not, peace is won through strength and vigilance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Sevrio Castellanus**
> ""My men remain sharp and unwavering in their duty -- we will not fail the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[406]`
Mówca: **Sevrio Castellanus**
> ""We stand ready for whatever lies ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Sevrio Castellanus**
> ""Faith and steel will carry us to victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Sevrio Castellanus**
> ""Your confidence in us strengthens our resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith"] == true  or  Variable["RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith"] == true  or  Variable["RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[413]`
Mówca: **Sal Ignacius**
> ""Your prohibition of heretic faiths has cleared the way for ours to flower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Sal Ignacius**
> ""Your Majesty... with the formation of the Guardians, we came one step closer to bringing God's will to Rizia. But I am afraid our goal of establishing a holy kingdom is still far out of reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[420]`
  - -> `[422]`
  - -> `[425]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our goal? This was always your goal, Sal, not mine. I only founded the Guardians to keep the peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Sal Ignacius**
> ""Hrm. That explains your cavalier treatment of the Wruhecist community since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Someday Rizia will rise to bask in God's glory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Sal Ignacius**
> ""Someday. When it has a king who prioritizes the Wruhecist congregation's needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean? Am I not the king from the prophesies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Sal Ignacius**
> ""I once thought you might be. But then, I thought the same of your father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Sal Ignacius**
> ""I'm not a young man, Your Majesty. Prophecies are as hard for me to read as newsprint.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would love nothing more than to spend the rest of my reign promoting the tenets of Wruhecism. But alas, it's just not realistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Sal Ignacius**
> ""I understand. I only entreat you not to take your faithful followers for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""As for the House of Delegates... I see no reason to alter its function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[431]`
Mówca: **Sal Ignacius**
> ""Having a direct conduit to the people will be useful. So long as we ensure the representatives are faithful Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Sal Ignacius**
> ""But as for the Royal Council... it will need to be restructured under the guidance of the clergy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[433]`
Mówca: **Narrator**
> "He lowered his voice even further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[434]`
Mówca: **Narrator**
> "The sanctuary choir broke into a jubilant-sounding hymnal, praising all who carry out the sacred duties of Nur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[435]`
Mówca: **Sevrio Castellanus**
> ""Repairing protester-damaged infrastructure, providing aid to displaced families, to name a few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_EstablishReligiousCourts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_EstablishReligiousCourts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[439]`
Mówca: **Sal Ignacius**
> ""Thanks to the establishment of religious courts, divine judgment now walks beside the law of the land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Attending the graduation of their religious militia", "Benievon Archsanctuary", "Kingdom of Rizia");)*
- **Efekt (`userScript`):** `SetRichPresence("Attending the graduation of their religious militia","Benievon Archsanctuary","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
