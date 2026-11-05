# Sordland/Turn07/Privatization and Nationalization Feedback

- **ID konwersacji:** `100`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/100_Privatization_and_Nationalization_Feedback.md`
- **Liczba węzłów dialogowych:** 299
- **Liczba wyborów gracza:** 32

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
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.EconomicDirection_StatusQuo`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Capitalist`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Malenyevist`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.Situation_Economy_PrivateSector_Expanded`
- `BaseGame.Situation_Economy_StateSector_Expanded`
- `BaseGame.Sollist`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.Turn07_Detained_MikailAven`
- `BaseGameSupport.FactionReport_Turn07_ATO_PrivatizationPraise`
- `BaseGameSupport.FactionReport_Turn07_CSP_NationalizationPraise`
- `GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[99] Sordland/Turn07/EnT_NationalizationAndPrivatization** (../Turn_07/099_EnT_NationalizationAndPrivatization.md), Węzeł `[279]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[27]` | **"“What did you just call me? Say that again. I dare you.""** | `[26]` **Mikail Aven**: "“You idiot!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Mikail Aven**: "“I said, you IDIOT!"" |
| `[33]` | **"“A few years in Antel Rock Prison will teach him how to talk to a President. Take ..."** | `[32]` **Narrator**: "They looked at me expectantly, w..." | `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | *Brak zmian stanu* | `[63]` **Narrator**: "The guards flanked Mikail and gr..." |
| `[37]` | **"“It's all fine. Just a disagreement. Right, Mr. Aven?”"** | `[32]` **Narrator**: "They looked at me expectantly, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "He measured the guards with his ..." |
| `[38]` | **"“Get him out of my face!”"** | `[32]` **Narrator**: "They looked at me expectantly, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Guards flanked Mikail and grabbe..." |
| `[39]` | **"“Please calm down, Mr. Aven. Otherwise I will have you removed.”"** | `[26]` **Mikail Aven**: "“You idiot!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Edith Agnoc**: "“Mikail!”" |
| `[40]` | **"“Go back to your master like the dog you are and tell Mr. Tusk you're through.”"** | `[26]` **Mikail Aven**: "“You idiot!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Mikail Aven**: "“What did you just say to m--”" |
| `[46]` | **"“We all make mistakes. I forgive you.”"** | `[45]` **Mikail Aven**: "“I am sorry, Mr. President. I lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Mikail Aven**: "“Thank you, Mr. President.”" |
| `[47]` | **"“If anything like this happens again...”"** | `[45]` **Mikail Aven**: "“I am sorry, Mr. President. I lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Mikail Aven**: "“Yes, Mr. President. I understand.”" |
| `[50]` | **"Stay silent."** | `[45]` **Mikail Aven**: "“I am sorry, Mr. President. I lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Mikail Aven**: "“Come, Edith. We must report the..." |
| `[64]` | **"“Very well. Let him go.”"** | `[62]` **Edith Agnoc**: "“Would you please forgive him?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Edith Agnoc**: "“Thank you very much, Mr. Presid..." |
| `[65]` | **"“No. Take him away.”"** | `[62]` **Edith Agnoc**: "“Would you please forgive him?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Detained_MikailAven"] = true;` | `[66]` **Mikail Aven**: "“No!”" |
| `[109]` | **"“It's okay. You don't have to. You just have to accept it.”"** | `[108]` **Mikail Aven**: "“I'm sorry. No matter what I do,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Mikail Aven**: "“Hmm. I see.”"<br>`[162]` **Mikail Aven**: "“We are done here.”" |
| `[110]` | **"“Simple, really. It was the better choice.”"** | `[108]` **Mikail Aven**: "“I'm sorry. No matter what I do,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Mikail Aven**: "“Hmm. I see.”"<br>`[162]` **Mikail Aven**: "“We are done here.”" |
| `[111]` | **"“I don't have to explain my reasons to you, Mr. Aven.”"** | `[108]` **Mikail Aven**: "“I'm sorry. No matter what I do,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Mikail Aven**: "“Hmm. I see.”"<br>`[162]` **Mikail Aven**: "“We are done here.”" |
| `[139]` | **"“I don't have to explain my reasons to you, Mr. Aven.”"** | `[136]` **Mikail Aven**: "“But I suppose it could've been ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Mikail Aven**: "“Of course, Mr. President.”" |
| `[140]` | **"“Exactly. Don't forget who made that decision.”"** | `[136]` **Mikail Aven**: "“But I suppose it could've been ..."<br>`[138]` **Mikail Aven**: "“I suppose it could've been much..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Mikail Aven**: "“We will not, Mr. President.”" |
| `[141]` | **"“I had to make a decision.”"** | `[136]` **Mikail Aven**: "“But I suppose it could've been ..."<br>`[138]` **Mikail Aven**: "“I suppose it could've been much..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Mikail Aven**: "“I understand, Mr. President.”" |
| `[175]` | **"“Then get to it, Lucian.”"** | `[179]` **Lucian Galade**: "“I also want to remind you that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "He frowned, bowed slightly and s..." |
| `[176]` | **"“We can offset our losses in votes with our gains from this change.”"** | `[179]` **Lucian Galade**: "“I also want to remind you that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucian Galade**: "“You are being too optimistic. I..." |
| `[177]` | **"“I don't care about the conservatives.”"** | `[179]` **Lucian Galade**: "“I also want to remind you that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Lucian Galade**: "“We must. They have considerable..." |
| `[185]` | **"“I have complete trust in your capabilities, Lucian.”"** | `[184]` **Lucian Galade**: "“I will see what we can do, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Lucian Galade**: "“I will do my best.”" |
| `[186]` | **"“You will succeed regardless.”"** | `[184]` **Lucian Galade**: "“I will see what we can do, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Lucian Galade**: "“I will do my best.”" |
| `[187]` | **"“We have come this far. We can handle it.”"** | `[184]` **Lucian Galade**: "“I will see what we can do, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Lucian Galade**: "“I will do my best.”" |
| `[219]` | **"“I hope you are right.”"** | `[218]` **Lucian Galade**: "“But the gains we receive will o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Lucian Galade**: "“I will do the best I can.”" |
| `[220]` | **"“I don't care about the conservatives in the Assembly.”"** | `[218]` **Lucian Galade**: "“But the gains we receive will o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Lucian Galade**: "“As they have quite a majority i..." |
| `[221]` | **"“Make sure those gains happen.""** | `[218]` **Lucian Galade**: "“But the gains we receive will o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Lucian Galade**: "“As you wish. I will not leave a..." |
| `[234]` | **"“I don't need an ally like you.”"** | `[233]` **Edith Agnoc**: "“I want to assure you, you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Edith Agnoc**: "“As you wish. Suit yourself.”" |
| `[235]` | **"“Sounds wonderful. I am looking forward to working with you.”"** | `[233]` **Edith Agnoc**: "“I want to assure you, you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Edith Agnoc**: "“That's great to hear!”" |
| `[236]` | **"“It had better be that way, Edith. For your own good.”"** | `[233]` **Edith Agnoc**: "“I want to assure you, you will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Edith Agnoc**: "“I understand.”" |
| `[243]` | **"“Good work everyone.”"** | `[229]` **Symon Holl**: "“Thank you all for coming.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Symon Holl**: "“Indeed.”" |
| `[244]` | **"“Thank you, Symon.”"** | `[229]` **Symon Holl**: "“Thank you all for coming.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Symon Holl**: "“My pleasure.”" |
| `[245]` | **"“I want to see the results as soon as possible.”"** | `[229]` **Symon Holl**: "“Thank you all for coming.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Symon Holl**: "“Of course. As fast as we can.”" |

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
  - -> `[3]` (*Narrator: "I signed the document altering the ownership of the key c..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 5; BaseGame.Economy -= 2;"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "I signed the document altering the ownership of the key corporations with a flourish. Symon leaned back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“So.”"*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“So.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Symon Holl: "“This is the path we are taking.”"*)

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“This is the path we are taking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 && Ba..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization == 3 && BaseGa..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Mikail Aven: "“This is absolutely ridiculous!”"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 0"*)

### Węzeł `[12]`
Mówca: **Mikail Aven**
> "“This is absolutely ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Mikail Aven: "“Symon, please tell me you are not fine with this.”"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 0"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization == 0)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization >= 2"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization >= 2"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization >= 2)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Mikail Aven: "“This is absolutely ridiculous!”"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSo..."*)

### Węzeł `[19]`
Mówca: **Mikail Aven**
> "“Symon, please tell me you are not fine with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Mikail Aven: "“Please tell me...that Mr. President...did not just sign ..."*)

### Węzeł `[20]`
Mówca: **Mikail Aven**
> "“Please tell me...that Mr. President...did not just sign this order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“He just did, Mr. Aven.”"*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“He just did, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“And there is nothing you can do about it.”"*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“And there is nothing you can do about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Mikail turned to me. His eyes were wide open with rage. H..."*)

### Węzeł `[23]`
Mówca: **Mikail Aven**
> "“What...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Mikail Aven: "“What have you done?”"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Mikail turned to me. His eyes were wide open with rage. He was clenching his fists so hard that his hands turned red from exertion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Mikail Aven: "“What...”"*)

### Węzeł `[25]`
Mówca: **Mikail Aven**
> "“What have you done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Mikail Aven: "“You...”"*)

### Węzeł `[26]`
Mówca: **Mikail Aven**
> "“You idiot!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Please calm down, Mr. Aven. Otherwise I will have you re..."*)
  - -> `[27]` (*Player: "“What did you just call me? Say that again. I dare you.""*)
  - -> `[40]` (*Player: "“Go back to your master like the dog you are and tell Mr...."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“What did you just call me? Say that again. I dare you.""]** — Mówca: **Player**
> "“What did you just call me? Say that again. I dare you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Mikail Aven: "“I said, you IDIOT!""*)

### Węzeł `[28]`
Mówca: **Mikail Aven**
> "“You...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Edith Agnoc: "“Mikail, don't. Please.”"*)

### Węzeł `[29]`
Mówca: **Edith Agnoc**
> "“Mikail, don't. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Mikail Aven: "“You idiot!”"*)

### Węzeł `[30]`
Mówca: **Mikail Aven**
> "“I said, you IDIOT!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Two security officers immediately entered the room with h..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Two security officers immediately entered the room with hands on their guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "They looked at me expectantly, waiting for my orders."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "They looked at me expectantly, waiting for my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“Get him out of my face!”"*)
  - -> `[37]` (*Player: "“It's all fine. Just a disagreement. Right, Mr. Aven?”"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“A few years in Antel Rock Prison will teach him how to talk to a President. Take him away.”"]** — Mówca: **Player**
> "“A few years in Antel Rock Prison will teach him how to talk to a President. Take him away.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "The guards flanked Mikail and grabbed his arms from both ..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“A few years in Antel Rock Prison will teach him how to t..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA: "“It's all fine. Just a disagreement. Right, Mr. Aven?”"]** — Mówca: **Player**
> "“It's all fine. Just a disagreement. Right, Mr. Aven?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "He measured the guards with his eyes."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Get him out of my face!”"]** — Mówca: **Player**
> "“Get him out of my face!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Guards flanked Mikail and grabbed his arms from both sides."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Please calm down, Mr. Aven. Otherwise I will have you removed.”"]** — Mówca: **Player**
> "“Please calm down, Mr. Aven. Otherwise I will have you removed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Edith Agnoc: "“Mikail!”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Go back to your master like the dog you are and tell Mr. Tusk you're through.”"]** — Mówca: **Player**
> "“Go back to your master like the dog you are and tell Mr. Tusk you're through.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Mikail Aven: "“What did you just say to m--”"*)

### Węzeł `[41]`
Mówca: **Edith Agnoc**
> "“Mikail!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Edith Agnoc: "“I am very sorry for my colleague's behavior, Mr. Preside..."*)

### Węzeł `[42]`
Mówca: **Edith Agnoc**
> "“I am very sorry for my colleague's behavior, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Edith Agnoc: "“I hope we can look past this.”"*)

### Węzeł `[43]`
Mówca: **Edith Agnoc**
> "“I hope we can look past this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Edith Agnoc: "“I'm sure Mikail is sorry too. Right?”"*)

### Węzeł `[44]`
Mówca: **Edith Agnoc**
> "“I'm sure Mikail is sorry too. Right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Mikail Aven: "“I am sorry, Mr. President. I lost my cool.”"*)

### Węzeł `[45]`
Mówca: **Mikail Aven**
> "“I am sorry, Mr. President. I lost my cool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“We all make mistakes. I forgive you.”"*)
  - -> `[47]` (*Player: "“If anything like this happens again...”"*)
  - -> `[50]` (*Player_Italic: "Stay silent."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“We all make mistakes. I forgive you.”"]** — Mówca: **Player**
> "“We all make mistakes. I forgive you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Mikail Aven: "“Thank you, Mr. President.”"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“If anything like this happens again...”"]** — Mówca: **Player**
> "“If anything like this happens again...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Mikail Aven: "“Yes, Mr. President. I understand.”"*)

### Węzeł `[48]`
Mówca: **Mikail Aven**
> "“Yes, Mr. President. I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[49]`
Mówca: **Mikail Aven**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[51]`
Mówca: **Mikail Aven**
> "“Come, Edith. We must report the outcome of this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Edith Agnoc: "“I'm not going anywhere.”"*)

### Węzeł `[52]`
Mówca: **Edith Agnoc**
> "“I'm not going anywhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Mikail turned to Edith with a sour face. His eyes were sh..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Mikail turned to Edith with a sour face. His eyes were shooting daggers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Mikail Aven: "“Suit yourself.”"*)

### Węzeł `[54]`
Mówca: **Mikail Aven**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Mikail Aven: "“And Mr. President...”"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "He packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Lucian got up from his seat and intercepted him on his wa..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Lucian got up from his seat and intercepted him on his way out. He put his hand on Mikail's shoulder and spoke with a calm and soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: "“I'll be watching you.”"*)

### Węzeł `[57]`
Mówca: **Mikail Aven**
> "“And Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Mikail Aven: "“Mr. Tusk will hear about this. You can rest assured.”"*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“I'll be watching you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Mikail didn't respond. He simply left."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Mikail didn't respond. He simply left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Edith leaned forward to get closer to my ear."*)

### Węzeł `[60]`
Mówca: **Edith Agnoc**
> "“Mr. President. Please, he didn't mean it like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Edith Agnoc: "“We all make mistakes and I know what a kind and benevole..."*)

### Węzeł `[61]`
Mówca: **Edith Agnoc**
> "“We all make mistakes and I know what a kind and benevolent President you are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Edith Agnoc: "“Would you please forgive him?”"*)

### Węzeł `[62]`
Mówca: **Edith Agnoc**
> "“Would you please forgive him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“No. Take him away.”"*)
  - -> `[64]` (*Player: "“Very well. Let him go.”"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "The guards flanked Mikail and grabbed his arms from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Edith Agnoc: "“Mr. President. Please, he didn't mean it like that.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. Let him go.”"]** — Mówca: **Player**
> "“Very well. Let him go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Edith Agnoc: "“Thank you very much, Mr. President!”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“No. Take him away.”"]** — Mówca: **Player**
> "“No. Take him away.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MikailAven = true"*)

### Węzeł `[66]`
Mówca: **Mikail Aven**
> "“No!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Mikail Aven: "“You can't do this!”"*)

### Węzeł `[67]`
Mówca: **Mikail Aven**
> "“You can't do this!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He started struggling but the guards held him tightly."*)

### Węzeł `[68]`
Mówca: **Mikail Aven**
> "“Get off of me, you lowlifes! Don't you know who I am?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Mikail Aven: "“I am Mikail Aven!”"*)

### Węzeł `[69]`
Mówca: **Mikail Aven**
> "“I am Mikail Aven!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "The door closed and his muffled protests gradually faded ..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He started struggling but the guards held him tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Mikail Aven: "“Get off of me, you lowlifes! Don't you know who I am?”"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "The door closed and his muffled protests gradually faded away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Edith leaned forward to get closer to my ear."*)

### Węzeł `[72]`
Mówca: **Edith Agnoc**
> "“Thank you very much, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Edith made her way to Mikail and gestured for him to leav..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Edith made her way to Mikail and gestured for him to leave the room with her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Edith Agnoc: "“If you will excuse us.”"*)

### Węzeł `[74]`
Mówca: **Edith Agnoc**
> "“If you will excuse us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Mikail silently followed Edith."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Mikail silently followed Edith."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The door closed behind them."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[77]`
Mówca: **Mikail Aven**
> "“Exactly. Just a small misunderstanding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Mikail Aven: "“I am very sorry about that, Mr. President.”"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "He measured the guards with his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Mikail Aven: "“Exactly. Just a small misunderstanding.”"*)

### Węzeł `[79]`
Mówca: **Mikail Aven**
> "“I am very sorry about that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Guards flanked Mikail and grabbed his arms from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Mikail Aven: "“Get off of me, you lowlifes!”"*)

### Węzeł `[81]`
Mówca: **Mikail Aven**
> "“Get off of me, you lowlifes!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Mikail Aven: "“I know my way out.”"*)

### Węzeł `[82]`
Mówca: **Mikail Aven**
> "“I know my way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[83]`
Mówca: **Mikail Aven**
> "“What did you just say to m--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Edith Agnoc: "“Mikail!”"*)

### Węzeł `[84]`
Mówca: **Mikail Aven**
> "“Mr. Tusk will hear about this. You can rest assured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "He packed up his bag and started making his way to the en..."*)

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“Although I am very much against the nationalization of any company, I am glad you at least chose to leave Bergia Steel alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Mikail Aven: "“If I were Mr. Tusk, I would be very happy with this deci..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“Now we must look into implementing these changes.”"*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Now we must look into implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Mikail Aven: "“Before you start that discussion, I'm afraid Edith and I..."*)

### Węzeł `[88]`
Mówca: **Edith Agnoc**
> "“This has been a fruitful meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“I agree.”"*)

### Węzeł `[89]`
Mówca: **Mikail Aven**
> "“Before you start that discussion, I'm afraid Edith and I will have to leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Mikail Aven: "“We need to report the outcome to our companies to make s..."*)

### Węzeł `[90]`
Mówca: **Mikail Aven**
> "“We need to report the outcome to our companies to make sure we can mitigate the impact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Edith Agnoc: "“Thank you everyone. Have a nice day.”"*)

### Węzeł `[91]`
Mówca: **Edith Agnoc**
> "“Thank you everyone. Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "They gathered their belongings and left the room hurriedly."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "They gathered their belongings and left the room hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[93]`
Mówca: **Mikail Aven**
> "“If I were Mr. Tusk, I would be very happy with this decision. Right, Edith?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "She chuckled."*)

### Węzeł `[94]`
Mówca: **Edith Agnoc**
> "“For sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Edith Agnoc: "“This has been a fruitful meeting.”"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "She chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Edith Agnoc: "“For sure.”"*)

### Węzeł `[96]`
Mówca: **Mikail Aven**
> "“You...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Edith Agnoc: "“Mikail, don't. Please.”"*)

### Węzeł `[97]`
Mówca: **Edith Agnoc**
> "“Mikail, don't. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Mikail Aven: "“You are making a great mistake, Mr. President.”"*)

### Węzeł `[98]`
Mówca: **Mikail Aven**
> "“What...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Mikail Aven: "“What have you done?”"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Mikail turned to me. His eyes were wide open with rage. He was clenching his fists so hard that his hands turned red from exertion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Mikail Aven: "“What...”"*)

### Węzeł `[100]`
Mówca: **Mikail Aven**
> "“This is absolutely ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Mikail Aven: "“Symon, please tell me you are not fine with this.”"*)

### Węzeł `[101]`
Mówca: **Mikail Aven**
> "“Symon, please tell me you are not fine with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Mikail Aven: "“Please tell me...that Mr. President... did not just sign..."*)

### Węzeł `[102]`
Mówca: **Mikail Aven**
> "“What have you done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Mikail Aven: "“You...”"*)

### Węzeł `[103]`
Mówca: **Symon Holl**
> "“He just did, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: "“And there is nothing you can do about it.”"*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> "“And there is nothing you can do about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Mikail turned to me. His eyes were wide open with rage. H..."*)

### Węzeł `[105]`
Mówca: **Mikail Aven**
> "“Please tell me...that Mr. President... did not just sign this order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Symon Holl: "“He just did, Mr. Aven.”"*)

### Węzeł `[106]`
Mówca: **Mikail Aven**
> "“You are making a great mistake, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)

### Węzeł `[107]`
Mówca: **Mikail Aven**
> "“You have made your preference of Heart of Sordland, a *media* conglomerate, over Bergia Steel very clear. BS is a company that has spent decades defining steel manufacturing in this country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Mikail Aven: "“I'm sorry. No matter what I do, I can't understand your ..."*)

### Węzeł `[108]`
Mówca: **Mikail Aven**
> "“I'm sorry. No matter what I do, I can't understand your reasoning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Simple, really. It was the better choice.”"*)
  - -> `[109]` (*Player: "“It's okay. You don't have to. You just have to accept it.”"*)
  - -> `[111]` (*Player: "“I don't have to explain my reasons to you, Mr. Aven.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“It's okay. You don't have to. You just have to accept it.”"]** — Mówca: **Player**
> "“It's okay. You don't have to. You just have to accept it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Simple, really. It was the better choice.”"]** — Mówca: **Player**
> "“Simple, really. It was the better choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I don't have to explain my reasons to you, Mr. Aven.”"]** — Mówca: **Player**
> "“I don't have to explain my reasons to you, Mr. Aven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)

### Węzeł `[112]`
Mówca: **Mikail Aven**
> "“Hmm. I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Mikail Aven: "“It was Koronti, wasn't it?”"*)

### Węzeł `[113]`
Mówca: **Mikail Aven**
> "“It was Koronti, wasn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Mikail Aven: "“So he bought you.”"*)

### Węzeł `[114]`
Mówca: **Mikail Aven**
> "“So he bought you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: "“Mr. Aven. I want you to think very carefully about what ..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Mr. Aven. I want you to think very carefully about what you are going to say next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Mikail Aven: "“I'm not going to say anything. We are done here.”"*)

### Węzeł `[116]`
Mówca: **Mikail Aven**
> "“I'm not going to say anything. We are done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[117]`
Mówca: **Mikail Aven**
> "“Come, Edith. We must report the outcome of this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Edith Agnoc: "“I'm not going anywhere.”"*)

### Węzeł `[118]`
Mówca: **Edith Agnoc**
> "“I'm not going anywhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Mikail turned to Edith with a sour face. His eyes were sh..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Mikail didn't respond. He simply left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Edith leaned forward to get closer to my ear."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Mikail turned to Edith with a sour face. His eyes were shooting daggers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Mikail Aven: "“Suit yourself.”"*)

### Węzeł `[121]`
Mówca: **Mikail Aven**
> "“And Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Mikail Aven: "“Mr. Tusk will hear about this. You can rest assured.”"*)

### Węzeł `[122]`
Mówca: **Mikail Aven**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Mikail Aven: "“And Mr. President.”"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Lucian got up from his seat and intercepted him on his way out. He put his hand on Mikail's shoulder and spoke with a calm and soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: "“I'll be watching you.”"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "He packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Lucian got up from his seat and intercepted him on his wa..."*)

### Węzeł `[125]`
Mówca: **Mikail Aven**
> "“Mr. Tusk will hear about this. You can rest assured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "He packed up his bag and started making his way to the en..."*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“I'll be watching you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Mikail didn't respond. He simply left."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOf..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Mikail Aven: "“You have made your preference of Heart of Sordland, a *m..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Mikail Aven: "“I'm sorry. No matter what I do, I can't understand your ..."*)

### Węzeł `[130]`
Mówca: **Mikail Aven**
> "“Although I'm not exactly happy, at least Bergia Steel was hit less hard than Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Mikail Aven: "“After all, one of them is a simple *media* conglomerate ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSo..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOf..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] < Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Mikail Aven: "“Although I'm not exactly happy, at least Bergia Steel wa..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] < Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfS..."*)

### Węzeł `[134]`
Mówca: **Mikail Aven**
> "“This is certainly not preferable at all. Why is Bergia Steel more nationalized than Heart of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Mikail Aven: "“One of them is a simple *media* conglomerate, while Berg..."*)

### Węzeł `[135]`
Mówca: **Mikail Aven**
> "“One of them is a simple *media* conglomerate, while Bergia Steel has been the backbone of our economy for years!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Mikail Aven: "“But I suppose it could've been much worse.”"*)

### Węzeł `[136]`
Mówca: **Mikail Aven**
> "“But I suppose it could've been much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“I had to make a decision.”"*)
  - -> `[140]` (*Player: "“Exactly. Don't forget who made that decision.”"*)
  - -> `[139]` (*Player: "“I don't have to explain my reasons to you, Mr. Aven.”"*)

### Węzeł `[137]`
Mówca: **Mikail Aven**
> "“After all, one of them is a simple *media* conglomerate while Bergia Steel has been the backbone of our economy for many years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Mikail Aven: "“I suppose it could've been much worse.”"*)

### Węzeł `[138]`
Mówca: **Mikail Aven**
> "“I suppose it could've been much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“I had to make a decision.”"*)
  - -> `[140]` (*Player: "“Exactly. Don't forget who made that decision.”"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I don't have to explain my reasons to you, Mr. Aven.”"]** — Mówca: **Player**
> "“I don't have to explain my reasons to you, Mr. Aven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Mikail Aven: "“Of course, Mr. President.”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Exactly. Don't forget who made that decision.”"]** — Mówca: **Player**
> "“Exactly. Don't forget who made that decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Mikail Aven), `[138]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Mikail Aven: "“We will not, Mr. President.”"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I had to make a decision.”"]** — Mówca: **Player**
> "“I had to make a decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Mikail Aven), `[138]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Mikail Aven: "“I understand, Mr. President.”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfS..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization == BaseGame.HeartO..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Mikail Aven: "“This is certainly not preferable at all. Why is Bergia S..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Mikail Aven: "“This is certainly not preferable at all. Why is Bergia S..."*)

### Węzeł `[145]`
Mówca: **Mikail Aven**
> "“This is certainly not preferable at all. Why is Bergia Steel getting the same treatment as Heart of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Mikail Aven: "“One of them is a simple *media* conglomerate, while Berg..."*)

### Węzeł `[146]`
Mówca: **Mikail Aven**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“Well then.”"*)

### Węzeł `[147]`
Mówca: **Mikail Aven**
> "“We will not, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“Well then.”"*)

### Węzeł `[148]`
Mówca: **Mikail Aven**
> "“I understand, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“Well then.”"*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“We must look into implementing these changes.”"*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“We must look into implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Mikail Aven: "“Before you start that discussion, I'm afraid Edith and I..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "They gathered their belongings and left the room hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[152]`
Mówca: **Edith Agnoc**
> "“Thank you everyone. Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "They gathered their belongings and left the room hurriedly."*)

### Węzeł `[153]`
Mówca: **Mikail Aven**
> "“Before you start that discussion, I'm afraid Edith and I will have to leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Mikail Aven: "“We need to report the outcome to our companies to make s..."*)

### Węzeł `[154]`
Mówca: **Mikail Aven**
> "“We need to report the outcome to our companies to make sure we mitigate the impact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Edith Agnoc: "“Thank you everyone. Have a nice day.”"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization == 3)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mikail Aven: "“Although I am very much against the nationalization of a..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Mikail Aven: "“I am glad you chose to avoid disrupting Bergia Steel. It..."*)

### Węzeł `[158]`
Mówca: **Mikail Aven**
> "“I am glad you chose to avoid disrupting Bergia Steel. It would've been disastrous otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Mikail Aven: "“If I were Mr. Tusk, I would be very happy with this deci..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSo..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOf..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Mikail Aven: "“Hmm. I see.”"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mikail Aven: "“We are done here.”"*)

### Węzeł `[162]`
Mówca: **Mikail Aven**
> "“We are done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Mikail Aven: "“Come, Edith. We must report the outcome of this meeting.”"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 && Ba..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 3 && ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Mikail Aven: "“I want to thank you, Mr. President.”"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 || Ba..."*)

### Węzeł `[166]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Mikail Aven: "“This decision will revitalize our economy. Eliminating r..."*)

### Węzeł `[167]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy. Eliminating recession completely is not so far off now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Edith Agnoc: "“This will definitely show our trade partners that Sordla..."*)

### Węzeł `[168]`
Mówca: **Edith Agnoc**
> "“This will definitely show our trade partners that Sordland is moving in the right direction. Which in turn will increase trust... which means more income.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Edith Agnoc: "“Excellent decision.”"*)

### Węzeł `[169]`
Mówca: **Edith Agnoc**
> "“Excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Symon Holl: "“I have to agree.”"*)

### Węzeł `[170]`
Mówca: **Symon Holl**
> "“I have to agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucian Galade: "“I'm not so sure about that.”"*)

### Węzeł `[171]`
Mówca: **Lucian Galade**
> "“I'm not so sure about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: "“Yes, fully privatizing state corporations might give us ..."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Yes, fully privatizing state corporations might give us the budget boost required to help us end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“But we can only pave the way forward for Sordland if we ..."*)

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“But we can only pave the way forward for Sordland if we are leading the country from the top.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: "“We might have been able to survive if you privatized onl..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“Mr. President. Your decision will cost us the support of *every* *single* conservative in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“Of course, that includes the leader of the conservative ..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Then get to it, Lucian.”"]** — Mówca: **Player**
> "“Then get to it, Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "He frowned, bowed slightly and spoke with a soft voice."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We can offset our losses in votes with our gains from this change.”"]** — Mówca: **Player**
> "“We can offset our losses in votes with our gains from this change.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: "“You are being too optimistic. I'm afraid of the reality.”"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“I don't care about the conservatives.”"]** — Mówca: **Player**
> "“I don't care about the conservatives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: "“We must. They have considerable power.”"*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Of course, that includes the leader of the conservative wing of our own party, Gloria Tory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: "“I also want to remind you that the majority of the Assem..."*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“I also want to remind you that the majority of the Assembly is conservative. We have our work cut out for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: "“I don't care about the conservatives.”"*)
  - -> `[176]` (*Player: "“We can offset our losses in votes with our gains from th..."*)
  - -> `[175]` (*Player: "“Then get to it, Lucian.”"*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“You are being too optimistic. I'm afraid of the reality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“I will see what we can do, but this might be the hardest..."*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“We must. They have considerable power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“I will see what we can do, but this might be the hardest..."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Right away, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“I will see what we can do, but this might be the hardest..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "He frowned, bowed slightly and spoke with a soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: "“Right away, sir.”"*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“I will see what we can do, but this might be the hardest task you have ever given me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“I have complete trust in your capabilities, Lucian.”"*)
  - -> `[187]` (*Player: "“We have come this far. We can handle it.”"*)
  - -> `[186]` (*Player: "“You will succeed regardless.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I have complete trust in your capabilities, Lucian.”"]** — Mówca: **Player**
> "“I have complete trust in your capabilities, Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: "“I will do my best.”"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“You will succeed regardless.”"]** — Mówca: **Player**
> "“You will succeed regardless.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: "“I will do my best.”"*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“We have come this far. We can handle it.”"]** — Mówca: **Player**
> "“We have come this far. We can handle it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: "“I will do my best.”"*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: "“If you will excuse me, I have to get to work immediately..."*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“If you will excuse me, I have to get to work immediately. There is much to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Lucian packed up his bag and started making his way to th..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucian packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“We might have been able to survive if you privatized only one of the companies, but fully privatizing both of them...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“Mr. President. Your decision will cost us the support of..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 || Ba..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 3 || ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  or  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Mikail Aven: "“I want to thank you, Mr. President.”"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  or  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 1 && Ba..."*)

### Węzeł `[195]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Mikail Aven: "“This decision will revitalize our economy. Eliminating r..."*)

### Węzeł `[196]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy. Eliminating recession completely is not so far off now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Edith Agnoc: "“This will definitely show our trade partners that Sordla..."*)

### Węzeł `[197]`
Mówca: **Edith Agnoc**
> "“This will definitely show our trade partners that Sordland is moving in the right direction. Which in turn will increase trust... which means more income.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Edith Agnoc: "“Excellent decision.”"*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Yes, fully privatizing a state corporation might give us the budgetary boost required to help us end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Lucian Galade: "“But we can only pave the way forward for Sordland if we ..."*)

### Węzeł `[199]`
Mówca: **Edith Agnoc**
> "“Excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Symon Holl: "“I have to agree.”"*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> "“I'm not so sure about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: "“Yes, fully privatizing a state corporation might give us..."*)

### Węzeł `[201]`
Mówca: **Symon Holl**
> "“I have to agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: "“I'm not so sure about that.”"*)

### Węzeł `[202]`
Mówca: **Lucian Galade**
> "“But we can only pave the way forward for Sordland if we are leading the country from the top.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: "“Mr. President. Your decision will make us lose the suppo..."*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“Mr. President. Your decision will make us lose the support of many conservatives in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“Of course, that includes the leader of the conservative ..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 1 && Ba..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 1 && ..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“Thank you for heeding my suggestions, sir.”"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Mikail Aven: "“I want to thank you, Mr. President.”"*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“Thank you for heeding my suggestions, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Mikail Aven: "“I want to thank you, Mr. President.”"*)

### Węzeł `[208]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Mikail Aven: "“This decision will revitalize our economy.”"*)

### Węzeł `[209]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Mikail Aven: "“Although I wish we could have proceeded with privatizati..."*)

### Węzeł `[210]`
Mówca: **Mikail Aven**
> "“Although I wish we could have proceeded with privatization in a greater capacity, it is a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Edith Agnoc: "“Certainly a step in the right direction.”"*)

### Węzeł `[211]`
Mówca: **Edith Agnoc**
> "“Certainly a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“Partial privatization will still deal damage to our cons..."*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“Partial privatization will still deal damage to our conservative voter base. But it is nothing we can't handle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 1 && Ba..."*)

### Węzeł `[213]`
Mówca: **Lucian Galade**
> "“I believe this was the best outcome we could have hoped for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucian Galade: "“I suspect that, regardless, we will lose the support of ..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 1 && Ba..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 1 && ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucian Galade: "“I believe this was the best outcome we could have hoped ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucian Galade: "“I suspect that, regardless, we will lose the support of ..."*)

### Węzeł `[217]`
Mówca: **Lucian Galade**
> "“I suspect that, regardless, we will lose the support of some conservatives in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: "“But the gains we receive will offset the losses.”"*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“But the gains we receive will offset the losses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: "“I don't care about the conservatives in the Assembly.”"*)
  - -> `[219]` (*Player: "“I hope you are right.”"*)
  - -> `[221]` (*Player: "“Make sure those gains happen.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: "“I hope you are right.”"]** — Mówca: **Player**
> "“I hope you are right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucian Galade: "“I will do the best I can.”"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I don't care about the conservatives in the Assembly.”"]** — Mówca: **Player**
> "“I don't care about the conservatives in the Assembly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucian Galade: "“As they have quite a majority in the Assembly, you should.”"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Make sure those gains happen.""]** — Mówca: **Player**
> "“Make sure those gains happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucian Galade: "“As you wish. I will not leave any stones unturned.”"*)

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“As you wish. I will not leave any stones unturned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: "“If you will excuse me, I have to get to work immediately..."*)

### Węzeł `[223]`
Mówca: **Lucian Galade**
> "“I will do the best I can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: "“If you will excuse me, I have to get to work immediately..."*)

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“As they have quite a majority in the Assembly, you should.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucian Galade: "“Hopefully the number of conservatives who will be agains..."*)

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“Hopefully the number of conservatives who will be against us because of this decision will be low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: "“If you will excuse me, I have to get to work immediately..."*)

### Węzeł `[226]`
Mówca: **Lucian Galade**
> "“If you will excuse me, I have to get to work immediately. There is much to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Lucian packed up his bag and started making his way to th..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Lucian packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[228]`
Mówca: **Symon Holl**
> "“That will be it for today then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Symon Holl: "“I know everyone has very busy schedules.”"*)

### Węzeł `[229]`
Mówca: **Symon Holl**
> "“Thank you all for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: "“Good work everyone.”"*)
  - -> `[244]` (*Player: "“Thank you, Symon.”"*)
  - -> `[245]` (*Player: "“I want to see the results as soon as possible.”"*)

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“I know everyone has very busy schedules.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Symon Holl: "“Thank you all for coming.”"*)

### Węzeł `[231]`
Mówca: **Edith Agnoc**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Edith Agnoc: "“I've had my fair share of experience. I understand when ..."*)

### Węzeł `[232]`
Mówca: **Edith Agnoc**
> "“I've had my fair share of experience. I understand when the cards are stacked against me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Edith Agnoc: "“I want to assure you, you will find an ally in me.”"*)

### Węzeł `[233]`
Mówca: **Edith Agnoc**
> "“I want to assure you, you will find an ally in me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player: "“It had better be that way, Edith. For your own good.”"*)
  - -> `[235]` (*Player: "“Sounds wonderful. I am looking forward to working with y..."*)
  - -> `[234]` (*Player: "“I don't need an ally like you.”"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I don't need an ally like you.”"]** — Mówca: **Player**
> "“I don't need an ally like you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Edith Agnoc: "“As you wish. Suit yourself.”"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Sounds wonderful. I am looking forward to working with you.”"]** — Mówca: **Player**
> "“Sounds wonderful. I am looking forward to working with you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Edith Agnoc: "“That's great to hear!”"*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“It had better be that way, Edith. For your own good.”"]** — Mówca: **Player**
> "“It had better be that way, Edith. For your own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Edith Agnoc: "“I understand.”"*)

### Węzeł `[237]`
Mówca: **Edith Agnoc**
> "“I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Edith Agnoc: "“I must leave now as well.”"*)

### Węzeł `[238]`
Mówca: **Edith Agnoc**
> "“That's great to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Edith Agnoc: "“I must leave now as well.”"*)

### Węzeł `[239]`
Mówca: **Edith Agnoc**
> "“As you wish. Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Edith Agnoc: "“I must leave now as well.”"*)

### Węzeł `[240]`
Mówca: **Edith Agnoc**
> "“I must leave now as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Symon Holl: "“That will be it for today then.”"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "Edith leaned forward to get closer to my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Edith Agnoc: "“Mr. President.”"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "I put the documents in my suitcase and left the room with Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_EnT_Feedback_NationalizationPrivatiz..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Good work everyone.”"]** — Mówca: **Player**
> "“Good work, everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Symon Holl: "“Indeed.”"*)

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Thank you, Symon.”"]** — Mówca: **Player**
> "“Thank you, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Symon Holl: "“My pleasure.”"*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "“I want to see the results as soon as possible.”"]** — Mówca: **Player**
> "“I want to see the results as soon as possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Symon Holl: "“Of course. As fast as we can.”"*)

### Węzeł `[246]`
Mówca: **Symon Holl**
> "“My pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I put the documents in my suitcase and left the room with..."*)

### Węzeł `[247]`
Mówca: **Symon Holl**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I put the documents in my suitcase and left the room with..."*)

### Węzeł `[248]`
Mówca: **Symon Holl**
> "“Of course. As fast as we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I put the documents in my suitcase and left the room with..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MikailAven = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Mikail Aven: "“No!”"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization +  BaseGam..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization +  BaseG..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_PrivateSector_Expanded = true;..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization +  BaseGam..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartO..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_StateSector_Expanded = true; B..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_StateSector_Expanded = true; BaseGameSupport.FactionReport_Turn07_CSP_NationalizationPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_StateSector_Expanded"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_CSP_NationalizationPraise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Filler instruction for organization`
- **Efekt skryptowy (`userScript`):** `-- Filler instruction for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_PrivateSector_Expanded = true; BaseGameSupport.FactionReport_Turn07_ATO_PrivatizationPraise = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_PrivateSector_Expanded"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_ATO_PrivatizationPraise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Filler instruction for organization`
- **Efekt skryptowy (`userScript`):** `-- Filler instruction for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == false"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2;
BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartO..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2; BaseGame.Economy += 1;"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 4; BaseGame.Economy += 2;"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 4;
BaseGame.Economy += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 4;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization +  BaseGam..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 3; BaseGame.Economy -= 1;"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 5; BaseGame.Economy -= 2;"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 3;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 3;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 5;
BaseGame.Economy -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 5;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartO..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization  + BaseGame.HeartOfS..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization +  BaseGam..."*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization +  BaseG..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 1;"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);
BaseGame.Malenyevist += (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);
BaseGame.Capitalist -= (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += (BaseGame.BergiaSteel_Nationalization..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Privatization == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= (BaseGame.NedamMiningGroup_Privatizat..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);
BaseGame.Malenyevist -= (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);
BaseGame.Capitalist += (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "// Filler instruction for organization"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == false"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == false)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "// Continue"*)
