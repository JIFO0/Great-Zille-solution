# Sordland/Turn07/A_Autocrat_CourtDecision

- **ID konwersacji:** `139`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/139_A_Autocrat_CourtDecision.md`
- **Liczba węzłów dialogowych:** 395
- **Liczba wyborów gracza:** 114

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[56]** Karl Greiser
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Autocrat_YoungSords_NFP_Deal`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_AutocratEmergency_Revoke`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Policy_Order_DetentionWithoutTrial`
- `BaseGame.Policy_Order_SuspendedProtests`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Emergency_StartInvestigations`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_SecretState_ThreatenCourt`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Reform_Turn07_Emergency_Detained_Journalists`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Order_ReductionOfCrimeCommunities`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained`
- `BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens`
- `BaseGameSupport.Journal_Turn07_CourtDecision_Illegal`
- `BaseGameSupport.Journal_Turn07_CourtDecision_Invalid`
- `BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso`
- `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations`
- `BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists`
- `BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder`
- `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended`
- `BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked`
- `BaseGameSupport.News_Turn07_HP_CourtForEmergency`
- `BaseGameSupport.News_Turn07_R_CourtForEmergency`
- `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal`
- `BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal`
- `BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation`
- `BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt`
- `BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt`
- `GameCondition.Turn07_A_Autocrat_CourtDecision`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 40

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[158]` (Lucian Galade): `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] = true;`
- Węzeł `[159]` (Lucian Galade): `Variable["BaseGame.Reform_SecretState_ThreatenCourt"] = true;`
- Węzeł `[178]` (Lucian Galade): `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Journalists"] = true;`
- Węzeł `[181]` (Lucian Galade): `Variable["BaseGame.Reform_Emergency_StartInvestigations"] = true;`
- Węzeł `[206]` (Lucian Galade): `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] = true; Variable["BaseGameSupport.Cod...`
- Węzeł `[207]` (Lucian Galade): `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- Węzeł `[208]` (Lucian Galade): `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- Węzeł `[292]` (Lucian Galade): `Variable["GameCondition.Turn07_A_Autocrat_CourtDecision"] = true;`
- *...oraz 32 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was eagerly waiting for the decision of the Supreme Court regarding the Emergency Act. I stood up from my chair and looked out the window in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Yes. I have to.""]** — Mówca: **Player**
> ""Yes. I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[5]`
Mówca: **Petr Vectern**
> ""Do you trust Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Petr was with me too. He was slouching on the couch at the right side of the office and staring at the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The emergency decree was tough on all of my team. We were constantly battling with an opposition against our security measures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Absolutely not.""]** — Mówca: **Player**
> ""Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""I know that he will not make a mistake.""]** — Mówca: **Player**
> ""I know that he will not make a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""I just hope he holds up his end of the bargain...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
> ""So... You expect your decree to be declared invalid?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[16]`
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""So... You believe the Court will not push this to the end?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Unfortunately, it seems that way.""]** — Mówca: **Player**
> ""Unfortunately, it seems that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I have to be prepared for the worst.""]** — Mówca: **Player**
> ""I have to be prepared for the worst.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No, the Court cannot afford to do that.""]** — Mówca: **Player**
> ""No, the Court cannot afford to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Yes. They can't afford to do that.""]** — Mówca: **Player**
> ""Yes. They can't afford to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I have to hope for the best.""]** — Mówca: **Player**
> ""I have to hope for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""If they declare it unconstitutional, they may potentially try to go against you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""We can't face that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Of course we can.""]** — Mówca: **Player**
> ""Of course we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I know Petr. I know.""]** — Mówca: **Player**
> ""I know Petr. I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Stop whining.""]** — Mówca: **Player**
> ""Stop whining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""What do we do?""]** — Mówca: **Player**
> ""What do we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Well... I don't know. People are uneasy with the current security measures and the opposition is growing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Petr looked at me and then continued to stare at the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""I hope so, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Petr Vectern**
> ""If the Court decides to side with them... You may lose support from our party too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""You just cannot have the Court against you, Anton. There is no other way but to get them to your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""But maybe this period has lasted too long already...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""The opposition within our party is also growing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Bludish people are getting more discontent than ever... Bergia region is becoming increasingly volatile. The Aschraf anniversary will happen later this year; who knows how that will unfold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Malenyevism is on the increase among the protesters. The fights are continuing despite our security measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[41]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""Sordish nationalism is on the rise... Increased tensions and violence are going on despite our security measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[41]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""What are you saying, Petr?""]** — Mówca: **Player**
> ""What are you saying, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Stop grumbling for once.""]** — Mówca: **Player**
> ""Stop grumbling for once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Yes, I'm afraid this decree was a bad idea.""]** — Mówca: **Player**
> ""Yes, I'm afraid this decree was a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""We'll get through it, Petr.""]** — Mówca: **Player**
> ""We'll get through it, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""We must think about ways of boosting your image...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Petr Vectern**
> ""Maybe cooperating with the Old Guard was a bad idea...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""I wish I could be as hopeful as you. But I really need something good to happen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Suddenly, we heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Suddenly, we heard a knock on the door. Lucian came inside and bowed his head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""The Court has made its decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> ""They found the decree completely legal and ruled Mr. Ricter's complaints invalid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
Mówca: **Narrator**
> "And immediately afterwards, Lucian rushed in, out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""The Court has made its decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""They declared the Emergency invalid and agreed with every complaint of Mr. Ricter regarding your actions being unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""Thank God!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""That's good news.""]** — Mówca: **Player**
> ""That's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I knew they wouldn't do it.""]** — Mówca: **Player**
> ""I knew they wouldn't do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We have no obstacles left now.""]** — Mówca: **Player**
> ""We have no obstacles left now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""That will show Frens who he's messing with.""]** — Mówca: **Player**
> ""That will show Frens who he's messing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Now we can start thinking about the opposition. They are starting to really provoke the people to go out and protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""What are we going to do?""]** — Mówca: **Player**
> ""What are we going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I am fucked.""]** — Mówca: **Player**
> ""I am fucked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Well... We must respect the decision.""]** — Mówca: **Player**
> ""Well... We must respect the decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Damn the court!""]** — Mówca: **Player**
> ""Damn the court!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""There is no alternative either way. However, this decree has really damaged your popularity. If the Court sides with the opposition and pushes for it, they may actually impeach you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""This decree has done a lot of damage. But we can still figure something out to increase the support behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court does not push on investigating Mr. Ricter's claims. This can lead to further chaos and theoretically to your impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The phone rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "Answer it."]** — Mówca: **Player_Italic**
> "I answered the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "Ignore the phone."]** — Mówca: **Player_Italic**
> "I ignored the phone and let it ring until it came to a stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
Mówca: **Orso Hawker**
> ""How are you doing, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm doing fine.""]** — Mówca: **Player**
> ""I'm doing fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""You made a big mistake.""]** — Mówca: **Player**
> ""You made a big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""You damn bastard.""]** — Mówca: **Player**
> ""You damn bastard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[82]`
Mówca: **Orso Hawker**
> ""I told you not to go against the Old Guard, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Orso Hawker**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[84]`
Mówca: **Orso Hawker**
> ""Another thing you should know is... The Court has decided to open an investigation on you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Orso Hawker**
> ""I wanted to give you the proper respect by letting you know myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Come on, Mr. Hawker. Don't do this.""]** — Mówca: **Player**
> ""Come on, Mr. Hawker. Don't do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I will have your head!""]** — Mówca: **Player**
> ""I will have your head!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Don't you dare!""]** — Mówca: **Player**
> ""Don't you dare!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Fuck you, Mr. Hawker.""]** — Mówca: **Player**
> ""Fuck you, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Orso Hawker**
> ""Have a good day, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "He hung up the call and I froze with the phone still in my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Was it the Chief Justice? What did he say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`
  - -> `[96]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""They are opening investigations against me.""]** — Mówca: **Player**
> ""They are opening investigations against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I am screwed. They are investigating me.""]** — Mówca: **Player**
> ""I am screwed. They are investigating me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Yes. He's going to be a problem.""]** — Mówca: **Player**
> ""Yes. He's going to be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Fuck him!""]** — Mówca: **Player**
> ""Fuck him!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""Let's think straight. This isn't *so* bad. If they are not directly opening a case to impeach you for this decree, they must have an opposition inside the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Anton. Calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Petr Vectern**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""I mean... He has always been a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court stands divided in that. I'll start reaching out to the Justices and find out about their stance and if they're willing to be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""We have to make sure the Court has no plans to make this a case against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""I'll start reaching out to the Justices and find out about their stance and if they're willing to be bribed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""In the meantime, let's stay focused on our current tasks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`
  - -> `[108]`
  - -> `[346]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""You're right. I have complete trust in you guys.""]** — Mówca: **Player**
> ""You're right. I have complete trust in you guys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""We'll get through it.""]** — Mówca: **Player**
> ""We'll get through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I need to fix my image.""]** — Mówca: **Player**
> ""I need to fix my image.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Orso will pay. I'll involve Mr. Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""Sir? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "He had a worried face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""We'll need a proper plan for the remaining of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""We'll do our best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
> ""You work on boosting your image, sir. We'll do our job and keep you updated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""I'll talk to Nia. See if she can help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "They both left the room and I collapsed on my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[121]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""This sucks.""]** — Mówca: **Player**
> ""This sucks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I'll fix this.""]** — Mówca: **Player**
> ""I'll fix this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Bollocks.""]** — Mówca: **Player**
> ""Bollocks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""We need to silence the Court. They need to be given a lesson.""]** — Mówca: **Player**
> ""We need to silence the Court. They need to be given a lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It's fine Lucian. I just need to talk to Karl.""]** — Mówca: **Player**
> ""It's fine Lucian. I just need to talk to Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""I don't know what you have in mind but it sounds risky, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[126]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "Call Karl Greiser."]** — Mówca: **Player_Italic**
> "I took the phone and called Karl Greiser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You're right. We can't act so extreme.""]** — Mówca: **Player**
> ""You're right. We can't act so extreme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[127]`
Mówca: **Narrator**
> "After a few seconds of ringing, he picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Karl Greiser**
> ""This is Karl Greiser speaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Hello Karl, it's the President.""]** — Mówca: **Player**
> ""Hello Karl, it's the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Hi Karl, it's me.""]** — Mówca: **Player**
> ""Hi Karl, it's me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I need you to fix a problem.""]** — Mówca: **Player**
> ""I need you to fix a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Karl Greiser**
> ""Of course, sir. I am at your command. What is the issue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Karl Greiser**
> ""I am at your command, sir! How can I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Can we get rid of Orso Hawker?""]** — Mówca: **Player**
> ""Can we get rid of Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I need the Court Justices to be taught a lesson, so they'd know their place.""]** — Mówca: **Player**
> ""I need the Court Justices to be taught a lesson, so they'd know their place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Karl Greiser**
> ""You want them scared off, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Yes. Scare them off by any means necessary. Convince them.""]** — Mówca: **Player**
> ""Yes. Scare them off by any means necessary. Convince them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Threaten them, beat them, do whatever you want.""]** — Mówca: **Player**
> ""Threaten them, beat them, do whatever you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""No. Maybe we can't be so reckless.""]** — Mówca: **Player**
> ""No. Maybe we can't be so reckless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Karl Greiser**
> ""As you wish, sir. I'll give the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Teach them a lesson.""]** — Mówca: **Player**
> ""Teach them a lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
Mówca: **Karl Greiser**
> ""Do you have anything else in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[144]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""No, I've changed my mind, Karl. Good day to you.""]** — Mówca: **Player**
> ""No, I've changed my mind, Karl. Good day to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Karl Greiser**
> ""Understood, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[146]`
Mówca: **Karl Greiser**
> ""Consider it done. Have a good day, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[147]`
Mówca: **Karl Greiser**
> ""You want him completely *gone*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[150]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""His time has come.""]** — Mówca: **Player**
> ""His time has come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Yes. This will teach everyone a lesson.""]** — Mówca: **Player**
> ""Yes. This will teach everyone a lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Can you do it?""]** — Mówca: **Player**
> ""Can you do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Karl Greiser**
> ""If that's the order, sir, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Karl Greiser**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Karl Greiser**
> ""Are you giving me full approval on this, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Yes. Make sure it's done.""]** — Mówca: **Player**
> ""Yes. Make sure it's done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""No. I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""No. I've changed my mind. Maybe we shouldn't be so reckless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Karl Greiser**
> ""I understand, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Karl Greiser**
> ""As you wish, sir. I'll execute the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_SecretState_ThreatenCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_SecretState_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[160]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""Sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""It is really irresponsible of them to invite people to protest on the streets during an emergency. This cannot end well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`
  - -> `[167]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Let's wait it out. If the worst happens the police would take care of it.""]** — Mówca: **Player**
> ""Let's wait it out. If the worst happens the police would take care of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""We should target the journalists that stir up unrest.""]** — Mówca: **Player**
> ""We should target the journalists that stir up unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""It's time to detain Frens Ricter.""]** — Mówca: **Player**
> ""It's time to detain Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""Understood. I will be ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""We'll start investigations against the opposition leaders.""]** — Mówca: **Player**
> ""We'll start investigations against the opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> ""You want them detained?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
> ""Understood. I'll reach out to my connections and make sure nothing about the emergency we do not approve gets published.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Detain journalists who have given support to the opposition.""]** — Mówca: **Player**
> ""Detain journalists who have given support to the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
**[WYBÓR GRACZA: ""No. Just reach out to our connections in media to censor the opposition.""]** — Mówca: **Player**
> ""No. Just reach out to our connections in media to censor the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn07_Emergency_Detained_Journalists = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Journalists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary preparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Emergency_StartInvestigations = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Emergency_StartInvestigations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""Are we really doing this? We still have the intel about him from Orso Hawker too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Petr Vectern**
> ""That's true. He has proven connections to Arcasia and has tried to cover his tracks behind international trips for unknown reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
> ""We can justify his arrest. And the decree will allow us to hold him without trial. Antel Rock awaits him if we go through with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""He will pay. Take him down.""]** — Mówca: **Player**
> ""He will pay. Take him down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Give the order of his arrest.""]** — Mówca: **Player**
> ""Give the order of his arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""I've changed my mind. Maybe we shouldn't be so reckless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
> ""If there's nothing else, let's conclude the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Thank you gentlemen, I'll see you later.""]** — Mówca: **Player**
> ""Thank you gentlemen, I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Before we go... I want to think about some measures again.""]** — Mówca: **Player**
> ""Before we go... I want to think about some measures again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
> ""Yes, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[164]`
  - -> `[167]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Never mind. Let's just focus the task at hand.""]** — Mówca: **Player**
> ""Never mind. Let's just focus the task at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""Have a good day, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Petr Vectern**
> ""See you later Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "They left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> ""If there's nothing else, let's conclude the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "They readied themselves before the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Understood. I will be ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Return)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: ChangedMind)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Return])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [ChangedMind])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
> ""As you wish, sir. I'll make the necessary calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Petr Vectern**
> ""This is a big move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn07_Emergency_Detained_Frens = true;
BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] = true;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FrensRicter_Detained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Extending the decree and cooperating with the Old Guard has put me in a very fragile spot, which felt like it could backfire at any moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[213]`
Mówca: **Narrator**
> "Cooperating with the Old Guard, even for a short time, has put me in a very fragile spot, which felt like it could backfire at any moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Petr Vectern**
> ""So... You expect an actual trial against you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[16]`
  - -> `[15]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Petr Vectern**
> ""I can't believe this... You did what they asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Petr Vectern**
> ""It's absurd that they did not protest when you declared the emergency and now they're reviewing a past case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Petr Vectern**
> ""We can't face a negative outcome from the supreme Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Petr Vectern**
> ""Well... I don't know. The emergency was not very popular before and that fed into the rise of the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Petr Vectern**
> ""If the Court decides to side with the opposition for once... You may lose support from everyone. Including the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Petr Vectern**
> ""How about the Bludish issue? The emergency did not really help with the situation in Bergia. It has become even more volatile. The Aschraf anniversary will happen later this year; who knows how that will unfold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""I'm afraid we also contributed to the radicalization of the malenyevists on our soil...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[41]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[240]`
Mówca: **Petr Vectern**
> ""I'm afraid we also contributed to the radicalization of the Sordish nationalists...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[41]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Lucian Galade**
> ""Now we can start thinking about what to do next and how to get out of this hole we put ourselves in. The opposition gained a lot of popularity throughout this process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""I'll arrange a cabinet meeting to address all the issues and our next steps as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Great. You have my trust, Lucian.""]** — Mówca: **Player**
> ""Great. You have my trust, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""The quicker we get together, the better.""]** — Mówca: **Player**
> ""The quicker we get together, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""I believe the concerns are overexaggerated.""]** — Mówca: **Player**
> ""I believe the concerns are overexaggerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
> ""With all due respect, I disagree sir. The main demand of the people were to pursue constitutional reforms. Not only we did not follow through with that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
> ""...We ended up making powerful enemies. Now if the Supreme Court wants us gone, they could potentially do that very easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "He fixed his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
> ""They declared the Emergency decree illegal and agreed with every complaint of Mr. Ricter regarding your actions being unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Let's finish the meeting here. I'll make a short phone call.""]** — Mówca: **Player**
> ""Let's finish the meeting here. I'll make a short phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[356]`

### Węzeł `[260]`
Mówca: **Livia Suno**
> ""Good day to you, Mr. President. Am I interrupting anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[262]`
  - -> `[261]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It's okay, Livia. What happened?""]** — Mówca: **Player**
> ""It's okay, Livia. What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Yes, you are. What is it?""]** — Mówca: **Player**
> ""Yes, you are. What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""No. Please come in. Is there a problem?""]** — Mówca: **Player**
> ""No. Please come in. Is there a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Thanks, Livia. You may go now.""]** — Mówca: **Player**
> ""Thanks, Livia. You may go now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Damn Orso...""]** — Mówca: **Player**
> ""Damn Orso...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Yeah. A picture of Tarquin Soll. What a nice present!""]** — Mówca: **Player**
> ""Yeah. A picture of Tarquin Soll. What a nice present!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Petr Vectern**
> ""Victory will be close, huh? Orso's getting ahead of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[268]`
Mówca: **Petr Vectern**
> ""Hi, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[269]`
Mówca: **Narrator**
> "She walked up and gave it to me. I immediately started to remove the wrapping to reveal a framed photograph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""This must be some kind of a message.""]** — Mówca: **Player**
> ""This must be some kind of a message.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[271]`
Mówca: **Livia Suno**
> ""The Chief Justice has sent you this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "She showed me the wrapped object."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[274]`
  - -> `[273]`

### Węzeł `[273]`
**[WYBÓR GRACZA: ""Thank you, Livia. You can leave it on my table.""]** — Mówca: **Player**
> ""Thank you, Livia. You can leave it on my table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Really? From Orso Hawker? Bring it here.""]** — Mówca: **Player**
> ""Really? From Orso Hawker? Bring it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""What is it?""]** — Mówca: **Player**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[276]`
Mówca: **Narrator**
> "Noticing Petr on the couch, Livia reddened slightly. She gave a small wave, which Petr returned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Livia turned to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[278]`
Mówca: **Livia Suno**
> ""No, but he's obviously trying to send you a message. I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[279]`
Mówca: **Livia Suno**
> ""He's obviously trying to send you a message, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[280]`
**[WYBÓR GRACZA: ""What do you think?""]** — Mówca: **Player**
> ""What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""Oh... A nice present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[265]`
  - -> `[266]`
  - -> `[280]`

### Węzeł `[282]`
Mówca: **Livia Suno**
> ""I don't know... A picture?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Livia Suno**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[284]`
Mówca: **Livia Suno**
> ""I'll just bring it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""Did Orso say anything to you about this?""]** — Mówca: **Player**
> ""Did Orso say anything to you about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[286]`
Mówca: **Narrator**
> "As soon as she left the room, Petr came right next to me and took a look at the photograph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[287]`
Mówca: **Livia Suno**
> ""Mr. Vice President. I'll be leaving now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[288]`
Mówca: **Narrator**
> "I turned to Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[285]`
  - -> `[264]`

### Węzeł `[289]`
Mówca: **Narrator**
> "It was an old black and white photograph of Tarquin Soll posing on a destroyed tank at the Holsord Square. The building behind him had thousands of bullet holes on it. To the side a clearly readable slogan 'Victory is close' written on its walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""What do you think this means, Livia?""]** — Mówca: **Player**
> ""What do you think this means, Livia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[291]`
Mówca: **Narrator**
> "The date, 14 March 1929 was written on the corner with a black marker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_Autocrat_CourtDecision = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_Autocrat_CourtDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Policy_Law_Decree_Stronger = false; BaseGame.Policy_Law_Decree_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_Invalid = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_Invalid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[295]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_Illegal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_Illegal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_OppositionJournalists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_OppositionInvestigations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_DetainFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_CourtDecision_KillOrso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[302]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCongratulatesCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[310]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_CelebratingRevocation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[311]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Revoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtAgainstEmergency_Extended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_CourtForEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_CourtForEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[320]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_PFJPCondemnsCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[321]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_CourtForEmergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_CourtForEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_CourtAgainstEmergency_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = false;
BaseGame.Reform_EmergencyDecree_PoliceAuthority = false;
BaseGame.Reform_EmergencyDecree_SuspendedProtests = false;
BaseGame.Reform_Law_Decrees_Stronger = false;
BaseGame.Reform_Law_Decrees_Default = true;
BaseGame.Policy_Law_Decree_Stronger = false;
BaseGame.Policy_Law_Decree_Default = true;
BaseGame.Policy_Law_EmergencyDecree = false;
BaseGame.Policy_Order_Authority = false;
BaseGame.Policy_Order_SuspendedProtests = false;
BaseGame.Policy_Order_DetentionWithoutTrial = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] = false;
Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] = false;
Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_Decree_Default"] = true;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Order_Authority"] = false;
Variable["BaseGame.Policy_Order_SuspendedProtests"] = false;
Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_IncreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_DecreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[344]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default = true; BaseGame.Policy_Law_Decree_Stronger = false; BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Policy_Law_EmergencyDecree = false; BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial = false; BaseGame.Reform_EmergencyDecree_PoliceAuthority = false; BaseGame.Reform_EmergencyDecree_SuspendedProtests = false; BaseGame.Policy_Order_DetentionWithoutTrial = false; BaseGame.Policy_Order_Authority = false; BaseGame.Policy_Order_SuspendedProtests = false; BaseGame.Reform_Law_Decrees_Stronger = false;
BaseGame.Reform_Law_Decrees_Default = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_Decree_Default"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = false;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Policy_Law_EmergencyDecree"] = false;
Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] = false;
Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] = false;
Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] = false;
Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = false;
Variable["BaseGame.Policy_Order_Authority"] = false;
Variable["BaseGame.Policy_Order_SuspendedProtests"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Reform_Law_Decrees_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Autocrat_YoungSords_NFP_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Orso will pay. I'll involve... a group of *fixers.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Lucian Galade**
> ""Sir? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Narrator**
> "He had a worried face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[352]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's fine, Lucian. I just need to make a phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[353]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[355]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Autocrat_YoungSords_NFP_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[358]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[359]`
**[WYBÓR GRACZA: "Call Remus Holstron."]** — Mówca: **Player_Italic**
> "I took the phone and called Remus Holstron."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Narrator**
> "After a few seconds of ringing, he picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`
  - -> `[363]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is the president speaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hi, Mr. Holstron, it's me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I need you to fix a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Remus Holstron**
> ""Tell me. What is the issue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Remus Holstron**
> ""Oh, Mr. President! How can I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you get rid of Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I need the Court Justices to be taught a lesson. I want them to know their place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Remus Holstron**
> ""I see. They are stepping on your toes. You want them scared off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`
  - -> `[371]`

### Węzeł `[369]`
**[WYBÓR GRACZA: ""Yes. Scare them off by any means necessary. Convince them.""]** — Mówca: **Player**
> ""Yes. Scare them off by any means necessary. Convince them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
**[WYBÓR GRACZA: ""Threaten them, beat them, do whatever you want.""]** — Mówca: **Player**
> ""Threaten them, beat them, do whatever you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
**[WYBÓR GRACZA: ""No. Maybe we can't be so reckless.""]** — Mówca: **Player**
> ""No. Maybe we shouldn't be so reckless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[372]`
Mówca: **Remus Holstron**
> ""I don't know if it will work. But we can try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[374]`
**[WYBÓR GRACZA: ""Teach them a lesson.""]** — Mówca: **Player**
> ""Teach them a lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Remus Holstron**
> ""Do you have anything else in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I've changed my mind. Good day to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[377]`
Mówca: **Remus Holstron**
> ""Sure. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[378]`
Mówca: **Remus Holstron**
> ""I see. He stepped on your toes too. You want him completely *gone*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`

### Węzeł `[379]`
**[WYBÓR GRACZA: ""His time has come.""]** — Mówca: **Player**
> ""His time has come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[380]`
**[WYBÓR GRACZA: ""Yes. This will teach everyone a lesson.""]** — Mówca: **Player**
> ""Yes. This will teach everyone a lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
**[WYBÓR GRACZA: ""Can you do it?""]** — Mówca: **Player**
> ""Can you do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Remus Holstron**
> ""I'll talk to my people. See what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[383]`
**[WYBÓR GRACZA: ""No. I've changed my mind. Maybe we shouldn't be so reckless.""]** — Mówca: **Player**
> ""No. I've changed my mind. Maybe we shouldn't be so reckless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Yes. Make sure it's done.""]** — Mówca: **Player**
> ""Yes. Make sure it's done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[385]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGame.YoungSords_Kill_OrsoHawker = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
Mówca: **Remus Holstron**
> ""Are you giving me full approval on this, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[383]`

### Węzeł `[387]`
Mówca: **Remus Holstron**
> ""I understand. Next time, call me when you are sure about what to ask for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Remus Holstron**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[389]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[390]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_SecretState_ThreatenCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_SecretState_ThreatenCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[391]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[392]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhonePickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhonePickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[393]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("KnockDoor");)*
- **Efekt (`userScript`):** `PlaySoundEffect("KnockDoor");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[394]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
