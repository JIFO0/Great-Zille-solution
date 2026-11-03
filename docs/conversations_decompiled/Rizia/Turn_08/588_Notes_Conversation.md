# Rizia/Turn 8/Notes/Notes Conversation

- **ID konwersacji:** `588`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/588_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 520
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Situation_Diplomacy_Pales_ATAActive`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation`
- `RiziaDLC.Turn05_Security_InvestigateBombingWehlen`
- `RiziaDLC.Zille_ViolentResistancePower`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus`

### Skoki między-konwersacyjne:
- Węzeł `[49]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[550]`
- Węzeł `[113]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[889]`
- Węzeł `[174]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[889]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 30
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[50]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus"] = true;`
- Węzeł `[140]` (Paskal Beniwoll): `AddConversant("Lucita Azaro"); AddConversant("Titus Gordion");`
- Węzeł `[175]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[230]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[274]` (Paskal Beniwoll): `AddConversant("Lucita Azaro");`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Despite the lack of immediate leads, I wasn’t convinced that it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> ""My instincts told me there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[5]`
Mówca: **Lucita Azaro**
> ""One of my operatives managed to get in deep with a record keeper in the forensics department of Wehlen's Security Ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[6]`
Mówca: **Lucita Azaro**
> ""This man was rather unhappy with his current situation and was... susceptible to persuasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""After some delicate negotiations and the promise of a better life elsewhere, he agreed to help us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`
  - -> `[8]`
  - -> `[381]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Persuasion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""We knew Wehlen’s databases were extensive, but rarely do they go back more than a decade in their routine checks. This was the key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[11]`
  - -> `[21]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what did they find?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Sure enough, after some thorough searching, our contact found a match. The fingerprints we discovered at the bombing scene matched those of a man named Viktor Karnov.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Lucita Azaro**
> ""He was arrested over 25 years ago for disorderly conduct and public intoxication. He was only 16 years old.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[19]`
  - -> `[14]`
  - -> `[18]`
  - -> `[392]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov? Should I know who that is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""Indeed, Your Majesty. Viktor Karnov is a well-known spy for Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Stationed at their consulate in Zille, he’s been operating under the radar for years, seamlessly blending into various roles and avoiding detection.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So who is he and why is he important?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A part of me secretly wonders what it would be like to be arrested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Enough with the generalities. I need specifics. What exactly did your operative find that we don’t already know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work. I’m curious to know more about what was discovered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, the good old carrot-and-stick approach. It seems we’ve managed to find a willing ally with a little incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes, the promise of a better future is all that's needed to turn the tide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't say I condone such actions, but I suppose if it achieves the desired results, I can look the other way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[28]`
Mówca: **Titus Gordion**
> ""Despite the lack of immediate leads from the fingerprints that were found at the scene, I wasn’t convinced it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[29]`
  - -> `[73]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you find?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Titus Gordion**
> ""I had a gut feeling that there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[31]`
Mówca: **Titus Gordion**
> ""One of my operatives gained access to Wehlen's Security Ministry by infiltrating a network of underground informants and black-market traders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""We'd previously identified a group of smugglers operating within Wehlen who occasionally dealt in sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Titus Gordion**
> ""My operative, Alexei, posed as a buyer interested in acquiring documents for a fictitious political rival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[67]`
  - -> `[34]`
  - -> `[72]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, they took him at his word?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Titus Gordion**
> ""Alexei’s cover was impeccable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[36]`
Mówca: **Titus Gordion**
> ""In any case, he gained their trust and managed to acquire a trove of documents, including detailed forensic records from the Security Ministry’s archives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[37]`
  - -> `[71]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what did they find?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[38]`
Mówca: **Titus Gordion**
> ""After meticulously combing through the records, we found a match for the fingerprints belonging to a man named Viktor Karnov.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Titus Gordion**
> ""He was arrested over 25 years ago for disorderly conduct and public intoxication, which made him 16 years old at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[43]`
  - -> `[40]`
  - -> `[409]`
  - -> `[411]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov? Should I know who that is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[41]`
Mówca: **Titus Gordion**
> ""Viktor Karnov is a well-known spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[42]`
Mówca: **Titus Gordion**
> ""Based at their consulate in Zille, he’s been operating under the radar for years, effortlessly blending into various roles and evading detection.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov... Viktor Karnov... Nope. Doesn't ring a bell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Titus Gordion**
> ""If your memory serves you well, he was the young man I sparred with at our first official meeting after your ascension to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[48]`
Mówca: **Narrator**
> "We took a seat around the council table. Titus handed each of us a large file, its contents nearly overflowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GGBombResult_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `409` (*Rizia/Turn 8/SnO_SecurityBriefAndZille*), Węzeł `[550]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I snapped back to reality upon entering the council room, reminded that I was there for a security briefing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Titus, ever the punctual one, was already present. And he wasn't alone. He was overseeing two men in uniform setting up a film projector and screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Titus Gordion**
> ""There you are, Your Majesty. I'm pleased to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
Mówca: **Narrator**
> "The three men, one by one, bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Titus Gordion**
> ""As the new Royal Councilor of War and Internal Security for Rizia, I want to express my eternal gratitude for the trust you've bestowed upon me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Titus, ever the punctual one, was already present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He bowed respectfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent work. It requires great skill to execute such an infiltration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Alexei covered his tracks thoroughly. The last thing we need is Wehlen uncovering our involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds a bit far-fetched, but go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A trove, huh? Alright, let's see them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope these documents are genuine, or there will be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s fascinating how the shadows of society can reveal the most vital information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Titus Gordion**
> "“It goes without saying that the Friendship Day bombing has complicated matters regarding Zille's reunification with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""However, what we've uncovered could be the breakthrough that tilts the situation back in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""As you know, you tasked me with investigating further into the possibility that Wehlen was responsible for the bombing.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Even though the fingerprints found at the scene, provided by Wehlen, didn't give us any immediate leads, I still wasn’t convinced it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[29]`
  - -> `[418]`

### Węzeł `[82]`
Mówca: **Taddeus Azaro**
> ""As everyone here knows, I was tasked with resuming the foreign intelligence investigation into the infamous Friendship Day bombing in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[83]`
Mówca: **Narrator**
> "We all took our places around the council table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Taddeus Azaro**
> ""As previously uncovered, my department identified material from the bomb site that came straight from CircuitRise Systems in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[88]`
Mówca: **Taddeus Azaro**
> ""Upon further investigation, we managed to identify the man responsible for obtaining the material in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Taddeus opened a large file folder he had brought in and handed out photos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""We've narrowed it down to a man by the name of Aurelio Iturriaga who worked as a Chief Operations Officer at CircuitRise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""Mr. Iturriaga exploited his exclusive access to tamper with inventory records, concealing the disappearance of vital materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""He manipulated dates, quantities, and descriptions, creating a deceptive trail to obscure his actions from scrutiny. Or so he believed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`
  - -> `[93]`
  - -> `[98]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is excellent news. What of his present whereabouts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, his trail ran cold. Any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Taddeus Azaro**
> ""To put it plainly, we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well... quite the diligent individual, I must say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work, General. We're finally getting closer to uncovering the truth behind this ordeal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So there is a culprit? He must be found and punished immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A dead end? Unacceptable! We can't afford setbacks like this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, General. It's a challenging situation. There's only so much you could have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's just great. Can we expect anything different at this point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, General. This is a setback we can ill afford.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""That's one way of putting it. That said...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""Thank you. Unfortunately, any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[105]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, that's as far as we got. Any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""I understand, Your Majesty. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Taddeus Azaro**
> ""No, Your Majesty. Not until new information presents itself. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Taddeus Azaro**
> ""I wish there was more I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Taddeus Azaro**
> ""Thank you for understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Narrator**
> "The General nodded slightly, indicating his agreement, before gathering his files."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""If any new information comes to light, then I will pursue it with great diligence. But until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""Well, if there's nothing more to discuss regarding the investigation, General, let's move on to the issue of Zille's impending reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ZilleUpdate_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `409` (*Rizia/Turn 8/SnO_SecurityBriefAndZille*), Węzeł `[889]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Unfortunately, there isn't a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Titus Gordion**
> ""Unfortunately, I don't have a significant update to offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Accessing necessary facilities and conducting interviews has proven challenging due to heightened security protocols related to the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Additionally, we've had to divert a sizeable amount of intelligence resources towards the war effort, limiting how much we can achieve in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this won't take too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[205]`
  - -> `[201]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Always a pleasure to be here. So, what have you got for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's skip the pleasantries and get to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[201]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""Yes. Understood, sir. Lucita?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[139]`
Mówca: **Narrator**
> "I had come to receive the latest updates on the situation in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[135]`
  - -> `[134]`
  - -> `[136]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");
AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Upon entering the council room, I found Titus and Lucita. They were awaiting my arrival, promptly rising from their seats when they noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Titus Gordion**
> ""I will strive for brevity, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please... try to contain your excitement. What pressing matters await my ears today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""Thank you, Titus. As you know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, you know me, always eager to dive into the riveting world of bureaucratic discussions. Well, let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[205]`
  - -> `[201]`

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Then I will get us started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Lucita Azaro**
> ""As you already know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""Hello, Your Majesty. I'm glad you could join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Lucita's words jolted me back to the present moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""But before we do, we should go over our final findings regarding the Friendship Day bombing incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[155]`
  - -> `[158]`

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""I hate to say it, but unfortunately, there isn't a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Final findings?' I'm not sure I like the sound of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I've been looking forward  to settling this matter once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""As have I, however, you may not like what you're about to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do I have a bad feeling about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[159]`
Mówca: **Lucita Azaro**
> ""I'm afraid your intuition is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""Accessing necessary facilities and conducting interviews in Pales has been challenging due to heightened security and restricted movement in the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Additionally, communication channels have been disrupted, making it difficult to gather firsthand information from sources within Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> "'I hate to say it, but I'm afraid we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[165]`
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean a dead end? This is unacceptable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, Lucita. It's a challenging situation. There's only so much you could have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, isn't that just peachy... Can we anticipate any changes in the situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, Lucita. This is a setback we can ill afford.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""Believe me, I understand completely. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""No, Your Majesty. Not until new information comes to light, if ever. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Lucita Azaro**
> ""Thank you for understanding, Your Majesty. I wish there was more I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""I truly wish there was more I could do. But my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""If any new information comes to light, I will pursue it with great diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Titus Gordion**
> ""Well, if there's nothing left to discuss regarding this matter, I suggest we move on to the issue of Zille's impending reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Lucita nodded slightly, indicating her agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ZilleUpdate_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `409` (*Rizia/Turn 8/SnO_SecurityBriefAndZille*), Węzeł `[889]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Titus Gordion**
> ""Hello, sir. I'm glad you could join me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Titus' words jolted me back to the present moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Upon entering the council room, I found Titus awaiting my arrival. He promptly rose from his seat when he noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Yes. Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""As you know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, Titus. It's a challenging situation. There's only so much you could have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, Titus. This is a setback we can ill afford.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""No, sir. Not until new information comes to light, if ever. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[187]`
Mówca: **Titus Gordion**
> ""I wish there was more I could do. But my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Titus Gordion**
> ""If any additional information comes to light, I will pursue it with great diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[189]`
Mówca: **Titus Gordion**
> ""I completely understand, sir. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[193]`
Mówca: **Lucita Azaro**
> ""Although you asked us to investigate Wehlen's potential involvement further, since the onset of the Pales conflict, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Although you asked us to investigate Pales' potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[195]`
Mówca: **Titus Gordion**
> ""Although you asked the Duchess to investigate Wehlen's potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Although you asked us to investigate Pales' potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[197]`
Mówca: **Titus Gordion**
> "'Thanks. I do wish I could have more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[204]`
Mówca: **Titus Gordion**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""As you already know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""But before we do, we should review the final findings of my continuation of Duchess Azaro's investigation into the Friendship Day bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[155]`
  - -> `[158]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""Same. Although, you may not like what you're about to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[223]`
Mówca: **Titus Gordion**
> ""Your intuition seems to be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[224]`
Mówca: **Titus Gordion**
> ""Unfortunately, I don't have a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[225]`
Mówca: **Titus Gordion**
> ""Accessing facilities and conducting interviews in Pales has proven challenging due to heightened security measures and restricted movement in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Titus Gordion**
> ""Additionally, communication channels have been disrupted, making it difficult for them to gather firsthand information from sources within Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Titus Gordion**
> ""As much as I hate to say it, I'm afraid we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[165]`
  - -> `[163]`
  - -> `[184]`

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""I understand your apprehension, but I can assure you that our findings bring promising developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""You won't hear it. You'll see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[234]`
Mówca: **Narrator**
> "Sitting at the head of my council room table, I again checked the time on the wall-mounted timepiece."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Narrator**
> "It was fifteen past three. Lucita was late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Narrator**
> "I was here to be briefed on the latest updates on Zille, but it was beginning to look like a postponement was in order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Narrator**
> "Titus, punctual as usual, stood nearby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[246]`
  - -> `[238]`
  - -> `[248]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“It’s unusual for Lucita to keep us waiting like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Titus Gordion**
> "“Quite uncharacteristic of her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Just as my eyes were beginning to veer toward the clock once more, the doors opened, and Lucita hurried in, clutching a folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[241]`
Mówca: **Narrator**
> "Two men in military uniforms followed her, pushing a film projector into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Narrator**
> "The trio's entrance spoke of urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[271]`
  - -> `[243]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Where have you been?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Lucita Azaro**
> "“My apologies, Your Majesty. Urgent matters delayed my arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I'll believe that when I hear it, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita did say she'd be here, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems Lucita is fashionably late to her own council meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't suppose you know what Lucita intended to discuss today, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. So glad you could finally join us. I was beginning to think you got lost in the maze of palace corridors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? Then please proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "Remain silent."]** — Mówca: **Player_Romus_Italic**
> "I remained silent, my cue for her to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hope this doesn't devolve into a wild goose chase, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita signaled to the men, who began setting up the film projector."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""Please forgive me, Your Majesty. I had urgent matters to attend to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
Mówca: **Lucita Azaro**
> ""Please excuse my late arrival, Your Majesty. Urgent matters demanded my attention elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""My apologies, Your Majesty. I was unavoidably detained by pressing matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""Suffice it to say we've had a breakthrough in the Friendship Day bombing case. A big one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[251]`
  - -> `[245]`
  - -> `[252]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> "“Thank you. Gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""It won't. I can promise you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[264]`
Mówca: **Lucita Azaro**
> ""I promise it won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. So glad you could finally join us. I was beginning to think you weren't coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's pray this doesn't veer into a wild goose chase, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[267]`
Mówca: **Narrator**
> "The sound of a ticking clock snapped me back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""As far as I know. I'm just as surprised by her absence as you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""Unfortunately, no. Only the general assessment of the situation regarding Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""It's unlike her to keep us waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[271]`
  - -> `[243]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Narrator**
> "Lucita opened her folder and distributed the documents within it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""As previously uncovered, my department identified material from the bomb site that came directly from CircuitRise Systems in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""And given your orders focus the investigation on Wehlen, nothing further has come from that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""But to our surprise, a piece of evidence we had nearly dismissed has turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[288]`
  - -> `[290]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That being?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds promising. I want to hear every detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What’s this evidence, and how does it shift our entire investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""The fingerprints found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[292]`
Mówca: **Lucita Azaro**
> ""The fingerprints Wehlen provided that were found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[293]`
Mówca: **Titus Gordion**
> ""Your concern is understandable, but I assure you that our findings bring promising news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""Unfortunately, your instincts are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[295]`
Mówca: **Titus Gordion**
> ""I hate to say it, but your instincts are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""Not much, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""The contact was on a train in Zille to meet up with my operative at a secret beachside rendezvous. On his way there, the train derailed, and he was killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Lucita Azaro**
> ""Apparently, Su Omina sabotaged the train to hinder Wehlen's logistics. It seems they were trying to disrupt any efforts to uncover information that could be damaging to their interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[308]`
  - -> `[302]`
  - -> `[307]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, we lost our lead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. An unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it was a mistake to enable Su Omina operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's disappointing news. My condolences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So it was all for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Titus Gordion**
> ""As previously uncovered, the Golden Guard identified material from the bomb site that came directly from TerraGrowth Agrochem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""And since your orders directed us to focus the investigation on Wehlen, no further progress has been made on that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""However, much to our surprise, a piece of evidence we had nearly dismissed has turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[288]`
  - -> `[290]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false 
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[319]`
Mówca: **Lucita Azaro**
> ""The fingerprints Wehlen claimed they found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""Turns out, they do exist and we were able to get our hands on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[321]`
Mówca: **Titus Gordion**
> ""Despite the absence of immediate leads, I wasn’t convinced that it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Titus Gordion**
> ""My gut told me there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false 
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""The fingerprints that were found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[330]`
Mówca: **Titus Gordion**
> ""The fingerprints that Wehlen claimed to have found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Titus Gordion**
> ""Turns out, they do exist and we were able to get our hands on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[332]`
Mówca: **Titus Gordion**
> ""The fingerprints Wehlen supplied, found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""One of my operatives managed to gain access to Wehlen's Security Ministry by infiltrating an underground network of informants and black-market traders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""We had previously identified a group of smugglers operating within Wehlen who occasionally dealt in sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""My operative, Alexei, posed as a buyer seeking documents for a made-up political rival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[347]`
  - -> `[342]`
  - -> `[346]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. Alexei’s cover was impeccable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Titus Gordion**
> ""In any case, he earned their trust and secured a trove of documents, including detailed forensic records from the Security Ministry’s archives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[350]`
  - -> `[349]`
  - -> `[352]`

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""If you recall, he was the young man I sparred with at our first official meeting following your ascension to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s fascinating how the shadows of society can yield the most crucial information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work. It takes a lot of skill to pull off such an infiltration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Alexei covered his tracks well. The last thing we need is Wehlen discovering our involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what exactly did they find?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where are these documents now?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A trove, eh? Alright, let's see them.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s not waste time. Bring those documents to me so I can examine them.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[38]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
Mówca: **Titus Gordion**
> ""A regrettable turn of events, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Titus Gordion**
> ""After Alexei acquired the documents, he arranged to meet with another operative to hand over the evidence in a remote location.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Titus Gordion**
> ""However, on his way there, Alexei happened to be in the wrong place at the wrong time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[359]`
  - -> `[361]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Titus Gordion**
> ""I assure you, it was anything but convenient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Titus Gordion**
> ""Su Omina militants had planned an attack on a convoy of Wehlen supporters who want Zille to stay with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Titus Gordion**
> ""When Alexei's car approached, it was caught in the crossfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Titus Gordion**
> ""The militants, not distinguishing between targets, attacked and destroyed his vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Titus Gordion**
> ""Alexei was killed instantly, and the documents were destroyed in the explosion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So, we lost our lead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[368]`
Mówca: **Titus Gordion**
> ""It was a tragic coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[367]`
  - -> `[370]`
  - -> `[401]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So you're saying this was all for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's disappointing news. My condolences to your operative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""I was just getting there, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[378]`
Mówca: **Lucita Azaro**
> ""But to our surprise, a piece of evidence we had nearly dismissed almost turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[289]`
  - -> `[288]`
  - -> `[290]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the sound of this. What evidence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[380]`
Mówca: **Titus Gordion**
> ""However, a piece of evidence we had nearly dismissed nearly turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[289]`
  - -> `[288]`
  - -> `[290]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[384]`
Mówca: **Lucita Azaro**
> ""Rightly, so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Lucita Azaro**
> ""My operative managed to coerce him into digging deeper into their archives, far beyond the usual scope of their investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""Spy-craft 101.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. It was an unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""An unfortunate turn of events. Yet, despite this setback, Su Omina could still be crucial to the success of Zille’s return.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
Mówca: **Lucita Azaro**
> ""While we may not have come to the desired conclusion, Su Omina's mistake is a lesson on how to refine our strategies and improve our approach to future operations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like my kind of guy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[395]`
Mówca: **Lucita Azaro**
> ""He's a known spy for Lespia. That's who he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[396]`
Mówca: **Lucita Azaro**
> ""It involves a lot of paperwork and fewer royal privileges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[397]`
Mówca: **Lucita Azaro**
> ""Let's hope you never have the pleasure of meeting him under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[398]`
Mówca: **Titus Gordion**
> ""Believe me, Alexei is the best of the best in covert operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[399]`
Mówca: **Titus Gordion**
> ""Alexei took all necessary measures to ensure his activities remain undetected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[400]`
Mówca: **Titus Gordion**
> ""A reminder of the importance of exploring every angle, even those that seem obscure or inconsequential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew enable Su Omina operations in ZIlle was a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[402]`
Mówca: **Titus Gordion**
> ""I wouldn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[403]`
Mówca: **Titus Gordion**
> ""I'm afraid so, sir.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Thank you, sir. It was a most unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[405]`
Mówca: **Titus Gordion**
> ""An unfortunate turn of events. However, despite this setback, Su Omina could still be crucial to the success of Zille’s return.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[406]`
Mówca: **Titus Gordion**
> ""Although we didn't acquire the desired result, Su Omina's mistake teaches us how to refine our strategies and enhance our approach to future operations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Titus Gordion**
> ""It just so happens that Viktor Karnov is a well-known spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[409]`
**[WYBÓR GRACZA: "Wait for Titus to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for Titus to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha! Sounds like my kind of guy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
Mówca: **Titus Gordion**
> ""Let’s hope you never have the misfortune of meeting him under such circumstances. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[415]`
Mówca: **Titus Gordion**
> ""Viktor Karnov is a noted spy for Lespia, though his activities are not widely publicized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""For Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yes. I'd nearly forgotten all about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like your instincts were spot on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[419]`
Mówca: **Titus Gordion**
> ""He took all necessary measures to ensure that his activities remain undetected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[420]`
Mówca: **Titus Gordion**
> ""I assure you, Alexei is the best of the best in covert operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[421]`
Mówca: **Titus Gordion**
> ""A reminder of the importance of exploring every angle, even those that seem obscure or inconsequential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[422]`
Mówca: **Titus Gordion**
> ""No doubt, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[423]`
Mówca: **Taddeus Azaro**
> ""However, any progress that *was* made regarding their possible involvement was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[424]`
Mówca: **Taddeus Azaro**
> ""And since your orders directed us to focus the investigation on Wehlen, no further progress has been made on that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true  ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""Thanks to our new foreign intelligence hub, we achieved this despite my department's limited resources due to the war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""Good. You'll be pleased with the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Titus Gordion**
> ""Good. You'll be satisfied with what we've discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""Unfortunately, the final findings are troubling and may complicate matters further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[447]`
Mówca: **Titus Gordion**
> ""Regrettably, the final findings are troubling and could complicate matters further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""With the support of our new foreign intelligence hub, we accomplished this despite my department's limited resources due to the war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""Good. I have no doubt you'll be pleased with the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Titus Gordion**
> ""I believe you'll be satisfied with what we've discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[457]`
Mówca: **Narrator**
> "Lucita leaned across the table to turn on the intercom and speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Lucita Azaro**
> ""Send them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[459]`
Mówca: **Titus Gordion**
> ""Despite the limited resources due to the war in Pales, we succeeded thanks to our new foreign intelligence hub.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[460]`
Mówca: **Narrator**
> "Titus leaned across the table to turn on the intercom and speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[461]`
Mówca: **Titus Gordion**
> ""Send them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[462]`
Mówca: **Narrator**
> "The council room doors opened, and two men in military uniforms entered, wheeling in a film projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A motion picture to support your findings?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it have to do with a film projector?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, a movie? How delightful. Is popcorn included, or do I need to bring my own?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[466]`
Mówca: **Narrator**
> "The doors to the council room opened, and two men in military uniforms wheeled in a film projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Narrator**
> "They began setting it up at the front of the room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`
  - -> `[463]`
  - -> `[465]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Titus Gordion**
> ""I understand your concern, but I can assure you that you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[481]`
Mówca: **Lucita Azaro**
> ""I wish I had better news, but I'm afraid the conclusions we've reached will not be what you hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[482]`
Mówca: **Titus Gordion**
> ""I wish I had better news, but the conclusions we've reached will not be what you hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[483]`
Mówca: **Lucita Azaro**
> ""I understand your concern, but I believe you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Titus Gordion**
> ""I understand your concern, but I can  assure you that you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""I understand your concern, but I know you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[516]`
Mówca: **Lucita Azaro**
> ""I understand your apprehension, but I assure you that our findings reveal promising developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[517]`
Mówca: **Titus Gordion**
> ""Your concern is understandable, but I assure you that our findings reveal promising news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: TitusWehlenInvestigation_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [TitusWehlenInvestigation_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GGBombResult_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
