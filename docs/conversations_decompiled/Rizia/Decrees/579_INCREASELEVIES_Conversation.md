# Rizia/INCREASELEVIES/INCREASELEVIES Conversation

- **ID konwersacji:** `579`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (INCREASELEVIES)`
- **Lokalizacja pliku:** `Rizia/Decrees/579_INCREASELEVIES_Conversation.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Said_Halaita`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[52]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Not just an increase. A doubling.""** | `[3]` **Hugo Toras**: ""I've heard that you're calling ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""I see."" |
| `[5]` | **""Yes. It's time the provinces contribute their fair share of soldiers and resource..."** | `[3]` **Hugo Toras**: ""I've heard that you're calling ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""I see."" |
| `[8]` | **""I know it is risky to give the Houses more power, but it's a necessary compromise.""** | `[3]` **Hugo Toras**: ""I've heard that you're calling ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""I see."" |
| `[9]` | **""Yes, Hugo. You heard it right.""** | `[3]` **Hugo Toras**: ""I've heard that you're calling ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Hugo Toras**: ""I see."" |
| `[23]` | **""The houses have always provided troops. If anything, more soldiers will ensure th..."** | `[22]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Hugo Toras**: ""That may be the intent, but you..." |
| `[31]` | **""No, I'm just going with my gut here.""** | `[22]` **Hugo Toras**: ""But I hope you considered in de..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5` | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[40]` **Narrator**: "Hugo narrowed his eyes, seemingl..." |
| `[33]` | **""I don't need to *consider* what's already obvious. The houses will grumble, they ..."** | `[22]` **Hugo Toras**: ""But I hope you considered in de..."<br>`[101]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Hugo Toras**: ""There's a fine line between gru..." |
| `[35]` | **""More soldiers mean stronger houses, but it also means they are more dependent on ..."** | `[22]` **Hugo Toras**: ""But I hope you considered in de..."<br>`[101]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Hugo Toras**: ""Will they, now?"" |
| `[39]` | **""It will make them more loyal in the long run. This is both their burden and their..."** | `[22]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Hugo Toras**: ""That may be the intent, but you..." |
| `[46]` | **""And what do you propose, Uncle? That we keep our forces weak? That the House armi..."** | `[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>`[44]` **Hugo Toras**: ""Handing each of these houses tw..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Hugo Toras**: ""No. I propose you stop assuming..." |
| `[47]` | **""You believe this decree could weaken the monarchy in the long run?""** | `[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>`[44]` **Hugo Toras**: ""Handing each of these houses tw..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Hugo Toras**: ""That depends on the Azaros and ..." |
| `[48]` | **""You might be right. If they try to use their troops as their personal armies rath..."** | `[64]` **Hugo Toras**: ""Because once you give a man an ..."<br>`[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""Then take the time to consider ..." |
| `[50]` | **""Naturally. Strategic foresight is overrated.""** | `[41]` **Hugo Toras**: ""Ah, of course! Who needs a Gran..."<br>`[137]` **Hugo Toras**: ""Ah, of course! The pure, God-gi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""Look..."" |
| `[51]` | **""I do pride myself on efficiency.""** | `[41]` **Hugo Toras**: ""Ah, of course! Who needs a Gran..."<br>`[137]` **Hugo Toras**: ""Ah, of course! The pure, God-gi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""Look..."" |
| `[52]` | **""I assume you came here for something other than dramatic irony, Uncle.""** | `[41]` **Hugo Toras**: ""Ah, of course! Who needs a Gran..."<br>`[77]` **Narrator**: "He bowed and left the room." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""Look..."" |
| `[65]` | **""Then I'll make sure they do.""** | `[64]` **Hugo Toras**: ""Because once you give a man an ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[80]` **Hugo Toras**: ""I surely hope so."" |
| `[66]` | **""Then I remove them before they get that chance.""** | `[64]` **Hugo Toras**: ""Because once you give a man an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "He raised an eyebrow." |
| `[67]` | **""I appreciate the words, but fear won't hold a nation together.""** | `[64]` **Hugo Toras**: ""Because once you give a man an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""No, but the absence of fear has..." |
| `[68]` | **""That's too dramatic.""** | `[64]` **Hugo Toras**: ""Because once you give a man an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Hugo Toras**: ""Say what you will. But the abse..." |
| `[79]` | **"Sign the decree."** | `[78]` **Narrator**: "I grabbed the pen."<br>`[87]` **Narrator**: "I grabbed the pen." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLev...` | `[94]` **Hugo Toras**: ""I'll let the others know about ..." |
| `[89]` | **""With all due respect, Hugo, I've already thought about this in detail and I'm awa..."** | `[22]` **Hugo Toras**: ""But I hope you considered in de..."<br>`[41]` **Hugo Toras**: ""Ah, of course! Who needs a Gran..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""I'm not here to question your a..." |
| `[90]` | **""Halaita.""** | `[41]` **Hugo Toras**: ""Ah, of course! Who needs a Gran..."<br>`[137]` **Hugo Toras**: ""Ah, of course! The pure, God-gi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[88]` **Hugo Toras**: ""Look..."" |
| `[91]` | **""I understand your concerns, Hugo, but I am certain these forces would make a diff..."** | `[101]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Hugo Toras**: ""Then by all means, sign the dec..." |
| `[92]` | **""Pales won't be conquered easily with what we have now. The royal houses have the ..."** | `[101]` **Hugo Toras**: ""But I hope you considered in de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Hugo Toras**: ""I understand."" |
| `[97]` | **""See you at dinner.""** | `[96]` **Hugo Toras**: ""I understand. Take your time."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Hugo Toras**: ""Certainly, Your Majesty."" |
| `[98]` | **""Good. Now I need a moment, if you'll excuse me.""** | `[96]` **Hugo Toras**: ""I understand. Take your time."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Hugo Toras**: ""Certainly, Your Majesty."" |
| `[99]` | **""I appreciate your counsel, Hugo.""** | `[96]` **Hugo Toras**: ""I understand. Take your time."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "He bowed and left the room." |
| `[106]` | **""You've given me a lot to consider. I'll hold off on the decree for now.""** | `[78]` **Narrator**: "I grabbed the pen." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Hugo Toras**: ""I understand. Take your time."" |
| `[110]` | **""I will. Thank you for the advice, Hugo.""** | `[108]` **Hugo Toras**: ""Just be sure that when we win, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Hugo Toras**: ""I trust your judgement."" |
| `[112]` | **""No offense, Hugo, but I tire of your assumption that I haven't thought this throu..."** | `[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>`[44]` **Hugo Toras**: ""Handing each of these houses tw..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Hugo Toras**: ""Of course not.""<br>`[57]` **Narrator**: "Hugo blinked once, then exhaled ..." |
| `[113]` | **""You don't need to worry. I have no intention of letting the Houses walk over me. ..."** | `[108]` **Hugo Toras**: ""Just be sure that when we win, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Hugo Toras**: ""There's a fine line between gru..." |
| `[114]` | **""Let's think about that after I sign this decree and win the war.""** | `[108]` **Hugo Toras**: ""Just be sure that when we win, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""That is precisely why I am here..." |
| `[118]` | **""I understand where you're coming from, but I am certain these forces are desperat..."** | `[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>`[44]` **Hugo Toras**: ""Handing each of these houses tw..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Then the decree is completely j..." |
| `[121]` | **""You might be right. I've been focused on the war effort, but I haven't considered..."** | `[64]` **Hugo Toras**: ""Because once you give a man an ..."<br>`[34]` **Hugo Toras**: ""Doubling their forces will doub..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""Then take the time to consider ..." |
| `[125]` | **""If the provinces want to keep their new forces, they'll need to stay in line.""** | `[108]` **Hugo Toras**: ""Just be sure that when we win, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Hugo Toras**: ""Will they, now?"" |
| `[134]` | **""No, I have not. I am a mere instrument of God's will.""** | `[22]` **Hugo Toras**: ""But I hope you considered in de..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5` | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[136]` **Narrator**: "Hugo narrowed his eyes, as if tr..." |

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
  - -> `[3]` (*Hugo Toras: ""I've heard that you're calling for an increase in the le..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""I assume you came here for something other than dramatic..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""I've heard that you're calling for an increase in the levy obligations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""Not just an increase. A doubling.""*)
  - -> `[5]` (*Player_Romus: ""Yes. It's time the provinces contribute their fair share..."*)
  - -> `[8]` (*Player_Romus: ""I know it is risky to give the Houses more power, but it..."*)
  - -> `[9]` (*Player_Romus: ""Yes, Hugo. You heard it right.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not just an increase. A doubling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""I see.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's time the provinces contribute their fair share of soldiers and resources for the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""I see.""*)

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""That may be the intent, but you're also giving the noble houses more leverage than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""Doubling their forces will double their influence as well.""*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""There's no denying that a stronger army is an asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know it is risky to give the Houses more power, but it's a necessary compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""I see.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo. You heard it right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""I see.""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "He leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""There's no denying we need a stronger force to end the P..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""There's no denying that a stronger army is an asset.""*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Especially given our current circumstances as the weakest military power in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""Especially given our current circumstances as the weakes..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""Especially given that all our neighbors possess stronger..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Especially given that all our neighbors possess stronger militaries than ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""But I hope you considered in detail what this will mean for the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""The houses have always provided troops. If anything, mor..."*)
  - -> `[35]` (*Player_Romus: ""More soldiers mean stronger houses, but it also means th..."*)
  - -> `[33]` (*Player_Romus: ""I don't need to *consider* what's already obvious. The h..."*)
  - -> `[39]` (*Player_Romus: ""It will make them more loyal in the long run. This is bo..."*)
  - -> `[89]` (*Player_Romus: ""With all due respect, Hugo, I've already thought about t..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Current..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.Cur..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The houses have always provided troops. If anything, more soldiers will ensure that every region is prepared should the kingdom face a threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Hugo Toras: ""That may be the intent, but you're also giving the noble..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""And I understand this could also be helpful against the ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""But I hope you considered in detail what this will mean ..."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""And I understand this could also be helpful against the unrest we're facing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""But I hope you considered in detail what this will mean ..."*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""There's no denying we need a stronger force to end the Pales invasion quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""If you're certain these forces would make a difference i..."*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true"*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""If you're certain these forces would make a difference in the ground operations, this would be the right call. We need numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'm just going with my gut here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Then take the time to consider it, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""You lose nothing by thinking twice, but you risk everyth..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to *consider* what's already obvious. The houses will grumble, they always do. But they will comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""There's a fine line between grumbling and resisting, Rom..."*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""Doubling their forces will double their influence as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More soldiers mean stronger houses, but it also means they are more dependent on the Crown. If they want to keep their new forces, they'll need to stay in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""Will they, now?""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Current..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Curre..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""No, I'm just going with my gut here.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will make them more loyal in the long run. This is both their burden and their reward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Hugo Toras: ""That may be the intent, but you're also giving the noble..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Hugo narrowed his eyes, seemingly unimpressed by my sarcasm. A forceful smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""Ah, of course! Who needs a Grand Vizier when one has int..."*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""Ah, of course! Who needs a Grand Vizier when one has intestines?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""With all due respect, Hugo, I've already thought about t..."*)
  - -> `[51]` (*Player_Romus: ""I do pride myself on efficiency.""*)
  - -> `[50]` (*Player_Romus: ""Naturally. Strategic foresight is overrated.""*)
  - -> `[52]` (*Player_Romus: ""I assume you came here for something other than dramatic..."*)
  - -> `[90]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""There's a fine line between grumbling and resisting, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""Handing each of these houses twice the number of soldier..."*)

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""Will they, now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Handing each of these houses twice the number of soldier..."*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Handing each of these houses twice the number of soldiers under their personal command only empowers them to do the opposite of 'falling in line.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""Handing each of these houses twice the number of soldiers under their personal command is the very thing that could make 'grumbling' turn into something far worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you propose, Uncle? That we keep our forces weak? That the House armies stay tiny and underequipped while threats gather on our borders?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""No. I propose you stop assuming their compliance is guar..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You believe this decree could weaken the monarchy in the long run?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""That depends on the Azaros and the Sazons. And on you.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might be right. If they try to use their troops as their personal armies rather than the kingdom's forces, then we'll have a problem.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras), `[34]` (Hugo Toras), `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""Then take the time to consider it, Romus.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[47]` (*Player_Romus: ""You believe this decree could weaken the monarchy in the..."*)
  - -> `[46]` (*Player_Romus: ""And what do you propose, Uncle? That we keep our forces ..."*)
  - -> `[112]` (*Player_Romus: ""No offense, Hugo, but I tire of your assumption that I h..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Naturally. Strategic foresight is overrated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Hugo Toras), `[137]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Look...""*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do pride myself on efficiency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Hugo Toras), `[137]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Look...""*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assume you came here for something other than dramatic irony, Uncle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Hugo Toras), `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Look...""*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""I'm not here to question your authority. But I must remind you that this decree doesn't only increase our forces. It shifts power in ways we can't control once the ink is dry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""I'm only here to challenge you before your enemies do.""*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I'm only here to challenge you before your enemies do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""That depends on the Azaros and the Sazons. And on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""Because once you give a man an army, the only thing stop..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Then the decree is completely justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""I trust your judgement.""*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Hugo blinked once, then exhaled slowly, pressing his lips together as if physically holding back a response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""You're the king, Romus. No one is saying you haven’t tho..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""You're the king, Romus. No one is saying you haven’t thought this through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""I will speak of this no more.""*)

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Hugo Toras: ""I trust your judgement.""*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Say what you will. But the absence of fear has toppled more kings than I can count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I'm here to challenge you before your enemies do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""That is precisely why I am here. So you do not ignore the potential fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I'm here to challenge you before your enemies do.""*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Because once you give a man an army, the only thing stopping him from using it is whether he fears you enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""Then I'll make sure they do.""*)
  - -> `[66]` (*Player_Romus: ""Then I remove them before they get that chance.""*)
  - -> `[67]` (*Player_Romus: ""I appreciate the words, but fear won't hold a nation tog..."*)
  - -> `[68]` (*Player_Romus: ""That's too dramatic.""*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I'll make sure they do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I remove them before they get that chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "He raised an eyebrow."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the words, but fear won't hold a nation together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""No, but the absence of fear has toppled more kings than ..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's too dramatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""Say what you will. But the absence of fear has toppled m..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""No, but the absence of fear has toppled more kings than I can count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalVa..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""Of course not.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Hugo blinked once, then exhaled slowly, pressing his lips..."*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""You're the king, Romus. No one is saying you haven’t tho..."*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""You lose nothing by thinking twice, but you risk everything by acting too soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""The trouble with preemptive strikes, Romus, is that they..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""The trouble with preemptive strikes, Romus, is that they teach others to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[106]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "Hugo's eyes were fixed on my hands as I placed my signature on the paper."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLev..."*)

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""I surely hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""But I understand the situation we're in. This decree wil..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""But I trust your judgement.""*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""But I understand the situation we're in. This decree will indeed be helpful with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Hugo Toras: ""I trust your judgement.""*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""But I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I grabbed the pen."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "I grabbed the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Sign the decree."*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""Look...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I'm not here to question your authority. But I must remi..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all due respect, Hugo, I've already thought about this in detail and I'm aware of the potential consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[41]` (Hugo Toras), `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I'm not here to question your authority. But I must remi..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Hugo Toras), `[137]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your concerns, Hugo, but I am certain these forces would make a difference in Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""Then by all means, sign the decree.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales won't be conquered easily with what we have now. The royal houses have the manpower. We should use it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLevies");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Order_ConscriptionLevy_IncreaseProvincialLevies");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""I'll let the others know about the changes.""*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""I'll let the others know about the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Hugo Toras: ""Until next time.""*)

### Węzeł `[95]`
Mówca: **Hugo Toras**
> ""Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""I understand. Take your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""I appreciate your counsel, Hugo.""*)
  - -> `[97]` (*Player_Romus: ""See you at dinner.""*)
  - -> `[98]` (*Player_Romus: ""Good. Now I need a moment, if you'll excuse me.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you at dinner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""Certainly, Your Majesty.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now I need a moment, if you'll excuse me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""Certainly, Your Majesty.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your counsel, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""But I hope you considered in detail what this will mean for the royal houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""I understand your concerns, Hugo, but I am certain these..."*)
  - -> `[92]` (*Player_Romus: ""Pales won't be conquered easily with what we have now. T..."*)
  - -> `[35]` (*Player_Romus: ""More soldiers mean stronger houses, but it also means th..."*)
  - -> `[33]` (*Player_Romus: ""I don't need to *consider* what's already obvious. The h..."*)
  - -> `[89]` (*Player_Romus: ""With all due respect, Hugo, I've already thought about t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""And I understand this could also be helpful against the ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""But I hope you considered in detail what this will mean ..."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""And I understand this could also be helpful against the unrest we're facing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""But I hope you considered in detail what this will mean ..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""I understand. Take your time.""*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""No. I propose you stop assuming their compliance is guaranteed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""Because once you give a man an army, the only thing stop..."*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""Just be sure that when we win, these forces answer to you, not the Houses who command them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""You don't need to worry. I have no intention of letting ..."*)
  - -> `[114]` (*Player_Romus: ""Let's think about that after I sign this decree and win ..."*)
  - -> `[110]` (*Player_Romus: ""I will. Thank you for the advice, Hugo.""*)
  - -> `[125]` (*Player_Romus: ""If the provinces want to keep their new forces, they'll ..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""Then by all means, sign the decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""Just be sure that when we win, these forces answer to yo..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Thank you for the advice, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""I trust your judgement.""*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""Just be sure that when we win, these forces answer to yo..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No offense, Hugo, but I tire of your assumption that I haven't thought this through. Do you believe I draft decrees in a drunken stupor?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to worry. I have no intention of letting the Houses walk over me. They may grumble, but they will comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""There's a fine line between grumbling and resisting, Rom..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's think about that after I sign this decree and win the war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""That is precisely why I am here. So you do not ignore th..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""I understand where you're coming from, but I am certain ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand where you're coming from, but I am certain these forces are desperately needed for the war effort.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[44]` (Hugo Toras), `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Then the decree is completely justified.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Look...""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Hugo narrowed his eyes, seemingly unimpressed by my sarca..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might be right. I've been focused on the war effort, but I haven't considered what happens after the war.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[64]` (Hugo Toras), `[34]` (Hugo Toras), `[44]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""Then take the time to consider it, Romus.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""You might be right. I've been focused on the war effort,..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""You might be right. If they try to use their troops as t..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the provinces want to keep their new forces, they'll need to stay in line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""Will they, now?""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Hugo Toras: ""I'm a little surprised.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_AbolishLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He leaned forward."*)

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""I wouldn't have expected that after our discussion where you were considering abolishing the levies altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He leaned forward."*)

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""I'm a little surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Hugo Toras: ""I wouldn't have expected that after our discussion where..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.Cur..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.C..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""No, I have not. I am a mere instrument of God's will.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true || RiziaDLCSetup.CurrentTurn < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I have not. I am a mere instrument of God's will.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Hugo narrowed his eyes, as if trying to determine whether..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Hugo narrowed his eyes, as if trying to determine whether I was serious. A forceful smile appeared on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Hugo Toras: ""Ah, of course! The pure, God-given instincts of the King.""*)

### Węzeł `[137]`
Mówca: **Hugo Toras**
> ""Ah, of course! The pure, God-given instincts of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""With all due respect, Hugo, I've already thought about t..."*)
  - -> `[51]` (*Player_Romus: ""I do pride myself on efficiency.""*)
  - -> `[50]` (*Player_Romus: ""Naturally. Strategic foresight is overrated.""*)
  - -> `[90]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Hugo Toras: ""I surely hope so.""*)
