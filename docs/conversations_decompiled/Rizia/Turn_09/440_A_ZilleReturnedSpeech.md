# Rizia/Turn 9/A_ZilleReturnedSpeech

- **ID konwersacji:** `440`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/440_A_ZilleReturnedSpeech.md`
- **Liczba węzłów dialogowych:** 319
- **Liczba wyborów gracza:** 76

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`
- `RiziaDLC.Policy_Economy_IncomeTax10`
- `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Resources_Military_RumburgianBFFMercenaries`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Success`
- `RiziaDLC.ZilleReferendum_StoppedByAN`
- `RiziaDLC.ZilleReferendum_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Authority_Modifier_TerritorialReclaimation`
- `RiziaDLC.Budget_Modifier_IncomeTax`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_Diplomacy_ZLLAActive`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome`
- `RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii`
- `RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival`
- `RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 29

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Authority_Modifier_TerritorialReclaimation`
- `RiziaDLC.Budget_Modifier_IncomeTax`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome`
- `RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations`
- *...oraz 4 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[44]` (Paskal Beniwoll): `AddConversant("Estela Toras");`
- Węzeł `[45]` (Paskal Beniwoll): `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- Węzeł `[102]` (Paskal Beniwoll): `End();`
- Węzeł `[119]` (Paskal Beniwoll): `AddConversant("Estela Toras");`
- Węzeł `[130]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[154]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations"] = true;`
- Węzeł `[155]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote"] = true;`
- Węzeł `[159]` (Paskal Beniwoll): `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
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
  - -> `[318]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My esteemed subjects, today marks a momentous occasion in the history of our great realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[11]`
  - -> `[30]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The strength and fortitude of those living under Wehlen's yoke has been an inspiration to us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[8]`
  - -> `[13]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we will march forward into the annals of history, hand in hand, as proud citizens of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Zille's return, we stand poised to achieve greatness beyond measure, as one people, one kingdom, united in purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[9]`
  - -> `[15]`
  - -> `[34]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After a prolonged period of estrangement, Zille is finally returning home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[4]`
  - -> `[12]`
  - -> `[25]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But let's not dwell on the trials of the past, but rather look towards the promise of a future forged in unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Therefore, raise your voices in celebration, for today marks the dawn of a new era for our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[5]`
  - -> `[16]`
  - -> `[35]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Citizens of Zille, let us revel in the glory of our triumph over the iron fist of Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[11]`
  - -> `[30]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it was the Crown's strength and determination that secured this victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[12]`
  - -> `[25]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To those who stood with us in our quest to reclaim what is rightfully ours. Your loyalty shall be remembered and rewarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[8]`
  - -> `[13]`
  - -> `[32]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As one nation, united under our banner, we shall forge a future of unparalleled greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The return of Zille serves as a testament to the strength of the monarchy and the inevitability of our victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[15]`
  - -> `[34]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so, my loyal subjects, let us seize this moment as an opportunity to reaffirm our commitment to our kingdom's unmatched dominance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[16]`
  - -> `[35]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As one, we shall crush all who would dare to defy us and cement our legacy as the unquestioned rulers of this land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My subjects, today brings a somber moment as we witness the return of Zille, a land marred by suffering and division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[24]`
  - -> `[23]`
  - -> `[7]`
  - -> `[30]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the resilient people of Zille, I offer my deepest sympathies. Your resilience in the face of adversity was a beacon of light in such dark times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[8]`
  - -> `[13]`
  - -> `[32]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looking back on what you endured, remember the solidarity that sustained you. In shared suffering, you found the strength to persevere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While the road to liberation was fraught with challenges, overcoming those hardships has helped us emerge stronger than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[9]`
  - -> `[15]`
  - -> `[34]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So let us honor the memories of those we have lost and the dreams that have been shattered along the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[5]`
  - -> `[16]`
  - -> `[35]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the sacrifices of those who fought for freedom guide us forward with resilience and hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The path before us was arduous, but in the end, we persevered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[4]`
  - -> `[12]`
  - -> `[25]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, it was through the strength and determination of the Crown that this victory has been achieved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[4]`
  - -> `[12]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our brothers and sisters in Zille, I offer my humble prayers and deepest blessings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[8]`
  - -> `[13]`
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dear brethren, today heralds a sacred moment as we witness the return of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[7]`
  - -> `[11]`
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it was through our enduring faith in the Almighty that this victory has been attained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[4]`
  - -> `[25]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, it was through our enduring faith in the Almighty that this triumph has been attained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[4]`
  - -> `[12]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United in our devotion and reverence, let us give thanks for the divine grace that has reunited us with our brethren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we'll walk the path of righteousness, guided by the eternal light of our faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[9]`
  - -> `[15]`
  - -> `[34]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In conclusion, we extend prayers of gratitude and thanksgiving for the divine blessings that have brought Zille back into our fold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[5]`
  - -> `[16]`
  - -> `[35]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And may our faith continue to strengthen us as we embark on this sacred journey together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The familiar scent of saltwater filled the air, prompting old memories to rush back to me and a single word to escape my lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""I really have missed this place, despite the dismal state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[38]`
  - -> `[263]`
  - -> `[266]`
  - -> `[275]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll fix it up so that it's exactly the way that it was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a difficult time for all of us. But it's over now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. Father's decision to hand over Zille to Wehlen cast a shadow over my entire reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[46]`
Mówca: **Narrator**
> "She stopped before turning to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my duty, Mother. For our kingdom, and for our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad I could step in where Father fell short. Wouldn't want his legacy tarnished any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very kind of you to say. I'm truly touched.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille belongs with us. Plain and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""And you fulfilled that duty admirably, my dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The distant tolling of a bell tower interrupted her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Estela Toras**
> ""Time to go. The festivities will be starting soon. And someone here is scheduled to give a speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "With a nod of acknowledgment, we left her childhood home behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never thought I'd see the day...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The pain of what King Valero let us lose, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""Consider the shadow lifted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[59]`
Mówca: **Estela Toras**
> ""Thank Dast for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[60]`
Mówca: **Estela Toras**
> ""Don't speak ill of your father. Now is neither the time nor the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Estela Toras**
> ""Although, I would be remiss to ignore the impact his decisions have had on our family and kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Halting, Mother turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Estela Toras**
> ""I'm proud of you, son. If not for your leadership, this house and so many others would have been lost forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, Mother, you had it easy compared to the rest of us. And by us, I mean me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Estela Toras**
> ""Well, forgive me for not shedding tears over your royal discomfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "An uncomfortable silence stretched between us. Finally, Mother broke the tension with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[67]`
Mówca: **Estela Toras**
> ""Well, I wouldn't say it if it wasn't true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Estela Toras**
> ""His legacy may have had its flaws, but please don't discount the sacrifices he made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""You've seen firsthand how hard it is to keep this kingdom together...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""The only thing left to do now is decide who's in charge...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[71]`
Mówca: **Narrator**
> "As we made our way through the city, I felt a sense of renewal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The streets bustled with activity, alive with the energy of the festival. The once-damaged tenement buildings now stood proudly, freshly repainted to conceal the scars of the past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Before long we passed a sign for Smolak Square, where the event was being held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Soldiers from the Rizian army were dispersed throughout the crowd, watchful for any sign of trouble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Walking towards the center of the square, I couldn't ignore the solemnity of the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Memories of that fateful day flooded back to me -- the chaos, the screams, the confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[77]`
Mówca: **Narrator**
> "It wasn't long before I was led to the podium to deliver my speech. Mother gently placed her hand on my arm, stopping me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[89]`
  - -> `[88]`
  - -> `[90]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True change comes from within. Our focus should be on uplifting people's spirits before we tackle the task of renaming squares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Back to Fedo Square?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's best we keep it as is. Knowing Smolak, it'd be sure to cause an international incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""You should have the square's name changed as soon as humanly possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[81]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're absolutely right, Mother. It's time to rid our city of reminders of the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
Mówca: **Estela Toras**
> ""The Sazons would love that, I'm certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""If renaming a square is all it takes to cause an international incident, then perhaps we need to reevaluate our diplomatic strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[86]`
Mówca: **Estela Toras**
> ""Good. The last thing we'd want is any reminder of that slimeball.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""If that's what you believe, dear, then I won't argue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. I'll do my best to represent our kingdom with dignity and grace as you have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luck is for the weak, Mother. But thanks all the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Good luck?' Please... I make my own luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the sentiment, Mother. May the divine light guide my words and actions as I address our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Narrator**
> "A smile graced her lips before she gave me a light kiss on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Mother rolled he eyes and shook her head, seeming only slightly annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[94]`
Mówca: **Narrator**
> "A gentle smile adorned her face before she kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Mother rolled her eyes and shook her head, though her demeanor suggested she wasn't truly upset."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[96]`
Mówca: **Narrator**
> "As I stepped onto the stage and took my place behind the podium, the crowd erupted in applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[97]`
Mówca: **Narrator**
> "As I finished my speech, the crowd broke into loud cheers once more, their joy reverberating through the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[98]`
Mówca: **Narrator**
> "I accepted it, quickly scanning its contents before taking up the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "And without a moment's hesitation, I signed my name, fulfilling a promise now complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I glanced over at my mother. She had tears shining in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Offering her a reassuring smile, I turned back to the crowd, the memory of their praise etched into my mind forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[103]`
Mówca: **Narrator**
> "My mother and I stood before the chain-link fence that now surrounded her old childhood home in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The beachfront shack looked as rundown as before, but, this time, a giant Wehlen flag fluttered proudly from its facade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Mother turned to me, simmering with palpable resentment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Estela Toras**
> ""So it's Smolak's house now. I can't believe my beloved son would agree to such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[107]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you rather that all of Zille belonged to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Estela Toras**
> ""Of course not. But this parting shot of his is almost too insulting to bear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Mother sighed heavily, her anger warring with her sense of duty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""But you made the right decision. You didn't stoop to his childish level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I truly regret promising it to him. But it was the only option left after years of negotiation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was falling apart anyway. You'd never have moved back in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wasn't a one-sided bargain. Did you see the doorstopper he gave me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""He was toying with you, Romus. As he has been for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[115]`
Mówca: **Estela Toras**
> ""You know that's not the point, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[116]`
Mówca: **Estela Toras**
> ""Oh, I saw it, all right. No buts about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[117]`
Mówca: **Narrator**
> "She took a final look back at the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""I'm proud of you, son. If not for your leadership, many more homes than mine would have been lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[123]`
Mówca: **Narrator**
> "On the other side of the square, a group of Derdian and Bludish Golcondists led a series of victorious-sounding chants. I could just make out the words "Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Only a select few knew that the crowd had been meticulously orchestrated, ensuring that only my supporters were present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[128]`
Mówca: **Narrator**
> "My thoughts were then abruptly interrupted by the distant shouts of Wehzek protesters at the back of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "Instruct security to remove them."]** — Mówca: **Player_Romus_Italic**
> "With a brief nod and a discreet hand gesture, I indicated for the protesters to be removed as quietly as possible, without making a scene."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[134]`
Mówca: **Estela Toras**
> ""Even if you had to resort to rather... unconventional tactics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your sentiments, but let's not overlook the people of Zille. Their votes and collective will are the reason why we're here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""Their resilience was truly remarkable. All those years without giving up hope...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Estela Toras**
> ""Ah, yes, the power of this so-called 'democracy at work' I keep hearing about. No extra persuasion necessary, I'm sure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[144]`
Mówca: **Narrator**
> "I spotted a group of Su Omina members, proudly displaying their insignia and banners."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[148]`
Mówca: **Narrator**
> "A group of ATA volunteers glared at them in obvious contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Local Zille representatives approached me, holding a leather portfolio containing the legislation that would officially reunify Zille with Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I accepted it, quickly scanning the referendum results before taking up the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Mother briefly paused when she reached the bedroom, gazing ruefully at the peeling paint on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I chose to ignore the protesters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_StoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[176]`
Mówca: **Narrator**
> "It was then that I noticed my daughter and her husband sitting in the very front row. Manus' eyes met with mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Next to him, Angelica Sazon wore a deadly serious expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "The applause subsided. I began to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[3]`
  - -> `[10]`
  - -> `[27]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Narrator**
> "It was then that I noticed Angelica Sazon in the front row. She wore a deadly serious expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Cheers erupted once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you all know, Zille has historically been a vital part of the province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[195]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the members of House Sazon for their patience in awaiting the return of this part of their ancestral homeland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not forget the reason we lost Zille in the first place. Because of the rebellion led by the traitorous Duke Lucas Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[196]`
  - -> `[197]`
  - -> `[200]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I myself attach many happy childhood memories to Zille. It holds a special place in my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[211]`
  - -> `[210]`
  - -> `[212]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I myself am one-half Zillean. This region holds a special place in my heart and that of my mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[211]`
  - -> `[210]`
  - -> `[212]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with joy that I announce the return of Zille to its original custodians, Brenas and House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, I'm a forgiving king. Therefore, I announce the return of this land to its rightful custodians. Zille shall once again belong to Brenas and House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To return it to the Sazons would reward their misdeeds. I therefore announce that Zille will be governed like Rizia Imperii, by the central government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, returning it outright would reward the Sazons for their misdeeds. Therefore, Zille shall be ruled by the central government, just as Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But in these precarious times, we need unity, not feudalism. Zille shall be guided by the firm hand of the central government, not a noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But in these precarious times, we need unity, not feudalism. Zille shall be firmly governed by the central authority, not one noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the meantime, the Sazons have proven themselves to be great allies. I shall therefore allow them to resume governance of the region that was taken from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And now that House Sazon and House Toras are reconciled, I find it only fitting to name the Sazons stewards of this land once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that House Sazon will take good care of it once it is reincorporated into Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I, therefore, cannot simply hand it back to House Sazon and Brenas. It will belong to the central government's jurisdiction, as Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with joy in my heart that I announce the return of Zille to its original custodians, Brenas and House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that spirit, and in the interest of promoting unity over feudalism, Zille shall belong to Rizia Imperii from henceforth onwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas = true;
RiziaDLC.Authority_Modifier_TerritorialReclaimation += 1;
RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas = true;
RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas = true;
RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_Brenas");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true;
Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] = Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] + 1;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory"] = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_Brenas");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_RiziaImperii = true;
RiziaDLC.Authority_Modifier_TerritorialReclaimation += 2;
RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii = true;
RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii = true;
RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_RiziaImperii");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true;
Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] = Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] + 2;
Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory"] = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_RiziaImperii");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[218]`
Mówca: **Narrator**
> "There was some applause from the crowd, as well as a few murmurs of concern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Angelica Sazon angrily rose from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Her son grabbed her arm and gently persuaded her to sit down once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[224]`
Mówca: **Narrator**
> "With a haughty glance in my direction, she turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Narrator**
> "Angelica Sazon stood and applauded fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Manus and Vina joined her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Narrator**
> "A group of Sazon supporters began chanting "Glovurius axa Sazoni!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[234]`
Mówca: **Narrator**
> "I motioned for the crowd to quiet down. I had to finish my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[6]`
  - -> `[14]`
  - -> `[33]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.ZilleReturn_Success"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City_HouseSazon");)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_HouseSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City_HouseSazon");)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Nanta","Rizia_City_HouseSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Nanta","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_IncomeTax += 4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_IncomeTax += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_IncomeTax += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_IncomeTax += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[256]`
Mówca: **Narrator**
> "As my mother and I stepped out of the car, we were met with a sea of cheering faces, their palpable enthusiasm filling the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[48]`
  - -> `[47]`
  - -> `[135]`

### Węzeł `[261]`
Mówca: **Narrator**
> "The scent of saltwater filled the air. Almost involuntarily, a single word escaped her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Estela Toras**
> ""Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll turn it into a magnificent villa. The Queen Mother's very own luxury retreat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and me both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[268]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Estela Toras**
> ""That would just feel wrong. Although I wouldn't mind upgrading the bed linens to a higher thread count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Estela Toras**
> ""Nothing will be exactly the way it was, darling. We can't bring back the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Estela Toras**
> ""I'm glad you're as attached to the house as I am. It shows the King hasn't forgotten his roots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
Mówca: **Estela Toras**
> ""But bringing back the house? That would be lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Personally, I had no doubt in my mind that Zille would be ours again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Estela Toras**
> ""I look forward to the day when I can come here without being reminded of the pain of what we lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[57]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too used to it. I gave the Sords permission to turn the house into another resort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Narrator**
> "She stared daggers at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Estela Toras**
> ""If you think that's funny, you're as bad as Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Narrator**
> "I spotted a group of ATA volunteers, proudly waving Rizian flags."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Narrator**
> "On the other side of the square, a group of Derdian Golcondists led a series of victorious-sounding chants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
Mówca: **Narrator**
> "On the other side of the square, a group of Bludish Wehzeks led a series of victorious-sounding chants. I could just make out the words "Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_StoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[302]`
Mówca: **Narrator**
> "AN peacekeeping forces were dispersed throughout the crowd, watchful for any sign of trouble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[312]`
Mówca: **Narrator**
> "Manus Sazon's brow was knitted. Vina put a comforting arm around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[313]`
Mówca: **Narrator**
> "I walked alongside my mother through her dilapidated childhood home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[314]`
Mówca: **Narrator**
> "I walked alongside my mother through her dilapidated childhood home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Where the former grandstand once stood, there was now a memorial to the victims of the bombing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[316]`
Mówca: **Narrator**
> "They were shouting that the will of the people of Zille had been ignored."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[162]`

### Węzeł `[317]`
Mówca: **Narrator**
> "Some audience members joined them while others sat with their arms crossed, looking dissatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Proclaiming the return of Zille", "Smolak Square", "Zille");)*
- **Efekt (`userScript`):** `SetRichPresence("Proclaiming the return of Zille","Smolak Square","Zille");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
