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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[56]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_Alliance"] = true;`
- Węzeł `[115]` (Paskal Beniwoll): `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = true;`
- Węzeł `[117]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true; Variable["BaseGame.Agnolia_HeljilandRe...`
- Węzeł `[157]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- Węzeł `[167]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true; Variable["BaseGame.Agnolia_HeljilandRe...`
- Węzeł `[207]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- Węzeł `[300]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
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
  - -> `[18]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `160` (*Sordland/Turn08/FPnT_ValgslandVisit*), Węzeł `[3]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "“What was that about?”"]** — Mówca: **Player**
> "“What was that about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Of course, Chancellor Hegel. It was a pleasure.”"]** — Mówca: **Player**
> "“Of course, Chancellor Hegel. It was a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Emmerich Hegel**
> "“The pleasure is mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from the pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[7]`
Mówca: **Narrator**
> "As the assistant collected the empty glasses, he whispered into Hegel's ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Hegel's eyes widened and he clenched his fists in anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "We shook hands and Hegel left in a hurry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[10]`
Mówca: **Emmerich Hegel**
> "“The Agnolians did what?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Emmerich Hegel**
> "“Thank you for the offer, but no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
Mówca: **Narrator**
> "He composed himself and smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne, I'm afraid you will have to excuse me. There is a matter I need to attend to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[16]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Emmerich Hegel**
> "“Have a good day and enjoy Haelm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Is there anything I can help with?”"]** — Mówca: **Player**
> "“Is there anything I can help with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[17]`
Mówca: **Emmerich Hegel**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[18]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[19]`
Mówca: **Emmerich Hegel**
> "“If you will excuse me for one minute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[20]`
Mówca: **Emmerich Hegel**
> "“You are answering my question with a question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[24]`
Mówca: **Emmerich Hegel**
> "“Thankfully, we in Valgsland have now cut off the head of the snake called imperialism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[25]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Welcome to Valgsland. It is good to finally meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[26]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“So. Where do we begin?”"]** — Mówca: **Player**
> "“So. Where do we begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Likewise.”"]** — Mówca: **Player**
> "“Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's a pleasure to finally meet with you, Chancellor Hegel.”"]** — Mówca: **Player**
> "“It's a pleasure to finally meet with you, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Emmerich Hegel**
> "“A strong argument.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[30]`
Mówca: **Emmerich Hegel**
> "“Does this have anything to do with the growing threat of Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[50]`

### Węzeł `[31]`
Mówca: **Emmerich Hegel**
> "“A blunt answer. I like it. It gives me confidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He gestured towards the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Emmerich Hegel**
> "“No country in this world is completely isolated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[34]`
Mówca: **Emmerich Hegel**
> "“This was made in 1776 by the famous Valgslandian painter, Otto Kiebern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[35]`
Mówca: **Emmerich Hegel**
> "“You and I can do this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[36]`
Mówca: **Emmerich Hegel**
> "“Another round!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The assistants brought two more shots. We drank them in one go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[41]`
Mówca: **Emmerich Hegel**
> "“We must celebrate!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Narrator**
> "I looked at the painting. It must've been over five meters tall. It was a battle scene. On the left side there were banners carried by Valgs; on the right, Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Emmerich Hegel**
> "“Hell! Bring the bottle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Countless spears formed a triangle at the center. The sky was red from the blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Why not?”"]** — Mówca: **Player**
> "“Why not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Thank you for the offer, but there is only so much vodka I can drink before lunch.”"]** — Mówca: **Player**
> "“Thank you for the offer, but there is only so much vodka I can drink before lunch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
Mówca: **Emmerich Hegel**
> "“But so far, you haven't done much to justify such an alignment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[48]`
Mówca: **Emmerich Hegel**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[60]`

### Węzeł `[49]`
Mówca: **Emmerich Hegel**
> "“There we go!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“We don't need external threats to make a deal with one of our oldest neighbors.”"]** — Mówca: **Player**
> "“We don't need external threats to make a deal with one of our oldest neighbors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[51]`
Mówca: **Narrator**
> "He laughed loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Absolutely not. Sordland can defend itself just fine.”"]** — Mówca: **Player**
> "“Absolutely not. Sordland can defend itself just fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“It does.”"]** — Mówca: **Player**
> "“It does.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[54]`
Mówca: **Narrator**
> "We clinked the glasses and did our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[55]`
Mówca: **Narrator**
> "We shook hands and he pulled me in for a hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[57]`
Mówca: **Emmerich Hegel**
> "“So you want to keep improving your economy after all those long years of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[58]`
Mówca: **Emmerich Hegel**
> "“This is great news!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[59]`
Mówca: **Emmerich Hegel**
> "“So you want to get rid of that recession of yours then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It is a reminder. One misstep and we are back to painting the world with more blood.”"]** — Mówca: **Player**
> "“It is a reminder. One misstep and we are back to painting the world with more blood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Emmerich Hegel**
> "“I accept, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Nothing. It's just a painting.”"]** — Mówca: **Player**
> "“Nothing. It's just a painting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"]** — Mówca: **Player**
> "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
Mówca: **Emmerich Hegel**
> "“This time, Sords and Valgs will stand side by side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Emmerich Hegel**
> "“As the leaders of this world, we must be careful, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[66]`
Mówca: **Emmerich Hegel**
> "“I gladly accept, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[67]`
Mówca: **Emmerich Hegel**
> "“Certainly a fair viewpoint, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[68]`
Mówca: **Emmerich Hegel**
> "“This time we will not be on opposing sides of history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Emmerich Hegel**
> "“This time, Sords and Valgs will stand side by side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[70]`
Mówca: **Emmerich Hegel**
> "“We can do so much more through unity, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
Mówca: **Emmerich Hegel**
> "“What did you say?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[72]`
Mówca: **Emmerich Hegel**
> "“If your actions matched your words, this could've gone differently. But let's not talk about what could have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[73]`
Mówca: **Emmerich Hegel**
> "“Yes! This time we will not be on opposing sides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[74]`
Mówca: **Emmerich Hegel**
> "“We have much to gain from an alliance between our two nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Why should you not? What do you have to lose?”"]** — Mówca: **Player**
> "“Why should you not? What do you have to lose?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[76]`
Mówca: **Emmerich Hegel**
> "“I have been watching Sordland's development with worry over the last few years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[77]`
Mówca: **Emmerich Hegel**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Emmerich Hegel**
> "“Especially around those who are willing and ready to do precisely that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Emmerich Hegel**
> "“It would be a bit quick, but I am not opposed either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[80]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[81]`
Mówca: **Narrator**
> "He turned to me and put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[82]`
Mówca: **Emmerich Hegel**
> "“An alliance, you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[83]`
Mówca: **Emmerich Hegel**
> "“Thank you for coming, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Since we have come this far, I am not opposed to the idea of an alliance.”"]** — Mówca: **Player**
> "“Since we have come this far, I am not opposed to the idea of an alliance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“I know you are a busy man. Thank you for your time today, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I know you are a busy man. Thank you for your time today, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“I want an alliance, Chancellor Hegel. I want to revive the brotherhood of old!”"]** — Mówca: **Player**
> "“I want an alliance, Chancellor Hegel. I want to revive our brotherhood of old!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
Mówca: **Emmerich Hegel**
> "“A valid point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“It is the first step towards improving the ties between our nations.”"]** — Mówca: **Player**
> "“It is the first step towards improving the ties between our nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[89]`
Mówca: **Emmerich Hegel**
> "“To me, this painting tells me how far we have come. Sords and Valgs might have had troubles in the past, but ultimately, we are brothers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Emmerich Hegel**
> "“No two countries in the world understand each other more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`
  - -> `[101]`

### Węzeł `[91]`
Mówca: **Emmerich Hegel**
> "“I have been watching Sordland's development with worry over the last few years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“More trade means more money circulation. Undoubtedly it will help both of our nations' economies.”"]** — Mówca: **Player**
> "“More trade means more money circulation. Undoubtedly it will help both of our nations' economies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[93]`
Mówca: **Narrator**
> "He took another puff from his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[86]`
  - -> `[85]`

### Węzeł `[94]`
Mówca: **Emmerich Hegel**
> "“I will commence the invasion regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Narrator**
> "We gulped down the shots after clinking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Emmerich Hegel**
> "“Well said!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“My thoughts exactly.”"]** — Mówca: **Player**
> "“My thoughts exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“It is great to hear these important words coming from you.”"]** — Mówca: **Player**
> "“It is great to hear these important words coming from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The assistant immediately showed up with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[100]`
Mówca: **Emmerich Hegel**
> "“Although I would appreciate the support, as you said, our matters are not yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Let's hope we can stay that way.”"]** — Mówca: **Player**
> "“Let's hope we can stay that way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
Mówca: **Emmerich Hegel**
> "“If you say that, I believe you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“I want to align Sordland closer with the CSP.”"]** — Mówca: **Player**
> "“I want to align Sordland closer with the CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[104]`
Mówca: **Emmerich Hegel**
> "“Forgive me, Mr. Rayne. I was trying to figure out your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[105]`
Mówca: **Emmerich Hegel**
> "“Very well. I respect that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[106]`
Mówca: **Emmerich Hegel**
> "“Another!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[107]`
Mówca: **Emmerich Hegel**
> "“So you've decided to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Emmerich Hegel**
> "“We have achieved a lot today, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Hegel chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[110]`
Mówca: **Emmerich Hegel**
> "“I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[111]`
Mówca: **Narrator**
> "He nodded and pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Hegel_PutInAGoodWordWithMalenyev = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[116]`
Mówca: **Emmerich Hegel**
> "“You are making trade deals with Agnolians, our sworn rivals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Agnolia_HeljilandRecognised = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[118]`
Mówca: **Narrator**
> "He pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Emmerich Hegel**
> "“The Great Fire of Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[121]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[122]`
Mówca: **Emmerich Hegel**
> "“That's why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[222]`

### Węzeł `[123]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from the pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[124]`
Mówca: **Emmerich Hegel**
> "“The most shameful event in all of Valgslandian history. The scars of it must still sting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[134]`
  - -> `[137]`

### Węzeł `[125]`
Mówca: **Emmerich Hegel**
> "“But I can't risk international backlash. If I have you... if I have Sordland behind our cause, everything will be easier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[126]`
Mówca: **Emmerich Hegel**
> "“A blunt answer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[127]`
Mówca: **Narrator**
> "We clinked the glasses and drank our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[128]`
Mówca: **Emmerich Hegel**
> "“What do I have to lose?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[129]`
Mówca: **Emmerich Hegel**
> "“We could've made history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[130]`
Mówca: **Emmerich Hegel**
> "“This is not your battle, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[131]`
Mówca: **Emmerich Hegel**
> "“A valid point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[132]`
Mówca: **Emmerich Hegel**
> "“A pity, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Past is past. We need to look into the future.”"]** — Mówca: **Player**
> "“Past is past. We need to look into the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“We shouldn't bear the sins of our forefathers.”"]** — Mówca: **Player**
> "“We shouldn't bear the sins of our forefathers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[136]`
Mówca: **Emmerich Hegel**
> "“Don't worry. I don't wish to pull Sordland into this conflict in any way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“We will never forget the extremely shameful display by the Valgslandian navy. ”"]** — Mówca: **Player**
> "“We will never forget the extremely shameful display by the Valgslandian navy. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[138]`
Mówca: **Emmerich Hegel**
> "“Very well. Then you have ended your chances of achieving this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[142]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[143]`
Mówca: **Emmerich Hegel**
> "“I will accept the deal on the basis of your sincerity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[144]`
Mówca: **Emmerich Hegel**
> "“I am planning on invading Heljiland to save Valgslandian citizens from the clutches of the murderous Agnolians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[145]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[146]`
Mówca: **Emmerich Hegel**
> "“We have achieved a lot today, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[147]`
Mówca: **Emmerich Hegel**
> "“So you've decided to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[148]`
Mówca: **Emmerich Hegel**
> "“We will never forget the sins of our fathers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[149]`
Mówca: **Emmerich Hegel**
> "“Well said, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[150]`
Mówca: **Emmerich Hegel**
> "“I agree completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[151]`
Mówca: **Emmerich Hegel**
> "“That is precisely what I am trying to do, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[152]`
Mówca: **Emmerich Hegel**
> "“If they want to mess with Valgsland, they will see our might!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Since we have signed our trade deal, I will be open with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[154]`
Mówca: **Emmerich Hegel**
> "“Why should I accept this deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[88]`
  - -> `[92]`
  - -> `[103]`

### Węzeł `[155]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[156]`
Mówca: **Emmerich Hegel**
> "“Middle way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[161]`
Mówca: **Emmerich Hegel**
> "“How can I stay calm?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[162]`
Mówca: **Emmerich Hegel**
> "“Agnolia wants war!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[163]`
Mówca: **Emmerich Hegel**
> "“The window for diplomatic action is closing, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Emmerich Hegel**
> "“I am not sure how much longer I can show restraint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[165]`
Mówca: **Emmerich Hegel**
> "“But understanding your own position is a virtue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[166]`
Mówca: **Narrator**
> "A guard approached the Chancellor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[168]`
Mówca: **Emmerich Hegel**
> "“I have to protect my nation, and to do so I will concern myself with whatever I want. You have no say in that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He stepped away with the guard while I looked around. I saw a more recent painting, depicting the upheaval of farmers against an aristocrat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Agnolia_HeljilandRecognised = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[172]`
Mówca: **Emmerich Hegel**
> "“I am glad to see you are making progress in fixing the situation created by your predecessor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Hegel's loud voice echoed in the empty halls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[174]`
Mówca: **Emmerich Hegel**
> "“Valgsland is being attacked!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[175]`
Mówca: **Emmerich Hegel**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[176]`
Mówca: **Emmerich Hegel**
> "“Imagine they did that to Sordish people. What would you do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[177]`
  - -> `[179]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“I would slaughter them just like they slaughtered us!”"]** — Mówca: **Player**
> "“I would slaughter them just like they slaughtered us!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"]** — Mówca: **Player**
> "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "“I would approach the matter diplomatically. Surely a middle way can be found.”"]** — Mówca: **Player**
> "“I would approach the matter diplomatically. Surely a middle way can be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Emmerich Hegel**
> "“Middle way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[181]`
Mówca: **Emmerich Hegel**
> "“If I accept this deal, I will lose face with my people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[229]`

### Węzeł `[182]`
Mówca: **Emmerich Hegel**
> "“There is something you can do for me to make this deal work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[183]`
Mówca: **Emmerich Hegel**
> "“But, you do have a point. Why should we not, indeed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[184]`
Mówca: **Emmerich Hegel**
> "“I know the details of the deal already, but to sum it up...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[185]`
Mówca: **Emmerich Hegel**
> "“Give the miners what they want. As for the director of the company, I want him to face a trial for undermining the workers of Valgsland. Relay it to the Minister of Justice at once!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Narrator**
> "He leaned back in his chair and took another puff from his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[187]`
Mówca: **Emmerich Hegel**
> "“No one can exploit our people and expect to get away with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a seafaring nation, requires Sordish fishing output?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[189]`
Mówca: **Emmerich Hegel**
> "“If they want to mess with Valgsland, they will see our might!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Emmerich Hegel**
> "“That's why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[261]`

### Węzeł `[191]`
Mówca: **Narrator**
> "After receiving the order, the guard hastily left. Hegel walked over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[192]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation rich with wheat farms, requires Sordish wheat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[193]`
Mówca: **Emmerich Hegel**
> "“The more nations we have on our side against the Agnolians, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[194]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation with plenty of its own coal mines, requires Sordish coal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[195]`
Mówca: **Emmerich Hegel**
> "“What makes you think that Valgsland, a nation with considerable tungsten reserves, requires Sordish tungsten?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[196]`
Mówca: **Emmerich Hegel**
> "“I have had it with those damn Agnolians claiming *our* land as their own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Emmerich Hegel**
> "“As if that's not enough, they kill my people in their homes in Heljiland! Slaughtering them like mere cattle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[198]`
Mówca: **Emmerich Hegel**
> "“Sorry about that. You know how it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[3]`
  - -> `[199]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Let's move on with the scheduled program.”"]** — Mówca: **Player**
> "“Let's move on with the scheduled program.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[200]`
Mówca: **Emmerich Hegel**
> "“I am not sure how much longer I can show restraint.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[201]`
Mówca: **Emmerich Hegel**
> "“How can I stay calm?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[202]`
Mówca: **Emmerich Hegel**
> "“Agnolia wants war!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[203]`
Mówca: **Emmerich Hegel**
> "“The window for diplomatic action is closing, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[204]`
Mówca: **Emmerich Hegel**
> "“For the sake of our conversation, let's say that there is something I want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“I definitely do.”"]** — Mówca: **Player**
> "“I definitely do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[206]`
Mówca: **Emmerich Hegel**
> "“I will accept the trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[208]`
Mówca: **Emmerich Hegel**
> "“A director of a foreign joint-venture mining corporation decided not to pay his miners their salary for two consecutive months. He will be handled.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[209]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Are you not reading your newspapers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[210]`
Mówca: **Emmerich Hegel**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[211]`
Mówca: **Emmerich Hegel**
> "“Now. If you wish to join the CSP, you will have to put more effort into it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[212]`
Mówca: **Emmerich Hegel**
> "“It also takes strength to be able to overcome your pride and say that you need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[213]`
Mówca: **Emmerich Hegel**
> "“Valgsland is being attacked!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[214]`
Mówca: **Emmerich Hegel**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[215]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[216]`
Mówca: **Emmerich Hegel**
> "“Revolution is a slow process, Mr. Rayne. Slow but sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[217]`
Mówca: **Narrator**
> "He picked up the documents that were beside him on the small ornamental coffee table and started going through them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[218]`
Mówca: **Emmerich Hegel**
> "“Since you are so focused on the economic aspect, let me do that too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[219]`
Mówca: **Emmerich Hegel**
> "“I want Sordland and Valgsland to be closer again as two nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[220]`
Mówca: **Emmerich Hegel**
> "“Follow me. We will have a short breakfast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Why do you want this from me?”"]** — Mówca: **Player**
> "“Why do you want this from me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I won't meddle in the affairs between Valgsland and Agnolia.”"]** — Mówca: **Player**
> "“I won't meddle in the affairs between Valgsland and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "“An easy choice. I accept.”"]** — Mówca: **Player**
> "“An easy choice. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I would slaughter them just like they slaughtered us!”"]** — Mówca: **Player**
> "“I would slaughter them just like they slaughtered us!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"]** — Mówca: **Player**
> "“Chancellor Hegel. I urge you to remain calm on the matter. No one wants war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“I would approach the matter diplomatically. Surely a middle way can be found.”"]** — Mówca: **Player**
> "“I would approach the matter diplomatically. Surely a middle way can be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[227]`
Mówca: **Emmerich Hegel**
> "“It's that simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[223]`
  - -> `[222]`

### Węzeł `[228]`
Mówca: **Narrator**
> "We made our way to the exquisite dining room. I looked around. The tableware and decor was all colored gold, blue and white."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Then I will make it worth your while.”"]** — Mówca: **Player**
> "“Then I will make it worth your while.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Smoked bear meat, a local delicacy, was served with eggs. After a very delicious meal, we sat down on two couches. I immediately saw the portrait of Leon "Malenyev" Chavatangakwunua staring down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[234]`

### Węzeł `[231]`
Mówca: **Emmerich Hegel**
> "“Imagine they did that to Sordish people. What would you do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[224]`
  - -> `[226]`

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Everything has a price, Chancellor Hegel. What is yours?”"]** — Mówca: **Player**
> "“Everything has a price, Chancellor Hegel. What is yours?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[233]`
**[WYBÓR GRACZA: "“Why is Valgsland so concerned with Sordland making deals with its neighbors?”"]** — Mówca: **Player**
> "“Why is Valgsland so concerned with Sordland making deals with its neighbors?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Let's talk about business, shall we?”"]** — Mówca: **Player**
> "“Let's talk about business, shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[235]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "“What can you tell me about Malenyev?”"]** — Mówca: **Player**
> "“What can you tell me about Malenyev?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
Mówca: **Emmerich Hegel**
> "“Recognize Heljiland as Valgslandian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[238]`
Mówca: **Emmerich Hegel**
> "“As if that's not enough, they kill my people in their homes in Heljiland! Slaughtering them like mere cattle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[239]`
Mówca: **Emmerich Hegel**
> "“Now that we are trade partners, I will be honest with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[240]`
Mówca: **Emmerich Hegel**
> "“Ah. You have spotted the portrait. Well. Where do I begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[242]`
Mówca: **Emmerich Hegel**
> "“Comrade Malenyev is a good friend of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Emmerich Hegel**
> "“Let me tell you what I want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[244]`
Mówca: **Emmerich Hegel**
> "“Although I don't agree with him on every matter, he demands respect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "“What do you want? Tell it to me straight.”"]** — Mówca: **Player**
> "“What do you want? Tell it to me straight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[246]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[247]`
**[WYBÓR GRACZA: "“Anything to join the pact.”"]** — Mówca: **Player**
> "“Anything to join the pact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Hegel looked down for a moment. He walked over to the window and gazed outside with his arms crossed behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[249]`
Mówca: **Emmerich Hegel**
> "“Those damn Agnolians are claiming *our* land as their own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[250]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish wheat from the Bergia region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[251]`
Mówca: **Emmerich Hegel**
> "“But I can put in a good word in with him... if you do something for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[245]`
  - -> `[247]`

### Węzeł `[252]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[253]`
Mówca: **Emmerich Hegel**
> "“The details were discussed between our ministers, but I do have a few questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[254]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Are you not reading your newspapers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[255]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish fishing output from the Agnland region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[256]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish coal from the Lorren region in return for Valgsland's hard-earned money”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[257]`
Mówca: **Emmerich Hegel**
> "“I can't tell him to simply take Sordland in, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[258]`
**[WYBÓR GRACZA: "“Whatever. He is still just a man.”"]** — Mówca: **Player**
> "“Whatever. He is still just a man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Why do you want this from me?”"]** — Mówca: **Player**
> "“Why do you want this from me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[260]`
**[WYBÓR GRACZA: "“An easy choice. I accept.”"]** — Mówca: **Player**
> "“An easy choice. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[261]`
**[WYBÓR GRACZA: "“I won't meddle in the affairs between Valgsland and Agnolia.”"]** — Mówca: **Player**
> "“I won't meddle in the affairs between Valgsland and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[262]`
Mówca: **Emmerich Hegel**
> "“You want to provide Sordish tungsten in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[263]`
Mówca: **Narrator**
> "We clinked the glasses and drank our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[264]`
Mówca: **Emmerich Hegel**
> "“I want you to recognize Heljiland as Valgslandian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`
  - -> `[261]`

### Węzeł `[265]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "“He seems like an interesting person. I would like to meet with him.”"]** — Mówca: **Player**
> "“He seems like an interesting person. I would like to meet with him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[267]`
Mówca: **Emmerich Hegel**
> "“Comrade Malenyev is a good friend of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[268]`
Mówca: **Narrator**
> "He burst into laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[269]`
Mówca: **Emmerich Hegel**
> "“Perhaps one day you will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[270]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[271]`
Mówca: **Emmerich Hegel**
> "“He would say the same thing about himself too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[272]`
Mówca: **Emmerich Hegel**
> "“It sounds like you have much more to gain from the deal than Valgsland does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[273]`
Mówca: **Emmerich Hegel**
> "“I want to mend the damage that was inflicted by the imperialism that caused our countries, once brothers, to oppose each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[274]`
Mówca: **Emmerich Hegel**
> "“If you want this deal, there is something you can do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[275]`
Mówca: **Emmerich Hegel**
> "“Please do not waste my time with senseless questions, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[276]`
Mówca: **Emmerich Hegel**
> "“Oh?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "“What do I have to do?”"]** — Mówca: **Player**
> "“What do I have to do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[279]`
Mówca: **Narrator**
> "An assistant brought in two cups of coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Emmerich Hegel**
> "“Let's begin, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[281]`
Mówca: **Narrator**
> "He called an assistant nearby. A moment later the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[282]`
Mówca: **Emmerich Hegel**
> "“You speak like the oligarchs we have long dealt with here in Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[283]`
Mówca: **Emmerich Hegel**
> "“I hear there is still an emergency declared in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "“That is none of your concern, Chancellor Hegel.”"]** — Mówca: **Player**
> "“That is none of your concern, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[288]`
Mówca: **Emmerich Hegel**
> "“I hope everything is alright.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[284]`
  - -> `[292]`

### Węzeł `[289]`
Mówca: **Emmerich Hegel**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Nothing to worry about, Chancellor Hegel. Everything has been handled.”"]** — Mówca: **Player**
> "“Nothing to worry about, Chancellor Hegel. Everything has been handled.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[291]`
Mówca: **Emmerich Hegel**
> "“It is precisely my concern. I won't make trade deals with an unstable country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`
  - -> `[295]`

### Węzeł `[292]`
**[WYBÓR GRACZA: "“Let's change the topic.”"]** — Mówca: **Player**
> "“Let's change the topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[293]`
**[WYBÓR GRACZA: "“There is nothing to worry about in terms of our trade deal.”"]** — Mówca: **Player**
> "“There is nothing to worry about in terms of our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[294]`
**[WYBÓR GRACZA: "“Who says Sordland is unstable? We're the most stable country there is.”"]** — Mówca: **Player**
> "“Who says Sordland is unstable? We're the most stable country there is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
**[WYBÓR GRACZA: "“I understand, Chancellor Hegel. Rest assured I have the situation under control.”"]** — Mówca: **Player**
> "“I understand, Chancellor Hegel. Rest assured I have the situation under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Emmerich Hegel**
> "“If you say so...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[297]`
Mówca: **Emmerich Hegel**
> "“However, our revolution here in Valgsland owes a great deal to Malenyev. He is the father of Malenyevism and a symbol of global revolution. Not only is he the first-ever communist revolutionary leader, he managed to unite a whole continent, forming the greatest country in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[258]`

### Węzeł `[298]`
Mówca: **Emmerich Hegel**
> "“We believe that the revolution in Valgsland is stable enough that we do not need the vanguardist approach of Malenyevism. We are already in the process of such a transformation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[299]`
Mówca: **Emmerich Hegel**
> "“Valgslandian Socialism aims to eliminate the power of the state through the promotion of responsibility, freedom and well-being of the people. One of our key cornerstones is the devolution of big government to smaller councils with high citizen participation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Valgsland", "Allied");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Lespia", "Unfriendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Agnolia", "Unfriendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Agnolia", "Unfriendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
