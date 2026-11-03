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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 17

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Situation_Economy_PrivateSector_Expanded`
- `BaseGame.Situation_Economy_StateSector_Expanded`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[249]` (Symon Holl): `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- Węzeł `[250]` (Symon Holl): `Variable["BaseGame.Turn07_Detained_MikailAven"] = true;`
- Węzeł `[260]` (Symon Holl): `Variable["BaseGame.Situation_Economy_StateSector_Expanded"] = true; Variable["BaseGameSupport.Fac...`
- Węzeł `[261]` (Symon Holl): `-- Filler instruction for organization;`
- Węzeł `[262]` (Symon Holl): `Variable["BaseGame.Situation_Economy_PrivateSector_Expanded"] = true; Variable["BaseGameSupport.F...`
- Węzeł `[263]` (Symon Holl): `-- Filler instruction for organization;`
- Węzeł `[264]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2; Variable["Base...`
- Węzeł `[268]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 4; Variable["Base...`
- *...oraz 9 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `99` (*Sordland/Turn07/EnT_NationalizationAndPrivatization*), Węzeł `[279]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I signed the document altering the ownership of the key corporations with a flourish. Symon leaned back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“So.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“This is the path we are taking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization == 3 && BaseGame.BergiaSteel_Nationalization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Mikail Aven**
> "“This is absolutely ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization == 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[18]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[19]`
Mówca: **Mikail Aven**
> "“Symon, please tell me you are not fine with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Mikail Aven**
> "“Please tell me...that Mr. President...did not just sign this order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“He just did, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“And there is nothing you can do about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Mikail Aven**
> "“What...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Mikail turned to me. His eyes were wide open with rage. He was clenching his fists so hard that his hands turned red from exertion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[25]`
Mówca: **Mikail Aven**
> "“What have you done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Mikail Aven**
> "“You idiot!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[27]`
  - -> `[40]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“What did you just call me? Say that again. I dare you.""]** — Mówca: **Player**
> "“What did you just call me? Say that again. I dare you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Mikail Aven**
> "“You...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Edith Agnoc**
> "“Mikail, don't. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
Mówca: **Mikail Aven**
> "“I said, you IDIOT!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Two security officers immediately entered the room with hands on their guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "They looked at me expectantly, waiting for my orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[37]`
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“A few years in Antel Rock Prison will teach him how to talk to a President. Take him away.”"]** — Mówca: **Player**
> "“A few years in Antel Rock Prison will teach him how to talk to a President. Take him away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA: "“It's all fine. Just a disagreement. Right, Mr. Aven?”"]** — Mówca: **Player**
> "“It's all fine. Just a disagreement. Right, Mr. Aven?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Get him out of my face!”"]** — Mówca: **Player**
> "“Get him out of my face!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Please calm down, Mr. Aven. Otherwise I will have you removed.”"]** — Mówca: **Player**
> "“Please calm down, Mr. Aven. Otherwise I will have you removed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Go back to your master like the dog you are and tell Mr. Tusk you're through.”"]** — Mówca: **Player**
> "“Go back to your master like the dog you are and tell Mr. Tusk you're through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[41]`
Mówca: **Edith Agnoc**
> "“Mikail!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Edith Agnoc**
> "“I am very sorry for my colleague's behavior, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Edith Agnoc**
> "“I hope we can look past this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Edith Agnoc**
> "“I'm sure Mikail is sorry too. Right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Mikail Aven**
> "“I am sorry, Mr. President. I lost my cool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[50]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“We all make mistakes. I forgive you.”"]** — Mówca: **Player**
> "“We all make mistakes. I forgive you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“If anything like this happens again...”"]** — Mówca: **Player**
> "“If anything like this happens again...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Mikail Aven**
> "“Yes, Mr. President. I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Mikail Aven**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Mikail Aven**
> "“Come, Edith. We must report the outcome of this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Edith Agnoc**
> "“I'm not going anywhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Mikail turned to Edith with a sour face. His eyes were shooting daggers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Mikail Aven**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Lucian got up from his seat and intercepted him on his way out. He put his hand on Mikail's shoulder and spoke with a calm and soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Mikail Aven**
> "“And Mr. President...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“I'll be watching you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Mikail didn't respond. He simply left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[60]`
Mówca: **Edith Agnoc**
> "“Mr. President. Please, he didn't mean it like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Edith Agnoc**
> "“We all make mistakes and I know what a kind and benevolent President you are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Edith Agnoc**
> "“Would you please forgive him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "The guards flanked Mikail and grabbed his arms from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. Let him go.”"]** — Mówca: **Player**
> "“Very well. Let him go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“No. Take him away.”"]** — Mówca: **Player**
> "“No. Take him away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[66]`
Mówca: **Mikail Aven**
> "“No!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Mikail Aven**
> "“You can't do this!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Mikail Aven**
> "“Get off of me, you lowlifes! Don't you know who I am?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Mikail Aven**
> "“I am Mikail Aven!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Narrator**
> "He started struggling but the guards held him tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[71]`
Mówca: **Narrator**
> "The door closed and his muffled protests gradually faded away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[72]`
Mówca: **Edith Agnoc**
> "“Thank you very much, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Edith made her way to Mikail and gestured for him to leave the room with her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Edith Agnoc**
> "“If you will excuse us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Mikail silently followed Edith."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[77]`
Mówca: **Mikail Aven**
> "“Exactly. Just a small misunderstanding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "He measured the guards with his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[79]`
Mówca: **Mikail Aven**
> "“I am very sorry about that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Guards flanked Mikail and grabbed his arms from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Mikail Aven**
> "“Get off of me, you lowlifes!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Mikail Aven**
> "“I know my way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[83]`
Mówca: **Mikail Aven**
> "“What did you just say to m--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[84]`
Mówca: **Mikail Aven**
> "“Mr. Tusk will hear about this. You can rest assured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“Although I am very much against the nationalization of any company, I am glad you at least chose to leave Bergia Steel alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Now we must look into implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Edith Agnoc**
> "“This has been a fruitful meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[89]`
Mówca: **Mikail Aven**
> "“Before you start that discussion, I'm afraid Edith and I will have to leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Mikail Aven**
> "“We need to report the outcome to our companies to make sure we can mitigate the impact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Edith Agnoc**
> "“Thank you everyone. Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "They gathered their belongings and left the room hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[93]`
Mówca: **Mikail Aven**
> "“If I were Mr. Tusk, I would be very happy with this decision. Right, Edith?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Edith Agnoc**
> "“For sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[95]`
Mówca: **Narrator**
> "She chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
Mówca: **Mikail Aven**
> "“You...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Edith Agnoc**
> "“Mikail, don't. Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[98]`
Mówca: **Mikail Aven**
> "“What...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Mikail turned to me. His eyes were wide open with rage. He was clenching his fists so hard that his hands turned red from exertion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Mikail Aven**
> "“This is absolutely ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Mikail Aven**
> "“Symon, please tell me you are not fine with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Mikail Aven**
> "“What have you done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[103]`
Mówca: **Symon Holl**
> "“He just did, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> "“And there is nothing you can do about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[105]`
Mówca: **Mikail Aven**
> "“Please tell me...that Mr. President... did not just sign this order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[106]`
Mówca: **Mikail Aven**
> "“You are making a great mistake, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[107]`
Mówca: **Mikail Aven**
> "“You have made your preference of Heart of Sordland, a *media* conglomerate, over Bergia Steel very clear. BS is a company that has spent decades defining steel manufacturing in this country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Mikail Aven**
> "“I'm sorry. No matter what I do, I can't understand your reasoning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“It's okay. You don't have to. You just have to accept it.”"]** — Mówca: **Player**
> "“It's okay. You don't have to. You just have to accept it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Simple, really. It was the better choice.”"]** — Mówca: **Player**
> "“Simple, really. It was the better choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I don't have to explain my reasons to you, Mr. Aven.”"]** — Mówca: **Player**
> "“I don't have to explain my reasons to you, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[112]`
Mówca: **Mikail Aven**
> "“Hmm. I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Mikail Aven**
> "“It was Koronti, wasn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Mikail Aven**
> "“So he bought you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Mr. Aven. I want you to think very carefully about what you are going to say next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Mikail Aven**
> "“I'm not going to say anything. We are done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Mikail Aven**
> "“Come, Edith. We must report the outcome of this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Edith Agnoc**
> "“I'm not going anywhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Mikail didn't respond. He simply left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Mikail turned to Edith with a sour face. His eyes were shooting daggers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Mikail Aven**
> "“And Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
Mówca: **Mikail Aven**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
Mówca: **Narrator**
> "Lucian got up from his seat and intercepted him on his way out. He put his hand on Mikail's shoulder and spoke with a calm and soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Narrator**
> "He packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[125]`
Mówca: **Mikail Aven**
> "“Mr. Tusk will hear about this. You can rest assured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“I'll be watching you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[130]`
Mówca: **Mikail Aven**
> "“Although I'm not exactly happy, at least Bergia Steel was hit less hard than Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[131]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] < Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization < BaseGame.HeartOfSordland_Nationalization))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] < Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[134]`
Mówca: **Mikail Aven**
> "“This is certainly not preferable at all. Why is Bergia Steel more nationalized than Heart of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Mikail Aven**
> "“One of them is a simple *media* conglomerate, while Bergia Steel has been the backbone of our economy for years!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Mikail Aven**
> "“But I suppose it could've been much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[140]`
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Mikail Aven**
> "“After all, one of them is a simple *media* conglomerate while Bergia Steel has been the backbone of our economy for many years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Mikail Aven**
> "“I suppose it could've been much worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I don't have to explain my reasons to you, Mr. Aven.”"]** — Mówca: **Player**
> "“I don't have to explain my reasons to you, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Exactly. Don't forget who made that decision.”"]** — Mówca: **Player**
> "“Exactly. Don't forget who made that decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I had to make a decision.”"]** — Mówca: **Player**
> "“I had to make a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization == BaseGame.HeartOfSordland_Nationalization))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[145]`
Mówca: **Mikail Aven**
> "“This is certainly not preferable at all. Why is Bergia Steel getting the same treatment as Heart of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[146]`
Mówca: **Mikail Aven**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[147]`
Mówca: **Mikail Aven**
> "“We will not, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Mikail Aven**
> "“I understand, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“We must look into implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Narrator**
> "They gathered their belongings and left the room hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[152]`
Mówca: **Edith Agnoc**
> "“Thank you everyone. Have a nice day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Mikail Aven**
> "“Before you start that discussion, I'm afraid Edith and I will have to leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Mikail Aven**
> "“We need to report the outcome to our companies to make sure we mitigate the impact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Mikail Aven**
> "“I am glad you chose to avoid disrupting Bergia Steel. It would've been disastrous otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization > BaseGame.HeartOfSordland_Nationalization))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] > Variable["BaseGame.HeartOfSordland_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Mikail Aven**
> "“We are done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[166]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy. Eliminating recession completely is not so far off now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Edith Agnoc**
> "“This will definitely show our trade partners that Sordland is moving in the right direction. Which in turn will increase trust... which means more income.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Edith Agnoc**
> "“Excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Symon Holl**
> "“I have to agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> "“I'm not so sure about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Yes, fully privatizing state corporations might give us the budget boost required to help us end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“But we can only pave the way forward for Sordland if we are leading the country from the top.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“Mr. President. Your decision will cost us the support of *every* *single* conservative in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Then get to it, Lucian.”"]** — Mówca: **Player**
> "“Then get to it, Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We can offset our losses in votes with our gains from this change.”"]** — Mówca: **Player**
> "“We can offset our losses in votes with our gains from this change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“I don't care about the conservatives.”"]** — Mówca: **Player**
> "“I don't care about the conservatives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Of course, that includes the leader of the conservative wing of our own party, Gloria Tory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“I also want to remind you that the majority of the Assembly is conservative. We have our work cut out for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[176]`
  - -> `[175]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“You are being too optimistic. I'm afraid of the reality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“We must. They have considerable power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Right away, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "He frowned, bowed slightly and spoke with a soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“I will see what we can do, but this might be the hardest task you have ever given me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[187]`
  - -> `[186]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I have complete trust in your capabilities, Lucian.”"]** — Mówca: **Player**
> "“I have complete trust in your capabilities, Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“You will succeed regardless.”"]** — Mówca: **Player**
> "“You will succeed regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“We have come this far. We can handle it.”"]** — Mówca: **Player**
> "“We have come this far. We can handle it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“If you will excuse me, I have to get to work immediately. There is much to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucian packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“We might have been able to survive if you privatized only one of the companies, but fully privatizing both of them...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  or  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 3 || BaseGame.NedamMiningGroup_Privatization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  or  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[195]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy. Eliminating recession completely is not so far off now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Edith Agnoc**
> "“This will definitely show our trade partners that Sordland is moving in the right direction. Which in turn will increase trust... which means more income.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Yes, fully privatizing a state corporation might give us the budgetary boost required to help us end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Edith Agnoc**
> "“Excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> "“I'm not so sure about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Symon Holl**
> "“I have to agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
> "“But we can only pave the way forward for Sordland if we are leading the country from the top.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“Mr. President. Your decision will make us lose the support of many conservatives in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“Thank you for heeding my suggestions, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Mikail Aven**
> "“I want to thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Mikail Aven**
> "“This decision will revitalize our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Mikail Aven**
> "“Although I wish we could have proceeded with privatization in a greater capacity, it is a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Edith Agnoc**
> "“Certainly a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“Partial privatization will still deal damage to our conservative voter base. But it is nothing we can't handle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
> "“I believe this was the best outcome we could have hoped for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 1 && BaseGame.NedamMiningGroup_Privatization == 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 1  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
> "“I suspect that, regardless, we will lose the support of some conservatives in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“But the gains we receive will offset the losses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[219]`
  - -> `[221]`

### Węzeł `[219]`
**[WYBÓR GRACZA: "“I hope you are right.”"]** — Mówca: **Player**
> "“I hope you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I don't care about the conservatives in the Assembly.”"]** — Mówca: **Player**
> "“I don't care about the conservatives in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Make sure those gains happen.""]** — Mówca: **Player**
> "“Make sure those gains happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“As you wish. I will not leave any stones unturned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
> "“I will do the best I can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“As they have quite a majority in the Assembly, you should.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“Hopefully the number of conservatives who will be against us because of this decision will be low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
> "“If you will excuse me, I have to get to work immediately. There is much to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Lucian packed up his bag and started making his way to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Symon Holl**
> "“That will be it for today then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Symon Holl**
> "“Thank you all for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`
  - -> `[245]`

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“I know everyone has very busy schedules.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[231]`
Mówca: **Edith Agnoc**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Edith Agnoc**
> "“I've had my fair share of experience. I understand when the cards are stacked against me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Edith Agnoc**
> "“I want to assure you, you will find an ally in me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[235]`
  - -> `[234]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I don't need an ally like you.”"]** — Mówca: **Player**
> "“I don't need an ally like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Sounds wonderful. I am looking forward to working with you.”"]** — Mówca: **Player**
> "“Sounds wonderful. I am looking forward to working with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "“It had better be that way, Edith. For your own good.”"]** — Mówca: **Player**
> "“It had better be that way, Edith. For your own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Edith Agnoc**
> "“I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
Mówca: **Edith Agnoc**
> "“That's great to hear!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Edith Agnoc**
> "“As you wish. Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Edith Agnoc**
> "“I must leave now as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[241]`
Mówca: **Narrator**
> "Edith leaned forward to get closer to my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[242]`
Mówca: **Narrator**
> "I put the documents in my suitcase and left the room with Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Good work everyone.”"]** — Mówca: **Player**
> "“Good work, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Thank you, Symon.”"]** — Mówca: **Player**
> "“Thank you, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "“I want to see the results as soon as possible.”"]** — Mówca: **Player**
> "“I want to see the results as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Symon Holl**
> "“My pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[247]`
Mówca: **Symon Holl**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[248]`
Mówca: **Symon Holl**
> "“Of course. As fast as we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[249]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[250]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[251]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[253]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[254]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_StateSector_Expanded = true; BaseGameSupport.FactionReport_Turn07_CSP_NationalizationPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_StateSector_Expanded"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_CSP_NationalizationPraise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Filler instruction for organization)*
- **Efekt (`userScript`):** `-- Filler instruction for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[262]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_PrivateSector_Expanded = true; BaseGameSupport.FactionReport_Turn07_ATO_PrivatizationPraise = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_PrivateSector_Expanded"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_ATO_PrivatizationPraise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[263]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Filler instruction for organization)*
- **Efekt (`userScript`):** `-- Filler instruction for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[264]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2;
BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[265]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[267]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 4;
BaseGame.Economy += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 4;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[270]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[272]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[273]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[274]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization <= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[277]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 3;
BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 3;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 5;
BaseGame.Economy -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 5;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[280]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[281]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[283]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization 
+
BaseGame.HeartOfSordland_Nationalization <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] 
+
Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[284]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[286]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + 
BaseGame.NedamMiningGroup_Privatization <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + 
Variable["BaseGame.NedamMiningGroup_Privatization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[287]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);
BaseGame.Malenyevist += (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);
BaseGame.Capitalist -= (BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization);)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - (Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"]);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[288]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[290]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[294]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);
BaseGame.Malenyevist -= (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);
BaseGame.Capitalist += (BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization);)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + (Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"]);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[295]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[297]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[298]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
