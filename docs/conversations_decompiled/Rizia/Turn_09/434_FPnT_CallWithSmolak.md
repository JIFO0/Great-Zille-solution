# Rizia/Turn 9/FPnT_CallWithSmolak

- **ID konwersacji:** `434`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/434_FPnT_CallWithSmolak.md`
- **Liczba węzłów dialogowych:** 208
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[77]** Wiktor Smolak (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn06_Cemetary_HonorDadPales`
- `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales`
- `RiziaDLC.War_Objective_Captured_Remaz`
- `RiziaDLC.War_Objective_Captured_Solles`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.ZilleReferendum_NotStoppedByAN`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Accepted`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Rejected`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected`
- `RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 8

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Accepted`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Rejected`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected`
- `RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLC.War_Pales_Won"] = true; Variable["RiziaDLC.War_WehlenJoined"] = true; Variable...`
- Węzeł `[75]` (Paskal Beniwoll): `End();`
- Węzeł `[87]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true; Variable["RiziaDLCSupport.Journ...`
- Węzeł `[88]` (Paskal Beniwoll): `AddConversant("Wiktor Smolak (R)");`
- Węzeł `[89]` (Paskal Beniwoll): `RemoveConversant("Wiktor Smolak (R)");`
- Węzeł `[93]` (Paskal Beniwoll): `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- Węzeł `[204]` (Paskal Beniwoll): `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true; Variable["RiziaDLCSupport.Journ...`
- Węzeł `[207]` (Paskal Beniwoll): `SetRichPresence("Losing one territory to regain the other","Palas Toras","Monqiz"); ;`

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
  - -> `[93]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was having a massage and cocktail on the balcony of Palas Toras, high above Monqiz. The sun was setting, its rays shimmering on the water and illuminating the Rumburgian flags flying over the port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[4]`
Mówca: **Narrator**
> "My masseuse handed me a towel as I got up. Fully adept at blending business with pleasure, I reached for my cocktail and told the attendent I'd be taking the call in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[5]`
Mówca: **Narrator**
> "As I did, the attendant ran a telephone out to me, setting it on the pool's edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He informed me that Wiktor Smolak was on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[7]`
Mówca: **Wiktor Smolak (R)**
> ""Good evening, Your Majesty. I hope I am not disturbing your regal downtime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mr. President. To what do I owe the pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you call?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wasn't disturbed before. Now I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Wiktor Smolak (R)**
> ""My my. Last I recall, Rizians were a bit more welcoming than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Wiktor Smolak (R)**
> ""So tell me... how are you doing, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[13]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm well. And you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Savoring the high life in one of my many palaces. You know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Wiktor Smolak (R)**
> ""As a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Wiktor Smolak (R)**
> ""I'm currently partaking in the very same indulgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Wiktor Smolak (R)**
> ""Alright, I will cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Wiktor Smolak (R)**
> ""Oh, you know how it is. Purging my cabinet of infiltrators, taking out 'personal loans' from the treasury department...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[20]`
Mówca: **Wiktor Smolak (R)**
> ""Listen, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Wiktor Smolak (R)**
> ""I have a proposition for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[22]`
Mówca: **Narrator**
> "The water suddenly felt cold against my skin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`
  - -> `[104]`

### Węzeł `[23]`
Mówca: **Wiktor Smolak (R)**
> ""One you might find to be of interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Make it quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Wiktor Smolak (R)**
> ""How is your little war going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[29]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He took another drag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, thank you. A full victory is at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could be better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Wiktor Smolak (R)**
> ""I thought so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Wiktor Smolak (R)**
> ""Oh, really? Well, that's good. That's good. Yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Wiktor Smolak (R)**
> ""A man of few words, are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Wiktor Smolak (R)**
> ""Here's what I think, if I may be so bold...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Wiktor Smolak (R)**
> ""Imagine standing on your palace balcony, watching the sun dip in the west.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I didn't know any better, I'd interpret that as a veiled threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you out of your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Wiktor Smolak (R)**
> ""Now. Now. No need to be so tense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Wiktor Smolak (R)**
> ""Here comes the good part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly is this glorious army doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[44]`
Mówca: **Wiktor Smolak (R)**
> ""I use my army...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Wiktor Smolak (R)**
> ""...to help you win your war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[46]`
Mówca: **Wiktor Smolak (R)**
> ""So how about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Narrator**
> "He took another drag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you want in return?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your generosity. Of course we would accept Wehlen's unconditional assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm hanging up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Wiktor Smolak (R)**
> ""Hold on. Hold on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Wiktor Smolak (R)**
> ""Now hold on a minute... there's nothing unconditional about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Wiktor Smolak (R)**
> ""I'm offering a trade. Zille for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[167]`
  - -> `[188]`
  - -> `[190]`
  - -> `[175]`
  - -> `[178]`

### Węzeł `[54]`
Mówca: **Wiktor Smolak (R)**
> ""That's my price. Accept, and Pales will be yours for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Wiktor Smolak (R)**
> ""The offer expires the moment I hang up. Thoughts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. What made you think Rizia can't win without Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not give up Zille. Perhaps, there's another option we can explore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard a clink as he put the pipe down. His tone shifted to a much more serious one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
Mówca: **Wiktor Smolak (R)**
> ""This deal isn't negotiable. It's Zille or nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Too bad. A pity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I agree to your conditions, but only if you follow through with your side of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[62]`
Mówca: **Narrator**
> "I took a moment to mull over his proposal. Could I really trade Zille for Pales?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[63]`
Mówca: **Wiktor Smolak (R)**
> ""So what do you think? Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[83]`
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Narrator**
> "I thought about it for another brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[61]`

### Węzeł `[65]`
Mówca: **Wiktor Smolak (R)**
> ""Excellent! And of course, I'll follow through. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[66]`
Mówca: **Narrator**
> "I could picture his wide grin in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won = true; RiziaDLC.War_WehlenJoined = true; RiziaDLC.ZilleReturn_Success = false;
RiziaDLC.ZilleReferendum_SmolakOffer_Accepted = true; 
RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted = true;
RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Won"] = true;
Variable["RiziaDLC.War_WehlenJoined"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = false;
Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Accepted"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""I made my offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Wiktor Smolak (R)**
> ""I wish you a good night, Your Majesty. And good luck in your war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[71]`
  - -> `[70]`
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good night, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope to never hear your voice again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Piss off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[73]`
Mówca: **Wiktor Smolak (R)**
> ""That makes two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[74]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
Mówca: **Wiktor Smolak (R)**
> ""Then my people will talk to your people and we will be all set.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Wiktor Smolak (R)**
> ""You definitely are a man of reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[78]`
Mówca: **Wiktor Smolak (R)**
> ""I wish you a good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Wiktor Smolak (R)**
> ""I'm eager to attend the victory celebrations in Pales, hosted by none other than King Romus himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll surpass your wildest expectations, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Should you betray me, I'll make sure both you and your nation suffer the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting proposal... But how do I know you won't renege?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Wiktor Smolak (R)**
> ""We will sign an agreement, of course! I trust your foreign affairs councilor to make sure everything is airtight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[61]`

### Węzeł `[85]`
Mówca: **Wiktor Smolak (R)**
> ""You're speaking my language, Your Majesty! I look forward to hearing all about all the dirty details!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[86]`
Mówca: **Narrator**
> "I muttered the words to no one before submerging myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Wiktor Smolak (R)");)*
- **Efekt (`userScript`):** `AddConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Wiktor Smolak (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[94]`
Mówca: **Narrator**
> "I took a sip from my virgin Romultini -- my mother's invention -- and let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[95]`
Mówca: **Narrator**
> "I took a sip from my Romultini -- my mother's invention -- and let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I almost spit out my drink. I took a moment to compose myself before picking up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was just about to take a leisurely swim in my pool of gold coins. But I suppose your company is a worthy distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Wiktor Smolak (R)**
> ""'Ha! 'Pool of gold coins...' I'll have to remember that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
Mówca: **Wiktor Smolak (R)**
> ""So how are you, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[13]`

### Węzeł `[103]`
Mówca: **Wiktor Smolak (R)**
> ""Just another day at the office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, don't keep me in suspense. The anticipation is absolutely killing me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "There was a noticeable pause before he took another drag. I suspected my sarcasm might have missed its mark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[106]`
Mówca: **Wiktor Smolak (R)**
> ""The unmatched glory that is the army of the Republic of Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[39]`
  - -> `[38]`
  - -> `[40]`

### Węzeł `[107]`
Mówca: **Wiktor Smolak (R)**
> ""Suddenly, just as its fading light teeters over the horizon, you spot a glimmer of gold amidst the shadows--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[108]`
Mówca: **Wiktor Smolak (R)**
> ""As you're undoubtedly aware, Wehzek troops boast a legendary reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[109]`
Mówca: **Narrator**
> "On the one hand, accepting Wehlen's aid could tip the scales in our favor, but aligning with the likes of Wikor Smolak could leave us indebted to him indefinitely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Narrator**
> "On the other hand, if Smolak's intentions were true, a decisive victory over Pales could be within our grasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Not to mention, risk tarnishing our reputation with our international partners, especially if we were to lose the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[112]`
Mówca: **Wiktor Smolak (R)**
> ""I understand the importance of trust and honoring one's commitments -- especially to a soon-to-be brother in arms!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[113]`
Mówca: **Wiktor Smolak (R)**
> ""Just think... this one phone call will inevitably change the course of history. No doubt about it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[114]`
Mówca: **Wiktor Smolak (R)**
> ""Well, I've had some pretty wild dreams, but I'll trust you on this one!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A military alliance with Wiktor Smolak... what have I gotten myself into... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales is within my grasp. I can feel it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've almost finished what my father started. "The Rizian flag *will* fly over Pales once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[118]`
Mówca: **Narrator**
> "As I set my phone down, I reflected on what just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[115]`
  - -> `[133]`
  - -> `[205]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Narrator**
> "I said the words out loud to no one before submerging myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A military alliance with Wiktor Smolak... I can't believe I even considered it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales is within my grasp. I can feel it. Not even a two-bit dictator like Wiktor Smolak will make me think otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Narrator**
> "As I set my phone down, I reflected on what just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`
  - -> `[125]`
  - -> `[205]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Screw Smolak... I will finish what my father started. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_Cemetary_HonorDadPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw Smolak... I don't need his help to rectify my father's mistakes. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw Smolak. I don't need his help. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_Cemetary_HonorDadPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag *will* once again fly over Pales. My father's mistakes will no longer haunt this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag *will* fly over Pales once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[141]`
Mówca: **Narrator**
> "I basked in the serenity, almost able to forget my troubles, when an attendant broke the calm with news of an important phone call, pulling me back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[142]`
Mówca: **Narrator**
> "When I reached my private oasis -- surrounded by marble columns with an equally impressive view as before -- I descended the steps and immersed myself in the cool water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[143]`
Mówca: **Narrator**
> "I heard him take a puff, likely from a khisha pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[144]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, Lucita had urged me to take some time for myself. For her sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, Pabel had urged me to take some time for myself. For his sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, my mother had urged me to take some time for myself. For her sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "I was having a massage and cocktail on the balcony of Palas Toras, high above Monqiz. The sun was setting, its rays shimmering on the water and illuminating the Rizian flags flying over the port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[160]`
Mówca: **Wiktor Smolak (R)**
> ""Be glad you're a king and not a poker player. You're bluffing terribly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[161]`
Mówca: **Wiktor Smolak (R)**
> ""Don't be so rude, Your Majesty. I'm asking as a friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything I went through to get Zille back? Forget it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_NotStoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see through your desperation. You're making this offer because you're going to lose the referendum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late for that, Mr. President. Zille is a part of Rizia again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen here, Smolak. Your puny little troops will only interfere with the unstoppable juggernaut that is the Rizian Armed Forces. Consider your offer declined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[172]`
Mówca: **Wiktor Smolak (R)**
> ""The only difference is that this time, our ownership of Zille will be permanent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Wiktor Smolak (R)**
> ""But who need dusty old Zille anyway? Not when you've got full control over South Merkopa's largest new natural gas source...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[174]`
Mówca: **Wiktor Smolak (R)**
> ""It's never too late for another agreement, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you opened a newspaper lately? We're closing in on the Palesian capital. We don't need help from you or anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[182]`
Mówca: **Wiktor Smolak (R)**
> ""And here I thought you were doing all that as a token of friendship. Not because of some dusty old piece of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Wiktor Smolak (R)**
> ""Think about it, Your Majesty. Who needs Zille when you have full control over South Merkopa's largest new natural gas source?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[184]`
Mówca: **Wiktor Smolak (R)**
> ""Do you own a crystal ball, Your Majesty? Nothing's decided until the people cast their vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Wiktor Smolak (R)**
> ""Think about it. Lose both the referendum and the war, and you'll have lost two regions. Accept this deal, and you're guaranteed to gain one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia calling on the Wehzek army for help? It's been done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Wiktor Smolak (R)**
> ""And it worked, didn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please elaborate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Wiktor Smolak (R)**
> ""It's simple. After we help you win the war, Rizia and Wehlen will sign a land transfer agreement, just like your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if your troops fail? We'll lose two regions in one go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Wiktor Smolak (R)**
> ""Don't you worry, Your Majesty. If Pales is lost, our agreement will be void. Zille will be yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_NotStoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[195]`
Mówca: **Wiktor Smolak (R)**
> ""If you win the referendum. Which is by no means a given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see you at the Zille return ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_NotStoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Wiktor Smolak (R)**
> ""I wouldn't count on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[201]`
Mówca: **Wiktor Smolak (R)**
> ""If your war duties don't beckon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[202]`
Mówca: **Narrator**
> "He adopted a wounded tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Wiktor Smolak (R)**
> ""No need to raise your voice, Your Majesty. It was a friendly gesture, nothing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse me?! Why is my Romultini glass empty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "My attendant ran to refresh my drink as I submerged myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Losing one territory to regain the other", "Palas Toras", "Monqiz");)*
- **Efekt (`userScript`):** `SetRichPresence("Losing one territory to regain the other","Palas Toras","Monqiz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
