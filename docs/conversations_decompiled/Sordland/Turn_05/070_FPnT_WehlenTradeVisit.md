# Sordland/Turn05/FPnT_WehlenTradeVisit

- **ID konwersacji:** `70`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/070_FPnT_WehlenTradeVisit.md`
- **Liczba węzłów dialogowych:** 335
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[17]** Wiktor Smolak

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Economy_Bergia`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_CoalitionIntervention`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGame.Situation_Military_MilitaryInterventionWehlen`
- `BaseGame.Situation_Military_Wehlen_BorderDefence`
- `BaseGame.Sollist`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`
- `BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal`
- `BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom`
- `BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenFailed`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenSigned`
- `BaseGameSupport.News_Turn05_HP_WehlenDeal`
- `BaseGameSupport.News_Turn05_R_WehlenCoop`
- `BaseGameSupport.Report_Turn05_Narbel_DetainReport`
- `BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport`
- `GameCondition.Turn05_FPnT_WehlenTradeVisit`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 46

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Bergia`
- `BaseGame.GovernmentBudget`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGame.Sollist`
- `BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[94]` (Serge Wolkner): `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] = true;`
- Węzeł `[214]` (Serge Wolkner): `Variable["GameCondition.Turn05_FPnT_WehlenTradeVisit"] = true;`
- Węzeł `[215]` (Serge Wolkner): `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true; Variable["BaseGameSupport.J...`
- Węzeł `[216]` (Serge Wolkner): `Variable["BaseGame.Wehlen_TradeDeal"] = true; Variable["BaseGame.Wehlen_JointOperation"] = true; ...`
- Węzeł `[227]` (Serge Wolkner): `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true;`
- Węzeł `[228]` (Serge Wolkner): `Variable["BaseGame.Wehlen_DefendBorder"] = true; Variable["BaseGame.Wehlen_TradeDeal"] = true; Va...`
- Węzeł `[231]` (Serge Wolkner): `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] = true; Variable["BaseGame.Policy_Dip...`
- Węzeł `[232]` (Serge Wolkner): `Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = true; Variable["BaseGame.Situat...`
- *...oraz 38 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordland One's flight from Holsord to Wraclawitz took approximately five hours. Despite heavy turbulence, I managed to sleep a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Symon, Deivid and I landed at the international airport of the capital city of Wehlen. Our aim here was to finalise the trade deal drafted between Sordland and Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Our plane landed, and the door opened. The sun blinded me for a moment. I stepped outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I saw the soldiers lined up on either side of a red carpet. There must've been at least a hundred of them. A marching band started playing and the soldiers immediately saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Nice to see you, Mr. President.”"]** — Mówca: **Player**
> "“Nice to see you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "Salute the soldiers."]** — Mówca: **Player_Italic**
> "I saluted the soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "Proceed to the red carpet without any gestures."]** — Mówca: **Player_Italic**
> "I walked downstairs and proceeded without any gestures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "At the bottom of the stairs, Wiktor Smolak was waiting for me next to a military jeep with a few soldiers by his side. There were a few reporters at the edge of the crowd, waiting with their cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "He was a tall man, almost as tall as me. He was wearing large sunglasses and a regular suit, contrasting with the military attire of everyone else in the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Wiktor Smolak**
> "“Mr. President. Welcome to Wraclawitz.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He immediately motioned for an embrace. We hugged and many cameras went off at the same time. He turned around for a couple of additional poses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[15]`
  - -> `[14]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Thank you for inviting us.”"]** — Mówca: **Player**
> "“Thank you for inviting us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Pull him aside for a couple of more poses yourself."]** — Mówca: **Player_Italic**
> "I pulled him aside for a couple of more poses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Wiktor Smolak**
> "“Now that the pleasantries are done, let's go! We will take the jeep for a tour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "With another tune from the marching band, we boarded the military jeep. He sat in the driver's seat and I sat next to him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "As we started speeding up, the soldiers saluted again. Wiktor saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Salute the soldiers."]** — Mówca: **Player_Italic**
> "I saluted the soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Wiktor Smolak**
> "“We will first go to the city center to see the unveiling of a statue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Both of our security details started following us immediately, along with a team of reporters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Whose statue?”"]** — Mówca: **Player**
> "“Whose statue?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Sounds ...exciting.”"]** — Mówca: **Player**
> "“Sounds ...exciting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I'd rather not waste time. Let's get straight to business.”"]** — Mówca: **Player**
> "“I'd rather not waste time. Let's get straight to business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Wiktor Smolak**
> "“Ah, Mr. President. I must insist. Also, I am in the driver's seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Wiktor Smolak**
> "“This is an important occasion for Wehlen. I am sure you will like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Wiktor Smolak**
> "“Mine, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "We kept making small talk about the flight and the weather as we made our way towards the city center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "On almost every corner, there were reporters taking photos of us. Aside from them, though, the streets seemed completely empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[35]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Is Wraclawitz always this empty?”"]** — Mówca: **Player**
> "“Is Wraclawitz always this empty?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Is this all a big photo op for you?”"]** — Mówca: **Player**
> "“Is this all a big photo op for you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Wiktor Smolak**
> "“I had this part of the city close down because of your visit so that you could enjoy the city in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Wiktor Smolak**
> "“It is a good opportunity to show the world our unity in Eastern Merkopa. We must display our unified strength to Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“How long is this going to take?”"]** — Mówca: **Player**
> "“How long is this going to take?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Wiktor Smolak**
> "“Patience is a virtue. We will be done soon, and then we can discuss our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Wiktor Smolak**
> "“There we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "We arrived at the center. In the middle of a large plaza, there was a covered statue. Large crowds of people were gathered behind fences. waving both Sordland and Wehlen flags. Wiktor waved back at them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Wiktor Smolak**
> "“My people have been very supportive of this visit, Mr. President. I am sure you are delighted to see them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "A man came closer to the fences and started yelling at Wiktor. With my limited knowledge of the Wehzek language, I understood the words 'Wiktor' and 'murderer'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Almost instantaneously, two soldiers came up from behind the man and he was taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Wiktor Smolak**
> "“Thankfully the sun is out. Today will be a good day for the reveal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“I see that you know how to handle dissidents. Very good.”"]** — Mówca: **Player**
> "“I see that you know how to handle dissidents. Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“What will happen to the man who was protesting you?”"]** — Mówca: **Player**
> "“What will happen to the man who was protesting you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Wiktor Smolak**
> "“Oh, which man? That one in the crowd?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Wiktor Smolak**
> "“Don't worry about the details. He must've been a troubled fellow. Let's focus on the event.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Wiktor Smolak**
> "“I am glad you approve. We are of the same mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Wiktor Smolak**
> "“See, I knew we would get along fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Wiktor Smolak**
> "“Let's take our places.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "We took our places in front of the statue. With a drumroll, the statue of Wiktor Smolak was uncovered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "It was a fairly good likeness, albeit more muscular than the real Wiktor. He was wearing a cloak and holding a sword in his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Wiktor Smolak**
> "“Excellent statue. Very lifelike. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Our artists can do better in Sordland.”"]** — Mówca: **Player**
> "“Our artists can do better in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Yes, it's very good. Very lifelike.”"]** — Mówca: **Player**
> "“Yes, it's very good. Very lifelike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Mr. Smolak, I don't have time for these games. Let's get straight to the business.”"]** — Mówca: **Player**
> "“Mr. Smolak, I don't have time for these games. Let's get straight to the business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Wiktor Smolak**
> "“Don't worry. We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Wiktor Smolak**
> "“Glad you appreciate the art behind it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Narrator**
> "His face soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Wiktor Smolak**
> "“Well...then I'd like to contact one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "He turned to the soldiers and started yelling at them in Wehzek. The soldiers covered the statue again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Wiktor Smolak**
> "“Join me for a walk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Narrator**
> "I followed him through the streets. At every corner, more and more photos were taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "We stopped in front of a pastry vendor on the street."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Wiktor Smolak**
> "“Give me two strudels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The man behind the stand smiled and gave us two strudels."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[67]`
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "Pay the street vendor."]** — Mówca: **Player_Italic**
> "I put my hand on my wallet and brought up some money to give the vendor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Are you going to pay for it?”"]** — Mówca: **Player**
> "“Are you going to pay for it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wait for him to pay the street vendor."]** — Mówca: **Player_Italic**
> "I waited for him to pay the street vendor. He simply took the two strudels and didn't pay anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[67]`
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Wiktor Smolak**
> "“Of course, Mr. Rayne! Smolak's got your back!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Wiktor Smolak**
> "“Hold up. Your money doesn't count here. I got this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He handed the money to the street vendor with a huge smile on his face. The cameras flashed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Italic**
> "I kept walking alongside Wiktor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Afterwards, we walked a short distance to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Passing the gates, we made our way into the main building made from ivory-colored stones. The old guard towers flanked the magnificent structure from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The inside of the palace was very spacious, with a very large chandelier hanging from the ceiling. Grand staircases made from the same ivory stone had red carpets on them. On the upper levels, guards stood wearing the traditional outfits of the old Wehzek kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "We finally reached the office of the President of Wehlen. The door closed behind us. I looked around at the golden ornaments on the walls and the various jewel-encrusted artifacts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "As it was customary in Wehlen, we sat down on the carpet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Wiktor Smolak**
> "“Now we can talk about our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Finally.”"]** — Mówca: **Player**
> "“Finally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Wiktor Smolak**
> "“But before that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "He clapped his hands twice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Wiktor Smolak**
> "“Bring the Khisha.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "A few assistants immediately entered the room, carrying a large ornamented Khisha, the well-known smoking instrument originating from Wehlen. They immediately lit it up and the room was filled with the smell of tobacco."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Wiktor inhaled the smoke and handed me the Khisha."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[87]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Partake."]** — Mówca: **Player_Italic**
> "I inhaled the smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I don't smoke.”"]** — Mówca: **Player**
> "“I don't smoke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Wiktor Smolak**
> "“Your loss. It's the finest tobacco in the land.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Wiktor Smolak**
> "“So... Mr. President. Bah, that's too long. Can I call you Anton?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Narrator**
> "He took another puff, filling the room with more smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“I prefer my official title.”"]** — Mówca: **Player**
> "“I prefer my official title.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Sure.”"]** — Mówca: **Player**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Wiktor Smolak**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Wiktor Smolak**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Wiktor Smolak**
> "“Tell me. What do you really think about Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[102]`
  - -> `[104]`
  - -> `[124]`

### Węzeł `[98]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[101]`
Mówca: **Wiktor Smolak**
> "“I know you have put an embargo on Rumburg, and I congratulate you for standing up to them. But let me ask you a question. What do you really think about Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[102]`
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“They are a threat to the region.”"]** — Mówca: **Player**
> "“They are a threat to the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“A barking dog doesn't bite.”"]** — Mówca: **Player**
> "“A barking dog doesn't bite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“They can go to hell!”"]** — Mówca: **Player**
> "“They can go to hell!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[105]`
Mówca: **Wiktor Smolak**
> "“Exactly! To hell with Rumburg! I like you already, Anton!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[106]`
Mówca: **Wiktor Smolak**
> "“I agree with your sentiments, Anton. They are a threat to everyone in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Wiktor Smolak**
> "“I wouldn't be so sure, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Wiktor Smolak**
> "“I wouldn't be so sure, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Wiktor Smolak**
> "“I assure you their time will come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[113]`
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Are you planning something?”"]** — Mówca: **Player**
> "“Are you planning something?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“In due time, yes.”"]** — Mówca: **Player**
> "“In due time, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Regardless, I would rather prevent further conflict in the region.”"]** — Mówca: **Player**
> "“Regardless, I would rather prevent further conflict in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Wiktor Smolak**
> "“Well...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Wiktor Smolak**
> "“Not yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Wiktor Smolak**
> "“First, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[119]`
Mówca: **Wiktor Smolak**
> "“You know as well as I do, Anton. They are coming whether we like it or not. They are the aggressor, not us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[120]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Wiktor Smolak**
> "“You know as well as I do, Mr. President. They are coming whether we like it or not. They are the aggressor, not us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Not much in particular. Like any other country, they have their needs and their own agenda.”"]** — Mówca: **Player**
> "“Not much in particular. Like any other country, they have their needs and their own agenda.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Wiktor Smolak**
> "“Yes, they do. But their ambitions are over Wehlen and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[126]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[128]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Wiktor Smolak**
> "“Exactly! To hell with Rumburg! I like you already, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[130]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[132]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Wiktor Smolak**
> "“I agree with your sentiments, Mr. President. They are a threat to everyone in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[134]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Wiktor Smolak**
> "“We must be careful, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[138]`
Mówca: **Wiktor Smolak**
> "“We must be careful, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“What is it?”"]** — Mówca: **Player**
> "“What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He clapped his hands again. Two assistants came into the room with a map of the border regions between Wehlen and Sordland. He pointed at the border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Wiktor Smolak**
> "“Look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Wiktor Smolak**
> "“Bluds and their so called *BFF* are causing problems for me in this region. They are getting increasingly dangerous with Rumburg's active support. I know that they are a problem for you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Wiktor Smolak**
> "“I will not allow these traitors to exist within my borders. So I will hit them with all the might of Wehlen. These terrorists need to be destroyed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[145]`
Mówca: **Wiktor Smolak**
> "“I call it Operation Bear Trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`
  - -> `[148]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“I don't support any military action this close to our borders.”"]** — Mówca: **Player**
> "“I don't support any military action this close to our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "“What do you want from me?”"]** — Mówca: **Player**
> "“What do you want from me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "“I like the sound of it.”"]** — Mówca: **Player**
> "“I like the sound of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Wiktor Smolak**
> "“Here is the deal. I will give you objectively the *best* trade deal in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Narrator**
> "He grinned and lay back on the large pillow behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[151]`
Mówca: **Wiktor Smolak**
> "“You will give me your assistance crushing the terrorists on both of our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He lay back on the large pillow behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I need specifics.”"]** — Mówca: **Player**
> "“I need specifics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[154]`
**[WYBÓR GRACZA: "“Absolutely not. I won't meddle in Wehlen's military interventions.”"]** — Mówca: **Player**
> "“Absolutely not. I won't meddle in Wehlen's military interventions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Two birds, one stone.”"]** — Mówca: **Player**
> "“Two birds, one stone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Wiktor Smolak**
> "“You read my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Wiktor Smolak**
> "“This is not just Wehlen's problem. This is also Sordland's problem. These terrorists are doing anything they can to destabilize the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Wiktor Smolak**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Wiktor Smolak**
> "“My spies have infiltrated BFF cells and they found caches of KA-74s. We traced them back to Rumburg. This alone justifies my retaliation to protect my country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Wiktor Smolak**
> "“Worst of all, we also found that similar shipments are going to Sordland. Rumburg is trying to unite the BFF forces in both of our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[161]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Wiktor Smolak**
> "“Yes, Anton. You see. This is not just Wehlen's problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Wiktor Smolak**
> "“Yes, Mr. President. You see. This is not just Wehlen's problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Wiktor Smolak**
> "“Let's take a step back and talk about what you will get in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Wiktor Smolak**
> "“I propose you a no-tariff agreement, co-investment projects and oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[168]`
Mówca: **Wiktor Smolak**
> "“You know that as long as they use the mountains in Wehlen as a base, Sordland and Lespia will equally suffer. This is in the interest of the whole region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[169]`
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“What kind of support do you need from me? Can't Wehlen handle it by itself?”"]** — Mówca: **Player**
> "“What kind of support do you need from me? Can't Wehlen handle it by itself?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Wiktor Smolak**
> "“We can, but these vermin are good at hiding. As I told you, they operate and keep reorganizing inside both of our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“There might be international ramifications.”"]** — Mówca: **Player**
> "“There might be international ramifications.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Wiktor Smolak**
> "“To hell with international ramifications! I will protect my country! I don't care what they say!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[173]`
Mówca: **Wiktor Smolak**
> "“What I want from you in return for all the money and the resources, is only a joint operation between our armies against the BFF.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Deal.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I took a moment to think about it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“No deal. It's too risky. I'm afraid I can't accept.”"]** — Mówca: **Player**
> "“No deal. It's too risky. I'm afraid I can't accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“Let's negotiate Sordland's contribution in this operation.”"]** — Mówca: **Player**
> "“Let's negotiate Sordland's contribution in this operation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Wiktor Smolak**
> "“You are a tough one, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[182]`
Mówca: **Wiktor Smolak**
> "“You are a tough one, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[183]`
Mówca: **Wiktor Smolak**
> "“Wait, Mr. President. Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[184]`
Mówca: **Wiktor Smolak**
> "“Wait, Anton. Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[185]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[188]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[189]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[191]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[193]`
Mówca: **Wiktor Smolak**
> "“Normally, I wouldn't offer anything else but, I like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Wiktor Smolak**
> "“Here is my final offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Wiktor Smolak**
> "“When the operation starts, with you or without you, there will be stragglers trying to cross into Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Wiktor Smolak**
> "“We just want you to support the operation even if you do not join. Stop the terrorists from fleeing into your country and you will have your deal. Simple, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Wiktor Smolak**
> "“So what do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[198]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“No deal. I'm afraid I can't accept.”"]** — Mówca: **Player**
> "“No deal. I'm afraid I can't accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[199]`
Mówca: **Wiktor Smolak**
> "“That's unfortunate. I thought we could be friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Wiktor Smolak**
> "“But you decided to leave Wehlen to fend for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Wiktor Smolak**
> "“Such a shame. I am sure a powerful leader like Soll would've accepted this great offer without a doubt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[202]`
Mówca: **Wiktor Smolak**
> "“Tonight we will drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Narrator**
> "He clapped his hands again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Wiktor Smolak**
> "“Drinks! Dancers! Music!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Instead of the two assistants this time, a group of dancers and performers entered. Smoke filled  the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "As they performed their songs, we clinked our glasses to our new partnership while sipping the sweet Wehzek liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[207]`
Mówca: **Narrator**
> "The next day, I returned to Sordland with a hangover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[208]`
Mówca: **Wiktor Smolak**
> "“My assistants will show you the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Wiktor Smolak**
> "“Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "“Take care of yourself, Wiktor.”"]** — Mówca: **Player**
> "“Take care of yourself, Wiktor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "Nod and leave."]** — Mówca: **Player_Italic**
> "I nodded and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Narrator**
> "I returned to Sordland immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "I felt relieved to be back in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_FPnT_WehlenTradeVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_FPnT_WehlenTradeVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[215]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true; BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal = true;
BaseGame.Wehlen_JointOperation = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Wehlen_TradeDeal"] = true;
Variable["BaseGame.Wehlen_JointOperation"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[217]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Narrator**
> "The next day, I returned to Sordland with a hangover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[219]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[220]`
Mówca: **Wiktor Smolak**
> "“Tonight we will drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Narrator**
> "A group of dancers and performers entered and smoke filled the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[222]`
Mówca: **Narrator**
> "He clapped his hands again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Wiktor Smolak**
> "“Drinks! Dancers! Music!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[224]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[226]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[227]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder = true;
BaseGame.Wehlen_TradeDeal = true; 

BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Wehlen_DefendBorder"] = true;
Variable["BaseGame.Wehlen_TradeDeal"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Narrator**
> "As they performed their songs, we clinked our glasses to our new partnership while sipping the sweet Wehzek liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[230]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[231]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation = true;
BaseGame.Policy_Diplomacy_Wehlen_Trade = true;
BaseGame.Policy_Diplomacy_CoalitionIntervention = true;
BaseGame.Policy_Diplomacy_Neutrality = false;
BaseGame.Policy_Military_JointMilitaryExercises = true;
BaseGame.Situation_Military_MilitaryInterventionWehlen = true;
BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_CoalitionIntervention"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;
Variable["BaseGame.Situation_Military_MilitaryInterventionWehlen"] = true;
Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[232]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = true;
BaseGame.Situation_Military_Wehlen_BorderDefence = true;
BaseGame.Policy_Diplomacy_Wehlen_DefendBorder = true;
BaseGame.Policy_Diplomacy_Wehlen_Trade = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = true;
Variable["BaseGame.Situation_Military_Wehlen_BorderDefence"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[233]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn05_Trade_WehlenFailed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[234]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[237]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal = true;
BaseGameSupport.News_Turn05_R_WehlenCoop = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal"] = true;
Variable["BaseGameSupport.News_Turn05_R_WehlenCoop"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[238]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[241]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[244]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[245]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Narbel_DetainReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Narbel_DetainReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[246]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_WehlenDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_WehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[252]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1;
BaseGame.Capitalist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[254]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 1;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[255]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[257]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: // Filler Node for organization)*
- **Efekt (`userScript`):** `-- Filler Node for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[263]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Wehlen_TradeDeal"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = false;
BaseGame.Situation_Military_MilitaryInterventionWehlen = false;
BaseGame.Situation_Military_Wehlen_BorderDefence = false;
BaseGame.Policy_Diplomacy_Wehlen_DefendBorder = false;
BaseGame.Policy_Diplomacy_Wehlen_JointOperation = false;
BaseGame.Policy_Diplomacy_Wehlen_Trade = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = false;
Variable["BaseGame.Situation_Military_MilitaryInterventionWehlen"] = false;
Variable["BaseGame.Situation_Military_Wehlen_BorderDefence"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[265]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[267]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_IncreasedTrade = true;
BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = true;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[269]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[272]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_RecoveredTrade = true;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = true;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs = true; BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs"] = true;
Variable["BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[280]`
Mówca: **Wiktor Smolak**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[281]`
Mówca: **Wiktor Smolak**
> "“I will cut all their supplies from Rumburg and trap them on the mountains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""Why would you offer me so much?""]** — Mówca: **Player**
> ""Why would you offer me so much?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Wiktor Smolak**
> "“Why wouldn't I? I want Sordland to be Wehlen's friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Wiktor Smolak**
> ""The question is, do you also want Wehlen as your friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[285]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[286]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[289]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Vesord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Vesord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Estord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Estord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[297]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PlaneLandingRoughly");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PlaneLandingRoughly");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[298]`
Mówca: **Narrator**
> "It was probably the highest-quality tobacco I had ever smoked. I handed it back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[299]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Shisha");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Shisha");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[300]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Wehlen", "Friendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Wehlen","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[301]`
Mówca: **Wiktor Smolak**
> ""However, the main problem is the border security between our nations. BFF militants have been using the mountains between Sordland and Wehlen to escape justice in both of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Wiktor Smolak**
> ""If we don't act and trap them in those mountains, they will keep replenishing their forces in both of our countries and keep waging war against our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[303]`
Mówca: **Wiktor Smolak**
> "“In return, you will assist me in destroying the armed militants in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[304]`
Mówca: **Wiktor Smolak**
> "“And now, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[305]`
Mówca: **Wiktor Smolak**
> "“But now, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[306]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[307]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Cooperation");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Cooperation");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade_Oil");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade_Oil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[311]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade_Oil");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade_Oil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[312]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  or  (Variable["BaseGame.Wehlen_DefendBorder"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  or  (Variable["BaseGame.Wehlen_DefendBorder"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[315]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Derdia", "Unfriendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Derdia","Unfriendly");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[316]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Wehlen", "Progress_DiplomaticMission_Wehlen");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Wehlen","Progress_DiplomaticMission_Wehlen");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[317]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[319]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[321]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[322]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[325]`
Mówca: **Wiktor Smolak**
> ""What I seek from you, in reciprocation for this advantageous collaboration, is merely a cooperative military endeavor involving our forces against the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[326]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[329]`
**[WYBÓR GRACZA: ""Are you suggesting we pay a higher rate than usual?""]** — Mówca: **Player**
> ""Are you suggesting we pay a higher rate than usual?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Wiktor Smolak**
> ""Indeed, there are additional expenses emerging within our oil sector. Consider it a modest surcharge, a token of our potential friendship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[331]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[334]`
Mówca: **Wiktor Smolak**
> "“In exchange, we will offer you a competitive new oil price, aligned with the latest market dynamics, and in turn, you'll aid me in dismantling the armed militants in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
