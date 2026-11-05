# Sordland/Turn07/EnT_NationalizationAndPrivatization

- **ID konwersacji:** `99`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/099_EnT_NationalizationAndPrivatization.md`
- **Liczba węzłów dialogowych:** 280
- **Liczba wyborów gracza:** 45

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[25]** Edith Agnoc
- **[38]** Lucian Galade
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority`
- `BaseGameIsolated.Turn07_EnT_HOS_Full`
- `BaseGameIsolated.Turn07_EnT_HOS_Majority`
- `BaseGameIsolated.Turn07_EnT_HOS_Minority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Full`
- `BaseGameIsolated.Turn07_EnT_Nedam_Majority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Minority`
- `BaseGameIsolated.Turn07_EnT_SSC_Full`
- `BaseGameIsolated.Turn07_EnT_SSC_Majority`
- `BaseGameIsolated.Turn07_EnT_SSC_Minority`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority`
- `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority`
- `BaseGameIsolated.Turn07_EnT_HOS_Full`
- `BaseGameIsolated.Turn07_EnT_HOS_Majority`
- `BaseGameIsolated.Turn07_EnT_HOS_Minority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Full`
- `BaseGameIsolated.Turn07_EnT_Nedam_Majority`
- `BaseGameIsolated.Turn07_EnT_Nedam_Minority`
- `BaseGameIsolated.Turn07_EnT_SSC_Full`
- `BaseGameIsolated.Turn07_EnT_SSC_Majority`
- `BaseGameIsolated.Turn07_EnT_SSC_Minority`
- `GameCondition.Turn07_EnT_Intro_NationalizationPrivatization`

### Skoki między-konwersacyjne:
- Węzeł `[3]` -> **[100] Sordland/Turn07/Privatization and Nationalization Feedback** (../Turn_07/100_Privatization_and_Nationalization_Feedback.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“Exactly. I will not be swayed.”"** | `[20]` **Symon Holl**: "“But as I understand it, your de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Symon Holl**: "“Let's move on to how we can go ..." |
| `[22]` | **"“Which 'certain individuals' were those?”"** | `[20]` **Symon Holl**: "“But as I understand it, your de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Mikail Aven**: "“Me and Edith's, Mr. President.”" |
| `[23]` | **"“Yes. And you will respect my decision whether you like it or not.”"** | `[20]` **Symon Holl**: "“But as I understand it, your de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Edith Agnoc**: "“But--”" |
| `[26]` | **"“Too bad. Your opinion doesn't matter.”"** | `[25]` **Edith Agnoc**: "“I am very much against a nation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Edith Agnoc**: "“But--”" |
| `[27]` | **"“And why is that?”"** | `[25]` **Edith Agnoc**: "“I am very much against a nation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Edith Agnoc**: "“It's simple, really.”" |
| `[30]` | **"“This is for the good of our country.”"** | `[25]` **Edith Agnoc**: "“I am very much against a nation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Edith Agnoc**: "“I don't think so.”" |
| `[34]` | **"“And you personally won't be able to profit. Isn't that right, Ms. Agnoc?”"** | `[33]` **Edith Agnoc**: "“But in the long term, you are l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Edith Agnoc**: "“No. That is not my point.”" |
| `[36]` | **"“Are you saying that the state of Sordland is untrustworthy?”"** | `[33]` **Edith Agnoc**: "“But in the long term, you are l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Edith Agnoc**: "“No. Of course it is trustworthy..." |
| `[37]` | **"“I've heard enough. You will accept my decision regardless.”"** | `[33]` **Edith Agnoc**: "“But in the long term, you are l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Edith Agnoc**: "“But, I-”" |
| `[48]` | **"Turn to page 14."** | `[47]` **Symon Holl**: "“Please turn to page 14.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Symon Holl**: "“As you can see on the document,..." |
| `[71]` | **"“What would the effects be if we fully nationalize Heart of Sordland?”"** | `[58]` **Lucian Galade**: "“If we are going to nationalize ..."<br>`[83]` **Player**: "“I will think about it.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false` | *Brak zmian stanu* | `[78]` **Edith Agnoc**: "“They'd be disastrous, is what t..." |
| `[72]` | **"“What if we just assume minority ownership of HOS?”"** | `[58]` **Lucian Galade**: "“If we are going to nationalize ..."<br>`[83]` **Player**: "“I will think about it.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false` | *Brak zmian stanu* | `[87]` **Lucian Galade**: "“At first glance, a minority sha..." |
| `[73]` | **"“What about a majority share?”"** | `[58]` **Lucian Galade**: "“If we are going to nationalize ..."<br>`[83]` **Player**: "“I will think about it.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false` | *Brak zmian stanu* | `[90]` **Symon Holl**: "“I believe this is the way to go.”" |
| `[74]` | **"“I already know what to do. Let's move on to our next option.”"** | `[58]` **Lucian Galade**: "“If we are going to nationalize ..."<br>`[83]` **Player**: "“I will think about it.”"<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true) == false` | *Brak zmian stanu* | `[76]` **Symon Holl**: "“Very well. Please turn to page ..." |
| `[75]` | **"“Let's move on to our next option.”"** | `[58]` **Lucian Galade**: "“If we are going to nationalize ..."<br>`[83]` **Player**: "“I will think about it.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true` | *Brak zmian stanu* | `[76]` **Symon Holl**: "“Very well. Please turn to page ..." |
| `[77]` | **"Turn to page 37."** | `[76]` **Symon Holl**: "“Very well. Please turn to page ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Symon Holl**: "“Bergia Steel.”" |
| `[82]` | **"“Why is that?”"** | `[81]` **Mikail Aven**: "“But if you insist on nationaliz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Mikail Aven**: "“Marcel Koronti is growing too p..." |
| `[83]` | **"“I will think about it.”"** | `[81]` **Mikail Aven**: "“But if you insist on nationaliz..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] = true;` | `[71]` **Player**: "“What would the effects be if we..."<br>`[72]` **Player**: "“What if we just assume minority..."<br>*(oraz 3 innych odgałęzień)* |
| `[106]` | **"“What would the effects be if we fully nationalize Bergia Steel?”"** | `[102]` **Lucian Galade**: "“I don't have so strong of an op..."<br>`[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”"<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false` | *Brak zmian stanu* | `[124]` **Mikail Aven**: "“Where do I start?"" |
| `[107]` | **"“What are your thoughts on a minority share?”"** | `[102]` **Lucian Galade**: "“I don't have so strong of an op..."<br>`[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”"<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false` | *Brak zmian stanu* | `[137]` **Symon Holl**: "“As I mentioned, I am against ma..." |
| `[111]` | **"“I have already decided on what we need to do.”"** | `[102]` **Lucian Galade**: "“I don't have so strong of an op..."<br>`[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”"<br>*(oraz 7 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true) == false` | *Brak zmian stanu* | `[154]` **Symon Holl**: "“Sounds good.”" |
| `[112]` | **"“What would be the outcome of taking a majority share?”"** | `[102]` **Lucian Galade**: "“I don't have so strong of an op..."<br>`[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”"<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false` | *Brak zmian stanu* | `[141]` **Symon Holl**: "“This is of course a better opti..." |
| `[113]` | **"“I am ready to make a decision.”"** | `[102]` **Lucian Galade**: "“I don't have so strong of an op..."<br>`[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”"<br>*(oraz 7 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true` | *Brak zmian stanu* | `[154]` **Symon Holl**: "“Sounds good.”" |
| `[127]` | **"“Is that a threat, Mikail?”"** | `[126]` **Mikail Aven**: "“If you do this, you will anger ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Mikail Aven**: "“No, Mr. President. It's a fact.”" |
| `[129]` | **"“I understand the predicament, but it is necessary.”"** | `[126]` **Mikail Aven**: "“If you do this, you will anger ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Edith Agnoc**: "“I don't see how this is *necess..." |
| `[130]` | **"“Let them come. I am not afraid.”"** | `[126]` **Mikail Aven**: "“If you do this, you will anger ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Edith Agnoc**: "“I think you should be.”" |
| `[131]` | **"“You are right. I don't want more enemies.”"** | `[126]` **Mikail Aven**: "“If you do this, you will anger ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Edith Agnoc**: "“I knew you would see reason.”" |
| `[145]` | **"“No need to be afraid. If push comes to shove, I will handle it.”"** | `[144]` **Symon Holl**: "“And if I may make an understate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Symon Holl**: "“It's the administration I'm wor..." |
| `[146]` | **"“He is scary for sure. I would hate to make an enemy out of him.”"** | `[144]` **Symon Holl**: "“And if I may make an understate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: "“He seems to hold everyone in hi..." |
| `[148]` | **"“If that day comes, Walter Tusk will learn Anton Rayne is *also* not a forgiving m..."** | `[144]` **Symon Holl**: "“And if I may make an understate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Lucian Galade**: "“As you say.”" |
| `[172]` | **"“You are saying this only because you will have a stake in it.”"** | `[171]` **Edith Agnoc**: "“We can then use these funds to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Edith Agnoc**: "“Of course not! I am saying this..." |
| `[173]` | **"“I am glad we are on the same page.”"** | `[171]` **Edith Agnoc**: "“We can then use these funds to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Edith Agnoc**: "“Certainly!”" |
| `[175]` | **"“Enough with the flattery.”"** | `[171]` **Edith Agnoc**: "“We can then use these funds to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Edith Agnoc**: "“I have to give credit when it's..." |
| `[182]` | **"Turn to page 6."** | `[181]` **Symon Holl**: "“Please turn to page 6.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Symon Holl**: "“As you can see on the document,..." |
| `[196]` | **"“What would the effects be if we fully privatize the Sordish State Corporation?”"** | `[191]` **Lucian Galade**: "“If we privatize these companies..."<br>`[220]` **Lucian Galade**: "“I am against full privatization..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false` | *Brak zmian stanu* | `[216]` **Symon Holl**: "“We would gain tremendous amount..." |
| `[197]` | **"“What if we sell a minority share of SSC?”"** | `[191]` **Lucian Galade**: "“If we privatize these companies..."<br>`[220]` **Lucian Galade**: "“I am against full privatization..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false` | *Brak zmian stanu* | `[221]` **Edith Agnoc**: "“It would be better than nothing..." |
| `[206]` | **"Turn to page 26."** | `[207]` **Symon Holl**: "“Very well. Please turn to page ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Symon Holl**: "“Nedam Mining Group.”" |
| `[208]` | **"“What about selling a majority share?”"** | `[191]` **Lucian Galade**: "“If we privatize these companies..."<br>`[220]` **Lucian Galade**: "“I am against full privatization..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false` | *Brak zmian stanu* | `[225]` **Mikail Aven**: "“This is certainly a very good o..." |
| `[212]` | **"“I already know what to do. Let's move on to the next option.”"** | `[191]` **Lucian Galade**: "“If we privatize these companies..."<br>`[220]` **Lucian Galade**: "“I am against full privatization..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true) == false` | *Brak zmian stanu* | `[207]` **Symon Holl**: "“Very well. Please turn to page ..." |
| `[213]` | **"“Let's move on to the next option.”"** | `[191]` **Lucian Galade**: "“If we privatize these companies..."<br>`[220]` **Lucian Galade**: "“I am against full privatization..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true` | *Brak zmian stanu* | `[207]` **Symon Holl**: "“Very well. Please turn to page ..." |
| `[240]` | **"“What would the effects be if we fully privatize Nedam Mining Group?”"** | `[236]` **Mikail Aven**: "“I can vouch for that. I have pe..."<br>`[274]` **Lucian Galade**: "“We should go for a minority sha..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false` | *Brak zmian stanu* | `[261]` **Mikail Aven**: "“It would be a very profitable s..." |
| `[241]` | **"“What are your thoughts on selling a minority share?”"** | `[236]` **Mikail Aven**: "“I can vouch for that. I have pe..."<br>`[274]` **Lucian Galade**: "“We should go for a minority sha..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false` | *Brak zmian stanu* | `[268]` **Lucian Galade**: "“Coupled with a minority share o..." |
| `[249]` | **"“What about selling a majority share?”"** | `[236]` **Mikail Aven**: "“I can vouch for that. I have pe..."<br>`[274]` **Lucian Galade**: "“We should go for a minority sha..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false` | *Brak zmian stanu* | `[271]` **Symon Holl**: "“My preference is selling a majo..." |
| `[250]` | **"“I am ready to make a decision.”"** | `[236]` **Mikail Aven**: "“I can vouch for that. I have pe..."<br>`[274]` **Lucian Galade**: "“We should go for a minority sha..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true` | *Brak zmian stanu* | `[246]` **Symon Holl**: "“Sounds good.”" |
| `[257]` | **"“I have already decided what we need to do.”"** | `[236]` **Mikail Aven**: "“I can vouch for that. I have pe..."<br>`[274]` **Lucian Galade**: "“We should go for a minority sha..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true) == false` | *Brak zmian stanu* | `[246]` **Symon Holl**: "“Sounds good.”" |

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
  - -> `[5]` (*Narrator: "Lucian and I arrived at the Ministry of Economy."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_EnT_Intro_NationalizationPrivatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_EnT_Intro_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Ms. Agnoc. Don't forget whom you are speaking with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: "“Let's not get ahead of ourselves, shall we?”"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian and I arrived at the Ministry of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Assistants took our coats and showed us into the meeting ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Exactly. I will not be swayed.”"]** — Mówca: **Player**
> "“Exactly. I will not be swayed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“Let's move on to how we can go about implementing a nati..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Symon Holl: "“We are here today to discuss our economic move towards n..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: "“We are of course here today to discuss our economic shif..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Assistants took our coats and showed us into the meeting room where Symon, Edith, Gus and Mikail were waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "As soon as I entered, their chatter stopped and they stoo..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "As soon as I entered, their chatter stopped and they stood up. After a few pleasantries, everyone but Symon took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He opened his briefcase, produced a folder and proceeded ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He opened his briefcase, produced a folder and proceeded to go over some of the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“Greetings, everyone. Welcome to the Ministry of Economy.”"*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“Greetings, everyone. Welcome to the Ministry of Economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Symon Holl: "“Without further ado...”"*)

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“Without further ado...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[15]`
Mówca: **Symon Holl**
> "“We are here today to discuss our economic move towards nationalization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Both Mikail and Edith had their arms crossed and frowns o..."*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“We are of course here today to discuss our economic shift towards privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Mikail and Edith exchanged smiles."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Mikail and Edith exchanged smiles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Symon Holl: "“Mr. President.”"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Both Mikail and Edith had their arms crossed and frowns on their faces. They were listening intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“Mr. President.”"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Before you arrived, certain individuals in this room were voicing their opinion against a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“But as I understand it, your decision has already been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Which 'certain individuals' were those?”"*)
  - -> `[6]` (*Player: "“Exactly. I will not be swayed.”"*)
  - -> `[23]` (*Player: "“Yes. And you will respect my decision whether you like i..."*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Before you arrived, certain individuals in this room wer..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Which 'certain individuals' were those?”"]** — Mówca: **Player**
> "“Which 'certain individuals' were those?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Mikail Aven: "“Me and Edith's, Mr. President.”"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Yes. And you will respect my decision whether you like it or not.”"]** — Mówca: **Player**
> "“Yes. And you will respect my decision whether you like it or not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Edith Agnoc: "“But--”"*)

### Węzeł `[24]`
Mówca: **Mikail Aven**
> "“Me and Edith's, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Edith Agnoc: "“I am very much against a nationalization plan.”"*)

### Węzeł `[25]`
Mówca: **Edith Agnoc**
> "“I am very much against a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“And why is that?”"*)
  - -> `[26]` (*Player: "“Too bad. Your opinion doesn't matter.”"*)
  - -> `[30]` (*Player: "“This is for the good of our country.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Too bad. Your opinion doesn't matter.”"]** — Mówca: **Player**
> "“Too bad. Your opinion doesn't matter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Edith Agnoc: "“But--”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“And why is that?”"]** — Mówca: **Player**
> "“And why is that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Edith Agnoc: "“It's simple, really.”"*)

### Węzeł `[28]`
Mówca: **Edith Agnoc**
> "“But--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "One look from Symon stopped her. Both she and Mikail were..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "One look from Symon stopped her. Both she and Mikail were restless in their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“Let's move on to how we can go about implementing a nati..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“This is for the good of our country.”"]** — Mówca: **Player**
> "“This is for the good of our country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Edith Agnoc: "“I don't think so.”"*)

### Węzeł `[31]`
Mówca: **Edith Agnoc**
> "“It's simple, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Edith Agnoc: "“Nationalization could provide an improvement in terms of..."*)

### Węzeł `[32]`
Mówca: **Edith Agnoc**
> "“Nationalization could provide an improvement in terms of our economic development in the next year or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Edith Agnoc: "“But in the long term, you are losing people's trust. Wit..."*)

### Węzeł `[33]`
Mówca: **Edith Agnoc**
> "“But in the long term, you are losing people's trust. Without trust, there can be little trade. Especially if the government excessively nationalizes entire industries. Besides, it will cost us a proportional amount of government budget to nationalize.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“Are you saying that the state of Sordland is untrustwort..."*)
  - -> `[34]` (*Player: "“And you personally won't be able to profit. Isn't that r..."*)
  - -> `[37]` (*Player: "“I've heard enough. You will accept my decision regardless.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“And you personally won't be able to profit. Isn't that right, Ms. Agnoc?”"]** — Mówca: **Player**
> "“And you personally won't be able to profit. Isn't that right, Ms. Agnoc?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Edith Agnoc: "“No. That is not my point.”"*)

### Węzeł `[35]`
Mówca: **Edith Agnoc**
> "“No. That is not my point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Ms. Agnoc. Don't forget whom you are speaking with.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Are you saying that the state of Sordland is untrustworthy?”"]** — Mówca: **Player**
> "“Are you saying that the state of Sordland is untrustworthy?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Edith Agnoc: "“No. Of course it is trustworthy. That is not my point.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“I've heard enough. You will accept my decision regardless.”"]** — Mówca: **Player**
> "“I've heard enough. You will accept my decision regardless.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Edith Agnoc: "“But, I-”"*)

### Węzeł `[38]`
Mówca: **Edith Agnoc**
> "“No. Of course it is trustworthy. That is not my point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Ms. Agnoc. Don't forget whom you are speaking with.”"*)

### Węzeł `[39]`
Mówca: **Edith Agnoc**
> "“But, I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Ms. Agnoc. Don't forget whom you are speaking with.”"*)

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Let's not get ahead of ourselves, shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Mr. Holl. Please continue.”"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Mr. Holl. Please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“Thank you, Mr. Galade.”"*)

### Węzeł `[42]`
Mówca: **Edith Agnoc**
> "“I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Edith Agnoc: "“Nationalization could provide an improvement in terms of..."*)

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Let's move on to how we can go about implementing a nationalization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“Mr. President.”"*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Thank you, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“Let's move on to how we can go about implementing a nati..."*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "He handed me and everyone else in the room two neat stack..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "He handed me and everyone else in the room two neat stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Symon Holl: "“Please turn to page 14.”"*)

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“Please turn to page 14.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Italic: "Turn to page 14."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Turn to page 14."]** — Mówca: **Player_Italic**
> "I turned to page 14. The title was: Heart of Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“As you can see on the document, the first corporation up..."*)

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“As you can see on the document, the first corporation up for discussion is Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“Led by fledgling CEO Marcel Koronti, HOS has recently ob..."*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Led by fledgling CEO Marcel Koronti, HOS has recently observed a boost in their revenue. They control many media organisations across Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: "“It is possible to see their imprint everywhere from news..."*)

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“It is possible to see their imprint everywhere from newspaper stands to convenience stores. In fact, they own more than half of the media products in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“We all know how much of an effect media has on politics.”"*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“We all know how much of an effect media has on politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“That is the reason I think if we are to nationalize any ..."*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“I must add that I myself am against fully nationalizing any of these companies in principle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“However, we could partially move the ownership of HOS to..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `HOS Nationalization Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full == false"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Minority == false"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Majority == false"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameI..."*)

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“That is the reason I think if we are to nationalize any corporation, HOS should be our target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“I must add that I myself am against fully nationalizing ..."*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“However, we could partially move the ownership of HOS to the state, gaining access to their income to help end the recession and provide for our citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: "“I am inclined to agree with you from a political perspec..."*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> "“I am inclined to agree with you from a political perspective. However...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: "“If we are going to nationalize HOS, I think we should go..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“If we are going to nationalize HOS, I think we should go all the way and fully move its ownership to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "HOS Nationalization Hub"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full == false"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_HOS_Full == false)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“What would the effects be if we fully nationalize Heart ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_HOS_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Minority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Minority == false"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_HOS_Minority == false)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Minority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“What if we just assume minority ownership of HOS?”"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_HOS_Minority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Majority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Majority == false"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_HOS_Majority == false)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Majority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“What about a majority share?”"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_HOS_Majority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameI..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGam..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Let's move on to our next option.”"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_HOS_Full == true || BaseGameIsolated.Turn07_EnT_HOS_Majority == true || BaseGameIsolated.Turn07_EnT_HOS_Minority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“I already know what to do. Let's move on to our next opt..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What would the effects be if we fully nationalize Heart of Sordland?”"]** — Mówca: **Player**
> "“What would the effects be if we fully nationalize Heart of Sordland?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade), `[83]` (Player), `[85]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Edith Agnoc: "“They'd be disastrous, is what they would be.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“What if we just assume minority ownership of HOS?”"]** — Mówca: **Player**
> "“What if we just assume minority ownership of HOS?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade), `[83]` (Player), `[85]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“At first glance, a minority share might make sense. Howe..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“What about a majority share?”"]** — Mówca: **Player**
> "“What about a majority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade), `[83]` (Player), `[85]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Symon Holl: "“I believe this is the way to go.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I already know what to do. Let's move on to our next option.”"]** — Mówca: **Player**
> "“I already know what to do. Let's move on to our next option.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade), `[83]` (Player), `[85]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Symon Holl: "“Very well. Please turn to page 37.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Let's move on to our next option.”"]** — Mówca: **Player**
> "“Let's move on to our next option.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] == true`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade), `[83]` (Player), `[85]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Symon Holl: "“Very well. Please turn to page 37.”"*)

### Węzeł `[76]`
Mówca: **Symon Holl**
> "“Very well. Please turn to page 37.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Italic: "Turn to page 37."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "Turn to page 37."]** — Mówca: **Player_Italic**
> "I turned to page 37. The title was: Bergia Steel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Symon Holl: "“Bergia Steel.”"*)

### Węzeł `[78]`
Mówca: **Edith Agnoc**
> "“They'd be disastrous, is what they would be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Edith Agnoc: "“Thousands of assets belonging to Marcel Koronti would no..."*)

### Węzeł `[79]`
Mówca: **Edith Agnoc**
> "“Thousands of assets belonging to Marcel Koronti would now belong to the state. This would scare off many investors and most likely stop new money from coming in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Mikail Aven: "“I am against fully nationalizing any company.""*)

### Węzeł `[80]`
Mówca: **Mikail Aven**
> "“I am against fully nationalizing any company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Mikail Aven: "“But if you insist on nationalizing something regardless,..."*)

### Węzeł `[81]`
Mówca: **Mikail Aven**
> "“But if you insist on nationalizing something regardless, I would pick HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“Why is that?”"*)
  - -> `[83]` (*Player: "“I will think about it.”"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Mikail Aven: "“Marcel Koronti is growing too powerful too fast.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full = true"*)

### Węzeł `[84]`
Mówca: **Mikail Aven**
> "“Marcel Koronti is growing too powerful too fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mikail Aven: "“The next thing you know, he could even have control over..."*)

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“The next thing you know, he could even have control over the state newspapers!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Full = true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [HOS Nationalization Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "HOS Nationalization Hub"*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“At first glance, a minority share might make sense. However, I don't think it's a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“It would only serve to make Koronti angry at the state w..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“It would only serve to make Koronti angry at the state while retaining enough power to damage us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Symon Holl: "“In the case of HOS, I do agree.”"*)

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“In the case of HOS, I do agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Minority = true"*)

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“I believe this is the way to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Symon Holl: "“We would have board control over HOS and supplementary f..."*)

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“We would have board control over HOS and supplementary funds for government projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Symon Holl: "“It's a win-win situation.”"*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“Theoretically. But we would still be making an enemy out of Marcel Koronti. He wouldn't be as powerful, of course, but I believe it's safer to move him off the chess board entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_HOS_Majority = true"*)

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“It's a win-win situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: "“Theoretically. But we would still be making an enemy out..."*)

### Węzeł `[94]`
Mówca: **Symon Holl**
> "“Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Symon Holl: "“It is the largest fully private corporation among the Bi..."*)

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“It is the largest fully private corporation among the Big Four and a dominant force in steel manufacturing for many years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Symon Holl: "“It is led by current CEO and Lotherberg spokesman Walter..."*)

### Węzeł `[96]`
Mówca: **Symon Holl**
> "“It is led by current CEO and Lotherberg spokesman Walter Tusk. I believe all of us in the room are familiar with him in one way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Symon Holl: "“What can I say? They have been widely successful since t..."*)

### Węzeł `[97]`
Mówca: **Symon Holl**
> "“What can I say? They have been widely successful since their founding. They have achieved renown not only in Sordland, but worldwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Symon Holl: "“I believe we shouldn't attempt to break something that i..."*)

### Węzeł `[98]`
Mówca: **Symon Holl**
> "“I believe we shouldn't attempt to break something that is already working. I am against the nationalization of Bergia Steel in any capacity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Mikail Aven: "“Not to mention any amount of nationalization would be di..."*)

### Węzeł `[99]`
Mówca: **Mikail Aven**
> "“Not to mention any amount of nationalization would be disastrous for both Bergia Steel and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Mikail Aven: "“Much of our steel trade is reliant on their manufacturin..."*)

### Węzeł `[100]`
Mówca: **Mikail Aven**
> "“Much of our steel trade is reliant on their manufacturing capabilities. Any sudden change there would be like throwing a screwdriver in a working engine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Edith Agnoc: "“No matter what, we should refrain from nationalizing the..."*)

### Węzeł `[101]`
Mówca: **Edith Agnoc**
> "“No matter what, we should refrain from nationalizing them. It could result in an economic crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I don't have so strong of an opinion. But I will say tha..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“I don't have so strong of an opinion. But I will say that nationalizing both Bergia Steel and HOS would be quite unwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "Bergia Steel Nationalization Hub"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“What would the effects be if we fully nationalize Bergia..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WYBÓR GRACZA: "“What would the effects be if we fully nationalize Bergia Steel?”"]** — Mówca: **Player**
> "“What would the effects be if we fully nationalize Bergia Steel?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade), `[128]` (Mikail Aven), `[132]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Mikail Aven: "“Where do I start?""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“What are your thoughts on a minority share?”"]** — Mówca: **Player**
> "“What are your thoughts on a minority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade), `[128]` (Mikail Aven), `[132]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: "“As I mentioned, I am against making changes to Bergia St..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“What are your thoughts on a minority share?”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I have already decided on what we need to do.”"]** — Mówca: **Player**
> "“I have already decided on what we need to do.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade), `[128]` (Mikail Aven), `[132]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Symon Holl: "“Sounds good.”"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“What would be the outcome of taking a majority share?”"]** — Mówca: **Player**
> "“What would be the outcome of taking a majority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade), `[128]` (Mikail Aven), `[132]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Symon Holl: "“This is of course a better option than full nationalizat..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade), `[128]` (Mikail Aven), `[132]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Symon Holl: "“Sounds good.”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“What would be the outcome of taking a majority share?”"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || B..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true ||..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "“I am ready to make a decision.”"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == true || BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: "“I have already decided on what we need to do.”"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Bergia Steel Nationalization Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == false"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority == false"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority == false"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full == true || B..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Full = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Jump to: [HOS Nationalization Hub]"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Minority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Jump to: [HOS Nationalization Hub]"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_HOS_Majority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_HOS_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Jump to: [HOS Nationalization Hub]"*)

### Węzeł `[124]`
Mówca: **Mikail Aven**
> "“Where do I start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Mikail Aven: "“They are quite literally the backbone of Sordland's priv..."*)

### Węzeł `[125]`
Mówca: **Mikail Aven**
> "“They are quite literally the backbone of Sordland's private economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Mikail Aven: "“If you do this, you will anger many powerful people. Tru..."*)

### Węzeł `[126]`
Mówca: **Mikail Aven**
> "“If you do this, you will anger many powerful people. Trust me, you don't want that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“You are right. I don't want more enemies.”"*)
  - -> `[129]` (*Player: "“I understand the predicament, but it is necessary.”"*)
  - -> `[127]` (*Player: "“Is that a threat, Mikail?”"*)
  - -> `[130]` (*Player: "“Let them come. I am not afraid.”"*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“Is that a threat, Mikail?”"]** — Mówca: **Player**
> "“Is that a threat, Mikail?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Mikail Aven: "“No, Mr. President. It's a fact.”"*)

### Węzeł `[128]`
Mówca: **Mikail Aven**
> "“No, Mr. President. It's a fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“I understand the predicament, but it is necessary.”"]** — Mówca: **Player**
> "“I understand the predicament, but it is necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Edith Agnoc: "“I don't see how this is *necessary*.”"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Let them come. I am not afraid.”"]** — Mówca: **Player**
> "“Let them come. I am not afraid.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Edith Agnoc: "“I think you should be.”"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“You are right. I don't want more enemies.”"]** — Mówca: **Player**
> "“You are right. I don't want more enemies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Edith Agnoc: "“I knew you would see reason.”"*)

### Węzeł `[132]`
Mówca: **Edith Agnoc**
> "“I think you should be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true"*)

### Węzeł `[133]`
Mówca: **Edith Agnoc**
> "“I don't see how this is *necessary*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Edith Agnoc: "“You can simply not do it and you will achieve peace.”"*)

### Węzeł `[134]`
Mówca: **Edith Agnoc**
> "“You can simply not do it and you will achieve peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true"*)

### Węzeł `[135]`
Mówca: **Edith Agnoc**
> "“I knew you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Full = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Jump to: [Bergia Steel Nationalization Hub]"*)

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“As I mentioned, I am against making changes to Bergia Steel's ownership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Symon Holl: "“We should leave the company as it is.”"*)

### Węzeł `[138]`
Mówca: **Symon Holl**
> "“We should leave the company as it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“I tend to agree. But only because HOS is the weaker of t..."*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“I tend to agree. But only because HOS is the weaker of the two and it is less risky to deal with them as opposed to a giant like Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority = true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Jump to: [Bergia Steel Nationalization Hub]"*)

### Węzeł `[141]`
Mówca: **Symon Holl**
> "“This is of course a better option than full nationalization. But that doesn't mean you would not face adversity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Symon Holl: "“A majority share means Bergia Steel would experience a m..."*)

### Węzeł `[142]`
Mówca: **Symon Holl**
> "“A majority share means Bergia Steel would experience a massive drop in status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Symon Holl: "“This would surely anger a man like Walter Tusk.”"*)

### Węzeł `[143]`
Mówca: **Symon Holl**
> "“This would surely anger a man like Walter Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Symon Holl: "“And if I may make an understatement, he is not a forgivi..."*)

### Węzeł `[144]`
Mówca: **Symon Holl**
> "“And if I may make an understatement, he is not a forgiving man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: "“He is scary for sure. I would hate to make an enemy out ..."*)
  - -> `[145]` (*Player: "“No need to be afraid. If push comes to shove, I will han..."*)
  - -> `[148]` (*Player: "“If that day comes, Walter Tusk will learn Anton Rayne is..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“No need to be afraid. If push comes to shove, I will handle it.”"]** — Mówca: **Player**
> "“No need to be afraid. If push comes to shove, I will handle it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Symon Holl: "“It's the administration I'm worried about. Not only you.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“He is scary for sure. I would hate to make an enemy out of him.”"]** — Mówca: **Player**
> "“He is scary for sure. I would hate to make an enemy out of him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“He seems to hold everyone in his pocket.”"*)

### Węzeł `[147]`
Mówca: **Symon Holl**
> "“It's the administration I'm worried about. Not only you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority = true"*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "“If that day comes, Walter Tusk will learn Anton Rayne is *also* not a forgiving man.”"]** — Mówca: **Player**
> "“If that day comes, Walter Tusk will learn Anton Rayne is *also* not a forgiving man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“As you say.”"*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“As you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority = true"*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“He seems to hold everyone in his pocket.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Lucian looked pointedly at Mikail."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Lucian looked pointedly at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority = true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_BergiaSteel_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Jump to: [Bergia Steel Nationalization Hub]"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Bergia Steel Nationalization Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "Bergia Steel Nationalization Hub"*)

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Symon Holl: "“Let's go over the document once again then.”"*)

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“Let's go over the document once again then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "I read all of Symon's documents once more, then flipped t..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "I read all of Symon's documents once more, then flipped to the last page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "It was time to make some decisions."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "It was time to make some decisions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Nationalization");  // Sho..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Symon Holl: "“Especially since we were initially going down the path o..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“But as I understand it, your decision has already been m..."*)

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“Especially since we were initially going down the path of a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“But as I understand it, your decision has already been m..."*)

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Symon Holl: "“Before you arrived, Mikail and Edith were expressing the..."*)

### Węzeł `[163]`
Mówca: **Symon Holl**
> "“Before you arrived, Mikail and Edith were expressing their delight at your decision to go down this path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Mikail Aven: "“Wonderful news, I'd say.”"*)

### Węzeł `[164]`
Mówca: **Mikail Aven**
> "“Wonderful news, I'd say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[165]`
Mówca: **Edith Agnoc**
> "“This was certainly the right decision. It will boost our economy by providing the government much-needed funds right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Edith Agnoc: "“We can then use these funds to increase development for ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Mikail Aven: "“I'm glad we're staying firmly on the path to a market ec..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Mikail Aven: "“I know a market economy wasn't part of your original pla..."*)

### Węzeł `[169]`
Mówca: **Mikail Aven**
> "“I'm glad we're staying firmly on the path to a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Edith Agnoc: "“This was certainly the right decision. It will boost our..."*)

### Węzeł `[170]`
Mówca: **Mikail Aven**
> "“I know a market economy wasn't part of your original plans, but I'm happy you've seen the light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Edith Agnoc: "“This was certainly the right decision. It will boost our..."*)

### Węzeł `[171]`
Mówca: **Edith Agnoc**
> "“We can then use these funds to increase development for the future. It's a win-win situation for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: "“I am glad we are on the same page.”"*)
  - -> `[172]` (*Player: "“You are saying this only because you will have a stake i..."*)
  - -> `[175]` (*Player: "“Enough with the flattery.”"*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“You are saying this only because you will have a stake in it.”"]** — Mówca: **Player**
> "“You are saying this only because you will have a stake in it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Edith Agnoc: "“Of course not! I am saying this because all along I knew..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "“I am glad we are on the same page.”"]** — Mówca: **Player**
> "“I am glad we are on the same page.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Edith Agnoc: "“Certainly!”"*)

### Węzeł `[174]`
Mówca: **Edith Agnoc**
> "“Certainly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon handed me and everyone else in the room two neat st..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Enough with the flattery.”"]** — Mówca: **Player**
> "“Enough with the flattery.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Edith Agnoc: "“I have to give credit when it's due.”"*)

### Węzeł `[176]`
Mówca: **Edith Agnoc**
> "“Of course not! I am saying this because all along I knew you would make the right choice for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Edith Agnoc: "“It's because I trusted you.”"*)

### Węzeł `[177]`
Mówca: **Edith Agnoc**
> "“It's because I trusted you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon handed me and everyone else in the room two neat st..."*)

### Węzeł `[178]`
Mówca: **Edith Agnoc**
> "“I have to give credit when it's due.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon handed me and everyone else in the room two neat st..."*)

### Węzeł `[179]`
Mówca: **Symon Holl**
> "“Let's move on to how we can go about implementing a privatization plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Symon Holl: "“Please turn to page 6.”"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Symon handed me and everyone else in the room two neat stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Symon Holl: "“Let's move on to how we can go about implementing a priv..."*)

### Węzeł `[181]`
Mówca: **Symon Holl**
> "“Please turn to page 6.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Italic: "Turn to page 6."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "Turn to page 6."]** — Mówca: **Player_Italic**
> "I turned to page 6. The title was: Sordish State Corporation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Symon Holl: "“As you can see on the document, the first company up for..."*)

### Węzeł `[183]`
Mówca: **Symon Holl**
> "“As you can see on the document, the first company up for discussion is the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Symon Holl: "“The Sordish State Corporation, or SSC for short, has bee..."*)

### Węzeł `[184]`
Mówca: **Symon Holl**
> "“The Sordish State Corporation, or SSC for short, has been around for over half a century. Most recently they have been handling a wide range of state construction projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Symon Holl: "“In their portfolio they have government buildings, vario..."*)

### Węzeł `[185]`
Mówca: **Symon Holl**
> "“In their portfolio they have government buildings, various infrastructure projects, state libraries, embassies. Basically anything government-related.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Symon Holl: "“Privatizing a company like this would certainly increase..."*)

### Węzeł `[186]`
Mówca: **Symon Holl**
> "“Privatizing a company like this would certainly increase the government's budget. That, of course, would result in lots of opportunities for us to provide for our citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: "“The funds could also be used to boost our popularity. Es..."*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“The funds could also be used to boost our popularity. Especially with the elections approaching.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: "“Not to mention the various other areas in which we can a..."*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> "“Not to mention the various other areas in which we can and should spend money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: "“However, there is one catch.”"*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“However, there is one catch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: "“The conservative majority of the USP would not like this..."*)

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“The conservative majority of the USP would not like this decision. At all. For them, these state companies are part and parcel of Sordish identity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: "“If we privatize these companies entirely and sell too ma..."*)

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“If we privatize these companies entirely and sell too many shares in them, it will have consequences for us in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "SSC Privatization Hub"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Full == false"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_SSC_Full == false)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“What would the effects be if we fully privatize the Sord..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_SSC_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SSC Privatization Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "SSC Privatization Hub"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“What would the effects be if we fully privatize the Sordish State Corporation?”"]** — Mówca: **Player**
> "“What would the effects be if we fully privatize the Sordish State Corporation?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade), `[220]` (Lucian Galade), `[228]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Symon Holl: "“We would gain tremendous amounts of money for the govern..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“What if we sell a minority share of SSC?”"]** — Mówca: **Player**
> "“What if we sell a minority share of SSC?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade), `[220]` (Lucian Galade), `[228]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Edith Agnoc: "“It would be better than nothing, but why stop there?""*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameI..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGam..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: "“Let's move on to the next option.”"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameIsolated.Turn07_EnT_SSC_Majority == true || BaseGameIsolated.Turn07_EnT_SSC_Minority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: "“I already know what to do. Let's move on to the next opt..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Minority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Minority == false"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_SSC_Minority == false)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Minority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“What if we sell a minority share of SSC?”"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_SSC_Minority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Full = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [SSC Privatization Hub]"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Majority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [SSC Privatization Hub]"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "Turn to page 26."]** — Mówca: **Player_Italic**
> "I turned to page 26. The title was: Nedam Mining Group."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Symon Holl: "“Nedam Mining Group.”"*)

### Węzeł `[207]`
Mówca: **Symon Holl**
> "“Very well. Please turn to page 26.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Italic: "Turn to page 26."*)

### Węzeł `[208]`
**[WYBÓR GRACZA: "“What about selling a majority share?”"]** — Mówca: **Player**
> "“What about selling a majority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade), `[220]` (Lucian Galade), `[228]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Mikail Aven: "“This is certainly a very good option.”"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Majority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Majority == false"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_SSC_Majority == false)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Majority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: "“What about selling a majority share?”"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_SSC_Majority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA: "“I already know what to do. Let's move on to the next option.”"]** — Mówca: **Player**
> "“I already know what to do. Let's move on to the next option.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade), `[220]` (Lucian Galade), `[228]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Symon Holl: "“Very well. Please turn to page 26.”"*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Let's move on to the next option.”"]** — Mówca: **Player**
> "“Let's move on to the next option.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] == true`
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade), `[220]` (Lucian Galade), `[228]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Symon Holl: "“Very well. Please turn to page 26.”"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_SSC_Minority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_SSC_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [SSC Privatization Hub]"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SSC Privatization Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Full == false"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Minority == false"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Majority == false"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Full == true || BaseGameI..."*)

### Węzeł `[216]`
Mówca: **Symon Holl**
> "“We would gain tremendous amounts of money for the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Symon Holl: "“We can invest that money in future government projects w..."*)

### Węzeł `[217]`
Mówca: **Symon Holl**
> "“We can invest that money in future government projects which would popularise our administration, increasing the chances for our re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: "“That popularity might not make up for losing the lion's ..."*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“That popularity might not make up for losing the lion's share of the conservative vote.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“Conservatives comprise the majority of the Assembly. If ..."*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“Conservatives comprise the majority of the Assembly. If we hurt their national pride, they'll turn on us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: "“I am against full privatization. We shouldn't make enemi..."*)

### Węzeł `[220]`
Mówca: **Lucian Galade**
> "“I am against full privatization. We shouldn't make enemies at this stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Full = true"*)

### Węzeł `[221]`
Mówca: **Edith Agnoc**
> "“It would be better than nothing, but why stop there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Edith Agnoc: "“A minority stake won't help our government as much.”"*)

### Węzeł `[222]`
Mówca: **Edith Agnoc**
> "“A minority stake won't help our government as much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Edith Agnoc: "“We need to be decisive.”"*)

### Węzeł `[223]`
Mówca: **Edith Agnoc**
> "“We need to be decisive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucian Galade: "“On the other hand, a minority share would create less fr..."*)

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“On the other hand, a minority share would create less friction. This would be my preference.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Minority = true"*)

### Węzeł `[225]`
Mówca: **Mikail Aven**
> "“This is certainly a very good option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Mikail Aven: "“The state would keep some of SSC's operations under cont..."*)

### Węzeł `[226]`
Mówca: **Mikail Aven**
> "“The state would keep some of SSC's operations under control, and the government would have lots of gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Symon Holl: "“I am leaning towards this option myself.”"*)

### Węzeł `[227]`
Mówca: **Symon Holl**
> "“I am leaning towards this option myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“Retaining control while increasing our budget -- I don't..."*)

### Węzeł `[228]`
Mówca: **Symon Holl**
> "“Retaining control while increasing our budget -- I don't see a downside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_SSC_Majority = true"*)

### Węzeł `[229]`
Mówca: **Symon Holl**
> "“Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Symon Holl: "“It is one of the largest mining corporations in Eastern ..."*)

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“It is one of the largest mining corporations in Eastern Merkopa, let alone Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Symon Holl: "“They call themselves the leaders of the world in coal. T..."*)

### Węzeł `[231]`
Mówca: **Symon Holl**
> "“They call themselves the leaders of the world in coal. They certainly have enough evidence to back that up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Symon Holl: "“Perhaps they are not as large as SSC, but we still have ..."*)

### Węzeł `[232]`
Mówca: **Symon Holl**
> "“Perhaps they are not as large as SSC, but we still have a lot to gain if Nedam Mining Group is privatised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Symon Holl: "“I fully support privatization of this company to any ext..."*)

### Węzeł `[233]`
Mówca: **Symon Holl**
> "“I fully support privatization of this company to any extent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Symon Holl: "“Certainly a good option to gain enough capital to end th..."*)

### Węzeł `[234]`
Mówca: **Symon Holl**
> "“Certainly a good option to gain enough capital to end the recession once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Edith Agnoc: "“I have contacts in Nedam. It is one of the most valuable..."*)

### Węzeł `[235]`
Mówca: **Edith Agnoc**
> "“I have contacts in Nedam. It is one of the most valuable corporations of the last decade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Mikail Aven: "“I can vouch for that. I have personal experience with th..."*)

### Węzeł `[236]`
Mówca: **Mikail Aven**
> "“I can vouch for that. I have personal experience with the company myself. It would be a great addition to any portfolio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "Nedam Privatization Hub"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Full == false"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_Nedam_Full == false)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: "“What would the effects be if we fully privatize Nedam Mi..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_Nedam_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
**[WYBÓR GRACZA: "“What would the effects be if we fully privatize Nedam Mining Group?”"]** — Mówca: **Player**
> "“What would the effects be if we fully privatize Nedam Mining Group?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Mikail Aven), `[274]` (Lucian Galade), `[267]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Mikail Aven: "“It would be a very profitable sell.”"*)

### Węzeł `[241]`
**[WYBÓR GRACZA: "“What are your thoughts on selling a minority share?”"]** — Mówca: **Player**
> "“What are your thoughts on selling a minority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Mikail Aven), `[274]` (Lucian Galade), `[267]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucian Galade: "“Coupled with a minority share of SSC, that is the way to..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Minority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Minority == false"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_Nedam_Minority == false)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Minority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "“What are your thoughts on selling a minority share?”"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_Nedam_Minority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Nedam Privatization Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "Nedam Privatization Hub"*)

### Węzeł `[246]`
Mówca: **Symon Holl**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Symon Holl: "“Let's go over the document once again then.”"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Majority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Jump to: [Nedam Privatization Hub]"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Full = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Jump to: [Nedam Privatization Hub]"*)

### Węzeł `[249]`
**[WYBÓR GRACZA: "“What about selling a majority share?”"]** — Mówca: **Player**
> "“What about selling a majority share?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Mikail Aven), `[274]` (Lucian Galade), `[267]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Symon Holl: "“My preference is selling a majority share of both SSC an..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Mikail Aven), `[274]` (Lucian Galade), `[267]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Symon Holl: "“Sounds good.”"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Majority == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Majority == false"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_Nedam_Majority == false)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Majority == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: "“What about selling a majority share?”"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_Nedam_Majority == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGam..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseG..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: "“I am ready to make a decision.”"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGameIsolated.Turn07_EnT_Nedam_Majority == true || BaseGameIsolated.Turn07_EnT_Nedam_Minority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: "“I have already decided what we need to do.”"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "“I have already decided what we need to do.”"]** — Mówca: **Player**
> "“I have already decided what we need to do.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_EnT_Nedam_Full"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Majority"] == true  or  Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Mikail Aven), `[274]` (Lucian Galade), `[267]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Symon Holl: "“Sounds good.”"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Nedam Privatization Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Full == false"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Minority == false"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Majority == false"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Full == true || BaseGam..."*)

### Węzeł `[259]`
Mówca: **Symon Holl**
> "“Let's go over the document once again then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "I read all of Symon's documents once more, then flipped t..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_EnT_Nedam_Minority = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_EnT_Nedam_Minority"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Jump to: [Nedam Privatization Hub]"*)

### Węzeł `[261]`
Mówca: **Mikail Aven**
> "“It would be a very profitable sell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Edith Agnoc: "“I know many people who would kill to have a portion of t..."*)

### Węzeł `[262]`
Mówca: **Edith Agnoc**
> "“I know many people who would kill to have a portion of that company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Symon Holl: "“I do think this is a good option.”"*)

### Węzeł `[263]`
Mówca: **Symon Holl**
> "“I do think this is a good option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Symon Holl: "“We could simply fully privatize Nedam along with SSC to ..."*)

### Węzeł `[264]`
Mówca: **Symon Holl**
> "“We could simply fully privatize Nedam along with SSC to bring in a large influx of money to the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucian Galade: "“Mr. President.”"*)

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“I hate to repeat myself, but fully privatizing one state..."*)

### Węzeł `[266]`
Mówca: **Lucian Galade**
> "“I hate to repeat myself, but fully privatizing one state-owned company -- let alone two -- will anger our conservative voter base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lucian Galade: "“All the budget in the world won't matter if you aren't r..."*)

### Węzeł `[267]`
Mówca: **Lucian Galade**
> "“All the budget in the world won't matter if you aren't re-elected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Full = true"*)

### Węzeł `[268]`
Mówca: **Lucian Galade**
> "“Coupled with a minority share of SSC, that is the way to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Symon Holl: "“It would, however, be a lost opportunity. I think we sho..."*)

### Węzeł `[269]`
Mówca: **Symon Holl**
> "“It would, however, be a lost opportunity. I think we should sell a majority share instead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Edith Agnoc: "“Definitely not a bad idea at all.”"*)

### Węzeł `[270]`
Mówca: **Edith Agnoc**
> "“Definitely not a bad idea at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Minority = true"*)

### Węzeł `[271]`
Mówca: **Symon Holl**
> "“My preference is selling a majority share of both SSC and Nedam.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Symon Holl: "“It would give us the most value. I think we should go wi..."*)

### Węzeł `[272]`
Mówca: **Symon Holl**
> "“It would give us the most value. I think we should go with this choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: "“This might still generate a backlash from the Assembly a..."*)

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“This might still generate a backlash from the Assembly and the general public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lucian Galade: "“We should go for a minority share instead.”"*)

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“We should go for a minority share instead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_EnT_Nedam_Majority = true"*)

### Węzeł `[275]`
Mówca: **Narrator**
> "I read all of Symon's documents once more, then flipped to the last page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "It was time to make some decisions."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "It was time to make some decisions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Privatization");  // Shows..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Privatization");

// Shows Paged Decisions Panel with the name in database`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Privatization");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_EnT_Intro_NationalizationPrivatizati..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Nationalization");

// Shows Paged Decisions Panel with the name in database`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_EnT_Intro_NationalizationPrivatizati..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
