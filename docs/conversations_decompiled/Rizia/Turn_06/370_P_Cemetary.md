# Rizia/Turn 6/P_Cemetary

- **ID konwersacji:** `370`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/370_P_Cemetary.md`
- **Liczba węzłów dialogowych:** 909
- **Liczba wyborów gracza:** 176

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_RD_Law_NurityStateReligion`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Prologue_DadLetter`
- `RiziaDLC.Prologue_DadLetter_ThrowAway`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_InBoatAccident`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Religion_Leaning_Theocratic`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Happy`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Turn02_Intention_NoMonarchy`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.VinaManus_Together`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.War_Incident_Naval`
- `RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina`
- `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Estela_PromisedToConvert`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Turn06_Cemetary_DadLetterBurn`
- `RiziaDLC.Turn06_Cemetary_HonorDadLegacy`
- `RiziaDLC.Turn06_Cemetary_HonorDadPales`
- `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales`
- `RiziaDLC.Turn06_Cemetary_WalkOwnPath`
- `RiziaDLC.VinaManus_Together`
- `RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina`
- `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope`
- `RiziaDLCIsolated.Turn06_Cemetary_ZilleChat`
- `RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave`
- `RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy`
- `RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove`
- `RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave`
- `RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales`
- `RiziaDLCSupport.News_Turn06_Sov_Memorial`
- `RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina`
- `RiziaDLCSupport.Turn06_Cemetary_FathersGrave`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 42

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Turn06_Cemetary_HonorDadPales`
- `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales`
- `RiziaDLCIsolated.Turn06_Cemetary_ZilleChat`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[46]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = true;`
- Węzeł `[47]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = false;`
- Węzeł `[103]` (Paskal Beniwoll): `End();`
- Węzeł `[104]` (Paskal Beniwoll): `AddConversant("Estela Toras");`
- Węzeł `[105]` (Paskal Beniwoll): `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- Węzeł `[110]` (Paskal Beniwoll): `AddConversant("Vina Toras");`
- Węzeł `[322]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- Węzeł `[388]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy"] = true;`
- *...oraz 34 innych węzłów ze skryptami.*

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
  - -> `[908]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The National Mausoleum, high in the hills above Porte Drazon, embraced me with its stately presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was here for the annual Sovereign Memorial Commemoration, a ceremony honoring the former monarchs of Rizia, held just outside the mausoleum's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The hushed corridors were adorned with statues and inscriptions of monarchs from eras long past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The mausoleum stood as a witness to the enduring legacy of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I had also come to honor the memory of my late wife, Lena, whose resting place could be found within these hallowed grounds as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Adjacent to it stood a bouquet of recently placed flowers, a weekly tradition per Vina's instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Take a flower."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Leave the flowers as is."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I took a flower from the bouquet and smelled it. The scent of roses still reminded me of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[12]`
Mówca: **Narrator**
> "As I stood in contemplation, reflecting upon our time together, a gentle voice called from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[13]`
Mówca: **Estela Toras**
> "“Romus...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[14]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Mother? This is a surprise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "She hadn’t attended a Sovereign Memorial Commemoration since Father’s passing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Estela Toras**
> "“At my age, surprises are as rare as non-gray hairs. Don't act as though my presence is some extraordinary revelation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[17]`
Mówca: **Estela Toras**
> "“And, for the record, I can still navigate these halls without assistance--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Her eyes swept across the room, coming to rest on Lena's grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Estela Toras**
> "“Forgive my lack of decorum. I should treat this day with the gravity it deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Gradually, she drew near, her eyes conveying unexpressed sentiment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[21]`
Mówca: **Estela Toras**
> "“You of all people know what an extraordinary woman she was. Though I confess it took me a while to warm up to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[39]`
  - -> `[40]`
  - -> `[43]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“What was extraordinary about her? She was just another entitled noblewoman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Estela Toras**
> "“That's what I thought as well, darling. At first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[24]`
Mówca: **Estela Toras**
> "“I remember the exact moment my feelings toward Princess Lena changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[25]`
Mówca: **Estela Toras**
> "“It was right after the civil war broke out in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[26]`
Mówca: **Estela Toras**
> "“Up to that point, I was adamant that Rizia should accept as few Wehzek refugees as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""The next day, I persuaded Valero to open our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[581]`
  - -> `[566]`
  - -> `[569]`

### Węzeł `[28]`
Mówca: **Narrator**
> "My mother reached into her handbag and held up a weathered envelope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Take the envelope."]** — Mówca: **Player_Romus_Italic**
> "I took the envelope from her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "Don't take the envelope."]** — Mówca: **Player_Romus_Italic**
> "I didn’t take the envelope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[31]`
Mówca: **Estela Toras**
> "“A love letter from your father -- the first one he ever wrote. I want to honor him by giving it back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[45]`
  - -> `[32]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Quite the keepsake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds like her -- placing compassion before practicality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena and I never spoke about such weighty topics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Love... now that's a word I rarely hear you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were her mother-in-law. There's always some friction in that relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know she was extraordinary? You two barely spoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well. Fancy meeting you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't know you felt that way about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not surprising at all. Everyone who met Lena loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very thoughtful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Estela Toras**
> "“A love letter from your father -- the first one he ever wrote. I thought it only fitting to give it back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[45]`
  - -> `[32]`
  - -> `[293]`

### Węzeł `[49]`
Mówca: **Narrator**
> "My mother left the room, and I followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "We made our way down the great hall, past the resting places of the great leaders, and some not-so-great, who came before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[51]`
Mówca: **Narrator**
> "It wasn’t long before the light from the Eternal Flame, a single torch placed at the late king’s sarcophagus symbolizing a monarch’s enduring reign, guided us the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "As we neared, my mother’s pace slowed as if waves of memories pressed upon her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[317]`
  - -> `[314]`
  - -> `[316]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The flame's flickering glow cast dancing shadows on our path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "We stopped just before we reached my father’s stone encasing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Estela Toras**
> "“There you are...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "We both fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[57]`
Mówca: **Estela Toras**
> "“If you don’t mind, I’d like to say a few words to your father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[58]`
  - -> `[83]`
  - -> `[118]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Please, by all means.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Estela Toras**
> "“Val... For 45 years, we walked different paths, our views often conflicting, and our words sometimes harsh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Estela Toras**
> ""But the love between us never waned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[61]`
Mówca: **Estela Toras**
> ""So, in this space between the living and the departed, I speak these final words. My reserved heart lays bare the truth...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[62]`
Mówca: **Narrator**
> "She presented the letter to the flame, watching as it intensified, consuming the paper until it vanished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[63]`
Mówca: **Estela Toras**
> "“May he rest in peace as his legacy lives on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[225]`
  - -> `[64]`
  - -> `[866]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Legacy... I doubt history will be very kind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Estela Toras**
> "“I’m not speaking of his actions on the throne. His legacy is you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[66]`
  - -> `[229]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“A heavy burden to bear -- a name forever stained by the judgments of time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Estela Toras**
> "“Legacies are shaped by more than just deeds. What you make of the name matters just as much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[92]`
  - -> `[91]`
  - -> `[68]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I can't escape the shadows of his choices, no matter what path I forge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""Maybe not, but you can cast new shadows that speak of redemption and resilience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Estela Toras**
> "“Sometimes, the most profound responsibilities are the ones we inherit, not by choice, but by destiny.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[95]`
  - -> `[94]`
  - -> `[71]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Destiny or not, I'll strive to leave a legacy that stands apart from the mistakes of my father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“My triumph over Pales will rectify his failure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Estela Toras**
> "“Or be your undoing, just like him. His relentless pursuit of victory at any cost consumed him, as I fear it may be consuming you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "I began pacing around the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`
  - -> `[99]`
  - -> `[75]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You know nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Estela Toras**
> "“So sure of yourself. I'll tell you what I do know... ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Estela Toras**
> "“I know that my son is determined to embark on some military expedition when his attention should be focused on the rightful restoration of Zille.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Estela Toras**
> "“I know that the very foundations of the monarchy have been put at risk through such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[79]`
Mówca: **Estela Toras**
> ""And speaking of risk... I've heard whispers about your *escapades* with House Azaro, a family harboring their own ambitions regarding the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[244]`
  - -> `[72]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[267]`
  - -> `[264]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you insist, but please make it brief. I don't have all day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll give you some privacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find comfort in knowing that his legacy lives on, but it doesn't change the pain of his absence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For better or worse, his legacy will live on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Recognizing the past's influence on the present is crucial, guided by divine blessings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, my father's and my legacies are intertwined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder to choose our path with care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What matters is what I do, not what the name did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ensure the name stands strong, even if it means shouldering the weight alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My actions speak louder than any family name. I'll forge my path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, like divine threads in a grand design, guiding us toward a purpose beyond our choosing, much like Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father's path proved it's the choices, not fate, that shape our destiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll embrace whatever responsibilities destiny throws at me, be it triumphs or defeats, much like my father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My victory over Pales will honor his memory by finishing what he started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God willing, my victory over Pales will honor his memory by finishing what he started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, but this time will be different. God is on our side. I can feel it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't see into the future any more than anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[100]`
Mówca: **Estela Toras**
> ""Farewell, until we meet where love knows no bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[101]`
Mówca: **Estela Toras**
> ""The years may have etched lines on our faces, but they also deepened my affection for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""My heart bears no bitterness. Instead, it carries the memories of laughter, shared moments, and a touch beyond words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
Mówca: **Narrator**
> "Vina, of course, was by my side. Her demeanor had become much more solemn since her return from Pales. She clasped her hands tightly around the bouquet she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[114]`
Mówca: **Narrator**
> "I gave her some space to allow for a moment between the two of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "She spoke to him in a hushed whisper, for much longer than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "When she was finished, she took out the love letter and placed it on the sarcophagus. I took this as my cue to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do mind. You could have said what you needed to say within the past four years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[121]`
Mówca: **Narrator**
> "I stepped away, granting her some space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Narrator**
> "She folded her arms and scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Estela Toras**
> ""I was speaking rhetorically, Romus. I'll grieve as I see fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[124]`
Mówca: **Narrator**
> "She spoke to him in a hushed whisper, prolonging the conversation far longer than I anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Narrator**
> "When she finally concluded, she retrieved the love letter and let the flames of the torch consume it. Taking this as my cue, I returned to her side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[126]`
Mówca: **Vina Toras**
> ""Feels like we were just here. I miss her so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[138]`
  - -> `[137]`
  - -> `[128]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We all do, dear. She's always with us in our hearts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I know. But I'm still filled with regret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault, Vina. You couldn't have predicted it. It was a tragic accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Vina Toras**
> ""It was my own pleading that steered us into that storm. We should have never set foot on that boat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[141]`
  - -> `[140]`
  - -> `[132]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother wouldn't want you carrying that burden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[135]`
Mówca: **Vina Toras**
> ""But she would still be here if I hadn't asked her to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[514]`
  - -> `[510]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're here because it's what people do. They come, they remember, and then they move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother's presence is timeless, and it's only right that we revisit this place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but time moves on, so we must as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were a child. I was the one who refused the trip. If I had gone, I could've been there to save her life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Blaming yourself for the storm won't bring her back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The storm wasn't your doing. You need to move past this fixation with what could have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We all do, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[143]`
Mówca: **Narrator**
> "It wasn't long before we reached her mother's tomb. Vina set the bouquet in a vase next to the sarcophagus, which had been encased in gold, as was tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""I gathered these roses from the Royal Garden. They're the absolute best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[145]`
Mówca: **Narrator**
> "We shared a quiet moment without words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[146]`
Mówca: **Estela Toras**
> ""Well, there you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Estela Toras**
> "“And, for the record, I can still navigate these halls without assistance, thank you very much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Vina! It's so good to see you. You're looking as lovely as ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Vina Toras**
> ""You, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Vina went to her, and they exchanged a brief embrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.VinaManus_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[157]`
Mówca: **Vina Toras**
> ""Speaking of which, I'm going to meet Manus for a short walk before the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We felt it would be more appropriate to limit visiting Lena to family only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""Hm. He didn't feel like joining you here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[543]`
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Before I could fully grasp the moment, she reached for my hand and delivered a sincere squeeze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Narrator**
> "I stared at the tomb, allowing memories of Lena and the boat accident to flood my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Narrator**
> "We shared a quiet moment without words until a voice from behind caught our attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[166]`
Mówca: **Narrator**
> "I was on the verge of becoming lost in thought when a voice called to me from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. He's quite busy now that he's majority speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena would have hated to see her daughter dating a Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would be the point? Lena wasn't *his* mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Despite the absence of romance, I owed it to Vina, whose captivity consumed my thoughts, to pay my respects."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Soon, I found her sarcophagus, encased in gold as per tradition. A heavy silence settled over me as I stood before it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[172]`
Mówca: **Narrator**
> "I'd endured many sleepless nights since she was taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Narrator**
> "She reached out and took Vina's hand, giving it a gentle squeeze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Estela Toras**
> "“She was an extraordinary woman, your mother. I'd even go as far as to say she was like a daughter to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Vina Toras**
> ""I wish I'd known her as well as you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`
  - -> `[594]`
  - -> `[597]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bringing Zille back into our fold will rectify his mistake of giving it away so freely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[183]`
Mówca: **Narrator**
> "As for Vina... the relentless thought of her captivity plagued my mind. I had hardly slept since she was taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Hugo was overseeing the ceremony, and there was still some time before it was to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""Maybe for you, but it still feels like I'm stuck in a moment I can't escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[186]`
Mówca: **Vina Toras**
> ""Timeless, maybe. But sometimes it feels like the memories are slipping away, and revisiting only makes the pain worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[187]`
Mówca: **Vina Toras**
> ""That's easy for you to say. Regret is a constant reminder of what I've lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[188]`
Mówca: **Vina Toras**
> ""You don't understand. I still think about it every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[189]`
Mówca: **Vina Toras**
> ""But it doesn't make the guilt any easier to let go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[134]`
  - -> `[514]`
  - -> `[510]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[193]`
Mówca: **Vina Toras**
> ""Acknowledging it doesn't make the guilt disappear. It's not that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[134]`
  - -> `[514]`
  - -> `[510]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were a child. I was on that boat, too, and I could have saved her life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Vina Toras**
> ""It's hard not to wonder, what if?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[514]`
  - -> `[510]`

### Węzeł `[196]`
Mówca: **Vina Toras**
> ""So you do feel lucky to have me. You've got an interesting way of showing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Narrator**
> "We walked the rest of the way in uncomfortable silence until we reached Lena's tomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Vina, of course, was by my side. She was holding a bouquet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[202]`
Mówca: **Vina Toras**
> ""No... no, you're right. It won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Vina said a silent prayer and set the bouquet in a vase next to her mother's sarcophagus, which had been encased in gold, as was tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[207]`
Mówca: **Narrator**
> "In an instant, the memories of the boat accident came flooding back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "The deafening thunder that accompanied the torrent of rain, waves that tossed us around like rag dolls..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "But before I became lost in thought, my focus shifted back to Vina, whose captivity consumed my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[210]`
Mówca: **Estela Toras**
> ""I agree with your father. Just because he's courting the king's daughter, it doesn't mean he has special privileges--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[211]`
Mówca: **Vina Toras**
> ""If by 'we', you mean 'you.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[212]`
Mówca: **Estela Toras**
> ""Busy with what, dear? You know your father always called his party a zoo full of paper tigers--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[213]`
Mówca: **Estela Toras**
> ""No, indeed. He'd be lucky to have a Rumburgian princess for a mother instead of that harpy--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[214]`
Mówca: **Estela Toras**
> ""Don't be so sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[215]`
Mówca: **Estela Toras**
> ""We conversed much more often than you realized. You were just too busy to notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Estela Toras**
> ""It was only after you were married that my love for her grew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[559]`
  - -> `[280]`

### Węzeł `[217]`
Mówca: **Estela Toras**
> ""Believe me when I say that I did grow to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[559]`
  - -> `[280]`

### Węzeł `[218]`
Mówca: **Estela Toras**
> ""Come now, you know I'm not one for garish displays of emotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Estela Toras**
> ""But, yes, it's true. I did grow to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[559]`
  - -> `[280]`

### Węzeł `[220]`
Mówca: **Estela Toras**
> ""Not only that. I was common-born, and she was a Livingston. She was practically bred to hate me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Estela Toras**
> ""But somehow, she managed to completely defy my expectations, and I grew to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[280]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the use of a legacy if it doesn't change anything for the living?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Estela Toras**
> ""Sure, however, acknowledging the past can often guide us in shaping a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[66]`

### Węzeł `[227]`
Mówca: **Estela Toras**
> ""A testament to how our actions reverberate through time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[89]`
  - -> `[88]`

### Węzeł `[228]`
Mówca: **Estela Toras**
> ""The ache of loss may linger, but the impact he made will endure through the ages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Unfortunately, my father's and my legacies are intertwined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Estela Toras**
> ""You'd be wise to consider what imprint *you* wish to leave behind as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[89]`
  - -> `[229]`

### Węzeł `[231]`
Mówca: **Estela Toras**
> ""He may not have been a perfect man, but his responsibilities are now yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[232]`
Mówca: **Estela Toras**
> ""Yes, because our name carries weight, son. It's not just the actions. It's how you carry the responsibility that defines the legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[92]`
  - -> `[91]`
  - -> `[68]`

### Węzeł `[233]`
Mówca: **Estela Toras**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Estela Toras**
> ""Actions matter, but how you carry the family name matters equally. Your choices will shape our legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[92]`
  - -> `[91]`
  - -> `[68]`

### Węzeł `[235]`
Mówca: **Estela Toras**
> ""Our name carries weight. It's not just the actions. It's how you carry the responsibility that defines the legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[92]`
  - -> `[91]`
  - -> `[68]`

### Węzeł `[236]`
Mówca: **Estela Toras**
> ""But you're not just living for yourself. The family name is a part of you, and its heritage is in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[237]`
Mówca: **Estela Toras**
> ""Don't underestimate the power of a name. Your actions reflect not just on you but on our family as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[238]`
Mówca: **Estela Toras**
> ""I'm pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's as if there are subtle forces at play, nudging us toward responsibilities we never chose but are fated to fulfill, much like Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to avenge it and restore honor to our house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to avenge it and restore honor to our house -- by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[251]`
Mówca: **Estela Toras**
> ""I'm concerned that your relentless pursuit to reclaim Pales may lead to a case of history repeating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[252]`
Mówca: **Estela Toras**
> ""A noble resolve, but beware of letting it consume you and cloud your judgment, as it did your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[253]`
Mówca: **Estela Toras**
> ""Our family's honor was never lost. Even in defeat, your father fought with dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Estela Toras**
> ""That said, I fear your determination to reclaim Pales may lead to a case of history repeating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[255]`
Mówca: **Estela Toras**
> ""Your attention should be on the rightful restoration of Zille, not Pales!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[256]`
Mówca: **Estela Toras**
> ""You sound just like him. But I'll tell you what I *do* see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Estela Toras**
> "“I see a son determined to embark on a military expedition when his attention should be focused on the rightful restoration of Zille.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Estela Toras**
> "“I see the very foundation of the monarchy being put at risk through such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[259]`
Mówca: **Estela Toras**
> ""The very foundation of the monarchy is being put at risk through such actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[260]`
Mówca: **Estela Toras**
> ""He chose the lesser of two evils. And in doing so, we retained the throne. The only mistake would have been inaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`
  - -> `[325]`
  - -> `[326]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reclaiming Zille will honor his memory by finishing what he started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reclaiming Zille, God willing, will honor his memory by finishing what he started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to do everything possible to see it returned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to do everything possible to see it returned -- by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
Mówca: **Estela Toras**
> ""Your words would have been a source of pride for him, as they are with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[272]`
Mówca: **Estela Toras**
> ""As hard as it may be to accept, he took the necessary steps to secure the throne for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""A noble resolve indeed. Your words would have been a source of pride for him, as they are with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[274]`
Mówca: **Estela Toras**
> ""As hard as it may be to accept, he did what needed to be done so that we would retain the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray she's found peace in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope she has found peace in whatever comes next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She gave me the greatest gift of all, Vina. For that, I will always be in her debt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
Mówca: **Estela Toras**
> ""Love is a private sentiment, not a public performance. But yes, my affection toward Lena was quite strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Narrator**
> "A fleeting smile hinted at a memory that briefly illuminated her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[286]`
Mówca: **Narrator**
> "A momentary smile suggested a memory that fleetingly illuminated her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[287]`
Mówca: **Narrator**
> "A passing smile hinted at a memory that briefly flickered through her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[288]`
Mówca: **Narrator**
> "A transient smile hinted at a memory that briefly crossed her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[289]`
Mówca: **Estela Toras**
> ""A monarch must reign with compassion, or all will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea. So many lives were saved, thanks to that one conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Estela Toras**
> ""To think... if only she was around to talk to Wiktor Smolak now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A love letter? So the old man had a heart after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A love letter? Somehow I have trouble picturing Father writing one of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. For a moment there I thought you were handing me divorce paperwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? What's it say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[302]`
Mówca: **Estela Toras**
> ""It's five years and a heart attack too late for me to divorce Valero, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Narrator**
> "She took the envelope out of my hands and shoved it back into the bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Narrator**
> "She shoved the letter back in her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
Mówca: **Estela Toras**
> ""There's a lot you don't know about him. That you never bothered trying to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Estela Toras**
> ""There was far more to him than you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Estela Toras**
> ""Come. Let's go pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[311]`
Mówca: **Estela Toras**
> ""Let's go pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""It was only gathering dust in my writing desk. Come, let's pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[313]`
Mówca: **Estela Toras**
> ""That's between your father and me. Come, let's see what he's up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You alright?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Estela Toras**
> ""Yes. I've never been better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[316]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "But I said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this is becoming too much for you, I'll understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Estela Toras**
> ""Your concern is appreciated, but I'll be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we doing this or what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Estela Toras**
> ""Of course! That was never in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[321]`
Mówca: **Estela Toras**
> ""However, I'm pleased to hear your commitment to ensuring its return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More like kicking the can down the road for others to clean up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can dwell on the loss until the end of time. What matters is our resilience to reclaim what's ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe. But it doesn't make reclaiming it any easier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A mistake is a mistake, not matter how you try to sugarcoat it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[327]`
Mówca: **Estela Toras**
> ""No, I suppose not. But we must do what must be done to preserve our territorial integrity, not to mention our family name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[328]`
Mówca: **Estela Toras**
> ""Agreed. It's time to move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
Mówca: **Estela Toras**
> ""Nevertheless, the Toras family still stands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[330]`
Mówca: **Estela Toras**
> ""Which we must learn from to avoid repetition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[331]`
Mówca: **Estela Toras**
> ""Though, of course, the further forward we move, the closer we may get to hitting a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[332]`
Mówca: **Estela Toras**
> ""Though I fear you'll have to learn that lesson yourself when it comes to Crown policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[336]`
Mówca: **Estela Toras**
> ""Your reforms to the monarchy are slowly chipping away at our most sacred institution. If you're not careful, I fear nothing will be left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My reforms are for the good of the country. If anything our concessions will make our monarchy stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to get with the times. If we don't evolve, we'll be left in the dust like all the other monarchies that have gone extinct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I've got everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern. I know what I'm doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is neither the time nor the place to discuss Crown policy. I don't wish to discuss it any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Estela Toras**
> ""Very well. But given your concern for legacy, you're certainly risking tarnishing it with such reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Relationship_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Relationship_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[348]`
Mówca: **Estela Toras**
> ""Those who believe they're in control often find themselves at the mercy of unforeseen circumstances, and risk losing it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[349]`
Mówca: **Estela Toras**
> ""If by putting the founding principles of the monarchy in jeopardy, then yes. I'd say you're succeeding on that end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[350]`
Mówca: **Estela Toras**
> ""I'd say your policies imply that extinction is your goal. These reforms set a dangerous precedence and come with great risks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[351]`
Mówca: **Estela Toras**
> ""You and I seem to have different definitions of what it means to be strong. From my vantage point, I'd say the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Estela Toras**
> ""Taking such risks sets a dangerous precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""Which, I'm sorry to say, are slowly being chipped away. I fear that if we continue on this trajectory, there might be nothing substantial remaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""Yes, darling, I've heard rumors that you may begin working with a certain someone on reforming the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Estela Toras**
> ""It's none of my business, of course. But it's bound to make you a host of enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[362]`
Mówca: **Estela Toras**
> ""I've heard whispers about your *escapades* with House Azaro, a family harboring their own ambitions regarding the throne. And you know how risky rumors can be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[363]`
Mówca: **Narrator**
> "It was then we heard the far distant rings of the bells of the Archsanctuary of Zilba begin to chime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Estela Toras**
> ""Right on cue. Shall we head to the ceremony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[365]`
  - -> `[385]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we wouldn't want to be late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Estela Toras**
> ""We're already late, but as king, that's your prerogative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Almost forgot all about it. I'm sure Vina is wondering where we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Almost forgot all about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[372]`
Mówca: **Narrator**
> "Before departing, I cast a final glance at Father's resting place, and a rush of memories flooded my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`
  - -> `[382]`
  - -> `[375]`
  - -> `[373]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we part, know this -- I shape my own legacy, free from the expectations of a faded form. Father's views on my choices carry no weight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the spirit of transparency, know that I fully intend to reclaim Pales, rectifying Father's mistakes. While I understand you have your sights set on Zille, I believe this is what's best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we go... you should know that I intend to uphold Father's legacy. I will do right by him by rejuvenating this nation in accordance with his wishes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since we're being forthright, I want you to know that I intend to preserve Father's legacy and do right by him. I vow to fulfill what he started by reclaiming Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""Very well. I trust you know what's best. I'll pray for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[378]`
Mówca: **Estela Toras**
> ""I understand. For what it's worth, as hard as it may be to believe, he would have been proud of you no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[379]`
Mówca: **Estela Toras**
> ""May your endeavors to rejuvenate our nation bring about the greatness he envisioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[380]`
Mówca: **Estela Toras**
> ""I can't help but feel a sense of skepticism and concern, but I trust in God, and I have faith that you'll succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[381]`
Mówca: **Estela Toras**
> ""Then good luck to you then. Though, you're going to need more than luck to reclaim Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[376]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Just give me a second alone with father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`

### Węzeł `[386]`
Mówca: **Estela Toras**
> ""Then we'd best be off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[387]`
Mówca: **Narrator**
> "I took my mother's arm and we departed, leaving my father to his solitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DepartTomb_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[398]`
Mówca: **Estela Toras**
> ""Though for how long, is a question that lingers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[399]`
Mówca: **Estela Toras**
> ""That said...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[403]`
Mówca: **Estela Toras**
> ""Speaking of mistakes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Finale_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[408]`
Mówca: **Estela Toras**
> ""Though, I can't say the same for your commitment to reforming the monarchy, which is slowly chipping away at our most sacred institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Estela Toras**
> ""If you're not careful, I fear nothing will be left by the time you're through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[413]`
Mówca: **Estela Toras**
> ""Speaking of securing the throne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[417]`
Mówca: **Estela Toras**
> ""However, I can't say the same toward your crusade to reform the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Estela Toras**
> ""If you're not careful, I fear nothing will be left to salvage by the time you're through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[422]`
Mówca: **Estela Toras**
> ""However, I can't say the same across the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[423]`
Mówca: **Narrator**
> "In the royal tradition, this was the resting place of the most recently deceased monarch of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Turn06_Cemetary_FathersGrave = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Turn06_Cemetary_FathersGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_Sov_Memorial = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_Sov_Memorial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_InBoatAccident == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[437]`
Mówca: **Estela Toras**
> ""I so wish Vina could be here. She never got to know Lena the way I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[444]`
Mówca: **Estela Toras**
> ""Not to mention your misadventures in cooperation with the opposition party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[448]`
Mówca: **Narrator**
> "She took the letter back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[452]`
Mówca: **Narrator**
> "She took the envelope back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[456]`
Mówca: **Narrator**
> "She took the letter back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[460]`
Mówca: **Narrator**
> "Mother took back the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[464]`
Mówca: **Narrator**
> "Mother took the envelope back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Isn't the allure of gossip beneath someone of your age and stature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whispers and rumors... they hold no more substance than passing reflections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The glow of divine providence renders whispers and rumors as transitory as sunlight on water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[468]`
Mówca: **Estela Toras**
> ""Gossip is the fuel on which monarchies run. I thought you knew that already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[469]`
Mówca: **Estela Toras**
> ""I see that instead of addressing my concern, you choose to deflect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[470]`
Mówca: **Estela Toras**
> ""Fancy words. Almost as if you were trying to deflect from the rumors' substance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumors are as fleeting as sunlight dancing on water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Finale_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Risk_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[484]`
Mówca: **Estela Toras**
> ""Speaking of integrity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GovReforms_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`
  - -> `[340]`
  - -> `[344]`

### Węzeł `[486]`
Mówca: **Estela Toras**
> ""Still, I expect nothing but discretion from both you and your daughter. Wouldn't want to risk stirring up too much gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[488]`
Mówca: **Estela Toras**
> ""It requires us to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[493]`
Mówca: **Estela Toras**
> ""Speaking of which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[494]`
Mówca: **Estela Toras**
> ""Which is why I'm expecting nothing but discretion from both you and your daughter. Wouldn't want to risk stirring up too much gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[496]`
Mówca: **Estela Toras**
> ""We're sometimes required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[498]`
Mówca: **Estela Toras**
> ""In life, we're sometimes required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[500]`
Mówca: **Estela Toras**
> ""Sometimes in life, we're required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Risk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[507]`
Mówca: **Narrator**
> "She embraced her granddaughter, then held her at arm's length."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[508]`
Mówca: **Estela Toras**
> ""Vina! I'm so glad you made it back to Rizia in time to pay your respects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[509]`
Mówca: **Vina Toras**
> ""Grandmother! I will remind you that I'm spoken for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be hard to believe, but your mother's death was part of God's plan. We should not question His designs, only trust in His wisdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have each other. You don't know how scared I was of losing you during the Pales incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging that you were responsible for the death of the love of my life won't bring comfort to either of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could have been worse. I could've lost you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Vina Toras**
> ""Trust goes both ways, Father. What has God done to earn ours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Vina Toras**
> ""You were never in danger of losing me, Father. I can take care of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[528]`
Mówca: **Narrator**
> "Tears filled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[529]`
Mówca: **Narrator**
> "Her eyes brimmed with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Vina Toras**
> ""I know. But I still can't help but feel that letting it go would mean letting her down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[531]`
Mówca: **Estela Toras**
> ""I'd say your time among the Palesians has done wonders for you. You've lost weight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[535]`
Mówca: **Narrator**
> "Vina smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[536]`
Mówca: **Vina Toras**
> ""If I did, it was by accident. I ate very well over there, even after the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[537]`
Mówca: **Vina Toras**
> ""If I did, it was by accident. I ate very well over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[538]`
Mówca: **Estela Toras**
> ""Candlelit dinners with His Grace? Do tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.VinaManus_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""Grandmother! Don't tell me you believed those rumors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. His duties as a delegate must keep him quite busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[547]`
Mówca: **Vina Toras**
> ""We'll catch up later. I'm meeting Manus for a walk before the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[548]`
Mówca: **Estela Toras**
> ""What rumors? All I know is that if I were alone with that man, an energy partnership wouldn't be the only deal sealed--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Estela Toras**
> "“Neither did you, I suspect, or you'd be sobbing by her graveside right now. She was an extraordinary woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[22]`
  - -> `[43]`
  - -> `[553]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I liked her enough. We just never felt a spark.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Estela Toras**
> ""Perhaps you resented your arranged marriage so much that you did not allow yourself to feel it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, I remember. You never met a noblewoman you didn't disparage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Estela Toras**
> ""I was insecure, darling. Even after my status was secured, I never got over the feeling that I was an imposter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[557]`
Mówca: **Estela Toras**
> ""Except around Her Highness. That was part of the reason I loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[559]`
  - -> `[280]`

### Węzeł `[558]`
Mówca: **Estela Toras**
> ""For my part, I grew to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[38]`
  - -> `[559]`
  - -> `[280]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame you could never hold your tongue around her sister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Estela Toras**
> ""Beatrice never had it easy. Shouldering the responsibility of ruling Rumburg while her gorgeous younger sibling absorbed the limelight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Estela Toras**
> ""But if anyone deserved it, she did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Estela Toras**
> "“It was right after the civil war broke out in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena's naivete overlooked the full implications of welcoming all those foreigners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[573]`
Mówca: **Estela Toras**
> ""No. She thought about their humanity and the horrors they faced, at a time when few other nobles did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think she'd make of my decision to go to war with Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[575]`
Mówca: **Estela Toras**
> ""Good question. I suppose we'll never know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Estela Toras**
> ""Remember that as we enter into war, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[580]`
Mówca: **Estela Toras**
> ""A lesson we'd all do well to remember, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[584]`
Mówca: **Estela Toras**
> ""That's a shame. Who knows how many valuable insights were lost when that boat capsized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've described her exactly. Whenever I make a royal decision, I try to see the humane side of it. The way she would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[586]`
Mówca: **Estela Toras**
> ""Who knows what insights she would have to contribute if she were alive today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[587]`
Mówca: **Estela Toras**
> ""Lena and I had much in common besides political opinions, too. We both took a single ice cube in our red wine on hot days...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's exaggerating, Vina. She didn't know your mother at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really, Mother? 'Like a daughter'? You never met a noblewoman you didn't disparage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[590]`
Mówca: **Estela Toras**
> ""I was insecure, darling. Even after my status was secured, I never got over the feeling that I was an imposter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[591]`
Mówca: **Estela Toras**
> ""Except around Her Highness. That was part of the reason I loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[592]`
Mówca: **Estela Toras**
> ""We conversed much more often than you realized. You were just too busy to notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Estela Toras**
> ""Believe me when I say that I did grow to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea you felt that way about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[595]`
Mówca: **Estela Toras**
> ""Come now. You know I'm not one for garish displays of emotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Estela Toras**
> ""But it's true. I did grow to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[597]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena won over every person she met. Even prickly Queen Consorts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[598]`
Mówca: **Estela Toras**
> ""Ha! I confess it took me a while to get over my prejudices about Rumburgian nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[599]`
Mówca: **Narrator**
> "She smiled in fond recollection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.VinaManus_Together = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.VinaManus_Together"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother's passing was a part of life. It's important to find strength in the memories and support each other through these challenging times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[605]`
Mówca: **Vina Toras**
> ""I'm not sure memories are enough to give me strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[606]`
Mówca: **Narrator**
> "Since she was taken, I'd endured many sleepless nights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[607]`
Mówca: **Estela Toras**
> ""Yes, the Livingstons are as traditionalist as they come, but there's much we mothers are willing to overlook for the sake of our children's happiness--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[608]`
Mówca: **Estela Toras**
> ""You two were at Palas Rezna for dinner, and Lena and I absconded for tea after you and your father got into another one of your rows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[609]`
Mówca: **Estela Toras**
> ""You two were at Palas Rezna for dinner, and Lena and I absconded for tea after you and your father went off to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[610]`
Mówca: **Estela Toras**
> ""But as we discussed the situation, your wife made such a convincing case for empathy and kindness that I was literally moved to tears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Estela Toras**
> ""She had this way of seeing past politics, straight to the heart of the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[612]`
Mówca: **Narrator**
> "When I died, I would take my father's place beside the Eternal Flame, and he would be laid to rest among his forebears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[613]`
Mówca: **Estela Toras**
> ""Through triumphs and tribulations, you were my confidante, my partner, my solace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[614]`
Mówca: **Estela Toras**
> ""I loved you then, I love you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Recognizing the influence of the past on the present is crucial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`
  - -> `[621]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, but this time will be different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[623]`
Mówca: **Estela Toras**
> ""Relying solely on divine intervention is misguided. Speaking of which, your attention should be on the rightful restoration of Zille, not Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[624]`
Mówca: **Estela Toras**
> ""Or so the rumors say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since we're being honest with one another... Know that Father's legacy and opinions of me are of no concern. But I'm determined to correct his mistakes by achieving what he couldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableNews("G_HeljilandRecognized");)*
- **Efekt (`userScript`):** `EnableNews("G_HeljilandRecognized");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableNews("G_AgnoliaAlliance");)*
- **Efekt (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[636]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[638]`
Mówca: **Estela Toras**
> ""Your father declaring war must have been quite the appetite suppressant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`
  - -> `[641]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[642]`
Mówca: **Vina Toras**
> ""Now, Grandmother. The cause was just.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[643]`
Mówca: **Vina Toras**
> ""It must have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[644]`
Mówca: **Narrator**
> "I saw her lip tremble slightly. Mother squeezed her shoulder in silent support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[645]`
Mówca: **Narrator**
> "Soon, I found her sarcophagus, encased in gold as per tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're making a fuss over nothing, Mother. The Duke and I had the deal clinched. Vina's involvement was merely ornamental.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[653]`
Mówca: **Estela Toras**
> ""If anyone deserves to settle down with a nice husband, it's her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[655]`
Mówca: **Narrator**
> "She looked at me pointedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[694]`
  - -> `[656]`
  - -> `[705]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`
  - -> `[658]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`
  - -> `[661]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[662]`
Mówca: **Estela Toras**
> ""I know she would've been proud of the person you've become, Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[663]`
Mówca: **Estela Toras**
> ""I know you have approved of Manus and Vina, and I support passion, but it might not be as digestible for the rest of the house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[664]`
Mówca: **Estela Toras**
> ""Look at how you handled yourself in Pales. The perfect example of royal grace and dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`
  - -> `[665]`
  - -> `[649]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, she has indeed shown remarkable strength and resilience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[666]`
Mówca: **Estela Toras**
> ""Poor dear... she's been through so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[670]`
Mówca: **Estela Toras**
> "“But I'm getting sidetracked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[671]`
Mówca: **Estela Toras**
> ""A bit harsh, wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[677]`
  - -> `[678]`
  - -> `[675]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I didn't need to react that way. I will speak to her about it later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She'll be fine. Don't worry about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll parent my way, and you parent yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[679]`
Mówca: **Estela Toras**
> ""I wouldn't call that parenting. I'd call it imposing your will without considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[680]`
Mówca: **Estela Toras**
> ""Well, it was. Unless your goal is to get her to resent you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`
  - -> `[693]`
  - -> `[681]`

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that's *exactly* what I want to do. What better way to forge better family ties than to encourage resentment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're making a fuss over nothing, Mother. A true diplomat wouldn't have caused an international incident like Vina did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[683]`
Mówca: **Narrator**
> "Despite Vina's attempts to conceal her emotions, the subtle quiver in her lips and a deep sigh betrayed her inner turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1;
RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[685]`
Mówca: **Vina Toras**
> ""Please excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Narrator**
> "Vina hurried out of the room before anyone could respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[688]`
Mówca: **Narrator**
> "Even as Vina tried to conceal her feelings, a subtle tremor in her lips and a heavy sigh betrayed her inner turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[689]`
Mówca: **Estela Toras**
> ""I'm her grandmother. It's my job to worry, as should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very kind of you, Mother. Vina indeed handled herself like a true princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[691]`
Mówca: **Narrator**
> "Vina's lip trembled. I saw outrage in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[692]`
Mówca: **Estela Toras**
> ""Sarcasm doesn't suit you. It's beneath the dignity expected of a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your tone. I am your king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is free to marry whomever she chooses. You, of all people, should understand the importance of love and following one's heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[695]`
Mówca: **Estela Toras**
> ""Good. This family has enough problems as it is. No need to create more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[696]`
Mówca: **Estela Toras**
> ""And I am your mother. If anybody's tone needs watching, it's yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[697]`
Mówca: **Estela Toras**
> ""I wouldn't be so sure of that. Grudges have a funny way of never going away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. I'm sure she'll forget all about it and forgive me in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Unfortunately, I suspect she still has her heart set on Manus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[700]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't agree more. However, it seems this kingdom lacks suitable men of good stature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[701]`
Mówca: **Estela Toras**
> ""I don't need a lecture on the importance of love and freedom, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[702]`
Mówca: **Estela Toras**
> ""Either way, our girl needs to tie the knot sooner rather than later for our family to secure its place on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[703]`
Mówca: **Estela Toras**
> ""Then maybe you should start looking outside the kingdom. To Pales, perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[704]`
Mówca: **Estela Toras**
> ""Then perhaps you should start looking outside the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I keep coming back to the same answer. The only way to ensure our stability is to marry her off within House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[709]`
Mówca: **Estela Toras**
> ""Love has its own stubborn ways, and letting go can be an arduous task. Yet, duty often requires sacrifice -- the Princess should know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[710]`
Mówca: **Estela Toras**
> ""That trigger should be pulled only out of desperation, dear. I don't think we're there yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[711]`
Mówca: **Estela Toras**
> ""Losing a parent is hard, especially when they love you as much as Vina's mother loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[712]`
Mówca: **Estela Toras**
> ""It's about time we consider wedding bells for Vina if we want to ensure the continuation of our lineage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[694]`
  - -> `[656]`
  - -> `[705]`

### Węzeł `[713]`
Mówca: **Estela Toras**
> ""In any case, I'm pleased that Vina's looking well, all things considered. She's been through so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[717]`
Mówca: **Estela Toras**
> ""Speaking of love...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[719]`
Mówca: **Narrator**
> "Her gaze once again landed on Lena's resting place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[723]`
Mówca: **Narrator**
> "As she spoke, a memory suddenly came to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Estela Toras**
> ""But let's get to the reason why I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[725]`
Mówca: **Narrator**
> "Lena had just completed the Rite of Severance, the ceremony converting her to Wruhecism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[726]`
Mówca: **Narrator**
> "After she'd burned the last of the eleven slips of parchment representing her connection to Dastnurity, my mother was the first to approach and embrace her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[727]`
Mówca: **Narrator**
> "I hadn't thought much about it at the time. But knowing what I did now..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`
  - -> `[729]`
  - -> `[733]`
  - -> `[734]`

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did my wife know you were a Dastnurist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`
  - -> `[731]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wine? No, what you two shared was an attachment to your heathen faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[733]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's something I need to bring up with you. Have you secretly been practicing Dastnurity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, enough about Lena. This is already a very emotional day for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Narrator**
> "My mother went pale as a sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[736]`
Mówca: **Estela Toras**
> ""Emotional, Romus? You haven't seen anything yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`
  - -> `[472]`

### Węzeł `[738]`
Mówca: **Estela Toras**
> "“I don’t know what you’re talking about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[744]`
  - -> `[751]`
  - -> `[739]`

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. I'm not judging you. I just want you to be honest with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[740]`
Mówca: **Estela Toras**
> "“It’s called faith for a reason. It's not something you casually discard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`
  - -> `[764]`
  - -> `[794]`
  - -> `[765]`

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't lie to me! Do you take me for a fool? I know all about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus told me where you where the night Father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[743]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Mother. I know all about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's a relief. I guess I can close the case on that one. What was I thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[748]`
Mówca: **Estela Toras**
> ""You had me investigated? Your own mother?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[749]`
Mówca: **Estela Toras**
> ""Don't take that tone with me! You may be king, but I'm still your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[750]`
Mówca: **Narrator**
> "Mother stood firm, her gaze unfaltering. Yet, it took only a short while before she yielded, heaving a sigh of resignation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`
  - -> `[753]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita told me where you where the night Father died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`
  - -> `[757]`

### Węzeł `[756]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[758]`
Mówca: **Estela Toras**
> ""Oh, I highly doubt you're not judging me, son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[759]`
Mówca: **Estela Toras**
> ""The same Lucita who's in jail for crimes against the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`
  - -> `[762]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[763]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is if you want to be part of the Rizian Royal Family. Why couldn't you have made the same sacrifice Lena did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was your whole family Dastnurist? How could you have kept this a secret for so long?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. But I wish I hadn't found out this way. You should have trusted me enough to tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[766]`
Mówca: **Estela Toras**
> ""I'm sorry I felt compelled to hide it all these years. But I did it to protect you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[767]`
Mówca: **Estela Toras**
> ""Marrying your father was enough of a scandal. Can you imagine the uproar my religion would've caused on top of that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[768]`
Mówca: **Estela Toras**
> ""My intention was to shield you from danger, even if it meant keeping a part of myself hidden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[769]`
Mówca: **Estela Toras**
> ""But as king, and more importantly, as my son, you had a right to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`
  - -> `[793]`
  - -> `[785]`
  - -> `[792]`

### Węzeł `[770]`
Mówca: **Estela Toras**
> ""Sacrifice and compromise are values drilled into princesses, my dear. Not fisherman's daughters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[771]`
Mówca: **Estela Toras**
> ""Only my grandmother, God rest her soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[772]`
Mówca: **Estela Toras**
> ""She used to take me to Dastnurist services behind my parents' back. I kept up the habit after she died -- not regularly, but whenever I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[773]`
Mówca: **Estela Toras**
> ""My late grandmother used to take me to the Dastnurist sanctuary in Zille behind my parents' back. Our little secret, she called it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[774]`
Mówca: **Estela Toras**
> ""To turn my back on Dastnurity would be to betray her memory. Or that's what it feels like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`
  - -> `[782]`
  - -> `[775]`
  - -> `[765]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`
  - -> `[777]`

### Węzeł `[776]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religion_Leaning_Theocratic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[778]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to me, Mother. You have to convert before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[779]`
Mówca: **Estela Toras**
> ""Too late?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[780]`
Mówca: **Estela Toras**
> ""Can't you just keep this between us two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with your grandma's memory. What about betraying your son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she was alive when you were crowned Princess Consort, she would have told you to convert.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[783]`
Mówca: **Estela Toras**
> ""I'll never know, will I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where all branches of the Nurist faith are equally welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[785]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`
  - -> `[787]`

### Węzeł `[786]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[787]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Law_NurityStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where no religion dominates over any other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`
  - -> `[791]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your honesty. And don't worry. Nobody else has to know about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[793]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that your secret's out, I implore you to convert to Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe Lena never told me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`
  - -> `[797]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false  or  Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[797]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false  or  Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[798]`
Mówca: **Estela Toras**
> ""You two were never exactly forthright with each other, were you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[799]`
Mówca: **Estela Toras**
> ""She wanted to. I swore her to secrecy, the poor dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[800]`
Mówca: **Estela Toras**
> ""I'm an old lady, darling. And I'm more set in my ways than an eel in aspic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[801]`
Mówca: **Estela Toras**
> ""Oh, I know. And I'm grateful for it, believe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[802]`
Mówca: **Estela Toras**
> ""Oh, I know. And I imagine Grand Wiseman Ignacius was just thrilled with that little decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[803]`
Mówca: **Estela Toras**
> ""But tradition is tradition, and I've already caused enough fusses to last a lifetime. So I'd prefer this little revelation stay between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[804]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`
  - -> `[806]`

### Węzeł `[805]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`

### Węzeł `[807]`
Mówca: **Narrator**
> "Her eyes flicked towards the mausoleum entrance, where the Golden Guard stood watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[808]`
Mówca: **Estela Toras**
> ""And Captain Muscles out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`
  - -> `[811]`

### Węzeł `[810]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[811]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[812]`
Mówca: **Estela Toras**
> ""After all, the only other person who knows can't go blabbing to anyone but the Citadel walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[813]`
Mówca: **Estela Toras**
> ""And your lovely falcon of a war councilor, I suppose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[814]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`
  - -> `[816]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[817]`
Mówca: **Estela Toras**
> ""After all, the only other person who knows can't go blabbing to anyone but the Citadel walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[818]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, I won't tell anyone. But it goes without saying that you've shattered my trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`

### Węzeł `[819]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't force you to convert. But for your own sake, please be more careful in concealing your faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[820]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your secret is safe. But I do pray that in due time, you'll see the error of your ways and return to the one true faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`
  - -> `[823]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`
  - -> `[841]`
  - -> `[835]`
  - -> `[821]`
  - -> `[818]`

### Węzeł `[825]`
Mówca: **Narrator**
> "She looked at me worriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where Dastnurity can flourish, regardless of our state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`
  - -> `[829]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[829]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[830]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. Actually, revealing your religion might boost my popularity with the Dastnurist community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[831]`
Mówca: **Narrator**
> "She hurriedly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[832]`
Mówca: **Estela Toras**
> ""Tradition is tradition, and I've already caused enough fusses to last a lifetime. So I'd prefer this little revelation stay between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[833]`
Mówca: **Narrator**
> "She put a hand to her chest and sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[834]`
Mówca: **Estela Toras**
> ""I appreciate it, Romus. I really do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[835]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Mother. If you love me, you'll do this for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[836]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am building a new Rizia. One in which the Wruhecist faith triumphs over all others. Everyone must see the light, the Queen Mother included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`
  - -> `[839]`

### Węzeł `[838]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religion_Leaning_Theocratic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[840]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More people know your secret than just us two. It's only a matter of time before it's made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[841]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`
  - -> `[843]`

### Węzeł `[842]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[844]`
Mówca: **Estela Toras**
> ""My dear, if you don't trust your investigators to keep a secret, you shouldn't have trusted them with an investigation in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`

### Węzeł `[845]`
Mówca: **Estela Toras**
> ""My son over my faith... it's an impossible choice, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`

### Węzeł `[846]`
Mówca: **Estela Toras**
> ""Oh, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[847]`
Mówca: **Narrator**
> "She twisted a ring on one of her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`

### Węzeł `[848]`
Mówca: **Estela Toras**
> ""I presume you haven't told the Rumburgians about these plans yet...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`

### Węzeł `[849]`
Mówca: **Estela Toras**
> ""But never mind that. If it's really so important to you, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`
  - -> `[862]`
  - -> `[859]`

### Węzeł `[850]`
Mówca: **Estela Toras**
> ""Well, when you manage to put it back together again, let me know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[851]`
Mówca: **Estela Toras**
> ""I was doing just fine before you brought a security team into it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[852]`
Mówca: **Estela Toras**
> ""Pray away, my son. This soul's already a lost cause, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[853]`
Mówca: **Estela Toras**
> ""Now, as for the reason I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[854]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Father Love Letter)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[855]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Father Love Letter])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[856]`
Mówca: **Estela Toras**
> ""But if it's really so important to you, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`
  - -> `[862]`
  - -> `[859]`

### Węzeł `[857]`
Mówca: **Narrator**
> "She recomposed herself and made an effort to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[858]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mother. You won't regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]`

### Węzeł `[859]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I don't want to force you to become a Wruhecist for my sake. I only hope you'll come to the decision on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[860]`
Mówca: **Narrator**
> "She put a hand to her chest and sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[861]`
Mówca: **Estela Toras**
> ""Maybe I will. Someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will? Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]`

### Węzeł `[863]`
Mówca: **Estela Toras**
> ""Next chance I get, I'll march down to Zilba and have one of the Wisemen there make a believer out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[864]`
Mówca: **Estela Toras**
> ""Covertly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_PromisedToConvert = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Estela_PromisedToConvert"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[866]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let's leave it at that. I'm not in the mood for conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[867]`
Mówca: **Narrator**
> "She stepped towards my father's resting place and spoke to him in a hushed whisper, prolonging the conversation far longer than I anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[868]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Finale_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[869]`
Mówca: **Narrator**
> "She kissed me on the cheek and patted my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]`

### Węzeł `[870]`
Mówca: **Estela Toras**
> ""Take all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`

### Węzeł `[871]`
Mówca: **Narrator**
> "Mother went on ahead of me while I remained behind to have a final moment with Father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]`

### Węzeł `[872]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[873]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]`
  - -> `[875]`

### Węzeł `[874]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[875]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[876]`
Mówca: **Narrator**
> "Once alone, I reached into my inner jacket pocket and took out an envelope -- the last letter my father ever wrote to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]`

### Węzeł `[877]`
Mówca: **Narrator**
> ""Find your own way, my son, and let your journey be yours alone — not a reflection of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`

### Węzeł `[878]`
Mówca: **Narrator**
> "His final words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[879]`
**[WYBÓR GRACZA: "Place the letter into the fire."]** — Mówca: **Player_Romus_Italic**
> "Having held onto it long enough, I fed the letter to the flames and watched it burn until nothing was left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[880]`
**[WYBÓR GRACZA: "Keep the letter."]** — Mówca: **Player_Romus_Italic**
> "I considered consigning the letter to the flames as my mother did, but in the end, I decided to hold onto it for safekeeping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[881]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_DadLetterBurn = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[882]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_DadLetterBurn = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[883]`
Mówca: **Narrator**
> "I departed soon after, leaving my father to his solitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[884]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]`
  - -> `[886]`

### Węzeł `[885]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`

### Węzeł `[886]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DadLetter_ThrowAway == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]`

### Węzeł `[887]`
Mówca: **Narrator**
> "I struggled to remember his face or the last words he spoke to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[888]`
Mówca: **Narrator**
> "I remembered his last words to me as if he'd spoken them yesterday."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest in peace, old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[890]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I will rectify your mistakes. I will reclaim Pales and become the greatest king Rizia has ever known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]`

### Węzeł `[891]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do right by you, Father. I will rejuvenate this nation the way you always wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag shall fly over Pales in your honor, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]`

### Węzeł `[893]`
Mówca: **Estela Toras**
> ""May your endeavors to rejuvenate our nation bring about the greatness he envisioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]`

### Węzeł `[894]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`
  - -> `[896]`

### Węzeł `[895]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`
  - -> `[892]`

### Węzeł `[896]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]`

### Węzeł `[897]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[898]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_HonorDadPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[899]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[900]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't give a damn about your legacy or what you thought about me. I have my own path to walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[901]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[902]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]`
  - -> `[894]`
  - -> `[891]`
  - -> `[889]`
  - -> `[904]`

### Węzeł `[903]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I will rectify your mistakes. I will take back Zille and become the greatest king Rizia has ever known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[904]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I stood there in silence for a long moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[905]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[906]`
  - -> `[907]`

### Węzeł `[906]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]`
  - -> `[880]`

### Węzeł `[907]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[908]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Attending the Sovereign Memorial Commemoration", "Mausoleum", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Attending the Sovereign Memorial Commemoration","Mausoleum","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
