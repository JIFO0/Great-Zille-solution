# Sordland/Turn08/ValgslandVisit_DefaultRayne

- **ID konwersacji:** `164`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/164_ValgslandVisit_DefaultRayne.md`
- **Liczba węzłów dialogowych:** 309
- **Liczba wyborów gracza:** 62

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[26]** Emmerich Hegel

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Economy`
- `BaseGame.Reform_Autocrat_CourtVote_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Hegel_PutInAGoodWordWithMalenyev`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“What was that about?”"** | `[198]` **Emmerich Hegel**: "“Sorry about that. You know how ..."<br>`[9]` **Narrator**: "We shook hands and Hegel left in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Emmerich Hegel**: "“A director of a foreign joint-v..." |
| `[4]` | **"“Of course, Chancellor Hegel. It was a pleasure.”"** | `[13]` **Emmerich Hegel**: "“Mr. Rayne, I'm afraid you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Emmerich Hegel**: "“The pleasure is mine.”" |
| `[15]` | **"“Good luck.”"** | `[13]` **Emmerich Hegel**: "“Mr. Rayne, I'm afraid you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Emmerich Hegel**: "“Thank you.”" |
| `[16]` | **"“Is there anything I can help with?”"** | `[13]` **Emmerich Hegel**: "“Mr. Rayne, I'm afraid you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Emmerich Hegel**: "“Thank you for the offer, but no.”" |
| `[26]` | **"“So. Where do we begin?”"** | `[25]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "He gestured towards the painting." |
| `[27]` | **"“Likewise.”"** | `[25]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "He gestured towards the painting." |
| `[28]` | **"“It's a pleasure to finally meet with you, Chancellor Hegel.”"** | `[25]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "He gestured towards the painting." |
| `[45]` | **"“Why not?”"** | `[43]` **Emmerich Hegel**: "“Hell! Bring the bottle!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Emmerich Hegel**: "“There we go!”" |
| `[46]` | **"“Thank you for the offer, but there is only so much vodka I can drink before lunch.”"** | `[43]` **Emmerich Hegel**: "“Hell! Bring the bottle!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "He laughed loudly." |
| `[50]` | **"“We don't need external threats to make a deal with one of our oldest neighbors.”"** | `[30]` **Emmerich Hegel**: "“Does this have anything to do w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Emmerich Hegel**: "“Well said!”" |
| `[52]` | **"“Absolutely not. Sordland can defend itself just fine.”"** | `[30]` **Emmerich Hegel**: "“Does this have anything to do w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Emmerich Hegel**: "“If you say that, I believe you.”" |
| `[53]` | **"“It does.”"** | `[30]` **Emmerich Hegel**: "“Does this have anything to do w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Emmerich Hegel**: "“A blunt answer.”" |
| `[60]` | **"“It is a reminder. One misstep and we are back to painting the world with more blo..."** | `[48]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Emmerich Hegel**: "“As the leaders of this world, w..." |
| `[62]` | **"“Nothing. It's just a painting.”"** | `[48]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Emmerich Hegel**: "“Certainly a fair viewpoint, Mr...." |
| `[63]` | **"“I think that we have come far. After all, we are standing here side by side inste..."** | `[48]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Emmerich Hegel**: "“We can do so much more through ..." |
| `[75]` | **"“Why should you not? What do you have to lose?”"** | `[154]` **Emmerich Hegel**: "“Why should I accept this deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Emmerich Hegel**: "“You are answering my question w..." |
| `[84]` | **"“Since we have come this far, I am not opposed to the idea of an alliance.”"** | `[93]` **Narrator**: "He took another puff from his pipe." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Emmerich Hegel**: "“An alliance, you say.”" |
| `[85]` | **"“I know you are a busy man. Thank you for your time today, Chancellor Hegel.”"** | `[93]` **Narrator**: "He took another puff from his pipe." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Emmerich Hegel**: "“Thank you for coming, Mr. Rayne.”" |
| `[86]` | **"“I want an alliance, Chancellor Hegel. I want to revive the brotherhood of old!”"** | `[93]` **Narrator**: "He took another puff from his pipe." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Narrator**: "He turned to me and put his hand..." |
| `[88]` | **"“It is the first step towards improving the ties between our nations.”"** | `[154]` **Emmerich Hegel**: "“Why should I accept this deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Emmerich Hegel**: "“Does this have anything to do w..." |
| `[92]` | **"“More trade means more money circulation. Undoubtedly it will help both of our nat..."** | `[154]` **Emmerich Hegel**: "“Why should I accept this deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Emmerich Hegel**: "“So you want to keep improving y..."<br>`[59]` **Emmerich Hegel**: "“So you want to get rid of that ..." |
| `[97]` | **"“My thoughts exactly.”"** | `[90]` **Emmerich Hegel**: "“No two countries in the world u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "He nodded and pointed towards an..." |
| `[98]` | **"“It is great to hear these important words coming from you.”"** | `[90]` **Emmerich Hegel**: "“No two countries in the world u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "He nodded and pointed towards an..." |
| `[101]` | **"“Let's hope we can stay that way.”"** | `[90]` **Emmerich Hegel**: "“No two countries in the world u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Emmerich Hegel**: "“I am hopeful.”" |
| `[103]` | **"“I want to align Sordland closer with the CSP.”"** | `[154]` **Emmerich Hegel**: "“Why should I accept this deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Emmerich Hegel**: "“A blunt answer. I like it. It g..." |
| `[120]` | **"“Very well. I accept.”"** | `[122]` **Emmerich Hegel**: "“That's why.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true...`<br>`Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = t...`<br>*(+1 skryptów)* | `[108]` **Emmerich Hegel**: "“We have achieved a lot today, M..." |
| `[134]` | **"“Past is past. We need to look into the future.”"** | `[124]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Emmerich Hegel**: "“I agree completely.”" |
| `[135]` | **"“We shouldn't bear the sins of our forefathers.”"** | `[124]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Emmerich Hegel**: "“Well said, Mr. Rayne.”" |
| `[137]` | **"“We will never forget the extremely shameful display by the Valgslandian navy. ”"** | `[124]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Emmerich Hegel**: "“We will never forget the sins o..." |
| `[170]` | **"“Very well. I accept.”"** | `[190]` **Emmerich Hegel**: "“That's why.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true...`<br>`Variable["BaseGame.Valgsland_TradeDeal"] = true;`<br>*(+1 skryptów)* | `[146]` **Emmerich Hegel**: "“We have achieved a lot today, M..." |
| `[177]` | **"“I would slaughter them just like they slaughtered us!”"** | `[176]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Emmerich Hegel**: "“Exactly!”" |
| `[178]` | **"“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"** | `[176]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Emmerich Hegel**: "“Valgsland is being attacked!”" |
| `[179]` | **"“I would approach the matter diplomatically. Surely a middle way can be found.”"** | `[176]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Emmerich Hegel**: "“Middle way?”" |
| `[199]` | **"“Let's move on with the scheduled program.”"** | `[198]` **Emmerich Hegel**: "“Sorry about that. You know how ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Emmerich Hegel**: "“Sure.”" |
| `[205]` | **"“I definitely do.”"** | `[198]` **Emmerich Hegel**: "“Sorry about that. You know how ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Emmerich Hegel**: "“Revolution is a slow process, M..." |
| `[221]` | **"“Why do you want this from me?”"** | `[227]` **Emmerich Hegel**: "“It's that simple.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Emmerich Hegel**: "“Mr. Rayne. Are you not reading ..." |
| `[222]` | **"“I won't meddle in the affairs between Valgsland and Agnolia.”"** | `[122]` **Emmerich Hegel**: "“That's why.”"<br>`[227]` **Emmerich Hegel**: "“It's that simple.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Emmerich Hegel**: "“So you've decided to stay neutr..." |
| `[223]` | **"“An easy choice. I accept.”"** | `[227]` **Emmerich Hegel**: "“It's that simple.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true...`<br>`Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = t...`<br>*(+1 skryptów)* | `[108]` **Emmerich Hegel**: "“We have achieved a lot today, M..." |
| `[224]` | **"“I would slaughter them just like they slaughtered us!”"** | `[231]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Emmerich Hegel**: "“Exactly!”" |
| `[225]` | **"“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"** | `[231]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Emmerich Hegel**: "“Valgsland is being attacked!”" |
| `[226]` | **"“I would approach the matter diplomatically. Surely a middle way can be found.”"** | `[231]` **Emmerich Hegel**: "“Imagine they did that to Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Emmerich Hegel**: "“Middle way?”" |
| `[229]` | **"“Then I will make it worth your while.”"** | `[181]` **Emmerich Hegel**: "“If I accept this deal, I will l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Emmerich Hegel**: "“Oh?”" |
| `[232]` | **"“Everything has a price, Chancellor Hegel. What is yours?”"** | `[181]` **Emmerich Hegel**: "“If I accept this deal, I will l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Emmerich Hegel**: "“You speak like the oligarchs we..." |
| `[233]` | **"“Why is Valgsland so concerned with Sordland making deals with its neighbors?”"** | `[181]` **Emmerich Hegel**: "“If I accept this deal, I will l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Emmerich Hegel**: "“Please do not waste my time wit..." |
| `[234]` | **"“Let's talk about business, shall we?”"** | `[230]` **Narrator**: "Smoked bear meat, a local delica..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Narrator**: "An assistant brought in two cups..." |
| `[236]` | **"“What can you tell me about Malenyev?”"** | `[230]` **Narrator**: "Smoked bear meat, a local delica..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Emmerich Hegel**: "“Ah. You have spotted the portra..." |
| `[245]` | **"“What do you want? Tell it to me straight.”"** | `[251]` **Emmerich Hegel**: "“But I can put in a good word in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Emmerich Hegel**: "“Recognize Heljiland as Valgslan..." |
| `[246]` | **"“I'm listening.”"** | `[251]` **Emmerich Hegel**: "“But I can put in a good word in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Emmerich Hegel**: "“Recognize Heljiland as Valgslan..." |
| `[247]` | **"“Anything to join the pact.”"** | `[251]` **Emmerich Hegel**: "“But I can put in a good word in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Emmerich Hegel**: "“Recognize Heljiland as Valgslan..." |
| `[258]` | **"“Whatever. He is still just a man.”"** | `[297]` **Emmerich Hegel**: "“However, our revolution here in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Narrator**: "He burst into laughter." |
| `[259]` | **"“Why do you want this from me?”"** | `[264]` **Emmerich Hegel**: "“I want you to recognize Heljila..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Emmerich Hegel**: "“Mr. Rayne. Are you not reading ..." |
| `[260]` | **"“An easy choice. I accept.”"** | `[264]` **Emmerich Hegel**: "“I want you to recognize Heljila..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true...`<br>`Variable["BaseGame.Valgsland_TradeDeal"] = true;`<br>*(+1 skryptów)* | `[146]` **Emmerich Hegel**: "“We have achieved a lot today, M..." |
| `[261]` | **"“I won't meddle in the affairs between Valgsland and Agnolia.”"** | `[190]` **Emmerich Hegel**: "“That's why.”"<br>`[264]` **Emmerich Hegel**: "“I want you to recognize Heljila..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Emmerich Hegel**: "“So you've decided to stay neutr..." |
| `[266]` | **"“He seems like an interesting person. I would like to meet with him.”"** | `[297]` **Emmerich Hegel**: "“However, our revolution here in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Emmerich Hegel**: "“Perhaps one day you will.”" |
| `[277]` | **"“What do I have to do?”"** | `[211]` **Emmerich Hegel**: "“Now. If you wish to join the CS..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Emmerich Hegel**: "“Comrade Malenyev is a good frie..." |
| `[278]` | **"“Go on.”"** | `[211]` **Emmerich Hegel**: "“Now. If you wish to join the CS..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Emmerich Hegel**: "“Comrade Malenyev is a good frie..." |
| `[284]` | **"“That is none of your concern, Chancellor Hegel.”"** | `[288]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Emmerich Hegel**: "“It is precisely my concern. I w..." |
| `[290]` | **"“Nothing to worry about, Chancellor Hegel. Everything has been handled.”"** | `[288]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Emmerich Hegel**: "“Very well.”" |
| `[292]` | **"“Let's change the topic.”"** | `[288]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Emmerich Hegel**: "“Very well.”" |
| `[293]` | **"“There is nothing to worry about in terms of our trade deal.”"** | `[291]` **Emmerich Hegel**: "“It is precisely my concern. I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Emmerich Hegel**: "“If you say so...”" |
| `[294]` | **"“Who says Sordland is unstable? We're the most stable country there is.”"** | `[291]` **Emmerich Hegel**: "“It is precisely my concern. I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Emmerich Hegel**: "“If you say so...”" |
| `[295]` | **"“I understand, Chancellor Hegel. Rest assured I have the situation under control.”"** | `[291]` **Emmerich Hegel**: "“It is precisely my concern. I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Emmerich Hegel**: "“If you say so...”" |

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
  - -> `[18]` (*Narrator: "We shook hands."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“What was that about?”"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "“What was that about?”"]** — Mówca: **Player**
> "“What was that about?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel), `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Emmerich Hegel: "“A director of a foreign joint-venture mining corporation..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Of course, Chancellor Hegel. It was a pleasure.”"]** — Mówca: **Player**
> "“Of course, Chancellor Hegel. It was a pleasure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Emmerich Hegel: "“The pleasure is mine.”"*)

### Węzeł `[5]`
Mówca: **Emmerich Hegel**
> "“The pleasure is mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from the pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Emmerich Hegel: "“For the sake of our conversation, let's say that there i..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "As the assistant collected the empty glasses, he whispered into Hegel's ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Hegel's eyes widened and he clenched his fists in anger."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Hegel's eyes widened and he clenched his fists in anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Emmerich Hegel: "“The Agnolians did what?!”"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "We shook hands and Hegel left in a hurry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[10]`
Mówca: **Emmerich Hegel**
> "“The Agnolians did what?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He composed himself and smiled at me."*)

### Węzeł `[11]`
Mówca: **Emmerich Hegel**
> "“Thank you for the offer, but no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He composed himself and smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Emmerich Hegel: "“Mr. Rayne, I'm afraid you will have to excuse me. There ..."*)

### Węzeł `[13]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne, I'm afraid you will have to excuse me. There is a matter I need to attend to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "“Of course, Chancellor Hegel. It was a pleasure.”"*)
  - -> `[16]` (*Player: "“Is there anything I can help with?”"*)
  - -> `[15]` (*Player: "“Good luck.”"*)

### Węzeł `[14]`
Mówca: **Emmerich Hegel**
> "“Have a good day and enjoy Haelm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "We shook hands and Hegel left in a hurry."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Emmerich Hegel: "“Thank you.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Is there anything I can help with?”"]** — Mówca: **Player**
> "“Is there anything I can help with?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Emmerich Hegel: "“Thank you for the offer, but no.”"*)

### Węzeł `[17]`
Mówca: **Emmerich Hegel**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Emmerich Hegel: "“Mr. Rayne. Welcome to Valgsland. It is good to finally m..."*)

### Węzeł `[19]`
Mówca: **Emmerich Hegel**
> "“If you will excuse me for one minute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He stepped away with the guard while I looked around. I s..."*)

### Węzeł `[20]`
Mówca: **Emmerich Hegel**
> "“You are answering my question with a question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 6)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Emmerich Hegel: "“So you want to keep improving your economy after all tho..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Emmerich Hegel: "“So you want to get rid of that recession of yours then.”"*)

### Węzeł `[24]`
Mówca: **Emmerich Hegel**
> "“Thankfully, we in Valgsland have now cut off the head of the snake called imperialism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "A guard approached the Chancellor."*)

### Węzeł `[25]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Welcome to Valgsland. It is good to finally meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“It's a pleasure to finally meet with you, Chancellor Heg..."*)
  - -> `[27]` (*Player: "“Likewise.”"*)
  - -> `[26]` (*Player: "“So. Where do we begin?”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“So. Where do we begin?”"]** — Mówca: **Player**
> "“So. Where do we begin?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Likewise.”"]** — Mówca: **Player**
> "“Likewise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's a pleasure to finally meet with you, Chancellor Hegel.”"]** — Mówca: **Player**
> "“It's a pleasure to finally meet with you, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[29]`
Mówca: **Emmerich Hegel**
> "“A strong argument.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "He leaned back in his chair and took another puff from hi..."*)

### Węzeł `[30]`
Mówca: **Emmerich Hegel**
> "“Does this have anything to do with the growing threat of Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“It does.”"*)
  - -> `[52]` (*Player: "“Absolutely not. Sordland can defend itself just fine.”"*)
  - -> `[50]` (*Player: "“We don't need external threats to make a deal with one o..."*)

### Węzeł `[31]`
Mówca: **Emmerich Hegel**
> "“A blunt answer. I like it. It gives me confidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Emmerich Hegel: "“But so far, you haven't done much to justify such an ali..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He gestured towards the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Emmerich Hegel: "“This was made in 1776 by the famous Valgslandian painter..."*)

### Węzeł `[33]`
Mówca: **Emmerich Hegel**
> "“No country in this world is completely isolated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Emmerich Hegel: "“I have to protect my nation, and to do so I will concern..."*)

### Węzeł `[34]`
Mówca: **Emmerich Hegel**
> "“This was made in 1776 by the famous Valgslandian painter, Otto Kiebern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "I looked at the painting. It must've been over five meter..."*)

### Węzeł `[35]`
Mówca: **Emmerich Hegel**
> "“You and I can do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Emmerich Hegel: "“I will accept the trade deal.”"*)

### Węzeł `[36]`
Mówca: **Emmerich Hegel**
> "“Another round!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The assistants brought two more shots. We drank them in o..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The assistants brought two more shots. We drank them in one go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Emmerich Hegel: "“We must celebrate!”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Emmerich Hegel: "“What do I have to lose?”"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Hegel chuckled."*)

### Węzeł `[41]`
Mówca: **Emmerich Hegel**
> "“We must celebrate!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Emmerich Hegel: "“Hell! Bring the bottle!”"*)

### Węzeł `[42]`
Mówca: **Narrator**
> "I looked at the painting. It must've been over five meters tall. It was a battle scene. On the left side there were banners carried by Valgs; on the right, Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Countless spears formed a triangle at the center. The sky..."*)

### Węzeł `[43]`
Mówca: **Emmerich Hegel**
> "“Hell! Bring the bottle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Thank you for the offer, but there is only so much vodka..."*)
  - -> `[45]` (*Player: "“Why not?”"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Countless spears formed a triangle at the center. The sky was red from the blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Emmerich Hegel: "“What do you think about it?”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Why not?”"]** — Mówca: **Player**
> "“Why not?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Emmerich Hegel: "“There we go!”"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Thank you for the offer, but there is only so much vodka I can drink before lunch.”"]** — Mówca: **Player**
> "“Thank you for the offer, but there is only so much vodka I can drink before lunch.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "He laughed loudly."*)

### Węzeł `[47]`
Mówca: **Emmerich Hegel**
> "“But so far, you haven't done much to justify such an alignment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel: "“If your actions matched your words, this could've gone d..."*)

### Węzeł `[48]`
Mówca: **Emmerich Hegel**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“I think that we have come far. After all, we are standin..."*)
  - -> `[62]` (*Player: "“Nothing. It's just a painting.”"*)
  - -> `[60]` (*Player: "“It is a reminder. One misstep and we are back to paintin..."*)

### Węzeł `[49]`
Mówca: **Emmerich Hegel**
> "“There we go!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“We don't need external threats to make a deal with one of our oldest neighbors.”"]** — Mówca: **Player**
> "“We don't need external threats to make a deal with one of our oldest neighbors.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Emmerich Hegel: "“Well said!”"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "He laughed loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Absolutely not. Sordland can defend itself just fine.”"]** — Mówca: **Player**
> "“Absolutely not. Sordland can defend itself just fine.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Emmerich Hegel: "“If you say that, I believe you.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“It does.”"]** — Mówca: **Player**
> "“It does.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Emmerich Hegel: "“A blunt answer.”"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "We clinked the glasses and did our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The strong bite of alcohol turned into a sweeter aftertaste."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "We shook hands and he pulled me in for a hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance = ..."*)

### Węzeł `[57]`
Mówca: **Emmerich Hegel**
> "“So you want to keep improving your economy after all those long years of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Emmerich Hegel: "“A valid point.”"*)

### Węzeł `[58]`
Mówca: **Emmerich Hegel**
> "“This is great news!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Emmerich Hegel: "“Another round!”"*)

### Węzeł `[59]`
Mówca: **Emmerich Hegel**
> "“So you want to get rid of that recession of yours then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Emmerich Hegel: "“A valid point.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It is a reminder. One misstep and we are back to painting the world with more blood.”"]** — Mówca: **Player**
> "“It is a reminder. One misstep and we are back to painting the world with more blood.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Emmerich Hegel: "“As the leaders of this world, we must be careful, Mr. Ra..."*)

### Węzeł `[61]`
Mówca: **Emmerich Hegel**
> "“I accept, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "We shook hands and he pulled me in for a hug."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Nothing. It's just a painting.”"]** — Mówca: **Player**
> "“Nothing. It's just a painting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Emmerich Hegel: "“Certainly a fair viewpoint, Mr. Rayne.”"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"]** — Mówca: **Player**
> "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Emmerich Hegel: "“We can do so much more through unity, Mr. Rayne.”"*)

### Węzeł `[64]`
Mówca: **Emmerich Hegel**
> "“This time, Sords and Valgs will stand side by side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Emmerich Hegel: "“I gladly accept, Mr. Rayne.”"*)

### Węzeł `[65]`
Mówca: **Emmerich Hegel**
> "“As the leaders of this world, we must be careful, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Emmerich Hegel: "“Especially around those who are willing and ready to do ..."*)

### Węzeł `[66]`
Mówca: **Emmerich Hegel**
> "“I gladly accept, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "We shook hands and he pulled me in for a hug."*)

### Węzeł `[67]`
Mówca: **Emmerich Hegel**
> "“Certainly a fair viewpoint, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "We started walking."*)

### Węzeł `[68]`
Mówca: **Emmerich Hegel**
> "“This time we will not be on opposing sides of history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Emmerich Hegel: "“This time, Sords and Valgs will stand side by side.”"*)

### Węzeł `[69]`
Mówca: **Emmerich Hegel**
> "“This time, Sords and Valgs will stand side by side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Emmerich Hegel: "“I accept, Mr. Rayne.”"*)

### Węzeł `[70]`
Mówca: **Emmerich Hegel**
> "“We can do so much more through unity, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "We started walking."*)

### Węzeł `[71]`
Mówca: **Emmerich Hegel**
> "“What did you say?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Hegel's loud voice echoed in the empty halls."*)

### Węzeł `[72]`
Mówca: **Emmerich Hegel**
> "“If your actions matched your words, this could've gone differently. But let's not talk about what could have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Emmerich Hegel: "“I will accept the deal on the basis of your sincerity.”"*)

### Węzeł `[73]`
Mówca: **Emmerich Hegel**
> "“Yes! This time we will not be on opposing sides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Emmerich Hegel: "“This time, Sords and Valgs will stand side by side.”"*)

### Węzeł `[74]`
Mówca: **Emmerich Hegel**
> "“We have much to gain from an alliance between our two nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Emmerich Hegel: "“This time we will not be on opposing sides of history.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Why should you not? What do you have to lose?”"]** — Mówca: **Player**
> "“Why should you not? What do you have to lose?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Emmerich Hegel: "“You are answering my question with a question.”"*)

### Węzeł `[76]`
Mówca: **Emmerich Hegel**
> "“I have been watching Sordland's development with worry over the last few years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel: "“Since you are so focused on the economic aspect, let me ..."*)

### Węzeł `[77]`
Mówca: **Emmerich Hegel**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Emmerich Hegel: "“Yes! This time we will not be on opposing sides.”"*)

### Węzeł `[78]`
Mówca: **Emmerich Hegel**
> "“Especially around those who are willing and ready to do precisely that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "We started walking."*)

### Węzeł `[79]`
Mówca: **Emmerich Hegel**
> "“It would be a bit quick, but I am not opposed either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Emmerich Hegel: "“We have much to gain from an alliance between our two na..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Emmerich Hegel: "“To me, this painting tells me how far we have come. Sord..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "He turned to me and put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Emmerich Hegel: "“Yes.”"*)

### Węzeł `[82]`
Mówca: **Emmerich Hegel**
> "“An alliance, you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Emmerich Hegel: "“It would be a bit quick, but I am not opposed either.”"*)

### Węzeł `[83]`
Mówca: **Emmerich Hegel**
> "“Thank you for coming, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Since we have come this far, I am not opposed to the idea of an alliance.”"]** — Mówca: **Player**
> "“Since we have come this far, I am not opposed to the idea of an alliance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Emmerich Hegel: "“An alliance, you say.”"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“I know you are a busy man. Thank you for your time today, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I know you are a busy man. Thank you for your time today, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Emmerich Hegel: "“Thank you for coming, Mr. Rayne.”"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“I want an alliance, Chancellor Hegel. I want to revive the brotherhood of old!”"]** — Mówca: **Player**
> "“I want an alliance, Chancellor Hegel. I want to revive our brotherhood of old!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He turned to me and put his hand on my shoulder."*)

### Węzeł `[87]`
Mówca: **Emmerich Hegel**
> "“A valid point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel: "“I have been watching Sordland's development with worry o..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“It is the first step towards improving the ties between our nations.”"]** — Mówca: **Player**
> "“It is the first step towards improving the ties between our nations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Emmerich Hegel: "“Does this have anything to do with the growing threat of..."*)

### Węzeł `[89]`
Mówca: **Emmerich Hegel**
> "“To me, this painting tells me how far we have come. Sords and Valgs might have had troubles in the past, but ultimately, we are brothers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Emmerich Hegel: "“No two countries in the world understand each other more.”"*)

### Węzeł `[90]`
Mówca: **Emmerich Hegel**
> "“No two countries in the world understand each other more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "“My thoughts exactly.”"*)
  - -> `[98]` (*Player: "“It is great to hear these important words coming from you.”"*)
  - -> `[101]` (*Player: "“Let's hope we can stay that way.”"*)

### Węzeł `[91]`
Mówca: **Emmerich Hegel**
> "“I have been watching Sordland's development with worry over the last few years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Emmerich Hegel: "“I am glad to see you are making progress in fixing the s..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“More trade means more money circulation. Undoubtedly it will help both of our nations' economies.”"]** — Mówca: **Player**
> "“More trade means more money circulation. Undoubtedly it will help both of our nations' economies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "He took another puff from his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Since we have come this far, I am not opposed to the ide..."*)
  - -> `[86]` (*Player: "“I want an alliance, Chancellor Hegel. I want to revive t..."*)
  - -> `[85]` (*Player: "“I know you are a busy man. Thank you for your time today..."*)

### Węzeł `[94]`
Mówca: **Emmerich Hegel**
> "“I will commence the invasion regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He took another puff from his pipe."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "We gulped down the shots after clinking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He took another puff from his pipe."*)

### Węzeł `[96]`
Mówca: **Emmerich Hegel**
> "“Well said!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Emmerich Hegel: "“That is precisely what I am trying to do, Mr. Rayne.”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“My thoughts exactly.”"]** — Mówca: **Player**
> "“My thoughts exactly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He nodded and pointed towards another painting that was a..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“It is great to hear these important words coming from you.”"]** — Mówca: **Player**
> "“It is great to hear these important words coming from you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He nodded and pointed towards another painting that was a..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The assistant immediately showed up with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Un..."*)

### Węzeł `[100]`
Mówca: **Emmerich Hegel**
> "“Although I would appreciate the support, as you said, our matters are not yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Emmerich Hegel: "“I will commence the invasion regardless.”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Let's hope we can stay that way.”"]** — Mówca: **Player**
> "“Let's hope we can stay that way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Emmerich Hegel: "“I am hopeful.”"*)

### Węzeł `[102]`
Mówca: **Emmerich Hegel**
> "“If you say that, I believe you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Emmerich Hegel: "“Let me tell you what I want.”"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“I want to align Sordland closer with the CSP.”"]** — Mówca: **Player**
> "“I want to align Sordland closer with the CSP.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Emmerich Hegel: "“A blunt answer. I like it. It gives me confidence.”"*)

### Węzeł `[104]`
Mówca: **Emmerich Hegel**
> "“Forgive me, Mr. Rayne. I was trying to figure out your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Emmerich Hegel: "“But, you do have a point. Why should we not, indeed?”"*)

### Węzeł `[105]`
Mówca: **Emmerich Hegel**
> "“Very well. I respect that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Emmerich Hegel: "“Although I would appreciate the support, as you said, ou..."*)

### Węzeł `[106]`
Mówca: **Emmerich Hegel**
> "“Another!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The assistant immediately showed up with two shots of vodka."*)

### Węzeł `[107]`
Mówca: **Emmerich Hegel**
> "“So you've decided to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Emmerich Hegel: "“Very well. I respect that.”"*)

### Węzeł `[108]`
Mówca: **Emmerich Hegel**
> "“We have achieved a lot today, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“Another!”"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Hegel chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Emmerich Hegel: "“Forgive me, Mr. Rayne. I was trying to figure out your i..."*)

### Węzeł `[110]`
Mówca: **Emmerich Hegel**
> "“I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He pointed towards another painting that was almost as la..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "He nodded and pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Emmerich Hegel: "“The Great Fire of Conriat.”"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Emmerich Hegel: "“You want to provide Sordish coal from the Lorren region ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Emmerich Hegel: "“You want to provide Sordish tungsten in return for Valgs..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRe..."*)

### Węzeł `[116]`
Mówca: **Emmerich Hegel**
> "“You are making trade deals with Agnolians, our sworn rivals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Emmerich Hegel: "“If I accept this deal, I will lose face with my people.”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Agnolia_HeljilandRecognised = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev = true"*)

### Węzeł `[118]`
Mówca: **Narrator**
> "He pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Emmerich Hegel: "“The Great Fire of Conriat.”"*)

### Węzeł `[119]`
Mówca: **Emmerich Hegel**
> "“The Great Fire of Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Emmerich Hegel: "“The most shameful event in all of Valgslandian history. ..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.A..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He took another puff from his pipe."*)

### Węzeł `[122]`
Mówca: **Emmerich Hegel**
> "“That's why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“Very well. I accept.”"*)
  - -> `[222]` (*Player: "“I won't meddle in the affairs between Valgsland and Agno..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from the pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Emmerich Hegel: "“If you want this deal, there is something you can do.”"*)

### Węzeł `[124]`
Mówca: **Emmerich Hegel**
> "“The most shameful event in all of Valgslandian history. The scars of it must still sting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: "“We shouldn't bear the sins of our forefathers.”"*)
  - -> `[134]` (*Player: "“Past is past. We need to look into the future.”"*)
  - -> `[137]` (*Player: "“We will never forget the extremely shameful display by t..."*)

### Węzeł `[125]`
Mówca: **Emmerich Hegel**
> "“But I can't risk international backlash. If I have you... if I have Sordland behind our cause, everything will be easier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Emmerich Hegel: "“That's why.”"*)

### Węzeł `[126]`
Mówca: **Emmerich Hegel**
> "“A blunt answer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Emmerich Hegel: "“But understanding your own position is a virtue.”"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "We clinked the glasses and drank our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Un..."*)

### Węzeł `[128]`
Mówca: **Emmerich Hegel**
> "“What do I have to lose?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Emmerich Hegel: "“You are making trade deals with Agnolians, our sworn riv..."*)

### Węzeł `[129]`
Mówca: **Emmerich Hegel**
> "“We could've made history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[130]`
Mówca: **Emmerich Hegel**
> "“This is not your battle, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Emmerich Hegel: "“But I can't risk international backlash. If I have you....."*)

### Węzeł `[131]`
Mówca: **Emmerich Hegel**
> "“A valid point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Emmerich Hegel: "“I have been watching Sordland's development with worry o..."*)

### Węzeł `[132]`
Mówca: **Emmerich Hegel**
> "“A pity, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Emmerich Hegel: "“We could've made history.”"*)

### Węzeł `[133]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "We clinked the glasses and drank our shots."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Past is past. We need to look into the future.”"]** — Mówca: **Player**
> "“Past is past. We need to look into the future.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Emmerich Hegel: "“I agree completely.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“We shouldn't bear the sins of our forefathers.”"]** — Mówca: **Player**
> "“We shouldn't bear the sins of our forefathers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Emmerich Hegel: "“Well said, Mr. Rayne.”"*)

### Węzeł `[136]`
Mówca: **Emmerich Hegel**
> "“Don't worry. I don't wish to pull Sordland into this conflict in any way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Emmerich Hegel: "“This is not your battle, after all.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“We will never forget the extremely shameful display by the Valgslandian navy. ”"]** — Mówca: **Player**
> "“We will never forget the extremely shameful display by the Valgslandian navy. ”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Emmerich Hegel: "“We will never forget the sins of our fathers.”"*)

### Węzeł `[138]`
Mówca: **Emmerich Hegel**
> "“Very well. Then you have ended your chances of achieving this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Emmerich Hegel: "“A pity, really.”"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Emmerich Hegel: "“You want to provide Sordish wheat from the Bergia region..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Emmerich Hegel: "“In Valgsland we drink on a contract, Mr. Rayne.”"*)

### Węzeł `[143]`
Mówca: **Emmerich Hegel**
> "“I will accept the deal on the basis of your sincerity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal = true"*)

### Węzeł `[144]`
Mówca: **Emmerich Hegel**
> "“I am planning on invading Heljiland to save Valgslandian citizens from the clutches of the murderous Agnolians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Emmerich Hegel: "“Don't worry. I don't wish to pull Sordland into this con..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Emmerich Hegel: "“In Valgsland we drink on a contract, Mr. Rayne.”"*)

### Węzeł `[146]`
Mówca: **Emmerich Hegel**
> "“We have achieved a lot today, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He called an assistant nearby. A moment later the assista..."*)

### Węzeł `[147]`
Mówca: **Emmerich Hegel**
> "“So you've decided to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Emmerich Hegel: "“Very well. Then you have ended your chances of achieving..."*)

### Węzeł `[148]`
Mówca: **Emmerich Hegel**
> "“We will never forget the sins of our fathers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[149]`
Mówca: **Emmerich Hegel**
> "“Well said, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[150]`
Mówca: **Emmerich Hegel**
> "“I agree completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[151]`
Mówca: **Emmerich Hegel**
> "“That is precisely what I am trying to do, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Emmerich Hegel: "“I want Sordland and Valgsland to be closer again as two ..."*)

### Węzeł `[152]`
Mówca: **Emmerich Hegel**
> "“If they want to mess with Valgsland, they will see our might!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Emmerich Hegel: "“Mr. Rayne. Since we have signed our trade deal, I will b..."*)

### Węzeł `[153]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Since we have signed our trade deal, I will be open with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Emmerich Hegel: "“I am planning on invading Heljiland to save Valgslandian..."*)

### Węzeł `[154]`
Mówca: **Emmerich Hegel**
> "“Why should I accept this deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Why should you not? What do you have to lose?”"*)
  - -> `[88]` (*Player: "“It is the first step towards improving the ties between ..."*)
  - -> `[92]` (*Player: "“More trade means more money circulation. Undoubtedly it ..."*)
  - -> `[103]` (*Player: "“I want to align Sordland closer with the CSP.”"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Emmerich Hegel: "“Now. If you wish to join the CSP, you will have to put m..."*)

### Węzeł `[156]`
Mówca: **Emmerich Hegel**
> "“Middle way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Emmerich Hegel: "“The window for diplomatic action is closing, Mr. Rayne.”"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAn..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Emmerich Hegel: "“You want to provide Sordish fishing output from the Agnl..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[161]`
Mówca: **Emmerich Hegel**
> "“How can I stay calm?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[162]`
Mówca: **Emmerich Hegel**
> "“Agnolia wants war!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Emmerich Hegel: "“How can I stay calm?”"*)

### Węzeł `[163]`
Mówca: **Emmerich Hegel**
> "“The window for diplomatic action is closing, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Emmerich Hegel: "“I am not sure how much longer I can show restraint.”"*)

### Węzeł `[164]`
Mówca: **Emmerich Hegel**
> "“I am not sure how much longer I can show restraint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[165]`
Mówca: **Emmerich Hegel**
> "“But understanding your own position is a virtue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Emmerich Hegel: "“It also takes strength to be able to overcome your pride..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "A guard approached the Chancellor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Emmerich Hegel: "“If you will excuse me for one minute.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal =..."*)

### Węzeł `[168]`
Mówca: **Emmerich Hegel**
> "“I have to protect my nation, and to do so I will concern myself with whatever I want. You have no say in that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He leaned back in his chair and took another puff from th..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He stepped away with the guard while I looked around. I saw a more recent painting, depicting the upheaval of farmers against an aristocrat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Emmerich Hegel: "“What did you say?!”"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.A..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Agnolia_HeljilandRecognised = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal = true"*)

### Węzeł `[172]`
Mówca: **Emmerich Hegel**
> "“I am glad to see you are making progress in fixing the situation created by your predecessor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Emmerich Hegel: "“Since you are so focused on the economic aspect, let me ..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Hegel's loud voice echoed in the empty halls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Emmerich Hegel: "“Give the miners what they want. As for the director of t..."*)

### Węzeł `[174]`
Mówca: **Emmerich Hegel**
> "“Valgsland is being attacked!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Emmerich Hegel: "“Agnolia wants war!”"*)

### Węzeł `[175]`
Mówca: **Emmerich Hegel**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Emmerich Hegel: "“I am not sure how much longer I can show restraint.”"*)

### Węzeł `[176]`
Mówca: **Emmerich Hegel**
> "“Imagine they did that to Sordish people. What would you do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player: "“Chancellor Hegel. I urge you to remain calm on the matte..."*)
  - -> `[177]` (*Player: "“I would slaughter them just like they slaughtered us!”"*)
  - -> `[179]` (*Player: "“I would approach the matter diplomatically. Surely a mid..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“I would slaughter them just like they slaughtered us!”"]** — Mówca: **Player**
> "“I would slaughter them just like they slaughtered us!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Emmerich Hegel: "“Exactly!”"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"]** — Mówca: **Player**
> "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Emmerich Hegel: "“Valgsland is being attacked!”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“I would approach the matter diplomatically. Surely a middle way can be found.”"]** — Mówca: **Player**
> "“I would approach the matter diplomatically. Surely a middle way can be found.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Emmerich Hegel: "“Middle way?”"*)

### Węzeł `[180]`
Mówca: **Emmerich Hegel**
> "“Middle way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Emmerich Hegel: "“The window for diplomatic action is closing, Mr. Rayne.”"*)

### Węzeł `[181]`
Mówca: **Emmerich Hegel**
> "“If I accept this deal, I will lose face with my people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player: "“Everything has a price, Chancellor Hegel. What is yours?”"*)
  - -> `[233]` (*Player: "“Why is Valgsland so concerned with Sordland making deals..."*)
  - -> `[229]` (*Player: "“Then I will make it worth your while.”"*)

### Węzeł `[182]`
Mówca: **Emmerich Hegel**
> "“There is something you can do for me to make this deal work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Emmerich Hegel: "“I want you to recognize Heljiland as Valgslandian territ..."*)

### Węzeł `[183]`
Mówca: **Emmerich Hegel**
> "“But, you do have a point. Why should we not, indeed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Emmerich Hegel: "“I want Sordland and Valgsland to be closer again as two ..."*)

### Węzeł `[184]`
Mówca: **Emmerich Hegel**
> "“I know the details of the deal already, but to sum it up...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[185]`
Mówca: **Emmerich Hegel**
> "“Give the miners what they want. As for the director of the company, I want him to face a trial for undermining the workers of Valgsland. Relay it to the Minister of Justice at once!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Emmerich Hegel: "“No one can exploit our people and expect to get away wit..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Emmerich Hegel: "“There is something you can do for me to make this deal w..."*)

### Węzeł `[187]`
Mówca: **Emmerich Hegel**
> "“No one can exploit our people and expect to get away with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "After receiving the order, the guard hastily left. Hegel ..."*)

### Węzeł `[188]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a seafaring nation, requires Sordish fishing output?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Emmerich Hegel: "“Why should I accept this deal?”"*)

### Węzeł `[189]`
Mówca: **Emmerich Hegel**
> "“If they want to mess with Valgsland, they will see our might!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Emmerich Hegel: "“The more nations we have on our side against the Agnolia..."*)

### Węzeł `[190]`
Mówca: **Emmerich Hegel**
> "“That's why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“Very well. I accept.”"*)
  - -> `[261]` (*Player: "“I won't meddle in the affairs between Valgsland and Agno..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "After receiving the order, the guard hastily left. Hegel walked over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Emmerich Hegel: "“Sorry about that. You know how it is.”"*)

### Węzeł `[192]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation rich with wheat farms, requires Sordish wheat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Emmerich Hegel: "“Why should I accept this deal?”"*)

### Węzeł `[193]`
Mówca: **Emmerich Hegel**
> "“The more nations we have on our side against the Agnolians, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Emmerich Hegel: "“That's why.”"*)

### Węzeł `[194]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation with plenty of its own coal mines, requires Sordish coal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Emmerich Hegel: "“Why should I accept this deal?”"*)

### Węzeł `[195]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation with considerable tungsten reserves, requires Sordish tungsten?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Emmerich Hegel: "“Why should I accept this deal?”"*)

### Węzeł `[196]`
Mówca: **Emmerich Hegel**
> "“I have had it with those damn Agnolians claiming *our* land as their own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Emmerich Hegel: "“As if that's not enough, they kill my people in their ho..."*)

### Węzeł `[197]`
Mówca: **Emmerich Hegel**
> "“As if that's not enough, they kill my people in their homes in Heljiland! Slaughtering them like mere cattle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Emmerich Hegel: "“Imagine they did that to Sordish people. What would you ..."*)

### Węzeł `[198]`
Mówca: **Emmerich Hegel**
> "“Sorry about that. You know how it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“I definitely do.”"*)
  - -> `[3]` (*Player: "“What was that about?”"*)
  - -> `[199]` (*Player: "“Let's move on with the scheduled program.”"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Let's move on with the scheduled program.”"]** — Mówca: **Player**
> "“Let's move on with the scheduled program.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Emmerich Hegel: "“Sure.”"*)

### Węzeł `[200]`
Mówca: **Emmerich Hegel**
> "“I am not sure how much longer I can show restraint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[201]`
Mówca: **Emmerich Hegel**
> "“How can I stay calm?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[202]`
Mówca: **Emmerich Hegel**
> "“Agnolia wants war!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Emmerich Hegel: "“How can I stay calm?”"*)

### Węzeł `[203]`
Mówca: **Emmerich Hegel**
> "“The window for diplomatic action is closing, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Emmerich Hegel: "“I am not sure how much longer I can show restraint.”"*)

### Węzeł `[204]`
Mówca: **Emmerich Hegel**
> "“For the sake of our conversation, let's say that there is something I want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Emmerich Hegel: "“I want you to recognize Heljiland as Valgslandian territ..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“I definitely do.”"]** — Mówca: **Player**
> "“I definitely do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Emmerich Hegel: "“Revolution is a slow process, Mr. Rayne. Slow but sure.”"*)

### Węzeł `[206]`
Mówca: **Emmerich Hegel**
> "“I will accept the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal = true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal =..."*)

### Węzeł `[208]`
Mówca: **Emmerich Hegel**
> "“A director of a foreign joint-venture mining corporation decided not to pay his miners their salary for two consecutive months. He will be handled.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Emmerich Hegel: "“Revolution is a slow process, Mr. Rayne. Slow but sure.”"*)

### Węzeł `[209]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Are you not reading your newspapers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Emmerich Hegel: "“I have had it with those damn Agnolians claiming *our* l..."*)

### Węzeł `[210]`
Mówca: **Emmerich Hegel**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[211]`
Mówca: **Emmerich Hegel**
> "“Now. If you wish to join the CSP, you will have to put more effort into it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: "“What do I have to do?”"*)
  - -> `[278]` (*Player: "“Go on.”"*)

### Węzeł `[212]`
Mówca: **Emmerich Hegel**
> "“It also takes strength to be able to overcome your pride and say that you need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Emmerich Hegel: "“Let me tell you what I want.”"*)

### Węzeł `[213]`
Mówca: **Emmerich Hegel**
> "“Valgsland is being attacked!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Emmerich Hegel: "“Agnolia wants war!”"*)

### Węzeł `[214]`
Mówca: **Emmerich Hegel**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Emmerich Hegel: "“I am not sure how much longer I can show restraint.”"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Hegel looked down for a moment. He walked over to the win..."*)

### Węzeł `[216]`
Mówca: **Emmerich Hegel**
> "“Revolution is a slow process, Mr. Rayne. Slow but sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "He picked up the documents that were beside him on the small ornamental coffee table and started going through them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Emmerich Hegel: "“I know the details of the deal already, but to sum it up..."*)

### Węzeł `[218]`
Mówca: **Emmerich Hegel**
> "“Since you are so focused on the economic aspect, let me do that too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Emmerich Hegel: "“It sounds like you have much more to gain from the deal ..."*)

### Węzeł `[219]`
Mówca: **Emmerich Hegel**
> "“I want Sordland and Valgsland to be closer again as two nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Emmerich Hegel: "“I want to mend the damage that was inflicted by the impe..."*)

### Węzeł `[220]`
Mówca: **Emmerich Hegel**
> "“Follow me. We will have a short breakfast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "We made our way to the exquisite dining room. I looked ar..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Why do you want this from me?”"]** — Mówca: **Player**
> "“Why do you want this from me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Emmerich Hegel: "“Mr. Rayne. Are you not reading your newspapers?”"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I won't meddle in the affairs between Valgsland and Agnolia.”"]** — Mówca: **Player**
> "“I won't meddle in the affairs between Valgsland and Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Emmerich Hegel), `[227]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Emmerich Hegel: "“So you've decided to stay neutral.”"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "“An easy choice. I accept.”"]** — Mówca: **Player**
> "“An easy choice. I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.A..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I would slaughter them just like they slaughtered us!”"]** — Mówca: **Player**
> "“I would slaughter them just like they slaughtered us!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Emmerich Hegel: "“Exactly!”"*)

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"]** — Mówca: **Player**
> "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Emmerich Hegel: "“Valgsland is being attacked!”"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“I would approach the matter diplomatically. Surely a middle way can be found.”"]** — Mówca: **Player**
> "“I would approach the matter diplomatically. Surely a middle way can be found.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Emmerich Hegel: "“Middle way?”"*)

### Węzeł `[227]`
Mówca: **Emmerich Hegel**
> "“It's that simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“Why do you want this from me?”"*)
  - -> `[223]` (*Player: "“An easy choice. I accept.”"*)
  - -> `[222]` (*Player: "“I won't meddle in the affairs between Valgsland and Agno..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "We made our way to the exquisite dining room. I looked around. The tableware and decor was all colored gold, blue and white."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Smoked bear meat, a local delicacy, was served with eggs...."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Then I will make it worth your while.”"]** — Mówca: **Player**
> "“Then I will make it worth your while.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Emmerich Hegel: "“Oh?”"*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Smoked bear meat, a local delicacy, was served with eggs. After a very delicious meal, we sat down on two couches. I immediately saw the portrait of Leon "Malenyev" Chavatangakwunua staring down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player: "“What can you tell me about Malenyev?”"*)
  - -> `[234]` (*Player: "“Let's talk about business, shall we?”"*)

### Węzeł `[231]`
Mówca: **Emmerich Hegel**
> "“Imagine they did that to Sordish people. What would you do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: "“Chancellor Hegel. I urge you to remain calm on the matte..."*)
  - -> `[224]` (*Player: "“I would slaughter them just like they slaughtered us!”"*)
  - -> `[226]` (*Player: "“I would approach the matter diplomatically. Surely a mid..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Everything has a price, Chancellor Hegel. What is yours?”"]** — Mówca: **Player**
> "“Everything has a price, Chancellor Hegel. What is yours?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Emmerich Hegel: "“You speak like the oligarchs we have long dealt with her..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: "“Why is Valgsland so concerned with Sordland making deals with its neighbors?”"]** — Mówca: **Player**
> "“Why is Valgsland so concerned with Sordland making deals with its neighbors?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Emmerich Hegel: "“Please do not waste my time with senseless questions, Mr..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Let's talk about business, shall we?”"]** — Mówca: **Player**
> "“Let's talk about business, shall we?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "An assistant brought in two cups of coffee."*)

### Węzeł `[235]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Emmerich Hegel: "“What makes you think that Valgsland, a seafaring nation,..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“What can you tell me about Malenyev?”"]** — Mówca: **Player**
> "“What can you tell me about Malenyev?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Emmerich Hegel: "“Ah. You have spotted the portrait. Well. Where do I begin?”"*)

### Węzeł `[237]`
Mówca: **Emmerich Hegel**
> "“Recognize Heljiland as Valgslandian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Emmerich Hegel: "“It's that simple.”"*)

### Węzeł `[238]`
Mówca: **Emmerich Hegel**
> "“As if that's not enough, they kill my people in their homes in Heljiland! Slaughtering them like mere cattle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Emmerich Hegel: "“Imagine they did that to Sordish people. What would you ..."*)

### Węzeł `[239]`
Mówca: **Emmerich Hegel**
> "“Now that we are trade partners, I will be honest with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Emmerich Hegel: "“I have had it with those damn Agnolians claiming *our* l..."*)

### Węzeł `[240]`
Mówca: **Emmerich Hegel**
> "“Ah. You have spotted the portrait. Well. Where do I begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Emmerich Hegel: "“Comrade Malenyev is a good friend of mine.”"*)

### Węzeł `[241]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Emmerich Hegel: "“What makes you think that Valgsland, a nation rich with ..."*)

### Węzeł `[242]`
Mówca: **Emmerich Hegel**
> "“Comrade Malenyev is a good friend of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Emmerich Hegel: "“Although I don't agree with him on every matter, he dema..."*)

### Węzeł `[243]`
Mówca: **Emmerich Hegel**
> "“Let me tell you what I want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Emmerich Hegel: "“I want Sordland and Valgsland to be closer again as two ..."*)

### Węzeł `[244]`
Mówca: **Emmerich Hegel**
> "“Although I don't agree with him on every matter, he demands respect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Emmerich Hegel: "“Valgslandian Socialism aims to eliminate the power of th..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "“What do you want? Tell it to me straight.”"]** — Mówca: **Player**
> "“What do you want? Tell it to me straight.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Emmerich Hegel: "“Recognize Heljiland as Valgslandian territory.”"*)

### Węzeł `[246]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Emmerich Hegel: "“Recognize Heljiland as Valgslandian territory.”"*)

### Węzeł `[247]`
**[WYBÓR GRACZA: "“Anything to join the pact.”"]** — Mówca: **Player**
> "“Anything to join the pact.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Emmerich Hegel: "“Recognize Heljiland as Valgslandian territory.”"*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Hegel looked down for a moment. He walked over to the window and gazed outside with his arms crossed behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Emmerich Hegel: "“Now that we are trade partners, I will be honest with you.”"*)

### Węzeł `[249]`
Mówca: **Emmerich Hegel**
> "“Those damn Agnolians are claiming *our* land as their own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Emmerich Hegel: "“As if that's not enough, they kill my people in their ho..."*)

### Węzeł `[250]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish wheat from the Bergia region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Emmerich Hegel: "“The details were discussed between our ministers, but I ..."*)

### Węzeł `[251]`
Mówca: **Emmerich Hegel**
> "“But I can put in a good word in with him... if you do something for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: "“I'm listening.”"*)
  - -> `[245]` (*Player: "“What do you want? Tell it to me straight.”"*)
  - -> `[247]` (*Player: "“Anything to join the pact.”"*)

### Węzeł `[252]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Emmerich Hegel: "“What makes you think that Valgsland, a nation with plent..."*)

### Węzeł `[253]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Emmerich Hegel: "“What makes you think that Valgsland, a nation with consi..."*)

### Węzeł `[254]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Are you not reading your newspapers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Emmerich Hegel: "“Those damn Agnolians are claiming *our* land as their own.”"*)

### Węzeł `[255]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish fishing output from the Agnland region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Emmerich Hegel: "“The details were discussed between our ministers, but I ..."*)

### Węzeł `[256]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish coal from the Lorren region in return for Valgsland's hard-earned money”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Emmerich Hegel: "“The details were discussed between our ministers, but I ..."*)

### Węzeł `[257]`
Mówca: **Emmerich Hegel**
> "“I can't tell him to simply take Sordland in, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Emmerich Hegel: "“But I can put in a good word in with him... if you do so..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: "“Whatever. He is still just a man.”"]** — Mówca: **Player**
> "“Whatever. He is still just a man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "He burst into laughter."*)

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Why do you want this from me?”"]** — Mówca: **Player**
> "“Why do you want this from me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Emmerich Hegel: "“Mr. Rayne. Are you not reading your newspapers?”"*)

### Węzeł `[260]`
**[WYBÓR GRACZA: "“An easy choice. I accept.”"]** — Mówca: **Player**
> "“An easy choice. I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.A..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: "“I won't meddle in the affairs between Valgsland and Agnolia.”"]** — Mówca: **Player**
> "“I won't meddle in the affairs between Valgsland and Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Emmerich Hegel), `[264]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Emmerich Hegel: "“So you've decided to stay neutral.”"*)

### Węzeł `[262]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish tungsten in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Emmerich Hegel: "“The details were discussed between our ministers, but I ..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "We clinked the glasses and drank our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "The strong bite of alcohol turned into a sweeter aftertaste."*)

### Węzeł `[264]`
Mówca: **Emmerich Hegel**
> "“I want you to recognize Heljiland as Valgslandian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player: "“Why do you want this from me?”"*)
  - -> `[260]` (*Player: "“An easy choice. I accept.”"*)
  - -> `[261]` (*Player: "“I won't meddle in the affairs between Valgsland and Agno..."*)

### Węzeł `[265]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "We clinked the glasses and drank our shots."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“He seems like an interesting person. I would like to meet with him.”"]** — Mówca: **Player**
> "“He seems like an interesting person. I would like to meet with him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Emmerich Hegel: "“Perhaps one day you will.”"*)

### Węzeł `[267]`
Mówca: **Emmerich Hegel**
> "“Comrade Malenyev is a good friend of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Emmerich Hegel: "“I can't tell him to simply take Sordland in, of course.”"*)

### Węzeł `[268]`
Mówca: **Narrator**
> "He burst into laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Emmerich Hegel: "“He would say the same thing about himself too.”"*)

### Węzeł `[269]`
Mówca: **Emmerich Hegel**
> "“Perhaps one day you will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "An assistant brought in two cups of coffee."*)

### Węzeł `[270]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "We clinked the glasses and did our shots."*)

### Węzeł `[271]`
Mówca: **Emmerich Hegel**
> "“He would say the same thing about himself too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "An assistant brought in two cups of coffee."*)

### Węzeł `[272]`
Mówca: **Emmerich Hegel**
> "“It sounds like you have much more to gain from the deal than Valgsland does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "He leaned back in his chair and took another puff from hi..."*)

### Węzeł `[273]`
Mówca: **Emmerich Hegel**
> "“I want to mend the damage that was inflicted by the imperialism that caused our countries, once brothers, to oppose each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Emmerich Hegel: "“You and I can do this.”"*)

### Węzeł `[274]`
Mówca: **Emmerich Hegel**
> "“If you want this deal, there is something you can do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Emmerich Hegel: "“I want you to recognize Heljiland as Valgslandian territ..."*)

### Węzeł `[275]`
Mówca: **Emmerich Hegel**
> "“Please do not waste my time with senseless questions, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Emmerich Hegel: "“No country in this world is completely isolated.”"*)

### Węzeł `[276]`
Mówca: **Emmerich Hegel**
> "“Oh?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Emmerich Hegel: "“A strong argument.”"*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“What do I have to do?”"]** — Mówca: **Player**
> "“What do I have to do?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Emmerich Hegel: "“Comrade Malenyev is a good friend of mine.”"*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Emmerich Hegel: "“Comrade Malenyev is a good friend of mine.”"*)

### Węzeł `[279]`
Mówca: **Narrator**
> "An assistant brought in two cups of coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Emmerich Hegel: "“Let's begin, then.”"*)

### Węzeł `[280]`
Mówca: **Emmerich Hegel**
> "“Let's begin, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "He picked up the documents that were beside him on the sm..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Emmerich Hegel: "“In Valgsland we drink on a contract, Mr. Rayne.”"*)

### Węzeł `[282]`
Mówca: **Emmerich Hegel**
> "“You speak like the oligarchs we have long dealt with here in Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He leaned back in his chair and took another puff from th..."*)

### Węzeł `[283]`
Mówca: **Emmerich Hegel**
> "“I hear there is still an emergency declared in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Emmerich Hegel: "“I hope everything is alright.”"*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "“That is none of your concern, Chancellor Hegel.”"]** — Mówca: **Player**
> "“That is none of your concern, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Emmerich Hegel: "“It is precisely my concern. I won't make trade deals wit..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Emmerich Hegel: "“I hear there is still an emergency declared in Sordland.”"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[288]`
Mówca: **Emmerich Hegel**
> "“I hope everything is alright.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: "“Nothing to worry about, Chancellor Hegel. Everything has..."*)
  - -> `[284]` (*Player: "“That is none of your concern, Chancellor Hegel.”"*)
  - -> `[292]` (*Player: "“Let's change the topic.”"*)

### Węzeł `[289]`
Mówca: **Emmerich Hegel**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Nothing to worry about, Chancellor Hegel. Everything has been handled.”"]** — Mówca: **Player**
> "“Nothing to worry about, Chancellor Hegel. Everything has been handled.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[291]`
Mówca: **Emmerich Hegel**
> "“It is precisely my concern. I won't make trade deals with an unstable country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: "“There is nothing to worry about in terms of our trade de..."*)
  - -> `[294]` (*Player: "“Who says Sordland is unstable? We're the most stable cou..."*)
  - -> `[295]` (*Player: "“I understand, Chancellor Hegel. Rest assured I have the ..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA: "“Let's change the topic.”"]** — Mówca: **Player**
> "“Let's change the topic.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: "“There is nothing to worry about in terms of our trade deal.”"]** — Mówca: **Player**
> "“There is nothing to worry about in terms of our trade deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Emmerich Hegel: "“If you say so...”"*)

### Węzeł `[294]`
**[WYBÓR GRACZA: "“Who says Sordland is unstable? We're the most stable country there is.”"]** — Mówca: **Player**
> "“Who says Sordland is unstable? We're the most stable country there is.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Emmerich Hegel: "“If you say so...”"*)

### Węzeł `[295]`
**[WYBÓR GRACZA: "“I understand, Chancellor Hegel. Rest assured I have the situation under control.”"]** — Mówca: **Player**
> "“I understand, Chancellor Hegel. Rest assured I have the situation under control.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Emmerich Hegel: "“If you say so...”"*)

### Węzeł `[296]`
Mówca: **Emmerich Hegel**
> "“If you say so...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[297]`
Mówca: **Emmerich Hegel**
> "“However, our revolution here in Valgsland owes a great deal to Malenyev. He is the father of Malenyevism and a symbol of global revolution. Not only is he the first-ever communist revolutionary leader, he managed to unite a whole continent, forming the greatest country in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: "“He seems like an interesting person. I would like to mee..."*)
  - -> `[258]` (*Player: "“Whatever. He is still just a man.”"*)

### Węzeł `[298]`
Mówca: **Emmerich Hegel**
> "“We believe that the revolution in Valgsland is stable enough that we do not need the vanguardist approach of Malenyevism. We are already in the process of such a transformation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Emmerich Hegel: "“However, our revolution here in Valgsland owes a great d..."*)

### Węzeł `[299]`
Mówca: **Emmerich Hegel**
> "“Valgslandian Socialism aims to eliminate the power of the state through the promotion of responsibility, freedom and well-being of the people. One of our key cornerstones is the devolution of big government to smaller councils with high citizen participation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Emmerich Hegel: "“We believe that the revolution in Valgsland is stable en..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "He called an assistant nearby. A moment later the assista..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He called an assistant nearby. A moment later the assista..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Emmerich Hegel: "“We have achieved a lot today, Mr. Rayne.”"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Emmerich Hegel: "“We have achieved a lot today, Mr. Rayne.”"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Emmerich Hegel: "“This is great news!”"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "Unf..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance = true"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "We gulped down the shots after clinking."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "The strong bite of alcohol turned into a sweeter aftertaste."*)
