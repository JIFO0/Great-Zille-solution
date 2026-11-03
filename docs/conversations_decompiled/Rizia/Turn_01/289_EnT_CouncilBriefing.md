# Rizia/Turn 1/EnT_CouncilBriefing

- **ID konwersacji:** `289`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/289_EnT_CouncilBriefing.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn01_CoronationParty_Large`
- `RiziaDLC.Decision_Turn01_CoronationParty_Medium`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Focus_Economy_Mixed`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Monqiz_Rebuild`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Turn01_WineWithHugo`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment`
- `RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding`
- `RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Manus_IgnoreFirstMeeting`
- `RiziaDLC.Relations_Manus_ThreatenFirstMeeting`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Large`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Small`
- `RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing`
- `RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest`
- `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid`

### Skoki między-konwersacyjne:
- Węzeł `[48]` -> **[290] Rizia/Turn 1/Economy and Treasury Section** (../Turn_01/290_Economy_and_Treasury_Section.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 16

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment`
- `RiziaDLC.Relations_Manus_IgnoreFirstMeeting`
- `RiziaDLC.Relations_Manus_ThreatenFirstMeeting`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[192]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] = true;`
- Węzeł `[193]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- Węzeł `[194]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- Węzeł `[195]` (Paskal Beniwoll): `RemoveConversant("Manus Sazon"); ;`
- Węzeł `[196]` (Paskal Beniwoll): `RemoveConversant("Manus Sazon"); ;`
- Węzeł `[197]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Large"] = true;`
- Węzeł `[204]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium"] = true;`
- Węzeł `[205]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Small"] = true;`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> `[285]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Hugo, Your Grace. Your shirt's buttoned wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "My uncle looked chastised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Welcome to the council, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Princess is part of this court now. I advise you to be more respectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""Apologies to you both. I meant no disrespect at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "She gave Vina a broad smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Vina Toras**
> ""Please don't mind me, Duchess Azaro. I'm only here as an observer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""Thank you all for joining us. I'm pleased to have the entire council here for this first meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""Your Majesty. It is a pleasure and an honor to be in this room with you once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[15]`
Mówca: **Elena Werner**
> ""I must say it makes me proud to see you in that seat. Between your time on this council and the fine work you did in Valenqiris, I can't think of a better man for the position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`
  - -> `[43]`

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Your Majesty. It is a pleasure and an honor to serve on your council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucita's eyes darted to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""The King and his direct successor spending so much time in the same room... I hope the Golden Guard knows what's at stake in keeping these chambers secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Rebuild == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Rebuild == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_Rebuild == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Rebuild == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Rebuild == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_Rebuild == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[25]`
Mówca: **Elena Werner**
> ""Your reputation precedes you, Your Majesty. I've heard marvelous things about the work you did in Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[43]`

### Węzeł `[26]`
Mówca: **Elena Werner**
> ""I must say it makes me proud to see you in that seat. If you show the same devotion as you did on King Valero's council, you'll make a fine ruler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`
  - -> `[35]`
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Vina Toras**
> ""I wouldn't go that far. But I do hope you'll tell me about your time in Queen Lyza's court one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Vina blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Elena looked fondly at Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""I'm pleased to see the young heiress here as well. A new Lyza the Great in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""Yes, welcome, Your Majesty. If you're half the young man your father made you out to be, you'll make a fine king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[35]`
  - -> `[43]`
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner and Mr. Esquibel. I look forward to working with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need your approval, Ms. Werner. If anything, you're the one who should be seeking mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This formality doesn't suit any of us. Elena, Laurento, it's great to see you both again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""Protocol is protocol, Your Majesty. Even if we've both known you since you were in diapers.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt my father ever praised me so highly. But thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for flattery. With your years of experience, I'm the one who should be bowing down to you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Elena Werner**
> ""Of-- of course. I misspoke. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's right. Fix your shirt, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[46]`
Mówca: **Laurento Esquibel**
> ""That's far too kind of you, Your Majesty. But I hope we old-timers can be of some assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""I'd love to. There are just a few updates I've got to share with your father first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[48]`
Mówca: **Narrator**
> "She put on a pair of half-moon glasses, then reached down into her purse, pulled out a thick, leather-bound ledger and flipped it open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `290` (*Rizia/Turn 1/Economy and Treasury Section*), Węzeł `[1]`

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Oh, hello, Princess Vina. Your Majesty, may I ask what your daughter is doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[274]`
  - -> `[55]`
  - -> `[6]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[56]`
  - -> `[5]`
  - -> `[45]`

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""Please accept House Azaro's formal congratulations on your coronation, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Salute her."]** — Mówca: **Player_Romus_Italic**
> "I raised my hand in a salute. Lucita smiled in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ask her yourself, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras accepts your congratulations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""My father always spoke highly of you, Your Majesty. I wish he was the one greeting you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Hugo hastily rebuttoned his shirt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Oh, excuse me. What brings you to these chambers, Your Highness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[60]`
Mówca: **Narrator**
> "As if on cue, I heard the voices of Elena Werner and Laurento Esquibel, my treasurer and the councilor of foreign affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Elena Werner**
> ""For Dast's sake, Laurento, you don't need to hold the door open for me every single time. I'm not as fragile as I look.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""I keep telling you, how could I allow a door to close on such a gorgeous face?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "I remembered their flirtatious routine from my days on my father's council. Nobody knew whether the two of them had actually had an affair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "As the two senior councilors stepped in, they immediately dropped the flirtatious routine and assumed a look of deference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[68]`
Mówca: **Narrator**
> "It was late afternoon when Vina and I headed back to the chambers for the first council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "It was late afternoon when I headed back to the chambers for the first council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_WineWithHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_WineWithHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_WineWithHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_WineWithHugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The day was sweltering, and a lingering haze from the wine we’d shared before lunch clouded my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "I was about to be inundated with updates and reports from my councilors -- I only hoped I could keep it all straight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Narrator**
> "The day was sweltering, and the morning meeting had left me drained. I was glad I’d turned down Hugo’s offer of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Narrator**
> "As we made our way through the palace gardens, an unsettling sense of being watched crept over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "As I crossed the palace gardens, I had the feeling I was being watched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[84]`
Mówca: **Narrator**
> "His face matched the photograph Hugo had shown me that morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[88]`
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Narrator**
> "His face matched the photograph Hugo had shown me that morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[88]`
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Sazon, I presume?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Ignore him and keep walking."]** — Mówca: **Player_Romus_Italic**
> "I ignored Manus Sazon and continued towards the council chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing here? Explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Manus Sazon**
> ""Pardon me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Narrator**
> "The man's face flushed. He looked down at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[91]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""I hold no land, Your Majesty. But you may use the title if you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`
  - -> `[252]`

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""I suppose you already know who I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""I think he wanted to talk to you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[102]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't talk to traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then he should request a formal audience with me like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time. It's not kingly to be late, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still a little drunk. I didn't want to embarrass myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_WineWithHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_WineWithHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_WineWithHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_WineWithHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Narrator**
> "We kept walking. Oddly enough, I still felt like someone had their eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[106]`
Mówca: **Narrator**
> "Even after I passed him, the sensation that someone was watching me continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[107]`
Mówca: **Narrator**
> "We entered the chambers, where Hugo was already waiting for us. No sooner had we sat down than a brief rap came at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I entered the chambers, where Hugo was already waiting for me. No sooner had I sat down than a brief rap came on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The son of a traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man who would topple the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's brave of you to approach me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're the traitor's son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're the man who would topple the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's brave of you to approach me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Narrator**
> "His fingers almost unconsciously began loosening his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Narrator**
> "He tugged at his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "His fingers almost unconsciously began loosening his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""I wanted to introduce myself before our first official meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Manus Sazon**
> ""I don't know what you've heard. But I assure you that's not my aim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[120]`
Mówca: **Manus Sazon**
> ""I-- well, in a nutshell, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""I may be the leader of the opposition, but I'm not your enemy. If you and I establish a dialogue, I believe we can work wonders for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Vina gave him an encouraging smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Vina Toras**
> ""How lovely of you to say that. I'm Vina Toras, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Narrator**
> "He resisted the urge to laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""I know. A pleasure to make your acquaintance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish we could stay and talk, but the Princess and I must be going. Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't speak to him, Vina. We're going to be late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are to stay away from me, Mr. Sazon. And even further away from my daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not uninterested in your proposition. But you'll have to request a formal audience with me like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Narrator**
> "His face went pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Manus Sazon**
> ""I-- I'm sorry, Your Majesty. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""I look forward to it, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "Vina waved as we walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[137]`
Mówca: **Manus Sazon**
> ""I understand. Looking forward to it, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[138]`
Mówca: **Vina Toras**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Manus Sazon**
> ""That's perfectly fine. I hope to speak again when it's more convenient, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Vina's face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He rushed away. Vina watched him go, disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""He was only trying to be nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice, my foot. That man has all kinds of ulterior motives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean it, Vina. I don't want you talking to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He shouldn't be cornering the King of Rizia on his way to an important meeting. The kid needs to learn decorum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[146]`
Mówca: **Vina Toras**
> ""He seems nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[147]`
  - -> `[143]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too smitten. He's the opposition, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's friendlier than I expected. I could imagine working together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[149]`
Mówca: **Narrator**
> "He looked at me expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could stay and talk, but I must be going. Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not interested. If you'll excuse me, I'm going to be late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't approach me outside of work again, Mr. Sazon. This is my only warning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not un-interested. But you'll have to request a formal audience with me like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[154]`
Mówca: **Narrator**
> "His face went pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Manus Sazon**
> ""I-- I'm sorry, Your Majesty. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""I look forward to it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "He gave a small wave as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""I understand. Looking forward to it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""That's perfectly fine. I hope to speak again when it's more convenient, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Narrator**
> "He rushed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[161]`
Mówca: **Narrator**
> "I continued towards the council chambers. Oddly enough, I still felt like someone had their eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[162]`
Mówca: **Narrator**
> "We continued towards the council chambers. Oddly enough, I still felt like someone had their eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Without waiting for an answer, Lucita Azaro rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "The new war and security councilor was younger than I'd imagined. She carried herself with a mix of regal elegance and soldierly authority."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Lucita Azaro**
> ""Gentlemen. Pardon my interruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Narrator**
> "She bowed towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""A military man. How could I forget?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""I'm sorry I couldn't make it to the coronation. I heard everything ran smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""General Taddeus sends his regards. Or he would if he were capable of speaking in full sentences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Lucita Azaro**
> ""He sends his regards. Or he would if he were capable of speaking in full sentences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Narrator**
> "She was trying to be flippant, but I could sense emotion behind her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`
  - -> `[180]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the General. He's got some fight left in him yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
Mówca: **Narrator**
> "She was trying to be flippant, but I could sense emotion behind her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[181]`
  - -> `[182]`
  - -> `[180]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This must be a difficult time for you. Let me know if there's anything I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for pleasantries. Where are the others?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope he heals swiftly. I was counting on his expertise as a councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Lucita smiled with pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Narrator**
> "She frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""Two of them were right behind me on the stairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""The others should be right behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""I'll do my best to serve in his stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[188]`
Mówca: **Narrator**
> "The corners of her mouth twitched downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""I'm not a porcelain doll, Your Majesty. My ability to perform my duties is in no way compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[190]`
Mówca: **Narrator**
> "On seeing me, they dropped the act and assumed a look of deference. Laurento smoothly removed his fedora, revealing a well-oiled mane of gray hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[191]`
Mówca: **Narrator**
> "Once all the councilors were seated, Hugo began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_IgnoreFirstMeeting = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Celebrations_Large = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_CoronationParty_Large == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_CoronationParty_Large == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_CoronationParty_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn01_CoronationParty_Large == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_CoronationParty_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_CoronationParty_Medium == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn01_CoronationParty_Medium == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_CoronationParty_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn01_CoronationParty_Medium == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_CoronationParty_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Celebrations_Small = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Your form is slightly off. But an admirable effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Elena nodded. Her businesslike demeanor briefly softened as she looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Laurento smoothly removed his fedora, revealing a well-oiled mane of gray hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[209]`
Mówca: **Narrator**
> "Elena nodded briskly. Despite her grandmotherly appearance, her demeanor was all business."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Once all the councilors were seated, Hugo began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Well -- not the entire council. The Grand Wiseman is in Plavo, preparing for the upcoming religious ceremony with His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""But he needn't involve himself in earthly concerns like our royal treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "He smiled to himself, then gestured to Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""No, indeed. That's for me to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[215]`
Mówca: **Elena Werner**
> ""And work we will. We have so much ahead of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[216]`
Mówca: **Narrator**
> "I looked back for just long enough to see a flash of gold. Titus. Of course."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[217]`
Mówca: **Narrator**
> "I looked back for just long enough to see a flash of gold. Titus. Of course."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[218]`
Mówca: **Elena Werner**
> ""Frankly, I'm glad to see you taking such an interest in our financials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Elena Werner**
> ""Between myself and the House of Delegates, we were able to keep everything running smoothly in the absence of clear guidance from your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Elena Werner**
> ""But with a king of your caliber at the helm, there's no telling how high we can soar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[227]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""History shall know me as Romus the Fiscally Responsible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your hard work during my father's decline is to be commended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please leave my father out of this. I'd prefer to be judged on my own merits, not compared to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not speak ill of His Majesty. He did the best he could in the face of his many enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[225]`
Mówca: **Elena Werner**
> ""Very catchy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[226]`
Mówca: **Elena Werner**
> ""Thank you. It was indeed quite the stressful time for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[230]`
Mówca: **Elena Werner**
> ""That is undoubtedly true, Your Majesty. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Elena Werner**
> ""Understandable, Your Majesty. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Elena Werner**
> ""I think that's enough for today. But we will have to come to a decision regarding our resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[233]`
Mówca: **Elena Werner**
> ""Gold and energy exports have gotten us to where we are today, but if we are to stay relevant and protect our economy from global fluctuations, we need to diversify. I suspect you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Elena Werner**
> ""I'll let you think about it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Hugo Toras**
> ""Thank you, Ms. Werner. This was indeed enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Laurento Esquibel**
> ""A pleasure to share these chambers with you once more, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""A pleasure to finally share these chambers with you, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Lucita Azaro**
> ""Yes. I'm looking forward to our upcoming security briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Narrator**
> "My councilors left. I sat for a few more minutes, reflecting on what Elena and the others had said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""And congratulations on surviving your first council meeting, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Vina Toras**
> ""I found it fascinating, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[249]`
Mówca: **Narrator**
> "They smiled at each other, not altogether sincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, Duke Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you here in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[253]`
Mówca: **Narrator**
> "I motioned for her to stand. Her eye was fixated on my uncle's shirt as she raised herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing = true; RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing"] = true;
Variable["RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment = true;
RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies = true;
RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies = true;
RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners = true;
RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[257]`
Mówca: **Elena Werner**
> ""Secondly, there's the matter of living standards. Improving the quality of life for our citizens naturally leads to higher administrative expenditures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Elena Werner**
> ""Thirdly, if you do decide to listen to Duchess Azaro and expand our defense capabilities, keep in mind that the cost of upkeep for our armed forces will rise accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Elena Werner**
> ""Lastly, energy management poses its own challenges. As we approach the limits of our grid's capacity, we may incur additional storage costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`
  - -> `[265]`
  - -> `[266]`

### Węzeł `[260]`
Mówca: **Elena Werner**
> ""The first point to consider is industrial growth. I am all for expanding production and construction, but we should make sure we have the energy to keep our facilities humming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[261]`
Mówca: **Elena Werner**
> ""I'd like to discuss several economic considerations. We should anticipate potential expenses arising from our impending fiscal policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[269]`
  - -> `[268]`

### Węzeł `[262]`
Mówca: **Narrator**
> "Elena glanced down at her notes, her expression contemplative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This information is invaluable, Elena. I appreciate your insights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That'll be a long way off in the future. I have more pressing worries at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have full confidence in your ability to handle these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very good to know. I'll make my decisions accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please elaborate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've covered enough ground for today. Let's adjourn the meeting soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm accustomed to handling unexpected challenges. A detailed explanation isn't necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's here to learn from the King, as I learned from my father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's here to receive tutelage from the best minds this kingdom has to offer. Yours included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""I'm flattered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[276]`
Mówca: **Narrator**
> "They looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""You are most welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[279]`
Mówca: **Elena Werner**
> ""Very well. It seems like you've got a good grasp on our financials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[281]`
Mówca: **Narrator**
> "Then, suddenly, I caught sight of a young man standing by the path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Then, suddenly, I caught sight of a young man standing by the path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""Thank you anyway, Ms. Werner. I'll be sure to deliver your reports to His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Briefing Skipped)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Presiding over their first council as King", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Presiding over their first council as King","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Economy_Diversification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Mixed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Mixed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Economy_Mixed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Elena Werner**
> ""While gold and energy exports remain the backbone of our economy, supplementing them with other industries will make us more robust and less vulnerable to global fluctuations. I suspect you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""If gold and energy exports are to remain the backbone of our economy, we need to focus on finding new sources. Of course, we could also try to develop other industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
