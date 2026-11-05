# Rizia/ABOLISHLEVIES/ABOLISHLEVIES Conversation

- **ID konwersacji:** `578`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (ABOLISHLEVIES)`
- **Lokalizacja pliku:** `Rizia/Decrees/578_ABOLISHLEVIES_Conversation.md`
- **Liczba węzłów dialogowych:** 157
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_Sazon_Dead`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_DeclareIntention_WeakStatement`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Objective_Captured_Pales`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`
- `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports`
- `RiziaDLCSetup.CurrentStep`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`
- `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[51]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""The levies are relics of feudalism. How can we claim to be united under one crown..."** | `[4]` **Hugo Toras**: ""To dismantle them is to upend t..."<br>`[150]` **Hugo Toras**: ""I don't know what you're thinki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Hugo Toras**: ""I understand the logic, Romus. ..."<br>`[14]` **Hugo Toras**: ""I understand the logic, Romus. ..." |
| `[6]` | **""I am aware of what this decree entails, Hugo.""** | `[4]` **Hugo Toras**: ""To dismantle them is to upend t..."<br>`[150]` **Hugo Toras**: ""I don't know what you're thinki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Hugo Toras**: ""I understand the logic, Romus. ..."<br>`[14]` **Hugo Toras**: ""I understand the logic, Romus. ..." |
| `[7]` | **""That's exactly what I'm aiming to do.""** | `[4]` **Hugo Toras**: ""To dismantle them is to upend t..."<br>`[150]` **Hugo Toras**: ""I don't know what you're thinki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Hugo Toras**: ""I understand the logic, Romus. ..."<br>`[14]` **Hugo Toras**: ""I understand the logic, Romus. ..." |
| `[8]` | **""All right, Hugo. Tell me what's on your mind.""** | `[4]` **Hugo Toras**: ""To dismantle them is to upend t..."<br>`[150]` **Hugo Toras**: ""I don't know what you're thinki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "He leaned forward." |
| `[36]` | **"I'm aware, Hugo. I expect resistance already.""** | `[70]` **Hugo Toras**: ""And they will resist that perce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""This is a dangerous gamble so e..."<br>`[52]` **Hugo Toras**: ""This is a dangerous gamble whil..."<br>*(oraz 2 innych odgałęzień)* |
| `[37]` | **""This isn't about weakening them. It's about strengthening the kingdom as a whole.""** | `[70]` **Hugo Toras**: ""And they will resist that perce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""This is a dangerous gamble so e..."<br>`[52]` **Hugo Toras**: ""This is a dangerous gamble whil..."<br>*(oraz 2 innych odgałęzień)* |
| `[38]` | **""And what do you suggest?""** | `[70]` **Hugo Toras**: ""And they will resist that perce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""This is a dangerous gamble so e..."<br>`[52]` **Hugo Toras**: ""This is a dangerous gamble whil..."<br>*(oraz 2 innych odgałęzień)* |
| `[39]` | **""They can try to resist all they want.""** | `[70]` **Hugo Toras**: ""And they will resist that perce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""This is a dangerous gamble so e..."<br>`[52]` **Hugo Toras**: ""This is a dangerous gamble whil..."<br>*(oraz 2 innych odgałęzień)* |
| `[59]` | **""You may be right. But what would you have me do? Allow this fractured system to c..."** | `[70]` **Hugo Toras**: ""And they will resist that perce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""This is a dangerous gamble so e..."<br>`[52]` **Hugo Toras**: ""This is a dangerous gamble whil..."<br>*(oraz 2 innych odgałęzień)* |
| `[64]` | **""Well, does House Toras stand firm, Hugo?""** | `[18]` **Hugo Toras**: ""But if House Toras stands firm ..."<br>`[140]` **Hugo Toras**: ""But now that you've also remove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""Of course. As always."" |
| `[65]` | **""I believe this is the right time.""** | `[18]` **Hugo Toras**: ""But if House Toras stands firm ..."<br>`[140]` **Hugo Toras**: ""But now that you've also remove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "He nodded." |
| `[67]` | **""Thank you, Hugo.""** | `[95]` **Hugo Toras**: ""I will do my best to support yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_Hugo...` | `[117]` **Narrator**: "I grabbed the pen." |
| `[71]` | **""The levies are what's tearing the kingdom apart. The sooner I get rid of them, th..."** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | *Brak zmian stanu* | `[31]` **Hugo Toras**: ""We need the Houses' full cooper..." |
| `[72]` | **""This will not weaken our forces, it will strengthen the central administration's ..."** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Hugo Toras**: ""You underestimate the risk. Thi..." |
| `[73]` | **""You're worrying too much. We will win this war in no time. We don't need the levi..."** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..."<br>`[104]` **Hugo Toras**: ""We need the Houses' full cooper..." | `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[98]` **Narrator**: "There was a brief silence. His e..." |
| `[74]` | **""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""** | `[31]` **Hugo Toras**: ""We need the Houses' full cooper..."<br>`[32]` **Hugo Toras**: ""This decree risks tearing the k..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "There was a brief silence. His e..." |
| `[87]` | **""House Azaro and Sazon's elite divisions have already been mostly destroyed. This ..."** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..."<br>`[104]` **Hugo Toras**: ""We need the Houses' full cooper..." | `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[98]` **Narrator**: "There was a brief silence. His e..." |
| `[88]` | **""Don't worry about the war. I'll make sure this decree won't cripple our forces.""** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..."<br>`[104]` **Hugo Toras**: ""We need the Houses' full cooper..." | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`<br>`Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[98]` **Narrator**: "There was a brief silence. His e..." |
| `[89]` | **""I appreciate your counsel, Hugo.""** | `[95]` **Hugo Toras**: ""I will do my best to support yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_Hugo...` | `[117]` **Narrator**: "I grabbed the pen." |
| `[90]` | **""Good. Then let's get to work.""** | `[95]` **Hugo Toras**: ""I will do my best to support yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_Hugo...` | `[117]` **Narrator**: "I grabbed the pen." |
| `[91]` | **""More importantly, do I have your support?""** | `[18]` **Hugo Toras**: ""But if House Toras stands firm ..."<br>`[140]` **Hugo Toras**: ""But now that you've also remove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""Of course. As always."" |
| `[92]` | **""You may be right. But what would you have me do? Allow this fractured system to c..."** | `[32]` **Hugo Toras**: ""This decree risks tearing the k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Hugo Toras**: ""For now, yes."" |
| `[105]` | **""So you're telling me to let this go.""** | `[61]` **Hugo Toras**: ""I must counsel against this dec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Hugo Toras**: ""You have all the time in your h..." |
| `[106]` | **""Fine. I'll listen to your counsel, Hugo. I won't sign this decree for now.""** | `[31]` **Hugo Toras**: ""We need the Houses' full cooper..."<br>`[32]` **Hugo Toras**: ""This decree risks tearing the k..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "His expression loosened slightly." |
| `[112]` | **""I'm ready to take that gamble.""** | `[18]` **Hugo Toras**: ""But if House Toras stands firm ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Hugo Toras**: ""I understand."" |
| `[115]` | **""You have no choice but to respect my decision, Hugo.""** | `[99]` **Hugo Toras**: ""But if you are sure about passi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""I just want you to be careful, ..." |
| `[118]` | **"Sign the decree."** | `[117]` **Narrator**: "I grabbed the pen." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevie...` | `[109]` **Hugo Toras**: ""I'll let the others know about ..." |
| `[120]` | **""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""** | `[99]` **Hugo Toras**: ""But if you are sure about passi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Hugo Toras**: ""I understand."" |
| `[123]` | **""I appreciate your counsel, Hugo.""** | `[96]` **Hugo Toras**: ""If you sign that decree, I will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "I grabbed the pen." |
| `[124]` | **""I am sure, Hugo. Don't worry.""** | `[99]` **Hugo Toras**: ""But if you are sure about passi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""I just want you to be careful, ..." |
| `[125]` | **""As you should.""** | `[96]` **Hugo Toras**: ""If you sign that decree, I will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "I grabbed the pen." |
| `[126]` | **""Good. Then let's get to work.""** | `[96]` **Hugo Toras**: ""If you sign that decree, I will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "I grabbed the pen." |
| `[127]` | **""Thank you, Hugo.""** | `[121]` **Hugo Toras**: ""I understand, Your Majesty. Tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "He bowed and left the room." |
| `[128]` | **""I hope I'm not making a mistake.""** | `[121]` **Hugo Toras**: ""I understand, Your Majesty. Tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "He bowed and left the room." |
| `[129]` | **""I appreciate your counsel, Hugo.""** | `[121]` **Hugo Toras**: ""I understand, Your Majesty. Tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "He bowed and left the room." |
| `[131]` | **""We will see. That depends on their reaction.""** | `[95]` **Hugo Toras**: ""I will do my best to support yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_Hugo...` | `[117]` **Narrator**: "I grabbed the pen." |
| `[132]` | **""We will see. That depends on their reaction.""** | `[96]` **Hugo Toras**: ""If you sign that decree, I will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "I grabbed the pen." |
| `[141]` | **""Exactly.""** | `[140]` **Hugo Toras**: ""But now that you've also remove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "He nodded." |
| `[145]` | **""Again with the Royal Houses, Hugo?""** | `[4]` **Hugo Toras**: ""To dismantle them is to upend t..."<br>`[150]` **Hugo Toras**: ""I don't know what you're thinki..." | `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true` | *Brak zmian stanu* | `[146]` **Hugo Toras**: ""I have to bring it up again sin..." |

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
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)"*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""The provincial levies have existed for centuries, tied to the authority of the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""To dismantle them is to upend the internal balance of ou..."*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""To dismantle them is to upend the internal balance of our kingdom itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == tru..."*)
  - -> `[5]` (*Player_Romus: ""The levies are relics of feudalism. How can we claim to ..."*)
  - -> `[6]` (*Player_Romus: ""I am aware of what this decree entails, Hugo.""*)
  - -> `[7]` (*Player_Romus: ""That's exactly what I'm aiming to do.""*)
  - -> `[8]` (*Player_Romus: ""All right, Hugo. Tell me what's on your mind.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The levies are relics of feudalism. How can we claim to be united under one crown when the provinces hold the means to defy us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am aware of what this decree entails, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly what I'm aiming to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, Hugo. Tell me what's on your mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He leaned forward."*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""I understand the logic, Romus. Centralizing the military under the crown would give you unmatched control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gov..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""I understand the logic, Romus. Centralizing the military..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""I understand the logic, Romus. Centralizing the military..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""I understand the logic, Romus. Centralizing the military under the crown would standardize our forces and stop the Houses from using their levies to threaten the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_De..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_DeclareIntention_Public == false || RiziaDLC.Reform_DeclareIntention_WeakStatement == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 8  and  (Variable["RiziaDLC.Reform_DeclareIntention_Public"] == false  or  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""You underestimate the risk. This could unite the Houses ..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""But if House Toras stands firm and the others remain manageable, then perhaps this is the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I'm ready to take that gamble.""*)
  - -> `[64]` (*Player_Romus: ""Well, does House Toras stand firm, Hugo?""*)
  - -> `[65]` (*Player_Romus: ""I believe this is the right time.""*)
  - -> `[91]` (*Player_Romus: ""More importantly, do I have your support?""*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""But you must consider the ripples this will send through the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""The royal houses have grown accustomed to their autonomy..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""But to push this now, when we’re so fragile... It is mad..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""But to push this now, while we're at war with Pales... I..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""But you must consider the ripples this will send through..."*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""But to push this now, when we’re so fragile... It is madness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""The kingdom is already teetering. Unrest brews in the cities, and the whispers of revolution are growing louder than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""The unity you seek will mean nothing if our kingdom fall..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""The kingdom is already teetering. Unrest brews in the ci..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""The kingdom is already teetering. Unrest is brewing in t..."*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""We need the Houses' full cooperation to get this dissent under control, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""This decree risks tearing the kingdom apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[72]` (*Player_Romus: ""This will not weaken our forces, it will strengthen the ..."*)
  - -> `[92]` (*Player_Romus: ""You may be right. But what would you have me do? Allow t..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[74]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""The provincial levies are the backbone of our manpower. To dissolve them now would cripple our forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""The unity you seek will mean nothing if our army is crus..."*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""But to push this now, while we're at war with Pales... It makes no sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""The provincial levies are the backbone of our manpower. ..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""The kingdom is already teetering. Unrest is brewing in the cities, and we're already fighting a war with the very levies you're trying to abolish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""The unity you seek will mean nothing if our kingdom fall..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "I'm aware, Hugo. I expect resistance already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't about weakening them. It's about strengthening the kingdom as a whole.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you suggest?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can try to resist all they want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.CurrentTurn < 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.CurrentTurn < 4)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.CurrentTurn < 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.CurrentTurn"] < 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""This is a dangerous gamble so early in your reign, Your ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.CurrentTurn < 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.CurrentTurn"] < 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentSt..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.Current..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSetup.CurrentTurn"] <= 9  and  Variable["RiziaDLCSetup.CurrentStep"] <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: ""This could be a dangerous gamble before overseeing the r..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentStep <= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSetup.CurrentTurn"] <= 9  and  Variable["RiziaDLCSetup.CurrentStep"] <= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""This could be a dangerous gamble, Your Majesty.""*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""This is a dangerous gamble so early in your reign, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""The unity you seek will mean nothing if our army is crushed by Pales again. Wait until the war is won.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""This decree risks tearing the kingdom apart.""*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble before overseeing the return of Zille, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""This is a dangerous gamble while our military is already..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn <= 9 && RiziaDLCSetup.CurrentSt..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""This is a dangerous gamble while our military is already in a weak shape, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""And it could very well unite the Houses against your rule.""*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 8 && (RiziaDLC.Reform_Decl..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Especially considering the already weakened state of our..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""You underestimate the danger. The houses may seem loyal ..."*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Especially considering the already weakened state of our military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""You underestimate the danger. The houses may seem loyal ..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""The unity you seek will mean nothing if our kingdom falls. Wait until our immediate threats are dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. But what would you have me do? Allow this fractured system to continue?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSetup.CurrentTurn < 4"*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""You underestimate the danger. The houses may seem loyal now, but ordering the removal of their units will feel like a betrayal to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""I must counsel against this decree.""*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""I must counsel against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)
  - -> `[105]` (*Player_Romus: ""So you're telling me to let this go.""*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""You underestimate the risk. This could unite the Houses against your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""I must counsel against this decree.""*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""And it could very well unite the Houses against your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""I must counsel against this decree.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, does House Toras stand firm, Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[140]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""Of course. As always.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe this is the right time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[140]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He nodded."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""I just want you to be careful, Romus. Keep the other Hou..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""The royal houses have grown accustomed to their autonomy. Their levies are not just military forces; they're symbols of their power and the means to maintain their control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""To take them away will be seen as an attempt by the Crow..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""To take them away will be seen as an attempt by the Crown to render them powerless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""And they will resist that perception fiercely.""*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""And they will resist that perception fiercely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""You may be right. But what would you have me do? Allow t..."*)
  - -> `[39]` (*Player_Romus: ""They can try to resist all they want.""*)
  - -> `[36]` (*Player_Romus: "I'm aware, Hugo. I expect resistance already.""*)
  - -> `[37]` (*Player_Romus: ""This isn't about weakening them. It's about strengthenin..."*)
  - -> `[38]` (*Player_Romus: ""And what do you suggest?""*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The levies are what's tearing the kingdom apart. The sooner I get rid of them, the faster unity will be restored.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""We need the Houses' full cooperation to get this dissent..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This will not weaken our forces, it will strengthen the central administration's ability to handle the situation more swiftly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""You underestimate the risk. This could unite the Houses ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're worrying too much. We will win this war in no time. We don't need the levies.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras), `[104]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "There was a brief silence. His eyes locked onto mine, cal..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Hugo Toras), `[32]` (Hugo Toras), `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "There was a brief silence. His eyes locked onto mine. The..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_S..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""The levies are what's tearing the kingdom apart. The soo..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.W..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""You're worrying too much. We will win this war in no tim..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true || RiziaDLC.War_WehlenJoined == true || RiziaDLC.War_Objective_Captured_Terador == true || RiziaDLC.War_Objective_Captured_Pales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""Don't worry about the war. I'll make sure this decree wo..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_S..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""House Azaro and Sazon's elite divisions have already bee..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Dead > 0 && RiziaDLC.Army_Unit_Sazon_Dead > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Azaro and Sazon's elite divisions have already been mostly destroyed. This is the perfect time to sign this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0  and  Variable["RiziaDLC.Army_Unit_Sazon_Dead"] > 0` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras), `[104]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "There was a brief silence. His eyes locked onto mine, cal..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about the war. I'll make sure this decree won't cripple our forces.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true  or  Variable["RiziaDLC.War_WehlenJoined"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Terador"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Pales"] == true) == false` AND `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras), `[104]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "There was a brief silence. His eyes locked onto mine, cal..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Then let's get to work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More importantly, do I have your support?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras), `[140]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""Of course. As always.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. But what would you have me do? Allow this fractured system to continue?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""For now, yes.""*)

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""Of course. As always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""I just want you to be careful, Romus. Keep the other Hou..."*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""I just want you to be careful, Romus. Keep the other Houses close to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Hugo Toras: ""I will do my best to support you in keeping them in line.""*)

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""I will do my best to support you in keeping them in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""We will see. That depends on their reaction.""*)
  - -> `[67]` (*Player_Romus: ""Thank you, Hugo.""*)
  - -> `[89]` (*Player_Romus: ""I appreciate your counsel, Hugo.""*)
  - -> `[90]` (*Player_Romus: ""Good. Then let's get to work.""*)

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""If you sign that decree, I will do my best to support you in keeping the Houses in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""As you should.""*)
  - -> `[123]` (*Player_Romus: ""I appreciate your counsel, Hugo.""*)
  - -> `[126]` (*Player_Romus: ""Good. Then let's get to work.""*)
  - -> `[132]` (*Player_Romus: ""We will see. That depends on their reaction.""*)

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""I just want you to be careful, Romus. Try to use persuasion, not force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""If you sign that decree, I will do my best to support yo..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "There was a brief silence. His eyes locked onto mine, calculating. Then, slowly, his gaze drifted downward, settling on the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Hugo Toras: ""This could be a dangerous gamble, Your Majesty. I must s..."*)

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""But if you are sure about passing it, I will not stand in your way. I'll trust your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""I am sure, Hugo. Don't worry.""*)
  - -> `[115]` (*Player_Romus: ""You have no choice but to respect my decision, Hugo.""*)
  - -> `[120]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""For now, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""We need the Houses' full cooperation to win this war, Ro..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""We need the Houses' full cooperation to get this dissent..."*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""We need the Houses' full cooperation to win this war, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[74]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're telling me to let this go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""You have all the time in your hands, Romus.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. I'll listen to your counsel, Hugo. I won't sign this decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Hugo Toras), `[32]` (Hugo Toras), `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "His expression loosened slightly."*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "There was a brief silence. His eyes locked onto mine. Then, slowly, his gaze drifted downward, settling on the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I'll let the others know about the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Hugo Toras: ""I'll see you later.""*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""You have all the time in your hands, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""Wait for a better time.""*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""Wait for a better time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I appreciate your counsel, Hugo, but I have already deci..."*)
  - -> `[106]` (*Player_Romus: ""Fine. I'll listen to your counsel, Hugo. I won't sign th..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm ready to take that gamble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""I just want you to be careful, Romus. Keep the other Hou..."*)

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""This could be a dangerous gamble, Your Majesty. I must still counsel against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Hugo Toras: ""But if you are sure about passing it, I will not stand i..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have no choice but to respect my decision, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""I just want you to be careful, Romus. Try to use persuas..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevies");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevies");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""I'll let the others know about the changes.""*)

### Węzeł `[117]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus_Italic: "Sign the decree."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "Hugo's eyes were fixed on my hands as I placed my signature on the paper."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Order_ConscriptionLevy_RemoveProvincialLevie..."*)

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo, but I have already decided to sign this decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""I understand, Your Majesty. Thank you for listening to my counsel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""Thank you, Hugo.""*)
  - -> `[129]` (*Player_Romus: ""I appreciate your counsel, Hugo.""*)
  - -> `[128]` (*Player_Romus: ""I hope I'm not making a mistake.""*)

### Węzeł `[122]`
Mówca: **Narrator**
> "His expression loosened slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Hugo Toras: ""I understand, Your Majesty. Thank you for listening to m..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sure, Hugo. Don't worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""I just want you to be careful, Romus. Try to use persuas..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you should.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Then let's get to work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I'm not making a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see. That depends on their reaction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see. That depends on their reaction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Hugo Toras: ""You've already abolished the local police forces. Now yo..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""This decree risks tearing the kingdom apart.""*)

### Węzeł `[136]`
Mówca: **Hugo Toras**
> ""You've already abolished the local police forces. Now you would deny the provinces their armies when they need them the most?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""This decree risks tearing the kingdom apart.""*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""But now that you've also removed their local police forc..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""But if House Toras stands firm and the others remain man..."*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""But now that you've also removed their local police forces... If House Toras stands firm and the others remain manageable, perhaps this is the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Exactly.""*)
  - -> `[64]` (*Player_Romus: ""Well, does House Toras stand firm, Hugo?""*)
  - -> `[65]` (*Player_Romus: ""I believe this is the right time.""*)
  - -> `[91]` (*Player_Romus: ""More importantly, do I have your support?""*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He nodded."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == tru..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == t..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""Again with the Royal Houses, Hugo?""*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true || RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Again with the Royal Houses, Hugo?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras), `[150]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Hugo Toras: ""I have to bring it up again since you're still trying to..."*)

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""I have to bring it up again since you're still trying to damage them openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Focus_Gover..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == t..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""I'm surprised you are now considering abolishing our pro..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_IncreaseLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Hugo Toras: ""The provincial levies have existed for centuries, tied t..."*)

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""I don't know what you're thinking, Romus, but to dismantle this system is to upend the internal balance of our kingdom itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == tru..."*)
  - -> `[5]` (*Player_Romus: ""The levies are relics of feudalism. How can we claim to ..."*)
  - -> `[6]` (*Player_Romus: ""I am aware of what this decree entails, Hugo.""*)
  - -> `[7]` (*Player_Romus: ""That's exactly what I'm aiming to do.""*)
  - -> `[8]` (*Player_Romus: ""All right, Hugo. Tell me what's on your mind.""*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I'm surprised you are now considering abolishing our provincial levies after our conversation about increasing them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Hugo Toras: ""I don't know what you're thinking, Romus, but to dismant..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports =..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_CounselIgnored += 1"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RoyalDecrees_RemoveLevies_HugoSupports"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He bowed and left the room."*)
