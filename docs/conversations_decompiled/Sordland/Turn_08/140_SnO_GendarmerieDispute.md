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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"Slam the table."** | `[21]` **Lileas Graf**: "“If you continue to do so, you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“Lileas. Explain what happened.”"<br>`[24]` **Player**: "“Iosef. Let's hear your side of ..." |
| `[11]` | **"“Don't worry. We will solve this conflict of interest.”"** | `[21]` **Lileas Graf**: "“If you continue to do so, you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Lileas Graf**: "“This issue has been in the back..." |
| `[12]` | **"“That's enough. Calm down, both of you.”"** | `[21]` **Lileas Graf**: "“If you continue to do so, you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lileas Graf**: "“I am trying *really* hard to st..." |
| `[23]` | **"“Lileas. Explain what happened.”"** | `[10]` **Player_Italic**: "I slammed the table which shocke..."<br>`[15]` **Iosef Lancea**: "“Ms. Graf, you are pushing your ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lileas Graf**: "“Mr. Greiser was tasked with the..." |
| `[24]` | **"“Iosef. Let's hear your side of the story.”"** | `[10]` **Player_Italic**: "I slammed the table which shocke..."<br>`[15]` **Iosef Lancea**: "“Ms. Graf, you are pushing your ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Iosef Lancea**: "“The Lieutenant-General of the G..." |
| `[33]` | **"“So, the police meddled and caused the raid to fail.”"** | `[26]` **Iosef Lancea**: "“As a result, criminals got away.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Iosef Lancea**: "“Exactly!”" |
| `[36]` | **"“Isn't there a line of communication between you?”"** | `[26]` **Iosef Lancea**: "“As a result, criminals got away.”"<br>`[32]` **Lileas Graf**: "“As a result, criminals got away..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Lileas Graf**: "“There is, but the Minister of D..." |
| `[39]` | **"“So, the Gendarmerie meddled and caused the raid to fail.”"** | `[32]` **Lileas Graf**: "“As a result, criminals got away..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Lileas Graf**: "“Exactly!”" |
| `[43]` | **"“You went out of your jurisdiction to pursue these criminals.”"** | `[32]` **Lileas Graf**: "“As a result, criminals got away..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: "“I did nothing of that sort. We ..." |
| `[48]` | **"“Didn't you rush the situation a little there, Iosef?”"** | `[26]` **Iosef Lancea**: "“As a result, criminals got away.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Iosef Lancea**: "“Sir, we received reports that t..." |
| `[56]` | **"“What I hear is that you are both incompetent.”"** | `[55]` **Narrator**: "I started tapping on the table w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Iosef Lancea**: "“Sir.”" |
| `[57]` | **"“How do we solve this issue so that it never happens again?”"** | `[55]` **Narrator**: "I started tapping on the table w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Lileas Graf**: "“I think this was the last drop.”" |
| `[58]` | **"“We are getting nowhere. We need to find a middle ground.”"** | `[55]` **Narrator**: "I started tapping on the table w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Lileas Graf**: "“I think this was the last drop.”" |
| `[73]` | **"“Why? Because it makes sense?”"** | `[68]` **Iosef Lancea**: "“Ridiculous! This is absolutely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Iosef Lancea**: "“You already reduced the militar..."<br>`[76]` **Iosef Lancea**: "“Because the Gendarmerie is also..." |
| `[78]` | **"“I agree. The Gendarmerie has been a part of the Ministry of Defense for years.”"** | `[68]` **Iosef Lancea**: "“Ridiculous! This is absolutely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Iosef Lancea**: "“Besides assisting our internal ..." |
| `[80]` | **"“Do you have a better solution, Iosef?”"** | `[68]` **Iosef Lancea**: "“Ridiculous! This is absolutely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Iosef Lancea**: "“Whenever operations overlap, we..." |
| `[84]` | **"“I remember it very well. Don't you worry.”"** | `[91]` **Lileas Graf**: "“I want to remind you about your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lileas Graf**: "“That is relieving.”" |
| `[89]` | **"“Yes, but my decision hasn't been made yet.”"** | `[91]` **Lileas Graf**: "“I want to remind you about your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Lileas Graf**: "“I sure hope that you will keep ..." |
| `[92]` | **"“What promise? I don't remember any promises I made.”"** | `[91]` **Lileas Graf**: "“I want to remind you about your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lileas Graf**: "“I see. I was a fool to trust th..." |
| `[93]` | **"“That was before this screw up.”"** | `[91]` **Lileas Graf**: "“I want to remind you about your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lileas Graf**: "“That is not how promises work, ..." |
| `[98]` | **"“What do you mean?”"** | `[97]` **Iosef Lancea**: "“Now I see what is going on here.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Iosef Lancea**: "“Lileas set us up to create this..." |
| `[99]` | **"“Nothing is going on.”"** | `[97]` **Iosef Lancea**: "“Now I see what is going on here.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Iosef Lancea**: "“Lileas set us up to create this..." |
| `[102]` | **"“Enlighthen us. What is going on here, Iosef?”"** | `[97]` **Iosef Lancea**: "“Now I see what is going on here.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Iosef Lancea**: "“Lileas set us up to create this..." |
| `[106]` | **"“You may be right.”"** | `[105]` **Iosef Lancea**: "“There is no way that the police..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lileas Graf**: "“It is very disappointing that y..." |
| `[107]` | **"“This is conspiracy theory territory.”"** | `[105]` **Iosef Lancea**: "“There is no way that the police..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lileas Graf**: "“It very much is a conspiracy th..." |
| `[108]` | **"“Let us take it down a notch with the accusations.”"** | `[105]` **Iosef Lancea**: "“There is no way that the police..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Lileas Graf**: "“This kind of an accusation is u..." |
| `[119]` | **"“From now on work together and don't fight among each other. I want capable and ef..."** | `[121]` **Iosef Lancea**: "“Thank you for protecting the st..."<br>`[123]` **Lileas Graf**: "“It was the right call to establ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Lileas Graf**: "“We will do our best. Right, Mr...." |
| `[122]` | **"“There will be no change related to the Gendarmerie operations.”"** | `[117]` **Lileas Graf**: "“What is your decision?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Military_DisputeWithInterior...`<br>`Variable["BaseGameSupport.Journal_Turn08_GendarmerieDispu...` | `[120]` **Lileas Graf**: "“You are making a mistake.”" |
| `[124]` | **"“There are bigger issues at hand that need attention. Focus on them instead of eac..."** | `[121]` **Iosef Lancea**: "“Thank you for protecting the st..."<br>`[123]` **Lileas Graf**: "“It was the right call to establ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Lileas Graf**: "“We will do our best. Right, Mr...." |
| `[125]` | **"“I want those criminals to be caught immediately.”"** | `[121]` **Iosef Lancea**: "“Thank you for protecting the st..."<br>`[123]` **Lileas Graf**: "“It was the right call to establ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Lileas Graf**: "“We have interrogated the ones c..." |
| `[134]` | **"“The Gendarmerie will be transferred to the Ministry of Interior.”"** | `[117]` **Lileas Graf**: "“What is your decision?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Narrator**: "Iosef stood up and leaned forwar..."<br>`[311]` **Iosef Lancea**: "“You are making a mistake.”" |
| `[307]` | **"“Enough! I will not be threatened. I have already given my decision.”"** | `[305]` **Iosef Lancea**: "“Listen to what I am telling you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Iosef Lancea**: "“I did all I could, Mr. President.”" |
| `[308]` | **"“Now that I think about it again... you are right, Iosef.”"** | `[305]` **Iosef Lancea**: "“Listen to what I am telling you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Iosef Lancea**: "“Thank you, Mr. President.”" |

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
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Their voices were getting louder and louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Iosef Lancea: "“Rural security is my jurisdiction and your men were way ..."*)

### Węzeł `[4]`
Mówca: **Iosef Lancea**
> "“How dare the police meddle in the affairs of the Gendarmerie?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lileas Graf: "“It was *your* men who started this ridiculousness and me..."*)

### Węzeł `[5]`
Mówca: **Lileas Graf**
> "“It was *your* men who started this ridiculousness and meddled with an ongoing police investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Their voices were getting louder and louder."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I opened the doors to the meeting room. The two ministers did not even realise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Iosef Lancea: "“This is unacceptable!”"*)

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“Rural security is my jurisdiction and your men were way outside of Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I had seen the reports of a recent issue that rose between the Sordish Police Forces and the Gendarmerie units at the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The report said that an operation against a drug traffick..."*)

### Węzeł `[9]`
Mówca: **Iosef Lancea**
> "“This is unacceptable!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Iosef Lancea: "“How dare the police meddle in the affairs of the Gendarm..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Slam the table."]** — Mówca: **Player_Italic**
> "I slammed the table which shocked the ministers. They fell silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Lileas. Explain what happened.”"*)
  - -> `[24]` (*Player: "“Iosef. Let's hear your side of the story.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Don't worry. We will solve this conflict of interest.”"]** — Mówca: **Player**
> "“Don't worry. We will solve this conflict of interest.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lileas Graf: "“This issue has been in the back of my head for a long ti..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“That's enough. Calm down, both of you.”"]** — Mówca: **Player**
> "“That's enough. Calm down, both of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lileas Graf: "“I am trying *really* hard to stay calm, Mr. President.”"*)

### Węzeł `[13]`
Mówca: **Lileas Graf**
> "“This issue has been in the back of my head for a long time and now it caused real damage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Iosef Lancea: "“Indeed, it has. All because of the *exemplary* behaviour..."*)

### Węzeł `[14]`
Mówca: **Lileas Graf**
> "“I am trying *really* hard to stay calm, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Iosef Lancea: "“Ms. Graf, you are pushing your boundaries.”"*)

### Węzeł `[15]`
Mówca: **Iosef Lancea**
> "“Ms. Graf, you are pushing your boundaries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Lileas. Explain what happened.”"*)
  - -> `[24]` (*Player: "“Iosef. Let's hear your side of the story.”"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "It was not hard to guess what this meeting was going to be about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "We entered the city hall and made our way to the second f..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "We entered the city hall and made our way to the second floor. I could hear Iosef and Lileas's voices echoing through the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I opened the doors to the meeting room. The two ministers..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Albin, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I had seen the reports of a recent issue that rose betwee..."*)

### Węzeł `[19]`
Mówca: **Iosef Lancea**
> "“Apologies, but Ms. Graf here fails to understand her place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lileas Graf: "“No, Mr. Lancea. You are the one who does not understand ..."*)

### Węzeł `[20]`
Mówca: **Lileas Graf**
> "“No, Mr. Lancea. You are the one who does not understand his place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lileas Graf: "“If you continue to do so, you will pay for it one day.”"*)

### Węzeł `[21]`
Mówca: **Lileas Graf**
> "“If you continue to do so, you will pay for it one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Italic: "Slam the table."*)
  - -> `[12]` (*Player: "“That's enough. Calm down, both of you.”"*)
  - -> `[11]` (*Player: "“Don't worry. We will solve this conflict of interest.”"*)

### Węzeł `[22]`
Mówca: **Iosef Lancea**
> "“Indeed, it has. All because of the *exemplary* behaviour of your police.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Lileas. Explain what happened.”"*)
  - -> `[24]` (*Player: "“Iosef. Let's hear your side of the story.”"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Lileas. Explain what happened.”"]** — Mówca: **Player**
> "“Lileas. Explain what happened.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Italic), `[15]` (Iosef Lancea), `[22]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lileas Graf: "“Mr. Greiser was tasked with the investigation of a drug ..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Iosef. Let's hear your side of the story.”"]** — Mówca: **Player**
> "“Iosef. Let's hear your side of the story.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Italic), `[15]` (Iosef Lancea), `[22]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Iosef Lancea: "“The Lieutenant-General of the Gendarmerie was tracking a..."*)

### Węzeł `[25]`
Mówca: **Iosef Lancea**
> "“The Lieutenant-General of the Gendarmerie was tracking a drug trafficking ring in the countryside of Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: "“We immediately acted on it.”"*)

### Węzeł `[26]`
Mówca: **Iosef Lancea**
> "“As a result, criminals got away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“Isn't there a line of communication between you?”"*)
  - -> `[33]` (*Player: "“So, the police meddled and caused the raid to fail.”"*)
  - -> `[48]` (*Player: "“Didn't you rush the situation a little there, Iosef?”"*)

### Węzeł `[27]`
Mówca: **Lileas Graf**
> "“Mr. Greiser was tasked with the investigation of a drug trafficking ring in downtown Vesord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lileas Graf: "“We found the evidence of a drug stash located in the out..."*)

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“We found the evidence of a drug stash located in the outskirts of the city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lileas Graf: "“We had to act quickly to put an end to the criminals we ..."*)

### Węzeł `[29]`
Mówca: **Lileas Graf**
> "“So we immediately sent our police units to catch them and find the drugs in the compound.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: "“Mr. Lancea and his Gendarmerie did not notify us that th..."*)

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“We had to act quickly to put an end to the criminals we have been watching for some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lileas Graf: "“So we immediately sent our police units to catch them an..."*)

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“Mr. Lancea and his Gendarmerie did not notify us that they were also moving against the same target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lileas Graf: "“As a result, criminals got away and we lost months of pr..."*)

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“As a result, criminals got away and we lost months of progress!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“You went out of your jurisdiction to pursue these crimin..."*)
  - -> `[39]` (*Player: "“So, the Gendarmerie meddled and caused the raid to fail.”"*)
  - -> `[36]` (*Player: "“Isn't there a line of communication between you?”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“So, the police meddled and caused the raid to fail.”"]** — Mówca: **Player**
> "“So, the police meddled and caused the raid to fail.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Iosef Lancea: "“Exactly!”"*)

### Węzeł `[34]`
Mówca: **Iosef Lancea**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Iosef Lancea: "“Now these criminals are free because of it.”"*)

### Węzeł `[35]`
Mówca: **Iosef Lancea**
> "“Now these criminals are free because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lileas Graf: "“Big words after you allowed them to escape.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Isn't there a line of communication between you?”"]** — Mówca: **Player**
> "“Isn't there a line of communication between you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Iosef Lancea), `[32]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lileas Graf: "“There is, but the Minister of Defense decided to avoid n..."*)

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“The same could be said about you because the reports show that you knew about the gang and their stash in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I started tapping on the table with my fingers."*)

### Węzeł `[38]`
Mówca: **Lileas Graf**
> "“There is, but the Minister of Defense decided to avoid notifying the police department about the planned raid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Iosef Lancea: "“The same could be said about you because the reports sho..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“So, the Gendarmerie meddled and caused the raid to fail.”"]** — Mówca: **Player**
> "“So, the Gendarmerie meddled and caused the raid to fail.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lileas Graf: "“Exactly!”"*)

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lileas Graf: "“Now these criminals are free because of it.”"*)

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“Now these criminals are free because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Iosef Lancea: "“Big words after you allowed them to escape.”"*)

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“You must have known how dangerous they were and the fact that they carried weapons.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Iosef Lancea: "“You should've let us handle it. Gendarmerie is better tr..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“You went out of your jurisdiction to pursue these criminals.”"]** — Mówca: **Player**
> "“You went out of your jurisdiction to pursue these criminals.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“I did nothing of that sort. We followed a gang that was ..."*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“I did nothing of that sort. We followed a gang that was active in the city and the investigation was completely related to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Iosef Lancea: "“You must have known how dangerous they were and the fact..."*)

### Węzeł `[45]`
Mówca: **Iosef Lancea**
> "“You should've let us handle it. Gendarmerie is better trained for combat situations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I started tapping on the table with my fingers."*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“We immediately acted on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“Just when we were about to raid their hideout with live ..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“Just when we were about to raid their hideout with live weapons, the police units arrived in the scene and alerted the criminals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Iosef Lancea: "“As a result, criminals got away.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Didn't you rush the situation a little there, Iosef?”"]** — Mówca: **Player**
> "“Didn't you rush the situation a little there, Iosef?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Iosef Lancea: "“Sir, we received reports that they were heavily armed. W..."*)

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Sir, we received reports that they were heavily armed. We acted to ensure no harm could come to civilians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“You acted too swiftly and without notifying us.”"*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“You acted too swiftly and without notifying us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Iosef Lancea: "“You must have known how dangerous they were and the fact..."*)

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“Big words after you allowed them to escape.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I started tapping on the table with my fingers."*)

### Węzeł `[52]`
Mówca: **Lileas Graf**
> "“Big words after you allowed them to escape.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I started tapping on the table with my fingers."*)

### Węzeł `[53]`
Mówca: **Iosef Lancea**
> "“You must have known how dangerous they were and the fact that they carried weapons.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Iosef Lancea: "“You should've let us handle it. Gendarmerie is better tr..."*)

### Węzeł `[54]`
Mówca: **Iosef Lancea**
> "“You should've let us handle it. Gendarmerie is better trained for combat situations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I started tapping on the table with my fingers."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "I started tapping on the table with my fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“How do we solve this issue so that it never happens again?”"*)
  - -> `[56]` (*Player: "“What I hear is that you are both incompetent.”"*)
  - -> `[58]` (*Player: "“We are getting nowhere. We need to find a middle ground.”"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“What I hear is that you are both incompetent.”"]** — Mówca: **Player**
> "“What I hear is that you are both incompetent.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Iosef Lancea: "“Sir.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“How do we solve this issue so that it never happens again?”"]** — Mówca: **Player**
> "“How do we solve this issue so that it never happens again?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lileas Graf: "“I think this was the last drop.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We are getting nowhere. We need to find a middle ground.”"]** — Mówca: **Player**
> "“We are getting nowhere. We need to find a middle ground.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lileas Graf: "“I think this was the last drop.”"*)

### Węzeł `[59]`
Mówca: **Iosef Lancea**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Both of them started staring at the table without saying ..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Both of them started staring at the table without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Lileas finally spoke up."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Lileas finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lileas Graf: "“I think this was the last drop.”"*)

### Węzeł `[62]`
Mówca: **Lileas Graf**
> "“I think this was the last drop.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lileas Graf: "“Internal security matters should be handed to Ministry o..."*)

### Węzeł `[63]`
Mówca: **Lileas Graf**
> "“Internal security matters should be handed to Ministry of Interior completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lileas Graf: "“We are called the Ministry of *Interior* for a reason. W..."*)

### Węzeł `[64]`
Mówca: **Lileas Graf**
> "“We are called the Ministry of *Interior* for a reason. We can't let any more screw ups like this happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She looked at me."*)

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“I want the Gendarmerie to be transferred to the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Iosef Lancea: "“What?”"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lileas Graf: "“I want the Gendarmerie to be transferred to the Ministry..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Iosef turned red with anger. He composed himself after a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“Ridiculous! This is absolutely ridiculous. I won't hand over Gendarmerie to her. Out of the question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“Why? Because it makes sense?”"*)
  - -> `[78]` (*Player: "“I agree. The Gendarmerie has been a part of the Ministry..."*)
  - -> `[80]` (*Player: "“Do you have a better solution, Iosef?”"*)

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“What?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Iosef Lancea: "“Woman, are you out of your mind?”"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“You already reduced the military budget and dealt a blow..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Iosef Lancea: "“Because the Gendarmerie is also part of the military str..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Why? Because it makes sense?”"]** — Mówca: **Player**
> "“Why? Because it makes sense?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“Besides assisting our internal security, in a time of war the Gendarmerie is a strong asset to defend our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“The police forces have certain units that are capable of conducting similar operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“Because the Gendarmerie is also part of the military structure and must be tied to the Defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Iosef Lancea: "“The police forces don't have the right equipment and rea..."*)

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“We could work on establishing that but it still doesn't change the wrong system that exists now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I agree. The Gendarmerie has been a part of the Ministry of Defense for years.”"]** — Mówca: **Player**
> "“I agree. The Gendarmerie has been a part of the Ministry of Defense for years.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Iosef Lancea: "“Besides assisting our internal security, in a time of wa..."*)

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“You already reduced the military budget and dealt a blow to our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“I can't understand why you are continuing to weaken our ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Do you have a better solution, Iosef?”"]** — Mówca: **Player**
> "“Do you have a better solution, Iosef?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Iosef Lancea: "“Whenever operations overlap, we should engage at a lower..."*)

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“The police forces don't have the right equipment and reach to cover rural areas like the Gendarmerie does.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“The police forces have certain units that are capable of..."*)

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> "“Whenever operations overlap, we should engage at a lower rank with the local officers on both sides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lileas Graf: "“We could work on establishing that but it still doesn't ..."*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I can't understand why you are continuing to weaken our military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“The police forces have certain units that are capable of..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“I remember it very well. Don't you worry.”"]** — Mówca: **Player**
> "“I remember it very well. Don't you worry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lileas Graf: "“That is relieving.”"*)

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“That is relieving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Iosef Lancea: "“What promise?”"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lileas_GendermariePromise == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lileas Graf: "“I want to remind you about your promise, Mr. President.”"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lileas_GendermariePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lileas Graf: "“No matter what we need to eliminate this grey area and m..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Yes, but my decision hasn't been made yet.”"]** — Mówca: **Player**
> "“Yes, but my decision hasn't been made yet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lileas Graf: "“I sure hope that you will keep your word.”"*)

### Węzeł `[90]`
Mówca: **Lileas Graf**
> "“No matter what we need to eliminate this grey area and modernise our internal security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Iosef Lancea: "“Now I see what is going on here.”"*)

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“I want to remind you about your promise, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“That was before this screw up.”"*)
  - -> `[84]` (*Player: "“I remember it very well. Don't you worry.”"*)
  - -> `[89]` (*Player: "“Yes, but my decision hasn't been made yet.”"*)
  - -> `[92]` (*Player: "“What promise? I don't remember any promises I made.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“What promise? I don't remember any promises I made.”"]** — Mówca: **Player**
> "“What promise? I don't remember any promises I made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lileas Graf: "“I see. I was a fool to trust that you would keep your wo..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“That was before this screw up.”"]** — Mówca: **Player**
> "“That was before this screw up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lileas Graf: "“That is not how promises work, Mr. President.”"*)

### Węzeł `[94]`
Mówca: **Lileas Graf**
> "“I sure hope that you will keep your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Iosef Lancea: "“What promise?”"*)

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“I see. I was a fool to trust that you would keep your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Iosef Lancea: "“What promise?”"*)

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“That is not how promises work, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Iosef Lancea: "“What promise?”"*)

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“Now I see what is going on here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: "“What do you mean?”"*)
  - -> `[99]` (*Player: "“Nothing is going on.”"*)
  - -> `[102]` (*Player: "“Enlighthen us. What is going on here, Iosef?”"*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“Lileas set us up to create this incident.”"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Nothing is going on.”"]** — Mówca: **Player**
> "“Nothing is going on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“Lileas set us up to create this incident.”"*)

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“Lileas set us up to create this incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Lileas bit her lips."*)

### Węzeł `[101]`
Mówca: **Iosef Lancea**
> "“What promise?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Iosef Lancea: "“Now I see what is going on here.”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Enlighthen us. What is going on here, Iosef?”"]** — Mówca: **Player**
> "“Enlighthen us. What is going on here, Iosef?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“Lileas set us up to create this incident.”"*)

### Węzeł `[103]`
Mówca: **Iosef Lancea**
> "“Now I see what is going on here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“Lileas set us up to create this incident.”"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Lileas bit her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“There is no way that the police has arrived at the right time of a month long search on the exact day and minute of the Gendarmerie raid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“You may be right.”"*)
  - -> `[107]` (*Player: "“This is conspiracy theory territory.”"*)
  - -> `[108]` (*Player: "“Let us take it down a notch with the accusations.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“You may be right.”"]** — Mówca: **Player**
> "“You may be right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: "“It is very disappointing that you would even entertain t..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“This is conspiracy theory territory.”"]** — Mówca: **Player**
> "“This is conspiracy theory territory.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lileas Graf: "“It very much is a conspiracy theory.”"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let us take it down a notch with the accusations.”"]** — Mówca: **Player**
> "“Let us take it down a notch with the accusations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: "“This kind of an accusation is unheard of.”"*)

### Węzeł `[109]`
Mówca: **Lileas Graf**
> "“It is very disappointing that you would even entertain the idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: "“This kind of an accusation is unheard of.”"*)

### Węzeł `[110]`
Mówca: **Lileas Graf**
> "“It very much is a conspiracy theory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: "“This kind of an accusation is unheard of.”"*)

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“This kind of an accusation is unheard of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lileas Graf: "“It's nonsense.”"*)

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Heed my word, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Iosef Lancea: "“When dealing with these situations, you need to always l..."*)

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“It's nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“If I were you, I wouldn't believe a word Mr. Lancea says..."*)

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“If I were you, I wouldn't believe a word Mr. Lancea says, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)

### Węzeł `[115]`
Mówca: **Iosef Lancea**
> "“When dealing with these situations, you need to always look at who gets what out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lileas Graf: "“I won't stand idle by these utterly ridiculous and basel..."*)

### Węzeł `[116]`
Mówca: **Lileas Graf**
> "“I won't stand idle by these utterly ridiculous and baseless accusations. I don't have time for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lileas Graf: "“What is your decision?”"*)

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“What is your decision?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "“The Gendarmerie will be transferred to the Ministry of I..."*)
  - -> `[122]` (*Player: "“There will be no change related to the Gendarmerie opera..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_Gendarmerie_Interior = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_Gendarmerie = false; BaseGame.Po..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“From now on work together and don't fight among each other. I want capable and effective members of cabinet.”"]** — Mówca: **Player**
> "“From now on work together and don't fight among each other. I want capable and effective members of cabinet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Iosef Lancea), `[123]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lileas Graf: "“We will do our best. Right, Mr. Lancea?”"*)

### Węzeł `[120]`
Mówca: **Lileas Graf**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“Thank you for protecting the structure and authority of the Ministry of Defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“I want those criminals to be caught immediately.”"*)
  - -> `[119]` (*Player: "“From now on work together and don't fight among each oth..."*)
  - -> `[124]` (*Player: "“There are bigger issues at hand that need attention. Foc..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“There will be no change related to the Gendarmerie operations.”"]** — Mówca: **Player**
> "“There will be no change related to the Gendarmerie operations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_DisputeWithInterior = false; ..."*)

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“It was the right call to establish a modern internal security structure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“I want those criminals to be caught immediately.”"*)
  - -> `[119]` (*Player: "“From now on work together and don't fight among each oth..."*)
  - -> `[124]` (*Player: "“There are bigger issues at hand that need attention. Foc..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“There are bigger issues at hand that need attention. Focus on them instead of each other.”"]** — Mówca: **Player**
> "“There are bigger issues at hand that need attention. Focus on them instead of each other.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Iosef Lancea), `[123]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lileas Graf: "“We will do our best. Right, Mr. Lancea?”"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I want those criminals to be caught immediately.”"]** — Mówca: **Player**
> "“I want those criminals to be caught immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Iosef Lancea), `[123]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lileas Graf: "“We have interrogated the ones caught and are after the o..."*)

### Węzeł `[126]`
Mówca: **Lileas Graf**
> "“We have interrogated the ones caught and are after the others who have escaped.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Iosef Lancea: "“Don't worry. They will get the justice they deserve.”"*)

### Węzeł `[127]`
Mówca: **Lileas Graf**
> "“We will do our best. Right, Mr. Lancea?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Iosef Lancea: "“That's right, Ms. Graf.”"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_InternalSecurityJurisdiction = false;
BaseGame.Situation_Order_DisputeDefenceMinistry = false;
BaseGame.Situation_Military_DisputeWithInterior = false;
BaseGame.Situation_Order_MinistryOfInteriorStrengthened = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_InternalSecurityJurisdiction"] = false;
Variable["BaseGame.Situation_Order_DisputeDefenceMinistry"] = false;
Variable["BaseGame.Situation_Military_DisputeWithInterior"] = false;
Variable["BaseGame.Situation_Order_MinistryOfInteriorStrengthened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interio..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_SnO_GendarmerieDispute = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_SnO_GendarmerieDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Ob..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_Gendarmerie = false;
BaseGame.Policy_Order_Gendarmerie = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Military_Gendarmerie"] = false;
Variable["BaseGame.Policy_Order_Gendarmerie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_InternalSecurityJurisdiction ..."*)

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“Don't worry. They will get the justice they deserve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I left the room to attend to my next scheduled meeting."*)

### Węzeł `[132]`
Mówca: **Iosef Lancea**
> "“That's right, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I left the room to attend to my next scheduled meeting."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "I left the room to attend to my next scheduled meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_GendarmerieDispute = true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“The Gendarmerie will be transferred to the Ministry of Interior.”"]** — Mówca: **Player**
> "“The Gendarmerie will be transferred to the Ministry of Interior.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "The report said that an operation against a drug trafficking gang in Vesord failed due to miscommunication."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was not hard to guess what this meeting was going to b..."*)

### Węzeł `[136]`
Mówca: **Iosef Lancea**
> "“Woman, are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Iosef turned red with anger. He composed himself after a ..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I arrived in the city of Vesord with my new Vice Presiden..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "I arrived in the city of Vesord with my new Vice Presiden..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "I arrived in the city of Vesord with my new Vice Presiden..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I arrived in the city of Vesord with Petr after receiving..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Gloria, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I had seen the reports of a recent issue that rose betwee..."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with my new Vice President, Lucian, after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I had seen the reports of a recent issue that rose betwee..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "I arrived in the city of Vesord with Petr after receiving an emergency meeting request from Iosef and Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I had seen the reports of a recent issue that rose betwee..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: "“Mr. Lancea, Ms. Graf. Please remain calm.”"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Petr Vectern: "“Please calm down and let's discuss this.”"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gloria Tory: "“Ministers. Please stop your bickering in front of Mr. Pr..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Albin Clavin: "“We are here to help with the matter.”"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[158]`
Mówca: **Albin Clavin**
> "“We are here to help with the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Albin Clavin: "“What is going on?”"*)

### Węzeł `[159]`
Mówca: **Gloria Tory**
> "“Ministers. Please stop your bickering in front of Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gloria Tory: "“We will get nowhere if you continue with this behaviour.”"*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> "“Mr. Lancea, Ms. Graf. Please remain calm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucian Galade: "“What is the problem?”"*)

### Węzeł `[161]`
Mówca: **Petr Vectern**
> "“Please calm down and let's discuss this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Petr Vectern: "“What is going on?”"*)

### Węzeł `[162]`
Mówca: **Petr Vectern**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Iosef Lancea: "“Apologies, but Ms. Graf here fails to understand her pla..."*)

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“What is the problem?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Iosef Lancea: "“Mr. President. Mr. Gala-... Mr. Vice President.”"*)

### Węzeł `[164]`
Mówca: **Gloria Tory**
> "“We will get nowhere if you continue with this behaviour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Iosef Lancea: "“Mr. President. Ms. To-... Ms. Vice President.”"*)

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Iosef Lancea: "“Mr. President. Mr. Cla-... Mr. Vice President.”"*)

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“Mr. President. Mr. Cla-... Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Iosef Lancea: "“Apologies, but Ms. Graf here fails to understand her pla..."*)

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Mr. President. Ms. To-... Ms. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Iosef Lancea: "“Apologies, but Ms. Graf here fails to understand her pla..."*)

### Węzeł `[168]`
Mówca: **Iosef Lancea**
> "“Mr. President. Mr. Gala-... Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Iosef Lancea: "“Apologies, but Ms. Graf here fails to understand her pla..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucian Galade: "“Looking at it from the perspective of improving our inte..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Petr Vectern: "“Can't these branches just try to improve their communica..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Albin Clavin: "“To me, what needs to change is not the structure itself ..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[175]`
Mówca: **Gloria Tory**
> "“I have to agree with Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Gloria Tory: "“If we unify the command, our internal security will impr..."*)

### Węzeł `[176]`
Mówca: **Petr Vectern**
> "“Can't these branches just try to improve their communication?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Petr Vectern: "“Just saying.”"*)

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“Looking at it from the perspective of improving our internal security, I agree with Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucian Galade: "“We would reap the benefits in the long run.”"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gloria Tory: "“I have to agree with Ms. Graf.”"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[181]`
Mówca: **Albin Clavin**
> "“To me, what needs to change is not the structure itself but the problems in it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Albin Clavin: "“We need to find out what is causing this and fix it.”"*)

### Węzeł `[182]`
Mówca: **Albin Clavin**
> "“We need to find out what is causing this and fix it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lileas Graf: "“I believe I just told you the fix to the problem, Mr. Cl..."*)

### Węzeł `[183]`
Mówca: **Gloria Tory**
> "“If we unify the command, our internal security will improve. There is no question to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Iosef Lancea: "“Look, Ms. Tory. I know you are new at this and there is ..."*)

### Węzeł `[184]`
Mówca: **Petr Vectern**
> "“Just saying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lileas Graf: "“I believe I just told you the fix to the problem, Mr. Vi..."*)

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“We would reap the benefits in the long run.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Iosef Lancea: "“Look, Mr. Galade. I know you are new at this and there i..."*)

### Węzeł `[186]`
Mówca: **Iosef Lancea**
> "“Look, Ms. Tory. I know you are new at this and there is much that you were not briefed about but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Gloria Tory: "“I don't have to be briefed to see common sense, Mr. Lanc..."*)

### Węzeł `[187]`
Mówca: **Gloria Tory**
> "“I don't have to be briefed to see common sense, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Gloria Tory: "“I would also like to remind you that it is Ms. Vice Pres..."*)

### Węzeł `[188]`
Mówca: **Gloria Tory**
> "“I would also like to remind you that it is Ms. Vice President to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“Ridiculous! This is absolutely ridiculous. I won't hand ..."*)

### Węzeł `[189]`
Mówca: **Iosef Lancea**
> "“Look, Mr. Galade. I know you are new at this and there is much that you were not briefed about but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: "“Mr. Lancea. You are forgetting who I am.”"*)

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“Mr. Lancea. You are forgetting who I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“Ridiculous! This is absolutely ridiculous. I won't hand ..."*)

### Węzeł `[191]`
Mówca: **Lileas Graf**
> "“I believe I just told you the fix to the problem, Mr. Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Albin Clavin: "“Please address me as Mr. Vice President, Ms. Graf.”"*)

### Węzeł `[192]`
Mówca: **Albin Clavin**
> "“Please address me as Mr. Vice President, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Albin Clavin: "“I simply don't think the end justifies the means in this..."*)

### Węzeł `[193]`
Mówca: **Albin Clavin**
> "“I simply don't think the end justifies the means in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lileas Graf: "“This is not an individual case. This has been happening ..."*)

### Węzeł `[194]`
Mówca: **Lileas Graf**
> "“This is not an individual case. This has been happening for a long time in case you did not know, Mr. *Clavin*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“Ridiculous! This is absolutely ridiculous. I won't hand ..."*)

### Węzeł `[195]`
Mówca: **Lileas Graf**
> "“I believe I just told you the fix to the problem, Mr. Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Petr Vectern: "“Well, but-”"*)

### Węzeł `[196]`
Mówca: **Petr Vectern**
> "“Well, but-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lileas Graf: "“With all due respect, there is not other way.”"*)

### Węzeł `[197]`
Mówca: **Lileas Graf**
> "“With all due respect, there is not other way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“Ridiculous! This is absolutely ridiculous. I won't hand ..."*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“There is no way that the police has arrived at the right..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Gloria Tory: "“That is going too far. What proof do you have?”"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Albin Clavin: "“That is going a bit too far. What proof do you have?”"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Gloria == true"*)

### Węzeł `[205]`
Mówca: **Albin Clavin**
> "“That is going a bit too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“There is no way that the police has arrived at the right..."*)

### Węzeł `[206]`
Mówca: **Petr Vectern**
> "“That is going a bit too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“There is no way that the police has arrived at the right..."*)

### Węzeł `[207]`
Mówca: **Gloria Tory**
> "“That is going too far. What proof do you have?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Iosef Lancea: "“There is no way that the police has arrived at the right..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Lucian == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Lucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: "“What proof do you have?”"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Petr Vectern: "“That is going a bit too far. What proof do you have?”"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obs..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_O..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_DisabilityBenefit = true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obstructionist == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_Bill_DisabilityBenefit = true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_DisabilityBenefit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_DisabilityBenefit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Investigate_Oligarchs == true || BaseGam..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_Bill_DisabilityBenefit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_Bill_DisabilityBenefit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Investigate_Oligarchs == true || BaseGam..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Investigate_Oligarchs == true || BaseGam..."*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn07_Investigate_Oligarchs == true || BaseG..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  or  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true)  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_EstordRaid = true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn07_Investigate_Oligarchs == true || BaseGame.Turn07_Detained_MarcelKoronti == true) && BaseGame.Turn07_Fled_MarcelKoronti == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  or  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true)  and  Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_EstordRaid = true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_EstordRaid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_Gendarmerie_Interior == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_SnO_EstordRaid = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_Gendarmerie_Interior == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lileas_GendermariePromise == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lileas Graf: "“Thank you for being a man of your word.”"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lileas_GendermariePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: "“It was the right call to establish a modern internal sec..."*)

### Węzeł `[224]`
Mówca: **Lileas Graf**
> "“Thank you for being a man of your word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_Promise_Fulfilled = true"*)

### Węzeł `[225]`
Mówca: **Lileas Graf**
> "“Disappointing. Here I thought Anton Rayne was a man of his word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Iosef Lancea: "“Thank you for protecting the structure and authority of ..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lileas_GendermariePromise == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lileas Graf: "“Disappointing. Here I thought Anton Rayne was a man of h..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lileas_GendermariePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Iosef Lancea: "“Thank you for protecting the structure and authority of ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_Promise_Fulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lileas_Promise_Fulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: "“It was the right call to establish a modern internal sec..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interior = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_GendarmerieDispute_Interior"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontChange = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lileas Graf: "“You are making a mistake.”"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy = true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_Gendarmerie_Interior == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_Gendarmerie_Interior == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_Gendarmerie_Interior == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_Gendarmerie_Interior == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_GendermarieTransferred = true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_Gendarmerie_Interior == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_Gendarmerie_Interior"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == ..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_GendermarieTransferred = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_GendermarieTransferred"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_Gendarme..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Medi..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_OldGuard == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard =..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_OldGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs ..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Sit..."*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.S..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaCensored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Situation_Law_MediaCensored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Situation_Law_MediaCensored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_ACP_Investigates_Oligarchs_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = true; BaseGameSupport.Report_Turn08_ACP_Investigated_NFP = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP"] = true;
Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_ACP_Investigates_OldGuard ..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true || BaseGame.Sit..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_OldGuard == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard =..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_OldGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs ..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = tru..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = true; BaseGameSupport.Report_Turn08_SSP_Investigated_NFP = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP"] = true;
Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Community_Police = true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Community_Police = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Community_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == ..."*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate =..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate"] == true  and  (Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_President_Donation_League_W..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == true && (BaseGame.Turn05_Personal_Festival_LesteLeft == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true || BaseGame.Reform_Turn08_Decree_WomensRights == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate"] == true  and  (Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true  or  Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHeft..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_President_Donation_League_Women = true; 
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_President_Donation_League_Women"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_DisputeWithInterior = false;
BaseGame.Situation_Order_DisputeDefenceMinistry = false;
BaseGame.Situation_Military_UnrulyGeneral = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_DisputeWithInterior"] = false;
Variable["BaseGame.Situation_Order_DisputeDefenceMinistry"] = false;
Variable["BaseGame.Situation_Military_UnrulyGeneral"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_GendarmerieDispute_DontCha..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_ACP_Investigates_PFJP_NoMe..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie = false; BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie_Interior = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_Gendarmerie_Interior"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_LeagueOfWomenDonation_Donate == ..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Iosef Lancea: "“If you don't believe my word, believe this.”"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Iosef Lancea: "“Heed my word, Mr. President.”"*)

### Węzeł `[295]`
Mówca: **Iosef Lancea**
> "“If you don't believe my word, believe this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Iosef Lancea: "“If you decide to transfer the Gendarmerie and weaken our..."*)

### Węzeł `[296]`
Mówca: **Iosef Lancea**
> "“If you decide to transfer the Gendarmerie and weaken our military further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Iosef Lancea: "“I will not be responsible for what happens.”"*)

### Węzeł `[297]`
Mówca: **Iosef Lancea**
> "“I will not be responsible for what happens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lileas Graf: "“Your threats will get you nowhere.”"*)

### Węzeł `[298]`
Mówca: **Lileas Graf**
> "“Your threats will get you nowhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lileas Graf: "“What is your decision?”"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == fa..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "Iosef stood up and leaned forward. His eyes darkened and ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false && 
BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == false && BaseGame.Faction_OldGuard_Destroyed == false && 
(BaseGame.Turn03_EnT_Military_Budget_Decrease == true && BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce == true)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false  and  
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == false  and  Variable["BaseGame.Faction_OldGuard_Destroyed"] == false  and  
(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  and  Variable["BaseGame.Decision_Turn05_RumburgBorderReinforcement_DontReinforce"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Iosef Lancea: "“You are making a mistake.”"*)

### Węzeł `[302]`
Mówca: **Narrator**
> "Iosef stood up and leaned forward. His eyes darkened and spoke softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Iosef Lancea: "“Mr. Rayne...”"*)

### Węzeł `[303]`
Mówca: **Iosef Lancea**
> "“Mr. Rayne...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Iosef Lancea: "“I am openly warning you.”"*)

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“I am openly warning you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Iosef Lancea: "“Don't do this.”"*)

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> "“Listen to what I am telling you. It is for your own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: "“Enough! I will not be threatened. I have already given m..."*)
  - -> `[308]` (*Player: "“Now that I think about it again... you are right, Iosef.”"*)

### Węzeł `[306]`
Mówca: **Iosef Lancea**
> "“Don't do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: "“Listen to what I am telling you. It is for your own good.”"*)

### Węzeł `[307]`
**[WYBÓR GRACZA: "“Enough! I will not be threatened. I have already given my decision.”"]** — Mówca: **Player**
> "“Enough! I will not be threatened. I have already given my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Iosef Lancea: "“I did all I could, Mr. President.”"*)

### Węzeł `[308]`
**[WYBÓR GRACZA: "“Now that I think about it again... you are right, Iosef.”"]** — Mówca: **Player**
> "“Now that I think about it again... you are right, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[309]`
Mówca: **Iosef Lancea**
> "“I did all I could, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_UnrulyGeneral = true; BaseGam..."*)

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_DisputeWithInterior = false; ..."*)

### Węzeł `[311]`
Mówca: **Iosef Lancea**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_Gendarmerie_Interior = true"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_UnrulyGeneral = true;
BaseGame.LateGameCrisis += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_UnrulyGeneral"] = true;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_Gendarmerie_Interior = true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_President_Donation_League_Women = true; 
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_President_Donation_League_Women"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHeft..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHe..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_President_Donation_League_W..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_LeagueOfWomenDonation_DonateHefty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Stopped_Investigations_NFP == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Stopped_Investigations_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = tru..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_ACP_Investigated_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Stopped_Investigations_NFP == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Stopped_Investigations_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_ACP_Investigates_NFP = true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Stopped_Investigations_NFP == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Stopped_Investigations_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = tru..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_SSP_Investigated_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[328]`
Mówca: **Lileas Graf**
> ""This isn't new. How about Bergia, Mr. Lancea? Let me remind you. I've been tasked with eliminating the BFF -- and thanks to your men -- we have already slipped a BFF leader from our grasp before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Lileas Graf: ""This isn't new. How about Bergia, Mr. Lancea? Let me rem..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Ob..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_DisabilityBenefit = true"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= 0 && BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0  and  Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0 && BaseGame.Faction_USP_Obs..."*)
