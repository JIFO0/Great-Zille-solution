# Rizia/Turn 4/P_EstelaUpdate

- **ID konwersacji:** `315`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/315_P_EstelaUpdate.md`
- **Liczba węzłów dialogowych:** 399
- **Liczba wyborów gracza:** 110

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Decision_Turn04_AttendHouseOfDelegates`
- `RiziaDLC.Diplomacy_Lespia_WehlenHelp`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Relations_Estela_TellAboutMurderCase`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Vina`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Relations_Estela`
- `RiziaDLC.Turn04_EnableRRGStakeChange`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Vina`
- `RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen`
- `RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 12

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Estela`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[219]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Estela"] = Variable["RiziaDLC.Relations_Estela"] - 1;`
- Węzeł `[302]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] = true;`
- Węzeł `[322]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] = true;`
- Węzeł `[335]` (Paskal Beniwoll): `RemoveConversant("Estela Toras"); ;`
- Węzeł `[336]` (Paskal Beniwoll): `AddConversant("Estela Toras"); ;`
- Węzeł `[337]` (Paskal Beniwoll): `RemoveConversant("Vina Toras"); ;`
- Węzeł `[338]` (Paskal Beniwoll): `AddConversant("Vina Toras"); ;`
- Węzeł `[339]` (Paskal Beniwoll): `End();`
- *...oraz 4 innych węzłów ze skryptami.*

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
  - -> `[340]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was the night before my trip to Kyrute for the Alliance of Nations meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I had just finished some last-minute preparations in my study. I carefully made my way back towards the palace's residential wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I reached the top floor. Across the hall from my bedchamber, the Queen Mother's door was open a crack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I looked in. My mother was standing out on her balcony, her back turned towards me. I heard her whispering softly to herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Tap her on the shoulder."]** — Mówca: **Player_Romus_Italic**
> "I tapped her on the shoulder. She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't sleep?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Grand Wiseman Ignacius' quarters were on the ground floor. I saw light coming out of the keyhole."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Peer in."]** — Mówca: **Player_Romus_Italic**
> "I carefully bent down and looked inside. Sal was rocking back and forth in his armchair, his eyes closed. He seemed to be mouthing a prayer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Romus_Italic**
> "I proceeded towards the end of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Just before the stairs was the entrance to Vina's room. Through the door, I caught the faint strains of her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[22]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Press your ear against the door."]** — Mówca: **Player_Romus_Italic**
> "I pressed my ear against the door in order to hear better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[15]`
Mówca: **Vina Toras**
> ""Yes, I agree. It seems like an adequate compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[19]`
Mówca: **Vina Toras**
> ""...No, he hasn't written back yet. Who knows if he's even read it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""What, are you mad? Of course Father doesn't know anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Vina Toras**
> ""...Yes, my love. We'll speak very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Romus_Italic**
> "I passed Vina's door and walked up the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[23]`
Mówca: **Narrator**
> "There was a clunk as she hung up the phone. I moved away from the door and kept walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[24]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""Don't worry about me, darling. You should be resting yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[26]`
Mówca: **Estela Toras**
> ""All set for tomorrow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`
  - -> `[33]`
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""You shouldn't sneak up on an old woman like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[28]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Estela Toras**
> ""I'm surprised you're still up. You have a long day ahead of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I am. The Alliance of Nations won't know what hit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. Can I ask you something about Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did Father tell you anything about these AN sessions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not really. Diplomacy isn't exactly my forte.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Estela Toras**
> ""That's my boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[35]`
Mówca: **Estela Toras**
> ""We need our land back. No matter what kind of announcement Wiktor Smolak has up his sleeve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[43]`
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Estela Toras**
> ""There's nothing to it. Just stand up straight, smile, preach unity and cooperation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""Oh, you know he was no diplomat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Estela Toras**
> ""In fact, I'm not sure he even attended after the Zille agreement. Poor Mr. Esquibel went alone in his stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough is enough. He will pay for his disrespect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know he's going to make an announcement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""My whisper networks aren't what they used to be. But wives still talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[86]`
  - -> `[96]`

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""I care for Mr. Esquibel dearly, but he has given Wehlen the benefit of the doubt for too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[86]`
  - -> `[96]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want a confrontation. Our countries are on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""Oh, Romus. You still believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[86]`
  - -> `[96]`

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""And then stab the bastards in the back when they least expect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[46]`
Mówca: **Estela Toras**
> ""What about our princess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What has she been doing while I'm at my council meetings?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[133]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did she get up to anything while I was in Pales?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[52]`
Mówca: **Estela Toras**
> ""Besides her etiquette classes, I haven't the faintest. She spends a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
Mówca: **Vina Toras**
> ""No, I won't talk to him. He's in Kyrute the next few days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[60]`
Mówca: **Vina Toras**
> ""Oh, don't be so blue. Honestly, what were you expecting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""Yes, I know. I was surprised too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has she told you whether she's seeing someone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would it be crazy if I married her off to Rico?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[64]`
Mówca: **Estela Toras**
> ""Although of course I've heard the same rumors you have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Estela Toras**
> ""As far as I could tell, she spent a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all just talk. I don't know what's actually happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think they're more than just rumors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What rumors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""Then you have a relationship to approve of. Or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "She flicked a bit of ash from her cigarette off the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Estela Toras**
> ""I'll tell you this much. The last thing you want to do is forbid her from seeing him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[80]`
  - -> `[79]`
  - -> `[103]`

### Węzeł `[72]`
Mówca: **Estela Toras**
> ""Come, dear. Did you really think one dance in Sallabes would be enough for those two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the king. If I order her not to see him, she'll have to obey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[74]`
Mówca: **Narrator**
> "She snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Estela Toras**
> ""You've been talking to your uncle, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[93]`
  - -> `[94]`

### Węzeł `[76]`
Mówca: **Estela Toras**
> ""You know how your father and I met, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`
  - -> `[371]`

### Węzeł `[77]`
Mówca: **Estela Toras**
> ""That much is true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Next thing you know, she's throwing all of her influence at the Council to persuade them that a fisherman's daughter is a suitable match for a prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[376]`
  - -> `[227]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who said anything about forbidding? I *want* them to get together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that. I'm not stupid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[81]`
Mówca: **Estela Toras**
> ""After everything the Sazons did to you? To us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would never do that. She's allowed to love whomever she wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all fine. I've got a plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any advice for how to act, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""I was referring to Zille, my dear. Or have you forgotten that the handover deadline is imminent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'd rather not discuss this with you. You're not exactly impartial on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""Impartiality won't get you anywhere with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia will help me out. We have an arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[89]`
Mówca: **Estela Toras**
> ""I say don't stoop to his level. Make him look like the tyrant he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[90]`
Mówca: **Estela Toras**
> ""You always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wasn't wrong about keeping power within the Toras family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was right. Young people can't be trusted to follow their hearts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's a spark between those two, I can tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just weighing the possibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[95]`
Mówca: **Estela Toras**
> ""*Especially* after what we've both been through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
Mówca: **Estela Toras**
> ""Lespia? An odd choice, but I suppose you know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[100]`
Mówca: **Narrator**
> "It was later than I realized. The halls were dead silent, illuminated only by weak shafts of moonlight through the windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[101]`
Mówca: **Estela Toras**
> ""There's a spark between me and my doorknob when I wear woolen slippers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""Royal marriages are a balancing act, my dear. You can satisfy the betrotheds or the country, but almost never both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Estela Toras**
> ""*Almost*. You were lucky for a while, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""And it's hard to tell which compromise creates more misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had one more thing I wanted to ask first. About Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These things take a while, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[113]`
Mówca: **Estela Toras**
> ""I couldn't possibly comment on your daughter's affairs. No matter how much gossip is circulating about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""It's a balancing act, my dear. When it comes to royal marriages, you can satisfy the betrotheds or the country, but almost never both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""*Almost*. You were lucky for a while, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""This particular pairing, though, would satisfy House Toras and no one else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""And it's hard to tell which compromise creates more misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[121]`
Mówca: **Estela Toras**
> ""That isn't the sort of information a young lady shares with her grandmother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[125]`
Mówca: **Narrator**
> "She flicked a bit of ash from her cigarette off the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[126]`
Mówca: **Estela Toras**
> ""In *Rizia*, darling. Have you truly never considered looking to foreign shores?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[127]`
Mówca: **Narrator**
> "She smiled sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The supply of suitable, single nobles in Rizia is dwindling. I don't see much of a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I have House Toras behind me, I won't need anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo and Rico are powerful men. I'm worried about what they'll do if they don't get their way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I'm saying is, I think they would make cute babies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "She wrinkled her nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Has she been writing letters to anyone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Estela Toras**
> ""Possibly. She does spend a lot of time holed up in her room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[135]`
Mówca: **Estela Toras**
> ""It's the kind of behavior that might make one think she had a new lover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[229]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus. I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Estela Toras**
> ""I can't say I'm surprised. They're both quite good-looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[138]`
Mówca: **Estela Toras**
> ""This particular match would satisfy your daughter very much. It would also put House Sazon dangerously close to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""It's up to you whether Vina's happiness is worth that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[240]`
  - -> `[244]`
  - -> `[247]`

### Węzeł `[140]`
Mówca: **Estela Toras**
> ""Speaking of which, how is that muscle-bound lunk of yours proceeding with his investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`
  - -> `[158]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Estela Toras**
> ""Speaking of which, how is that bird of prey on your council proceeding with her investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[152]`
  - -> `[164]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_CompromisingPhoto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Speaking of which, how is your lady friend proceeding with her investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[164]`
  - -> `[165]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Lucita that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Titus that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which investigation do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hopefully Rico's gambit will buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[162]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Estela Toras**
> ""There's more than one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[206]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Pales situation has required her full attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's not my lady friend, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Estela Toras**
> ""No? It wouldn't be a bad match, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
Mówca: **Estela Toras**
> ""Do try to keep her in line. The Azaros getting too mixed up with Pales is what lost us Zille in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[180]`
  - -> `[181]`
  - -> `[363]`

### Węzeł `[168]`
Mówca: **Estela Toras**
> ""I do hope the investigators turn up something we can use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[169]`
Mówca: **Estela Toras**
> ""I meant it as a term of affection. You know I adore that man and his muscles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Estela Toras**
> ""At any rate, I hope his investigators turn up something we can use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
Mówca: **Estela Toras**
> ""She gives you the loyalty of the Azaros, you help curb that legendary Azaro temper...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[181]`
  - -> `[198]`
  - -> `[363]`

### Węzeł `[172]`
Mówca: **Estela Toras**
> ""I do wish you'd run that by me. If Wehlen finds out we intentionally gave them the wrong suspects, it could blow up in our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""Nothing to be done about it now, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[341]`
  - -> `[181]`

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""I shudder to think of what might happen if the handover deadline arrives before a culprit is found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[341]`
  - -> `[181]`

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""I meant it as a term of affection. She's got a beautiful beak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I hope she hasn't inherited her family's unhealthy obsession with Pales. She mustn't distract herself from our real problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[180]`
  - -> `[181]`
  - -> `[363]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll stay on top of her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""I'm sure you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales *is* a real problem, Mother. The situation there could easily spiral out of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother, could you perhaps envision minding your own damn business for once?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Estela Toras**
> ""Right. Who cares what happens to my homeland when there's embroidery that needs embroidering?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "She forcefully stubbed her cigarette out on the balcony railing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_CompromisingPhoto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Estela Toras**
> ""Has that bird of prey on your council managed to find out anything more about what happened to us in Zille?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[152]`
  - -> `[164]`

### Węzeł `[188]`
Mówca: **Estela Toras**
> ""Has your new lady friend received any more intelligence from Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[164]`
  - -> `[165]`

### Węzeł `[189]`
Mówca: **Estela Toras**
> ""I should get some rest. And so should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[190]`
  - -> `[191]`
  - -> `[217]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take that tone with your king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I'm sorry. You don't understand the stress I'm under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[192]`
Mówca: **Estela Toras**
> ""Pales is not ours to control in the first place. Zille, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[193]`
Mówca: **Estela Toras**
> ""Well. It's about time I got some rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[299]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I had one more thing I wanted to ask. About Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Estela Toras: ""What about our princess?""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't worry about Zille. I promise I'm doing everything I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I can see the advantages of such a match. But I haven't made my mind up yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's my councilor. It wouldn't be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Estela Toras**
> ""Your *interim* councilor, if I recall correctly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[200]`
Mówca: **Estela Toras**
> ""Think about it. She may be past her prime marriage years, but it's not too late for some other noble to snatch her up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wish me luck for tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Estela_TellAboutMurderCase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Estela_TellAboutMurderCase == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Estela_TellAboutMurderCase == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember how I told you Pabel thinks Father was murdered? Titus is investigating that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Sorry, I got confused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel thinks Father might have been murdered. I told Titus to investigate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Estela Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If someone killed Father, I might be next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if Pabel was wrong about the murder, I'll have gathered some useful intel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[211]`
Mówca: **Estela Toras**
> ""Hmm. You're starting to sound just like him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Narrator**
> "She stubbed her cigarette out on the balcony railing and sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[213]`
Mówca: **Estela Toras**
> ""I do beg your pardon. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Her gaze softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Narrator**
> "There was a chill in her voice now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[216]`
Mówca: **Estela Toras**
> ""I know. The last thing you need is pressure from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sleep well, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Estela Toras**
> ""Good night, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Estela -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Estela"] = Variable["RiziaDLC.Relations_Estela"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[220]`
Mówca: **Estela Toras**
> ""I should hope I'm not on the list of suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe not, but I've already assigned him the task. I've got to see it through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for all your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Estela Toras**
> ""What's a mother for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Estela Toras**
> ""I know you won't need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Estela Toras**
> ""I'm not worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Narrator**
> "I wished her goodnight and left the room. I heard her light click off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lyza was weak. I know how to control my own daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what do I do? I don't want him infecting her with his dangerous ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God. She's warmed up to Rico after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[230]`
Mówca: **Estela Toras**
> ""Are you sure it's not the opposite you need to be worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[261]`
  - -> `[260]`

### Węzeł `[231]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Sazon_ManusTalkSoured == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Sazon_ManusTalkSoured == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I actually like the kid. But he doesn't seem like marriage material to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[237]`
Mówca: **Estela Toras**
> ""But... after everything the Sazons did to you? To us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[238]`
Mówca: **Estela Toras**
> ""No force in this world is as uncontrollable as a young woman in love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[265]`
  - -> `[263]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Sazons aren't as dangerous as you think. I'm looking to collaborate more closely with Manus, in fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_WorkWithRPP == true || RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] == true  or  Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course it is, Mother. How could you even ask that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd be fine with it if it were true love. But I'm worried he's using her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[245]`
Mówca: **Estela Toras**
> ""They're powerful within Rizia, but minor players on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might help neutralize the Sazon threat, actually. Manus' 'man of the people' act won't work if he's king consort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said yourself I shouldn't forbid her from seeing him. What other choice do I have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[248]`
Mówca: **Estela Toras**
> ""You need to be thinking bigger, my love. We Torases are but minor players on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Estela Toras**
> ""I should think you'd be more worried about putting House Sazon a single body away from the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[260]`
  - -> `[265]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Estela Toras**
> ""It is, however, something any woman of experience can tell in seconds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[229]`

### Węzeł `[258]`
Mówca: **Estela Toras**
> ""The way I see it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Estela Toras**
> ""You could use the pairing to keep a close eye on the opposition. Assuming Vina trusts you enough to pass along information about her paramour's family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[271]`
  - -> `[276]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever. There must be some way we can stop this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nonsense. She can't even hold a gun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[264]`
Mówca: **Estela Toras**
> ""Nothing. Just wondering if she took more than an academic interest in that book she borrowed a while ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I can't control her, what can I do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[266]`
Mówca: **Estela Toras**
> ""Love has toppled more empires than gunshots ever will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[267]`
Mówca: **Estela Toras**
> ""You send the princess on a nice, relaxing trip abroad. Nothing cures lovesickness like a change of scenery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[287]`

### Węzeł `[268]`
Mówca: **Estela Toras**
> ""Then you'll have to find a way to make it work to your advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[269]`
Mówca: **Estela Toras**
> ""In that case, Vina might be useful as your eyes and ears inside their house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[270]`
Mówca: **Estela Toras**
> ""Yes, there are ways to make this work to your advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't count on that, unfortunately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course she trusts me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no. She's my daughter, not a spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Estela Toras**
> ""We're all using each other, aren't we? In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[279]`
Mówca: **Estela Toras**
> ""Or there's one other thing you could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A diplomatic mission, perhaps? Distract Vina and improve our international standing in one go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. She's a valuable member of my council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. She's been cramping my style on the council, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She'd find that a lot more stimulating than etiquette classes, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not ready to let go of her. She's the last tie to Lena I have left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Estela Toras**
> ""You could always invite her high-and-mighty aunt for more scintillating chats over putrid Rumburgian tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[289]`
Mówca: **Estela Toras**
> ""It's just a thought. Feel free to ignore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[290]`
Mówca: **Estela Toras**
> ""And if she meets some dashing foreign prince over there, consider it a bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[291]`
Mówca: **Estela Toras**
> ""You want my advice? It's high time the Princess took a nice, relaxing trip out of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Estela Toras**
> ""It would put a stop to the rumors that are beginning to circulate about Her Highness and the Sazon heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[296]`
Mówca: **Estela Toras**
> ""She's old enough to experience the world beyond our little peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[287]`

### Węzeł `[297]`
Mówca: **Estela Toras**
> ""Speaking of foreign affairs, are you positive you don't want to talk about tomorrow's meeting? I just want to make sure you're prepared to address the elephant in the chamber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[298]`
Mówca: **Estela Toras**
> ""And with that, it's time to turn in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[309]`
  - -> `[310]`
  - -> `[301]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, me too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Estela Toras**
> ""I hope Pabel ironed your pillowcase. You can't go addressing the AN with creases on your face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[201]`
  - -> `[222]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Wehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "She yawned theatrically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Estela Wehlen Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll deal with that when the moment arrives. I've got enough to think about for tonight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wish me luck for tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for all your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Estela Toras**
> ""What's a mother for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""I know you won't need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about Vina. I know what to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Estela Toras**
> ""It's late, isn't it? Time to turn in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`
  - -> `[301]`

### Węzeł `[315]`
Mówca: **Estela Toras**
> ""You're her father *and* the king. You surely know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_EstelaTalk_Vina == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_EstelaTalk_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_EstelaTalk_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[323]`
Mówca: **Narrator**
> "I returned to my quarters to see Titus take his post outside my door. I wondered how long he'd been shadowing me for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[327]`
Mówca: **Narrator**
> "I checked the corner for Bruno, but his dog bed was empty. I looked at my own bed and saw that he'd made himself comfortable there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shoo! Bad dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get a move on, boy. The King needs his rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. You can sleep here tonight, but don't get too used to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Narrator**
> "Bruno curled up at my feet as I got in bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[332]`
Mówca: **Narrator**
> "Bruno reluctantly hopped off the bed and trotted back to his corner. He was nearly as agile on three legs as he'd been on four."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Narrator**
> "I tried to sleep, but was too distracted by thoughts of the day ahead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[334]`
Mówca: **Narrator**
> "I climbed into bed, but was too distracted by thoughts of the day ahead to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`
  - -> `[395]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your concern. But I have it all under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Estela Toras**
> ""If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this doesn't work, we'll try something else. But Zille *will* be ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Estela Toras**
> ""Yes, I know. Excuse my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Qalus_CantuavoInvitation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[347]`
Mówca: **Estela Toras**
> ""You are planning on addressing the elephant in the chamber, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I am. Wehlen must be forced to honor the Zille handover deadline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. This naval standoff with Pales must end one way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""That's the pachyderm in question, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, the arbitration committee should have come to a decision already. Our claim on the gas field is clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which elephant? There are so many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Estela Toras**
> ""A wonder that you world leaders can squeeze in amongst all those pachyderms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""But I was referring to Zille. Or have you forgotten that the handover deadline is imminent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no elephant. I've neutralized the Pales situation for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Estela Toras**
> ""Have you so quickly forgotten? The Zille handover deadline is almost upon us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro has a level head. She won't drag us into conflict without reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Estela Toras**
> ""Oh, there's always a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Estela Wehlen Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[350]`
  - -> `[355]`
  - -> `[358]`

### Węzeł `[366]`
Mówca: **Narrator**
> "She snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[367]`
Mówca: **Estela Toras**
> ""Don't forget what happened when Lyza the Great tried to forbid your father from seeing the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were working as a waitress in a cocktail bar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You used your feminine wiles to entrap him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Estela Toras**
> ""Hardly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was always confused about that. Why did Lyza allow Father to date a commoner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Estela Toras**
> ""She didn't, at first. But the more she tried to discourage him, the faster she drove him straight into the arms of the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Narrator**
> "She laughed loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[374]`
Mówca: **Estela Toras**
> ""It was only supposed to be a fling, at first. But when Lyza the Great caught wind of it, she did everything in her considerable power to stop her son from seeing me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Estela Toras**
> ""And that, of course, was what drove him straight into the arms of the Whore of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything worked out in the end, though, didn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""If you call seriously undermining the monarchy 'working out', then yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[378]`
Mówca: **Narrator**
> "In my room. Pabel had already packed my suitcase and turned the bed down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[379]`
Mówca: **Vina Toras**
> ""Well, tell the others not to push for too much too quickly. He's in Kyrute the next few days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[380]`
Mówca: **Bruno**
> ""Hrr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`
  - -> `[330]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == false  and  Variable["RiziaDLC.Decision_Turn04_AttendHouseOfDelegates"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == false && RiziaDLC.Decision_Turn04_AttendHouseOfDelegates == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == false  and  Variable["RiziaDLC.Decision_Turn04_AttendHouseOfDelegates"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_EnableRRGStakeChange = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn04_EnableRRGStakeChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[385]`
Mówca: **Vina Toras**
> ""What?! Why would you want to stop when you only got half of what you wanted? That's no victory at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""Oh, don't be so blue. Honestly, what were you expecting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[393]`
Mówca: **Vina Toras**
> ""It's just the beginning, isn't it? You've won this victory, now you've got to keep pushing for more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[394]`
Mówca: **Estela Toras**
> ""Darling, sometimes a heart attack is just a heart attack. No need to waste the man's time trying to figure out who was where when.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[210]`
  - -> `[209]`
  - -> `[181]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Narrator**
> "She looked startled for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Estela Toras**
> ""Just rehearsing the choice words I'm going to have with the royal laundress. How hard can it be to get red wine out of an albino fox stole?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Narrator**
> "She lit a cigarette and blew smoke out into the gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
