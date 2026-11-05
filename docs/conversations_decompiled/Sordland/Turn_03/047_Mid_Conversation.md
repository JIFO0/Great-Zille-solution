# Sordland/Turn03/Mid Conversation

- **ID konwersacji:** `47`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/047_Mid_Conversation.md`
- **Liczba węzłów dialogowych:** 224
- **Liczba wyborów gracza:** 62

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Promise_Diplomacy_None`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[117]` -> **[46] Sordland/Turn03/Personal_HelicopterEscape** (../Turn_03/046_Personal_HelicopterEscape.md), Węzeł `[279]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **""A little ironic, isn't it? You escaped the bureaucrats, but by increasing Sordlan..."** | `[18]` **Ewald Alphonso**: ""The fresh sea breeze, the energ..." | `Variable["BaseGame.Promise_Diplomacy_None"] == true` | *Brak zmian stanu* | `[37]` **Ewald Alphonso**: ""A valid concern, {BaseGameText...." |
| `[20]` | **""I wish I could escape like that. But I never stop thinking about my duties in Hol..."** | `[18]` **Ewald Alphonso**: ""The fresh sea breeze, the energ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Ewald Alphonso**: ""That's no good, {BaseGameText.A..." |
| `[21]` | **""I couldn't agree with you more. I really should get out of Holsord more often.""** | `[18]` **Ewald Alphonso**: ""The fresh sea breeze, the energ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Ewald Alphonso**: ""It does you good, being exposed..." |
| `[30]` | **""Mr. Alphonso, your political career is well-known. Perhaps we should focus on the..."** | `[27]` **Ewald Alphonso**: ""But even after winning the part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Ewald Alphonso**: ""Of course. It's easy to dwell i..." |
| `[31]` | **""Free-market reforms were a significant departure. You couldn't expect the traditi..."** | `[27]` **Ewald Alphonso**: ""But even after winning the part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Ewald Alphonso**: ""It wasn't easy. The USP had a c..." |
| `[32]` | **""So your economic expertise was what gave you the edge against Soll. Quite the fea..."** | `[27]` **Ewald Alphonso**: ""But even after winning the part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Ewald Alphonso**: ""Thank you, Mr. President. I tri..." |
| `[33]` | **""You sound quite proud of your achievements. But what about the effects of your re..."** | `[27]` **Ewald Alphonso**: ""But even after winning the part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Ewald Alphonso**: ""Yes, and that's something I reg..." |
| `[34]` | **""You must have arrived shortly after the Battle of Holsord ended.""** | `[26]` **Ewald Alphonso**: ""As an engineer, my focus was on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Ewald Alphonso**: ""Ah, the Battle of Holsord. A tr..." |
| `[35]` | **""I understand that those were tumultuous times. The Great Betrayal was not so long..."** | `[26]` **Ewald Alphonso**: ""As an engineer, my focus was on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Ewald Alphonso**: ""The Great Betrayal... It was a ..." |
| `[36]` | **""The State Educators Corps and Sollonomics also played significant roles in the re..."** | `[26]` **Ewald Alphonso**: ""As an engineer, my focus was on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Ewald Alphonso**: ""That's what they say. But in my..." |
| `[45]` | **""Wow. That story speaks volumes about your dedication to Gasom.""** | `[44]` **Ewald Alphonso**: ""We had two days to get the gas ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Ewald Alphonso**: ""The whole company is like that...." |
| `[46]` | **""Your story is impressive, but shouldn't Gasom have had contingency plans for such..."** | `[44]` **Ewald Alphonso**: ""We had two days to get the gas ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Ewald Alphonso**: ""You're right, and we learned th..." |
| `[47]` | **""Fascinating. But I hope those incidents aren't too frequent at Gasom.""** | `[44]` **Ewald Alphonso**: ""We had two days to get the gas ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Ewald Alphonso**: ""Don't worry, {BaseGameText.Alph..." |
| `[56]` | **""So Gasom's success hinged on your personal heroics? That's not a sustainable stra..."** | `[44]` **Ewald Alphonso**: ""We had two days to get the gas ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Ewald Alphonso**: ""No, of course not. We had a goo..." |
| `[62]` | **""It's not about rejecting Gasom, it's about evaluating the best for Sordland. Not ..."** | `[61]` **Ewald Alphonso**: ""That deal put Gasom, and in tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Ewald Alphonso**: ""That may be true. But only shoo..." |
| `[65]` | **""They're over-relying on a single sector. It could leave them vulnerable in the lo..."** | `[76]` **Ewald Alphonso**: ""But perhaps, Mr. President, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Ewald Alphonso**: ""I don't think so. Their diversi..." |
| `[67]` | **""I respect your perspective, Alphonso. But not every risk guarantees a reward.""** | `[61]` **Ewald Alphonso**: ""That deal put Gasom, and in tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Ewald Alphonso**: ""I understand that, Mr. Presiden..." |
| `[68]` | **""It's obvious by now that our visions for Sordland differ. I believe in a diversif..."** | `[61]` **Ewald Alphonso**: ""That deal put Gasom, and in tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Ewald Alphonso**: ""Diversification is wise, but so..." |
| `[69]` | **""You've built a successful business, Alphonso. But the state isn't a business. The..."** | `[61]` **Ewald Alphonso**: ""That deal put Gasom, and in tur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Ewald Alphonso**: ""That doesn't mean we can't appl..." |
| `[73]` | **""Are you suggesting we follow Anraka's model despite our vastly different historie..."** | `[76]` **Ewald Alphonso**: ""But perhaps, Mr. President, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Ewald Alphonso**: ""I'm not suggesting we copy Anra..." |
| `[77]` | **""Which of their strategies do you suggest we adapt?""** | `[76]` **Ewald Alphonso**: ""But perhaps, Mr. President, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Ewald Alphonso**: ""Well, for one, their focus on o..." |
| `[78]` | **""Are you willing to consider other sectors for investment, or is your focus solely..."** | `[76]` **Ewald Alphonso**: ""But perhaps, Mr. President, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Ewald Alphonso**: ""While my focus is on energy, I ..." |
| `[83]` | **""My actions are always guided by my commitment to the Sordish people, not personal..."** | `[93]` **Ewald Alphonso**: ""While we're on the topic of tru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "The helicopter tilted to the rig..." |
| `[87]` | **""Do you ever worry that your focus on profit might come at the expense of the Sord..."** | `[81]` **Ewald Alphonso**: ""While my focus is on energy, I ..."<br>`[84]` **Ewald Alphonso**: ""I don't think so. Their diversi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Ewald Alphonso**: ""Mr. President, I understand the..." |
| `[88]` | **""Your dealings have been under scrutiny before, Alphonso. Can you assure me that y..."** | `[81]` **Ewald Alphonso**: ""While my focus is on energy, I ..."<br>`[84]` **Ewald Alphonso**: ""I don't think so. Their diversi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Ewald Alphonso**: ""Of course it's self-serving, Mr..." |
| `[89]` | **""Why should I trust you, Alphonso, when you've been known to prioritize business o..."** | `[81]` **Ewald Alphonso**: ""While my focus is on energy, I ..."<br>`[84]` **Ewald Alphonso**: ""I don't think so. Their diversi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Ewald Alphonso**: ""Trust is earned, Mr. President...." |
| `[90]` | **""Every decision I've made was in the best interest of Sordland and its citizens.""** | `[93]` **Ewald Alphonso**: ""While we're on the topic of tru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "The helicopter tilted to the rig..." |
| `[94]` | **""I don't need to justify my actions to you, Mr. Alphonso. You are Sordland's past;..."** | `[93]` **Ewald Alphonso**: ""While we're on the topic of tru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "The helicopter tilted to the rig..." |
| `[97]` | **""Thank you, Serge. It's good to be reminded that we all share a common goal.""** | `[96]` **Serge Wolkner**: ""Mr. President, Mr. Alphonso, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Serge Wolkner**: ""That's very kind of you, Mr. Pr..." |
| `[98]` | **""Serge, do you believe that our duty to the Sordish people should be our guiding p..."** | `[96]` **Serge Wolkner**: ""Mr. President, Mr. Alphonso, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Serge Wolkner**: ""I believe so, Mr. President. Th..." |
| `[99]` | **""Serge, your perspective is refreshing, but a bit naive. The world of politics and..."** | `[96]` **Serge Wolkner**: ""Mr. President, Mr. Alphonso, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Serge Wolkner**: ""You're right, Mr. President. Pl..." |
| `[102]` | **""Serge is loyal to his duty and to Sordland, Alphonso. I suggest you respect that.""** | `[101]` **Serge Wolkner**: ""I appreciate the offer, Mr. Alp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Ewald Alphonso**: ""Of course, Mr. President. I mea..." |
| `[103]` | **""Serge, you don't need to answer that. This is not the time or place.""** | `[101]` **Serge Wolkner**: ""I appreciate the offer, Mr. Alp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Ewald Alphonso**: ""Apologies, Mr. President. I did..." |
| `[104]` | **""Alphonso, I hope you're not trying to poach my staff mid-flight!""** | `[101]` **Serge Wolkner**: ""I appreciate the offer, Mr. Alp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Ewald Alphonso**: ""Just a friendly offer, Mr. Pres..." |
| `[109]` | **""I am glad to see you value Serge's skills, Alphonso. But I need him more than you..."** | `[101]` **Serge Wolkner**: ""I appreciate the offer, Mr. Alp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Ewald Alphonso**: ""I understand, Mr. President. It..." |
| `[110]` | **""Serge, in your view, is it possible to balance business interests with a commitme..."** | `[96]` **Serge Wolkner**: ""Mr. President, Mr. Alphonso, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Serge Wolkner**: ""Mr. President, I don't know muc..." |
| `[119]` | **""Your reforms had quite a few critics, actually. Some said they directly caused th..."** | `[118]` **Ewald Alphonso**: ""I appreciate your support, Mr. ..."<br>`[134]` **Ewald Alphonso**: ""I appreciate your candid feedba..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false` | *Brak zmian stanu* | `[121]` **Ewald Alphonso**: ""It's easy to pass judgement in ..." |
| `[120]` | **""I'm not sure any amount of reform could have prevented the recession of '51. Do y..."** | `[118]` **Ewald Alphonso**: ""I appreciate your support, Mr. ..."<br>`[134]` **Ewald Alphonso**: ""I appreciate your candid feedba..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false` | *Brak zmian stanu* | `[145]` **Ewald Alphonso**: ""You're correct, Mr. President. ..." |
| `[122]` | **""Your rapid privatization plan destabilized key sectors of our economy, leading to..."** | `[118]` **Ewald Alphonso**: ""I appreciate your support, Mr. ..."<br>`[134]` **Ewald Alphonso**: ""I appreciate your candid feedba..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false` | *Brak zmian stanu* | `[142]` **Ewald Alphonso**: ""Destabilization wasn't my goal...." |
| `[123]` | **""Do you think the economic downturn could have been avoided if the Old Guard hadn'..."** | `[118]` **Ewald Alphonso**: ""I appreciate your support, Mr. ..."<br>`[134]` **Ewald Alphonso**: ""I appreciate your candid feedba..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false` | *Brak zmian stanu* | `[141]` **Ewald Alphonso**: ""The resistance from the Old Gua..." |
| `[129]` | **""We did what we had to do to save the party and the country. I hope you can unders..."** | `[128]` **Ewald Alphonso**: ""Flipping my supporters, snaking..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Ewald Alphonso**: ""In the world of politics, we of..." |
| `[143]` | **""Do you still resent me for the way things turned out?""** | `[128]` **Ewald Alphonso**: ""Flipping my supporters, snaking..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Ewald Alphonso**: ""Resentment doesn't do anyone an..." |
| `[146]` | **""You were losing control, Alphonso. My intervention was necessary to steer the par..."** | `[128]` **Ewald Alphonso**: ""Flipping my supporters, snaking..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Ewald Alphonso**: ""I understand why you intervened..." |
| `[155]` | **""I see potential for collaboration, particularly in offshore resource extraction a..."** | `[154]` **Ewald Alphonso**: ""Gasom has multiple engineers hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Ewald Alphonso**: ""Precisely, Mr. President. It's ..." |
| `[156]` | **""I'm impressed as well, but it's crucial we remain cautious. Anraka's history of p..."** | `[154]` **Ewald Alphonso**: ""Gasom has multiple engineers hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Ewald Alphonso**: ""Your concern is valid, Mr. Pres..." |
| `[157]` | **""We should rather focus on Sordland's own strengths. Our future lies in building a..."** | `[154]` **Ewald Alphonso**: ""Gasom has multiple engineers hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Ewald Alphonso**: ""Absolutely, Mr. President. Stre..." |
| `[158]` | **""Anraka has potential. But isn't Rumburg already a counterbalance to the United Co..."** | `[154]` **Ewald Alphonso**: ""Gasom has multiple engineers hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Ewald Alphonso**: ""Rumburg does indeed possess sig..." |
| `[169]` | **""You were part of the USP during Soll's rule. You supported his policies then. Wha..."** | `[27]` **Ewald Alphonso**: ""But even after winning the part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Ewald Alphonso**: ""You're correct, Mr. President. ..." |
| `[170]` | **""Do you think the growth and prosperity of Lachaven can be replicated in other par..."** | `[189]` **Ewald Alphonso**: ""Without the investments that he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Ewald Alphonso**: ""Honestly, the key lies in strat..." |
| `[171]` | **""It took time for their vision to be realized. They didn't even see it come to ful..."** | `[189]` **Ewald Alphonso**: ""Without the investments that he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Ewald Alphonso**: ""That's a great point, Mr. Presi..." |
| `[172]` | **""The Kingdom was a different era. Do you think its strategies can be applied in ou..."** | `[189]` **Ewald Alphonso**: ""Without the investments that he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Ewald Alphonso**: ""Indeed, Mr. President. While th..." |
| `[173]` | **""You may be right. But not all cities have Lachaven's potential or resources.""** | `[189]` **Ewald Alphonso**: ""Without the investments that he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Ewald Alphonso**: ""You're absolutely right, Mr. Pr..." |
| `[174]` | **""It must have been interesting, navigating all the changing political dynamics as ..."** | `[26]` **Ewald Alphonso**: ""As an engineer, my focus was on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Ewald Alphonso**: ""The dynamics in Holsord were......" |
| `[178]` | **""I believe that Lachaven's success today is due to the collective effort of its pe..."** | `[189]` **Ewald Alphonso**: ""Without the investments that he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Ewald Alphonso**: ""But would their efforts have be..." |
| `[184]` | **""Sounds like a momentous time to be in Holsord. How did it feel to be part of the ..."** | `[26]` **Ewald Alphonso**: ""As an engineer, my focus was on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Ewald Alphonso**: ""It was a truly incredible exper..." |
| `[190]` | **""You speak of escaping from old bureaucrats. But isn't the capitalist system you p..."** | `[18]` **Ewald Alphonso**: ""The fresh sea breeze, the energ..." | `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true` | *Brak zmian stanu* | `[191]` **Ewald Alphonso**: ""An interesting perspective, {Ba..." |
| `[200]` | **""I didn't campaign for you because of your economic reforms, but because I wanted ..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true` | *Brak zmian stanu* | `[138]` **Ewald Alphonso**: ""Regardless of your motivations,..." |
| `[201]` | **""To be honest, I never agreed with your economic reforms. I felt they disproportio..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | *Brak zmian stanu* | `[139]` **Ewald Alphonso**: ""I understand your viewpoint, Mr..." |
| `[202]` | **""To be frank, Mr. Alphonso, I didn't campaign for you because I didn't like the di..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | *Brak zmian stanu* | `[135]` **Ewald Alphonso**: ""Your honesty is appreciated, Mr..." |
| `[203]` | **""I can tell you now that I didn't support your campaign. I felt that the USP was m..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | *Brak zmian stanu* | `[136]` **Ewald Alphonso**: ""That's a fair critique, Mr. Pre..." |
| `[204]` | **""I'm sure you remember that I campaigned for you. I believed in your economic visi..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true` | *Brak zmian stanu* | `[118]` **Ewald Alphonso**: ""I appreciate your support, Mr. ..." |
| `[205]` | **""Even when I was campaigning for you, I had reservations about your economic platf..."** | `[12]` **Ewald Alphonso**: ""But I believed in what I was do..."<br>`[13]` **Ewald Alphonso**: ""Winning the leadership was a cr..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true` | *Brak zmian stanu* | `[137]` **Ewald Alphonso**: ""A valid perspective. Balancing ..." |

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
  - -> `[211]` (*Narrator: "From here, it was even more evident what a pivotal role t..."*)

### Węzeł `[3]`
Mówca: **Ewald Alphonso**
> ""Of course. It's easy to dwell in the past, but it's the present that requires our attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[4]`
Mówca: **Ewald Alphonso**
> ""Ah, the Battle of Holsord. A tragic moment in our history. I wasn't directly involved, but I saw its devastating effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Ewald Alphonso: ""I can still recall the sight of the city in ruins, the p..."*)

### Węzeł `[5]`
Mówca: **Ewald Alphonso**
> ""I can still recall the sight of the city in ruins, the people despairing. It was a stark reminder of the cost of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ewald Alphonso: ""Still, what I remember most about those times was the se..."*)

### Węzeł `[6]`
Mówca: **Ewald Alphonso**
> ""The Great Betrayal... It was a dark time, and not only for the monarchists. The entire city was gripped by fear and suspicion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Ewald Alphonso: ""But we pushed through. Despite the upheaval, the work of..."*)

### Węzeł `[7]`
Mówca: **Ewald Alphonso**
> ""But we pushed through. Despite the upheaval, the work of rebuilding the capital couldn't be put on hold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ewald Alphonso: ""It was disheartening, but there was still a sense in tho..."*)

### Węzeł `[8]`
Mówca: **Ewald Alphonso**
> ""That's what they say. But in my opinion, their flaws outweighed their merits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Ewald Alphonso: ""The Corps, for instance, established a sense of order th..."*)

### Węzeł `[9]`
Mówca: **Ewald Alphonso**
> ""The Corps, for instance, established a sense of order that helped the populace recover, but its indoctrination methods were questionable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Ewald Alphonso: ""As for Sollonomics, it did help stabilize the economy, b..."*)

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
> ""As for Sollonomics, it did help stabilize the economy, but it also led to a heavy centralization of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Ewald Alphonso: ""Before that, I had the sense that truly anything was pos..."*)

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
> ""It wasn't easy. The USP had a certain way of doing things, and quite a few members saw my reforms as a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Ewald Alphonso: ""But I believed in what I was doing, and I was persistent..."*)

### Węzeł `[12]`
Mówca: **Ewald Alphonso**
> ""But I believed in what I was doing, and I was persistent. Eventually, I managed to win over the number of supporters I needed to overhaul the system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[13]`
Mówca: **Ewald Alphonso**
> ""Winning the leadership was a critical step towards implementing the reforms Sordland so desperately needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> ""But we must remember the state the country was in when I took over. We were stagnant, and change was necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Ewald Alphonso: ""Unfortunately, economic reforms often have unintended si..."*)

### Węzeł `[15]`
Mówca: **Ewald Alphonso**
> ""Unfortunately, economic reforms often have unintended side effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""Thank you, Mr. President. I tried my best to use my expertise to benefit the party and the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Ewald Alphonso: ""Winning the leadership was a critical step towards imple..."*)

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> ""Yes, and that's something I regret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ewald Alphonso: ""But we must remember the state the country was in when I..."*)

### Węzeł `[18]`
Mówca: **Ewald Alphonso**
> ""The fresh sea breeze, the energy of the city... it's always so invigorating. Makes you forget about the stuffy old bureaucrats trying to get in the way of your policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[20]` (*Player: ""I wish I could escape like that. But I never stop thinki..."*)
  - -> `[21]` (*Player: ""I couldn't agree with you more. I really should get out ..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A little ironic, isn't it? You escaped the bureaucrats, but by increasing Sordland's reliance on global trade and foreign powers, you traded one set of chains for another.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_None"] == true`
- **Kontekst wejściowy (poprzednik):** `[18]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Ewald Alphonso: ""A valid concern, {BaseGameText.AlphonsoToPlayer}. But in..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish I could escape like that. But I never stop thinking about my duties in Holsord. Even now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Ewald Alphonso: ""That's no good, {BaseGameText.AlphonsoToPlayer}. You can..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I couldn't agree with you more. I really should get out of Holsord more often.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Ewald Alphonso: ""It does you good, being exposed to life outside the poli..."*)

### Węzeł `[22]`
Mówca: **Ewald Alphonso**
> ""I always used to go here to escape the political pressure in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ewald Alphonso: ""The fresh sea breeze, the energy of the city... it's alw..."*)

### Węzeł `[23]`
Mówca: **Ewald Alphonso**
> ""Nothing like Holsord, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He looked lost in thought for a moment. Then he continued."*)

### Węzeł `[24]`
Mówca: **Ewald Alphonso**
> ""I do miss the capital sometimes. I still remember arriving there fresh from Arcasia, brimming with enthusiasm and ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ewald Alphonso: ""As an engineer, my focus was on the energy infrastructur..."*)

### Węzeł `[25]`
Mówca: **Ewald Alphonso**
> ""I think it was that feeling that led me to enter the political sphere in the '40s. I could tell the country was stagnating, and I used my knowledge of free-market reforms to garner support within the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ewald Alphonso: ""But even after winning the party leadership against Soll..."*)

### Węzeł `[26]`
Mówca: **Ewald Alphonso**
> ""As an engineer, my focus was on the energy infrastructure of Holsord. We had many blackouts back then. It was a challenging time -- the aftermath of the Civil War was still evident everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""You must have arrived shortly after the Battle of Holsor..."*)
  - -> `[35]` (*Player: ""I understand that those were tumultuous times. The Great..."*)
  - -> `[36]` (*Player: ""The State Educators Corps and Sollonomics also played si..."*)
  - -> `[184]` (*Player: ""Sounds like a momentous time to be in Holsord. How did i..."*)
  - -> `[174]` (*Player: ""It must have been interesting, navigating all the changi..."*)

### Węzeł `[27]`
Mówca: **Ewald Alphonso**
> ""But even after winning the party leadership against Soll, my time in office was a continuous struggle to dismantle old USP structures and bring about prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Mr. Alphonso, your political career is well-known. Perha..."*)
  - -> `[31]` (*Player: ""Free-market reforms were a significant departure. You co..."*)
  - -> `[32]` (*Player: ""So your economic expertise was what gave you the edge ag..."*)
  - -> `[33]` (*Player: ""You sound quite proud of your achievements. But what abo..."*)
  - -> `[169]` (*Player: ""You were part of the USP during Soll's rule. You support..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He looked lost in thought for a moment. Then he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ewald Alphonso: ""I do miss the capital sometimes. I still remember arrivi..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Alphonso seemed to retreat into his memories for a moment. A gust of wind rattled the helicopter as he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Ewald Alphonso: ""I think it was that feeling that led me to enter the pol..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, your political career is well-known. Perhaps we should focus on the present?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Ewald Alphonso: ""Of course. It's easy to dwell in the past, but it's the ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Free-market reforms were a significant departure. You couldn't expect the traditionalists in the USP to swallow them whole.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Ewald Alphonso: ""It wasn't easy. The USP had a certain way of doing thing..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So your economic expertise was what gave you the edge against Soll. Quite the feat, I must say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ewald Alphonso: ""Thank you, Mr. President. I tried my best to use my expe..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You sound quite proud of your achievements. But what about the effects of your reforms on the common people? Didn't the wealth gap widen during your tenure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ewald Alphonso: ""Yes, and that's something I regret.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You must have arrived shortly after the Battle of Holsord ended.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Ewald Alphonso: ""Ah, the Battle of Holsord. A tragic moment in our histor..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand that those were tumultuous times. The Great Betrayal was not so long in the past, was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Ewald Alphonso: ""The Great Betrayal... It was a dark time, and not only f..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The State Educators Corps and Sollonomics also played significant roles in the rebuilding of Holsord, didn't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Ewald Alphonso: ""That's what they say. But in my opinion, their flaws out..."*)

### Węzeł `[37]`
Mówca: **Ewald Alphonso**
> ""A valid concern, {BaseGameText.AlphonsoToPlayer}. But in a globalizing world, complete isolation isn't a viable strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Ewald Alphonso: ""We need to carve out a path that allows Sordland to bene..."*)

### Węzeł `[38]`
Mówca: **Ewald Alphonso**
> ""That's no good, {BaseGameText.AlphonsoToPlayer}. You can't make the right political decisions if you're never exposed to life outside the bubble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: ""It reminded me of the potential of Sordland, of what our..."*)

### Węzeł `[39]`
Mówca: **Ewald Alphonso**
> ""It does you good, being exposed to life outside the political bubble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Ewald Alphonso: ""For me, it shaped my political strategies, making them m..."*)

### Węzeł `[40]`
Mówca: **Ewald Alphonso**
> ""You know, looking at the sea reminds me of an incident from my early days at Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Ewald Alphonso: ""We had a big deal with a client from Xina, but a gas tan..."*)

### Węzeł `[41]`
Mówca: **Ewald Alphonso**
> ""For me, it shaped my political strategies, making them more people-centric and grounded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso: ""You know, looking at the sea reminds me of an incident f..."*)

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""It reminded me of the potential of Sordland, of what our nation could be if we embraced change and diversity as Lachaven has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso: ""You know, looking at the sea reminds me of an incident f..."*)

### Węzeł `[43]`
Mówca: **Ewald Alphonso**
> ""We had a big deal with a client from Xina, but a gas tanker broke down mid-journey. The delivery was at risk. It was winter, the seas were rough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ewald Alphonso: ""We had two days to get the gas to its destination or we'..."*)

### Węzeł `[44]`
Mówca: **Ewald Alphonso**
> ""We had two days to get the gas to its destination or we'd lose the client. So, I chartered a small cargo ship, braved the stormy seas, and supervised the transfer of the containers myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""Wow. That story speaks volumes about your dedication to ..."*)
  - -> `[56]` (*Player: ""So Gasom's success hinged on your personal heroics? That..."*)
  - -> `[46]` (*Player: ""Your story is impressive, but shouldn't Gasom have had c..."*)
  - -> `[47]` (*Player: ""Fascinating. But I hope those incidents aren't too frequ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wow. That story speaks volumes about your dedication to Gasom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ewald Alphonso: ""The whole company is like that. We'll do whatever it tak..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your story is impressive, but shouldn't Gasom have had contingency plans for such situations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ewald Alphonso: ""You're right, and we learned that lesson the hard way. S..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fascinating. But I hope those incidents aren't too frequent at Gasom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Ewald Alphonso: ""Don't worry, {BaseGameText.AlphonsoToPlayer}. We've come..."*)

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
> ""The whole company is like that. We'll do whatever it takes for our clients.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Ewald Alphonso: ""I always used to go here to escape the political pressur..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)

### Węzeł `[52]`
Mówca: **Ewald Alphonso**
> ""Take a look, Mr. President. That's the world out there in the Lachaven harbor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[53]`
Mówca: **Ewald Alphonso**
> ""No, of course not. We had a good look at our risk management and strategic planning after that debacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[54]`
Mówca: **Ewald Alphonso**
> ""You're right, and we learned that lesson the hard way. Since then, we've implemented extensive contingency plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[55]`
Mówca: **Ewald Alphonso**
> ""Don't worry, {BaseGameText.AlphonsoToPlayer}. We've come a long way since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So Gasom's success hinged on your personal heroics? That's not a sustainable strategy for a corporation, is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Ewald Alphonso: ""No, of course not. We had a good look at our risk manage..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Neutral == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Ewald Alphonso: ""Nothing like Holsord, is it?""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Ewald Alphonso: ""Take a look, Mr. President. That's the world out there i..."*)

### Węzeł `[60]`
Mówca: **Ewald Alphonso**
> ""I remember when we were negotiating our first international contract. We had engineered new excavation methods, but they were untested, unknown. The other side had many alternatives. They could have chosen any established player, but they chose us, a Sordish company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Ewald Alphonso: ""Why, you ask? Because we were willing to take risks for ..."*)

### Węzeł `[61]`
Mówca: **Ewald Alphonso**
> ""That deal put Gasom, and in turn Sordland, on the global map. Now, we're a force to be reckoned with in the energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I respect your perspective, Alphonso. But not every risk..."*)
  - -> `[68]` (*Player: ""It's obvious by now that our visions for Sordland differ..."*)
  - -> `[62]` (*Player: ""It's not about rejecting Gasom, it's about evaluating th..."*)
  - -> `[69]` (*Player: ""You've built a successful business, Alphonso. But the st..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's not about rejecting Gasom, it's about evaluating the best for Sordland. Not all that glitters is gold, Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ewald Alphonso: ""That may be true. But only shooting stars break the mold.""*)

### Węzeł `[63]`
Mówca: **Ewald Alphonso**
> ""That may be true. But only shooting stars break the mold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Ewald Alphonso: ""Look at the Federation of Anrakan Isles. They've success..."*)

### Węzeł `[64]`
Mówca: **Ewald Alphonso**
> ""You didn't just reject a business deal back at Gasom. You rejected a chance to further our nation's reach in the global market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Ewald Alphonso: ""I remember when we were negotiating our first internatio..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're over-relying on a single sector. It could leave them vulnerable in the long run.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Ewald Alphonso: ""I don't think so. Their diversification within the energ..."*)

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Why, you ask? Because we were willing to take risks for the greater reward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Ewald Alphonso: ""That deal put Gasom, and in turn Sordland, on the global..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I respect your perspective, Alphonso. But not every risk guarantees a reward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ewald Alphonso: ""I understand that, Mr. President. But without risk, ther..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's obvious by now that our visions for Sordland differ. I believe in a diversified approach, not just relying on one sector or company.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Ewald Alphonso: ""Diversification is wise, but so is recognizing and capit..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've built a successful business, Alphonso. But the state isn't a business. The risk is carried by our citizens, not shareholders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Ewald Alphonso: ""That doesn't mean we can't apply successful business str..."*)

### Węzeł `[70]`
Mówca: **Ewald Alphonso**
> ""I understand that, Mr. President. But without risk, there's no innovation, no progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Ewald Alphonso: ""Look at the Federation of Anrakan Isles. They've success..."*)

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> ""Diversification is wise, but so is recognizing and capitalizing on our strengths, of which energy is certainly one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Ewald Alphonso: ""Look at the Federation of Anrakan Isles. They've success..."*)

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""Their extensive offshore oil and gas operations and expansive trade relations are proof that their willingness to seize opportunities, even in the face of adversity, has paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Ewald Alphonso: ""But perhaps, Mr. President, you don't share the same adm..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you suggesting we follow Anraka's model despite our vastly different histories and challenges?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Ewald Alphonso: ""I'm not suggesting we copy Anraka's model verbatim, Mr. ..."*)

### Węzeł `[74]`
Mówca: **Ewald Alphonso**
> ""That doesn't mean we can't apply successful business strategies for the benefit of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Ewald Alphonso: ""Look at the Federation of Anrakan Isles. They've success..."*)

### Węzeł `[75]`
Mówca: **Ewald Alphonso**
> ""Look at the Federation of Anrakan Isles. They've successfully leveraged their strengths in sea exploration, resource extraction, and naval technology, and turned their geography into an advantage. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ewald Alphonso: ""Their extensive offshore oil and gas operations and expa..."*)

### Węzeł `[76]`
Mówca: **Ewald Alphonso**
> ""But perhaps, Mr. President, you don't share the same admiration for Anraka's strategy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""Are you suggesting we follow Anraka's model despite our ..."*)
  - -> `[77]` (*Player: ""Which of their strategies do you suggest we adapt?""*)
  - -> `[65]` (*Player: ""They're over-relying on a single sector. It could leave ..."*)
  - -> `[78]` (*Player: ""Are you willing to consider other sectors for investment..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Which of their strategies do you suggest we adapt?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Ewald Alphonso: ""Well, for one, their focus on offshore extraction and na..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you willing to consider other sectors for investment, or is your focus solely on energy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Ewald Alphonso: ""While my focus is on energy, I am not blind to the poten..."*)

### Węzeł `[79]`
Mówca: **Ewald Alphonso**
> ""I'm not suggesting we copy Anraka's model verbatim, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Ewald Alphonso: ""I'm only saying that we have much to learn from them.""*)

### Węzeł `[80]`
Mówca: **Ewald Alphonso**
> ""Well, for one, their focus on offshore extraction and naval technology could be beneficial for us, given our lengthy coastline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Ewald Alphonso: ""Also, their willingness to foster strong international t..."*)

### Węzeł `[81]`
Mówca: **Ewald Alphonso**
> ""While my focus is on energy, I am not blind to the potential of other sectors. But for now, I believe the energy sector holds the most promise for Sordland's economic growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Do you ever worry that your focus on profit might come a..."*)
  - -> `[88]` (*Player: ""Your dealings have been under scrutiny before, Alphonso...."*)
  - -> `[89]` (*Player: ""Why should I trust you, Alphonso, when you've been known..."*)

### Węzeł `[82]`
Mówca: **Ewald Alphonso**
> ""Trust is earned, Mr. President. I hope to earn yours by showing you that I'm committed to Sordland's growth. As for my priorities, I believe business can be a force for good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso: ""While we're on the topic of trust, Mr. President, may I ..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My actions are always guided by my commitment to the Sordish people, not personal gain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "The helicopter tilted to the right and re-adjusted its co..."*)

### Węzeł `[84]`
Mówca: **Ewald Alphonso**
> ""I don't think so. Their diversification within the energy sector and strong international trade network will help mitigate that risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Do you ever worry that your focus on profit might come a..."*)
  - -> `[88]` (*Player: ""Your dealings have been under scrutiny before, Alphonso...."*)
  - -> `[89]` (*Player: ""Why should I trust you, Alphonso, when you've been known..."*)

### Węzeł `[85]`
Mówca: **Ewald Alphonso**
> ""I'm only saying that we have much to learn from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Do you ever worry that your focus on profit might come a..."*)
  - -> `[88]` (*Player: ""Your dealings have been under scrutiny before, Alphonso...."*)
  - -> `[89]` (*Player: ""Why should I trust you, Alphonso, when you've been known..."*)

### Węzeł `[86]`
Mówca: **Ewald Alphonso**
> ""Also, their willingness to foster strong international trade relations is something we could definitely emulate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Do you ever worry that your focus on profit might come a..."*)
  - -> `[88]` (*Player: ""Your dealings have been under scrutiny before, Alphonso...."*)
  - -> `[89]` (*Player: ""Why should I trust you, Alphonso, when you've been known..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you ever worry that your focus on profit might come at the expense of the Sordish people?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso), `[84]` (Ewald Alphonso), `[85]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Ewald Alphonso: ""Mr. President, I understand the implications of my decis..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your dealings have been under scrutiny before, Alphonso. Can you assure me that your interest in the energy sector isn't self-serving?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso), `[84]` (Ewald Alphonso), `[85]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Ewald Alphonso: ""Of course it's self-serving, Mr. President. I'm a busine..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why should I trust you, Alphonso, when you've been known to prioritize business over everything else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Ewald Alphonso), `[84]` (Ewald Alphonso), `[85]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Ewald Alphonso: ""Trust is earned, Mr. President. I hope to earn yours by ..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Every decision I've made was in the best interest of Sordland and its citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "The helicopter tilted to the right and re-adjusted its co..."*)

### Węzeł `[91]`
Mówca: **Ewald Alphonso**
> ""Of course it's self-serving, Mr. President. I'm a businessman, not a saint. But I also firmly believe that what's good for Gasom is good for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso: ""While we're on the topic of trust, Mr. President, may I ..."*)

### Węzeł `[92]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I understand the implications of my decisions. I won't pretend I'm not interested in profit, but I firmly believe that a prosperous Gasom means a prosperous Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso: ""While we're on the topic of trust, Mr. President, may I ..."*)

### Węzeł `[93]`
Mówca: **Ewald Alphonso**
> ""While we're on the topic of trust, Mr. President, may I remind you that quite a few of your own decisions have been met with controversy. How do you justify your own actions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""Every decision I've made was in the best interest of Sor..."*)
  - -> `[83]` (*Player: ""My actions are always guided by my commitment to the Sor..."*)
  - -> `[94]` (*Player: ""I don't need to justify my actions to you, Mr. Alphonso...."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't need to justify my actions to you, Mr. Alphonso. You are Sordland's past; I am its future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "The helicopter tilted to the right and re-adjusted its co..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "The helicopter tilted to the right and re-adjusted its course. Serge, sensing the escalating tensions in the cabin, reluctantly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Serge Wolkner: ""Mr. President, Mr. Alphonso, I may only be a driver, but..."*)

### Węzeł `[96]`
Mówca: **Serge Wolkner**
> ""Mr. President, Mr. Alphonso, I may only be a driver, but it seems to me that both of you want to steer Sordland towards a better future. You just disagree on the right road to get there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""Thank you, Serge. It's good to be reminded that we all s..."*)
  - -> `[98]` (*Player: ""Serge, do you believe that our duty to the Sordish peopl..."*)
  - -> `[110]` (*Player: ""Serge, in your view, is it possible to balance business ..."*)
  - -> `[99]` (*Player: ""Serge, your perspective is refreshing, but a bit naive. ..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. It's good to be reminded that we all share a common goal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Serge Wolkner: ""That's very kind of you, Mr. President. I'm here to serve.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, do you believe that our duty to the Sordish people should be our guiding principle?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: ""I believe so, Mr. President. That's what service means t..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, your perspective is refreshing, but a bit naive. The world of politics and business isn't as straightforward as driving a car.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Serge Wolkner: ""You're right, Mr. President. Please excuse my interrupti..."*)

### Węzeł `[100]`
Mówca: **Ewald Alphonso**
> ""You know, Serge, if you ever find yourself weary of the political circus, I could always use a reliable man like you at Gasom. Consider it an open offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Serge Wolkner: ""I appreciate the offer, Mr. Alphonso, but serving Presid..."*)

### Węzeł `[101]`
Mówca: **Serge Wolkner**
> ""I appreciate the offer, Mr. Alphonso, but serving President Rayne and Sordland is my duty and I am proud of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Serge is loyal to his duty and to Sordland, Alphonso. I ..."*)
  - -> `[109]` (*Player: ""I am glad to see you value Serge's skills, Alphonso. But..."*)
  - -> `[103]` (*Player: ""Serge, you don't need to answer that. This is not the ti..."*)
  - -> `[104]` (*Player: ""Alphonso, I hope you're not trying to poach my staff mid..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge is loyal to his duty and to Sordland, Alphonso. I suggest you respect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Ewald Alphonso: ""Of course, Mr. President. I meant no disrespect.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, you don't need to answer that. This is not the time or place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Ewald Alphonso: ""Apologies, Mr. President. I didn't mean to overstep.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alphonso, I hope you're not trying to poach my staff mid-flight!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ewald Alphonso: ""Just a friendly offer, Mr. President, nothing more.""*)

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
> ""Of course, Mr. President. I meant no disrespect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
> ""I understand, Mr. President. It was just an offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
> ""Apologies, Mr. President. I didn't mean to overstep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
> ""Just a friendly offer, Mr. President, nothing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am glad to see you value Serge's skills, Alphonso. But I need him more than you do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Ewald Alphonso: ""I understand, Mr. President. It was just an offer.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, in your view, is it possible to balance business interests with a commitment to public service?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Serge Wolkner: ""Mr. President, I don't know much about business, but I t..."*)

### Węzeł `[111]`
Mówca: **Serge Wolkner**
> ""That's very kind of you, Mr. President. I'm here to serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Ewald Alphonso: ""And serve you do, Mr. Wolkner. You're as astute as you a..."*)

### Węzeł `[112]`
Mówca: **Serge Wolkner**
> ""I believe so, Mr. President. That's what service means to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Ewald Alphonso: ""A fine sentiment, Serge. I agree that the Sordish people..."*)

### Węzeł `[113]`
Mówca: **Serge Wolkner**
> ""Mr. President, I don't know much about business, but I think it's possible if one's heart is in the right place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Ewald Alphonso: ""Well said, Serge. I strive to balance my business intere..."*)

### Węzeł `[114]`
Mówca: **Ewald Alphonso**
> ""Well said, Serge. I strive to balance my business interests with my commitment to Sordland every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ewald Alphonso: ""You know, Serge, if you ever find yourself weary of the ..."*)

### Węzeł `[115]`
Mówca: **Ewald Alphonso**
> ""And serve you do, Mr. Wolkner. You're as astute as you are competent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ewald Alphonso: ""You know, Serge, if you ever find yourself weary of the ..."*)

### Węzeł `[116]`
Mówca: **Ewald Alphonso**
> ""A fine sentiment, Serge. I agree that the Sordish people should always come first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ewald Alphonso: ""You know, Serge, if you ever find yourself weary of the ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gasom Invest Choice Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[118]`
Mówca: **Ewald Alphonso**
> ""I appreciate your support, Mr. President. It's reassuring to know that there are others who share my dream of a prosperous Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your reforms had quite a few critics, actually. Some said they directly caused the 1951 recession.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Ewald Alphonso), `[134]` (Ewald Alphonso), `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Ewald Alphonso: ""It's easy to pass judgement in retrospect, Mr. President..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not sure any amount of reform could have prevented the recession of '51. Do you think there's a surefire way to stop these crises?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Ewald Alphonso), `[134]` (Ewald Alphonso), `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Ewald Alphonso: ""You're correct, Mr. President. The recession was a compl..."*)

### Węzeł `[121]`
Mówca: **Ewald Alphonso**
> ""It's easy to pass judgement in retrospect, Mr. President. At the time, I believed those reforms were necessary for Sordland's economic progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Ewald Alphonso: ""But I do admit they could have been implemented at a mor..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your rapid privatization plan destabilized key sectors of our economy, leading to the worst recession in our modern history.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Ewald Alphonso), `[134]` (Ewald Alphonso), `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Ewald Alphonso: ""Destabilization wasn't my goal. I was trying to attract ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think the economic downturn could have been avoided if the Old Guard hadn't obstructed your reforms?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Ewald Alphonso), `[134]` (Ewald Alphonso), `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Ewald Alphonso: ""The resistance from the Old Guard certainly worsened the..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_CampaignedForAlphonso == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true && Ba..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_CampaignedForAlphonso == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Ewald Alphonso: ""You made your dislike of my policies loud and clear when..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_CampaignedForAlphonso == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Your reforms had quite a few critics, actually. Some sai..."*)
  - -> `[122]` (*Player: ""Your rapid privatization plan destabilized key sectors o..."*)
  - -> `[123]` (*Player: ""Do you think the economic downturn could have been avoid..."*)
  - -> `[120]` (*Player: ""I'm not sure any amount of reform could have prevented t..."*)

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> ""You made your dislike of my policies loud and clear when you stole the party leadership out from under me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso: ""Flipping my supporters, snaking your way into my inner c..."*)

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""Flipping my supporters, snaking your way into my inner circle... I won't lie, it was a hard blow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""You were losing control, Alphonso. My intervention was n..."*)
  - -> `[129]` (*Player: ""We did what we had to do to save the party and the count..."*)
  - -> `[143]` (*Player: ""Do you still resent me for the way things turned out?""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We did what we had to do to save the party and the country. I hope you can understand that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ewald Alphonso: ""In the world of politics, we often find ourselves making..."*)

### Węzeł `[130]`
Mówca: **Ewald Alphonso**
> ""I understand why you intervened. I was struggling to maintain control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Ewald Alphonso: ""But I can't help but wonder if you could have achieved y..."*)

### Węzeł `[131]`
Mówca: **Ewald Alphonso**
> ""Resentment doesn't do anyone any good, Mr. President. What happened, happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ewald Alphonso: ""It's the future of the country that we need to focus on ..."*)

### Węzeł `[132]`
Mówca: **Ewald Alphonso**
> ""In the world of politics, we often find ourselves making tough choices for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Ewald Alphonso: ""Was that your motivation? I'm not sure.""*)

### Węzeł `[133]`
Mówca: **Ewald Alphonso**
> ""But I do admit they could have been implemented at a more moderate pace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> ""I appreciate your candid feedback.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[135]`
Mówca: **Ewald Alphonso**
> ""Your honesty is appreciated, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""I still believe I brought Sordland the change it needed...."*)

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> ""That's a fair critique, Mr. President. Change can be unsettling, especially when it challenges long-held beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""I still believe I brought Sordland the change it needed...."*)

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""A valid perspective. Balancing economic growth with social safety is indeed a complex challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Ewald Alphonso: ""I appreciate your candid feedback.""*)

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""Regardless of your motivations, your support during those times was crucial, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ewald Alphonso: ""I still see myself as a facilitator for change. Someone ..."*)

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""I understand your viewpoint, Mr. President. I still believe my reforms were necessary, but I'll be the first to admit they weren't perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""I still see myself as a facilitator for change. Someone who can help Sordland navigate the complexities of the global economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[141]`
Mówca: **Ewald Alphonso**
> ""The resistance from the Old Guard certainly worsened the situation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Ewald Alphonso: ""If the necessary reforms had been implemented in a timel..."*)

### Węzeł `[142]`
Mówca: **Ewald Alphonso**
> ""Destabilization wasn't my goal. I was trying to attract foreign investment and stimulate competition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Ewald Alphonso: ""However, I admit that the transition could have been bet..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you still resent me for the way things turned out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Ewald Alphonso: ""Resentment doesn't do anyone any good, Mr. President. Wh..."*)

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""I still believe I brought Sordland the change it needed. But I acknowledge that not everyone may share this view.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[145]`
Mówca: **Ewald Alphonso**
> ""You're correct, Mr. President. The recession was a complex event.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Ewald Alphonso: ""But addressing systemic corruption, improving bureaucrat..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You were losing control, Alphonso. My intervention was necessary to steer the party in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ewald Alphonso: ""I understand why you intervened. I was struggling to mai..."*)

### Węzeł `[147]`
Mówca: **Ewald Alphonso**
> ""But addressing systemic corruption, improving bureaucratic efficiency and ensuring transparent governance could be key to preventing further downturns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[148]`
Mówca: **Ewald Alphonso**
> ""If the necessary reforms had been implemented in a timely manner, we might have been able to avert the severity of the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[149]`
Mówca: **Ewald Alphonso**
> ""However, I admit that the transition could have been better managed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[150]`
Mówca: **Ewald Alphonso**
> ""But I can't help but wonder if you could have achieved your goals in a less aggressive manner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[151]`
Mówca: **Ewald Alphonso**
> ""It's the future of the country that we need to focus on now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[152]`
Mówca: **Ewald Alphonso**
> ""Was that your motivation? I'm not sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[153]`
Mówca: **Ewald Alphonso**
> ""Their commitment to natural resource extraction and emphasis on naval engineering are commendable. And as a neutral power, the country offers a counterweight to the battle between United Contana and Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Ewald Alphonso: ""Gasom has multiple engineers hired from Anraka too. I be..."*)

### Węzeł `[154]`
Mówca: **Ewald Alphonso**
> ""Gasom has multiple engineers hired from Anraka too. I believe Sordland could find a valuable partner in Anraka in the coming decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""I see potential for collaboration, particularly in offsh..."*)
  - -> `[156]` (*Player: ""I'm impressed as well, but it's crucial we remain cautio..."*)
  - -> `[157]` (*Player: ""We should rather focus on Sordland's own strengths. Our ..."*)
  - -> `[158]` (*Player: ""Anraka has potential. But isn't Rumburg already a counte..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see potential for collaboration, particularly in offshore resource extraction and marine conservation. We've got much to learn from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Ewald Alphonso: ""Precisely, Mr. President. It's not just about the econom..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm impressed as well, but it's crucial we remain cautious. Anraka's history of piracy and stringent laws could pose challenges in a potential partnership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ewald Alphonso: ""Your concern is valid, Mr. President.""*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We should rather focus on Sordland's own strengths. Our future lies in building a self-reliant economy and bolstering our own industries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Ewald Alphonso: ""Absolutely, Mr. President. Strengthening our domestic ec..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Anraka has potential. But isn't Rumburg already a counterbalance to the United Contana-Arcasia power struggle?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Ewald Alphonso: ""Rumburg does indeed possess significant power, Mr. Presi..."*)

### Węzeł `[159]`
Mówca: **Ewald Alphonso**
> ""Precisely, Mr. President. It's not just about the economic benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ewald Alphonso: ""Working together can drive innovation and sustainability..."*)

### Węzeł `[160]`
Mówca: **Ewald Alphonso**
> ""Your concern is valid, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso: ""While Anraka has its unique complexities, I believe thes..."*)

### Węzeł `[161]`
Mówca: **Ewald Alphonso**
> ""Absolutely, Mr. President. Strengthening our domestic economy is paramount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Ewald Alphonso: ""But partnerships with countries like Anraka -- or Rizia,..."*)

### Węzeł `[162]`
Mówca: **Ewald Alphonso**
> ""Rumburg does indeed possess significant power, Mr. President. But the Queen is far more opposed to United Contana and the CSP than Arcasia and the ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Ewald Alphonso: ""The dynamics would need to shift significantly before th..."*)

### Węzeł `[163]`
Mówca: **Ewald Alphonso**
> ""Working together can drive innovation and sustainability for both nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""These are the kind of factors you need to take into acco..."*)

### Węzeł `[164]`
Mówca: **Ewald Alphonso**
> ""While Anraka has its unique complexities, I believe these challenges can be managed with careful diplomacy and mutual respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""These are the kind of factors you need to take into acco..."*)

### Węzeł `[165]`
Mówca: **Ewald Alphonso**
> ""But partnerships with countries like Anraka -- or Rizia, for that matter -- could also serve to enhance our own capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""These are the kind of factors you need to take into acco..."*)

### Węzeł `[166]`
Mówca: **Ewald Alphonso**
> ""The dynamics would need to shift significantly before they could serve the same function as Anraka.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Ewald Alphonso: ""These are the kind of factors you need to take into acco..."*)

### Węzeł `[167]`
Mówca: **Ewald Alphonso**
> ""These are the kind of factors you need to take into account if you're going to reform the Energy Protection Act, by the way. It might seem minor, but any alteration could shape Sordland's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gasom Invest Choice Talk]"*)

### Węzeł `[168]`
Mówca: **Ewald Alphonso**
> ""But over time, I realized that his approach wasn't working, and that a new direction was needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You were part of the USP during Soll's rule. You supported his policies then. What changed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Ewald Alphonso: ""You're correct, Mr. President. Yes, I supported Soll's p..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think the growth and prosperity of Lachaven can be replicated in other parts of Sordland?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ewald Alphonso: ""Honestly, the key lies in strategic planning and targete..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It took time for their vision to be realized. They didn't even see it come to full fruition during their lifetimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ewald Alphonso: ""That's a great point, Mr. President. The key lies in per..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Kingdom was a different era. Do you think its strategies can be applied in our modern-day context?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ewald Alphonso: ""Indeed, Mr. President. While the context has changed, th..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You may be right. But not all cities have Lachaven's potential or resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: ""You're absolutely right, Mr. President. Each city in Sor..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It must have been interesting, navigating all the changing political dynamics as an outsider.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Ewald Alphonso: ""The dynamics in Holsord were... complicated, to say the ..."*)

### Węzeł `[175]`
Mówca: **Ewald Alphonso**
> ""You're correct, Mr. President. Yes, I supported Soll's policies early on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ewald Alphonso: ""But over time, I realized that his approach wasn't worki..."*)

### Węzeł `[176]`
Mówca: **Ewald Alphonso**
> ""Honestly, the key lies in strategic planning and targeted investments. We need to identify sectors with high growth potential and channel our resources there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Ewald Alphonso: ""And of course, we need to create a business environment ..."*)

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. While the context has changed, the principles of visionary leadership remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ewald Alphonso: ""We need to identify our strengths, understand our challe..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I believe that Lachaven's success today is due to the collective effort of its people, not a deceased monarch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ewald Alphonso: ""But would their efforts have been as strong without thos..."*)

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> ""You're absolutely right, Mr. President. Each city in Sordland has its own unique strengths and challenges. Our strategies must be tailored to leverage these unique attributes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Ewald Alphonso: ""It's not about a one-size-fits-all approach, but a nuanc..."*)

### Węzeł `[180]`
Mówca: **Ewald Alphonso**
> ""That's a great point, Mr. President. The key lies in persistence and long-term planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""It's akin to what we're trying to achieve with Gasom. Su..."*)

### Węzeł `[181]`
Mówca: **Ewald Alphonso**
> ""But would their efforts have been as strong without those leaders setting the direction?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""The past may have laid the foundation, but it's the pres..."*)

### Węzeł `[182]`
Mówca: **Ewald Alphonso**
> ""It was a truly incredible experience, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""Despite the challenges and hardships, there was a sense ..."*)

### Węzeł `[183]`
Mówca: **Ewald Alphonso**
> ""Despite the challenges and hardships, there was a sense of purpose, a collective will to rebuild and forge ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Ewald Alphonso: ""Back in those days, there was the sense that truly anyth..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sounds like a momentous time to be in Holsord. How did it feel to be part of the transformation of the city?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ewald Alphonso: ""It was a truly incredible experience, Mr. President.""*)

### Węzeł `[185]`
Mówca: **Ewald Alphonso**
> ""The dynamics in Holsord were... complicated, to say the least. It was hard not to get caught in the intricate web of political alliances and business rivalries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Ewald Alphonso: ""It was a steep learning curve, but it was also an invalu..."*)

### Węzeł `[186]`
Mówca: **Ewald Alphonso**
> ""It was a steep learning curve, but it was also an invaluable lesson in understanding the complexities of Sordish politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Ewald Alphonso: ""Back in those days, there was the sense that truly anyth..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Alphonso seemed to retreat into his memories for a moment. A gust of wind rattled the helicopter as he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Ewald Alphonso: ""Getting back to Lachaven... I was thinking about how the..."*)

### Węzeł `[188]`
Mówca: **Ewald Alphonso**
> ""Getting back to Lachaven... I was thinking about how the whole city displays the vision of King Egmund.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Ewald Alphonso: ""Without the investments that he and his chief architect ..."*)

### Węzeł `[189]`
Mówca: **Ewald Alphonso**
> ""Without the investments that he and his chief architect made, Lachaven wouldn't stand shoulder-to-shoulder with Haelm, Porte Drazon, Konstantium and Falenco today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player: ""I believe that Lachaven's success today is due to the co..."*)
  - -> `[170]` (*Player: ""Do you think the growth and prosperity of Lachaven can b..."*)
  - -> `[171]` (*Player: ""It took time for their vision to be realized. They didn'..."*)
  - -> `[172]` (*Player: ""The Kingdom was a different era. Do you think its strate..."*)
  - -> `[173]` (*Player: ""You may be right. But not all cities have Lachaven's pot..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You speak of escaping from old bureaucrats. But isn't the capitalist system you promoted just another form of bureaucracy? Possibly even the worst form of all, for those less fortunate.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Kontekst wejściowy (poprzednik):** `[18]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Ewald Alphonso: ""An interesting perspective, {BaseGameText.AlphonsoToPlay..."*)

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""An interesting perspective, {BaseGameText.AlphonsoToPlayer}. Of course capitalism creates disparities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ewald Alphonso: ""But it's also an engine for growth and innovation. The c..."*)

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""But it's also an engine for growth and innovation. The challenge, as I see it, is to create a more inclusive capitalism that serves the needs of all Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso: ""You know, looking at the sea reminds me of an incident f..."*)

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""We need to carve out a path that allows Sordland to benefit from our foreign relations while also maintaining our sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso: ""You know, looking at the sea reminds me of an incident f..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromotePlanned == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""You speak of escaping from old bureaucrats. But isn't th..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromotePlanned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_None == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""A little ironic, isn't it? You escaped the bureaucrats, ..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_None == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't campaign for you because of your economic reforms, but because I wanted change by any means necessary.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ewald Alphonso: ""Regardless of your motivations, your support during thos..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be honest, I never agreed with your economic reforms. I felt they disproportionately favored the wealthy and neglected the needs of the common people.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""I understand your viewpoint, Mr. President. I still beli..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be frank, Mr. Alphonso, I didn't campaign for you because I didn't like the direction you were taking the party in. I too wanted change, but not your way.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Ewald Alphonso: ""Your honesty is appreciated, Mr. President.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can tell you now that I didn't support your campaign. I felt that the USP was moving away from its roots and that your free-market reforms were a departure from our values.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso: ""That's a fair critique, Mr. President. Change can be uns..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure you remember that I campaigned for you. I believed in your economic vision then, just as I do now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Ewald Alphonso: ""I appreciate your support, Mr. President. It's reassurin..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even when I was campaigning for you, I had reservations about your economic platform. I thought there could have been a better balance between free-market principles and social safety nets.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Kontekst wejściowy (poprzednik):** `[12]` (Ewald Alphonso), `[13]` (Ewald Alphonso), `[15]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Ewald Alphonso: ""A valid perspective. Balancing economic growth with soci..."*)

### Węzeł `[206]`
Mówca: **Ewald Alphonso**
> ""Just as Lachaven's success is tied to its global connectivity, Sordland's wealth is tied to its connection to the world and its skilled, educated workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Ewald Alphonso: ""Looking at the global landscape, I see great potential i..."*)

### Węzeł `[207]`
Mówca: **Ewald Alphonso**
> ""It's akin to what we're trying to achieve with Gasom. Success isn't built overnight. It's the cumulative result of years of planning, investments, and execution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Ewald Alphonso: ""Just as Lachaven's success is tied to its global connect..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""I'm sure you remember that I campaigned for you. I belie..."*)
  - -> `[205]` (*Player: ""Even when I was campaigning for you, I had reservations ..."*)
  - -> `[200]` (*Player: ""I didn't campaign for you because of your economic refor..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: ""To be honest, I never agreed with your economic reforms...."*)
  - -> `[202]` (*Player: ""To be frank, Mr. Alphonso, I didn't campaign for you bec..."*)
  - -> `[203]` (*Player: ""I can tell you now that I didn't support your campaign. ..."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "From here, it was even more evident what a pivotal role the city of Lachaven played in our international trade. Here, at the so-called "Gateway", was where Sordland opened itself to the global market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""We need to identify our strengths, understand our challenges, and formulate a strategy that leverages our unique advantages. It's about adapting and innovating, not merely replicating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""It's akin to what we're trying to achieve with Gasom. Su..."*)

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""It's not about a one-size-fits-all approach, but a nuanced strategy that considers the local context.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""It's akin to what we're trying to achieve with Gasom. Su..."*)

### Węzeł `[214]`
Mówca: **Ewald Alphonso**
> ""And of course, we need to create a business environment that encourages innovation and entrepreneurship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""It's akin to what we're trying to achieve with Gasom. Su..."*)

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""The past may have laid the foundation, but it's the present that builds upon it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""It's akin to what we're trying to achieve with Gasom. Su..."*)

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""Looking at the global landscape, I see great potential in Anraka. Despite their turbulent history, they've emerged as a beacon of resilience and innovation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Ewald Alphonso: ""Their commitment to natural resource extraction and emph..."*)

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""It was disheartening, but there was still a sense in those times that anything was possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""Still, what I remember most about those times was the sense that truly anything was possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
> ""Back in those days, there was the sense that truly anything was possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Before that, I had the sense that truly anything was possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Alphonso seemed to retreat into his memories for a moment..."*)

### Węzeł `[221]`
Mówca: **Serge Wolkner**
> ""You're right, Mr. President. Please excuse my interruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Ewald Alphonso: ""You know, Serge, if you ever find yourself weary of the ..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ewald Alphonso: ""You didn't just reject a business deal back at Gasom. Yo..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Ewald Alphonso: ""I remember when we were negotiating our first internatio..."*)
