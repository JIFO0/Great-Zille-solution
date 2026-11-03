# Sordland/Turn08/ValgslandVisit_AntiCommunistRayne

- **ID konwersacji:** `163`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/163_ValgslandVisit_AntiCommunistRayne.md`
- **Liczba węzłów dialogowych:** 123
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
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
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[3]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[50]` (Paskal Beniwoll): `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true; Variable["BaseGame.Valgsland_TradeDeal...`
- Węzeł `[121]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland"] = true;`
- Węzeł `[122]` (Paskal Beniwoll): `UpdateCountryRelationship("Sordland_Country_Agnolia","Neutral");`

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
  - -> `[15]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `160` (*Sordland/Turn08/FPnT_ValgslandVisit*), Węzeł `[3]`

### Węzeł `[3]`
Mówca: **Emmerich Hegel**
> "“Have a good day, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[4]`
Mówca: **Emmerich Hegel**
> "“We are at the end of our allocated time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[5]`
Mówca: **Emmerich Hegel**
> "“Enjoy your stay in Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[6]`
  - -> `[16]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Thank you for the *warm* hospitality.”"]** — Mówca: **Player**
> "“Thank you for the *warm* hospitality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Emmerich Hegel**
> "“Sarcasm, huh? Haven't heard that one before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Emmerich Hegel**
> "“I am glad that at least we can agree on one matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[9]`
Mówca: **Emmerich Hegel**
> "“Excuses. Is that it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I won't sit idly while you insult me. The deal is off. We are finished here.”"]** — Mówca: **Player**
> "“I won't sit idly while you insult me. The deal is off. We are finished here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I am definitely not staying after this.”"]** — Mówca: **Player**
> "“I am definitely not staying after this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Emmerich Hegel**
> "“Have a safe trip back home, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[13]`
Mówca: **Emmerich Hegel**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[14]`
Mówca: **Emmerich Hegel**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Narrator**
> "He briefly scanned me from head to toe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I will. Have a good day, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I will. Have a good day, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"]** — Mówca: **Player**
> "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[18]`
Mówca: **Narrator**
> "We shook hands as he stared me down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Emmerich Hegel**
> "“I must go back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[20]`
Mówca: **Emmerich Hegel**
> "“I sincerely hope you understand that the world doesn't work that way anymore, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[21]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Welcome to Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`
  - -> `[38]`

### Węzeł `[22]`
Mówca: **Emmerich Hegel**
> "“No you don't. But you will answer to the people of your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
Mówca: **Emmerich Hegel**
> "“Recognise Heljiland as Valgslandian territory and I am ready to come to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[31]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“That's it? Sure. I will announce it as soon as possible.”"]** — Mówca: **Player**
> "“That's it? Sure. I will announce it as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Why? What are you after?”"]** — Mówca: **Player**
> "“Why? What are you after?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Emmerich Hegel**
> "“We can do so much more through unity. However, not everyone wants that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[27]`
Mówca: **Emmerich Hegel**
> "“Is that a yes or a no?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Emmerich Hegel**
> "“Do not underestimate your people, Mr. Rayne, or it might be the end of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[29]`
Mówca: **Emmerich Hegel**
> "“Perhaps in the past, but not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[30]`
Mówca: **Emmerich Hegel**
> "“Then consider our trade deal sealed, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[32]`
Mówca: **Emmerich Hegel**
> "“Are you saying that you're not only weak, but also can't own up to your mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Fine. Deal.”"]** — Mówca: **Player**
> "“Fine. Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I reject. You are asking for too much.”"]** — Mówca: **Player**
> "“I reject. You are asking for too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[35]`
Mówca: **Emmerich Hegel**
> "“I have no qualms about what has been negotiated so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“It's good to be here.”"]** — Mówca: **Player**
> "“It's good to be here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“So. Where do we begin?”"]** — Mówca: **Player**
> "“So. Where do we begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
Mówca: **Emmerich Hegel**
> "“Then consider our trade deal sealed, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I don't answer to you, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I don't answer to you, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[41]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Shake hands."]** — Mówca: **Player_Italic**
> "We shook hands on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I didn't shake his hand. He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He gestured towards the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Emmerich Hegel**
> "“After all, it was the people who brought imperialism to its knees.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[46]`
Mówca: **Emmerich Hegel**
> "“This was made in 1776 by the famous Valgslandian painter, Otto Kiebern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "I looked at the painting. It must've been over five meters tall. It was a battle scene. On the left side there were banners carried by Valgs; on the right, Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Narrator**
> "He turned around and walked away, leaving me alone in the empty halls of the Royal Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[49]`
Mówca: **Emmerich Hegel**
> "“To be honest, you do not surprise me, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Valgsland_TradeDeal = true;
BaseGame.Agnolia_HeljilandRecognised = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Valgsland_TradeDeal"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Countless spears formed a triangle at the center. The sky was red from the blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[53]`
Mówca: **Emmerich Hegel**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[56]`
Mówca: **Emmerich Hegel**
> "“Listen, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[57]`
Mówca: **Emmerich Hegel**
> "“What I want is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Nothing. It's just a painting.”"]** — Mówca: **Player**
> "“Nothing. It's just a painting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“It is a reminder. One misstep and we are back to painting the world with more blood.”"]** — Mówca: **Player**
> "“It is a reminder. One misstep and we are back to painting the world with more blood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[60]`
Mówca: **Emmerich Hegel**
> "“Let me tell you this, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[64]`
Mówca: **Emmerich Hegel**
> "“I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“You have the gall to say that after all this?”"]** — Mówca: **Player**
> "“You have the gall to say that after all this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Let's hear it. What do you want?”"]** — Mówca: **Player**
> "“Let's hear it. What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“You are making it less likely with every minute passing.”"]** — Mówca: **Player**
> "“You are making it less likely with every minute passing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[68]`
Mówca: **Emmerich Hegel**
> "“You have come here for a trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
Mówca: **Emmerich Hegel**
> "“You started privatizing your economy and sold state assets to make the rich even richer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[73]`
Mówca: **Emmerich Hegel**
> "“As the leaders of this world, we must be careful, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[74]`
Mówca: **Emmerich Hegel**
> "“A trade deal between Valgsland and Sordland is possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[67]`

### Węzeł `[75]`
Mówca: **Emmerich Hegel**
> "“I must admit I have been watching your rule with worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[76]`
Mówca: **Emmerich Hegel**
> "“A response that I expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[77]`
Mówca: **Emmerich Hegel**
> "“True. But I can certainly make your life harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[81]`
Mówca: **Emmerich Hegel**
> "“Your actions are clear as day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[91]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Emmerich Hegel**
> "“Then let's talk about your deal and we will call it a day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[84]`
  - -> `[10]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“My hand was forced when I made those decisions.”"]** — Mówca: **Player**
> "“My hand was forced when I made those decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“You have just lowered your chances of achieving a trade deal.”"]** — Mówca: **Player**
> "“You have just lowered your chances of achieving a trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[85]`
Mówca: **Emmerich Hegel**
> "“Especially around those who are willing and ready to do precisely that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“That's enough! I didn't come here to hear threats. We are done here!”"]** — Mówca: **Player**
> "“That's enough! I didn't come here to hear threats. We are done here!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“You don't have to like me to trade with Sordland.”"]** — Mówca: **Player**
> "“You don't have to like me to trade with Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Then it goes both ways, Chancellor Hegel.”"]** — Mówca: **Player**
> "“Then it goes both ways, Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I expect nothing more.”"]** — Mówca: **Player**
> "“I expect nothing more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[90]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Chancellor Hegel. Please. Sordland's concerns are Sordland's alone.”"]** — Mówca: **Player**
> "“Chancellor Hegel. Please. Sordland's concerns are Sordland's alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[92]`
Mówca: **Emmerich Hegel**
> "“My problem is with you, Mr. Rayne. It's with how you lead Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`
  - -> `[86]`

### Węzeł `[93]`
Mówca: **Emmerich Hegel**
> "“From the looks of it, you need this more than I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[97]`
Mówca: **Emmerich Hegel**
> "“I am even impartial to the trade deal you have made with those damn Agnolians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[104]`
Mówca: **Emmerich Hegel**
> "“No. My problem is not with the deal itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[105]`
Mówca: **Emmerich Hegel**
> "“You banned completely legal organizations such as the Red Youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[106]`
Mówca: **Emmerich Hegel**
> "“It's a good deal, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Emmerich Hegel**
> "“Here is what I am proposing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[108]`
Mówca: **Emmerich Hegel**
> "“Sordish fishing output from the Agnland region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Emmerich Hegel**
> "“Sordish wheat from the Bergia region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[110]`
Mówca: **Emmerich Hegel**
> "“Sordish coal from the Lorren region in return for Valgsland's hard-earned money”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[111]`
Mówca: **Emmerich Hegel**
> "“Sordish tungsten in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
Mówca: **Emmerich Hegel**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[116]`
Mówca: **Emmerich Hegel**
> "“You accepted Arcasian aid and sold your sovereignty by letting them build bases.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[120]`
Mówca: **Emmerich Hegel**
> "“You extended the emergency in your country with seemingly no end in sight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Agnolia", "Neutral");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
