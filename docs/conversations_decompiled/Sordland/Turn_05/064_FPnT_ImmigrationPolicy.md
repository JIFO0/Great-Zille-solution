# Sordland/Turn05/FPnT_ImmigrationPolicy

- **ID konwersacji:** `64`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/064_FPnT_ImmigrationPolicy.md`
- **Liczba węzłów dialogowych:** 305
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[44]** Lileas Graf
- **[51]** Symon Holl
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.GovernmentBudget`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Promise_Immigration_Tighten`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.SuperpowerTradeWarHappened`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn04_SnO_LE_Justice_Increased`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGameIsolated.Turn05_FPnT_Listened_Number`
- `BaseGameIsolated.Turn05_FPnT_Listened_Relaxed`
- `BaseGameIsolated.Turn05_FPnT_Listened_Status`
- `BaseGameIsolated.Turn05_FPnT_Listened_Tighten`
- `BaseGameIsolated.Turn05_FPnT_Listened_Travel`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Economy_Agnland`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Economy_Lorren`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Order_IllegalImmigration`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGame.Situation_Order_StreamlinedImmigration`
- `BaseGame.Sollist`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Turn05_Inflation`
- `BaseGameIsolated.Turn05_FPnT_Listened_Number`
- `BaseGameIsolated.Turn05_FPnT_Listened_Relaxed`
- `BaseGameIsolated.Turn05_FPnT_Listened_Status`
- `BaseGameIsolated.Turn05_FPnT_Listened_Tighten`
- `BaseGameIsolated.Turn05_FPnT_Listened_Travel`
- `BaseGameSupport.Codex_Characters_Others_JohanGasmich`
- `BaseGameSupport.Codex_Characters_Others_JohanGasmich_Arrested`
- `BaseGameSupport.CountryReport_Turn05_Kyrute_EmphasizesNeutralityValue`
- `BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsUCAid`
- `BaseGameSupport.CountryReport_Turn05_Valgsland_CautionsAgainstPrivatization`
- `BaseGameSupport.CountryReport_Turn05_Wehlen_CondemnsArcasianAid`
- `BaseGameSupport.FactionReport_Turn05_ATO_CritiquesTradeWar`
- `BaseGameSupport.FactionReport_Turn05_CSP_DefendsTradeWar`
- `BaseGameSupport.Journal_Turn05_Immigration_Tightened`
- `BaseGameSupport.News_Turn05_E_ImmigrationTightened`
- `BaseGameSupport.News_Turn05_G_ImmigrationTightened`
- `BaseGameSupport.News_Turn05_LT_FreedomEducation`
- `BaseGameSupport.News_Turn05_R_DeyrLockdownBlud`
- `BaseGameSupport.News_Turn05_R_StateWarRY`
- `BaseGameSupport.News_Turn05_ST_Strike_H3_Deal`
- `BaseGameSupport.News_Turn05_ST_Strike_H3_NoDeal`
- `BaseGameSupport.News_Turn05_ST_Strike_L1_Deal`
- `BaseGameSupport.News_Turn05_ST_Strike_L1_NoDeal`
- `BaseGameSupport.News_Turn05_ST_UCAid_Deal`
- `BaseGameSupport.News_Turn05_ST_UCAid_NoDeal`
- `BaseGameSupport.Report_Turn05_Benfi_RadicalEditorSuspect`
- `BaseGameSupport.Report_Turn05_Deyr_LockdownLifted`
- `BaseGameSupport.Report_Turn05_Erzaren_ReligiousRallyAgainstSordland`
- `BaseGameSupport.Report_Turn05_Holsord_CBRProposal`
- `BaseGameSupport.Report_Turn05_Holsord_InteriorIncreased`
- `BaseGameSupport.Report_Turn05_Holsord_JusticeIncreased`
- `BaseGameSupport.Report_Turn05_Vesord_RYRaided`
- `GameCondition.Turn05_FPnT_ImmigrationPolicy`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **"“I agree that we need to consider the economic impact of immigration.”"** | `[16]` **Deivid Wisci**: "“Look at the superpowers. Do you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Symon Holl**: "“Our money flow should be our ut..." |
| `[13]` | **"“We need to modernize and reach the level of the superpowers.”"** | `[16]` **Deivid Wisci**: "“Look at the superpowers. Do you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Deivid Wisci**: "“I am of the same mind. It is pr..." |
| `[14]` | **"“Sordish citizens must come first.”"** | `[16]` **Deivid Wisci**: "“Look at the superpowers. Do you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Iosef Lancea**: "“Exactly. Our citizens should ne..." |
| `[38]` | **"“What is the current legal status of immigrants?”"** | `[37]` **Deivid Wisci**: "“Mr. President. Do you have any ..."<br>`[48]` **Lileas Graf**: "“Politically persecuted Wehzek r..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == false` | *Brak zmian stanu* | `[39]` **Deivid Wisci**: "“Currently, all accepted immigra..." |
| `[41]` | **"“How many immigrants live in Sordland?”"** | `[37]` **Deivid Wisci**: "“Mr. President. Do you have any ..."<br>`[48]` **Lileas Graf**: "“Politically persecuted Wehzek r..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == false` | *Brak zmian stanu* | `[42]` **Deivid Wisci**: "“Official numbers show that we h..." |
| `[45]` | **"“How do immigrants usually arrive here?”"** | `[37]` **Deivid Wisci**: "“Mr. President. Do you have any ..."<br>`[48]` **Lileas Graf**: "“Politically persecuted Wehzek r..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == false` | *Brak zmian stanu* | `[46]` **Deivid Wisci**: "“There are three major paths the..." |
| `[49]` | **"“Let's move on and see what can be done about the immigration situation.”"** | `[37]` **Deivid Wisci**: "“Mr. President. Do you have any ..."<br>`[48]` **Lileas Graf**: "“Politically persecuted Wehzek r..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true` | *Brak zmian stanu* | `[51]` **Deivid Wisci**: "“Very well.”" |
| `[50]` | **"“I don't have any questions. Let's move on to solutions.”"** | `[37]` **Deivid Wisci**: "“Mr. President. Do you have any ..."<br>`[48]` **Lileas Graf**: "“Politically persecuted Wehzek r..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true) == false` | *Brak zmian stanu* | `[51]` **Deivid Wisci**: "“Very well.”" |
| `[70]` | **"“If we decide to tighten immigration, what does that entail?”"** | `[68]` **Deivid Wisci**: "“This is going nowhere.”"<br>`[83]` **Iosef Lancea**: "“Agreed. Sordish citizens should..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Tighten"] == false` | *Brak zmian stanu* | `[80]` **Deivid Wisci**: "“We would have to impose quotas ..." |
| `[71]` | **"“What are the consequences of keeping our immigration policy relaxed?”"** | `[68]` **Deivid Wisci**: "“This is going nowhere.”"<br>`[83]` **Iosef Lancea**: "“Agreed. Sordish citizens should..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Relaxed"] == false` | *Brak zmian stanu* | `[84]` **Deivid Wisci**: "“Aside from keeping us on the pa..." |
| `[72]` | **"“I am ready to make a decision.”"** | `[68]` **Deivid Wisci**: "“This is going nowhere.”"<br>`[83]` **Iosef Lancea**: "“Agreed. Sordish citizens should..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Deivid Wisci**: "“Yes?”" |
| `[93]` | **"“We will keep immigration laws relaxed.”"** | `[92]` **Narrator**: "Everyone leaned forward, eager t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = fals...`<br>`Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] ...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[94]` | **"“We'll tighten our immigration laws. I'll sign the decree soon, so be prepared to ..."** | `[92]` **Narrator**: "Everyone leaned forward, eager t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true...`<br>`Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[116]` | **"“The citizens of Sordland aren't forgotten. Our work for them continues.”"** | `[112]` **Iosef Lancea**: "“This is shameful.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Lileas Graf**: "“And now they will compete with ..." |
| `[117]` | **"“My decision is final and irreversible. Time to move on.”"** | `[112]` **Iosef Lancea**: "“This is shameful.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Deivid Wisci**: "“Rightfully so.”" |
| `[118]` | **"“We are not leaving Sordland unprotected. It is a logical decision.”"** | `[112]` **Iosef Lancea**: "“This is shameful.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Iosef Lancea**: "“You are wrong about this. There..." |
| `[120]` | **"“Thank you for your contributions. Let's wrap this up.”"** | `[108]` **Iosef Lancea**: "“Anything else that needs to be ..."<br>`[129]` **Deivid Wisci**: "“Anything else, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The ministers gathered their doc..." |
| `[121]` | **"“We can't let internal policy be decided by foreigners. Sordland always comes first.”"** | `[119]` **Symon Holl**: "“I'm against isolationism. It is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Deivid Wisci**: "“Both can be a factor in decisio..." |
| `[122]` | **"“This is not about isolating Sordland, but protecting it.”"** | `[119]` **Symon Holl**: "“I'm against isolationism. It is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Symon Holl**: "“This will isolate us in every w..." |
| `[123]` | **"“I want everybody here to get used to the new changes. This is our new direction.”"** | `[108]` **Iosef Lancea**: "“Anything else that needs to be ..."<br>`[129]` **Deivid Wisci**: "“Anything else, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The ministers gathered their doc..." |
| `[124]` | **"“Let's end this discussion and get to work. There are changes to be made.”"** | `[108]` **Iosef Lancea**: "“Anything else that needs to be ..."<br>`[129]` **Deivid Wisci**: "“Anything else, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The ministers gathered their doc..." |
| `[135]` | **"“Keep up the good work.”"** | `[131]` **Iosef Lancea**: "“Same here. Our border units nee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "The ministers dispersed." |
| `[136]` | **"“The decision has been made. Let's look past it.”"** | `[119]` **Symon Holl**: "“I'm against isolationism. It is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Iosef Lancea**: "“Well said!”" |
| `[140]` | **"“Yes, we are finished.”"** | `[131]` **Iosef Lancea**: "“Same here. Our border units nee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Narrator**: "The ministers dispersed." |
| `[212]` | **"“Be careful. Don't burn yourself out.”"** | `[210]` **Symon Holl**: "“I am currently attempting to mi..."<br>`[211]` **Symon Holl**: "“I am currently looking into way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Symon Holl**: "“I will do my best, but the futu..." |
| `[213]` | **"“I am expecting good results, Symon. Do not fail me.”"** | `[210]` **Symon Holl**: "“I am currently attempting to mi..."<br>`[211]` **Symon Holl**: "“I am currently looking into way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Symon Holl**: "“I will not, Mr. President. The ..." |
| `[214]` | **"“How is it looking? Is there a way out?”"** | `[210]` **Symon Holl**: "“I am currently attempting to mi..."<br>`[211]` **Symon Holl**: "“I am currently looking into way..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Symon Holl**: "“I do not want to say anything t..." |
| `[226]` | **"“Desperate times call for desperate measures.”"** | `[225]` **Iosef Lancea**: "“I do not approve of this decisi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Iosef Lancea**: "“That's how they take over count..." |
| `[227]` | **"“I will not let you question my decisions, Iosef.”"** | `[225]` **Iosef Lancea**: "“I do not approve of this decisi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Iosef Lancea**: "“Yes, Mr. President.”" |
| `[228]` | **"“I have done this with Sordish citizens in mind. Nothing else.”"** | `[225]` **Iosef Lancea**: "“I do not approve of this decisi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Iosef Lancea**: "“That's how they take over count..." |
| `[229]` | **"“Don't be dramatic. We need to be friendly with our potential allies.”"** | `[225]` **Iosef Lancea**: "“I do not approve of this decisi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Iosef Lancea**: "“Allies? Sordland has no allies ..." |
| `[234]` | **"“Desperate times call for desperate measures.”"** | `[224]` **Iosef Lancea**: "“Contanan war ships in Conriat! ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Iosef Lancea**: "“That's how they take over count..." |
| `[235]` | **"“I will not let you question my decisions, Iosef.”"** | `[224]` **Iosef Lancea**: "“Contanan war ships in Conriat! ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Iosef Lancea**: "“Yes, Mr. President.”" |
| `[236]` | **"“I have done this with Sordish citizens in mind. Nothing else.”"** | `[224]` **Iosef Lancea**: "“Contanan war ships in Conriat! ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Iosef Lancea**: "“That's how they take over count..." |
| `[237]` | **"“Don't be dramatic. We need to be friendly with our potential allies.”"** | `[224]` **Iosef Lancea**: "“Contanan war ships in Conriat! ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Iosef Lancea**: "“Allies? With those communists? ..." |

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
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Erzaren_ReligiousRallyAgain..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We were in the middle of a meeting in the Palace about our immigration policy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The ensuing discussion quickly became heated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Iosef Lancea: "“I don't think so, Mr. Wisci!”"*)

### Węzeł `[5]`
Mówca: **Iosef Lancea**
> "“It just doesn't make any sense to me that a foreign citizen should come before a Sordish citizen. In Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lileas Graf: "“Well said. My analysis is also in line with this. Especi..."*)

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“I don't think so, Mr. Wisci!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Iosef Lancea: "“It just doesn't make any sense to me that a foreign citi..."*)

### Węzeł `[7]`
Mówca: **Deivid Wisci**
> "“Immigrants are the reason our economy is not completely unsalvageable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deivid Wisci: "“Look at Agnolian immigrants in Agnland. They have revita..."*)

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“Well said. My analysis is also in line with this. Especially during the economic recession... We are giving Sordish jobs to migrants from other countries. What about our own people?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Deivid Wisci: "“Immigrants are the reason our economy is not completely ..."*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“Statistically speaking, allowing immigrants to become part of the workforce contributes to our economy. But I agree that the current situation is very nuanced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: "“With that said, we can't just tighten our immigration po..."*)

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“With that said, we can't just tighten our immigration policy and expect the economy to stay the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Symon Holl: "“We need to put our economy and the recession at the fore..."*)

### Węzeł `[11]`
Mówca: **Deivid Wisci**
> "“Look at Agnolian immigrants in Agnland. They have revitalized the whole region and in turn, boosted the economy of the entire country. Symon can attest to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“Statistically speaking, allowing immigrants to become pa..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I agree that we need to consider the economic impact of immigration.”"]** — Mówca: **Player**
> "“We need to consider the impact on economy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Symon Holl: "“Our money flow should be our utmost concern, if we want ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“We need to modernize and reach the level of the superpowers.”"]** — Mówca: **Player**
> "“We need to modernize and reach the level of the superpowers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Deivid Wisci: "“I am of the same mind. It is proven that immigration hel..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Sordish citizens must come first.”"]** — Mówca: **Player**
> "“Sordish citizens must come first.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Iosef Lancea: "“Exactly. Our citizens should never feel threatened by fo..."*)

### Węzeł `[15]`
Mówca: **Symon Holl**
> "“Our money flow should be our utmost concern, if we want to have the capability to accomplish actual change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Deivid Wisci: "“We need a decision. But before we move on...”"*)

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“Look at the superpowers. Do you see them closing off their borders? Why do you think their economies are in such good shape? They are in their current state because they welcome immigration, and use it to their advantage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“We need to modernize and reach the level of the superpow..."*)
  - -> `[12]` (*Player: "“I agree that we need to consider the economic impact of ..."*)
  - -> `[14]` (*Player: "“Sordish citizens must come first.”"*)

### Węzeł `[17]`
Mówca: **Iosef Lancea**
> "“Exactly. Our citizens should never feel threatened by foreigners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Deivid Wisci: "“We need a decision. But before we move on...”"*)

### Węzeł `[18]`
Mówca: **Deivid Wisci**
> "“I am of the same mind. It is proven that immigration helps countries to develop. And we cannot just deport our current immigrants.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Deivid Wisci: "“We need a decision. But before we move on...”"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Immigration Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Immigration Hub"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Immigration Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Status == false"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Number == false"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Travel == false"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Status == true || B..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Status == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Status == false"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Status == false)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Status == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“What is the current legal status of immigrants?”"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Status == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Number == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Number == false"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Number == false)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Number == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“How many immigrants live in Sordland?”"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Number == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Travel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "Jump to: [Immigration Hub]"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Status == true || BaseGameIsolated.Turn05_FPnT_Listened_Number == true || BaseGameIsolated.Turn05_FPnT_Listened_Travel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Status == true || B..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Status == true ||..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Status == true || BaseGameIsolated.Turn05_FPnT_Listened_Number == true || BaseGameIsolated.Turn05_FPnT_Listened_Travel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“Let's move on and see what can be done about the immigra..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Status == true || BaseGameIsolated.Turn05_FPnT_Listened_Number == true || BaseGameIsolated.Turn05_FPnT_Listened_Travel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“I don't have any questions. Let's move on to solutions.”"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Number = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "Jump to: [Immigration Hub]"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Travel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Travel == false"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Travel == false)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Travel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“How do immigrants usually arrive here?”"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Travel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Status = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "Jump to: [Immigration Hub]"*)

### Węzeł `[36]`
Mówca: **Deivid Wisci**
> "“We need a decision. But before we move on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Deivid Wisci: "“Mr. President. Do you have any questions about the curre..."*)

### Węzeł `[37]`
Mówca: **Deivid Wisci**
> "“Mr. President. Do you have any questions about the current state of immigration?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Immigration Hub"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“What is the current legal status of immigrants?”"]** — Mówca: **Player**
> "“What is the current legal status of immigrants?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == false`
- **Kontekst wejściowy (poprzednik):** `[37]` (Deivid Wisci), `[48]` (Lileas Graf), `[44]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Deivid Wisci: "“Currently, all accepted immigrants are given a work perm..."*)

### Węzeł `[39]`
Mówca: **Deivid Wisci**
> "“Currently, all accepted immigrants are given a work permit on arrival, so that they can work and contribute to the economy of Sordland. There is currently no limit on the number of immigrants accepted. However, the number has remained stable over the past years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Symon Holl: "“Despite the laws, the fact is many immigrants illegally ..."*)

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“Despite the laws, the fact is many immigrants illegally work for corporations. That is the main issue with immigration right now. Not the immigration itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lileas Graf: "“Nonsense. If not for the unlimited amount of immigration..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“How many immigrants live in Sordland?”"]** — Mówca: **Player**
> "“How many immigrants live in Sordland?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == false`
- **Kontekst wejściowy (poprzednik):** `[37]` (Deivid Wisci), `[48]` (Lileas Graf), `[44]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Deivid Wisci: "“Official numbers show that we have anywhere between two ..."*)

### Węzeł `[42]`
Mówca: **Deivid Wisci**
> "“Official numbers show that we have anywhere between two to three million immigrants residing in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: "“Even excluding the countless undocumented aliens in our ..."*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“Even excluding the countless undocumented aliens in our midst, that is a very substantial amount. The primary issue is the strife they cause between less fortunate Sordish citizens and themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“Including them in the workforce would benefit everybody,..."*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Including them in the workforce would benefit everybody, including unemployed Sords. More taxes means more services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Number = true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“How do immigrants usually arrive here?”"]** — Mówca: **Player**
> "“How do immigrants usually arrive here?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == false`
- **Kontekst wejściowy (poprzednik):** `[37]` (Deivid Wisci), `[48]` (Lileas Graf), `[44]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Deivid Wisci: "“There are three major paths they choose. The first one i..."*)

### Węzeł `[46]`
Mówca: **Deivid Wisci**
> "“There are three major paths they choose. The first one is the Agnland to Agnolia border. The second is the Bergia to Wehlen border, and the third is the Lorren Coast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“Agnolians are the largest group. It's a light border ove..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“Agnolians are the largest group. It's a light border over there. Although recently, political fugitives from Valgsland have been crossing the Grey Sea by boat to land on our coast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: "“Politically persecuted Wehzek refugees tend to use the d..."*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“Politically persecuted Wehzek refugees tend to use the dangerous mountain passes at the Wehlen border. Many of them also have Bludish blood. This is significantly increasing the Blud populace inside Bergia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Travel = true"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Let's move on and see what can be done about the immigration situation.”"]** — Mówca: **Player**
> "“Let's move on and see what can be done about the immigration situation.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true`
- **Kontekst wejściowy (poprzednik):** `[37]` (Deivid Wisci), `[48]` (Lileas Graf), `[44]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I don't have any questions. Let's move on to solutions.”"]** — Mówca: **Player**
> "“I don't have any questions. Let's move on to solutions.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Status"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Number"] == true  or  Variable["BaseGameIsolated.Turn05_FPnT_Listened_Travel"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[37]` (Deivid Wisci), `[48]` (Lileas Graf), `[44]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Deivid Wisci opened his dossier stamped with the seal of ..."*)

### Węzeł `[52]`
Mówca: **Lileas Graf**
> "“Nonsense. If not for the unlimited amount of immigration, we wouldn't be in this state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Status = true"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Deivid Wisci opened his dossier stamped with the seal of the Ministry of Foreign Affairs and Trade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Deivid Wisci: "“Before we make any decisions, I have to remind you.”"*)

### Węzeł `[54]`
Mówca: **Deivid Wisci**
> "“Before we make any decisions, I have to remind you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Tighten == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deivid Wisci: "“During the elections, we promised to tighten immigration..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Tighten == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Deivid Wisci: "“During the elections we promised to keep our immigration..."*)

### Węzeł `[58]`
Mówca: **Deivid Wisci**
> "“During the elections, we promised to tighten immigration laws. Of course, as you know, I was and I still am against it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“I agree with Deivid. We can turn immigration to our adva..."*)

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“During the elections we promised to keep our immigration laws relaxed. Which I think is the right course of action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“I disagree. We are supposed to control and reduce the ne..."*)

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“I agree with Deivid. We can turn immigration to our advantage from a financial standpoint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lileas Graf: "“Advantage? You should go over the amount of disadvantage..."*)

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“I see your point, Iosef but the economy certainly benefits from more immigration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lileas Graf: "“Internal order on the other hand, suffers immensely.”"*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“I disagree. We are supposed to control and reduce the negative effects of immigration, like crime and subversion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Symon Holl: "“I see your point, Iosef but the economy certainly benefi..."*)

### Węzeł `[63]`
Mówca: **Lileas Graf**
> "“Internal order on the other hand, suffers immensely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lileas Graf: "“We should tighten the laws to prevent further chaos.”"*)

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“We need to keep our promises and focus on our own citizens. That is what I think.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Deivid sighed wearily."*)

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“We should tighten the laws to prevent further chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Deivid sighed wearily."*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“Believe me, it would surprise you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“We need to keep our promises and focus on our own citize..."*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> "“Advantage? You should go over the amount of disadvantages caused by immigrants. I can provide you with a report from my ministry later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“Believe me, it would surprise you.”"*)

### Węzeł `[68]`
Mówca: **Deivid Wisci**
> "“This is going nowhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "ImmigrationChoiceHub"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Deivid sighed wearily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Deivid Wisci: "“This is going nowhere.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“If we decide to tighten immigration, what does that entail?”"]** — Mówca: **Player**
> "“If we decide to tighten immigration, what does that entail?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Tighten"] == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Deivid Wisci), `[83]` (Iosef Lancea), `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Deivid Wisci: "“We would have to impose quotas and, connected to that, s..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What are the consequences of keeping our immigration policy relaxed?”"]** — Mówca: **Player**
> "“What are the consequences of keeping our immigration policy relaxed?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Relaxed"] == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Deivid Wisci), `[83]` (Iosef Lancea), `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Deivid Wisci: "“Aside from keeping us on the path to prosperity, moderni..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Deivid Wisci), `[83]` (Iosef Lancea), `[87]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Deivid Wisci: "“Yes?”"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ImmigrationChoiceHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false"*)
  - -> `[72]` (*Player: "“I am ready to make a decision.”"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Tighten"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“If we decide to tighten immigration, what does that enta..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Tighten == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Tighten"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Relaxed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“What are the consequences of keeping our immigration pol..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Listened_Relaxed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Listened_Relaxed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Deivid Wisci**
> "“We would have to impose quotas and, connected to that, stricter border control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Symon Holl: "“On top of allowing our economy to take a hit.”"*)

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“On top of allowing our economy to take a hit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“Mr. Holl. Surely the well-being of our citizens and our ..."*)

### Węzeł `[82]`
Mówca: **Lileas Graf**
> "“Mr. Holl. Surely the well-being of our citizens and our internal security will more than compensate for any downturn in the markets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“Agreed. Sordish citizens should take priority.”"*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“Agreed. Sordish citizens should take priority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Tighten = true"*)

### Węzeł `[84]`
Mówca: **Deivid Wisci**
> "“Aside from keeping us on the path to prosperity, modernity and continuous improvement...Not much. Our current system is good for our era. We also have the capacity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Symon Holl: "“This will allow us to continue protecting investments fr..."*)

### Węzeł `[85]`
Mówca: **Symon Holl**
> "“This will allow us to continue protecting investments from foreign countries, which in turn will keep our trade steady. We would be more trustworthy partners. Stability draws money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lileas Graf: "“Stability? What stability? We're already seeing clashes ..."*)

### Węzeł `[86]`
Mówca: **Lileas Graf**
> "“Stability? What stability? We're already seeing clashes between our people and foreign interlopers. On the contrary, the only way we can achieve stability is through tightening our immigration policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Iosef Lancea: "“You heard the lady. Sordland first...”"*)

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“You heard the lady. Sordland first...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Listened_Relaxed = true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Tighten = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Tighten"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "Jump to: [ImmigrationChoiceHub]"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Listened_Relaxed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Listened_Relaxed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "Jump to: [ImmigrationChoiceHub]"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ImmigrationChoiceHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "ImmigrationChoiceHub"*)

### Węzeł `[91]`
Mówca: **Deivid Wisci**
> "“Yes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Everyone leaned forward, eager to hear my response."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Everyone leaned forward, eager to hear my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“We will keep immigration laws relaxed.”"*)
  - -> `[94]` (*Player: "“We'll tighten our immigration laws. I'll sign the decree..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“We will keep immigration laws relaxed.”"]** — Mówca: **Player**
> "“We will keep immigration laws relaxed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight = false; BaseGame...."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“We'll tighten our immigration laws. I'll sign the decree soon, so be prepared to start working on it, Mr. Wisci.”"]** — Mówca: **Player**
> "“We'll tighten our immigration laws. I'll sign the decree soon, so be prepared to start working on it, Mr. Wisci.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight = true; BaseGame.S..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration = true;
BaseGame.Policy_Diplomacy_TightenedImmigration = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] = true;
Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight = true;
BaseGame.Sollist += 3;
BaseGame.Capitalist -= 1;
BaseGame.Economy_Gruni -= 2;
BaseGame.Economy_Lorren -= 1;
BaseGame.Economy_Agnland -= 1;
BaseGame.Economy_Bergia -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 3;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;
Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] - 2;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] - 1;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] - 1;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration = true; Ba..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_IllegalImmigration = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_IllegalImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_StreamlinedImmigration = true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_StreamlinedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_StreamlinedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deivid Wisci: "“I am glad you made the right choice.”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_IllegalImmigration = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_IllegalImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_StreamlinedImmigration = true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration = true;
BaseGame.Policy_Diplomacy_RelaxedImmigration = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;
Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_StreamlinedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_StreamlinedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Deivid Wisci: "“It is unfortunate to see Sordland move in this direction..."*)

### Węzeł `[102]`
Mówca: **Deivid Wisci**
> "“I am glad you made the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Iosef Lancea: "“We will be forced to handle new waves of migrants from A..."*)

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“It is unfortunate to see Sordland move in this direction... But I trust you have good intentions. I'll move ahead with the implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Immigration_Tightened = true"*)

### Węzeł `[104]`
Mówca: **Iosef Lancea**
> "“We will be forced to handle new waves of migrants from Agnolia. Our border posts aren't ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: "“Not only that, we've just abandoned the native Sords who..."*)

### Węzeł `[105]`
Mówca: **Symon Holl**
> "“This has the chance to affect our trade negotiations with Agnolia negatively. They expect us to respect the flow of people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Deivid Wisci: "“Indeed. It will be a challenge to convince these countri..."*)

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“Also, this will bring a new tide of refugees from Wehlen. Bergia is already a difficult region to manage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Iosef Lancea: "“This is shameful.”"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_FPnT_ImmigrationPolicy = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_FPnT_ImmigrationPolicy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“Anything else that needs to be said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“Thank you for your contributions. Let's wrap this up.”"*)
  - -> `[124]` (*Player: "“Let's end this discussion and get to work. There are cha..."*)
  - -> `[123]` (*Player: "“I want everybody here to get used to the new changes. Th..."*)

### Węzeł `[109]`
Mówca: **Lileas Graf**
> "“Not only that, we've just abandoned the native Sords who need our support the most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lileas Graf: "“Also, this will bring a new tide of refugees from Wehlen..."*)

### Węzeł `[110]`
Mówca: **Symon Holl**
> "“This will isolate us in every way. The more we are connected to the world, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Deivid Wisci: "“The world is entering the age of globalization. This dec..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "The ministers gathered their documents and rose from their chairs, some with frowns on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Deivid Wisci: "“I'm looking forward to the upcoming trade talks. Petr an..."*)

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“This is shameful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“We are not leaving Sordland unprotected. It is a logical..."*)
  - -> `[117]` (*Player: "“My decision is final and irreversible. Time to move on.”"*)
  - -> `[116]` (*Player: "“The citizens of Sordland aren't forgotten. Our work for ..."*)

### Węzeł `[113]`
Mówca: **Deivid Wisci**
> "“Indeed. It will be a challenge to convince these countries as they see our borders close.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Symon Holl: "“Not only that, we've already slighted Wehlen in the past..."*)

### Węzeł `[114]`
Mówca: **Symon Holl**
> "“Not only that, we've already slighted Wehlen in the past. They might see this as a return to the '30s, which will definitely affect our negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lileas Graf: ""I wouldn't worry about that too much. With how Wehlen is..."*)

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“If we are finished, I need to head off and get the Ministry to work on the new policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Iosef Lancea: "“Same here. Our border units need to be informed and prep..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“The citizens of Sordland aren't forgotten. Our work for them continues.”"]** — Mówca: **Player**
> "“The citizens of Sordland aren't forgotten. Our work for them continues.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lileas Graf: "“And now they will compete with foreign immigrants just t..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“My decision is final and irreversible. Time to move on.”"]** — Mówca: **Player**
> "“My decision is final and irreversible. Time to move on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Deivid Wisci: "“Rightfully so.”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“We are not leaving Sordland unprotected. It is a logical decision.”"]** — Mówca: **Player**
> "“We are not leaving Sordland unprotected. It is a logical decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Iosef Lancea: "“You are wrong about this. There is a reason why this cou..."*)

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“I'm against isolationism. It is the wrong path.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“This is not about isolating Sordland, but protecting it.”"*)
  - -> `[121]` (*Player: "“We can't let internal policy be decided by foreigners. S..."*)
  - -> `[136]` (*Player: "“The decision has been made. Let's look past it.”"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Thank you for your contributions. Let's wrap this up.”"]** — Mówca: **Player**
> "“Thank you for your contributions. Let's wrap this up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea), `[129]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The ministers gathered their documents and rose from thei..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“We can't let internal policy be decided by foreigners. Sordland always comes first.”"]** — Mówca: **Player**
> "“We can't let internal policy be decided by foreigners. Sordland always comes first.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Deivid Wisci: "“Both can be a factor in decision-making. We shouldn't fo..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“This is not about isolating Sordland, but protecting it.”"]** — Mówca: **Player**
> "“This is not about isolating Sordland, but protecting it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Symon Holl: "“This will isolate us in every way. The more we are conne..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I want everybody here to get used to the new changes. This is our new direction.”"]** — Mówca: **Player**
> "“I want everybody here to get used to the new changes. This is our new direction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea), `[129]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The ministers gathered their documents and rose from thei..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Let's end this discussion and get to work. There are changes to be made.”"]** — Mówca: **Player**
> "“Let's end this discussion and get to work. There are changes to be made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Iosef Lancea), `[129]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The ministers gathered their documents and rose from thei..."*)

### Węzeł `[125]`
Mówca: **Iosef Lancea**
> "“You are wrong about this. There is a reason why this country has survived the Century of Revolutions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lileas Graf: "“I hope hard-working Sords will see this as positively as..."*)

### Węzeł `[126]`
Mówca: **Deivid Wisci**
> "“Both can be a factor in decision-making. We shouldn't forget about the immigrants who live here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: "“Disappointing, really.”"*)

### Węzeł `[127]`
Mówca: **Deivid Wisci**
> "“Rightfully so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Symon Holl: "“Let's move on.”"*)

### Węzeł `[128]`
Mówca: **Lileas Graf**
> "“And now they will compete with foreign immigrants just to put food on their tables.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Iosef Lancea: "“I'm disappointed in you, Rayne.""*)

### Węzeł `[129]`
Mówca: **Deivid Wisci**
> "“Anything else, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“Thank you for your contributions. Let's wrap this up.”"*)
  - -> `[124]` (*Player: "“Let's end this discussion and get to work. There are cha..."*)
  - -> `[123]` (*Player: "“I want everybody here to get used to the new changes. Th..."*)

### Węzeł `[130]`
Mówca: **Lileas Graf**
> "“I hope hard-working Sords will see this as positively as you do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Anything else, Mr. President?”"*)

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“Same here. Our border units need to be informed and prepared.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“Yes, we are finished.”"*)
  - -> `[135]` (*Player: "“Keep up the good work.”"*)

### Węzeł `[132]`
Mówca: **Narrator**
> "The ministers dispersed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)

### Węzeł `[133]`
Mówca: **Deivid Wisci**
> "“I'm looking forward to the upcoming trade talks. Petr and I have been visiting Staalport and Wraclawitz in preparation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Symon Holl: "“I'll be coming along to talk with the Economy Minister. ..."*)

### Węzeł `[134]`
Mówca: **Iosef Lancea**
> "“Well said!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“Anything else that needs to be said?”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“Keep up the good work.”"]** — Mówca: **Player**
> "“Keep up the good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "The ministers dispersed."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“The decision has been made. Let's look past it.”"]** — Mówca: **Player**
> "“The decision has been made. Let's look past it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Iosef Lancea: "“Well said!”"*)

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“Disappointing, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“Anything else that needs to be said?”"*)

### Węzeł `[138]`
Mówca: **Symon Holl**
> "“I'll be coming along to talk with the Economy Minister. Looking forward to the potential partnership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lileas Graf: "“If we are finished, I need to head off and get the Minis..."*)

### Węzeł `[139]`
Mówca: **Deivid Wisci**
> "“The world is entering the age of globalization. This decision will make us stay behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“Anything else that needs to be said?”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Yes, we are finished.”"]** — Mówca: **Player**
> "“Yes, we are finished.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "The ministers dispersed."*)

### Węzeł `[141]`
Mówca: **Symon Holl**
> "“Let's move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Anything else, Mr. President?”"*)

### Węzeł `[142]`
Mówca: **Iosef Lancea**
> "“I'm disappointed in you, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Anything else, Mr. President?”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Deyr_LockdownLifted = true;..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The ensuing discussion quickly became heated."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Deyr_LockdownLifted = true;
BaseGameSupport.News_Turn05_R_DeyrLockdownBlud = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Deyr_LockdownLifted"] = true;
Variable["BaseGameSupport.News_Turn05_R_DeyrLockdownBlud"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Deyr", "City_Lockdown");"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Wehlen_CondemnsArcas..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn05_Wehlen_CondemnsArcasianAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Wehlen_CondemnsArcasianAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsUCAid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsUCAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_InteriorIncreased =..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_JusticeIncreased = ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_InteriorIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_InteriorIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_JusticeIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_JusticeIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Benfi_RadicalEditorSuspect ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Benfi_RadicalEditorSuspect = true;
BaseGameSupport.Report_Turn05_Vesord_RYRaided = true;
BaseGameSupport.News_Turn05_R_StateWarRY = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Benfi_RadicalEditorSuspect"] = true;
Variable["BaseGameSupport.Report_Turn05_Vesord_RYRaided"] = true;
Variable["BaseGameSupport.News_Turn05_R_StateWarRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_JohanGasmich = fa..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_UCAid_Deal = true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_UCAid_NoDeal = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_UCAid_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_UCAid_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsUCAid..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_UCAid_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_UCAid_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsUCAid..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_E_ImmigrationTightened = true..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_E_ImmigrationTightened = true;
BaseGameSupport.News_Turn05_G_ImmigrationTightened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_ImmigrationTightened"] = true;
Variable["BaseGameSupport.News_Turn05_G_ImmigrationTightened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Immigration_Tightened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Immigration_Tightened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Symon Holl: "“This has the chance to affect our trade negotiations wit..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true )"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Strike_L1_Deal = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Strike_L1_NoDeal = true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Strike_L1_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Strike_L1_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Strike_H3_Deal = true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Strike_H3_NoDeal = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Strike_L1_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Strike_L1_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_ImmigrationPolicy = true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Strike_H3_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Strike_H3_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_ImmigrationPolicy = true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Strike_H3_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Strike_H3_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_ImmigrationPolicy = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight = false;
BaseGame.Sollist -= 2;
BaseGame.Capitalist += 1;
BaseGame.Economy_Agnland += 1;
BaseGame.Economy_Bergia += 1;
BaseGame.Economy_Lorren += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = false;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration = true; Base..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BlackTuesdayHappened == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Symon Holl: "“Especially after...""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BlackTuesdayHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Symon Holl: "“Thankfully, we have just started receiving financial aid..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Symon Holl: "“Thankfully, we have just started receiving financial aid..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerTradeWarHappened == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Symon Holl: "“Especially in the wake of...""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerTradeWarHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)

### Węzeł `[203]`
Mówca: **Symon Holl**
> "“Especially in the wake of...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Symon Holl: "...of this insane fucking trade war between Arcasia and U..."*)

### Węzeł `[204]`
Mówca: **Symon Holl**
> "“We need to put our economy and the recession at the forefront.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)

### Węzeł `[205]`
Mówca: **Symon Holl**
> "“Especially after...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Symon Holl: "“...after our entire fucking stock market went down the t..."*)

### Węzeł `[206]`
Mówca: **Symon Holl**
> "“I'm sorry for losing my cool, Mr. President. I have been working day and night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Symon Holl: "“I am currently attempting to minimize the damage this tr..."*)

### Węzeł `[207]`
Mówca: **Symon Holl**
> "“I'm sorry for losing my cool, Mr. President. I have been working day and night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Symon Holl: "“I am currently looking into ways to find out how we can ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "I'd never seen Symon this rattled. Everyone in the room turned to him in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Symon Holl: "“I'm sorry for losing my cool, Mr. President. I have been..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "I'd never seen Symon this rattled. Everyone in the room turned to him in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Symon Holl: "“I'm sorry for losing my cool, Mr. President. I have been..."*)

### Węzeł `[210]`
Mówca: **Symon Holl**
> "“I am currently attempting to minimize the damage this trade war will do to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: "“Be careful. Don't burn yourself out.”"*)
  - -> `[213]` (*Player: "“I am expecting good results, Symon. Do not fail me.”"*)
  - -> `[214]` (*Player: "“How is it looking? Is there a way out?”"*)

### Węzeł `[211]`
Mówca: **Symon Holl**
> "“I am currently looking into ways to find out how we can recover from this tragedy as quickly as we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: "“Be careful. Don't burn yourself out.”"*)
  - -> `[213]` (*Player: "“I am expecting good results, Symon. Do not fail me.”"*)
  - -> `[214]` (*Player: "“How is it looking? Is there a way out?”"*)

### Węzeł `[212]`
**[WYBÓR GRACZA: "“Be careful. Don't burn yourself out.”"]** — Mówca: **Player**
> "“Be careful. Don't burn yourself out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Symon Holl), `[211]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Symon Holl: "“I will do my best, but the future of Sordish citizens is..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“I am expecting good results, Symon. Do not fail me.”"]** — Mówca: **Player**
> "“I am expecting good results, Symon. Do not fail me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Symon Holl), `[211]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Symon Holl: "“I will not, Mr. President. The future of Sordish citizen..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“How is it looking? Is there a way out?”"]** — Mówca: **Player**
> "“How is it looking? Is there a way out?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Symon Holl), `[211]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Symon Holl: "“I do not want to say anything too early, Mr. President.”"*)

### Węzeł `[215]`
Mówca: **Symon Holl**
> "“I will do my best, but the future of Sordish citizens is at stake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[216]`
Mówca: **Symon Holl**
> "“I will not, Mr. President. The future of Sordish citizens is at stake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[217]`
Mówca: **Symon Holl**
> "“I do not want to say anything too early, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[218]`
Mówca: **Symon Holl**
> "“Thankfully, we have just started receiving financial aid from Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Iosef Lancea: "“And then what? We'll become their servants?""*)

### Węzeł `[219]`
Mówca: **Symon Holl**
> "“Thankfully, we have just started receiving financial aid from United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Iosef Lancea: "“I can't believe we're accepting financial aid from commu..."*)

### Węzeł `[220]`
Mówca: **Iosef Lancea**
> "“I can't believe we're accepting financial aid from communists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Iosef Lancea: "“What's next? Letting a child murderer buy us lunch?""*)

### Węzeł `[221]`
Mówca: **Iosef Lancea**
> "“And then what? We'll become their servants?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Iosef Lancea: "“First they will place their war planes in Erlory. Then t..."*)

### Węzeł `[222]`
Mówca: **Iosef Lancea**
> "“What's next? Letting a child murderer buy us lunch?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Iosef Lancea: "“Contanan war ships in Conriat! My father will be rolling..."*)

### Węzeł `[223]`
Mówca: **Iosef Lancea**
> "“First they will place their war planes in Erlory. Then their armies will come. You will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Iosef Lancea: "“I do not approve of this decision at all.”"*)

### Węzeł `[224]`
Mówca: **Iosef Lancea**
> "“Contanan war ships in Conriat! My father will be rolling in his grave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: "“I will not let you question my decisions, Iosef.”"*)
  - -> `[237]` (*Player: "“Don't be dramatic. We need to be friendly with our poten..."*)
  - -> `[234]` (*Player: "“Desperate times call for desperate measures.”"*)
  - -> `[236]` (*Player: "“I have done this with Sordish citizens in mind. Nothing ..."*)

### Węzeł `[225]`
Mówca: **Iosef Lancea**
> "“I do not approve of this decision at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: "“I will not let you question my decisions, Iosef.”"*)
  - -> `[229]` (*Player: "“Don't be dramatic. We need to be friendly with our poten..."*)
  - -> `[226]` (*Player: "“Desperate times call for desperate measures.”"*)
  - -> `[228]` (*Player: "“I have done this with Sordish citizens in mind. Nothing ..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Desperate times call for desperate measures.”"]** — Mówca: **Player**
> "“Desperate times call for desperate measures.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Iosef Lancea: "“That's how they take over countries, you know.”"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: "“I will not let you question my decisions, Iosef.”"]** — Mówca: **Player**
> "“I will not let you question my decisions, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Iosef Lancea: "“Yes, Mr. President.”"*)

### Węzeł `[228]`
**[WYBÓR GRACZA: "“I have done this with Sordish citizens in mind. Nothing else.”"]** — Mówca: **Player**
> "“I have done this with Sordish citizens in mind. Nothing else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Iosef Lancea: "“That's how they take over countries, you know.”"*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Don't be dramatic. We need to be friendly with our potential allies.”"]** — Mówca: **Player**
> "“Don't be dramatic. We need to be friendly with our potential allies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Iosef Lancea: "“Allies? Sordland has no allies and never did.”"*)

### Węzeł `[230]`
Mówca: **Iosef Lancea**
> "“Allies? Sordland has no allies and never did.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lileas Graf: "“Well said, Mr. Lancea. We can't be naive.”"*)

### Węzeł `[231]`
Mówca: **Iosef Lancea**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[232]`
Mówca: **Iosef Lancea**
> "“That's how they take over countries, you know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Lileas Graf: "“Mr. Lancea has a point. We have seen it happen many times.”"*)

### Węzeł `[233]`
Mówca: **Iosef Lancea**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Desperate times call for desperate measures.”"]** — Mówca: **Player**
> "“Desperate times call for desperate measures.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Iosef Lancea: "“That's how they take over countries, you know.”"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“I will not let you question my decisions, Iosef.”"]** — Mówca: **Player**
> "“I will not let you question my decisions, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Iosef Lancea: "“Yes, Mr. President.”"*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“I have done this with Sordish citizens in mind. Nothing else.”"]** — Mówca: **Player**
> "“I have done this with Sordish citizens in mind. Nothing else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Iosef Lancea: "“That's how they take over countries, you know.”"*)

### Węzeł `[237]`
**[WYBÓR GRACZA: "“Don't be dramatic. We need to be friendly with our potential allies.”"]** — Mówca: **Player**
> "“Don't be dramatic. We need to be friendly with our potential allies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Iosef Lancea: "“Allies? With those communists? I'd rather die.""*)

### Węzeł `[238]`
Mówca: **Iosef Lancea**
> "“Allies? With those communists? I'd rather die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lileas Graf: "“Well said, Mr. Lancea.”"*)

### Węzeł `[239]`
Mówca: **Iosef Lancea**
> "“That's how they take over countries, you know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lileas Graf: "“Mr. Lancea has a point. We have seen it happen many times.”"*)

### Węzeł `[240]`
Mówca: **Deivid Wisci**
> "“Gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Deivid Wisci: "“Can we please get back on topic?”"*)

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> "“Can we please get back on topic?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Symon Holl: "“Right. Sorry, Mr. Wisci.”"*)

### Węzeł `[242]`
Mówca: **Symon Holl**
> "“Right. Sorry, Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Deivid Wisci: "“As I was just saying before I was interrupted...”"*)

### Węzeł `[243]`
Mówca: **Lileas Graf**
> "“Well said, Mr. Lancea. We can't be naive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[244]`
Mówca: **Lileas Graf**
> "“Mr. Lancea has a point. We have seen it happen many times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[245]`
Mówca: **Lileas Graf**
> "“Well said, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[246]`
Mówca: **Lileas Graf**
> "“Mr. Lancea has a point. We have seen it happen many times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“Gentlemen.”"*)

### Węzeł `[247]`
Mówca: **Deivid Wisci**
> "“As I was just saying before I was interrupted...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deivid Wisci: "“Look at the superpowers. Do you see them closing off the..."*)

### Węzeł `[248]`
Mówca: **Symon Holl**
> "...of this insane fucking trade war between Arcasia and United Contana!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I'd never seen Symon this rattled. Everyone in the room t..."*)

### Węzeł `[249]`
Mówca: **Symon Holl**
> "“...after our entire fucking stock market went down the tubes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "I'd never seen Symon this rattled. Everyone in the room t..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesdayHappened == true || BaseGame.SuperpowerTradeWarHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesdayH..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesda..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesdayHappened == true || BaseGame.SuperpowerTradeWarHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -7  or  Variable["BaseGame.BlackTuesdayHappened"] == true  or  Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Inflation = true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesdayHappened == true || BaseGame.SuperpowerTradeWarHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -7  or  Variable["BaseGame.BlackTuesdayHappened"] == true  or  Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "We were in the middle of a meeting in the Palace about ou..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Inflation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Inflation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "We were in the middle of a meeting in the Palace about ou..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2; BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3; BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_IllegalImmigration = false"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_IllegalImmigration = false"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Tighten == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3; BaseGame.Bludish_Opinion -= 1;"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Tighten == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1; BaseGame.Bludish_Opinion -= 3;"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;
BaseGame.Bludish_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_IllegalImmigration = false"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_IllegalImmigration = false"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn04_InT_HighwayIssue_Solved == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true && BaseG..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn04_InT_HighwayIssue_Solved == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn04_InT_HighwayIssue_Solved == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_ImmigrationPolicy = true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn04_InT_RailwayIssue_Solved == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true && BaseG..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn04_InT_RailwayIssue_Solved == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn04_InT_RailwayIssue_Solved == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_FreedomEducation = true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true && BaseGame...."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_FreedomEducation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_FreedomEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true && BaseGame...."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = true;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatusAllCities("City_WidespreadProtests");  /..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_JohanGasmich = false; 
BaseGameSupport.Codex_Characters_Others_JohanGasmich_Arrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_JohanGasmich"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_JohanGasmich_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[276]`
Mówca: **Lileas Graf**
> ""I wouldn't worry about that too much. With how Wehlen is dealing with the Bludish terrorists, I would argue that President Smolak would beg us to tighten our immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lileas Graf: ""With that said, I don't fancy Wehlen as a partner since ..."*)

### Węzeł `[277]`
Mówca: **Lileas Graf**
> ""With that said, I don't fancy Wehlen as a partner since they are as reliable as a flopping fish out of water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“I'm against isolationism. It is the wrong path.”"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true && BaseGame.Policy_Diplomacy_TightenedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true && BaseGame...."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true && BaseGam..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true && BaseGame.Policy_Diplomacy_TightenedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true  and  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true && BaseGame.Policy_Diplomacy_TightenedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true  and  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true && BaseGame...."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true && BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true && BaseGame...."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Tighten == true && BaseGam..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true && BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Tighten == true && BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Kyrute_EmphasizesNeu..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true && BaseGame...."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Kyrute_EmphasizesNeu..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest <= 0"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest <= 0)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Deyr", "City_WidespreadP..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Deyr", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Deyr", "City_Lockdown");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_Lockdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The ensuing discussion quickly became heated."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_BFFSanct..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest <= 0"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_BFFSanctuaries");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_BFFSanctuaries");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Uziren", "City_BFFSanctu..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Uziren", "City_BFFSanctuaries");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Uziren","City_BFFSanctuaries");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest <= 0"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Erzaren_ReligiousRallyAgainstSordland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Erzaren_ReligiousRallyAgainstSordland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Nationwide_Protests = false; Bas..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerTradeWarHappened == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn05_ATO_CritiquesTradeWa..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerTradeWarHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn05_ATO_CritiquesTradeWar = true; BaseGameSupport.FactionReport_Turn05_CSP_DefendsTradeWar = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn05_ATO_CritiquesTradeWar"] = true;
Variable["BaseGameSupport.FactionReport_Turn05_CSP_DefendsTradeWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn05_Kyrute_EmphasizesNeutralityValue = true; BaseGameSupport.CountryReport_Turn05_Valgsland_CautionsAgainstPrivatization = true;
BaseGameSupport.Report_Turn05_Holsord_CBRProposal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Kyrute_EmphasizesNeutralityValue"] = true;
Variable["BaseGameSupport.CountryReport_Turn05_Valgsland_CautionsAgainstPrivatization"] = true;
Variable["BaseGameSupport.Report_Turn05_Holsord_CBRProposal"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatusAllCities("City_WidespreadProtests");

// Removes given token status from ALL cities`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatusAllCities("City_WidespreadProtests");
-- Removes given token status from ALL cities;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -7 || BaseGame.BlackTuesdayH..."*)
