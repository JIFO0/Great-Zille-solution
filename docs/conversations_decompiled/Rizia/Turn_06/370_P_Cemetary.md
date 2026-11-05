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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"Take a flower."** | `[8]` **Narrator**: "Adjacent to it stood a bouquet o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I took a flower from the bouquet..." |
| `[10]` | **"Leave the flowers as is."** | `[8]` **Narrator**: "Adjacent to it stood a bouquet o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "As I stood in contemplation, ref..." |
| `[14]` | **"“Mother? This is a surprise.”"** | `[13]` **Estela Toras**: "“Romus...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "She hadn’t attended a Sovereign ..." |
| `[22]` | **"“What was extraordinary about her? She was just another entitled noblewoman.""** | `[552]` **Estela Toras**: "“Neither did you, I suspect, or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Estela Toras**: "“That's what I thought as well, ..." |
| `[29]` | **"Take the envelope."** | `[28]` **Narrator**: "My mother reached into her handb..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"]...` | `[31]` **Estela Toras**: "“A love letter from your father ..." |
| `[30]` | **"Don't take the envelope."** | `[28]` **Narrator**: "My mother reached into her handb..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"]...` | `[48]` **Estela Toras**: "“A love letter from your father ..." |
| `[32]` | **"“Quite the keepsake.”"** | `[31]` **Estela Toras**: "“A love letter from your father ..."<br>`[48]` **Estela Toras**: "“A love letter from your father ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Narrator**: "She took the letter back."<br>`[312]` **Estela Toras**: ""It was only gathering dust in m..." |
| `[36]` | **""That sounds like her -- placing compassion before practicality.""** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Estela Toras**: ""A monarch must reign with compa..." |
| `[37]` | **""Lena and I never spoke about such weighty topics.""** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | `(Variable["RiziaDLC.Prologue_LovedWife"]) == false` | *Brak zmian stanu* | `[584]` **Estela Toras**: ""That's a shame. Who knows how m..." |
| `[38]` | **""Love... now that's a word I rarely hear you say.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Estela Toras**: ""Love is a private sentiment, no..." |
| `[39]` | **""You were her mother-in-law. There's always some friction in that relationship.""** | `[21]` **Estela Toras**: "“You of all people know what an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Estela Toras**: ""Not only that. I was common-bor..." |
| `[40]` | **""How do you know she was extraordinary? You two barely spoke.""** | `[21]` **Estela Toras**: "“You of all people know what an ..."<br>`[552]` **Estela Toras**: "“Neither did you, I suspect, or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Estela Toras**: ""We conversed much more often th..." |
| `[41]` | **""What are you doing here?""** | `[13]` **Estela Toras**: "“Romus...”"<br>`[146]` **Estela Toras**: ""Well, there you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "She hadn’t attended a Sovereign ..." |
| `[42]` | **""Well, well. Fancy meeting you here.""** | `[13]` **Estela Toras**: "“Romus...”"<br>`[146]` **Estela Toras**: ""Well, there you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "She hadn’t attended a Sovereign ..." |
| `[43]` | **""I didn't know you felt that way about her.""** | `[21]` **Estela Toras**: "“You of all people know what an ..."<br>`[552]` **Estela Toras**: "“Neither did you, I suspect, or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Estela Toras**: ""Come now, you know I'm not one ..." |
| `[44]` | **""That's not surprising at all. Everyone who met Lena loved her.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[288]` **Narrator**: "A transient smile hinted at a me..." |
| `[45]` | **""How very thoughtful.""** | `[31]` **Estela Toras**: "“A love letter from your father ..."<br>`[48]` **Estela Toras**: "“A love letter from your father ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Narrator**: "She took the envelope back."<br>`[312]` **Estela Toras**: ""It was only gathering dust in m..." |
| `[58]` | **"“Please, by all means.”"** | `[57]` **Estela Toras**: "“If you don’t mind, I’d like to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Estela Toras**: "“Val... For 45 years, we walked ..." |
| `[64]` | **"“Legacy... I doubt history will be very kind.”"** | `[63]` **Estela Toras**: "“May he rest in peace as his leg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Estela Toras**: "“I’m not speaking of his actions..." |
| `[66]` | **"“A heavy burden to bear -- a name forever stained by the judgments of time.”"** | `[65]` **Estela Toras**: "“I’m not speaking of his actions..."<br>`[226]` **Estela Toras**: ""Sure, however, acknowledging th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Estela Toras**: "“Legacies are shaped by more tha..." |
| `[68]` | **"“I can't escape the shadows of his choices, no matter what path I forge.”"** | `[67]` **Estela Toras**: "“Legacies are shaped by more tha..."<br>`[232]` **Estela Toras**: ""Yes, because our name carries w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Estela Toras**: ""Maybe not, but you can cast new..." |
| `[71]` | **"“Destiny or not, I'll strive to leave a legacy that stands apart from the mistakes..."** | `[70]` **Estela Toras**: "“Sometimes, the most profound re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Player_Romus**: "“My triumph over Pales will rect..."<br>`[182]` **Player_Romus**: ""Bringing Zille back into our fo..."<br>*(oraz 8 innych odgałęzień)* |
| `[72]` | **"“My triumph over Pales will rectify his failure.”"** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[73]` **Estela Toras**: "“Or be your undoing, just like h..." |
| `[75]` | **"“You know nothing.”"** | `[74]` **Narrator**: "I began pacing around the hall." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Estela Toras**: "“So sure of yourself. I'll tell ..." |
| `[83]` | **""If you insist, but please make it brief. I don't have all day.""** | `[57]` **Estela Toras**: "“If you don’t mind, I’d like to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "I stepped away, granting her som..." |
| `[84]` | **""I'll give you some privacy.""** | `[57]` **Estela Toras**: "“If you don’t mind, I’d like to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "I gave her some space to allow f..." |
| `[85]` | **""I find comfort in knowing that his legacy lives on, but it doesn't change the pai..."** | `[63]` **Estela Toras**: "“May he rest in peace as his leg..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == false` | *Brak zmian stanu* | `[228]` **Estela Toras**: ""The ache of loss may linger, bu..." |
| `[86]` | **""For better or worse, his legacy will live on.""** | `[63]` **Estela Toras**: "“May he rest in peace as his leg..." | `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == false) == false` | *Brak zmian stanu* | `[227]` **Estela Toras**: ""A testament to how our actions ..." |
| `[87]` | **""Indeed. Recognizing the past's influence on the present is crucial, guided by div..."** | `[227]` **Estela Toras**: ""A testament to how our actions ..."<br>`[230]` **Estela Toras**: ""You'd be wise to consider what ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[233]` **Estela Toras**: ""I'm glad you agree."" |
| `[88]` | **""Unfortunately, my father's and my legacies are intertwined.""** | `[226]` **Estela Toras**: ""Sure, however, acknowledging th..."<br>`[227]` **Estela Toras**: ""A testament to how our actions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Estela Toras**: ""He may not have been a perfect ..." |
| `[89]` | **""A reminder to choose our path with care.""** | `[65]` **Estela Toras**: "“I’m not speaking of his actions..."<br>`[226]` **Estela Toras**: ""Sure, however, acknowledging th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Estela Toras**: ""Yes, because our name carries w..." |
| `[90]` | **""What matters is what I do, not what the name did.""** | `[67]` **Estela Toras**: "“Legacies are shaped by more tha..."<br>`[232]` **Estela Toras**: ""Yes, because our name carries w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Estela Toras**: ""But you're not just living for ..." |
| `[91]` | **""I'll ensure the name stands strong, even if it means shouldering the weight alone.""** | `[67]` **Estela Toras**: "“Legacies are shaped by more tha..."<br>`[232]` **Estela Toras**: ""Yes, because our name carries w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Estela Toras**: ""I'm pleased to hear it."" |
| `[92]` | **""My actions speak louder than any family name. I'll forge my path.""** | `[67]` **Estela Toras**: "“Legacies are shaped by more tha..."<br>`[232]` **Estela Toras**: ""Yes, because our name carries w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Estela Toras**: ""Don't underestimate the power o..." |
| `[93]` | **""Indeed, like divine threads in a grand design, guiding us toward a purpose beyond..."** | `[70]` **Estela Toras**: "“Sometimes, the most profound re..." | `Variable["RiziaDLC.Trait_ReligiousKing"]` | *Brak zmian stanu* | `[72]` **Player_Romus**: "“My triumph over Pales will rect..."<br>`[182]` **Player_Romus**: ""Bringing Zille back into our fo..."<br>*(oraz 8 innych odgałęzień)* |
| `[94]` | **""Father's path proved it's the choices, not fate, that shape our destiny.""** | `[70]` **Estela Toras**: "“Sometimes, the most profound re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Player_Romus**: "“My triumph over Pales will rect..."<br>`[182]` **Player_Romus**: ""Bringing Zille back into our fo..."<br>*(oraz 8 innych odgałęzień)* |
| `[95]` | **""I'll embrace whatever responsibilities destiny throws at me, be it triumphs or de..."** | `[70]` **Estela Toras**: "“Sometimes, the most profound re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Player_Romus**: "“My triumph over Pales will rect..."<br>`[182]` **Player_Romus**: ""Bringing Zille back into our fo..."<br>*(oraz 8 innych odgałęzień)* |
| `[96]` | **""My victory over Pales will honor his memory by finishing what he started.""** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[252]` **Estela Toras**: ""A noble resolve, but beware of ..." |
| `[97]` | **""God willing, my victory over Pales will honor his memory by finishing what he sta..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[252]` **Estela Toras**: ""A noble resolve, but beware of ..." |
| `[98]` | **""I appreciate your concern, but this time will be different. God is on our side. I..."** | `[74]` **Narrator**: "I began pacing around the hall." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[623]` **Estela Toras**: ""Relying solely on divine interv..." |
| `[99]` | **""You can't see into the future any more than anyone else.""** | `[74]` **Narrator**: "I began pacing around the hall." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Estela Toras**: ""You sound just like him. But I'..." |
| `[117]` | **""I do mind. You could have said what you needed to say within the past four years.""** | `[57]` **Estela Toras**: "“If you don’t mind, I’d like to ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[122]` **Narrator**: "She folded her arms and scowled ..." |
| `[127]` | **""We all do, dear. She's always with us in our hearts.""** | `[126]` **Vina Toras**: ""Feels like we were just here. I..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[131]` **Vina Toras**: ""I know. But I'm still filled wi..." |
| `[132]` | **""It's not your fault, Vina. You couldn't have predicted it. It was a tragic accide..."** | `[133]` **Vina Toras**: ""It was my own pleading that ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Vina Toras**: ""But she would still be here if ..." |
| `[134]` | **""Your mother wouldn't want you carrying that burden.""** | `[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>`[193]` **Vina Toras**: ""Acknowledging it doesn't make t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Narrator**: "Her eyes brimmed with tears." |
| `[136]` | **""We're here because it's what people do. They come, they remember, and then they m..."** | `[126]` **Vina Toras**: ""Feels like we were just here. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Vina Toras**: ""Maybe for you, but it still fee..."<br>`[187]` **Vina Toras**: ""That's easy for you to say. Reg..." |
| `[137]` | **""Your mother's presence is timeless, and it's only right that we revisit this place.""** | `[126]` **Vina Toras**: ""Feels like we were just here. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Vina Toras**: ""Timeless, maybe. But sometimes ..." |
| `[138]` | **""Yes, but time moves on, so we must as well.""** | `[126]` **Vina Toras**: ""Feels like we were just here. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Vina Toras**: ""Maybe for you, but it still fee..." |
| `[139]` | **""You were a child. I was the one who refused the trip. If I had gone, I could've b..."** | `[133]` **Vina Toras**: ""It was my own pleading that ste..." | `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false` | *Brak zmian stanu* | `[195]` **Vina Toras**: ""It's hard not to wonder, what if?"" |
| `[140]` | **""Blaming yourself for the storm won't bring her back.""** | `[133]` **Vina Toras**: ""It was my own pleading that ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Vina Toras**: ""But it doesn't make the guilt a..." |
| `[141]` | **""The storm wasn't your doing. You need to move past this fixation with what could ..."** | `[133]` **Vina Toras**: ""It was my own pleading that ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Vina Toras**: ""Acknowledging it doesn't make t..." |
| `[142]` | **""We all do, dear.""** | `[126]` **Vina Toras**: ""Feels like we were just here. I..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[188]` **Vina Toras**: ""You don't understand. I still t..." |
| `[158]` | **""We felt it would be more appropriate to limit visiting Lena to family only.""** | `[159]` **Estela Toras**: ""Hm. He didn't feel like joining..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Vina Toras**: ""If by 'we', you mean 'you.'"" |
| `[167]` | **""I understand. He's quite busy now that he's majority speaker.""** | `[159]` **Estela Toras**: ""Hm. He didn't feel like joining..." | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true` | *Brak zmian stanu* | `[212]` **Estela Toras**: ""Busy with what, dear? You know ..." |
| `[168]` | **""Lena would have hated to see her daughter dating a Sazon.""** | `[159]` **Estela Toras**: ""Hm. He didn't feel like joining..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Estela Toras**: ""Don't be so sure."" |
| `[169]` | **""What would be the point? Lena wasn't *his* mother.""** | `[159]` **Estela Toras**: ""Hm. He didn't feel like joining..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Estela Toras**: ""No, indeed. He'd be lucky to ha..." |
| `[182]` | **""Bringing Zille back into our fold will rectify his mistake of giving it away so f..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false` | `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = ...` | `[260]` **Estela Toras**: ""He chose the lesser of two evil..." |
| `[194]` | **""You were a child. I was on that boat, too, and I could have saved her life.""** | `[133]` **Vina Toras**: ""It was my own pleading that ste..." | `Variable["RiziaDLC.Prologue_InBoatAccident"] == true` | *Brak zmian stanu* | `[195]` **Vina Toras**: ""It's hard not to wonder, what if?"" |
| `[225]` | **""What's the use of a legacy if it doesn't change anything for the living?""** | `[63]` **Estela Toras**: "“May he rest in peace as his leg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Estela Toras**: ""Sure, however, acknowledging th..." |
| `[229]` | **""Yes. Unfortunately, my father's and my legacies are intertwined.""** | `[65]` **Estela Toras**: "“I’m not speaking of his actions..."<br>`[230]` **Estela Toras**: ""You'd be wise to consider what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Estela Toras**: ""He may not have been a perfect ..." |
| `[242]` | **""It's as if there are subtle forces at play, nudging us toward responsibilities we..."** | `[70]` **Estela Toras**: "“Sometimes, the most profound re..." | `(Variable["RiziaDLC.Trait_ReligiousKing"]) == false` | *Brak zmian stanu* | `[72]` **Player_Romus**: "“My triumph over Pales will rect..."<br>`[182]` **Player_Romus**: ""Bringing Zille back into our fo..."<br>*(oraz 8 innych odgałęzień)* |
| `[243]` | **""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to ave..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[251]` **Estela Toras**: ""I'm concerned that your relentl..." |
| `[250]` | **""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to ave..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[253]` **Estela Toras**: ""Our family's honor was never lo..." |
| `[261]` | **""Reclaiming Zille will honor his memory by finishing what he started.""** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`<br>`(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[271]` **Estela Toras**: ""Your words would have been a so..." |
| `[262]` | **""Reclaiming Zille, God willing, will honor his memory by finishing what he started.""** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[273]` **Estela Toras**: ""A noble resolve indeed. Your wo..." |
| `[263]` | **""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to ..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`<br>`(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[272]` **Estela Toras**: ""As hard as it may be to accept,..." |
| `[270]` | **""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to ..."** | `[71]` **Player_Romus**: "“Destiny or not, I'll strive to ..."<br>`[93]` **Player_Romus**: ""Indeed, like divine threads in ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true`<br>`(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[274]` **Estela Toras**: ""As hard as it may be to accept,..." |
| `[275]` | **""I pray she's found peace in the afterlife.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[287]` **Narrator**: "A passing smile hinted at a memo..." |
| `[279]` | **""I hope she has found peace in whatever comes next.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[286]` **Narrator**: "A momentary smile suggested a me..." |
| `[283]` | **""She gave me the greatest gift of all, Vina. For that, I will always be in her debt.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[288]` **Narrator**: "A transient smile hinted at a me..." |
| `[290]` | **""I had no idea. So many lives were saved, thanks to that one conversation.""** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false` | *Brak zmian stanu* | `[291]` **Estela Toras**: ""To think... if only she was aro..." |
| `[292]` | **""A love letter? So the old man had a heart after all?""** | `[48]` **Estela Toras**: "“A love letter from your father ..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[460]` **Narrator**: "Mother took back the letter."<br>`[308]` **Estela Toras**: ""There's a lot you don't know ab..." |
| `[296]` | **""A love letter? Somehow I have trouble picturing Father writing one of those.""** | `[48]` **Estela Toras**: "“A love letter from your father ..." | `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false` | *Brak zmian stanu* | `[464]` **Narrator**: "Mother took the envelope back."<br>`[309]` **Estela Toras**: ""There was far more to him than ..." |
| `[300]` | **""Oh. For a moment there I thought you were handing me divorce paperwork.""** | `[31]` **Estela Toras**: "“A love letter from your father ..."<br>`[48]` **Estela Toras**: "“A love letter from your father ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[302]` **Estela Toras**: ""It's five years and a heart att..." |
| `[301]` | **""Really? What's it say?""** | `[31]` **Estela Toras**: "“A love letter from your father ..."<br>`[48]` **Estela Toras**: "“A love letter from your father ..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[448]` **Narrator**: "She took the letter back."<br>`[313]` **Estela Toras**: ""That's between your father and ..." |
| `[314]` | **""You alright?""** | `[52]` **Narrator**: "As we neared, my mother’s pace s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Estela Toras**: ""Yes. I've never been better."" |
| `[316]` | **"Say nothing."** | `[52]` **Narrator**: "As we neared, my mother’s pace s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "The flame's flickering glow cast..." |
| `[317]` | **""If this is becoming too much for you, I'll understand.""** | `[52]` **Narrator**: "As we neared, my mother’s pace s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Estela Toras**: ""Your concern is appreciated, bu..." |
| `[319]` | **""Are we doing this or what?""** | `[52]` **Narrator**: "As we neared, my mother’s pace s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Estela Toras**: ""Of course! That was never in do..." |
| `[323]` | **""More like kicking the can down the road for others to clean up.""** | `[260]` **Estela Toras**: ""He chose the lesser of two evil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Estela Toras**: ""Nevertheless, the Toras family ..." |
| `[324]` | **""We can dwell on the loss until the end of time. What matters is our resilience to..."** | `[260]` **Estela Toras**: ""He chose the lesser of two evil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Estela Toras**: ""Agreed. It's time to move forwa..." |
| `[325]` | **""Maybe. But it doesn't make reclaiming it any easier.""** | `[260]` **Estela Toras**: ""He chose the lesser of two evil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Estela Toras**: ""No, I suppose not. But we must ..." |
| `[326]` | **""A mistake is a mistake, not matter how you try to sugarcoat it.""** | `[260]` **Estela Toras**: ""He chose the lesser of two evil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Estela Toras**: ""Which we must learn from to avo..." |
| `[337]` | **""My reforms are for the good of the country. If anything our concessions will make..."** | `[336]` **Estela Toras**: ""Your reforms to the monarchy ar..."<br>`[353]` **Estela Toras**: ""Which, I'm sorry to say, are sl..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Estela Toras**: ""You and I seem to have differen..." |
| `[338]` | **""We need to get with the times. If we don't evolve, we'll be left in the dust like..."** | `[336]` **Estela Toras**: ""Your reforms to the monarchy ar..."<br>`[353]` **Estela Toras**: ""Which, I'm sorry to say, are sl..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Estela Toras**: ""I'd say your policies imply tha..." |
| `[339]` | **""Don't worry. I've got everything under control.""** | `[336]` **Estela Toras**: ""Your reforms to the monarchy ar..."<br>`[353]` **Estela Toras**: ""Which, I'm sorry to say, are sl..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[348]` **Estela Toras**: ""Those who believe they're in co..." |
| `[343]` | **""That's none of your concern. I know what I'm doing.""** | `[336]` **Estela Toras**: ""Your reforms to the monarchy ar..."<br>`[353]` **Estela Toras**: ""Which, I'm sorry to say, are sl..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[349]` **Estela Toras**: ""If by putting the founding prin..." |
| `[344]` | **""This is neither the time nor the place to discuss Crown policy. I don't wish to d..."** | `[336]` **Estela Toras**: ""Your reforms to the monarchy ar..."<br>`[353]` **Estela Toras**: ""Which, I'm sorry to say, are sl..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Estela Toras**: ""Very well. But given your conce..." |
| `[365]` | **""Yes, we wouldn't want to be late.""** | `[364]` **Estela Toras**: ""Right on cue. Shall we head to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Estela Toras**: ""We're already late, but as king..." |
| `[367]` | **""Right. Almost forgot all about it. I'm sure Vina is wondering where we are.""** | `[364]` **Estela Toras**: ""Right on cue. Shall we head to ..." | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[386]` **Estela Toras**: ""Then we'd best be off."" |
| `[371]` | **""Right. Almost forgot all about it.""** | `[364]` **Estela Toras**: ""Right on cue. Shall we head to ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[386]` **Estela Toras**: ""Then we'd best be off."" |
| `[373]` | **""Before we part, know this -- I shape my own legacy, free from the expectations of..."** | `[372]` **Narrator**: "Before departing, I cast a final..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Estela Toras**: ""I understand. For what it's wor..." |
| `[374]` | **""In the spirit of transparency, know that I fully intend to reclaim Pales, rectify..."** | `[372]` **Narrator**: "Before departing, I cast a final..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[381]` **Estela Toras**: ""Then good luck to you then. Tho..." |
| `[375]` | **""Before we go... you should know that I intend to uphold Father's legacy. I will d..."** | `[372]` **Narrator**: "Before departing, I cast a final..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Estela Toras**: ""May your endeavors to rejuvenat..." |
| `[376]` | **""Since we're being forthright, I want you to know that I intend to preserve Father..."** | `[372]` **Narrator**: "Before departing, I cast a final..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[380]` **Estela Toras**: ""I can't help but feel a sense o..." |
| `[385]` | **""Yes. Just give me a second alone with father.""** | `[364]` **Estela Toras**: ""Right on cue. Shall we head to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[869]` **Narrator**: "She kissed me on the cheek and p..." |
| `[465]` | **""Isn't the allure of gossip beneath someone of your age and stature?""** | `[624]` **Estela Toras**: ""Or so the rumors say.""<br>`[362]` **Estela Toras**: ""I've heard whispers about your ..."<br>*(oraz 12 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` | *Brak zmian stanu* | `[468]` **Estela Toras**: ""Gossip is the fuel on which mon..." |
| `[466]` | **""Whispers and rumors... they hold no more substance than passing reflections.""** | `[624]` **Estela Toras**: ""Or so the rumors say.""<br>`[362]` **Estela Toras**: ""I've heard whispers about your ..."<br>*(oraz 12 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` | *Brak zmian stanu* | `[469]` **Estela Toras**: ""I see that instead of addressin..." |
| `[467]` | **""The glow of divine providence renders whispers and rumors as transitory as sunlig..."** | `[624]` **Estela Toras**: ""Or so the rumors say.""<br>`[362]` **Estela Toras**: ""I've heard whispers about your ..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` | *Brak zmian stanu* | `[470]` **Estela Toras**: ""Fancy words. Almost as if you w..." |
| `[471]` | **""Rumors are as fleeting as sunlight dancing on water.""** | `[624]` **Estela Toras**: ""Or so the rumors say.""<br>`[362]` **Estela Toras**: ""I've heard whispers about your ..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`<br>`(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` | *Brak zmian stanu* | `[470]` **Estela Toras**: ""Fancy words. Almost as if you w..." |
| `[513]` | **""It may be hard to believe, but your mother's death was part of God's plan. We sho..."** | `[135]` **Vina Toras**: ""But she would still be here if ..."<br>`[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[523]` **Vina Toras**: ""Trust goes both ways, Father. W..." |
| `[517]` | **""We still have each other. You don't know how scared I was of losing you during th..."** | `[135]` **Vina Toras**: ""But she would still be here if ..."<br>`[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[196]` **Vina Toras**: ""So you do feel lucky to have me..."<br>`[527]` **Vina Toras**: ""You were never in danger of los..." |
| `[521]` | **""Acknowledging that you were responsible for the death of the love of my life won'..."** | `[135]` **Vina Toras**: ""But she would still be here if ..."<br>`[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[528]` **Narrator**: "Tears filled her eyes." |
| `[522]` | **""It could have been worse. I could've lost you as well.""** | `[135]` **Vina Toras**: ""But she would still be here if ..."<br>`[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>*(oraz 2 innych węzłów)* | `((Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[196]` **Vina Toras**: ""So you do feel lucky to have me..."<br>`[527]` **Vina Toras**: ""You were never in danger of los..." |
| `[546]` | **""I understand. His duties as a delegate must keep him quite busy.""** | `[159]` **Estela Toras**: ""Hm. He didn't feel like joining..." | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false` | *Brak zmian stanu* | `[212]` **Estela Toras**: ""Busy with what, dear? You know ..." |
| `[553]` | **""I liked her enough. We just never felt a spark.""** | `[552]` **Estela Toras**: "“Neither did you, I suspect, or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Estela Toras**: ""Perhaps you resented your arran..." |
| `[555]` | **""Oh, I remember. You never met a noblewoman you didn't disparage.""** | `[21]` **Estela Toras**: "“You of all people know what an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Estela Toras**: ""I was insecure, darling. Even a..." |
| `[559]` | **""A shame you could never hold your tongue around her sister.""** | `[216]` **Estela Toras**: ""It was only after you were marr..."<br>`[217]` **Estela Toras**: ""Believe me when I say that I di..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[560]` **Estela Toras**: ""Beatrice never had it easy. Sho..." |
| `[572]` | **""Lena's naivete overlooked the full implications of welcoming all those foreigners.""** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true` | *Brak zmian stanu* | `[573]` **Estela Toras**: ""No. She thought about their hum..." |
| `[574]` | **""What do you think she'd make of my decision to go to war with Pales?""** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[575]` **Estela Toras**: ""Good question. I suppose we'll ..." |
| `[585]` | **""You've described her exactly. Whenever I make a royal decision, I try to see the ..."** | `[27]` **Estela Toras**: ""The next day, I persuaded Valer..." | `Variable["RiziaDLC.Prologue_LovedWife"]` | *Brak zmian stanu* | `[586]` **Estela Toras**: ""Who knows what insights she wou..." |
| `[588]` | **""Your grandmother's exaggerating, Vina. She didn't know your mother at all.""** | `[178]` **Vina Toras**: ""I wish I'd known her as well as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[592]` **Estela Toras**: ""We conversed much more often th..." |
| `[589]` | **""Really, Mother? 'Like a daughter'? You never met a noblewoman you didn't disparage.""** | `[178]` **Vina Toras**: ""I wish I'd known her as well as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Estela Toras**: ""I was insecure, darling. Even a..." |
| `[594]` | **""I had no idea you felt that way about her.""** | `[178]` **Vina Toras**: ""I wish I'd known her as well as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Estela Toras**: ""Come now. You know I'm not one ..." |
| `[597]` | **""Lena won over every person she met. Even prickly Queen Consorts.""** | `[178]` **Vina Toras**: ""I wish I'd known her as well as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Estela Toras**: ""Ha! I confess it took me a whil..." |
| `[604]` | **""Your mother's passing was a part of life. It's important to find strength in the ..."** | `[135]` **Vina Toras**: ""But she would still be here if ..."<br>`[189]` **Vina Toras**: ""But it doesn't make the guilt a..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[605]` **Vina Toras**: ""I'm not sure memories are enoug..." |
| `[618]` | **""Indeed. Recognizing the influence of the past on the present is crucial.""** | `[227]` **Estela Toras**: ""A testament to how our actions ..."<br>`[230]` **Estela Toras**: ""You'd be wise to consider what ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[233]` **Estela Toras**: ""I'm glad you agree."" |
| `[622]` | **""I appreciate your concern, but this time will be different.""** | `[74]` **Narrator**: "I began pacing around the hall." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[255]` **Estela Toras**: ""Your attention should be on the..." |
| `[625]` | **""Since we're being honest with one another... Know that Father's legacy and opinio..."** | `[372]` **Narrator**: "Before departing, I cast a final..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Estela Toras**: ""Very well. I trust you know wha..." |
| `[652]` | **""You're making a fuss over nothing, Mother. The Duke and I had the deal clinched. ..."** | `[664]` **Estela Toras**: ""Look at how you handled yoursel..." | `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | *Brak zmian stanu* | `[691]` **Narrator**: "Vina's lip trembled. I saw outra..." |
| `[665]` | **""Yes, she has indeed shown remarkable strength and resilience.""** | `[664]` **Estela Toras**: ""Look at how you handled yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Narrator**: "Despite Vina's attempts to conce..." |
| `[675]` | **""No, not at all.""** | `[671]` **Estela Toras**: ""A bit harsh, wouldn't you say?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[680]` **Estela Toras**: ""Well, it was. Unless your goal ..." |
| `[676]` | **""You're right. I didn't need to react that way. I will speak to her about it later.""** | `[671]` **Estela Toras**: ""A bit harsh, wouldn't you say?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[695]` **Estela Toras**: ""Good. This family has enough pr..." |
| `[677]` | **""She'll be fine. Don't worry about her.""** | `[671]` **Estela Toras**: ""A bit harsh, wouldn't you say?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[689]` **Estela Toras**: ""I'm her grandmother. It's my jo..." |
| `[678]` | **""I'll parent my way, and you parent yours.""** | `[671]` **Estela Toras**: ""A bit harsh, wouldn't you say?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[679]` **Estela Toras**: ""I wouldn't call that parenting...." |
| `[681]` | **""Yes, that's *exactly* what I want to do. What better way to forge better family t..."** | `[680]` **Estela Toras**: ""Well, it was. Unless your goal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[692]` **Estela Toras**: ""Sarcasm doesn't suit you. It's ..." |
| `[682]` | **""You're making a fuss over nothing, Mother. A true diplomat wouldn't have caused a..."** | `[664]` **Estela Toras**: ""Look at how you handled yoursel..." | `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[691]` **Narrator**: "Vina's lip trembled. I saw outra..." |
| `[690]` | **""That's very kind of you, Mother. Vina indeed handled herself like a true princess.""** | `[664]` **Estela Toras**: ""Look at how you handled yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[688]` **Narrator**: "Even as Vina tried to conceal he..." |
| `[693]` | **""Watch your tone. I am your king.""** | `[680]` **Estela Toras**: ""Well, it was. Unless your goal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[696]` **Estela Toras**: ""And I am your mother. If anybod..." |
| `[694]` | **""Vina is free to marry whomever she chooses. You, of all people, should understand..."** | `[655]` **Narrator**: "She looked at me pointedly."<br>`[712]` **Estela Toras**: ""It's about time we consider wed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[701]` **Estela Toras**: ""I don't need a lecture on the i..." |
| `[698]` | **""What's done is done. I'm sure she'll forget all about it and forgive me in no time.""** | `[680]` **Estela Toras**: ""Well, it was. Unless your goal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[697]` **Estela Toras**: ""I wouldn't be so sure of that. ..." |
| `[699]` | **""I agree. Unfortunately, I suspect she still has her heart set on Manus.""** | `[655]` **Narrator**: "She looked at me pointedly."<br>`[712]` **Estela Toras**: ""It's about time we consider wed..." | `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false` | *Brak zmian stanu* | `[709]` **Estela Toras**: ""Love has its own stubborn ways,..." |
| `[700]` | **""I couldn't agree more. However, it seems this kingdom lacks suitable men of good ..."** | `[655]` **Narrator**: "She looked at me pointedly."<br>`[712]` **Estela Toras**: ""It's about time we consider wed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[704]` **Estela Toras**: ""Then perhaps you should start l..."<br>`[703]` **Estela Toras**: ""Then maybe you should start loo..." |
| `[705]` | **""I keep coming back to the same answer. The only way to ensure our stability is to..."** | `[655]` **Narrator**: "She looked at me pointedly."<br>`[712]` **Estela Toras**: ""It's about time we consider wed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[710]` **Estela Toras**: ""That trigger should be pulled o..." |
| `[728]` | **""Did my wife know you were a Dastnurist?""** | `[727]` **Narrator**: "I hadn't thought much about it a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[735]` **Narrator**: "My mother went pale as a sheet." |
| `[732]` | **""Wine? No, what you two shared was an attachment to your heathen faith.""** | `[727]` **Narrator**: "I hadn't thought much about it a..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[735]` **Narrator**: "My mother went pale as a sheet." |
| `[733]` | **""There's something I need to bring up with you. Have you secretly been practicing ..."** | `[727]` **Narrator**: "I hadn't thought much about it a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[735]` **Narrator**: "My mother went pale as a sheet." |
| `[734]` | **""Please, enough about Lena. This is already a very emotional day for me.""** | `[727]` **Narrator**: "I hadn't thought much about it a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[736]` **Estela Toras**: ""Emotional, Romus? You haven't s..." |
| `[739]` | **""Please. I'm not judging you. I just want you to be honest with me.”"** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[758]` **Estela Toras**: ""Oh, I highly doubt you're not j..."<br>`[750]` **Narrator**: "Mother stood firm, her gaze unfa..." |
| `[741]` | **""Don't lie to me! Do you take me for a fool? I know all about it.""** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[750]` **Narrator**: "Mother stood firm, her gaze unfa..." |
| `[742]` | **""Titus told me where you where the night Father died.""** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | `(Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true) == false` | *Brak zmian stanu* | `[748]` **Estela Toras**: ""You had me investigated? Your o..." |
| `[743]` | **""Come on, Mother. I know all about it.""** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[750]` **Narrator**: "Mother stood firm, her gaze unfa..." |
| `[747]` | **""Well, that's a relief. I guess I can close the case on that one. What was I think..."** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[749]` **Estela Toras**: ""Don't take that tone with me! Y..." |
| `[754]` | **""Lucita told me where you where the night Father died.""** | `[738]` **Estela Toras**: "“I don’t know what you’re talkin..." | `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true` | *Brak zmian stanu* | `[759]` **Estela Toras**: ""The same Lucita who's in jail f..."<br>`[748]` **Estela Toras**: ""You had me investigated? Your o..." |
| `[763]` | **""It is if you want to be part of the Rizian Royal Family. Why couldn't you have ma..."** | `[740]` **Estela Toras**: "“It’s called faith for a reason...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[770]` **Estela Toras**: ""Sacrifice and compromise are va..." |
| `[764]` | **""Was your whole family Dastnurist? How could you have kept this a secret for so lo..."** | `[740]` **Estela Toras**: "“It’s called faith for a reason...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[771]` **Estela Toras**: ""Only my grandmother, God rest h..." |
| `[765]` | **""I understand. But I wish I hadn't found out this way. You should have trusted me ..."** | `[740]` **Estela Toras**: "“It’s called faith for a reason...."<br>`[774]` **Estela Toras**: ""To turn my back on Dastnurity w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[766]` **Estela Toras**: ""I'm sorry I felt compelled to h..." |
| `[778]` | **""Listen to me, Mother. You have to convert before it's too late.""** | `[769]` **Estela Toras**: ""But as king, and more important..."<br>`[774]` **Estela Toras**: ""To turn my back on Dastnurity w..." | `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true` | *Brak zmian stanu* | `[779]` **Estela Toras**: ""Too late?!"" |
| `[781]` | **""To hell with your grandma's memory. What about betraying your son?""** | `[774]` **Estela Toras**: ""To turn my back on Dastnurity w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[766]` **Estela Toras**: ""I'm sorry I felt compelled to h..." |
| `[782]` | **""If she was alive when you were crowned Princess Consort, she would have told you ..."** | `[774]` **Estela Toras**: ""To turn my back on Dastnurity w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[783]` **Estela Toras**: ""I'll never know, will I?"" |
| `[784]` | **""You don't have to hide anymore. I am building a Rizia where all branches of the N..."** | `[769]` **Estela Toras**: ""But as king, and more important..." | `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true` | *Brak zmian stanu* | `[801]` **Estela Toras**: ""Oh, I know. And I'm grateful fo..." |
| `[788]` | **""You don't have to hide anymore. I am building a Rizia where no religion dominates..."** | `[769]` **Estela Toras**: ""But as king, and more important..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`<br>`(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false` | *Brak zmian stanu* | `[802]` **Estela Toras**: ""Oh, I know. And I imagine Grand..." |
| `[792]` | **""Thank you for your honesty. And don't worry. Nobody else has to know about this.""** | `[769]` **Estela Toras**: ""But as king, and more important..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[833]` **Narrator**: "She put a hand to her chest and ..." |
| `[793]` | **""Now that your secret's out, I implore you to convert to Wruhecism.""** | `[769]` **Estela Toras**: ""But as king, and more important..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[825]` **Narrator**: "She looked at me worriedly." |
| `[794]` | **""I can't believe Lena never told me.""** | `[740]` **Estela Toras**: "“It’s called faith for a reason...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[798]` **Estela Toras**: ""You two were never exactly fort..."<br>`[799]` **Estela Toras**: ""She wanted to. I swore her to s..." |
| `[818]` | **""Very well, I won't tell anyone. But it goes without saying that you've shattered ..."** | `[808]` **Estela Toras**: ""And Captain Muscles out there.""<br>`[812]` **Estela Toras**: ""After all, the only other perso..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[850]` **Estela Toras**: ""Well, when you manage to put it..." |
| `[819]` | **""I won't force you to convert. But for your own sake, please be more careful in co..."** | `[817]` **Estela Toras**: ""After all, the only other perso..."<br>`[780]` **Estela Toras**: ""Can't you just keep this betwee..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[851]` **Estela Toras**: ""I was doing just fine before yo..." |
| `[820]` | **""Your secret is safe. But I do pray that in due time, you'll see the error of your..."** | `[817]` **Estela Toras**: ""After all, the only other perso..."<br>`[780]` **Estela Toras**: ""Can't you just keep this betwee..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[852]` **Estela Toras**: ""Pray away, my son. This soul's ..." |
| `[826]` | **""You don't have to hide anymore. I am building a Rizia where Dastnurity can flouri..."** | `[769]` **Estela Toras**: ""But as king, and more important..." | `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true`<br>`(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false` | *Brak zmian stanu* | `[801]` **Estela Toras**: ""Oh, I know. And I'm grateful fo..." |
| `[830]` | **""You don't have to hide anymore. Actually, revealing your religion might boost my ..."** | `[769]` **Estela Toras**: ""But as king, and more important..." | `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false` | *Brak zmian stanu* | `[831]` **Narrator**: "She hurriedly shook her head." |
| `[835]` | **""Please, Mother. If you love me, you'll do this for me.""** | `[817]` **Estela Toras**: ""After all, the only other perso..."<br>`[780]` **Estela Toras**: ""Can't you just keep this betwee..." | `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[845]` **Estela Toras**: ""My son over my faith... it's an..." |
| `[836]` | **""I am building a new Rizia. One in which the Wruhecist faith triumphs over all oth..."** | `[817]` **Estela Toras**: ""After all, the only other perso..."<br>`[780]` **Estela Toras**: ""Can't you just keep this betwee..." | `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`<br>`(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[846]` **Estela Toras**: ""Oh, dear."" |
| `[840]` | **""More people know your secret than just us two. It's only a matter of time before ..."** | `[817]` **Estela Toras**: ""After all, the only other perso..."<br>`[780]` **Estela Toras**: ""Can't you just keep this betwee..." | `Variable["RiziaDLC.Lucita_Arrested"] == false`<br>`(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | *Brak zmian stanu* | `[844]` **Estela Toras**: ""My dear, if you don't trust you..." |
| `[858]` | **""Thank you, Mother. You won't regret it.""** | `[849]` **Estela Toras**: ""But never mind that. If it's re..."<br>`[856]` **Estela Toras**: ""But if it's really so important..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[863]` **Estela Toras**: ""Next chance I get, I'll march d..." |
| `[859]` | **""Wait. I don't want to force you to become a Wruhecist for my sake. I only hope yo..."** | `[849]` **Estela Toras**: ""But never mind that. If it's re..."<br>`[856]` **Estela Toras**: ""But if it's really so important..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[860]` **Narrator**: "She put a hand to her chest and ..." |
| `[862]` | **""You will? Really?""** | `[849]` **Estela Toras**: ""But never mind that. If it's re..."<br>`[856]` **Estela Toras**: ""But if it's really so important..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[863]` **Estela Toras**: ""Next chance I get, I'll march d..." |
| `[866]` | **"“Let's leave it at that. I'm not in the mood for conversation.""** | `[63]` **Estela Toras**: "“May he rest in peace as his leg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Narrator**: "It was then we heard the far dis..." |
| `[879]` | **"Place the letter into the fire."** | `[889]` **Player_Romus**: ""Rest in peace, old man.""<br>`[903]` **Player_Romus**: ""I vow that I will rectify your ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true` | `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = true;` | `[883]` **Narrator**: "I departed soon after, leaving m..." |
| `[880]` | **"Keep the letter."** | `[889]` **Player_Romus**: ""Rest in peace, old man.""<br>`[903]` **Player_Romus**: ""I vow that I will rectify your ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true` | `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = false;` | `[883]` **Narrator**: "I departed soon after, leaving m..." |
| `[889]` | **""Rest in peace, old man.""** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |
| `[890]` | **""I vow that I will rectify your mistakes. I will reclaim Pales and become the grea..."** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] =...` | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |
| `[891]` | **""I will do right by you, Father. I will rejuvenate this nation the way you always ..."** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[893]` **Estela Toras**: ""May your endeavors to rejuvenat..." |
| `[892]` | **""The Rizian flag shall fly over Pales in your honor, Father.""** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] = true;` | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |
| `[900]` | **""I don't give a damn about your legacy or what you thought about me. I have my own..."** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;` | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |
| `[903]` | **""I vow that I will rectify your mistakes. I will take back Zille and become the gr..."** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |
| `[904]` | **"Say nothing."** | `[878]` **Narrator**: "His final words."<br>`[887]` **Narrator**: "I struggled to remember his face..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[879]` **Player_Romus_Italic**: "Having held onto it long enough,..."<br>`[880]` **Player_Romus_Italic**: "I considered consigning the lett..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[908]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Attending the Sovereign Memorial Commemo..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The National Mausoleum, high in the hills above Porte Drazon, embraced me with its stately presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I was here for the annual Sovereign Memorial Commemoratio..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was here for the annual Sovereign Memorial Commemoration, a ceremony honoring the former monarchs of Rizia, held just outside the mausoleum's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Hugo was overseeing the ceremony, and there was still som..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The hushed corridors were adorned with statues and inscriptions of monarchs from eras long past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The mausoleum stood as a witness to the enduring legacy o..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The mausoleum stood as a witness to the enduring legacy of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I had also come to honor the memory of my late wife, Lena..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I had also come to honor the memory of my late wife, Lena, whose resting place could be found within these hallowed grounds as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Adjacent to it stood a bouquet of recently placed flowers, a weekly tradition per Vina's instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus_Italic: "Leave the flowers as is."*)
  - -> `[9]` (*Player_Romus_Italic: "Take a flower."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Take a flower."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I took a flower from the bouquet and smelled it. The scen..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Leave the flowers as is."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As I stood in contemplation, reflecting upon our time tog..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I took a flower from the bouquet and smelled it. The scent of roses still reminded me of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "As I stood in contemplation, reflecting upon our time together, a gentle voice called from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[13]`
Mówca: **Estela Toras**
> "“Romus...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""What are you doing here?""*)
  - -> `[42]` (*Player_Romus: ""Well, well. Fancy meeting you here.""*)
  - -> `[14]` (*Player_Romus: "“Mother? This is a surprise.”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Mother? This is a surprise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hadn’t attended a Sovereign Memorial Commemoration si..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "She hadn’t attended a Sovereign Memorial Commemoration since Father’s passing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Estela Toras: "“At my age, surprises are as rare as non-gray hairs. Don'..."*)

### Węzeł `[16]`
Mówca: **Estela Toras**
> "“At my age, surprises are as rare as non-gray hairs. Don't act as though my presence is some extraordinary revelation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[17]`
Mówca: **Estela Toras**
> "“And, for the record, I can still navigate these halls without assistance--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Her eyes swept across the room, coming to rest on Lena's grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Estela Toras: "“Forgive my lack of decorum. I should treat this day with..."*)

### Węzeł `[19]`
Mówca: **Estela Toras**
> "“Forgive my lack of decorum. I should treat this day with the gravity it deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Gradually, she drew near, her eyes conveying unexpressed ..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Gradually, she drew near, her eyes conveying unexpressed sentiment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[21]`
Mówca: **Estela Toras**
> "“You of all people know what an extraordinary woman she was. Though I confess it took me a while to warm up to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Player_Romus: ""Oh, I remember. You never met a noblewoman you didn't di..."*)
  - -> `[39]` (*Player_Romus: ""You were her mother-in-law. There's always some friction..."*)
  - -> `[40]` (*Player_Romus: ""How do you know she was extraordinary? You two barely sp..."*)
  - -> `[43]` (*Player_Romus: ""I didn't know you felt that way about her.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“What was extraordinary about her? She was just another entitled noblewoman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[552]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Estela Toras: "“That's what I thought as well, darling. At first.""*)

### Węzeł `[23]`
Mówca: **Estela Toras**
> "“That's what I thought as well, darling. At first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Estela Toras: ""It was only after you were married that my love for her ..."*)

### Węzeł `[24]`
Mówca: **Estela Toras**
> "“I remember the exact moment my feelings toward Princess Lena changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[25]`
Mówca: **Estela Toras**
> "“It was right after the civil war broke out in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Estela Toras: ""You two were at Palas Rezna for dinner, and Lena and I a..."*)

### Węzeł `[26]`
Mówca: **Estela Toras**
> "“Up to that point, I was adamant that Rizia should accept as few Wehzek refugees as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Estela Toras: ""But as we discussed the situation, your wife made such a..."*)

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""The next day, I persuaded Valero to open our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""That sounds like her -- placing compassion before practi..."*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife"*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "My mother reached into her handbag and held up a weathered envelope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus_Italic: "Take the envelope."*)
  - -> `[30]` (*Player_Romus_Italic: "Don't take the envelope."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Take the envelope."]** — Mówca: **Player_Romus_Italic**
> "I took the envelope from her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = true;"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "Don't take the envelope."]** — Mówca: **Player_Romus_Italic**
> "I didn’t take the envelope."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = false;"*)

### Węzeł `[31]`
Mówca: **Estela Toras**
> "“A love letter from your father -- the first one he ever wrote. I want to honor him by giving it back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[45]` (*Player_Romus: ""How very thoughtful.""*)
  - -> `[32]` (*Player_Romus: "“Quite the keepsake.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Quite the keepsake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Estela Toras), `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "Soon, I found her sarcophagus, encased in gold as per tra..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Despite the absence of romance, I owed it to Vina, whose ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds like her -- placing compassion before practicality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Estela Toras: ""A monarch must reign with compassion, or all will be lost.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena and I never spoke about such weighty topics.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Estela Toras: ""That's a shame. Who knows how many valuable insights wer..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Love... now that's a word I rarely hear you say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Estela Toras: ""Love is a private sentiment, not a public performance. B..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were her mother-in-law. There's always some friction in that relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Estela Toras: ""Not only that. I was common-born, and she was a Livingst..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know she was extraordinary? You two barely spoke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras), `[552]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Estela Toras: ""We conversed much more often than you realized. You were..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Estela Toras), `[146]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hadn’t attended a Sovereign Memorial Commemoration si..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well. Fancy meeting you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Estela Toras), `[146]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hadn’t attended a Sovereign Memorial Commemoration si..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't know you felt that way about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras), `[552]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Estela Toras: ""Come now, you know I'm not one for garish displays of em..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not surprising at all. Everyone who met Lena loved her.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "A transient smile hinted at a memory that briefly crossed..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very thoughtful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Estela Toras), `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Estela Toras: "“A love letter from your father -- the first one he ever ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Estela Toras: "“A love letter from your father -- the first one he ever ..."*)

### Węzeł `[48]`
Mówca: **Estela Toras**
> "“A love letter from your father -- the first one he ever wrote. I thought it only fitting to give it back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[45]` (*Player_Romus: ""How very thoughtful.""*)
  - -> `[32]` (*Player_Romus: "“Quite the keepsake.”"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "My mother left the room, and I followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "We made our way down the great hall, past the resting pla..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "We made our way down the great hall, past the resting places of the great leaders, and some not-so-great, who came before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Turn06_Cemetary_FathersGrave = true;"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "It wasn’t long before the light from the Eternal Flame, a single torch placed at the late king’s sarcophagus symbolizing a monarch’s enduring reign, guided us the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "As we neared, my mother’s pace slowed as if waves of memo..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "As we neared, my mother’s pace slowed as if waves of memories pressed upon her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Player_Romus: ""Are we doing this or what?""*)
  - -> `[317]` (*Player_Romus: ""If this is becoming too much for you, I'll understand.""*)
  - -> `[314]` (*Player_Romus: ""You alright?""*)
  - -> `[316]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The flame's flickering glow cast dancing shadows on our path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "We stopped just before we reached my father’s stone encas..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "We stopped just before we reached my father’s stone encasing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Estela Toras: "“There you are...”"*)

### Węzeł `[55]`
Mówca: **Estela Toras**
> "“There you are...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "We both fell silent."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "We both fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "In the royal tradition, this was the resting place of the..."*)

### Węzeł `[57]`
Mówca: **Estela Toras**
> "“If you don’t mind, I’d like to say a few words to your father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""I'll give you some privacy.""*)
  - -> `[58]` (*Player_Romus: "“Please, by all means.”"*)
  - -> `[83]` (*Player_Romus: ""If you insist, but please make it brief. I don't have al..."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Please, by all means.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Estela Toras: "“Val... For 45 years, we walked different paths, our view..."*)

### Węzeł `[59]`
Mówca: **Estela Toras**
> "“Val... For 45 years, we walked different paths, our views often conflicting, and our words sometimes harsh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Estela Toras: ""But the love between us never waned.""*)

### Węzeł `[60]`
Mówca: **Estela Toras**
> ""But the love between us never waned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Estela Toras: ""My heart bears no bitterness. Instead, it carries the me..."*)

### Węzeł `[61]`
Mówca: **Estela Toras**
> ""So, in this space between the living and the departed, I speak these final words. My reserved heart lays bare the truth...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Estela Toras: ""I loved you then, I love you now.""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "She presented the letter to the flame, watching as it intensified, consuming the paper until it vanished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove = true;"*)

### Węzeł `[63]`
Mówca: **Estela Toras**
> "“May he rest in peace as his legacy lives on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == false"*)
  - -> `[225]` (*Player_Romus: ""What's the use of a legacy if it doesn't change anything..."*)
  - -> `[64]` (*Player_Romus: "“Legacy... I doubt history will be very kind.”"*)
  - -> `[866]` (*Player_Romus: "“Let's leave it at that. I'm not in the mood for conversa..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Legacy... I doubt history will be very kind.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Estela Toras: "“I’m not speaking of his actions on the throne. His legac..."*)

### Węzeł `[65]`
Mówca: **Estela Toras**
> "“I’m not speaking of his actions on the throne. His legacy is you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""A reminder to choose our path with care.""*)
  - -> `[66]` (*Player_Romus: "“A heavy burden to bear -- a name forever stained by the ..."*)
  - -> `[229]` (*Player_Romus: ""Yes. Unfortunately, my father's and my legacies are inte..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“A heavy burden to bear -- a name forever stained by the judgments of time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Estela Toras), `[226]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Estela Toras: "“Legacies are shaped by more than just deeds. What you ma..."*)

### Węzeł `[67]`
Mówca: **Estela Toras**
> "“Legacies are shaped by more than just deeds. What you make of the name matters just as much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""What matters is what I do, not what the name did.""*)
  - -> `[92]` (*Player_Romus: ""My actions speak louder than any family name. I'll forge..."*)
  - -> `[91]` (*Player_Romus: ""I'll ensure the name stands strong, even if it means sho..."*)
  - -> `[68]` (*Player_Romus: "“I can't escape the shadows of his choices, no matter wha..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I can't escape the shadows of his choices, no matter what path I forge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Estela Toras), `[232]` (Estela Toras), `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Estela Toras: ""Maybe not, but you can cast new shadows that speak of re..."*)

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""Maybe not, but you can cast new shadows that speak of redemption and resilience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: "“Sometimes, the most profound responsibilities are the on..."*)

### Węzeł `[70]`
Mówca: **Estela Toras**
> "“Sometimes, the most profound responsibilities are the ones we inherit, not by choice, but by destiny.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing"*)
  - -> `[95]` (*Player_Romus: ""I'll embrace whatever responsibilities destiny throws at..."*)
  - -> `[94]` (*Player_Romus: ""Father's path proved it's the choices, not fate, that sh..."*)
  - -> `[71]` (*Player_Romus: "“Destiny or not, I'll strive to leave a legacy that stand..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Destiny or not, I'll strive to leave a legacy that stands apart from the mistakes of my father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“My triumph over Pales will rectify his failure.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Estela Toras: "“Or be your undoing, just like him. His relentless pursui..."*)

### Węzeł `[73]`
Mówca: **Estela Toras**
> "“Or be your undoing, just like him. His relentless pursuit of victory at any cost consumed him, as I fear it may be consuming you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I began pacing around the hall."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "I began pacing around the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[99]` (*Player_Romus: ""You can't see into the future any more than anyone else.""*)
  - -> `[75]` (*Player_Romus: "“You know nothing.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You know nothing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Estela Toras: "“So sure of yourself. I'll tell you what I do know... ”"*)

### Węzeł `[76]`
Mówca: **Estela Toras**
> "“So sure of yourself. I'll tell you what I do know... ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Estela Toras: "“I know that my son is determined to embark on some milit..."*)

### Węzeł `[77]`
Mówca: **Estela Toras**
> "“I know that my son is determined to embark on some military expedition when his attention should be focused on the rightful restoration of Zille.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Estela Toras: "“I know that the very foundations of the monarchy have be..."*)

### Węzeł `[78]`
Mówca: **Estela Toras**
> "“I know that the very foundations of the monarchy have been put at risk through such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[79]`
Mówca: **Estela Toras**
> ""And speaking of risk... I've heard whispers about your *escapades* with House Azaro, a family harboring their own ambitions regarding the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Estela Toras: ""Or so the rumors say.""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true )"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[72]` (*Player_Romus: "“My triumph over Pales will rectify his failure.”"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""Bringing Zille back into our fold will rectify his mista..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you insist, but please make it brief. I don't have all day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I stepped away, granting her some space."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll give you some privacy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "I gave her some space to allow for a moment between the t..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find comfort in knowing that his legacy lives on, but it doesn't change the pain of his absence.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Estela Toras: ""The ache of loss may linger, but the impact he made will..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For better or worse, his legacy will live on.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Estela Toras: ""A testament to how our actions reverberate through time.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Recognizing the past's influence on the present is crucial, guided by divine blessings.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[227]` (Estela Toras), `[230]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Estela Toras: ""I'm glad you agree.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, my father's and my legacies are intertwined.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Estela Toras), `[227]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Estela Toras: ""He may not have been a perfect man, but his responsibili..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder to choose our path with care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Estela Toras), `[226]` (Estela Toras), `[227]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Estela Toras: ""Yes, because our name carries weight, son. It's not just..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What matters is what I do, not what the name did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Estela Toras), `[232]` (Estela Toras), `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Estela Toras: ""But you're not just living for yourself. The family name..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ensure the name stands strong, even if it means shouldering the weight alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Estela Toras), `[232]` (Estela Toras), `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Estela Toras: ""I'm pleased to hear it.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My actions speak louder than any family name. I'll forge my path.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Estela Toras), `[232]` (Estela Toras), `[234]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Estela Toras: ""Don't underestimate the power of a name. Your actions re..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, like divine threads in a grand design, guiding us toward a purpose beyond our choosing, much like Father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"]`
- **Kontekst wejściowy (poprzednik):** `[70]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Father's path proved it's the choices, not fate, that shape our destiny.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll embrace whatever responsibilities destiny throws at me, be it triumphs or defeats, much like my father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My victory over Pales will honor his memory by finishing what he started.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Estela Toras: ""A noble resolve, but beware of letting it consume you an..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God willing, my victory over Pales will honor his memory by finishing what he started.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Estela Toras: ""A noble resolve, but beware of letting it consume you an..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, but this time will be different. God is on our side. I can feel it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Estela Toras: ""Relying solely on divine intervention is misguided. Spea..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't see into the future any more than anyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Estela Toras: ""You sound just like him. But I'll tell you what I *do* s..."*)

### Węzeł `[100]`
Mówca: **Estela Toras**
> ""Farewell, until we meet where love knows no bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "She presented the letter to the flame, watching as it int..."*)

### Węzeł `[101]`
Mówca: **Estela Toras**
> ""The years may have etched lines on our faces, but they also deepened my affection for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Estela Toras: ""Through triumphs and tribulations, you were my confidant..."*)

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""My heart bears no bitterness. Instead, it carries the memories of laughter, shared moments, and a touch beyond words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Estela Toras: ""The years may have etched lines on our faces, but they a..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Estela Toras: "“Romus...”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "Vina, of course, was by my side. Her demeanor had become much more solemn since her return from Pales. She clasped her hands tightly around the bouquet she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Vina Toras: ""Feels like we were just here. I miss her so much.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave = true;"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave = t..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The National Mausoleum, high in the hills above Porte Dra..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The National Mausoleum, high in the hills above Porte Dra..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "I gave her some space to allow for a moment between the two of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "She spoke to him in a hushed whisper, for much longer tha..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "She spoke to him in a hushed whisper, for much longer than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "When she was finished, she took out the love letter and p..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "When she was finished, she took out the love letter and placed it on the sarcophagus. I took this as my cue to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove = true;"*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do mind. You could have said what you needed to say within the past four years.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[57]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "She folded her arms and scowled at me."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""I do mind. You could have said what you needed to say wi..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[121]`
Mówca: **Narrator**
> "I stepped away, granting her some space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She spoke to him in a hushed whisper, prolonging the conv..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "She folded her arms and scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Estela Toras: ""I was speaking rhetorically, Romus. I'll grieve as I see..."*)

### Węzeł `[123]`
Mówca: **Estela Toras**
> ""I was speaking rhetorically, Romus. I'll grieve as I see fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Narrator: "She stepped towards my father's resting place and spoke t..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "She spoke to him in a hushed whisper, prolonging the conversation far longer than I anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "When she finally concluded, she retrieved the love letter..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "When she finally concluded, she retrieved the love letter and let the flames of the torch consume it. Taking this as my cue, I returned to her side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove = true;"*)

### Węzeł `[126]`
Mówca: **Vina Toras**
> ""Feels like we were just here. I miss her so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""We're here because it's what people do. They come, they ..."*)
  - -> `[138]` (*Player_Romus: ""Yes, but time moves on, so we must as well.""*)
  - -> `[137]` (*Player_Romus: ""Your mother's presence is timeless, and it's only right ..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We all do, dear. She's always with us in our hearts.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""I know. But I'm still filled with regret.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""We all do, dear. She's always with us in our hearts.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""We all do, dear.""*)

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I know. But I'm still filled with regret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""It was my own pleading that steered us into that storm. ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault, Vina. You couldn't have predicted it. It was a tragic accident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Vina Toras: ""But she would still be here if I hadn't asked her to go.""*)

### Węzeł `[133]`
Mówca: **Vina Toras**
> ""It was my own pleading that steered us into that storm. We should have never set foot on that boat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[141]` (*Player_Romus: ""The storm wasn't your doing. You need to move past this ..."*)
  - -> `[140]` (*Player_Romus: ""Blaming yourself for the storm won't bring her back.""*)
  - -> `[132]` (*Player_Romus: ""It's not your fault, Vina. You couldn't have predicted i..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother wouldn't want you carrying that burden.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Narrator: "Her eyes brimmed with tears."*)

### Węzeł `[135]`
Mówca: **Vina Toras**
> ""But she would still be here if I hadn't asked her to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inc..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're here because it's what people do. They come, they remember, and then they move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother's presence is timeless, and it's only right that we revisit this place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Vina Toras: ""Timeless, maybe. But sometimes it feels like the memorie..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but time moves on, so we must as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Vina Toras: ""Maybe for you, but it still feels like I'm stuck in a mo..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were a child. I was the one who refused the trip. If I had gone, I could've been there to save her life.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[133]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Vina Toras: ""It's hard not to wonder, what if?""*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Blaming yourself for the storm won't bring her back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Vina Toras: ""But it doesn't make the guilt any easier to let go.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The storm wasn't your doing. You need to move past this fixation with what could have been.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Vina Toras: ""Acknowledging it doesn't make the guilt disappear. It's ..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We all do, dear.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[126]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Vina Toras: ""You don't understand. I still think about it every day.""*)

### Węzeł `[143]`
Mówca: **Narrator**
> "It wasn't long before we reached her mother's tomb. Vina set the bouquet in a vase next to the sarcophagus, which had been encased in gold, as was tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Vina Toras: ""I gathered these roses from the Royal Garden. They're th..."*)

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""I gathered these roses from the Royal Garden. They're the absolute best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)

### Węzeł `[145]`
Mówca: **Narrator**
> "We shared a quiet moment without words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "I stared at the tomb, allowing memories of Lena and the b..."*)

### Węzeł `[146]`
Mówca: **Estela Toras**
> ""Well, there you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""What are you doing here?""*)
  - -> `[42]` (*Player_Romus: ""Well, well. Fancy meeting you here.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true )"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Estela Toras: "“And, for the record, I can still navigate these halls wi..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Estela Toras: "“And, for the record, I can still navigate these halls wi..."*)

### Węzeł `[150]`
Mówca: **Estela Toras**
> "“And, for the record, I can still navigate these halls without assistance, thank you very much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaD..."*)

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Vina! It's so good to see you. You're looking as lovely as ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Vina Toras: ""You, too.""*)

### Węzeł `[152]`
Mówca: **Vina Toras**
> ""You, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Vina went to her, and they exchanged a brief embrace."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Vina went to her, and they exchanged a brief embrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.VinaManus_Together == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Vina Toras: ""We'll catch up later. I'm meeting Manus for a walk befor..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.VinaManus_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[157]`
Mówca: **Vina Toras**
> ""Speaking of which, I'm going to meet Manus for a short walk before the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Estela Toras: ""Hm. He didn't feel like joining you here?""*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We felt it would be more appropriate to limit visiting Lena to family only.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Vina Toras: ""If by 'we', you mean 'you.'""*)

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""Hm. He didn't feel like joining you here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""What would be the point? Lena wasn't *his* mother.""*)
  - -> `[168]` (*Player_Romus: ""Lena would have hated to see her daughter dating a Sazon.""*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[158]` (*Player_Romus: ""We felt it would be more appropriate to limit visiting L..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Before I could fully grasp the moment, she reached for my hand and delivered a sincere squeeze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Estela Toras: ""I so wish Vina could be here. She never got to know Lena..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "We shared a quiet moment without words."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "We shared a quiet moment without words until a voice from..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "I stared at the tomb, allowing memories of Lena and the boat accident to flood my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I was on the verge of becoming lost in thought when a voi..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "We shared a quiet moment without words until a voice from behind caught our attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "I was on the verge of becoming lost in thought when a voice called to me from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. He's quite busy now that he's majority speaker.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Kontekst wejściowy (poprzednik):** `[159]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Estela Toras: ""Busy with what, dear? You know your father always called..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena would have hated to see her daughter dating a Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Estela Toras: ""Don't be so sure.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would be the point? Lena wasn't *his* mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Estela Toras: ""No, indeed. He'd be lucky to have a Rumburgian princess ..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Despite the absence of romance, I owed it to Vina, whose captivity consumed my thoughts, to pay my respects."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "I'd endured many sleepless nights since she was taken."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Soon, I found her sarcophagus, encased in gold as per tradition. A heavy silence settled over me as I stood before it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "I'd endured many sleepless nights since she was taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Soon, I found her sarcophagus, encased in gold as per tra..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true )"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Before I could fully grasp the moment, she reached for my..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "She reached out and took Vina's hand, giving it a gentle ..."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "She reached out and took Vina's hand, giving it a gentle squeeze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Estela Toras: "“She was an extraordinary woman, your mother. I'd even go..."*)

### Węzeł `[177]`
Mówca: **Estela Toras**
> "“She was an extraordinary woman, your mother. I'd even go as far as to say she was like a daughter to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Vina Toras: ""I wish I'd known her as well as you did.""*)

### Węzeł `[178]`
Mówca: **Vina Toras**
> ""I wish I'd known her as well as you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Player_Romus: ""Your grandmother's exaggerating, Vina. She didn't know y..."*)
  - -> `[589]` (*Player_Romus: ""Really, Mother? 'Like a daughter'? You never met a noble..."*)
  - -> `[594]` (*Player_Romus: ""I had no idea you felt that way about her.""*)
  - -> `[597]` (*Player_Romus: ""Lena won over every person she met. Even prickly Queen C..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true )"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Estela Toras: ""And speaking of risk... I've heard whispers about your *..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bringing Zille back into our fold will rectify his mistake of giving it away so freely.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;"*)

### Węzeł `[183]`
Mówca: **Narrator**
> "As for Vina... the relentless thought of her captivity plagued my mind. I had hardly slept since she was taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As I stood in contemplation, reflecting upon our time tog..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Hugo was overseeing the ceremony, and there was still some time before it was to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The hushed corridors were adorned with statues and inscri..."*)

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""Maybe for you, but it still feels like I'm stuck in a moment I can't escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""It was my own pleading that steered us into that storm. ..."*)

### Węzeł `[186]`
Mówca: **Vina Toras**
> ""Timeless, maybe. But sometimes it feels like the memories are slipping away, and revisiting only makes the pain worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""It was my own pleading that steered us into that storm. ..."*)

### Węzeł `[187]`
Mówca: **Vina Toras**
> ""That's easy for you to say. Regret is a constant reminder of what I've lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""It was my own pleading that steered us into that storm. ..."*)

### Węzeł `[188]`
Mówca: **Vina Toras**
> ""You don't understand. I still think about it every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Vina Toras: ""It was my own pleading that steered us into that storm. ..."*)

### Węzeł `[189]`
Mówca: **Vina Toras**
> ""But it doesn't make the guilt any easier to let go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[134]` (*Player_Romus: ""Your mother wouldn't want you carrying that burden.""*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inc..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""You were a child. I was on that boat, too, and I could h..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""You were a child. I was the one who refused the trip. If..."*)

### Węzeł `[193]`
Mówca: **Vina Toras**
> ""Acknowledging it doesn't make the guilt disappear. It's not that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[134]` (*Player_Romus: ""Your mother wouldn't want you carrying that burden.""*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inc..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were a child. I was on that boat, too, and I could have saved her life.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Kontekst wejściowy (poprzednik):** `[133]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Vina Toras: ""It's hard not to wonder, what if?""*)

### Węzeł `[195]`
Mówca: **Vina Toras**
> ""It's hard not to wonder, what if?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inc..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[196]`
Mówca: **Vina Toras**
> ""So you do feel lucky to have me. You've got an interesting way of showing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "We walked the rest of the way in uncomfortable silence un..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "We walked the rest of the way in uncomfortable silence until we reached Lena's tomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Vina said a silent prayer and set the bouquet in a vase n..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Vina, of course, was by my side. Her demeanor had become ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Vina, of course, was by my side. She was holding a bouquet."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Vina, of course, was by my side. She was holding a bouquet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Vina Toras: ""Feels like we were just here. I miss her so much.""*)

### Węzeł `[202]`
Mówca: **Vina Toras**
> ""No... no, you're right. It won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "We walked the rest of the way in uncomfortable silence un..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Vina said a silent prayer and set the bouquet in a vase next to her mother's sarcophagus, which had been encased in gold, as was tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true)"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "In an instant, the memories of the boat accident came flo..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "As for Vina... the relentless thought of her captivity pl..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "In an instant, the memories of the boat accident came flooding back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "The deafening thunder that accompanied the torrent of rai..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "The deafening thunder that accompanied the torrent of rain, waves that tossed us around like rag dolls..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "But before I became lost in thought, my focus shifted bac..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "But before I became lost in thought, my focus shifted back to Vina, whose captivity consumed my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Narrator: "Since she was taken, I'd endured many sleepless nights."*)

### Węzeł `[210]`
Mówca: **Estela Toras**
> ""I agree with your father. Just because he's courting the king's daughter, it doesn't mean he has special privileges--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[211]`
Mówca: **Vina Toras**
> ""If by 'we', you mean 'you.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Estela Toras: ""I agree with your father. Just because he's courting the..."*)

### Węzeł `[212]`
Mówca: **Estela Toras**
> ""Busy with what, dear? You know your father always called his party a zoo full of paper tigers--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[213]`
Mówca: **Estela Toras**
> ""No, indeed. He'd be lucky to have a Rumburgian princess for a mother instead of that harpy--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[214]`
Mówca: **Estela Toras**
> ""Don't be so sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Estela Toras: ""Yes, the Livingstons are as traditionalist as they come,..."*)

### Węzeł `[215]`
Mówca: **Estela Toras**
> ""We conversed much more often than you realized. You were just too busy to notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Estela Toras: ""Believe me when I say that I did grow to love her.""*)

### Węzeł `[216]`
Mówca: **Estela Toras**
> ""It was only after you were married that my love for her grew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[559]` (*Player_Romus: ""A shame you could never hold your tongue around her sist..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[217]`
Mówca: **Estela Toras**
> ""Believe me when I say that I did grow to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[559]` (*Player_Romus: ""A shame you could never hold your tongue around her sist..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[218]`
Mówca: **Estela Toras**
> ""Come now, you know I'm not one for garish displays of emotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Estela Toras: ""But, yes, it's true. I did grow to love her dearly.""*)

### Węzeł `[219]`
Mówca: **Estela Toras**
> ""But, yes, it's true. I did grow to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[559]` (*Player_Romus: ""A shame you could never hold your tongue around her sist..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[220]`
Mówca: **Estela Toras**
> ""Not only that. I was common-born, and she was a Livingston. She was practically bred to hate me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Estela Toras: ""But somehow, she managed to completely defy my expectati..."*)

### Węzeł `[221]`
Mówca: **Estela Toras**
> ""But somehow, she managed to completely defy my expectations, and I grew to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == false"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == false)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus: ""I find comfort in knowing that his legacy lives on, but ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""For better or worse, his legacy will live on.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the use of a legacy if it doesn't change anything for the living?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Estela Toras: ""Sure, however, acknowledging the past can often guide us..."*)

### Węzeł `[226]`
Mówca: **Estela Toras**
> ""Sure, however, acknowledging the past can often guide us in shaping a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""A reminder to choose our path with care.""*)
  - -> `[88]` (*Player_Romus: ""Unfortunately, my father's and my legacies are intertwin..."*)
  - -> `[66]` (*Player_Romus: "“A heavy burden to bear -- a name forever stained by the ..."*)

### Węzeł `[227]`
Mówca: **Estela Toras**
> ""A testament to how our actions reverberate through time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[89]` (*Player_Romus: ""A reminder to choose our path with care.""*)
  - -> `[88]` (*Player_Romus: ""Unfortunately, my father's and my legacies are intertwin..."*)

### Węzeł `[228]`
Mówca: **Estela Toras**
> ""The ache of loss may linger, but the impact he made will endure through the ages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Estela Toras: ""You'd be wise to consider what imprint *you* wish to lea..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Unfortunately, my father's and my legacies are intertwined.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Estela Toras), `[230]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Estela Toras: ""He may not have been a perfect man, but his responsibili..."*)

### Węzeł `[230]`
Mówca: **Estela Toras**
> ""You'd be wise to consider what imprint *you* wish to leave behind as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[89]` (*Player_Romus: ""A reminder to choose our path with care.""*)
  - -> `[229]` (*Player_Romus: ""Yes. Unfortunately, my father's and my legacies are inte..."*)

### Węzeł `[231]`
Mówca: **Estela Toras**
> ""He may not have been a perfect man, but his responsibilities are now yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Estela Toras: ""Actions matter, but how you carry the family name matter..."*)

### Węzeł `[232]`
Mówca: **Estela Toras**
> ""Yes, because our name carries weight, son. It's not just the actions. It's how you carry the responsibility that defines the legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""What matters is what I do, not what the name did.""*)
  - -> `[92]` (*Player_Romus: ""My actions speak louder than any family name. I'll forge..."*)
  - -> `[91]` (*Player_Romus: ""I'll ensure the name stands strong, even if it means sho..."*)
  - -> `[68]` (*Player_Romus: "“I can't escape the shadows of his choices, no matter wha..."*)

### Węzeł `[233]`
Mówca: **Estela Toras**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Estela Toras: ""Our name carries weight. It's not just the actions. It's..."*)

### Węzeł `[234]`
Mówca: **Estela Toras**
> ""Actions matter, but how you carry the family name matters equally. Your choices will shape our legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""What matters is what I do, not what the name did.""*)
  - -> `[92]` (*Player_Romus: ""My actions speak louder than any family name. I'll forge..."*)
  - -> `[91]` (*Player_Romus: ""I'll ensure the name stands strong, even if it means sho..."*)
  - -> `[68]` (*Player_Romus: "“I can't escape the shadows of his choices, no matter wha..."*)

### Węzeł `[235]`
Mówca: **Estela Toras**
> ""Our name carries weight. It's not just the actions. It's how you carry the responsibility that defines the legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""What matters is what I do, not what the name did.""*)
  - -> `[92]` (*Player_Romus: ""My actions speak louder than any family name. I'll forge..."*)
  - -> `[91]` (*Player_Romus: ""I'll ensure the name stands strong, even if it means sho..."*)
  - -> `[68]` (*Player_Romus: "“I can't escape the shadows of his choices, no matter wha..."*)

### Węzeł `[236]`
Mówca: **Estela Toras**
> ""But you're not just living for yourself. The family name is a part of you, and its heritage is in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: "“Sometimes, the most profound responsibilities are the on..."*)

### Węzeł `[237]`
Mówca: **Estela Toras**
> ""Don't underestimate the power of a name. Your actions reflect not just on you but on our family as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: "“Sometimes, the most profound responsibilities are the on..."*)

### Węzeł `[238]`
Mówca: **Estela Toras**
> ""I'm pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: "“Sometimes, the most profound responsibilities are the on..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""Indeed, like divine threads in a grand design, guiding u..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""It's as if there are subtle forces at play, nudging us t..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's as if there are subtle forces at play, nudging us toward responsibilities we never chose but are fated to fulfill, much like Father.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"]) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to avenge it and restore honor to our house.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Estela Toras: ""I'm concerned that your relentless pursuit to reclaim Pa..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""God willing, my victory over Pales will honor his memory..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""My victory over Pales will honor his memory by finishing..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""His defeat in Pales is one of Rizia's greatest tragedies..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: ""His defeat in Pales is one of Rizia's greatest tragedies..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His defeat in Pales is one of Rizia's greatest tragedies. That's why I aim to avenge it and restore honor to our house -- by any means necessary.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Estela Toras: ""Our family's honor was never lost. Even in defeat, your ..."*)

### Węzeł `[251]`
Mówca: **Estela Toras**
> ""I'm concerned that your relentless pursuit to reclaim Pales may lead to a case of history repeating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I began pacing around the hall."*)

### Węzeł `[252]`
Mówca: **Estela Toras**
> ""A noble resolve, but beware of letting it consume you and cloud your judgment, as it did your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I began pacing around the hall."*)

### Węzeł `[253]`
Mówca: **Estela Toras**
> ""Our family's honor was never lost. Even in defeat, your father fought with dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Estela Toras: ""That said, I fear your determination to reclaim Pales ma..."*)

### Węzeł `[254]`
Mówca: **Estela Toras**
> ""That said, I fear your determination to reclaim Pales may lead to a case of history repeating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I began pacing around the hall."*)

### Węzeł `[255]`
Mówca: **Estela Toras**
> ""Your attention should be on the rightful restoration of Zille, not Pales!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""The very foundation of the monarchy is being put at risk..."*)

### Węzeł `[256]`
Mówca: **Estela Toras**
> ""You sound just like him. But I'll tell you what I *do* see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Estela Toras: "“I see a son determined to embark on a military expeditio..."*)

### Węzeł `[257]`
Mówca: **Estela Toras**
> "“I see a son determined to embark on a military expedition when his attention should be focused on the rightful restoration of Zille.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Estela Toras: "“I see the very foundation of the monarchy being put at r..."*)

### Węzeł `[258]`
Mówca: **Estela Toras**
> "“I see the very foundation of the monarchy being put at risk through such actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[259]`
Mówca: **Estela Toras**
> ""The very foundation of the monarchy is being put at risk through such actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[260]`
Mówca: **Estela Toras**
> ""He chose the lesser of two evils. And in doing so, we retained the throne. The only mistake would have been inaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player_Romus: ""More like kicking the can down the road for others to cl..."*)
  - -> `[324]` (*Player_Romus: ""We can dwell on the loss until the end of time. What mat..."*)
  - -> `[325]` (*Player_Romus: ""Maybe. But it doesn't make reclaiming it any easier.""*)
  - -> `[326]` (*Player_Romus: ""A mistake is a mistake, not matter how you try to sugarc..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reclaiming Zille will honor his memory by finishing what he started.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` AND `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Estela Toras: ""Your words would have been a source of pride for him, as..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reclaiming Zille, God willing, will honor his memory by finishing what he started.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Estela Toras: ""A noble resolve indeed. Your words would have been a sou..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to do everything possible to see it returned.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` AND `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Estela Toras: ""As hard as it may be to accept, he took the necessary st..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""Reclaiming Zille, God willing, will honor his memory by ..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Reclaiming Zille will honor his memory by finishing what..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""Surrendering Zille was one of Rizia's greatest tragedies..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player_Romus: ""Surrendering Zille was one of Rizia's greatest tragedies..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surrendering Zille was one of Rizia's greatest tragedies. That's why I intend to do everything possible to see it returned -- by any means necessary.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true` AND `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[93]` (Player_Romus), `[94]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""As hard as it may be to accept, he did what needed to be..."*)

### Węzeł `[271]`
Mówca: **Estela Toras**
> ""Your words would have been a source of pride for him, as they are with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;"*)

### Węzeł `[272]`
Mówca: **Estela Toras**
> ""As hard as it may be to accept, he took the necessary steps to secure the throne for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;"*)

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""A noble resolve indeed. Your words would have been a source of pride for him, as they are with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;"*)

### Węzeł `[274]`
Mówca: **Estela Toras**
> ""As hard as it may be to accept, he did what needed to be done so that we would retain the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;"*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray she's found peace in the afterlife.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "A passing smile hinted at a memory that briefly flickered..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""I pray she's found peace in the afterlife.""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""I hope she has found peace in whatever comes next.""*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope she has found peace in whatever comes next.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "A momentary smile suggested a memory that fleetingly illu..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""That's not surprising at all. Everyone who met Lena love..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""She gave me the greatest gift of all, Vina. For that, I ..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She gave me the greatest gift of all, Vina. For that, I will always be in her debt.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "A transient smile hinted at a memory that briefly crossed..."*)

### Węzeł `[284]`
Mówca: **Estela Toras**
> ""Love is a private sentiment, not a public performance. But yes, my affection toward Lena was quite strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "A fleeting smile hinted at a memory that briefly illumina..."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "A fleeting smile hinted at a memory that briefly illuminated her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: "“I remember the exact moment my feelings toward Princess ..."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "A momentary smile suggested a memory that fleetingly illuminated her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: "“I remember the exact moment my feelings toward Princess ..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "A passing smile hinted at a memory that briefly flickered through her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: "“I remember the exact moment my feelings toward Princess ..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "A transient smile hinted at a memory that briefly crossed her thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: "“I remember the exact moment my feelings toward Princess ..."*)

### Węzeł `[289]`
Mówca: **Estela Toras**
> ""A monarch must reign with compassion, or all will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea. So many lives were saved, thanks to that one conversation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Estela Toras: ""To think... if only she was around to talk to Wiktor Smo..."*)

### Węzeł `[291]`
Mówca: **Estela Toras**
> ""To think... if only she was around to talk to Wiktor Smolak now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A love letter? So the old man had a heart after all?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""A love letter? So the old man had a heart after all?""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player_Romus: ""A love letter? Somehow I have trouble picturing Father w..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A love letter? Somehow I have trouble picturing Father writing one of those.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true )"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""Oh. For a moment there I thought you were handing me div..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player_Romus: ""Really? What's it say?""*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. For a moment there I thought you were handing me divorce paperwork.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Estela Toras), `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Estela Toras: ""It's five years and a heart attack too late for me to di..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? What's it say?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[31]` (Estela Toras), `[48]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[302]`
Mówca: **Estela Toras**
> ""It's five years and a heart attack too late for me to divorce Valero, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)

### Węzeł `[303]`
Mówca: **Narrator**
> "She took the envelope out of my hands and shoved it back into the bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Estela Toras: ""Let's go pay him a visit.""*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "She took the envelope out of my hands and shoved it back ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "She shoved the letter back in her bag."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "She shoved the letter back in her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Estela Toras: ""Let's go pay him a visit.""*)

### Węzeł `[308]`
Mówca: **Estela Toras**
> ""There's a lot you don't know about him. That you never bothered trying to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Estela Toras: ""Come. Let's go pay him a visit.""*)

### Węzeł `[309]`
Mówca: **Estela Toras**
> ""There was far more to him than you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Estela Toras: ""Come. Let's go pay him a visit.""*)

### Węzeł `[310]`
Mówca: **Estela Toras**
> ""Come. Let's go pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "My mother left the room, and I followed behind."*)

### Węzeł `[311]`
Mówca: **Estela Toras**
> ""Let's go pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "My mother left the room, and I followed behind."*)

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""It was only gathering dust in my writing desk. Come, let's pay him a visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "My mother left the room, and I followed behind."*)

### Węzeł `[313]`
Mówca: **Estela Toras**
> ""That's between your father and me. Come, let's see what he's up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "My mother left the room, and I followed behind."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You alright?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Estela Toras: ""Yes. I've never been better.""*)

### Węzeł `[315]`
Mówca: **Estela Toras**
> ""Yes. I've never been better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The flame's flickering glow cast dancing shadows on our p..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "But I said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The flame's flickering glow cast dancing shadows on our p..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this is becoming too much for you, I'll understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Estela Toras: ""Your concern is appreciated, but I'll be fine.""*)

### Węzeł `[318]`
Mówca: **Estela Toras**
> ""Your concern is appreciated, but I'll be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The flame's flickering glow cast dancing shadows on our p..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we doing this or what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Estela Toras: ""Of course! That was never in doubt.""*)

### Węzeł `[320]`
Mówca: **Estela Toras**
> ""Of course! That was never in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The flame's flickering glow cast dancing shadows on our p..."*)

### Węzeł `[321]`
Mówca: **Estela Toras**
> ""However, I'm pleased to hear your commitment to ensuring its return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More like kicking the can down the road for others to clean up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Estela Toras: ""Nevertheless, the Toras family still stands.""*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can dwell on the loss until the end of time. What matters is our resilience to reclaim what's ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Estela Toras: ""Agreed. It's time to move forward.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe. But it doesn't make reclaiming it any easier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""No, I suppose not. But we must do what must be done to p..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A mistake is a mistake, not matter how you try to sugarcoat it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Estela Toras: ""Which we must learn from to avoid repetition.""*)

### Węzeł `[327]`
Mówca: **Estela Toras**
> ""No, I suppose not. But we must do what must be done to preserve our territorial integrity, not to mention our family name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[328]`
Mówca: **Estela Toras**
> ""Agreed. It's time to move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Estela Toras: ""Though, of course, the further forward we move, the clos..."*)

### Węzeł `[329]`
Mówca: **Estela Toras**
> ""Nevertheless, the Toras family still stands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[330]`
Mówca: **Estela Toras**
> ""Which we must learn from to avoid repetition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[331]`
Mówca: **Estela Toras**
> ""Though, of course, the further forward we move, the closer we may get to hitting a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[332]`
Mówca: **Estela Toras**
> ""Though I fear you'll have to learn that lesson yourself when it comes to Crown policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Estela Toras: ""Yes, darling, I've heard rumors that you may begin worki..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Estela Toras: ""Though for how long, is a question that lingers.""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[336]`
Mówca: **Estela Toras**
> ""Your reforms to the monarchy are slowly chipping away at our most sacred institution. If you're not careful, I fear nothing will be left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "GovReforms_Hub"*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My reforms are for the good of the country. If anything our concessions will make our monarchy stronger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Estela Toras), `[353]` (Estela Toras), `[361]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Estela Toras: ""You and I seem to have different definitions of what it ..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to get with the times. If we don't evolve, we'll be left in the dust like all the other monarchies that have gone extinct.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Estela Toras), `[353]` (Estela Toras), `[361]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Estela Toras: ""I'd say your policies imply that extinction is your goal..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I've got everything under control.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[336]` (Estela Toras), `[353]` (Estela Toras), `[361]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Estela Toras: ""Those who believe they're in control often find themselv..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true )"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""That's none of your concern. I know what I'm doing.""*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Romus: ""Don't worry. I've got everything under control.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern. I know what I'm doing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[336]` (Estela Toras), `[353]` (Estela Toras), `[361]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Estela Toras: ""If by putting the founding principles of the monarchy in..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is neither the time nor the place to discuss Crown policy. I don't wish to discuss it any further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Estela Toras), `[353]` (Estela Toras), `[361]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Estela Toras: ""Very well. But given your concern for legacy, you're cer..."*)

### Węzeł `[345]`
Mówca: **Estela Toras**
> ""Very well. But given your concern for legacy, you're certainly risking tarnishing it with such reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Relationship_Hub]"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Relationship_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Relationship_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "Relationship_Hub"*)

### Węzeł `[348]`
Mówca: **Estela Toras**
> ""Those who believe they're in control often find themselves at the mercy of unforeseen circumstances, and risk losing it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Relationship_Hub]"*)

### Węzeł `[349]`
Mówca: **Estela Toras**
> ""If by putting the founding principles of the monarchy in jeopardy, then yes. I'd say you're succeeding on that end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Relationship_Hub]"*)

### Węzeł `[350]`
Mówca: **Estela Toras**
> ""I'd say your policies imply that extinction is your goal. These reforms set a dangerous precedence and come with great risks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Relationship_Hub]"*)

### Węzeł `[351]`
Mówca: **Estela Toras**
> ""You and I seem to have different definitions of what it means to be strong. From my vantage point, I'd say the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Estela Toras: ""Taking such risks sets a dangerous precedence.""*)

### Węzeł `[352]`
Mówca: **Estela Toras**
> ""Taking such risks sets a dangerous precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Relationship_Hub]"*)

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""Which, I'm sorry to say, are slowly being chipped away. I fear that if we continue on this trajectory, there might be nothing substantial remaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "GovReforms_Hub"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Estela Toras: ""Which, I'm sorry to say, are slowly being chipped away. ..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Estela Toras: ""Though I fear you'll have to learn that lesson yourself ..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""Yes, darling, I've heard rumors that you may begin working with a certain someone on reforming the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Estela Toras: ""It's none of my business, of course. But it's bound to m..."*)

### Węzeł `[361]`
Mówca: **Estela Toras**
> ""It's none of my business, of course. But it's bound to make you a host of enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "GovReforms_Hub"*)

### Węzeł `[362]`
Mówca: **Estela Toras**
> ""I've heard whispers about your *escapades* with House Azaro, a family harboring their own ambitions regarding the throne. And you know how risky rumors can be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[363]`
Mówca: **Narrator**
> "It was then we heard the far distant rings of the bells of the Archsanctuary of Zilba begin to chime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Estela Toras: ""Right on cue. Shall we head to the ceremony?""*)

### Węzeł `[364]`
Mówca: **Estela Toras**
> ""Right on cue. Shall we head to the ceremony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[365]` (*Player_Romus: ""Yes, we wouldn't want to be late.""*)
  - -> `[385]` (*Player_Romus: ""Yes. Just give me a second alone with father.""*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we wouldn't want to be late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Estela Toras: ""We're already late, but as king, that's your prerogative.""*)

### Węzeł `[366]`
Mówca: **Estela Toras**
> ""We're already late, but as king, that's your prerogative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Before departing, I cast a final glance at Father's resti..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Almost forgot all about it. I'm sure Vina is wondering where we are.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[364]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Estela Toras: ""Then we'd best be off.""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player_Romus: ""Right. Almost forgot all about it.""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""Right. Almost forgot all about it. I'm sure Vina is wond..."*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Almost forgot all about it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[364]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Estela Toras: ""Then we'd best be off.""*)

### Węzeł `[372]`
Mówca: **Narrator**
> "Before departing, I cast a final glance at Father's resting place, and a rush of memories flooded my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Player_Romus: ""Since we're being honest with one another... Know that F..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[375]` (*Player_Romus: ""Before we go... you should know that I intend to uphold ..."*)
  - -> `[373]` (*Player_Romus: ""Before we part, know this -- I shape my own legacy, free..."*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we part, know this -- I shape my own legacy, free from the expectations of a faded form. Father's views on my choices carry no weight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Estela Toras: ""I understand. For what it's worth, as hard as it may be ..."*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the spirit of transparency, know that I fully intend to reclaim Pales, rectifying Father's mistakes. While I understand you have your sights set on Zille, I believe this is what's best.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[372]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Estela Toras: ""Then good luck to you then. Though, you're going to need..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we go... you should know that I intend to uphold Father's legacy. I will do right by him by rejuvenating this nation in accordance with his wishes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Estela Toras: ""May your endeavors to rejuvenate our nation bring about ..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since we're being forthright, I want you to know that I intend to preserve Father's legacy and do right by him. I vow to fulfill what he started by reclaiming Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[372]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Estela Toras: ""I can't help but feel a sense of skepticism and concern,..."*)

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""Very well. I trust you know what's best. I'll pray for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;"*)

### Węzeł `[378]`
Mówca: **Estela Toras**
> ""I understand. For what it's worth, as hard as it may be to believe, he would have been proud of you no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;"*)

### Węzeł `[379]`
Mówca: **Estela Toras**
> ""May your endeavors to rejuvenate our nation bring about the greatness he envisioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;"*)

### Węzeł `[380]`
Mówca: **Estela Toras**
> ""I can't help but feel a sense of skepticism and concern, but I trust in God, and I have faith that you'll succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales = true;"*)

### Węzeł `[381]`
Mówca: **Estela Toras**
> ""Then good luck to you then. Though, you're going to need more than luck to reclaim Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player_Romus: ""In the spirit of transparency, know that I fully intend ..."*)
  - -> `[376]` (*Player_Romus: ""Since we're being forthright, I want you to know that I ..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Just give me a second alone with father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Narrator: "She kissed me on the cheek and patted my shoulder."*)

### Węzeł `[386]`
Mówca: **Estela Toras**
> ""Then we'd best be off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Before departing, I cast a final glance at Father's resti..."*)

### Węzeł `[387]`
Mówca: **Narrator**
> "I took my mother's arm and we departed, leaving my father to his solitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "DepartTomb_Hub"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "DepartTomb_Hub"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "DepartTomb_Hub"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "DepartTomb_Hub"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "DepartTomb_Hub"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DepartTomb_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "I took my mother's arm and we departed, leaving my father..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Estela Toras: ""Your reforms to the monarchy are slowly chipping away at..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[398]`
Mówca: **Estela Toras**
> ""Though for how long, is a question that lingers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Estela Toras: ""Your reforms to the monarchy are slowly chipping away at..."*)

### Węzeł `[399]`
Mówca: **Estela Toras**
> ""That said...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Estela Toras: ""Speaking of mistakes...""*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Estela Toras: ""We're sometimes required to face risks and challenges he..."*)

### Węzeł `[403]`
Mówca: **Estela Toras**
> ""Speaking of mistakes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Finale_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "It was then we heard the far distant rings of the bells o..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == tru..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Estela Toras: ""Though, I can't say the same for your commitment to refo..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[408]`
Mówca: **Estela Toras**
> ""Though, I can't say the same for your commitment to reforming the monarchy, which is slowly chipping away at our most sacred institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Estela Toras: ""If you're not careful, I fear nothing will be left by th..."*)

### Węzeł `[409]`
Mówca: **Estela Toras**
> ""If you're not careful, I fear nothing will be left by the time you're through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "GovReforms_Hub"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Estela Toras: ""Speaking of securing the throne...""*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Estela Toras: ""In life, we're sometimes required to face risks and chal..."*)

### Węzeł `[413]`
Mówca: **Estela Toras**
> ""Speaking of securing the throne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true ..."*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == tru..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Estela Toras: ""However, I can't say the same toward your crusade to ref..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[417]`
Mówca: **Estela Toras**
> ""However, I can't say the same toward your crusade to reform the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Estela Toras: ""If you're not careful, I fear nothing will be left to sa..."*)

### Węzeł `[418]`
Mówca: **Estela Toras**
> ""If you're not careful, I fear nothing will be left to salvage by the time you're through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "GovReforms_Hub"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Estela Toras: ""However, I can't say the same across the board.""*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Estela Toras: ""Sometimes in life, we're required to face risks and chal..."*)

### Węzeł `[422]`
Mówca: **Estela Toras**
> ""However, I can't say the same across the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "In the royal tradition, this was the resting place of the most recently deceased monarch of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Narrator: "When I died, I would take my father's place beside the Et..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_MothersLove"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Estela Toras: "“May he rest in peace as his legacy lives on.""*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Turn06_Cemetary_FathersGrave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Turn06_Cemetary_FathersGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "It wasn’t long before the light from the Eternal Flame, a..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_LenaGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaLenaGrave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_Sov_Memorial = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_Sov_Memorial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLega..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_MotherFathersLega..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "In an instant, the memories of the boat accident came flo..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As I stood in contemplation, reflecting upon our time tog..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Vina Toras: ""Maybe for you, but it still feels like I'm stuck in a mo..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Vina Toras: ""That's easy for you to say. Regret is a constant reminde..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Estela Toras: ""Well, there you are.""*)

### Węzeł `[437]`
Mówca: **Estela Toras**
> ""I so wish Vina could be here. She never got to know Lena the way I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true )"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_Sov_Memorial_NoVina = true;"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_Sov_Memorial = true;"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Estela Toras: ""Not to mention your misadventures in cooperation with th..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "Relationship_Hub"*)

### Węzeł `[444]`
Mówca: **Estela Toras**
> ""Not to mention your misadventures in cooperation with the opposition party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "She took the letter back."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Estela Toras: ""That's between your father and me. Come, let's see what ..."*)

### Węzeł `[448]`
Mówca: **Narrator**
> "She took the letter back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Estela Toras: ""That's between your father and me. Come, let's see what ..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "She took the envelope back."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""It was only gathering dust in my writing desk. Come, let..."*)

### Węzeł `[452]`
Mówca: **Narrator**
> "She took the envelope back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""It was only gathering dust in my writing desk. Come, let..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "She took the letter back."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""It was only gathering dust in my writing desk. Come, let..."*)

### Węzeł `[456]`
Mówca: **Narrator**
> "She took the letter back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""It was only gathering dust in my writing desk. Come, let..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "Mother took back the letter."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Estela Toras: ""There's a lot you don't know about him. That you never b..."*)

### Węzeł `[460]`
Mówca: **Narrator**
> "Mother took back the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Estela Toras: ""There's a lot you don't know about him. That you never b..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Narrator: "Mother took the envelope back."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_TakeEnvelope"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Estela Toras: ""There was far more to him than you know.""*)

### Węzeł `[464]`
Mówca: **Narrator**
> "Mother took the envelope back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Estela Toras: ""There was far more to him than you know.""*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Isn't the allure of gossip beneath someone of your age and stature?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[624]` (Estela Toras), `[362]` (Estela Toras), `[486]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Estela Toras: ""Gossip is the fuel on which monarchies run. I thought yo..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whispers and rumors... they hold no more substance than passing reflections.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[624]` (Estela Toras), `[362]` (Estela Toras), `[486]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Estela Toras: ""I see that instead of addressing my concern, you choose ..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The glow of divine providence renders whispers and rumors as transitory as sunlight on water.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[624]` (Estela Toras), `[362]` (Estela Toras), `[486]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Estela Toras: ""Fancy words. Almost as if you were trying to deflect fro..."*)

### Węzeł `[468]`
Mówca: **Estela Toras**
> ""Gossip is the fuel on which monarchies run. I thought you knew that already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "Jump to: [Finale_Hub]"*)

### Węzeł `[469]`
Mówca: **Estela Toras**
> ""I see that instead of addressing my concern, you choose to deflect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "Jump to: [Finale_Hub]"*)

### Węzeł `[470]`
Mówca: **Estela Toras**
> ""Fancy words. Almost as if you were trying to deflect from the rumors' substance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "Jump to: [Finale_Hub]"*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumors are as fleeting as sunlight dancing on water.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` AND `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[624]` (Estela Toras), `[362]` (Estela Toras), `[486]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Estela Toras: ""Fancy words. Almost as if you were trying to deflect fro..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true )"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""The glow of divine providence renders whispers and rumor..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Player_Romus: ""Rumors are as fleeting as sunlight dancing on water.""*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Finale_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "Finale_Hub"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Risk_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true )"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Estela Toras: ""That said...""*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Estela Toras: ""Still, I expect nothing but discretion from both you and..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true )"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Estela Toras: ""Speaking of integrity...""*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Estela Toras: ""It requires us to face risks and challenges head-on, whe..."*)

### Węzeł `[484]`
Mówca: **Estela Toras**
> ""Speaking of integrity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GovReforms_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: ""My reforms are for the good of the country. If anything ..."*)
  - -> `[338]` (*Player_Romus: ""We need to get with the times. If we don't evolve, we'll..."*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[344]` (*Player_Romus: ""This is neither the time nor the place to discuss Crown ..."*)

### Węzeł `[486]`
Mówca: **Estela Toras**
> ""Still, I expect nothing but discretion from both you and your daughter. Wouldn't want to risk stirring up too much gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[488]`
Mówca: **Estela Toras**
> ""It requires us to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true )"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Estela Toras: ""Speaking of which...""*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Estela Toras: ""Which is why I'm expecting nothing but discretion from b..."*)

### Węzeł `[493]`
Mówca: **Estela Toras**
> ""Speaking of which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Estela Toras: ""I've heard whispers about your *escapades* with House Az..."*)

### Węzeł `[494]`
Mówca: **Estela Toras**
> ""Which is why I'm expecting nothing but discretion from both you and your daughter. Wouldn't want to risk stirring up too much gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[496]`
Mówca: **Estela Toras**
> ""We're sometimes required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[498]`
Mówca: **Estela Toras**
> ""In life, we're sometimes required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[500]`
Mówca: **Estela Toras**
> ""Sometimes in life, we're required to face risks and challenges head-on, whether from hostile actors or simple gossip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "Jump to: [Risk_Hub]"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Risk_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Risk_Hub"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Estela Toras: ""He chose the lesser of two evils. And in doing so, we re..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_ZilleChat = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_ZilleChat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Estela Toras: ""However, I'm pleased to hear your commitment to ensuring..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaD..."*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || Rizi..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Estela Toras: ""Vina! I'm so glad you made it back to Rizia in time to p..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Estela Toras: ""Vina! It's so good to see you. You're looking as lovely ..."*)

### Węzeł `[507]`
Mówca: **Narrator**
> "She embraced her granddaughter, then held her at arm's length."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Estela Toras: ""I'd say your time among the Palesians has done wonders f..."*)

### Węzeł `[508]`
Mówca: **Estela Toras**
> ""Vina! I'm so glad you made it back to Rizia in time to pay your respects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "She embraced her granddaughter, then held her at arm's le..."*)

### Węzeł `[509]`
Mówca: **Vina Toras**
> ""Grandmother! I will remind you that I'm spoken for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Vina Toras: ""Speaking of which, I'm going to meet Manus for a short w..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""It may be hard to believe, but your mother's death was p..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Player_Romus: ""Your mother's passing was a part of life. It's important..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be hard to believe, but your mother's death was part of God's plan. We should not question His designs, only trust in His wisdom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Vina Toras), `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Vina Toras: ""Trust goes both ways, Father. What has God done to earn ..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inc..."*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.War_Incident_Border == true || RiziaDLC.War_I..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""We still have each other. You don't know how scared I wa..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true) && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Player_Romus: ""It could have been worse. I could've lost you as well.""*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have each other. You don't know how scared I was of losing you during the Pales incident.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Vina Toras), `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player_Romus: ""Acknowledging that you were responsible for the death of..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging that you were responsible for the death of the love of my life won't bring comfort to either of us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Vina Toras), `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Narrator: "Tears filled her eyes."*)

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could have been worse. I could've lost you as well.""
- **Wymagania odblokowania (kod gry):** `((Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true)  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Vina Toras), `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[523]`
Mówca: **Vina Toras**
> ""Trust goes both ways, Father. What has God done to earn ours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "We walked the rest of the way in uncomfortable silence un..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Vina Toras: ""So you do feel lucky to have me. You've got an interesti..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Vina Toras: ""You were never in danger of losing me, Father. I can tak..."*)

### Węzeł `[527]`
Mówca: **Vina Toras**
> ""You were never in danger of losing me, Father. I can take care of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "It wasn't long before we reached her mother's tomb. Vina ..."*)

### Węzeł `[528]`
Mówca: **Narrator**
> "Tears filled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Vina Toras: ""No... no, you're right. It won't.""*)

### Węzeł `[529]`
Mówca: **Narrator**
> "Her eyes brimmed with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Vina Toras: ""I know. But I still can't help but feel that letting it ..."*)

### Węzeł `[530]`
Mówca: **Vina Toras**
> ""I know. But I still can't help but feel that letting it go would mean letting her down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "It wasn't long before we reached her mother's tomb. Vina ..."*)

### Węzeł `[531]`
Mówca: **Estela Toras**
> ""I'd say your time among the Palesians has done wonders for you. You've lost weight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Narrator: "Vina smiled patiently."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Vina Toras: ""If I did, it was by accident. I ate very well over there..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Vina Toras: ""If I did, it was by accident. I ate very well over there.""*)

### Węzeł `[535]`
Mówca: **Narrator**
> "Vina smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[536]`
Mówca: **Vina Toras**
> ""If I did, it was by accident. I ate very well over there, even after the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[537]`
Mówca: **Vina Toras**
> ""If I did, it was by accident. I ate very well over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[538]`
Mówca: **Estela Toras**
> ""Candlelit dinners with His Grace? Do tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.VinaManus_Together == true)"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.VinaManus_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Vina Toras: ""Grandmother! I will remind you that I'm spoken for.""*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.VinaManus_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.VinaManus_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Vina Toras: ""Grandmother! Don't tell me you believed those rumors.""*)

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""Grandmother! Don't tell me you believed those rumors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Estela Toras: ""What rumors? All I know is that if I were alone with tha..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""I understand. He's quite busy now that he's majority spe..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player_Romus: ""I understand. His duties as a delegate must keep him qui..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. His duties as a delegate must keep him quite busy.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[159]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Estela Toras: ""Busy with what, dear? You know your father always called..."*)

### Węzeł `[547]`
Mówca: **Vina Toras**
> ""We'll catch up later. I'm meeting Manus for a walk before the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Estela Toras: ""Hm. He didn't feel like joining you here?""*)

### Węzeł `[548]`
Mówca: **Estela Toras**
> ""What rumors? All I know is that if I were alone with that man, an energy partnership wouldn't be the only deal sealed--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Estela Toras: "“You of all people know what an extraordinary woman she w..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Estela Toras: "“Neither did you, I suspect, or you'd be sobbing by her g..."*)

### Węzeł `[552]`
Mówca: **Estela Toras**
> "“Neither did you, I suspect, or you'd be sobbing by her graveside right now. She was an extraordinary woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""How do you know she was extraordinary? You two barely sp..."*)
  - -> `[22]` (*Player_Romus: "“What was extraordinary about her? She was just another e..."*)
  - -> `[43]` (*Player_Romus: ""I didn't know you felt that way about her.""*)
  - -> `[553]` (*Player_Romus: ""I liked her enough. We just never felt a spark.""*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I liked her enough. We just never felt a spark.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[552]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Estela Toras: ""Perhaps you resented your arranged marriage so much that..."*)

### Węzeł `[554]`
Mówca: **Estela Toras**
> ""Perhaps you resented your arranged marriage so much that you did not allow yourself to feel it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Estela Toras: ""For my part, I grew to love her dearly.""*)

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, I remember. You never met a noblewoman you didn't disparage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Estela Toras: ""I was insecure, darling. Even after my status was secure..."*)

### Węzeł `[556]`
Mówca: **Estela Toras**
> ""I was insecure, darling. Even after my status was secured, I never got over the feeling that I was an imposter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Estela Toras: ""Except around Her Highness. That was part of the reason ..."*)

### Węzeł `[557]`
Mówca: **Estela Toras**
> ""Except around Her Highness. That was part of the reason I loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[559]` (*Player_Romus: ""A shame you could never hold your tongue around her sist..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[558]`
Mówca: **Estela Toras**
> ""For my part, I grew to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[38]` (*Player_Romus: ""Love... now that's a word I rarely hear you say.""*)
  - -> `[559]` (*Player_Romus: ""A shame you could never hold your tongue around her sist..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame you could never hold your tongue around her sister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Estela Toras), `[217]` (Estela Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Estela Toras: ""Beatrice never had it easy. Shouldering the responsibili..."*)

### Węzeł `[560]`
Mówca: **Estela Toras**
> ""Beatrice never had it easy. Shouldering the responsibility of ruling Rumburg while her gorgeous younger sibling absorbed the limelight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Estela Toras: ""But if anyone deserved it, she did.""*)

### Węzeł `[561]`
Mówca: **Estela Toras**
> ""But if anyone deserved it, she did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "A fleeting smile hinted at a memory that briefly illumina..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Estela Toras: "“It was right after the civil war broke out in Wehlen.""*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Estela Toras: "“It was right after the civil war broke out in Wehlen.""*)

### Węzeł `[565]`
Mówca: **Estela Toras**
> "“It was right after the civil war broke out in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Estela Toras: ""You two were at Palas Rezna for dinner, and Lena and I a..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Player_Romus: ""What do you think she'd make of my decision to go to war..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situat..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Player_Romus: ""Lena's naivete overlooked the full implications of welco..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player_Romus: ""I had no idea. So many lives were saved, thanks to that ..."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena's naivete overlooked the full implications of welcoming all those foreigners.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Estela Toras: ""No. She thought about their humanity and the horrors the..."*)

### Węzeł `[573]`
Mówca: **Estela Toras**
> ""No. She thought about their humanity and the horrors they faced, at a time when few other nobles did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think she'd make of my decision to go to war with Pales?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Estela Toras: ""Good question. I suppose we'll never know.""*)

### Węzeł `[575]`
Mówca: **Estela Toras**
> ""Good question. I suppose we'll never know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Estela Toras: ""Remember that as we enter into war, Romus.""*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Estela Toras: ""A lesson we'd all do well to remember, Romus.""*)

### Węzeł `[579]`
Mówca: **Estela Toras**
> ""Remember that as we enter into war, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[580]`
Mówca: **Estela Toras**
> ""A lesson we'd all do well to remember, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Player_Romus: ""You've described her exactly. Whenever I make a royal de..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Lena and I never spoke about such weighty topics.""*)

### Węzeł `[584]`
Mówca: **Estela Toras**
> ""That's a shame. Who knows how many valuable insights were lost when that boat capsized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've described her exactly. Whenever I make a royal decision, I try to see the humane side of it. The way she would.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Estela Toras: ""Who knows what insights she would have to contribute if ..."*)

### Węzeł `[586]`
Mówca: **Estela Toras**
> ""Who knows what insights she would have to contribute if she were alive today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Estela Toras: ""Lena and I had much in common besides political opinions..."*)

### Węzeł `[587]`
Mówca: **Estela Toras**
> ""Lena and I had much in common besides political opinions, too. We both took a single ice cube in our red wine on hot days...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's exaggerating, Vina. She didn't know your mother at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Estela Toras: ""We conversed much more often than you realized. You were..."*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really, Mother? 'Like a daughter'? You never met a noblewoman you didn't disparage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Estela Toras: ""I was insecure, darling. Even after my status was secure..."*)

### Węzeł `[590]`
Mówca: **Estela Toras**
> ""I was insecure, darling. Even after my status was secured, I never got over the feeling that I was an imposter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Estela Toras: ""Except around Her Highness. That was part of the reason ..."*)

### Węzeł `[591]`
Mówca: **Estela Toras**
> ""Except around Her Highness. That was part of the reason I loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "She smiled in fond recollection."*)

### Węzeł `[592]`
Mówca: **Estela Toras**
> ""We conversed much more often than you realized. You were just too busy to notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Estela Toras: ""Believe me when I say that I did grow to love her.""*)

### Węzeł `[593]`
Mówca: **Estela Toras**
> ""Believe me when I say that I did grow to love her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "She smiled in fond recollection."*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no idea you felt that way about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Estela Toras: ""Come now. You know I'm not one for garish displays of em..."*)

### Węzeł `[595]`
Mówca: **Estela Toras**
> ""Come now. You know I'm not one for garish displays of emotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Estela Toras: ""But it's true. I did grow to love her dearly.""*)

### Węzeł `[596]`
Mówca: **Estela Toras**
> ""But it's true. I did grow to love her dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "She smiled in fond recollection."*)

### Węzeł `[597]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lena won over every person she met. Even prickly Queen Consorts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Estela Toras: ""Ha! I confess it took me a while to get over my prejudic..."*)

### Węzeł `[598]`
Mówca: **Estela Toras**
> ""Ha! I confess it took me a while to get over my prejudices about Rumburgian nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Estela Toras: ""But it's true. I did grow to love her dearly.""*)

### Węzeł `[599]`
Mówca: **Narrator**
> "She smiled in fond recollection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Estela Toras: ""I know she would've been proud of the person you've beco..."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC..."*)
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Relations_VinaManus_Approve == true || RiziaD..."*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together = true;"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaManus_Together = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.VinaManus_Together"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || Rizia..."*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your mother's passing was a part of life. It's important to find strength in the memories and support each other through these challenging times.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Vina Toras), `[189]` (Vina Toras), `[193]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Vina Toras: ""I'm not sure memories are enough to give me strength.""*)

### Węzeł `[605]`
Mówca: **Vina Toras**
> ""I'm not sure memories are enough to give me strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "We walked the rest of the way in uncomfortable silence un..."*)

### Węzeł `[606]`
Mówca: **Narrator**
> "Since she was taken, I'd endured many sleepless nights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "As I stood in contemplation, reflecting upon our time tog..."*)

### Węzeł `[607]`
Mówca: **Estela Toras**
> ""Yes, the Livingstons are as traditionalist as they come, but there's much we mothers are willing to overlook for the sake of our children's happiness--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Her eyes swept across the room, coming to rest on Lena's ..."*)

### Węzeł `[608]`
Mówca: **Estela Toras**
> ""You two were at Palas Rezna for dinner, and Lena and I absconded for tea after you and your father got into another one of your rows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Estela Toras: "“Up to that point, I was adamant that Rizia should accept..."*)

### Węzeł `[609]`
Mówca: **Estela Toras**
> ""You two were at Palas Rezna for dinner, and Lena and I absconded for tea after you and your father went off to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Estela Toras: "“Up to that point, I was adamant that Rizia should accept..."*)

### Węzeł `[610]`
Mówca: **Estela Toras**
> ""But as we discussed the situation, your wife made such a convincing case for empathy and kindness that I was literally moved to tears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Estela Toras: ""She had this way of seeing past politics, straight to th..."*)

### Węzeł `[611]`
Mówca: **Estela Toras**
> ""She had this way of seeing past politics, straight to the heart of the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Estela Toras: ""The next day, I persuaded Valero to open our borders.""*)

### Węzeł `[612]`
Mówca: **Narrator**
> "When I died, I would take my father's place beside the Eternal Flame, and he would be laid to rest among his forebears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Estela Toras: "“If you don’t mind, I’d like to say a few words to your f..."*)

### Węzeł `[613]`
Mówca: **Estela Toras**
> ""Through triumphs and tribulations, you were my confidante, my partner, my solace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Estela Toras: ""So, in this space between the living and the departed, I..."*)

### Węzeł `[614]`
Mówca: **Estela Toras**
> ""I loved you then, I love you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Estela Toras: ""Farewell, until we meet where love knows no bounds.""*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""Indeed. Recognizing the past's influence on the present ..."*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Player_Romus: ""Indeed. Recognizing the influence of the past on the pre..."*)

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Recognizing the influence of the past on the present is crucial.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[227]` (Estela Toras), `[230]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Estela Toras: ""I'm glad you agree.""*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""I appreciate your concern, but this time will be differe..."*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Player_Romus: ""I appreciate your concern, but this time will be differe..."*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, but this time will be different.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Estela Toras: ""Your attention should be on the rightful restoration of ..."*)

### Węzeł `[623]`
Mówca: **Estela Toras**
> ""Relying solely on divine intervention is misguided. Speaking of which, your attention should be on the rightful restoration of Zille, not Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Estela Toras: ""The very foundation of the monarchy is being put at risk..."*)

### Węzeł `[624]`
Mówca: **Estela Toras**
> ""Or so the rumors say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since we're being honest with one another... Know that Father's legacy and opinions of me are of no concern. But I'm determined to correct his mistakes by achieving what he couldn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""Very well. I trust you know what's best. I'll pray for y..."*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_HeljilandRecognized");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_HeljilandRecognized");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == true"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_HeljilandRecognized");"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == true"*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == true"*)
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == true)"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_AgnoliaAlliance");"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_AgnoliaAlliance");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || Rizia..."*)
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || Riz..."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = t..."*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_NoDeal == true || RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] == true  or  Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_VinaCalledBack"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[638]`
Mówca: **Estela Toras**
> ""Your father declaring war must have been quite the appetite suppressant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Vina Toras: ""Now, Grandmother. The cause was just.""*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Estela Toras: ""Your father declaring war must have been quite the appet..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Estela Toras: ""Candlelit dinners with His Grace? Do tell me more.""*)

### Węzeł `[642]`
Mówca: **Vina Toras**
> ""Now, Grandmother. The cause was just.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Vina Toras: ""It must have been.""*)

### Węzeł `[643]`
Mówca: **Vina Toras**
> ""It must have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Narrator: "I saw her lip tremble slightly. Mother squeezed her shoul..."*)

### Węzeł `[644]`
Mówca: **Narrator**
> "I saw her lip tremble slightly. Mother squeezed her shoulder in silent support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaManus_Together == true"*)

### Węzeł `[645]`
Mówca: **Narrator**
> "Soon, I found her sarcophagus, encased in gold as per tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Adjacent to it stood a bouquet of recently placed flowers..."*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Estela Toras: ""Look at how you handled yourself in Pales. The perfect e..."*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "Despite Vina's attempts to conceal her emotions, the subt..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Player_Romus: ""You're making a fuss over nothing, Mother. A true diplom..."*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Player_Romus: ""You're making a fuss over nothing, Mother. The Duke and ..."*)

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're making a fuss over nothing, Mother. The Duke and I had the deal clinched. Vina's involvement was merely ornamental.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[664]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Narrator: "Vina's lip trembled. I saw outrage in her eyes."*)

### Węzeł `[653]`
Mówca: **Estela Toras**
> ""If anyone deserves to settle down with a nice husband, it's her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Narrator: "She looked at me pointedly."*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Estela Toras: ""If anyone deserves to settle down with a nice husband, i..."*)

### Węzeł `[655]`
Mówca: **Narrator**
> "She looked at me pointedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Player_Romus: ""I couldn't agree more. However, it seems this kingdom la..."*)
  - -> `[694]` (*Player_Romus: ""Vina is free to marry whomever she chooses. You, of all ..."*)
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)
  - -> `[705]` (*Player_Romus: ""I keep coming back to the same answer. The only way to e..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaD..."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Player_Romus: ""I agree. Unfortunately, I suspect she still has her hear..."*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Estela Toras: ""I know you have approved of Manus and Vina, and I suppor..."*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Estela Toras: ""It's about time we consider wedding bells for Vina if we..."*)

### Węzeł `[662]`
Mówca: **Estela Toras**
> ""I know she would've been proud of the person you've become, Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[663]`
Mówca: **Estela Toras**
> ""I know you have approved of Manus and Vina, and I support passion, but it might not be as digestible for the rest of the house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Estela Toras: ""Either way, our girl needs to tie the knot sooner rather..."*)

### Węzeł `[664]`
Mówca: **Estela Toras**
> ""Look at how you handled yourself in Pales. The perfect example of royal grace and dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Player_Romus: ""That's very kind of you, Mother. Vina indeed handled her..."*)
  - -> `[665]` (*Player_Romus: ""Yes, she has indeed shown remarkable strength and resili..."*)
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, she has indeed shown remarkable strength and resilience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[664]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "Despite Vina's attempts to conceal her emotions, the subt..."*)

### Węzeł `[666]`
Mówca: **Estela Toras**
> ""Poor dear... she's been through so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProsp..."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true )"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Estela Toras: ""Poor dear... she's been through so much.""*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Estela Toras: ""Losing a parent is hard, especially when they love you a..."*)

### Węzeł `[670]`
Mówca: **Estela Toras**
> "“But I'm getting sidetracked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Narrator: "Her gaze once again landed on Lena's resting place."*)

### Węzeł `[671]`
Mówca: **Estela Toras**
> ""A bit harsh, wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Player_Romus: ""You're right. I didn't need to react that way. I will sp..."*)
  - -> `[677]` (*Player_Romus: ""She'll be fine. Don't worry about her.""*)
  - -> `[678]` (*Player_Romus: ""I'll parent my way, and you parent yours.""*)
  - -> `[675]` (*Player_Romus: ""No, not at all.""*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true"*)
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == tr..."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Estela Toras: ""A bit harsh, wouldn't you say?""*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, not at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[671]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Estela Toras: ""Well, it was. Unless your goal is to get her to resent y..."*)

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I didn't need to react that way. I will speak to her about it later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[671]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Estela Toras: ""Good. This family has enough problems as it is. No need ..."*)

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She'll be fine. Don't worry about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[671]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Estela Toras: ""I'm her grandmother. It's my job to worry, as should you.""*)

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll parent my way, and you parent yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[671]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Estela Toras: ""I wouldn't call that parenting. I'd call it imposing you..."*)

### Węzeł `[679]`
Mówca: **Estela Toras**
> ""I wouldn't call that parenting. I'd call it imposing your will without considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[680]`
Mówca: **Estela Toras**
> ""Well, it was. Unless your goal is to get her to resent you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Player_Romus: ""What's done is done. I'm sure she'll forget all about it..."*)
  - -> `[693]` (*Player_Romus: ""Watch your tone. I am your king.""*)
  - -> `[681]` (*Player_Romus: ""Yes, that's *exactly* what I want to do. What better way..."*)

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that's *exactly* what I want to do. What better way to forge better family ties than to encourage resentment?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Estela Toras: ""Sarcasm doesn't suit you. It's beneath the dignity expec..."*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're making a fuss over nothing, Mother. A true diplomat wouldn't have caused an international incident like Vina did.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[664]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Narrator: "Vina's lip trembled. I saw outrage in her eyes."*)

### Węzeł `[683]`
Mówca: **Narrator**
> "Despite Vina's attempts to conceal her emotions, the subtle quiver in her lips and a deep sigh betrayed her inner turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Vina Toras: ""Please excuse me.""*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1;
RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Vina Toras: ""Please excuse me.""*)

### Węzeł `[685]`
Mówca: **Vina Toras**
> ""Please excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[686]`
Mówca: **Narrator**
> "Vina hurried out of the room before anyone could respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Cemetary_RomusHarshOnVina == true"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Narrator: "Vina hurried out of the room before anyone could respond."*)

### Węzeł `[688]`
Mówca: **Narrator**
> "Even as Vina tried to conceal her feelings, a subtle tremor in her lips and a heavy sigh betrayed her inner turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Vina Toras: ""Please excuse me.""*)

### Węzeł `[689]`
Mówca: **Estela Toras**
> ""I'm her grandmother. It's my job to worry, as should you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very kind of you, Mother. Vina indeed handled herself like a true princess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[664]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Narrator: "Even as Vina tried to conceal her feelings, a subtle trem..."*)

### Węzeł `[691]`
Mówca: **Narrator**
> "Vina's lip trembled. I saw outrage in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1; RiziaDLCIsolated.Turn06_Cem..."*)

### Węzeł `[692]`
Mówca: **Estela Toras**
> ""Sarcasm doesn't suit you. It's beneath the dignity expected of a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your tone. I am your king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Estela Toras: ""And I am your mother. If anybody's tone needs watching, ..."*)

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is free to marry whomever she chooses. You, of all people, should understand the importance of love and following one's heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Narrator), `[712]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Estela Toras: ""I don't need a lecture on the importance of love and fre..."*)

### Węzeł `[695]`
Mówca: **Estela Toras**
> ""Good. This family has enough problems as it is. No need to create more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[696]`
Mówca: **Estela Toras**
> ""And I am your mother. If anybody's tone needs watching, it's yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[697]`
Mówca: **Estela Toras**
> ""I wouldn't be so sure of that. Grudges have a funny way of never going away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. I'm sure she'll forget all about it and forgive me in no time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Estela Toras: ""I wouldn't be so sure of that. Grudges have a funny way ..."*)

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Unfortunately, I suspect she still has her heart set on Manus.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Kontekst wejściowy (poprzednik):** `[655]` (Narrator), `[712]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Estela Toras: ""Love has its own stubborn ways, and letting go can be an..."*)

### Węzeł `[700]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't agree more. However, it seems this kingdom lacks suitable men of good stature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Narrator), `[712]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[701]`
Mówca: **Estela Toras**
> ""I don't need a lecture on the importance of love and freedom, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Estela Toras: ""Either way, our girl needs to tie the knot sooner rather..."*)

### Węzeł `[702]`
Mówca: **Estela Toras**
> ""Either way, our girl needs to tie the knot sooner rather than later for our family to secure its place on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Estela Toras: "“But I'm getting sidetracked.""*)

### Węzeł `[703]`
Mówca: **Estela Toras**
> ""Then maybe you should start looking outside the kingdom. To Pales, perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Estela Toras: "“But I'm getting sidetracked.""*)

### Węzeł `[704]`
Mówca: **Estela Toras**
> ""Then perhaps you should start looking outside the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Estela Toras: "“But I'm getting sidetracked.""*)

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I keep coming back to the same answer. The only way to ensure our stability is to marry her off within House Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Narrator), `[712]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Estela Toras: ""That trigger should be pulled only out of desperation, d..."*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true )"*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Estela Toras: ""Then perhaps you should start looking outside the kingdom.""*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Estela Toras: ""Then maybe you should start looking outside the kingdom...."*)

### Węzeł `[709]`
Mówca: **Estela Toras**
> ""Love has its own stubborn ways, and letting go can be an arduous task. Yet, duty often requires sacrifice -- the Princess should know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Estela Toras: "“But I'm getting sidetracked.""*)

### Węzeł `[710]`
Mówca: **Estela Toras**
> ""That trigger should be pulled only out of desperation, dear. I don't think we're there yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Estela Toras: "“But I'm getting sidetracked.""*)

### Węzeł `[711]`
Mówca: **Estela Toras**
> ""Losing a parent is hard, especially when they love you as much as Vina's mother loved her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProsp..."*)

### Węzeł `[712]`
Mówca: **Estela Toras**
> ""It's about time we consider wedding bells for Vina if we want to ensure the continuation of our lineage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Player_Romus: ""I couldn't agree more. However, it seems this kingdom la..."*)
  - -> `[694]` (*Player_Romus: ""Vina is free to marry whomever she chooses. You, of all ..."*)
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)
  - -> `[705]` (*Player_Romus: ""I keep coming back to the same answer. The only way to e..."*)

### Węzeł `[713]`
Mówca: **Estela Toras**
> ""In any case, I'm pleased that Vina's looking well, all things considered. She's been through so much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProsp..."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true )"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Estela Toras: ""In any case, I'm pleased that Vina's looking well, all t..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Estela Toras: ""Losing a parent is hard, especially when they love you a..."*)

### Węzeł `[717]`
Mówca: **Estela Toras**
> ""Speaking of love...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_Cemetary_VinaMarriageProspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Estela Toras: ""Speaking of love...""*)

### Węzeł `[719]`
Mówca: **Narrator**
> "Her gaze once again landed on Lena's resting place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: "“I remember the exact moment my feelings toward Princess ..."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Narrator: "As she spoke, a memory suddenly came to me."*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Estela Toras: ""But let's get to the reason why I'm here.""*)

### Węzeł `[723]`
Mówca: **Narrator**
> "As she spoke, a memory suddenly came to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Narrator: "Lena had just completed the Rite of Severance, the ceremo..."*)

### Węzeł `[724]`
Mówca: **Estela Toras**
> ""But let's get to the reason why I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "Father Love Letter"*)

### Węzeł `[725]`
Mówca: **Narrator**
> "Lena had just completed the Rite of Severance, the ceremony converting her to Wruhecism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Narrator: "After she'd burned the last of the eleven slips of parchm..."*)

### Węzeł `[726]`
Mówca: **Narrator**
> "After she'd burned the last of the eleven slips of parchment representing her connection to Dastnurity, my mother was the first to approach and embrace her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Narrator: "I hadn't thought much about it at the time. But knowing w..."*)

### Węzeł `[727]`
Mówca: **Narrator**
> "I hadn't thought much about it at the time. But knowing what I did now..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Player_Romus: ""Did my wife know you were a Dastnurist?""*)
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[733]` (*Player_Romus: ""There's something I need to bring up with you. Have you ..."*)
  - -> `[734]` (*Player_Romus: ""Please, enough about Lena. This is already a very emotio..."*)

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did my wife know you were a Dastnurist?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Narrator: "My mother went pale as a sheet."*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Player_Romus: ""Wine? No, what you two shared was an attachment to your ..."*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wine? No, what you two shared was an attachment to your heathen faith.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[727]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Narrator: "My mother went pale as a sheet."*)

### Węzeł `[733]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's something I need to bring up with you. Have you secretly been practicing Dastnurity?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Narrator: "My mother went pale as a sheet."*)

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, enough about Lena. This is already a very emotional day for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Estela Toras: ""Emotional, Romus? You haven't seen anything yet.""*)

### Węzeł `[735]`
Mówca: **Narrator**
> "My mother went pale as a sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Estela Toras: "“I don’t know what you’re talking about.”"*)

### Węzeł `[736]`
Mówca: **Estela Toras**
> ""Emotional, Romus? You haven't seen anything yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "Father Love Letter"*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Player_Romus: ""Isn't the allure of gossip beneath someone of your age a..."*)
  - -> `[466]` (*Player_Romus: ""Whispers and rumors... they hold no more substance than ..."*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[738]`
Mówca: **Estela Toras**
> "“I don’t know what you’re talking about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Player_Romus: ""Well, that's a relief. I guess I can close the case on t..."*)
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigate..."*)
  - -> `[739]` (*Player_Romus: ""Please. I'm not judging you. I just want you to be hones..."*)

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. I'm not judging you. I just want you to be honest with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[740]`
Mówca: **Estela Toras**
> "“It’s called faith for a reason. It's not something you casually discard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Player_Romus: ""It is if you want to be part of the Rizian Royal Family...."*)
  - -> `[764]` (*Player_Romus: ""Was your whole family Dastnurist? How could you have kep..."*)
  - -> `[794]` (*Player_Romus: ""I can't believe Lena never told me.""*)
  - -> `[765]` (*Player_Romus: ""I understand. But I wish I hadn't found out this way. Yo..."*)

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't lie to me! Do you take me for a fool? I know all about it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus told me where you where the night Father died.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Estela Toras: ""You had me investigated? Your own mother?!""*)

### Węzeł `[743]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Mother. I know all about it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Player_Romus: ""Don't lie to me! Do you take me for a fool? I know all a..."*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Player_Romus: ""Come on, Mother. I know all about it.""*)

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's a relief. I guess I can close the case on that one. What was I thinking?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Estela Toras: ""Don't take that tone with me! You may be king, but I'm s..."*)

### Węzeł `[748]`
Mówca: **Estela Toras**
> ""You had me investigated? Your own mother?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[749]`
Mówca: **Estela Toras**
> ""Don't take that tone with me! You may be king, but I'm still your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[750]`
Mówca: **Narrator**
> "Mother stood firm, her gaze unfaltering. Yet, it took only a short while before she yielded, heaving a sigh of resignation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Estela Toras: "“It’s called faith for a reason. It's not something you c..."*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigate..."*)
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestiga..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Player_Romus: ""Lucita told me where you where the night Father died.""*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone == true || RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Player_Romus: ""Titus told me where you where the night Father died.""*)

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita told me where you where the night Father died.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] == true  or  Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] == true`
- **Kontekst wejściowy (poprzednik):** `[738]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[756]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Estela Toras: ""Oh, I highly doubt you're not judging me, son.""*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[758]`
Mówca: **Estela Toras**
> ""Oh, I highly doubt you're not judging me, son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[759]`
Mówca: **Estela Toras**
> ""The same Lucita who's in jail for crimes against the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Narrator: "Mother stood firm, her gaze unfaltering. Yet, it took onl..."*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Estela Toras: ""The same Lucita who's in jail for crimes against the sta..."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Estela Toras: ""You had me investigated? Your own mother?!""*)

### Węzeł `[763]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is if you want to be part of the Rizian Royal Family. Why couldn't you have made the same sacrifice Lena did?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Estela Toras: ""Sacrifice and compromise are values drilled into princes..."*)

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was your whole family Dastnurist? How could you have kept this a secret for so long?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Estela Toras: ""Only my grandmother, God rest her soul.""*)

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. But I wish I hadn't found out this way. You should have trusted me enough to tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Estela Toras), `[774]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Estela Toras: ""I'm sorry I felt compelled to hide it all these years. B..."*)

### Węzeł `[766]`
Mówca: **Estela Toras**
> ""I'm sorry I felt compelled to hide it all these years. But I did it to protect you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Estela Toras: ""Marrying your father was enough of a scandal. Can you im..."*)

### Węzeł `[767]`
Mówca: **Estela Toras**
> ""Marrying your father was enough of a scandal. Can you imagine the uproar my religion would've caused on top of that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Estela Toras: ""My intention was to shield you from danger, even if it m..."*)

### Węzeł `[768]`
Mówca: **Estela Toras**
> ""My intention was to shield you from danger, even if it meant keeping a part of myself hidden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Estela Toras: ""But as king, and more importantly, as my son, you had a ..."*)

### Węzeł `[769]`
Mówca: **Estela Toras**
> ""But as king, and more importantly, as my son, you had a right to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[793]` (*Player_Romus: ""Now that your secret's out, I implore you to convert to ..."*)
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)
  - -> `[792]` (*Player_Romus: ""Thank you for your honesty. And don't worry. Nobody else..."*)

### Węzeł `[770]`
Mówca: **Estela Toras**
> ""Sacrifice and compromise are values drilled into princesses, my dear. Not fisherman's daughters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Estela Toras: ""My late grandmother used to take me to the Dastnurist sa..."*)

### Węzeł `[771]`
Mówca: **Estela Toras**
> ""Only my grandmother, God rest her soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Estela Toras: ""She used to take me to Dastnurist services behind my par..."*)

### Węzeł `[772]`
Mówca: **Estela Toras**
> ""She used to take me to Dastnurist services behind my parents' back. I kept up the habit after she died -- not regularly, but whenever I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Estela Toras: ""To turn my back on Dastnurity would be to betray her mem..."*)

### Węzeł `[773]`
Mówca: **Estela Toras**
> ""My late grandmother used to take me to the Dastnurist sanctuary in Zille behind my parents' back. Our little secret, she called it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Estela Toras: ""To turn my back on Dastnurity would be to betray her mem..."*)

### Węzeł `[774]`
Mówca: **Estela Toras**
> ""To turn my back on Dastnurity would be to betray her memory. Or that's what it feels like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Player_Romus: ""To hell with your grandma's memory. What about betraying..."*)
  - -> `[782]` (*Player_Romus: ""If she was alive when you were crowned Princess Consort,..."*)
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[765]` (*Player_Romus: ""I understand. But I wish I hadn't found out this way. Yo..."*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religion_Leaning_Theocratic == true)"*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Player_Romus: ""Listen to me, Mother. You have to convert before it's to..."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religion_Leaning_Theocratic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[778]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to me, Mother. You have to convert before it's too late.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras), `[774]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Estela Toras: ""Too late?!""*)

### Węzeł `[779]`
Mówca: **Estela Toras**
> ""Too late?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Estela Toras: ""I'm an old lady, darling. And I'm more set in my ways th..."*)

### Węzeł `[780]`
Mówca: **Estela Toras**
> ""Can't you just keep this between us two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with your grandma's memory. What about betraying your son?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[774]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Estela Toras: ""I'm sorry I felt compelled to hide it all these years. B..."*)

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she was alive when you were crowned Princess Consort, she would have told you to convert.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[774]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Estela Toras: ""I'll never know, will I?""*)

### Węzeł `[783]`
Mówca: **Estela Toras**
> ""I'll never know, will I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Estela Toras: ""I'm sorry I felt compelled to hide it all these years. B..."*)

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where all branches of the Nurist faith are equally welcome.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Estela Toras: ""Oh, I know. And I'm grateful for it, believe me.""*)

### Węzeł `[785]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)"*)

### Węzeł `[786]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Player_Romus: ""You don't have to hide anymore. I am building a Rizia wh..."*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where no religion dominates over any other.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true` AND `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Estela Toras: ""Oh, I know. And I imagine Grand Wiseman Ignacius was jus..."*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Player_Romus: ""You don't have to hide anymore. I am building a Rizia wh..."*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true"*)

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your honesty. And don't worry. Nobody else has to know about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Narrator: "She put a hand to her chest and sighed in relief."*)

### Węzeł `[793]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that your secret's out, I implore you to convert to Wruhecism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Narrator: "She looked at me worriedly."*)

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe Lena never told me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[740]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue..."*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue..."*)
  - -> `[797]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prolog..."*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false  or  Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Estela Toras: ""You two were never exactly forthright with each other, w..."*)

### Węzeł `[797]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == false || RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false  or  Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Estela Toras: ""She wanted to. I swore her to secrecy, the poor dear.""*)

### Węzeł `[798]`
Mówca: **Estela Toras**
> ""You two were never exactly forthright with each other, were you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Estela Toras: ""I'm sorry I felt compelled to hide it all these years. B..."*)

### Węzeł `[799]`
Mówca: **Estela Toras**
> ""She wanted to. I swore her to secrecy, the poor dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Estela Toras: ""I'm sorry I felt compelled to hide it all these years. B..."*)

### Węzeł `[800]`
Mówca: **Estela Toras**
> ""I'm an old lady, darling. And I'm more set in my ways than an eel in aspic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Estela Toras: ""Can't you just keep this between us two?""*)

### Węzeł `[801]`
Mówca: **Estela Toras**
> ""Oh, I know. And I'm grateful for it, believe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Estela Toras: ""But tradition is tradition, and I've already caused enou..."*)

### Węzeł `[802]`
Mówca: **Estela Toras**
> ""Oh, I know. And I imagine Grand Wiseman Ignacius was just thrilled with that little decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Estela Toras: ""But tradition is tradition, and I've already caused enou..."*)

### Węzeł `[803]`
Mówca: **Estela Toras**
> ""But tradition is tradition, and I've already caused enough fusses to last a lifetime. So I'd prefer this little revelation stay between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)

### Węzeł `[804]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[805]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Narrator: "Her eyes flicked towards the mausoleum entrance, where th..."*)

### Węzeł `[806]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[807]`
Mówca: **Narrator**
> "Her eyes flicked towards the mausoleum entrance, where the Golden Guard stood watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Estela Toras: ""And Captain Muscles out there.""*)

### Węzeł `[808]`
Mówca: **Estela Toras**
> ""And Captain Muscles out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Player_Romus: ""Very well, I won't tell anyone. But it goes without sayi..."*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[811]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Estela Toras: ""After all, the only other person who knows can't go blab..."*)

### Węzeł `[811]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Estela Toras: ""And your lovely falcon of a war councilor, I suppose.""*)

### Węzeł `[812]`
Mówca: **Estela Toras**
> ""After all, the only other person who knows can't go blabbing to anyone but the Citadel walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Player_Romus: ""Very well, I won't tell anyone. But it goes without sayi..."*)

### Węzeł `[813]`
Mówca: **Estela Toras**
> ""And your lovely falcon of a war councilor, I suppose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Player_Romus: ""Very well, I won't tell anyone. But it goes without sayi..."*)

### Węzeł `[814]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Estela Toras: ""After all, the only other person who knows can't go blab..."*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[817]`
Mówca: **Estela Toras**
> ""After all, the only other person who knows can't go blabbing to anyone but the Citadel walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[818]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, I won't tell anyone. But it goes without saying that you've shattered my trust.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[808]` (Estela Toras), `[812]` (Estela Toras), `[813]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Estela Toras: ""Well, when you manage to put it back together again, let..."*)

### Węzeł `[819]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't force you to convert. But for your own sake, please be more careful in concealing your faith.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[817]` (Estela Toras), `[780]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Estela Toras: ""I was doing just fine before you brought a security team..."*)

### Węzeł `[820]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your secret is safe. But I do pray that in due time, you'll see the error of your ways and return to the one true faith.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[817]` (Estela Toras), `[780]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Estela Toras: ""Pray away, my son. This soul's already a lost cause, any..."*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Player_Romus: ""Your secret is safe. But I do pray that in due time, you..."*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Player_Romus: ""I won't force you to convert. But for your own sake, ple..."*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[841]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[835]` (*Player_Romus: ""Please, Mother. If you love me, you'll do this for me.""*)
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[818]` (*Player_Romus: ""Very well, I won't tell anyone. But it goes without sayi..."*)

### Węzeł `[825]`
Mówca: **Narrator**
> "She looked at me worriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Estela Toras: ""I'm an old lady, darling. And I'm more set in my ways th..."*)

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. I am building a Rizia where Dastnurity can flourish, regardless of our state religion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true` AND `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Estela Toras: ""Oh, I know. And I'm grateful for it, believe me.""*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true"*)
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_DastnuristCommunity_Happy == t..."*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Player_Romus: ""You don't have to hide anymore. I am building a Rizia wh..."*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_DastnuristCommunity_Happy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Player_Romus: ""You don't have to hide anymore. Actually, revealing your..."*)

### Węzeł `[830]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to hide anymore. Actually, revealing your religion might boost my popularity with the Dastnurist community.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[769]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Narrator: "She hurriedly shook her head."*)

### Węzeł `[831]`
Mówca: **Narrator**
> "She hurriedly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Estela Toras: ""Tradition is tradition, and I've already caused enough f..."*)

### Węzeł `[832]`
Mówca: **Estela Toras**
> ""Tradition is tradition, and I've already caused enough fusses to last a lifetime. So I'd prefer this little revelation stay between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)

### Węzeł `[833]`
Mówca: **Narrator**
> "She put a hand to her chest and sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Estela Toras: ""I appreciate it, Romus. I really do.""*)

### Węzeł `[834]`
Mówca: **Estela Toras**
> ""I appreciate it, Romus. I really do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Estela Toras: ""Now, as for the reason I'm here.""*)

### Węzeł `[835]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Mother. If you love me, you'll do this for me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[817]` (Estela Toras), `[780]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Estela Toras: ""My son over my faith... it's an impossible choice, Romus.""*)

### Węzeł `[836]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am building a new Rizia. One in which the Wruhecist faith triumphs over all others. Everyone must see the light, the Queen Mother included.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true` AND `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[817]` (Estela Toras), `[780]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Estela Toras: ""Oh, dear.""*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religion_Leaning_Theocratic == true"*)
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religion_Leaning_Theocratic == true)"*)

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religion_Leaning_Theocratic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Player_Romus: ""I am building a new Rizia. One in which the Wruhecist fa..."*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religion_Leaning_Theocratic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[840]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More people know your secret than just us two. It's only a matter of time before it's made public.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Arrested"] == false` AND `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[817]` (Estela Toras), `[780]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Estela Toras: ""My dear, if you don't trust your investigators to keep a..."*)

### Węzeł `[841]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false"*)
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false)"*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Player_Romus: ""More people know your secret than just us two. It's only..."*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[844]`
Mówca: **Estela Toras**
> ""My dear, if you don't trust your investigators to keep a secret, you shouldn't have trusted them with an investigation in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Estela Toras: ""But never mind that. If it's really so important to you,..."*)

### Węzeł `[845]`
Mówca: **Estela Toras**
> ""My son over my faith... it's an impossible choice, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Estela Toras: ""But if it's really so important to you, I'll do it.""*)

### Węzeł `[846]`
Mówca: **Estela Toras**
> ""Oh, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Narrator: "She twisted a ring on one of her fingers."*)

### Węzeł `[847]`
Mówca: **Narrator**
> "She twisted a ring on one of her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Estela Toras: ""I presume you haven't told the Rumburgians about these p..."*)

### Węzeł `[848]`
Mówca: **Estela Toras**
> ""I presume you haven't told the Rumburgians about these plans yet...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Estela Toras: ""But never mind that. If it's really so important to you,..."*)

### Węzeł `[849]`
Mówca: **Estela Toras**
> ""But never mind that. If it's really so important to you, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Player_Romus: ""Thank you, Mother. You won't regret it.""*)
  - -> `[862]` (*Player_Romus: ""You will? Really?""*)
  - -> `[859]` (*Player_Romus: ""Wait. I don't want to force you to become a Wruhecist fo..."*)

### Węzeł `[850]`
Mówca: **Estela Toras**
> ""Well, when you manage to put it back together again, let me know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Narrator: "She recomposed herself and made an effort to smile."*)

### Węzeł `[851]`
Mówca: **Estela Toras**
> ""I was doing just fine before you brought a security team into it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Narrator: "She recomposed herself and made an effort to smile."*)

### Węzeł `[852]`
Mówca: **Estela Toras**
> ""Pray away, my son. This soul's already a lost cause, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Narrator: "She recomposed herself and made an effort to smile."*)

### Węzeł `[853]`
Mówca: **Estela Toras**
> ""Now, as for the reason I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Węzeł Logiki Narracyjnej: "Jump to: [Father Love Letter]"*)

### Węzeł `[854]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Father Love Letter`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "My mother reached into her handbag and held up a weathere..."*)

### Węzeł `[855]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Father Love Letter]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "Father Love Letter"*)

### Węzeł `[856]`
Mówca: **Estela Toras**
> ""But if it's really so important to you, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Player_Romus: ""Thank you, Mother. You won't regret it.""*)
  - -> `[862]` (*Player_Romus: ""You will? Really?""*)
  - -> `[859]` (*Player_Romus: ""Wait. I don't want to force you to become a Wruhecist fo..."*)

### Węzeł `[857]`
Mówca: **Narrator**
> "She recomposed herself and made an effort to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Estela Toras: ""Now, as for the reason I'm here.""*)

### Węzeł `[858]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mother. You won't regret it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[849]` (Estela Toras), `[856]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]` (*Estela Toras: ""Next chance I get, I'll march down to Zilba and have one..."*)

### Węzeł `[859]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I don't want to force you to become a Wruhecist for my sake. I only hope you'll come to the decision on your own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[849]` (Estela Toras), `[856]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Narrator: "She put a hand to her chest and sighed in relief."*)

### Węzeł `[860]`
Mówca: **Narrator**
> "She put a hand to her chest and sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Estela Toras: ""Maybe I will. Someday.""*)

### Węzeł `[861]`
Mówca: **Estela Toras**
> ""Maybe I will. Someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Estela Toras: ""Now, as for the reason I'm here.""*)

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will? Really?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[849]` (Estela Toras), `[856]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]` (*Estela Toras: ""Next chance I get, I'll march down to Zilba and have one..."*)

### Węzeł `[863]`
Mówca: **Estela Toras**
> ""Next chance I get, I'll march down to Zilba and have one of the Wisemen there make a believer out of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Estela Toras: ""Covertly, of course.""*)

### Węzeł `[864]`
Mówca: **Estela Toras**
> ""Covertly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Estela_PromisedToConvert = true"*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Estela_PromisedToConvert = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Estela_PromisedToConvert"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Narrator: "She recomposed herself and made an effort to smile."*)

### Węzeł `[866]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Let's leave it at that. I'm not in the mood for conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "Jump to: [Finale_Hub]"*)

### Węzeł `[867]`
Mówca: **Narrator**
> "She stepped towards my father's resting place and spoke to him in a hushed whisper, prolonging the conversation far longer than I anticipated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "When she finally concluded, she retrieved the love letter..."*)

### Węzeł `[868]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Finale_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "Finale_Hub"*)

### Węzeł `[869]`
Mówca: **Narrator**
> "She kissed me on the cheek and patted my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]` (*Estela Toras: ""Take all the time you need.""*)

### Węzeł `[870]`
Mówca: **Estela Toras**
> ""Take all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[871]`
Mówca: **Narrator**
> "Mother went on ahead of me while I remained behind to have a final moment with Father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[872]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Narrator: "Mother went on ahead of me while I remained behind to hav..."*)

### Węzeł `[873]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)
  - -> `[875]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DadLetter_ThrowAway == false && Rizia..."*)

### Węzeł `[874]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Narrator: "Once alone, I reached into my inner jacket pocket and too..."*)

### Węzeł `[875]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == true"*)

### Węzeł `[876]`
Mówca: **Narrator**
> "Once alone, I reached into my inner jacket pocket and took out an envelope -- the last letter my father ever wrote to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]` (*Narrator: ""Find your own way, my son, and let your journey be yours..."*)

### Węzeł `[877]`
Mówca: **Narrator**
> ""Find your own way, my son, and let your journey be yours alone — not a reflection of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Narrator: "His final words."*)

### Węzeł `[878]`
Mówca: **Narrator**
> "His final words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[879]`
**[WYBÓR GRACZA: "Place the letter into the fire."]** — Mówca: **Player_Romus_Italic**
> "Having held onto it long enough, I fed the letter to the flames and watched it burn until nothing was left."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Kontekst wejściowy (poprzednik):** `[889]` (Player_Romus), `[903]` (Player_Romus), `[904]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_DadLetterBurn = true;"*)

### Węzeł `[880]`
**[WYBÓR GRACZA: "Keep the letter."]** — Mówca: **Player_Romus_Italic**
> "I considered consigning the letter to the flames as my mother did, but in the end, I decided to hold onto it for safekeeping."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Kontekst wejściowy (poprzednik):** `[889]` (Player_Romus), `[903]` (Player_Romus), `[904]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_DadLetterBurn = false;"*)

### Węzeł `[881]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_DadLetterBurn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Narrator: "I departed soon after, leaving my father to his solitude."*)

### Węzeł `[882]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_DadLetterBurn = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_DadLetterBurn"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Narrator: "I departed soon after, leaving my father to his solitude."*)

### Węzeł `[883]`
Mówca: **Narrator**
> "I departed soon after, leaving my father to his solitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[884]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == true"*)
  - -> `[886]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DadLetter_ThrowAway == true)"*)

### Węzeł `[885]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Narrator: "I struggled to remember his face or the last words he spo..."*)

### Węzeł `[886]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DadLetter_ThrowAway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]` (*Narrator: "I remembered his last words to me as if he'd spoken them ..."*)

### Węzeł `[887]`
Mówca: **Narrator**
> "I struggled to remember his face or the last words he spoke to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[888]`
Mówca: **Narrator**
> "I remembered his last words to me as if he'd spoken them yesterday."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest in peace, old man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[890]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I will rectify your mistakes. I will reclaim Pales and become the greatest king Rizia has ever known.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;"*)

### Węzeł `[891]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do right by you, Father. I will rejuvenate this nation the way you always wanted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Estela Toras: ""May your endeavors to rejuvenate our nation bring about ..."*)

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag shall fly over Pales in your honor, Father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales = true;"*)

### Węzeł `[893]`
Mówca: **Estela Toras**
> ""May your endeavors to rejuvenate our nation bring about the greatness he envisioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;"*)

### Węzeł `[894]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[896]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[895]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Player_Romus: ""I vow that I will rectify your mistakes. I will reclaim ..."*)
  - -> `[892]` (*Player_Romus: ""The Rizian flag shall fly over Pales in your honor, Fath..."*)

### Węzeł `[896]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]` (*Player_Romus: ""I vow that I will rectify your mistakes. I will take bac..."*)

### Węzeł `[897]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadLegacy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadLegacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[898]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[899]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[900]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't give a damn about your legacy or what you thought about me. I have my own path to walk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;"*)

### Węzeł `[901]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_WalkOwnPath = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_Cemetary_WalkOwnPath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[902]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]` (*Player_Romus: ""I don't give a damn about your legacy or what you though..."*)
  - -> `[894]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[891]` (*Player_Romus: ""I will do right by you, Father. I will rejuvenate this n..."*)
  - -> `[889]` (*Player_Romus: ""Rest in peace, old man.""*)
  - -> `[904]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[903]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I will rectify your mistakes. I will take back Zille and become the greatest king Rizia has ever known.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[904]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I stood there in silence for a long moment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[878]` (Narrator), `[887]` (Narrator), `[888]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)

### Węzeł `[905]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[906]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDL..."*)
  - -> `[907]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DadLetter_ThrowAway == false && Rizia..."*)

### Węzeł `[906]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]` (*Player_Romus_Italic: "Place the letter into the fire."*)
  - -> `[880]` (*Player_Romus_Italic: "Keep the letter."*)

### Węzeł `[907]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DadLetter_ThrowAway == false && RiziaDLC.Prologue_DadLetter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] == false  and  Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Narrator: "I departed soon after, leaving my father to his solitude."*)

### Węzeł `[908]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Attending the Sovereign Memorial Commemoration", "Mausoleum", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Attending the Sovereign Memorial Commemoration","Mausoleum","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC..."*)
