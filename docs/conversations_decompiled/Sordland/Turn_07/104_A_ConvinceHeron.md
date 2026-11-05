# Sordland/Turn07/A_ConvinceHeron

- **ID konwersacji:** `104`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/104_A_ConvinceHeron.md`
- **Liczba węzłów dialogowych:** 235
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn07_HeronMeeting_OfferBribe`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Heron_BribedToMeet`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Reform_Reform_Heron_SentLucian`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Reform_Heron_BribedToVote`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGame.Reform_Reform_Heron_PromisedChiefJustice`
- `BaseGameSupport.Journal_Turn07_Heron_Convinced`
- `BaseGameSupport.Journal_Turn07_Heron_Failed`
- `GameCondition.Turn07_A_ConvinceHeron`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Oh this place is not mine. It's Petr's.""** | `[31]` **Heron Garaci**: ""A Gentlemen's Club, huh?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Heron Garaci**: ""Didn't know the Vice President ..." |
| `[32]` | **""We thought this place would be fitting.""** | `[31]` **Heron Garaci**: ""A Gentlemen's Club, huh?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Heron Garaci**: ""Yes. Fitting."" |
| `[33]` | **""I don't set up meetings. My team chose this place.""** | `[31]` **Heron Garaci**: ""A Gentlemen's Club, huh?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Heron Garaci**: ""Please send my regards to your ..." |
| `[37]` | **""Oh I'm not. I just recently bought this place.""** | `[30]` **Heron Garaci**: ""Didn't know you were a winegrow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Heron Garaci**: ""Well, I'll be looking forward t..." |
| `[38]` | **""Me neither. It just happened.""** | `[30]` **Heron Garaci**: ""Didn't know you were a winegrow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Heron Garaci**: ""Well, I'll be looking forward t..." |
| `[39]` | **""I like the calmness here. And the sight of the grapevines.""** | `[30]` **Heron Garaci**: ""Didn't know you were a winegrow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Heron Garaci**: ""You're lucky to have such a pla..." |
| `[54]` | **""I want you and your buddies in the Court to pass the changes.""** | `[51]` **Heron Garaci**: ""Your gesture of goodwill went a..."<br>`[53]` **Heron Garaci**: ""Please do speak of your intenti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Heron Garaci**: ""Yes. Not an easy thing to make ..." |
| `[55]` | **""You know what I want.""** | `[51]` **Heron Garaci**: ""Your gesture of goodwill went a..."<br>`[53]` **Heron Garaci**: ""Please do speak of your intenti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Heron Garaci**: ""I don't like to speculate. I wa..." |
| `[56]` | **""I'm waiting for your gesture of goodwill now.""** | `[51]` **Heron Garaci**: ""Your gesture of goodwill went a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Heron Garaci**: ""I believe I have already showed..." |
| `[57]` | **""We need your help with the upcoming vote.""** | `[51]` **Heron Garaci**: ""Your gesture of goodwill went a..."<br>`[53]` **Heron Garaci**: ""Please do speak of your intenti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Heron Garaci**: ""I'm prepared to do that."" |
| `[65]` | **""Don't you dare opposing me after you accepted my money.""** | `[59]` **Heron Garaci**: ""You know I'm taking a risk here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Heron Garaci**: ""I have not yet decided what to ..." |
| `[66]` | **""You know I'm taking a much higher risk here, Mr. Garaci.""** | `[59]` **Heron Garaci**: ""You know I'm taking a risk here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Heron Garaci**: ""Perhaps you are right. You have..." |
| `[67]` | **""Look. I need your help with the upcoming vote.""** | `[59]` **Heron Garaci**: ""You know I'm taking a risk here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Heron Garaci**: ""I'm prepared to do that."" |
| `[68]` | **""I'm not here to play your games.""** | `[60]` **Heron Garaci**: ""I don't like to speculate. I wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Heron Garaci**: ""Fine."" |
| `[69]` | **""Drop the act, Mr. Garaci. Let's not waste each other's time.""** | `[59]` **Heron Garaci**: ""You know I'm taking a risk here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Heron Garaci**: ""Fine."" |
| `[77]` | **""I'm listening.""** | `[76]` **Heron Garaci**: ""Wouldn't you want to have a Chi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Heron Garaci**: ""I already have a reasonable sup..."<br>`[101]` **Heron Garaci**: ""I already have a reasonable sup..." |
| `[78]` | **""I don't think you would be that person.""** | `[76]` **Heron Garaci**: ""Wouldn't you want to have a Chi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Heron Garaci**: ""I would be. If you allow me."" |
| `[79]` | **""So you want to take Orso's place huh?""** | `[76]` **Heron Garaci**: ""Wouldn't you want to have a Chi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Heron Garaci**: ""Is it really that unexpected?"" |
| `[84]` | **""I really did not expect this.""** | `[83]` **Heron Garaci**: ""We didn't want to create unnece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Heron Garaci**: ""The problem is the Chief Justice."" |
| `[85]` | **""So the Old Guard has actually decided to support me?""** | `[83]` **Heron Garaci**: ""We didn't want to create unnece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Heron Garaci**: ""Some of us see no problem with ..." |
| `[86]` | **""I'll admit, it's a nice surprise to hear this from you.""** | `[83]` **Heron Garaci**: ""We didn't want to create unnece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Heron Garaci**: ""The problem is the Chief Justice."" |
| `[87]` | **""Sounds too good to be true. I was told otherwise about your stance.""** | `[83]` **Heron Garaci**: ""We didn't want to create unnece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Heron Garaci**: ""We can't be open about this now..." |
| `[94]` | **""You're right. It does sound rather nice.""** | `[76]` **Heron Garaci**: ""Wouldn't you want to have a Chi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Heron Garaci**: ""Well, I agree."" |
| `[108]` | **""I already wanted to do that.""** | `[111]` **Heron Garaci**: ""And I will support you not only..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Heron Garaci**: ""So, it's a deal?"" |
| `[109]` | **""I like the offer. It's a deal.""** | `[105]` **Heron Garaci**: ""And I will support you not only..."<br>`[111]` **Heron Garaci**: ""And I will support you not only..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Heron Garaci**: ""Great to have come to an unders..." |
| `[110]` | **""Are you positive the evidence can lead to his impeachment?""** | `[105]` **Heron Garaci**: ""And I will support you not only..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Heron Garaci**: ""Well, yes. The new changes will..." |
| `[112]` | **""I believe there are more people who needs to go.""** | `[111]` **Heron Garaci**: ""And I will support you not only..."<br>`[228]` **Heron Garaci**: ""In such a circumstance, I'm pre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Heron Garaci**: ""That's not in the terms."" |
| `[113]` | **""I can't promise that.""** | `[105]` **Heron Garaci**: ""And I will support you not only..."<br>`[111]` **Heron Garaci**: ""And I will support you not only..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Heron Garaci**: ""I thought you were the one who ..." |
| `[114]` | **""Fine. It's a deal.""** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Heron Garaci**: ""Great to have come to an unders..." |
| `[115]` | **""Looks like our meeting is over.""** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>`[220]` **Heron Garaci**: ""No."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Heron Garaci**: ""Looks like it. Shame."" |
| `[116]` | **""How about another investment, Mr. Garaci? I'm sure we can find an amount you'd li..."** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..." | `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true`<br>`Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[138]` **Heron Garaci**: ""I'm listening."" |
| `[121]` | **""I make the terms here.""** | `[120]` **Heron Garaci**: ""That's not in the terms."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Heron Garaci**: ""I thought you were the one who ..." |
| `[122]` | **""I don't like your offer.""** | `[120]` **Heron Garaci**: ""That's not in the terms."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Heron Garaci**: ""I thought you were the one who ..." |
| `[123]` | **""Fine. I like your offer. It's a deal.""** | `[120]` **Heron Garaci**: ""That's not in the terms."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Heron Garaci**: ""Great to have come to an unders..." |
| `[126]` | **""No. I can't promise you such a thing.""** | `[125]` **Heron Garaci**: ""So, it's a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Heron Garaci**: ""I thought you were the one who ..." |
| `[127]` | **""Yes. It's a deal.""** | `[125]` **Heron Garaci**: ""So, it's a deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Heron Garaci**: ""Great to have come to an unders..." |
| `[137]` | **""How about a financial investment instead?""** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..." | `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false`<br>`Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[138]` **Heron Garaci**: ""I'm listening."" |
| `[142]` | **""Here. I'll be generous. [-2 Personal Wealth]""** | `[138]` **Heron Garaci**: ""I'm listening."" | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[163]` **Narrator**: "He smiled." |
| `[143]` | **""I'm sure this would convince you. [-1 Personal Wealth]""** | `[138]` **Heron Garaci**: ""I'm listening."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[163]` **Narrator**: "He smiled." |
| `[144]` | **""You'd better rethink your position, Mr. Garaci. I could have you dusted off.""** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>`[218]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[145]` **Heron Garaci**: ""You're threatening me?"" |
| `[149]` | **""You'd better rethink your position, Mr. Garaci. I could have you thrown in the can.""** | `[107]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>`[218]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`<br>`(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false` | *Brak zmian stanu* | `[150]` **Heron Garaci**: ""You're threatening me with that?"" |
| `[169]` | **""SIT DOWN.""** | `[154]` **Heron Garaci**: ""It's time I get going."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Heron Garaci**: ""I am not your dog, Mr. Rayne."" |
| `[170]` | **""You'll regret not supporting me.""** | `[154]` **Heron Garaci**: ""It's time I get going.""<br>`[159]` **Narrator**: "He put his hat back on and stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Heron Garaci**: ""Goodbye, Mr. President."" |
| `[171]` | **""Farewell, Mr. Garaci.""** | `[154]` **Heron Garaci**: ""It's time I get going.""<br>`[159]` **Narrator**: "He put his hat back on and stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Heron Garaci**: ""Goodbye, Mr. President. It was ..." |
| `[172]` | **""It was nice to have you here, Mr. Garaci. I hope you'll reconsider your support.""** | `[159]` **Narrator**: "He put his hat back on and stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Heron Garaci**: ""Thank you for inviting me here...." |
| `[180]` | **""Thank you for coming, Mr. Garaci. It was a fruitful meeting.""** | `[167]` **Narrator**: "He put his hat back on." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "We shook hands and he left me al..." |
| `[181]` | **""Looking forward to our cooperation.""** | `[167]` **Narrator**: "He put his hat back on." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "We shook hands and he left me al..." |
| `[182]` | **""I hope I can rely on you.""** | `[167]` **Narrator**: "He put his hat back on." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "We shook hands and he left me al..." |
| `[208]` | **""Here. I'll be generous. [-2 Personal Wealth]""** | `[211]` **Heron Garaci**: ""And I will support you not only..."<br>`[218]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[163]` **Narrator**: "He smiled." |
| `[209]` | **""Fine. I'm sure this would convince you. [-1 Personal Wealth]""** | `[211]` **Heron Garaci**: ""And I will support you not only..."<br>`[218]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.PersonalWealth"] > 0` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....` | `[163]` **Narrator**: "He smiled." |
| `[215]` | **""I'm sorry, Mr. Garaci. I don't have anything to spare.""** | `[211]` **Heron Garaci**: ""And I will support you not only..."<br>`[218]` **Heron Garaci**: ""I gave you my offer. If you don..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.PersonalWealth"] > 0) == false` | *Brak zmian stanu* | `[158]` **Heron Garaci**: ""It's time I get going then."" |
| `[216]` | **""I can't promise that.""** | `[211]` **Heron Garaci**: ""And I will support you not only..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Heron Garaci**: ""I thought you were the one who ..." |
| `[219]` | **""Can we figure something else out?""** | `[218]` **Heron Garaci**: ""I gave you my offer. If you don..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Heron Garaci**: ""No."" |
| `[230]` | **""I see. That makes sense.""** | `[228]` **Heron Garaci**: ""In such a circumstance, I'm pre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Heron Garaci**: ""So, it's a deal?"" |

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
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Kesaro Kibener had convinced him to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[4]`
Mówca: **Heron Garaci**
> ""Very nice location you've set up here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Heron Garaci: ""A Gentlemen's Club, huh?""*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Oh this place is not mine. It's Petr's.""]** — Mówca: **Player**
> ""Oh this place is not mine. It's Petr's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Heron Garaci: ""Didn't know the Vice President had such good taste.""*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Vineyard == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "We scheduled to meet outside of Holsord, in my new vineya..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "We scheduled to meet outside of Holsord, in the Gentlemen..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "It was yet another sunny day, and I was facing another important political figure: Heron Garaci."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_SentKesaro == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Kesaro Kibener had convinced him to have a meeting with m..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_SentKesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentLucian == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentLucian == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentLucian == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_SentLucian == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentLucian == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentLucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Lucian had managed to convince him to have a meeting with..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_SentLucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentLucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucian had managed to convince him to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The bribe had worked and he agreed to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "We scheduled to meet outside of Holsord, in my new vineyard in Erlory, where we could have some privacy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "I grabbed a drink and sat down under the shadow of a red ..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "We scheduled to meet outside of Holsord, in the Gentlemen's Club of Petr in Erlory, where we could have some privacy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "I grabbed a drink and sat down on the balcony of the vill..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "I grabbed a drink and sat down under the shadow of a red oak at the villa's garden overlooking the red grapevines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Heron sat next to me in his beige checked suit and took o..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "I grabbed a drink and sat down on the balcony of the villa overlooking its vast garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Heron sat next to me in his beige checked suit and took o..."*)

### Węzeł `[23]`
Mówca: **Heron Garaci**
> ""Very nice place you've got here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Heron Garaci: ""Didn't know you were a winegrower.""*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_HeronMeeting_OfferBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The bribe had worked and he agreed to have a meeting with..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_HeronMeeting_OfferBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He had reached out to us and wished for a meeting just ah..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He had reached out to us and wished for a meeting just ahead of the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Heron sat next to me in his beige checked suit and took off his white trilby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Heron Garaci: ""Very nice place you've got here, Mr. President.""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Heron sat next to me in his beige checked suit and took off his white trilby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Heron Garaci: ""Very nice location you've set up here, Mr. President.""*)

### Węzeł `[30]`
Mówca: **Heron Garaci**
> ""Didn't know you were a winegrower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Oh I'm not. I just recently bought this place.""*)
  - -> `[38]` (*Player: ""Me neither. It just happened.""*)
  - -> `[39]` (*Player: ""I like the calmness here. And the sight of the grapevines.""*)

### Węzeł `[31]`
Mówca: **Heron Garaci**
> ""A Gentlemen's Club, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""Oh this place is not mine. It's Petr's.""*)
  - -> `[32]` (*Player: ""We thought this place would be fitting.""*)
  - -> `[33]` (*Player: ""I don't set up meetings. My team chose this place.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""We thought this place would be fitting.""]** — Mówca: **Player**
> ""We thought this place would be fitting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""Yes. Fitting.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't set up meetings. My team chose this place.""]** — Mówca: **Player**
> ""I don't set up meetings. My team chose this place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Heron Garaci: ""Please send my regards to your team then.""*)

### Węzeł `[34]`
Mówca: **Heron Garaci**
> ""Didn't know the Vice President had such good taste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He straightened himself."*)

### Węzeł `[35]`
Mówca: **Heron Garaci**
> ""Yes. Fitting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He straightened himself."*)

### Węzeł `[36]`
Mówca: **Heron Garaci**
> ""Please send my regards to your team then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He straightened himself."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Oh I'm not. I just recently bought this place.""]** — Mówca: **Player**
> ""Oh I'm not. I just recently bought this place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Heron Garaci: ""Well, I'll be looking forward to have a taste of your wi..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Me neither. It just happened.""]** — Mówca: **Player**
> ""Me neither. It just happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Heron Garaci: ""Well, I'll be looking forward to have a taste of your wi..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I like the calmness here. And the sight of the grapevines.""]** — Mówca: **Player**
> ""I like the calmness here. And the sight of the grapevines.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Heron Garaci: ""You're lucky to have such a place to come and relax.""*)

### Węzeł `[40]`
Mówca: **Heron Garaci**
> ""Well, I'll be looking forward to have a taste of your wines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He straightened himself."*)

### Węzeł `[41]`
Mówca: **Heron Garaci**
> ""You're lucky to have such a place to come and relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He straightened himself."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Heron Garaci: ""So, Mr. President... I wanted to talk to you for a coupl..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Heron Garaci: ""So, Mr. President...""*)

### Węzeł `[46]`
Mówca: **Heron Garaci**
> ""So, Mr. President... I wanted to talk to you for a couple of reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Heron Garaci: ""First of all, I have to say that I'm behind your proposa..."*)

### Węzeł `[47]`
Mówca: **Heron Garaci**
> ""So, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_BribedToMeet == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_BribedToMeet == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_BribedToMeet == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_BribedToMeet == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_BribedToMeet == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Heron Garaci: ""Your gesture of goodwill went a long way. Please do spea..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_BribedToMeet == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Heron Garaci: ""You went a long way to make this meeting possible. I had..."*)

### Węzeł `[51]`
Mówca: **Heron Garaci**
> ""Your gesture of goodwill went a long way. Please do speak of your intentions and how I could I be of assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""I'm waiting for your gesture of goodwill now.""*)
  - -> `[55]` (*Player: ""You know what I want.""*)
  - -> `[54]` (*Player: ""I want you and your buddies in the Court to pass the cha..."*)
  - -> `[57]` (*Player: ""We need your help with the upcoming vote.""*)

### Węzeł `[52]`
Mówca: **Heron Garaci**
> ""You went a long way to make this meeting possible. I had to pay you the respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Heron Garaci: ""Please do speak of your intentions and how I could I be ..."*)

### Węzeł `[53]`
Mówca: **Heron Garaci**
> ""Please do speak of your intentions and how I could I be of assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""You know what I want.""*)
  - -> `[54]` (*Player: ""I want you and your buddies in the Court to pass the cha..."*)
  - -> `[57]` (*Player: ""We need your help with the upcoming vote.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I want you and your buddies in the Court to pass the changes.""]** — Mówca: **Player**
> ""I want you and your buddies in the Court to pass the changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci), `[53]` (Heron Garaci), `[60]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Heron Garaci: ""Yes. Not an easy thing to make it happen.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""You know what I want.""]** — Mówca: **Player**
> ""You know what I want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci), `[53]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Heron Garaci: ""I don't like to speculate. I want you to ask it yourself.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I'm waiting for your gesture of goodwill now.""]** — Mówca: **Player**
> ""I'm waiting for your gesture of goodwill now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Heron Garaci: ""I believe I have already showed that by coming here. Beh..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We need your help with the upcoming vote.""]** — Mówca: **Player**
> ""We need your help with the upcoming vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci), `[53]` (Heron Garaci), `[60]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Heron Garaci: ""I'm prepared to do that.""*)

### Węzeł `[58]`
Mówca: **Heron Garaci**
> ""I believe I have already showed that by coming here. Behind the Chief Justice's back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Heron Garaci: ""You know I'm taking a risk here.""*)

### Węzeł `[59]`
Mówca: **Heron Garaci**
> ""You know I'm taking a risk here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""You know I'm taking a much higher risk here, Mr. Garaci.""*)
  - -> `[65]` (*Player: ""Don't you dare opposing me after you accepted my money.""*)
  - -> `[69]` (*Player: ""Drop the act, Mr. Garaci. Let's not waste each other's t..."*)
  - -> `[67]` (*Player: ""Look. I need your help with the upcoming vote.""*)

### Węzeł `[60]`
Mówca: **Heron Garaci**
> ""I don't like to speculate. I want you to ask it yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""I'm not here to play your games.""*)
  - -> `[54]` (*Player: ""I want you and your buddies in the Court to pass the cha..."*)
  - -> `[57]` (*Player: ""We need your help with the upcoming vote.""*)

### Węzeł `[61]`
Mówca: **Heron Garaci**
> ""Yes. Not an easy thing to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: ""But I'm prepared to help with that.""*)

### Węzeł `[62]`
Mówca: **Heron Garaci**
> ""I'm prepared to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Heron Garaci: ""As long as we help each other.""*)

### Węzeł `[63]`
Mówca: **Heron Garaci**
> ""But I'm prepared to help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Heron Garaci: ""As long as we help each other.""*)

### Węzeł `[64]`
Mówca: **Heron Garaci**
> ""As long as we help each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He puffed himself up."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Don't you dare opposing me after you accepted my money.""]** — Mówca: **Player**
> ""Don't you dare opposing me after you accepted my money.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Heron Garaci: ""I have not yet decided what to do.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""You know I'm taking a much higher risk here, Mr. Garaci.""]** — Mówca: **Player**
> ""You know I'm taking a much higher risk here, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Heron Garaci: ""Perhaps you are right. You have already taken so much by..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Look. I need your help with the upcoming vote.""]** — Mówca: **Player**
> ""Look. I need your help with the upcoming vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Heron Garaci: ""I'm prepared to do that.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I'm not here to play your games.""]** — Mówca: **Player**
> ""I'm not here to play your games.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Heron Garaci: ""Fine.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Drop the act, Mr. Garaci. Let's not waste each other's time.""]** — Mówca: **Player**
> ""Drop the act, Mr. Garaci. Let's not waste each other's time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Heron Garaci: ""Fine.""*)

### Węzeł `[70]`
Mówca: **Heron Garaci**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He puffed himself up."*)

### Węzeł `[71]`
Mówca: **Heron Garaci**
> ""I have not yet decided what to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Heron Garaci: ""Let's not forget that you gave me evidence that could le..."*)

### Węzeł `[72]`
Mówca: **Heron Garaci**
> ""Perhaps you are right. You have already taken so much by getting involved in bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Heron Garaci: ""Let's not forget that you gave me evidence that could le..."*)

### Węzeł `[73]`
Mówca: **Heron Garaci**
> ""Let's not forget that you gave me evidence that could lead to a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He took a sip from his drink."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "He puffed himself up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Heron Garaci: ""I can help you beyond this vote.""*)

### Węzeł `[75]`
Mówca: **Heron Garaci**
> ""I can help you beyond this vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Heron Garaci: ""Wouldn't you want to have a Chief Justice who'd be sympa..."*)

### Węzeł `[76]`
Mówca: **Heron Garaci**
> ""Wouldn't you want to have a Chief Justice who'd be sympathetic to your concerns. Doesn't it sound nice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""So you want to take Orso's place huh?""*)
  - -> `[78]` (*Player: ""I don't think you would be that person.""*)
  - -> `[94]` (*Player: ""You're right. It does sound rather nice.""*)
  - -> `[77]` (*Player: ""I'm listening.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == false..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I don't think you would be that person.""]** — Mówca: **Player**
> ""I don't think you would be that person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Heron Garaci: ""I would be. If you allow me.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""So you want to take Orso's place huh?""]** — Mówca: **Player**
> ""So you want to take Orso's place huh?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Heron Garaci: ""Is it really that unexpected?""*)

### Węzeł `[80]`
Mówca: **Narrator**
> "He took a sip from his drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Heron Garaci: ""I'll be straightforward, Mr. President.""*)

### Węzeł `[81]`
Mówca: **Heron Garaci**
> ""I'll be straightforward, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Heron Garaci: ""I can help you beyond this vote.""*)

### Węzeł `[82]`
Mówca: **Heron Garaci**
> ""First of all, I have to say that I'm behind your proposal. It is the position of the majority of the Sollist Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Heron Garaci: ""We didn't want to create unnecessary risks by talking to..."*)

### Węzeł `[83]`
Mówca: **Heron Garaci**
> ""We didn't want to create unnecessary risks by talking to you directly until now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""I really did not expect this.""*)
  - -> `[85]` (*Player: ""So the Old Guard has actually decided to support me?""*)
  - -> `[86]` (*Player: ""I'll admit, it's a nice surprise to hear this from you.""*)
  - -> `[87]` (*Player: ""Sounds too good to be true. I was told otherwise about y..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I really did not expect this.""]** — Mówca: **Player**
> ""I really did not expect this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Heron Garaci: ""The problem is the Chief Justice.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""So the Old Guard has actually decided to support me?""]** — Mówca: **Player**
> ""So the Old Guard has actually decided to support me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Heron Garaci: ""Some of us see no problem with your proposal.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""I'll admit, it's a nice surprise to hear this from you.""]** — Mówca: **Player**
> ""I'll admit, it's a nice surprise to hear this from you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Heron Garaci: ""The problem is the Chief Justice.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Sounds too good to be true. I was told otherwise about your stance.""]** — Mówca: **Player**
> ""Sounds too good to be true. I was told otherwise about your stance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Heron Garaci: ""We can't be open about this now, can we?""*)

### Węzeł `[88]`
Mówca: **Heron Garaci**
> ""We can't be open about this now, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Heron Garaci: ""The problem is the Chief Justice.""*)

### Węzeł `[89]`
Mówca: **Heron Garaci**
> ""Some of us see no problem with your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Heron Garaci: ""The problem is the Chief Justice.""*)

### Węzeł `[90]`
Mówca: **Heron Garaci**
> ""The problem is the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Heron Garaci: ""He is fanatically working to undermine you. I'm afraid t..."*)

### Węzeł `[91]`
Mówca: **Heron Garaci**
> ""He is fanatically working to undermine you. I'm afraid that it has gone too far. There are plans of...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "He coughed and took a sip from his drink."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "He coughed and took a sip from his drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Heron Garaci: ""Well... He is organizing the Sollists against you. He ha..."*)

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""Well... He is organizing the Sollists against you. He has influence over a lot of people as you know, but he's now losing the Supreme Court's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "He straightened himself."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""You're right. It does sound rather nice.""]** — Mówca: **Player**
> ""You're right. It does sound rather nice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Heron Garaci: ""Well, I agree.""*)

### Węzeł `[95]`
Mówca: **Heron Garaci**
> ""Is it really that unexpected?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == false..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Heron Garaci: ""If you promise me to go ahead with it, I can provide you..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Heron Garaci: ""Promise me that you will dismiss him from the Supreme Co..."*)

### Węzeł `[99]`
Mówca: **Heron Garaci**
> ""I would be. If you allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == false..."*)

### Węzeł `[100]`
Mówca: **Heron Garaci**
> ""Well, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == false..."*)

### Węzeł `[101]`
Mówca: **Heron Garaci**
> ""I already have a reasonable support behind me. If Orso is dismissed from the Court, I can take his place and keep helping you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Heron Garaci: ""We must think beyond the vote, Mr. President.""*)

### Węzeł `[102]`
Mówca: **Heron Garaci**
> ""We must think beyond the vote, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""If you promise me to go ahead with it, I can provide you with some evidence against him. If we pass your proposal, you can use it to impeach him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Heron Garaci: ""And I will support you not only with the vote but afterw..."*)

### Węzeł `[104]`
Mówca: **Heron Garaci**
> ""Promise me that you will dismiss him from the Supreme Court. And him only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Heron Garaci: ""And I will support you not only with the vote but afterw..."*)

### Węzeł `[105]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""Are you positive the evidence can lead to his impeachment?""*)
  - -> `[109]` (*Player: ""I like the offer. It's a deal.""*)
  - -> `[113]` (*Player: ""I can't promise that.""*)

### Węzeł `[106]`
Mówca: **Heron Garaci**
> ""I thought you were the one who asked for my help, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Heron Garaci: ""I gave you my offer. If you don't like it, there will be..."*)

### Węzeł `[107]`
Mówca: **Heron Garaci**
> ""I gave you my offer. If you don't like it, there will be no support from my end. Easy as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Fine. It's a deal.""*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[115]` (*Player: ""Looks like our meeting is over.""*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I already wanted to do that.""]** — Mówca: **Player**
> ""I already wanted to do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Heron Garaci: ""So, it's a deal?""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I like the offer. It's a deal.""]** — Mówca: **Player**
> ""I like the offer. It's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Heron Garaci), `[111]` (Heron Garaci), `[228]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealAccepted]"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Are you positive the evidence can lead to his impeachment?""]** — Mówca: **Player**
> ""Are you positive the evidence can lead to his impeachment?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Heron Garaci: ""Well, yes. The new changes will allow the Grand National..."*)

### Węzeł `[111]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""I already wanted to do that.""*)
  - -> `[109]` (*Player: ""I like the offer. It's a deal.""*)
  - -> `[113]` (*Player: ""I can't promise that.""*)
  - -> `[112]` (*Player: ""I believe there are more people who needs to go.""*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""I believe there are more people who needs to go.""]** — Mówca: **Player**
> ""I believe there are more people who needs to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Heron Garaci), `[228]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Heron Garaci: ""That's not in the terms.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't promise that.""]** — Mówca: **Player**
> ""I can't promise that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Heron Garaci), `[111]` (Heron Garaci), `[228]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealTentative]"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Fine. It's a deal.""]** — Mówca: **Player**
> ""Fine. It's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealAccepted]"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Looks like our meeting is over.""]** — Mówca: **Player**
> ""Looks like our meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Heron Garaci: ""Looks like it. Shame.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""How about another investment, Mr. Garaci? I'm sure we can find an amount you'd like.""]** — Mówca: **Player**
> ""How about another investment, Mr. Garaci? I'm sure we can find an amount you'd like.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true` AND `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Heron Garaci: ""I'm listening.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: ""You'd better rethink your position, Mr. Garaci. I could ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[120]`
Mówca: **Heron Garaci**
> ""That's not in the terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""Fine. I like your offer. It's a deal.""*)
  - -> `[122]` (*Player: ""I don't like your offer.""*)
  - -> `[121]` (*Player: ""I make the terms here.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I make the terms here.""]** — Mówca: **Player**
> ""I make the terms here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealTentative]"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I don't like your offer.""]** — Mówca: **Player**
> ""I don't like your offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealTentative]"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Fine. I like your offer. It's a deal.""]** — Mówca: **Player**
> ""Fine. I like your offer. It's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealAccepted]"*)

### Węzeł `[124]`
Mówca: **Heron Garaci**
> ""Great to have come to an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice = true"*)

### Węzeł `[125]`
Mówca: **Heron Garaci**
> ""So, it's a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""No. I can't promise you such a thing.""*)
  - -> `[127]` (*Player: ""Yes. It's a deal.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""No. I can't promise you such a thing.""]** — Mówca: **Player**
> ""No. I can't promise you such a thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealTentative]"*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Yes. It's a deal.""]** — Mówca: **Player**
> ""Yes. It's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "Jump to: [DealAccepted]"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealTentative]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "DealTentative"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealAccepted]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "DealAccepted"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DealAccepted`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Heron Garaci: ""Great to have come to an understanding.""*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_BribedToMeet == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_BribedToMeet == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_BribedToMeet == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_BribedToMeet == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_BribedToMeet == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""How about another investment, Mr. Garaci? I'm sure we ca..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_BribedToMeet == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""How about a financial investment instead?""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""How about a financial investment instead?""]** — Mówca: **Player**
> ""How about a financial investment instead?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false` AND `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Heron Garaci: ""I'm listening.""*)

### Węzeł `[138]`
Mówca: **Heron Garaci**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[143]` (*Player: ""I'm sure this would convince you. [-1 Personal Wealth]""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""Here. I'll be generous. [-2 Personal Wealth]""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Here. I'll be generous. [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Here. I'll be generous. [-2 Personal Wealth]""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[138]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Hero..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I'm sure this would convince you. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""I'm sure this would convince you. [-1 Personal Wealth]""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1; BaseGame.Reform_Reform_Hero..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""You'd better rethink your position, Mr. Garaci. I could have you dusted off.""]** — Mówca: **Player**
> ""You'd better rethink your position, Mr. Garaci. I could have you dusted off.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci), `[218]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Heron Garaci: ""You're threatening me?""*)

### Węzeł `[145]`
Mówca: **Heron Garaci**
> ""You're threatening me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He put his hat back on."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""You'd better rethink your position, Mr. Garaci. I could ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[149]`
**[WYBÓR GRACZA: ""You'd better rethink your position, Mr. Garaci. I could have you thrown in the can.""]** — Mówca: **Player**
> ""You'd better rethink your position, Mr. Garaci. I could have you thrown in the can.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true` AND `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Heron Garaci), `[218]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Heron Garaci: ""You're threatening me with that?""*)

### Węzeł `[150]`
Mówca: **Heron Garaci**
> ""You're threatening me with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He laughed and put his hat back on."*)

### Węzeł `[151]`
Mówca: **Heron Garaci**
> ""That was a clear death threat towards a Supreme Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He stood up."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Heron Garaci: ""That was a clear death threat towards a Supreme Justice.""*)

### Węzeł `[153]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Heron Garaci: ""It's time I get going.""*)

### Węzeł `[154]`
Mówca: **Heron Garaci**
> ""It's time I get going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Farewell, Mr. Garaci.""*)
  - -> `[170]` (*Player: ""You'll regret not supporting me.""*)
  - -> `[169]` (*Player: ""SIT DOWN.""*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He laughed and put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Heron Garaci: ""It looks like we don't share a collaborative spirit.""*)

### Węzeł `[156]`
Mówca: **Heron Garaci**
> ""It looks like we don't share a collaborative spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "He stood up."*)

### Węzeł `[157]`
Mówca: **Heron Garaci**
> ""Looks like it. Shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Heron Garaci: ""It's time I get going then.""*)

### Węzeł `[158]`
Mówca: **Heron Garaci**
> ""It's time I get going then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He put his hat back on and stood up."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "He put his hat back on and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""It was nice to have you here, Mr. Garaci. I hope you'll ..."*)
  - -> `[171]` (*Player: ""Farewell, Mr. Garaci.""*)
  - -> `[170]` (*Player: ""You'll regret not supporting me.""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Heron_BribedToVote = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He smiled."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1;
BaseGame.Reform_Reform_Heron_BribedToVote = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He smiled."*)

### Węzeł `[162]`
Mówca: **Heron Garaci**
> ""I guess this works.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Heron Garaci: ""Fine. I'll help you with the vote.""*)

### Węzeł `[163]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Heron Garaci: ""I guess this works.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Heron Garaci: ""But I can now safely say that I will do my best to have ..."*)

### Węzeł `[165]`
Mówca: **Heron Garaci**
> ""But I can now safely say that I will do my best to have your proposal pass the Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He put his hat back on."*)

### Węzeł `[166]`
Mówca: **Heron Garaci**
> ""Fine. I'll help you with the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He put his hat back on."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "He put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced = true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""I hope I can rely on you.""*)
  - -> `[181]` (*Player: ""Looking forward to our cooperation.""*)
  - -> `[180]` (*Player: ""Thank you for coming, Mr. Garaci. It was a fruitful meet..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""SIT DOWN.""]** — Mówca: **Player**
> ""SIT DOWN.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Heron Garaci: ""I am not your dog, Mr. Rayne.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""You'll regret not supporting me.""]** — Mówca: **Player**
> ""You'll regret not supporting me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Heron Garaci), `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Heron Garaci: ""Goodbye, Mr. President.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Farewell, Mr. Garaci.""]** — Mówca: **Player**
> ""Farewell, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Heron Garaci), `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Heron Garaci: ""Goodbye, Mr. President. It was nice to talk to you.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""It was nice to have you here, Mr. Garaci. I hope you'll reconsider your support.""]** — Mówca: **Player**
> ""It was nice to have you here, Mr. Garaci. I hope you'll reconsider your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Heron Garaci: ""Thank you for inviting me here. It's a shame that we're ..."*)

### Węzeł `[173]`
Mówca: **Heron Garaci**
> ""Thank you for inviting me here. It's a shame that we're leaving empty-handed, but it was a nice meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He left me alone with my thoughts."*)

### Węzeł `[174]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President. It was nice to talk to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He left me alone with my thoughts."*)

### Węzeł `[175]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He left me alone with my thoughts."*)

### Węzeł `[176]`
Mówca: **Heron Garaci**
> ""I am not your dog, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Heron Garaci: ""Don't forget your place.""*)

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""Don't forget your place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He left me alone with my thoughts."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "He left me alone with my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceHeron = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_ConvinceHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced == true"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Thank you for coming, Mr. Garaci. It was a fruitful meeting.""]** — Mówca: **Player**
> ""Thank you for coming, Mr. Garaci. It was a fruitful meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "We shook hands and he left me alone with my thoughts."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Looking forward to our cooperation.""]** — Mówca: **Player**
> ""Looking forward to our cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "We shook hands and he left me alone with my thoughts."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I hope I can rely on you.""]** — Mówca: **Player**
> ""I hope I can rely on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "We shook hands and he left me alone with my thoughts."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "We shook hands and he left me alone with my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceHeron = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == false"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == false)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "It was yet another sunny day, and I was facing another im..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "It was yet another sunny day, and I was facing another im..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "It was yet another sunny day, and I was facing another im..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Heron Garaci: ""I want to help you, Mr. President.""*)

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""I want to help you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""I can organize the justices to vote for your proposal.""*)

### Węzeł `[193]`
Mówca: **Heron Garaci**
> ""I can organize the justices to vote for your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Heron Garaci: ""I can help you beyond this vote.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Heron_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Heron_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_Convinced == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_Convinced == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Heron_Convinced = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Heron_Failed = true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Heron_Failed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Heron_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealAccepted]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "DealAccepted"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealAccepted]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "DealAccepted"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealAccepted]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "DealAccepted"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DealTentative`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Heron Garaci: ""I thought you were the one who asked for my help, Mr. Pr..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealTentative]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "DealTentative"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DealTentative]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "DealTentative"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: ""Here. I'll be generous. [-2 Personal Wealth]""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Here. I'll be generous. [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Here. I'll be generous. [-2 Personal Wealth]""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[211]` (Heron Garaci), `[218]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Hero..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""Fine. I'm sure this would convince you. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""Fine. I'm sure this would convince you. [-1 Personal Wealth]""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[211]` (Heron Garaci), `[218]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1; BaseGame.Reform_Reform_Hero..."*)

### Węzeł `[210]`
Mówca: **Heron Garaci**
> ""If you can help me with some *investments,* I can be a valuable ally to have in the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Heron Garaci: ""And I will support you not only with the vote but afterw..."*)

### Węzeł `[211]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[216]` (*Player: ""I can't promise that.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: ""Fine. I'm sure this would convince you. [-1 Personal Wea..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""I'm sorry, Mr. Garaci. I don't have anything to spare.""*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Garaci. I don't have anything to spare.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Garaci. I don't have anything to spare.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[211]` (Heron Garaci), `[218]` (Heron Garaci), `[220]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Heron Garaci: ""It's time I get going then.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""I can't promise that.""]** — Mówca: **Player**
> ""I can't promise that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Heron Garaci: ""I thought you were the one who asked for my help, Mr. Pr..."*)

### Węzeł `[217]`
Mówca: **Heron Garaci**
> ""I thought you were the one who asked for my help, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Heron Garaci: ""I gave you my offer. If you don't like it, there will be..."*)

### Węzeł `[218]`
Mówca: **Heron Garaci**
> ""I gave you my offer. If you don't like it, there will be no support from my end. Easy as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[219]` (*Player: ""Can we figure something else out?""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Can we figure something else out?""]** — Mówca: **Player**
> ""Can we figure something else out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Heron Garaci: ""No.""*)

### Węzeł `[220]`
Mówca: **Heron Garaci**
> ""No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Looks like our meeting is over.""*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1;
BaseGame.Reform_Reform_Heron_BribedToVote = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He smiled."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Heron_BribedToVote = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He smiled."*)

### Węzeł `[223]`
Mówca: **Heron Garaci**
> ""I already have a reasonable support behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Heron Garaci: ""If you can help me with some *investments,* I can be a v..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == false..."*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == fal..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Heron Garaci: ""I already have a reasonable support behind me.""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Heron Garaci: ""I already have a reasonable support behind me. If Orso i..."*)

### Węzeł `[227]`
Mówca: **Heron Garaci**
> ""With the evidence I can provide, you can make a case to the Assembly to start his impeachment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Heron Garaci: ""In such a circumstance, I'm pretty sure the members of t..."*)

### Węzeł `[228]`
Mówca: **Heron Garaci**
> ""In such a circumstance, I'm pretty sure the members of the assembly would proceed with it. Mr. Hawker is not enjoying his old popularity anymore. We all know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: ""I see. That makes sense.""*)
  - -> `[109]` (*Player: ""I like the offer. It's a deal.""*)
  - -> `[113]` (*Player: ""I can't promise that.""*)
  - -> `[112]` (*Player: ""I believe there are more people who needs to go.""*)

### Węzeł `[229]`
Mówca: **Heron Garaci**
> ""Well, yes. The new changes will allow the Grand National Assembly to impeach the justices. I thought your intention was to use that for your own interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Heron Garaci: ""With the evidence I can provide, you can make a case to ..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: ""I see. That makes sense.""]** — Mówca: **Player**
> ""I see. That makes sense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Heron Garaci: ""So, it's a deal?""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Heron Garaci: ""So, Mr. President...""*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
