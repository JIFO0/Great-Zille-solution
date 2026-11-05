# Rizia/Turn 9/Hegel Side Convo

- **ID konwersacji:** `451`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/451_Hegel_Side_Convo.md`
- **Liczba węzłów dialogowych:** 268
- **Liczba wyborów gracza:** 50

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[78]** Emmerich Hegel (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Valgsland_Alliance`
- `RiziaDLC.CountryRelation_Valgsland_Unfriendly`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Hegel_OpenToRevolution`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.MITZ_LespiaScrewedOverRizia`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Morella_Sabotage_Plans_Discovered`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad`
- `RiziaDLC.ToldAboutComradeVina`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Valgsland_NegotiatingPower`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP`
- `RiziaDLC.Resources_Budget`
- `RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz`
- `RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz`
- `RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[450] Rizia/Turn 9/FPnT_MITZ_BoardMeeting** (../Turn_09/450_FPnT_MITZ_BoardMeeting.md), Węzeł `[347]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""I will be direct. Are you going to support Lespia stealing our share in the MITZ?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true` | *Brak zmian stanu* | `[8]` **Narrator**: "Hegel barked out a laugh." |
| `[19]` | **""Chancellor Hegel, I must insist that you do not vote for the latest proposal. It ..."** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true` | *Brak zmian stanu* | `[8]` **Narrator**: "Hegel barked out a laugh." |
| `[24]` | **""Just out of curiosity, how are you planning on voting today?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true` | *Brak zmian stanu* | `[8]` **Narrator**: "Hegel barked out a laugh." |
| `[25]` | **""I know you are helping Saltana stoke internal rebellion in my kingdom. I just wan..."** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false`<br>`(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false` | *Brak zmian stanu* | `[88]` **Emmerich Hegel (R)**: ""Mr. Toras, I have no idea what ..." |
| `[32]` | **""Do you know where my daughter is?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true` | *Brak zmian stanu* | `[37]` **Narrator**: "He laughed without mirth." |
| `[42]` | **""You and the Morellan prime minister must cease your provocations at once. The las..."** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false`<br>`(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false` | *Brak zmian stanu* | `[87]` **Emmerich Hegel (R)**: ""Mr. Toras, I have no idea what ..." |
| `[43]` | **""You're still planning on voting the same way, right?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` | *Brak zmian stanu* | `[44]` **Narrator**: "He looked at me sternly." |
| `[50]` | **""How's everything back home?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` | *Brak zmian stanu* | `[130]` **Narrator**: "He huffed impatiently." |
| `[51]` | **""Exactly as *who* planned?""** | `[49]` **Emmerich Hegel (R)**: ""Don't worry, Mr. Toras. Everyth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "He smiled mysteriously." |
| `[52]` | **""Good. That's all I wanted to know.""** | `[49]` **Emmerich Hegel (R)**: ""Don't worry, Mr. Toras. Everyth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "He gave a curt nod. We left the ..." |
| `[53]` | **""What will it take for you to give me some extra reassurance?""** | `[49]` **Emmerich Hegel (R)**: ""Don't worry, Mr. Toras. Everyth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Emmerich Hegel (R)**: ""You don't need it. You can rely..." |
| `[54]` | **""Good point. Let's head to the vote.""** | `[45]` **Emmerich Hegel (R)**: ""Why are you asking me? You'll f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "He gave a curt nod. We left the ..." |
| `[55]` | **""If your mind has changed... what will it take to change it back?""** | `[45]` **Emmerich Hegel (R)**: ""Why are you asking me? You'll f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Emmerich Hegel (R)**: ""Now you want to make a deal?"" |
| `[56]` | **""Do not disrespect the King of Rizia, Chancellor. I am warning you.""** | `[45]` **Emmerich Hegel (R)**: ""Why are you asking me? You'll f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Emmerich Hegel (R)**: ""You and your crown of stolen go..." |
| `[57]` | **""Please. There must be something Rizia can offer you.""** | `[17]` **Emmerich Hegel (R)**: ""And even if I wasn't... your ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "He folded his arms."<br>`[147]` **Emmerich Hegel (R)**: ""You sold your own island to Les..." |
| `[58]` | **""Is there anything I can do in exchange for a little extra reassurance?""** | `[31]` **Emmerich Hegel (R)**: ""Don't worry. The chances of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "He folded his arms."<br>`[147]` **Emmerich Hegel (R)**: ""You sold your own island to Les..." |
| `[59]` | **""How can you say that? I thought the West was your greatest nemesis.""** | `[17]` **Emmerich Hegel (R)**: ""And even if I wasn't... your ki..."<br>`[33]` **Emmerich Hegel (R)**: ""But you, Mr. Toras, are arguabl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Emmerich Hegel (R)**: ""It is not the West that we in V..." |
| `[66]` | **""A pity. But I understand. I will not try to change your mind.""** | `[17]` **Emmerich Hegel (R)**: ""And even if I wasn't... your ki..."<br>`[18]` **Emmerich Hegel (R)**: ""I am sorry. But that's the way ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Emmerich Hegel (R)**: ""That's very wise of you."" |
| `[67]` | **""That's great to know. Let's head to the vote, then.""** | `[31]` **Emmerich Hegel (R)**: ""Don't worry. The chances of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "He gave a curt nod. We left the ..." |
| `[68]` | **""So you're saying there's no chance. Zero.""** | `[31]` **Emmerich Hegel (R)**: ""Don't worry. The chances of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "He continued to wear an inscruta..." |
| `[70]` | **""Well, if the shoe fits...""** | `[64]` **Emmerich Hegel (R)**: ""And with your insistence on wag..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[83]` **Narrator**: "He rolled his eyes."<br>`[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[81]` | **""You don't understand. There have been extenuating circumstances.""** | `[64]` **Emmerich Hegel (R)**: ""And with your insistence on wag..."<br>`[65]` **Emmerich Hegel (R)**: ""And with your violent actions i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "He rolled his eyes." |
| `[82]` | **""And you? How much damage have you caused by encouraging societies to rip each oth..."** | `[64]` **Emmerich Hegel (R)**: ""And with your insistence on wag..."<br>`[65]` **Emmerich Hegel (R)**: ""And with your violent actions i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Emmerich Hegel (R)**: ""A muscle must tear before it ca..." |
| `[86]` | **""Please. Isn't there anything my kingdom can do to sway your vote?""** | `[64]` **Emmerich Hegel (R)**: ""And with your insistence on wag..."<br>`[65]` **Emmerich Hegel (R)**: ""And with your violent actions i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "He folded his arms."<br>`[147]` **Emmerich Hegel (R)**: ""You sold your own island to Les..." |
| `[97]` | **""It's all in the service of reforms that will transform Rizia. You'll see.""** | `[64]` **Emmerich Hegel (R)**: ""And with your insistence on wag..."<br>`[65]` **Emmerich Hegel (R)**: ""And with your violent actions i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reform_Path"] == true` | *Brak zmian stanu* | `[98]` **Emmerich Hegel (R)**: ""All I see is a deranged bull, c..." |
| `[100]` | **""Stop lying. You've been plotting the downfall of Rizia since you lost Pales.""** | `[99]` **Emmerich Hegel (R)**: ""Your monarchy has sown the seed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Emmerich Hegel (R)**: ""You have a very vivid imaginati..." |
| `[101]` | **""Help me quell this threat, and we will defeat the West together.""** | `[99]` **Emmerich Hegel (R)**: ""Your monarchy has sown the seed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Emmerich Hegel (R)**: ""You, King Romus Toras, want to ..." |
| `[116]` | **""You are a pragmatic man, Mr. Hegel. You know that world leaders do not have to ag..."** | `[99]` **Emmerich Hegel (R)**: ""Your monarchy has sown the seed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Emmerich Hegel (R)**: ""You and I do not even agree on ..."<br>`[125]` **Emmerich Hegel (R)**: ""You have sold your kingdom out ..."<br>*(oraz 2 innych odgałęzień)* |
| `[153]` | **""You're insane. No amount of money is worth that much.""** | `[148]` **Emmerich Hegel (R)**: ""Entirely out of the goodness of..."<br>`[152]` **Emmerich Hegel (R)**: ""You'll be compensated fairly, o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "He shrugged." |
| `[154]` | **""Fine. If that's what it will take, Caleqabiz will be yours." [+4 Budget]"** | `[148]` **Emmerich Hegel (R)**: ""Entirely out of the goodness of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "He reached out and shook my hand..." |
| `[158]` | **""My kingdom's claim to the Aureus gas field rests on the resource's proximity to C..."** | `[148]` **Emmerich Hegel (R)**: ""Entirely out of the goodness of..."<br>`[152]` **Emmerich Hegel (R)**: ""You'll be compensated fairly, o..." | `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]` | *Brak zmian stanu* | `[167]` **Emmerich Hegel (R)**: ""Suit yourself."" |
| `[159]` | **""Our kingdom could use the extra income. Why not? Let's make a deal." [+4 Budget]"** | `[152]` **Emmerich Hegel (R)**: ""You'll be compensated fairly, o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "He reached out and shook my hand..." |
| `[160]` | **""The CSP already has its hooks in Morella. Now you want to position yourselves on ..."** | `[148]` **Emmerich Hegel (R)**: ""Entirely out of the goodness of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "He shrugged." |
| `[161]` | **""Only if you call me 'Comrade Romus'." [+4 Budget]"** | `[152]` **Emmerich Hegel (R)**: ""You'll be compensated fairly, o..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2` | *Brak zmian stanu* | `[162]` **Narrator**: "He snorted." |
| `[176]` | **""This had better be worth it.""** | `[172]` **Emmerich Hegel (R)**: ""I assume we're done here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Emmerich Hegel (R)**: ""That's not for me to judge."" |
| `[177]` | **""Yes, let's get this over with.""** | `[172]` **Emmerich Hegel (R)**: ""I assume we're done here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "We left the room." |
| `[182]` | **""Do you know where my daughter is?""** | `[172]` **Emmerich Hegel (R)**: ""I assume we're done here."" | `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true` | *Brak zmian stanu* | `[189]` **Narrator**: "He laughed without mirth." |
| `[190]` | **""Thank you for your flexibility, Chancellor.""** | `[172]` **Emmerich Hegel (R)**: ""I assume we're done here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "We left the room." |
| `[196]` | **""I want the truth. Is Valgsland aiding the new revolutionary movement in Rizia?""** | `[3]` **Narrator**: "The aides quickly readied a side..." | `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true` | *Brak zmian stanu* | `[197]` **Narrator**: "He spoke calmly." |
| `[202]` | **""We discussed this. You yourself said the time would be right someday.""** | `[198]` **Emmerich Hegel (R)**: ""Revolutions cannot be started f..." | `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true` | *Brak zmian stanu* | `[214]` **Emmerich Hegel (R)**: ""Did I? I don't recall. It was v..." |
| `[203]` | **""Seeds don't grow without nourishment. You've been watering them from afar.""** | `[198]` **Emmerich Hegel (R)**: ""Revolutions cannot be started f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Emmerich Hegel (R)**: ""As have you, from what I gather.""<br>`[236]` **Emmerich Hegel (R)**: ""I don't have the time or inclin..." |
| `[204]` | **""I want those seeds to sprout as much as you do. I am working with this movement, ..."** | `[198]` **Emmerich Hegel (R)**: ""Revolutions cannot be started f..." | `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true` | *Brak zmian stanu* | `[208]` **Emmerich Hegel (R)**: ""I am skeptical that even an 'en..." |
| `[219]` | **""If your government is meddling with my kingdom's affairs in any way, you will pay.""** | `[198]` **Emmerich Hegel (R)**: ""Revolutions cannot be started f..." | `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false` | *Brak zmian stanu* | `[220]` **Emmerich Hegel (R)**: ""Duly noted. Is that all?"" |
| `[222]` | **""Drop the high-and-mighty act, Chancellor. The CSP would love a bigger foothold in..."** | `[198]` **Emmerich Hegel (R)**: ""Revolutions cannot be started f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Emmerich Hegel (R)**: ""Rizia would have much to gain f..."<br>`[236]` **Emmerich Hegel (R)**: ""I don't have the time or inclin..." |
| `[226]` | **""No. I heard you might be changing your vote today?""** | `[220]` **Emmerich Hegel (R)**: ""Duly noted. Is that all?"" | `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true` | *Brak zmian stanu* | `[8]` **Narrator**: "Hegel barked out a laugh." |
| `[227]` | **""Yes. Let's get this board vote over with.""** | `[220]` **Emmerich Hegel (R)**: ""Duly noted. Is that all?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Emmerich Hegel (R)**: ""Indeed."" |
| `[238]` | **""We once spoke of big changes coming to Rizia. I believe the time is now right for..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "The hint of a smile appeared on ..." |
| `[249]` | **""You don't need to worry about that. Just know that we'll be open to closer ties w..."** | `[248]` **Emmerich Hegel (R)**: ""Although I am worried that with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Emmerich Hegel (R)**: ""If it's closer ties with Valgsl..."<br>`[258]` **Emmerich Hegel (R)**: ""How can you say that when your ..." |
| `[250]` | **""I assure you these changes are being made with the working class in mind.""** | `[248]` **Emmerich Hegel (R)**: ""Although I am worried that with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Emmerich Hegel (R)**: ""I should hope so."" |
| `[251]` | **""That is the least of my concerns. I'll be lucky to pass even a bare-bones version..."** | `[248]` **Emmerich Hegel (R)**: ""Although I am worried that with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Emmerich Hegel (R)**: ""You are the monarch, are you no..." |

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
  - -> `[3]` (*Narrator: "The aides quickly readied a side room for us. We stepped ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The aides quickly readied a side room for us. We stepped in and sat across from one another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Elena Werner")"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_LespiaScrewedOverRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_LespiaScrewedOverRizia == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_LespiaScrewedOverRizia == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_LespiaScrewedOverRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""I will be direct. Are you going to support Lespia steali..."*)
  - -> `[19]` (*Player_Romus: ""Chancellor Hegel, I must insist that you do not vote for..."*)
  - -> `[24]` (*Player_Romus: ""Just out of curiosity, how are you planning on voting to..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_LespiaScrewedOverRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Re..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be direct. Are you going to support Lespia stealing our share in the MITZ?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hegel barked out a laugh."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Hegel barked out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Emmerich Hegel (R): ""I warned you that the Lespians were a menace to the Trad..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Emmerich Hegel (R): ""In the end, it is Morella's decision, not mine. I am obl..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Emmerich Hegel (R): ""Obviously, I am against Alvarez and his cronies snapping..."*)

### Węzeł `[12]`
Mówca: **Emmerich Hegel (R)**
> ""I warned you that the Lespians were a menace to the Trade Zone. You didn't listen to me, and this is your reward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true"*)

### Węzeł `[13]`
Mówca: **Emmerich Hegel (R)**
> ""In the end, it is Morella's decision, not mine. I am obligated to support any nationalization plan that Saltana puts forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Emmerich Hegel (R): ""And even if I wasn't... your kingdom is arguably a great..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Emmerich Hegel (R): ""I am sorry. But that's the way it has to be.""*)

### Węzeł `[17]`
Mówca: **Emmerich Hegel (R)**
> ""And even if I wasn't... your kingdom is arguably a greater threat than Lespia at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Please. There must be something Rizia can offer you.""*)
  - -> `[66]` (*Player_Romus: ""A pity. But I understand. I will not try to change your ..."*)
  - -> `[59]` (*Player_Romus: ""How can you say that? I thought the West was your greate..."*)

### Węzeł `[18]`
Mówca: **Emmerich Hegel (R)**
> ""I am sorry. But that's the way it has to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""A pity. But I understand. I will not try to change your ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chancellor Hegel, I must insist that you do not vote for the latest proposal. It was amended without Rizia's knowledge.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hegel barked out a laugh."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComrad..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComr..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Do you know where my daughter is?""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[23]`
Mówca: **Emmerich Hegel (R)**
> ""Obviously, I am against Alvarez and his cronies snapping up a bigger share of South Merkopa's largest gold resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just out of curiosity, how are you planning on voting today?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hegel barked out a laugh."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you are helping Saltana stoke internal rebellion in my kingdom. I just wanted to tell you that I don't care.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false` AND `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Emmerich Hegel (R): ""Mr. Toras, I have no idea what you're talking about.""*)

### Węzeł `[26]`
Mówca: **Emmerich Hegel (R)**
> ""If I knew where she was, why the hell would I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[27]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras fled Rizia to escape the archaic marriage bond being forced upon her by her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Emmerich Hegel (R): ""If I knew where she was, why the hell would I tell you?""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Emmerich Hegel (R): ""But you, Mr. Toras, are arguably a greater threat than A..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Emmerich Hegel (R): ""Don't worry. The chances of the new proposal passing are..."*)

### Węzeł `[31]`
Mówca: **Emmerich Hegel (R)**
> ""Don't worry. The chances of the new proposal passing are roughly that of a snowball in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Is there anything I can do in exchange for a little extr..."*)
  - -> `[67]` (*Player_Romus: ""That's great to know. Let's head to the vote, then.""*)
  - -> `[68]` (*Player_Romus: ""So you're saying there's no chance. Zero.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know where my daughter is?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "He laughed without mirth."*)

### Węzeł `[33]`
Mówca: **Emmerich Hegel (R)**
> ""But you, Mr. Toras, are arguably a greater threat than Alvarez at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""A pity. But I understand. I will not try to change your ..."*)
  - -> `[59]` (*Player_Romus: ""How can you say that? I thought the West was your greate..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.V..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Emmerich Hegel (R): ""From what I have heard, Vina Toras fled Rizia to escape ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Emmerich Hegel (R): ""From what I have heard, Vina Toras was being kept in a g..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "He laughed without mirth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.V..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Re..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC...."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""I know you are helping Saltana stoke internal rebellion ..."*)
  - -> `[42]` (*Player_Romus: ""You and the Morellan prime minister must cease your prov..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true && RiziaDLC.Reform_Movement_Grows == true && RiziaDLC.Morella_Sabotage_Plans_Discovered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Refo..."*)

### Węzeł `[41]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras was being kept in a golden cage -- allowed neither power nor the ability to choose her own husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Emmerich Hegel (R): ""If I knew where she was, why the hell would I tell you?""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and the Morellan prime minister must cease your provocations at once. The last thing any of us wants is bloodshed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true  and  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == false` AND `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Emmerich Hegel (R): ""Mr. Toras, I have no idea what you're talking about.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still planning on voting the same way, right?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He looked at me sternly."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He looked at me sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[45]`
Mówca: **Emmerich Hegel (R)**
> ""Why are you asking me? You'll find out in five minutes, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Good point. Let's head to the vote.""*)
  - -> `[55]` (*Player_Romus: ""If your mind has changed... what will it take to change ..."*)
  - -> `[56]` (*Player_Romus: ""Do not disrespect the King of Rizia, Chancellor. I am wa..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Emmerich Hegel (R): ""Why are you asking me? You'll find out in five minutes, ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Emmerich Hegel (R): ""Don't worry, Mr. Toras. Everything will go exactly as pl..."*)

### Węzeł `[49]`
Mówca: **Emmerich Hegel (R)**
> ""Don't worry, Mr. Toras. Everything will go exactly as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""Exactly as *who* planned?""*)
  - -> `[52]` (*Player_Romus: ""Good. That's all I wanted to know.""*)
  - -> `[53]` (*Player_Romus: ""What will it take for you to give me some extra reassura..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How's everything back home?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He huffed impatiently."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly as *who* planned?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "He smiled mysteriously."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's all I wanted to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He gave a curt nod. We left the room."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What will it take for you to give me some extra reassurance?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Emmerich Hegel (R): ""You don't need it. You can rely on my cooperation.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Let's head to the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He gave a curt nod. We left the room."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your mind has changed... what will it take to change it back?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Emmerich Hegel (R): ""Now you want to make a deal?""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not disrespect the King of Rizia, Chancellor. I am warning you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Emmerich Hegel (R): ""You and your crown of stolen gold... They are coming for..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. There must be something Rizia can offer you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there anything I can do in exchange for a little extra reassurance?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you say that? I thought the West was your greatest nemesis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Emmerich Hegel (R)), `[33]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Emmerich Hegel (R): ""It is not the West that we in Valgsland are fighting, Mr..."*)

### Węzeł `[60]`
Mówca: **Emmerich Hegel (R)**
> ""It is not the West that we in Valgsland are fighting, Mr. Toras. It is the boot on the necks of the oppressed everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Emmerich Hegel (R): ""And with your insistence on waging an unjust war, Rizia ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Emmerich Hegel (R): ""And with your violent actions in Zille, Rizia is wearing..."*)

### Węzeł `[64]`
Mówca: **Emmerich Hegel (R)**
> ""And with your insistence on waging an unjust war, Rizia is wearing the biggest boot of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Please. Isn't there anything my kingdom can do to sway y..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[81]` (*Player_Romus: ""You don't understand. There have been extenuating circum..."*)
  - -> `[82]` (*Player_Romus: ""And you? How much damage have you caused by encouraging ..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)

### Węzeł `[65]`
Mówca: **Emmerich Hegel (R)**
> ""And with your violent actions in Zille, Rizia is wearing the biggest boot of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Please. Isn't there anything my kingdom can do to sway y..."*)
  - -> `[81]` (*Player_Romus: ""You don't understand. There have been extenuating circum..."*)
  - -> `[82]` (*Player_Romus: ""And you? How much damage have you caused by encouraging ..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pity. But I understand. I will not try to change your mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Emmerich Hegel (R)), `[18]` (Emmerich Hegel (R)), `[33]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel (R): ""That's very wise of you.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's great to know. Let's head to the vote, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He gave a curt nod. We left the room."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're saying there's no chance. Zero.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "He continued to wear an inscrutable expression."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "He gave a curt nod. We left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, if the shoe fits...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[64]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He rolled his eyes."*)
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "He folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Emmerich Hegel (R): ""There is precisely one thing you can offer.""*)

### Węzeł `[72]`
Mówca: **Emmerich Hegel (R)**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Emmerich Hegel (R): ""Shall we get this over with?""*)

### Węzeł `[73]`
Mówca: **Emmerich Hegel (R)**
> ""Shall we get this over with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He gestured to the door, and we left the room."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "He gestured to the door, and we left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "He continued to wear an inscrutable expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[76]`
Mówca: **Emmerich Hegel (R)**
> ""Let's get this over with, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "We left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""Well, if the shoe fits...""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. There have been extenuating circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Emmerich Hegel (R)), `[65]` (Emmerich Hegel (R)), `[92]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He rolled his eyes."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you? How much damage have you caused by encouraging societies to rip each other apart in the name of your 'revolution'?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Emmerich Hegel (R)), `[65]` (Emmerich Hegel (R)), `[92]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Emmerich Hegel (R): ""A muscle must tear before it can grow stronger.""*)

### Węzeł `[83]`
Mówca: **Narrator**
> "He rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[84]`
Mówca: **Emmerich Hegel (R)**
> ""A muscle must tear before it can grow stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Emmerich Hegel (R): ""You'll find that out for yourself.""*)

### Węzeł `[85]`
Mówca: **Emmerich Hegel (R)**
> ""You'll find that out for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Isn't there anything my kingdom can do to sway your vote?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Emmerich Hegel (R)), `[65]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[87]`
Mówca: **Emmerich Hegel (R)**
> ""Mr. Toras, I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Emmerich Hegel (R): ""Your monarchy has sown the seeds of its own revolution. ..."*)

### Węzeł `[88]`
Mówca: **Emmerich Hegel (R)**
> ""Mr. Toras, I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true )"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Emmerich Hegel (R): ""With your campaign of terror, you are sowing the seeds f..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Emmerich Hegel (R): ""But I am glad that you have accepted the inevitability o..."*)

### Węzeł `[92]`
Mówca: **Emmerich Hegel (R)**
> ""With your campaign of terror, you are sowing the seeds for your kingdom's own demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""You don't understand. There have been extenuating circum..."*)
  - -> `[82]` (*Player_Romus: ""And you? How much damage have you caused by encouraging ..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)

### Węzeł `[93]`
Mówca: **Emmerich Hegel (R)**
> ""But I am glad that you have accepted the inevitability of revolution. All kingdoms must, in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""It's all in the service of reforms that will transform R..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all in the service of reforms that will transform Rizia. You'll see.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[64]` (Emmerich Hegel (R)), `[65]` (Emmerich Hegel (R)), `[92]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Emmerich Hegel (R): ""All I see is a deranged bull, charging at the people in ..."*)

### Węzeł `[98]`
Mówca: **Emmerich Hegel (R)**
> ""All I see is a deranged bull, charging at the people in the stands instead of the man waving the flag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[99]`
Mówca: **Emmerich Hegel (R)**
> ""Your monarchy has sown the seeds of its own revolution. They did not need our help to sprout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""Help me quell this threat, and we will defeat the West t..."*)
  - -> `[100]` (*Player_Romus: ""Stop lying. You've been plotting the downfall of Rizia s..."*)
  - -> `[116]` (*Player_Romus: ""You are a pragmatic man, Mr. Hegel. You know that world ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop lying. You've been plotting the downfall of Rizia since you lost Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Emmerich Hegel (R): ""You have a very vivid imagination.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Help me quell this threat, and we will defeat the West together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Emmerich Hegel (R): ""You, King Romus Toras, want to defeat the West?""*)

### Węzeł `[102]`
Mówca: **Emmerich Hegel (R)**
> ""You, King Romus Toras, want to defeat the West?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Emmerich Hegel (R): ""It is not the West that we in Valgsland are fighting, Mr..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Emmerich Hegel (R): ""You expect me to believe that after you sold your island..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He folded his arms."*)

### Węzeł `[109]`
Mówca: **Emmerich Hegel (R)**
> ""You expect me to believe that after you sold your island to ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Emmerich Hegel (R): ""I see no use in speaking to you further.""*)

### Węzeł `[110]`
Mówca: **Emmerich Hegel (R)**
> ""I see no use in speaking to you further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[111]`
Mówca: **Narrator**
> "He folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Emmerich Hegel (R): ""If you are serious about that, there is precisely one th..."*)

### Węzeł `[112]`
Mówca: **Emmerich Hegel (R)**
> ""If you are serious about that, there is precisely one thing you can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "Jump to: [Caleqabiz Valgsland Sale]"*)

### Węzeł `[113]`
Mówca: **Emmerich Hegel (R)**
> ""There is precisely one thing you can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Caleqabiz Valgsland Sale"*)

### Węzeł `[114]`
Mówca: **Emmerich Hegel (R)**
> ""Your island, Caleqabiz. Allow Valgsland and the CSP to use it as a base of operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[115]`
Mówca: **Emmerich Hegel (R)**
> ""You have a very vivid imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a pragmatic man, Mr. Hegel. You know that world leaders do not have to agree on everything to help each other out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Emmerich Hegel (R): ""You and I do not even agree on what constitutes basic de..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)

### Węzeł `[120]`
Mówca: **Emmerich Hegel (R)**
> ""You and I do not even agree on what constitutes basic decency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)

### Węzeł `[121]`
Mówca: **Emmerich Hegel (R)**
> ""We will suffer through today. And then our paths will not cross again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Emmerich Hegel (R): ""You have sold your kingdom out to Lespia and ATO. No off..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[125]`
Mówca: **Emmerich Hegel (R)**
> ""You have sold your kingdom out to Lespia and ATO. No offer under the sun would convince me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Emmerich Hegel (R): ""We will suffer through today. And then our paths will no..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[129]`
Mówca: **Emmerich Hegel (R)**
> ""Good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He huffed impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Emmerich Hegel (R): ""Good, as it happens. Valgsland gained a new ally recently.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Emmerich Hegel (R): ""I didn't come here for small talk, Mr. Toras.""*)

### Węzeł `[134]`
Mówca: **Emmerich Hegel (R)**
> ""Good, as it happens. Valgsland gained a new ally recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[135]`
Mówca: **Emmerich Hegel (R)**
> ""I didn't come here for small talk, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[136]`
Mówca: **Emmerich Hegel (R)**
> ""Now you want to make a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[137]`
Mówca: **Emmerich Hegel (R)**
> ""You and your crown of stolen gold... They are coming for it, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[138]`
Mówca: **Emmerich Hegel (R)**
> ""You don't need it. You can rely on my cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[139]`
Mówca: **Emmerich Hegel (R)**
> ""But if it's a closer bond with Valgsland you want, I do have one offer for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Caleqabiz Valgsland Sale"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Emmerich Hegel (R): ""But if it's a closer bond with Valgsland you want, I do ..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[143]`
Mówca: **Narrator**
> "He smiled mysteriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "He folded his arms."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Emmerich Hegel (R): ""You sold your own island to Lespia and ATO. No offer und..."*)

### Węzeł `[147]`
Mówca: **Emmerich Hegel (R)**
> ""You sold your own island to Lespia and ATO. No offer under the sun would convince me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[148]`
Mówca: **Emmerich Hegel (R)**
> ""Entirely out of the goodness of your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: ""The CSP already has its hooks in Morella. Now you want t..."*)
  - -> `[153]` (*Player_Romus: ""You're insane. No amount of money is worth that much.""*)
  - -> `[154]` (*Player_Romus: ""Fine. If that's what it will take, Caleqabiz will be you..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Emmerich Hegel (R): ""Entirely out of the goodness of your heart.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel (R): ""You'll be compensated fairly, of course.""*)

### Węzeł `[152]`
Mówca: **Emmerich Hegel (R)**
> ""You'll be compensated fairly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""You're insane. No amount of money is worth that much.""*)
  - -> `[159]` (*Player_Romus: ""Our kingdom could use the extra income. Why not? Let's m..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're insane. No amount of money is worth that much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Emmerich Hegel (R)), `[152]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He shrugged."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Fine. If that's what it will take, Caleqabiz will be yours." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. If that's what it will take, Caleqabiz will be yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He reached out and shook my hand firmly."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""My kingdom's claim to the Aureus gas field rests on the ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom's claim to the Aureus gas field rests on the resource's proximity to Caleqabiz. I will not weaken it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"]`
- **Kontekst wejściowy (poprzednik):** `[148]` (Emmerich Hegel (R)), `[152]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Emmerich Hegel (R): ""Suit yourself.""*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Our kingdom could use the extra income. Why not? Let's make a deal." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Our kingdom could use the extra income. Why not? Let's make a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He reached out and shook my hand firmly."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The CSP already has its hooks in Morella. Now you want to position yourselves on our other side? Never.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He shrugged."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Only if you call me 'Comrade Romus'." [+4 Budget]"]** — Mówca: **Player_Romus**
> ""Only if you call me 'Comrade Romus'.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Kontekst wejściowy (poprzednik):** `[152]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He snorted."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Emmerich Hegel (R): ""We have a deal, comrade.""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 2)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""Only if you call me 'Comrade Romus'." [+4 Budget]"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
Mówca: **Emmerich Hegel (R)**
> ""We have a deal, comrade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP = true; ..."*)

### Węzeł `[167]`
Mówca: **Emmerich Hegel (R)**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[168]`
Mówca: **Emmerich Hegel (R)**
> ""A pleasure cooperating with you, Mr. Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP = true; ..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He reached out and shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Emmerich Hegel (R): ""Then my vote is yours.""*)

### Węzeł `[170]`
Mówca: **Emmerich Hegel (R)**
> ""Then my vote is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP = true; ..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "He reached out and shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Emmerich Hegel (R): ""A pleasure cooperating with you, Mr. Toras.""*)

### Węzeł `[172]`
Mówca: **Emmerich Hegel (R)**
> ""I assume we're done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""This had better be worth it.""*)
  - -> `[177]` (*Player_Romus: ""Yes, let's get this over with.""*)
  - -> `[190]` (*Player_Romus: ""Thank you for your flexibility, Chancellor.""*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComrad..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP = true; 
RiziaDLC.Resources_Budget += 4; 
RiziaDLC.PersonalValue_Malenyevist += 3;
RiziaDLC.Diplomacy_Valgsland_NegotiatingPower += 3; RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 3;
RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz = true;
RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 3;
Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] + 3;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 3;
Variable["RiziaDLCSupport.FactionReports_Turn09_ATO_CondemnsCSPCaleqabiz"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn09_GRACE_CondemnsCSPCaleqabiz"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland ..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Emmerich Hegel (R): ""That was my idea. I don't have any others.""*)

### Węzeł `[175]`
Mówca: **Emmerich Hegel (R)**
> ""That was my idea. I don't have any others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel (R): ""Let's get this over with, shall we?""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better be worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Emmerich Hegel (R): ""That's not for me to judge.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[178]`
Mówca: **Emmerich Hegel (R)**
> ""That's not for me to judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComrad..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComr..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""Do you know where my daughter is?""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComradeVina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know where my daughter is?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  and  Variable["RiziaDLC.ToldAboutComradeVina"] == true`
- **Kontekst wejściowy (poprzednik):** `[172]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "He laughed without mirth."*)

### Węzeł `[183]`
Mówca: **Emmerich Hegel (R)**
> ""If I knew where she was, why the hell would I tell you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[184]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras fled Rizia to escape the archaic marriage bond being forced upon her by her father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Emmerich Hegel (R): ""If I knew where she was, why the hell would I tell you?""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.V..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Emmerich Hegel (R): ""From what I have heard, Vina Toras fled Rizia to escape ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Emmerich Hegel (R): ""From what I have heard, Vina Toras was being kept in a g..."*)

### Węzeł `[188]`
Mówca: **Emmerich Hegel (R)**
> ""From what I have heard, Vina Toras was being kept in a golden cage -- allowed neither the ability to advance her career nor choose her own life partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Emmerich Hegel (R): ""If I knew where she was, why the hell would I tell you?""*)

### Węzeł `[189]`
Mówca: **Narrator**
> "He laughed without mirth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.V..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your flexibility, Chancellor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_MITZ_CaleqebizToValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_City_Qabiz", "Rizia_City..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Elena Werner")`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Elena Werner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_LespiaScrewedOverRizia == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true && RiziaDLC.ToldAboutComrad..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""I want the truth. Is Valgsland aiding the new revolution..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""How's everything back home?""*)
  - -> `[43]` (*Player_Romus: ""You're still planning on voting the same way, right?""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want the truth. Is Valgsland aiding the new revolutionary movement in Rizia?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "He spoke calmly."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "He spoke calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Emmerich Hegel (R): ""Revolutions cannot be started from the outside, Mr. Tora..."*)

### Węzeł `[198]`
Mówca: **Emmerich Hegel (R)**
> ""Revolutions cannot be started from the outside, Mr. Toras. Your people planted the seeds of their own liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution == true"*)
  - -> `[203]` (*Player_Romus: ""Seeds don't grow without nourishment. You've been wateri..."*)
  - -> `[222]` (*Player_Romus: ""Drop the high-and-mighty act, Chancellor. The CSP would ..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAda..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hegel_OpenToRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hegel_OpenToRevolution == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hegel_OpenToRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""We discussed this. You yourself said the time would be r..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hegel_OpenToRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hegel_OpenToRevolution"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We discussed this. You yourself said the time would be right someday.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Emmerich Hegel (R): ""Did I? I don't recall. It was very late at night.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seeds don't grow without nourishment. You've been watering them from afar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want those seeds to sprout as much as you do. I am working with this movement, not against it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Emmerich Hegel (R): ""I am skeptical that even an 'enlightened' monarch such a..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAda..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToA..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I want those seeds to sprout as much as you do. I am wor..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""If your government is meddling with my kingdom's affairs..."*)

### Węzeł `[208]`
Mówca: **Emmerich Hegel (R)**
> ""I am skeptical that even an 'enlightened' monarch such as yourself would be willing to hand the reins of government to the working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Emmerich Hegel (R): ""But I'm ready to be positively surprised.""*)

### Węzeł `[209]`
Mówca: **Emmerich Hegel (R)**
> ""But I'm ready to be positively surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[210]`
Mówca: **Narrator**
> "He smiled conspiratorially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Emmerich Hegel (R): ""While you are still monarch of Rizia, there is one thing..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "He smiled conspiratorially."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Emmerich Hegel (R): ""I would take you to task for leasing your most strategic..."*)

### Węzeł `[214]`
Mówca: **Emmerich Hegel (R)**
> ""Did I? I don't recall. It was very late at night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[215]`
Mówca: **Emmerich Hegel (R)**
> ""But I am happy to see that your politician -- Sotelato, was it? -- has finally put the Rizian working class on a path to self-determination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Emmerich Hegel (R): ""But if the time were ever right for revolution in your c..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Emmerich Hegel (R): ""But I am happy to see that your politician -- Sotelato, ..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your government is meddling with my kingdom's affairs in any way, you will pay.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Emmerich Hegel (R): ""Duly noted. Is that all?""*)

### Węzeł `[220]`
Mówca: **Emmerich Hegel (R)**
> ""Duly noted. Is that all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_LespiaScrewedOverRizia == true"*)
  - -> `[227]` (*Player_Romus: ""Yes. Let's get this board vote over with.""*)

### Węzeł `[221]`
Mówca: **Emmerich Hegel (R)**
> ""But if the time were ever right for revolution in your country, it would be now, after you dissolved your father's sad attempt at a parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drop the high-and-mighty act, Chancellor. The CSP would love a bigger foothold in South Merkopa.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_LespiaScrewedOverRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_LespiaScrewedOverRizia == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_LespiaScrewedOverRizia == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_LespiaScrewedOverRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""No. I heard you might be changing your vote today?""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_LespiaScrewedOverRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I heard you might be changing your vote today?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_LespiaScrewedOverRizia"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Hegel barked out a laugh."]"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Let's get this board vote over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Emmerich Hegel (R): ""Indeed.""*)

### Węzeł `[228]`
Mówca: **Emmerich Hegel (R)**
> ""As have you, from what I gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Emmerich Hegel (R): ""As have you, from what I gather.""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Emmerich Hegel (R): ""I don't have the time or inclination to listen to your a..."*)

### Węzeł `[232]`
Mówca: **Emmerich Hegel (R)**
> ""Rizia would have much to gain from that as well, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKi..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Emmerich Hegel (R): ""Rizia would have much to gain from that as well, you know.""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true || RiziaDLC.Trait_CommieKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Emmerich Hegel (R): ""I don't have the time or inclination to listen to your a..."*)

### Węzeł `[236]`
Mówca: **Emmerich Hegel (R)**
> ""I don't have the time or inclination to listen to your accusations. We've got a vote to sit through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[237]`
Mówca: **Emmerich Hegel (R)**
> ""I only hope that whenever your new government comes to fruition, it has the sense to reverse that decision. Until then, I don't have a thing to say to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We once spoke of big changes coming to Rizia. I believe the time is now right for them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "The hint of a smile appeared on his face."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Refo..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Re..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hegel_OpenToRevolution"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""We once spoke of big changes coming to Rizia. I believe ..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hegel_OpenToRevolution == true && (RiziaDLC.Reform_Path == true || RiziaDLC.Reform_TalkToAdarfo_AskedManus == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hegel_OpenToRevolution"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[242]`
Mówca: **Narrator**
> "The hint of a smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == false"*)

### Węzeł `[243]`
Mówca: **Emmerich Hegel (R)**
> ""Yes. I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Emmerich Hegel (R): ""I am skeptical that even an 'enlightened' monarch such a..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == false"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == false)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Emmerich Hegel (R): ""It's heartening to hear that.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Emmerich Hegel (R): ""Yes. I believe so as well.""*)

### Węzeł `[247]`
Mówca: **Emmerich Hegel (R)**
> ""It's heartening to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Emmerich Hegel (R): ""Although I am worried that without the workers' movement..."*)

### Węzeł `[248]`
Mówca: **Emmerich Hegel (R)**
> ""Although I am worried that without the workers' movement leading the charge, the 'new' Rizia will suspiciously resemble the old one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""You don't need to worry about that. Just know that we'll..."*)
  - -> `[250]` (*Player_Romus: ""I assure you these changes are being made with the worki..."*)
  - -> `[251]` (*Player_Romus: ""That is the least of my concerns. I'll be lucky to pass ..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to worry about that. Just know that we'll be open to closer ties with Valgsland going forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assure you these changes are being made with the working class in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Emmerich Hegel (R): ""I should hope so.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is the least of my concerns. I'll be lucky to pass even a bare-bones version of reform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Emmerich Hegel (R): ""You are the monarch, are you not? Exercise your power wh..."*)

### Węzeł `[252]`
Mówca: **Emmerich Hegel (R)**
> ""If it's closer ties with Valgsland you want, there is something I can offer you right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "Jump to: [Caleqabiz Valgsland Sale]"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Emmerich Hegel (R): ""If it's closer ties with Valgsland you want, there is so..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Emmerich Hegel (R): ""How can you say that when your most strategic island has..."*)

### Węzeł `[256]`
Mówca: **Emmerich Hegel (R)**
> ""I should hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[257]`
Mówca: **Emmerich Hegel (R)**
> ""You are the monarch, are you not? Exercise your power while you still can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_LespiaATO == false"*)

### Węzeł `[258]`
Mówca: **Emmerich Hegel (R)**
> ""How can you say that when your most strategic island has been leased to our ideological rival?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Emmerich Hegel (R): ""I only hope that whenever your new government comes to f..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Caleqabiz Valgsland Sale`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Emmerich Hegel (R): ""Your island, Caleqabiz. Allow Valgsland and the CSP to u..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Caleqabiz Valgsland Sale]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Caleqabiz Valgsland Sale"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Caleqabiz Valgsland Sale]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Caleqabiz Valgsland Sale"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Hegel barked out a laugh."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hegel barked out a laugh."*)

### Węzeł `[263]`
Mówca: **Emmerich Hegel (R)**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We left the room."*)

### Węzeł `[264]`
Mówca: **Emmerich Hegel (R)**
> ""While you are still monarch of Rizia, there is one thing I would ask of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "Jump to: [Caleqabiz Valgsland Sale]"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Caleqabiz Valgsland Sale]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Caleqabiz Valgsland Sale"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_City_Qabiz", "Rizia_City_ValgslandPort");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Qabiz","Rizia_City_ValgslandPort");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Emmerich Hegel (R): ""I assume we're done here.""*)

### Węzeł `[267]`
Mówca: **Emmerich Hegel (R)**
> ""I would take you to task for leasing your most strategic island to our direct rivals in Lespia. But I'll save that conversation for your predecessor, whoever he or she may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel (R): ""Good day.""*)
