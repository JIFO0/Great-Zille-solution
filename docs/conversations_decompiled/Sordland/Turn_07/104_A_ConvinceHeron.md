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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[160]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2; Variable["BaseGame...`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1; Variable["BaseGame...`
- Węzeł `[164]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] = true;`
- Węzeł `[168]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Reform_Heron_Convinced"] = true;`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- Węzeł `[190]` (Paskal Beniwoll): `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- Węzeł `[194]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Heron_Convinced"] = true;`
- Węzeł `[198]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_Heron_Failed"] = true;`
- *...oraz 3 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Kesaro Kibener had convinced him to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Heron Garaci**
> ""Very nice location you've set up here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Oh this place is not mine. It's Petr's.""]** — Mówca: **Player**
> ""Oh this place is not mine. It's Petr's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Vineyard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[10]`
Mówca: **Narrator**
> "It was yet another sunny day, and I was facing another important political figure: Heron Garaci."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_SentKesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentLucian == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentLucian == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentLucian"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_SentLucian == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentLucian"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucian had managed to convince him to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[18]`
Mówca: **Narrator**
> "The bribe had worked and he agreed to have a meeting with me just before the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[19]`
Mówca: **Narrator**
> "We scheduled to meet outside of Holsord, in my new vineyard in Erlory, where we could have some privacy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Narrator**
> "We scheduled to meet outside of Holsord, in the Gentlemen's Club of Petr in Erlory, where we could have some privacy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "I grabbed a drink and sat down under the shadow of a red oak at the villa's garden overlooking the red grapevines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Narrator**
> "I grabbed a drink and sat down on the balcony of the villa overlooking its vast garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Heron Garaci**
> ""Very nice place you've got here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_HeronMeeting_OfferBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_HeronMeeting_OfferBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_HeronMeeting_OfferBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "He had reached out to us and wished for a meeting just ahead of the Court vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Heron sat next to me in his beige checked suit and took off his white trilby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Heron sat next to me in his beige checked suit and took off his white trilby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[30]`
Mówca: **Heron Garaci**
> ""Didn't know you were a winegrower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[31]`
Mówca: **Heron Garaci**
> ""A Gentlemen's Club, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""We thought this place would be fitting.""]** — Mówca: **Player**
> ""We thought this place would be fitting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't set up meetings. My team chose this place.""]** — Mówca: **Player**
> ""I don't set up meetings. My team chose this place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Heron Garaci**
> ""Didn't know the Vice President had such good taste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[35]`
Mówca: **Heron Garaci**
> ""Yes. Fitting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[36]`
Mówca: **Heron Garaci**
> ""Please send my regards to your team then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Oh I'm not. I just recently bought this place.""]** — Mówca: **Player**
> ""Oh I'm not. I just recently bought this place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Me neither. It just happened.""]** — Mówca: **Player**
> ""Me neither. It just happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I like the calmness here. And the sight of the grapevines.""]** — Mówca: **Player**
> ""I like the calmness here. And the sight of the grapevines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Heron Garaci**
> ""Well, I'll be looking forward to have a taste of your wines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Heron Garaci**
> ""You're lucky to have such a place to come and relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Heron Garaci**
> ""So, Mr. President... I wanted to talk to you for a couple of reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[47]`
Mówca: **Heron Garaci**
> ""So, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_BribedToMeet == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_BribedToMeet == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_BribedToMeet == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Heron Garaci**
> ""Your gesture of goodwill went a long way. Please do speak of your intentions and how I could I be of assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Heron Garaci**
> ""You went a long way to make this meeting possible. I had to pay you the respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Heron Garaci**
> ""Please do speak of your intentions and how I could I be of assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I want you and your buddies in the Court to pass the changes.""]** — Mówca: **Player**
> ""I want you and your buddies in the Court to pass the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""You know what I want.""]** — Mówca: **Player**
> ""You know what I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I'm waiting for your gesture of goodwill now.""]** — Mówca: **Player**
> ""I'm waiting for your gesture of goodwill now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We need your help with the upcoming vote.""]** — Mówca: **Player**
> ""We need your help with the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Heron Garaci**
> ""I believe I have already showed that by coming here. Behind the Chief Justice's back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Heron Garaci**
> ""You know I'm taking a risk here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[69]`
  - -> `[67]`

### Węzeł `[60]`
Mówca: **Heron Garaci**
> ""I don't like to speculate. I want you to ask it yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[54]`
  - -> `[57]`

### Węzeł `[61]`
Mówca: **Heron Garaci**
> ""Yes. Not an easy thing to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Heron Garaci**
> ""I'm prepared to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Heron Garaci**
> ""But I'm prepared to help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Heron Garaci**
> ""As long as we help each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Don't you dare opposing me after you accepted my money.""]** — Mówca: **Player**
> ""Don't you dare opposing me after you accepted my money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""You know I'm taking a much higher risk here, Mr. Garaci.""]** — Mówca: **Player**
> ""You know I'm taking a much higher risk here, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Look. I need your help with the upcoming vote.""]** — Mówca: **Player**
> ""Look. I need your help with the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I'm not here to play your games.""]** — Mówca: **Player**
> ""I'm not here to play your games.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Drop the act, Mr. Garaci. Let's not waste each other's time.""]** — Mówca: **Player**
> ""Drop the act, Mr. Garaci. Let's not waste each other's time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Heron Garaci**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Heron Garaci**
> ""I have not yet decided what to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Heron Garaci**
> ""Perhaps you are right. You have already taken so much by getting involved in bribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Heron Garaci**
> ""Let's not forget that you gave me evidence that could lead to a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
Mówca: **Narrator**
> "He puffed himself up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Heron Garaci**
> ""I can help you beyond this vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Heron Garaci**
> ""Wouldn't you want to have a Chief Justice who'd be sympathetic to your concerns. Doesn't it sound nice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[78]`
  - -> `[94]`
  - -> `[77]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I don't think you would be that person.""]** — Mówca: **Player**
> ""I don't think you would be that person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""So you want to take Orso's place huh?""]** — Mówca: **Player**
> ""So you want to take Orso's place huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[80]`
Mówca: **Narrator**
> "He took a sip from his drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Heron Garaci**
> ""I'll be straightforward, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Heron Garaci**
> ""First of all, I have to say that I'm behind your proposal. It is the position of the majority of the Sollist Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Heron Garaci**
> ""We didn't want to create unnecessary risks by talking to you directly until now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[86]`
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I really did not expect this.""]** — Mówca: **Player**
> ""I really did not expect this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""So the Old Guard has actually decided to support me?""]** — Mówca: **Player**
> ""So the Old Guard has actually decided to support me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""I'll admit, it's a nice surprise to hear this from you.""]** — Mówca: **Player**
> ""I'll admit, it's a nice surprise to hear this from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Sounds too good to be true. I was told otherwise about your stance.""]** — Mówca: **Player**
> ""Sounds too good to be true. I was told otherwise about your stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Heron Garaci**
> ""We can't be open about this now, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Heron Garaci**
> ""Some of us see no problem with your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Heron Garaci**
> ""The problem is the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Heron Garaci**
> ""He is fanatically working to undermine you. I'm afraid that it has gone too far. There are plans of...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "He coughed and took a sip from his drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""Well... He is organizing the Sollists against you. He has influence over a lot of people as you know, but he's now losing the Supreme Court's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""You're right. It does sound rather nice.""]** — Mówca: **Player**
> ""You're right. It does sound rather nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Heron Garaci**
> ""Is it really that unexpected?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Heron Garaci**
> ""I would be. If you allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[100]`
Mówca: **Heron Garaci**
> ""Well, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[101]`
Mówca: **Heron Garaci**
> ""I already have a reasonable support behind me. If Orso is dismissed from the Court, I can take his place and keep helping you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Heron Garaci**
> ""We must think beyond the vote, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""If you promise me to go ahead with it, I can provide you with some evidence against him. If we pass your proposal, you can use it to impeach him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Heron Garaci**
> ""Promise me that you will dismiss him from the Supreme Court. And him only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[105]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Heron Garaci**
> ""I thought you were the one who asked for my help, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Heron Garaci**
> ""I gave you my offer. If you don't like it, there will be no support from my end. Easy as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[131]`
  - -> `[115]`
  - -> `[117]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I already wanted to do that.""]** — Mówca: **Player**
> ""I already wanted to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I like the offer. It's a deal.""]** — Mówca: **Player**
> ""I like the offer. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Are you positive the evidence can lead to his impeachment?""]** — Mówca: **Player**
> ""Are you positive the evidence can lead to his impeachment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[111]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[113]`
  - -> `[112]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""I believe there are more people who needs to go.""]** — Mówca: **Player**
> ""I believe there are more people who needs to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't promise that.""]** — Mówca: **Player**
> ""I can't promise that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Fine. It's a deal.""]** — Mówca: **Player**
> ""Fine. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Looks like our meeting is over.""]** — Mówca: **Player**
> ""Looks like our meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""How about another investment, Mr. Garaci? I'm sure we can find an amount you'd like.""]** — Mówca: **Player**
> ""How about another investment, Mr. Garaci? I'm sure we can find an amount you'd like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[120]`
Mówca: **Heron Garaci**
> ""That's not in the terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[122]`
  - -> `[121]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I make the terms here.""]** — Mówca: **Player**
> ""I make the terms here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I don't like your offer.""]** — Mówca: **Player**
> ""I don't like your offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Fine. I like your offer. It's a deal.""]** — Mówca: **Player**
> ""Fine. I like your offer. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[124]`
Mówca: **Heron Garaci**
> ""Great to have come to an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[125]`
Mówca: **Heron Garaci**
> ""So, it's a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""No. I can't promise you such a thing.""]** — Mówca: **Player**
> ""No. I can't promise you such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Yes. It's a deal.""]** — Mówca: **Player**
> ""Yes. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealTentative])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealAccepted])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DealAccepted)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_BribedToMeet == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_BribedToMeet == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_BribedToMeet == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_BribedToMeet"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""How about a financial investment instead?""]** — Mówca: **Player**
> ""How about a financial investment instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Heron Garaci**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[143]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Here. I'll be generous. [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Here. I'll be generous. [-2 Personal Wealth]""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I'm sure this would convince you. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""I'm sure this would convince you. [-1 Personal Wealth]""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""You'd better rethink your position, Mr. Garaci. I could have you dusted off.""]** — Mówca: **Player**
> ""You'd better rethink your position, Mr. Garaci. I could have you dusted off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Heron Garaci**
> ""You're threatening me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[149]`
**[WYBÓR GRACZA: ""You'd better rethink your position, Mr. Garaci. I could have you thrown in the can.""]** — Mówca: **Player**
> ""You'd better rethink your position, Mr. Garaci. I could have you thrown in the can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Heron Garaci**
> ""You're threatening me with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Heron Garaci**
> ""That was a clear death threat towards a Supreme Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Heron Garaci**
> ""It's time I get going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[170]`
  - -> `[169]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He laughed and put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Heron Garaci**
> ""It looks like we don't share a collaborative spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[157]`
Mówca: **Heron Garaci**
> ""Looks like it. Shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Heron Garaci**
> ""It's time I get going then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Narrator**
> "He put his hat back on and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[171]`
  - -> `[170]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Heron_BribedToVote = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1;
BaseGame.Reform_Reform_Heron_BribedToVote = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Heron Garaci**
> ""I guess this works.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_PromisedChiefJustice = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Heron Garaci**
> ""But I can now safely say that I will do my best to have your proposal pass the Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Heron Garaci**
> ""Fine. I'll help you with the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Narrator**
> "He put his hat back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[181]`
  - -> `[180]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""SIT DOWN.""]** — Mówca: **Player**
> ""SIT DOWN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""You'll regret not supporting me.""]** — Mówca: **Player**
> ""You'll regret not supporting me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Farewell, Mr. Garaci.""]** — Mówca: **Player**
> ""Farewell, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""It was nice to have you here, Mr. Garaci. I hope you'll reconsider your support.""]** — Mówca: **Player**
> ""It was nice to have you here, Mr. Garaci. I hope you'll reconsider your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Heron Garaci**
> ""Thank you for inviting me here. It's a shame that we're leaving empty-handed, but it was a nice meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President. It was nice to talk to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Heron Garaci**
> ""I am not your dog, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""Don't forget your place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "He left me alone with my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_ConvinceHeron = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Thank you for coming, Mr. Garaci. It was a fruitful meeting.""]** — Mówca: **Player**
> ""Thank you for coming, Mr. Garaci. It was a fruitful meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Looking forward to our cooperation.""]** — Mówca: **Player**
> ""Looking forward to our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I hope I can rely on you.""]** — Mówca: **Player**
> ""I hope I can rely on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "We shook hands and he left me alone with my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true || BaseGame.Faction_Oligarchs_Ally == true || BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[191]`
Mówca: **Narrator**
> "He straightened himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""I want to help you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Heron Garaci**
> ""I can organize the justices to vote for your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Heron_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Heron_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Heron_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Heron_Failed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Heron_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealAccepted])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealAccepted])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealAccepted])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DealTentative)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealTentative])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DealTentative])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Here. I'll be generous. [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Here. I'll be generous. [-2 Personal Wealth]""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""Fine. I'm sure this would convince you. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""Fine. I'm sure this would convince you. [-1 Personal Wealth]""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[210]`
Mówca: **Heron Garaci**
> ""If you can help me with some *investments,* I can be a valuable ally to have in the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Heron Garaci**
> ""And I will support you not only with the vote but afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[212]`
  - -> `[216]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Garaci. I don't have anything to spare.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Garaci. I don't have anything to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""I can't promise that.""]** — Mówca: **Player**
> ""I can't promise that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Heron Garaci**
> ""I thought you were the one who asked for my help, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Heron Garaci**
> ""I gave you my offer. If you don't like it, there will be no support from my end. Easy as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[205]`
  - -> `[212]`
  - -> `[219]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Can we figure something else out?""]** — Mówca: **Player**
> ""Can we figure something else out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Heron Garaci**
> ""No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[117]`
  - -> `[205]`
  - -> `[212]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1;
BaseGame.Reform_Reform_Heron_BribedToVote = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2; BaseGame.Reform_Reform_Heron_BribedToVote = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Reform_Reform_Heron_BribedToVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[223]`
Mówca: **Heron Garaci**
> ""I already have a reasonable support behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == false && BaseGame.Reform_Law_Judges_Impeachment_Assembly == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[227]`
Mówca: **Heron Garaci**
> ""With the evidence I can provide, you can make a case to the Assembly to start his impeachment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Heron Garaci**
> ""In such a circumstance, I'm pretty sure the members of the assembly would proceed with it. Mr. Hawker is not enjoying his old popularity anymore. We all know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[109]`
  - -> `[113]`
  - -> `[112]`

### Węzeł `[229]`
Mówca: **Heron Garaci**
> ""Well, yes. The new changes will allow the Grand National Assembly to impeach the justices. I thought your intention was to use that for your own interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[230]`
**[WYBÓR GRACZA: ""I see. That makes sense.""]** — Mówca: **Player**
> ""I see. That makes sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
