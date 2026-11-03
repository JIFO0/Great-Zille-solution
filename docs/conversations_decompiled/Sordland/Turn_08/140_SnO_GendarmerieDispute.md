# Sordland/Turn08/SnO_GendarmerieDispute

- **ID konwersacji:** `140`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/140_SnO_GendarmerieDispute.md`
- **Liczba węzłów dialogowych:** 336
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory
- **[38]** Lucian Galade
- **[44]** Lileas Graf
- **[61]** Albin Clavin
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce`
- `BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate`
- `BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.Faction_OldGuard_Destroyed`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.GovernmentBudget`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Stopped_Investigations_NFP`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn05_Personal_Festival_LesteLeft`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Investigate_OldGuard`
- `BaseGame.Turn07_Investigate_Oligarchs`
- `BaseGame.Turn07_Investigate_Opposition`
- `BaseGame.Turn08_SnO_Gendarmerie_Interior`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_DisabilityBenefit`
- `BaseGame.Enable_EstordRaid`
- `BaseGame.LateGameCrisis`
- `BaseGame.Policy_Military_Gendarmerie`
- `BaseGame.Policy_Order_Gendarmerie`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Lileas_Promise_Fulfilled`
- `BaseGame.Situation_Military_DisputeWithInterior`
- `BaseGame.Situation_Military_InternalSecurityJurisdiction`
- `BaseGame.Situation_Military_UnrulyGeneral`
- `BaseGame.Situation_Order_DisputeDefenceMinistry`
- `BaseGame.Situation_Order_MinistryOfInteriorStrengthened`
- `BaseGame.Turn08_SnO_Gendarmerie_Interior`
- `BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie`
- `BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie_Interior`
- `BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontChange`
- `BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interior`
- `BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard`
- `BaseGameSupport.News_Turn08_HP_GendermarieTransferred`
- `BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP`
- `BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_Media`
- `BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_NoMedia`
- `BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Media`
- `BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMedia`
- `BaseGameSupport.Report_Turn08_ACP_Investigated_NFP`
- `BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard`
- `BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs`
- `BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP`
- `BaseGameSupport.Report_Turn08_Community_Police`
- `BaseGameSupport.Report_Turn08_President_Donation_League_Women`
- `BaseGameSupport.Report_Turn08_SSP_Investigated_NFP`
- `BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard`
- `BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs`
- `BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP`
- `GameCondition.Turn08_Bill_DisabilityBenefit`
- `GameCondition.Turn08_SnO_EstordRaid`
- `GameCondition.Turn08_SnO_GendarmerieDispute`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Lileas_Promise_Fulfilled`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[118]` (Iosef Lancea): `Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] = true;`
- Węzeł `[128]` (Iosef Lancea): `Variable["BaseGame.Situation_Military_InternalSecurityJurisdiction"] = false; Variable["BaseGame....`
- Węzeł `[129]` (Iosef Lancea): `Variable["GameCondition.Turn08_SnO_GendarmerieDispute"] = true;`
- Węzeł `[130]` (Iosef Lancea): `Variable["BaseGame.Policy_Military_Gendarmerie"] = false; Variable["BaseGame.Policy_Order_Gendarm...`
- Węzeł `[214]` (Iosef Lancea): `Variable["BaseGame.Enable_DisabilityBenefit"] = true;`
- Węzeł `[215]` (Iosef Lancea): `Variable["GameCondition.Turn08_Bill_DisabilityBenefit"] = true;`
- Węzeł `[219]` (Iosef Lancea): `Variable["BaseGame.Enable_EstordRaid"] = true;`
- Węzeł `[220]` (Iosef Lancea): `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- *...oraz 26 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Iosef Lancea)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Their voices were getting louder and louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Iosef Lancea**
> "“How dare the police meddle in the affairs of the Gendarmerie?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Lileas Graf**
> "“It was *your* men who started this ridiculousness and meddled with an ongoing police investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I opened the doors to the meeting room. The two ministers did not even realise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“Rural security is my jurisdiction and your men were way outside of Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I had seen the reports of a recent issue that rose between the Sordish Police Forces and the Gendarmerie units at the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[9]`
Mówca: **Iosef Lancea**
> "“This is unacceptable!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Slam the table."]** — Mówca: **Player_Italic**
> "I slammed the table which shocked the ministers. They fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Don't worry. We will solve this conflict of interest.”"]** — Mówca: **Player**
> "“Don't worry. We will solve this conflict of interest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“That's enough. Calm down, both of you.”"]** — Mówca: **Player**
> "“That's enough. Calm down, both of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Lileas Graf**
> "“This issue has been in the back of my head for a long time and now it caused real damage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[14]`
Mówca: **Lileas Graf**
> "“I am trying *really* hard to stay calm, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Iosef Lancea**
> "“Ms. Graf, you are pushing your boundaries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[16]`
Mówca: **Narrator**
> "It was not hard to guess what this meeting was going to be about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "We entered the city hall and made our way to the second floor. I could hear Iosef and Lileas's voices echoing through the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Albin, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[19]`
Mówca: **Iosef Lancea**
> "“Apologies, but Ms. Graf here fails to understand her place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Lileas Graf**
> "“No, Mr. Lancea. You are the one who does not understand his place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Lileas Graf**
> "“If you continue to do so, you will pay for it one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[12]`
  - -> `[11]`

### Węzeł `[22]`
Mówca: **Iosef Lancea**
> "“Indeed, it has. All because of the *exemplary* behaviour of your police.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Lileas. Explain what happened.”"]** — Mówca: **Player**
> "“Lileas. Explain what happened.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Iosef. Let's hear your side of the story.”"]** — Mówca: **Player**
> "“Iosef. Let's hear your side of the story.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Iosef Lancea**
> "“The Lieutenant-General of the Gendarmerie was tracking a drug trafficking ring in the countryside of Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[26]`
Mówca: **Iosef Lancea**
> "“As a result, criminals got away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[33]`
  - -> `[48]`

### Węzeł `[27]`
Mówca: **Lileas Graf**
> "“Mr. Greiser was tasked with the investigation of a drug trafficking ring in downtown Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“We found the evidence of a drug stash located in the outskirts of the city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Lileas Graf**
> "“So we immediately sent our police units to catch them and find the drugs in the compound.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“We had to act quickly to put an end to the criminals we have been watching for some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“Mr. Lancea and his Gendarmerie did not notify us that they were also moving against the same target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“As a result, criminals got away and we lost months of progress!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[39]`
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“So, the police meddled and caused the raid to fail.”"]** — Mówca: **Player**
> "“So, the police meddled and caused the raid to fail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Iosef Lancea**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Iosef Lancea**
> "“Now these criminals are free because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Isn't there a line of communication between you?”"]** — Mówca: **Player**
> "“Isn't there a line of communication between you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“The same could be said about you because the reports show that you knew about the gang and their stash in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[38]`
Mówca: **Lileas Graf**
> "“There is, but the Minister of Defense decided to avoid notifying the police department about the planned raid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“So, the Gendarmerie meddled and caused the raid to fail.”"]** — Mówca: **Player**
> "“So, the Gendarmerie meddled and caused the raid to fail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“Now these criminals are free because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“You must have known how dangerous they were and the fact that they carried weapons.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“You went out of your jurisdiction to pursue these criminals.”"]** — Mówca: **Player**
> "“You went out of your jurisdiction to pursue these criminals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“I did nothing of that sort. We followed a gang that was active in the city and the investigation was completely related to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Iosef Lancea**
> "“You should've let us handle it. Gendarmerie is better trained for combat situations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“We immediately acted on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“Just when we were about to raid their hideout with live weapons, the police units arrived in the scene and alerted the criminals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Didn't you rush the situation a little there, Iosef?”"]** — Mówca: **Player**
> "“Didn't you rush the situation a little there, Iosef?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Sir, we received reports that they were heavily armed. We acted to ensure no harm could come to civilians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“You acted too swiftly and without notifying us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“Big words after you allowed them to escape.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[52]`
Mówca: **Lileas Graf**
> "“Big words after you allowed them to escape.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Iosef Lancea**
> "“You must have known how dangerous they were and the fact that they carried weapons.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Iosef Lancea**
> "“You should've let us handle it. Gendarmerie is better trained for combat situations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "I started tapping on the table with my fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“What I hear is that you are both incompetent.”"]** — Mówca: **Player**
> "“What I hear is that you are both incompetent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“How do we solve this issue so that it never happens again?”"]** — Mówca: **Player**
> "“How do we solve this issue so that it never happens again?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We are getting nowhere. We need to find a middle ground.”"]** — Mówca: **Player**
> "“We are getting nowhere. We need to find a middle ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Iosef Lancea**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Both of them started staring at the table without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Lileas finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Lileas Graf**
> "“I think this was the last drop.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Lileas Graf**
> "“Internal security matters should be handed to Ministry of Interior completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Lileas Graf**
> "“We are called the Ministry of *Interior* for a reason. We can't let any more screw ups like this happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“I want the Gendarmerie to be transferred to the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Iosef turned red with anger. He composed himself after a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“Ridiculous! This is absolutely ridiculous. I won't hand over Gendarmerie to her. Out of the question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[78]`
  - -> `[80]`

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“What?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[70]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Why? Because it makes sense?”"]** — Mówca: **Player**
> "“Why? Because it makes sense?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“Besides assisting our internal security, in a time of war the Gendarmerie is a strong asset to defend our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“The police forces have certain units that are capable of conducting similar operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“Because the Gendarmerie is also part of the military structure and must be tied to the Defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“We could work on establishing that but it still doesn't change the wrong system that exists now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I agree. The Gendarmerie has been a part of the Ministry of Defense for years.”"]** — Mówca: **Player**
> "“I agree. The Gendarmerie has been a part of the Ministry of Defense for years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“You already reduced the military budget and dealt a blow to our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Do you have a better solution, Iosef?”"]** — Mówca: **Player**
> "“Do you have a better solution, Iosef?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“The police forces don't have the right equipment and reach to cover rural areas like the Gendarmerie does.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“Whenever operations overlap, we should engage at a lower rank with the local officers on both sides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I can't understand why you are continuing to weaken our military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“I remember it very well. Don't you worry.”"]** — Mówca: **Player**
> "“I remember it very well. Don't you worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“That is relieving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[86]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lileas_GendermariePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Yes, but my decision hasn't been made yet.”"]** — Mówca: **Player**
> "“Yes, but my decision hasn't been made yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[90]`
Mówca: **Lileas Graf**
> "“No matter what we need to eliminate this grey area and modernise our internal security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“I want to remind you about your promise, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[84]`
  - -> `[89]`
  - -> `[92]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“What promise? I don't remember any promises I made.”"]** — Mówca: **Player**
> "“What promise? I don't remember any promises I made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“That was before this screw up.”"]** — Mówca: **Player**
> "“That was before this screw up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Lileas Graf**
> "“I sure hope that you will keep your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“I see. I was a fool to trust that you would keep your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“That is not how promises work, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“Now I see what is going on here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[102]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Nothing is going on.”"]** — Mówca: **Player**
> "“Nothing is going on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“Lileas set us up to create this incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Iosef Lancea**
> "“What promise?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Enlighthen us. What is going on here, Iosef?”"]** — Mówca: **Player**
> "“Enlighthen us. What is going on here, Iosef?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Iosef Lancea**
> "“Now I see what is going on here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Lileas bit her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“There is no way that the police has arrived at the right time of a month long search on the exact day and minute of the Gendarmerie raid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You may be right.”"]** — Mówca: **Player**
> "“You may be right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“This is conspiracy theory territory.”"]** — Mówca: **Player**
> "“This is conspiracy theory territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let us take it down a notch with the accusations.”"]** — Mówca: **Player**
> "“Let us take it down a notch with the accusations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Lileas Graf**
> "“It is very disappointing that you would even entertain the idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Lileas Graf**
> "“It very much is a conspiracy theory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“This kind of an accusation is unheard of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Heed my word, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“It's nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“If I were you, I wouldn't believe a word Mr. Lancea says, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[115]`
Mówca: **Iosef Lancea**
> "“When dealing with these situations, you need to always look at who gets what out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Lileas Graf**
> "“I won't stand idle by these utterly ridiculous and baseless accusations. I don't have time for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“What is your decision?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_Gendarmerie_Interior = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“From now on work together and don't fight among each other. I want capable and effective members of cabinet.”"]** — Mówca: **Player**
> "“From now on work together and don't fight among each other. I want capable and effective members of cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[120]`
Mówca: **Lileas Graf**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“Thank you for protecting the structure and authority of the Ministry of Defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[119]`
  - -> `[124]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“There will be no change related to the Gendarmerie operations.”"]** — Mówca: **Player**
> "“There will be no change related to the Gendarmerie operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“It was the right call to establish a modern internal security structure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[119]`
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“There are bigger issues at hand that need attention. Focus on them instead of each other.”"]** — Mówca: **Player**
> "“There are bigger issues at hand that need attention. Focus on them instead of each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I want those criminals to be caught immediately.”"]** — Mówca: **Player**
> "“I want those criminals to be caught immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Lileas Graf**
> "“We have interrogated the ones caught and are after the others who have escaped.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Lileas Graf**
> "“We will do our best. Right, Mr. Lancea?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_InternalSecurityJurisdiction = false;
BaseGame.Situation_Order_DisputeDefenceMinistry = false;
BaseGame.Situation_Military_DisputeWithInterior = false;
BaseGame.Situation_Order_MinistryOfInteriorStrengthened = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Military_InternalSecurityJurisdiction"] = false;
Variable["BaseGame.Situation_Order_DisputeDefenceMinistry"] = false;
Variable["BaseGame.Situation_Military_DisputeWithInterior"] = false;
Variable["BaseGame.Situation_Order_MinistryOfInteriorStrengthened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[129]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_SnO_GendarmerieDispute = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_SnO_GendarmerieDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[130]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_Gendarmerie = false;
BaseGame.Policy_Order_Gendarmerie = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Military_Gendarmerie"] = false;
Variable["BaseGame.Policy_Order_Gendarmerie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“Don't worry. They will get the justice they deserve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Iosef Lancea**
> "“That's right, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "I left the room to attend to my next scheduled meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“The Gendarmerie will be transferred to the Ministry of Interior.”"]** — Mówca: **Player**
> "“The Gendarmerie will be transferred to the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[135]`
Mówca: **Narrator**
> "The report said that an operation against a drug trafficking gang in Vesord failed due to miscommunication."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[136]`
Mówca: **Iosef Lancea**
> "“Woman, are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[137]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[139]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Gloria, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[147]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Lucian, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[148]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with Petr after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[149]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[151]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[152]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[154]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[155]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[158]`
Mówca: **Albin Clavin**
> "“We are here to help with the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[159]`
Mówca: **Gloria Tory**
> "“Ministers. Please stop your bickering in front of Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> "“Mr. Lancea, Ms. Graf. Please remain calm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Petr Vectern**
> "“Please calm down and let's discuss this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“What is the problem?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[164]`
Mówca: **Gloria Tory**
> "“We will get nowhere if you continue with this behaviour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“Mr. President. Mr. Cla-... Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Mr. President. Ms. To-... Ms. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[168]`
Mówca: **Iosef Lancea**
> "“Mr. President. Mr. Gala-... Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[169]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[171]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[174]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
Mówca: **Gloria Tory**
> "“I have to agree with Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[176]`
Mówca: **Petr Vectern**
> "“Can't these branches just try to improve their communication?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“Looking at it from the perspective of improving our internal security, I agree with Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[178]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[180]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[181]`
Mówca: **Albin Clavin**
> "“To me, what needs to change is not the structure itself but the problems in it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Albin Clavin**
> "“We need to find out what is causing this and fix it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[183]`
Mówca: **Gloria Tory**
> "“If we unify the command, our internal security will improve. There is no question to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Petr Vectern**
> "“Just saying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“We would reap the benefits in the long run.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[186]`
Mówca: **Iosef Lancea**
> "“Look, Ms. Tory. I know you are new at this and there is much that you were not briefed about but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Gloria Tory**
> "“I don't have to be briefed to see common sense, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Gloria Tory**
> "“I would also like to remind you that it is Ms. Vice President to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[189]`
Mówca: **Iosef Lancea**
> "“Look, Mr. Galade. I know you are new at this and there is much that you were not briefed about but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. You are forgetting who I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[191]`
Mówca: **Lileas Graf**
> "“I believe I just told you the fix to the problem, Mr. Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Albin Clavin**
> "“Please address me as Mr. Vice President, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Albin Clavin**
> "“I simply don't think the end justifies the means in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Lileas Graf**
> "“This is not an individual case. This has been happening for a long time in case you did not know, Mr. *Clavin*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[195]`
Mówca: **Lileas Graf**
> "“I believe I just told you the fix to the problem, Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Petr Vectern**
> "“Well, but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Lileas Graf**
> "“With all due respect, there is not other way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[199]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[201]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[202]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[205]`
Mówca: **Albin Clavin**
> "“That is going a bit too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[206]`
Mówca: **Petr Vectern**
> "“That is going a bit too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[207]`
Mówca: **Gloria Tory**
> "“That is going too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[208]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Lucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[210]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[211]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Enable_DisabilityBenefit = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_DisabilityBenefit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_Bill_DisabilityBenefit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_Bill_DisabilityBenefit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  or  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true)  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  or  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true)  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Enable_EstordRaid = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[220]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_SnO_EstordRaid = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[221]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lileas_GendermariePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[224]`
Mówca: **Lileas Graf**
> "“Thank you for being a man of your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[225]`
Mówca: **Lileas Graf**
> "“Disappointing. Here I thought Anton Rayne was a man of his word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[226]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[228]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lileas_GendermariePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[229]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_Promise_Fulfilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lileas_Promise_Fulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[230]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interior = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interior"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontChange = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[232]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[235]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[236]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_Gendarmerie_Interior == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_Gendarmerie_Interior == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_Gendarmerie_Interior == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[239]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_GendermarieTransferred = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_GendermarieTransferred"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[240]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[243]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[245]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[246]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[249]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[250]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[251]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[252]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[254]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_OldGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[255]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[256]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaCensored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaCensored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[260]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[261]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = true; BaseGameSupport.Report_Turn08_ACP_Investigated_NFP = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP"] = true;
Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[262]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[263]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[264]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[266]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[267]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[269]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_OldGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[270]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[324]`

### Węzeł `[272]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[273]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = true; BaseGameSupport.Report_Turn08_SSP_Investigated_NFP = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP"] = true;
Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[274]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[275]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[276]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[279]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Community_Police = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Community_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[280]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate"] == true  and  (Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate"] == true  and  (Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[283]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_President_Donation_League_Women = true; 
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_President_Donation_League_Women"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[284]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_DisputeWithInterior = false;
BaseGame.Situation_Order_DisputeDefenceMinistry = false;
BaseGame.Situation_Military_UnrulyGeneral = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Military_DisputeWithInterior"] = false;
Variable["BaseGame.Situation_Order_DisputeDefenceMinistry"] = false;
Variable["BaseGame.Situation_Military_UnrulyGeneral"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[285]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[287]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[290]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[291]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie = false; BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie_Interior = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie_Interior"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[292]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[295]`
Mówca: **Iosef Lancea**
> "“If you don't believe my word, believe this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Iosef Lancea**
> "“If you decide to transfer the Gendarmerie and weaken our military further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Iosef Lancea**
> "“I will not be responsible for what happens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Lileas Graf**
> "“Your threats will get you nowhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[299]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[302]`
Mówca: **Narrator**
> "Iosef stood up and leaned forward. His eyes darkened and spoke softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Iosef Lancea**
> "“Mr. Rayne...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“I am openly warning you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> "“Listen to what I am telling you. It is for your own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[306]`
Mówca: **Iosef Lancea**
> "“Don't do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[307]`
**[WYBÓR GRACZA: "“Enough! I will not be threatened. I have already given my decision.”"]** — Mówca: **Player**
> "“Enough! I will not be threatened. I have already given my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
**[WYBÓR GRACZA: "“Now that I think about it again... you are right, Iosef.”"]** — Mówca: **Player**
> "“Now that I think about it again... you are right, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Iosef Lancea**
> "“I did all I could, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[311]`
Mówca: **Iosef Lancea**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[312]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_UnrulyGeneral = true;
BaseGame.LateGameCrisis += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Military_UnrulyGeneral"] = true;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[313]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_President_Donation_League_Women = true; 
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_President_Donation_League_Women"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[314]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[316]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[317]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Stopped_Investigations_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[320]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[321]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[323]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Stopped_Investigations_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[324]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Stopped_Investigations_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[327]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[328]`
Mówca: **Lileas Graf**
> ""This isn't new. How about Bergia, Mr. Lancea? Let me remind you. I've been tasked with eliminating the BFF -- and thanks to your men -- we have already slipped a BFF leader from our grasp before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[329]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[331]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[332]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[333]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[335]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
