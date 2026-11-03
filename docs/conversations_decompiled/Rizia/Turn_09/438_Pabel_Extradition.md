# Rizia/Turn 9/Pabel Extradition

- **ID konwersacji:** `438`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/438_Pabel_Extradition.md`
- **Liczba węzłów dialogowych:** 80
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Success`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLC.Vina_Escapes`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Pabel_Arrested`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[435] Rizia/Turn 9/FPnT_Mediation** (../Turn_09/435_FPnT_Mediation.md), Węzeł `[9]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 2

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel_Together`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[44]` (Paskal Beniwoll): `Variable["RiziaDLC.Pabel_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn09_Derdia_Pabel...`
- Węzeł `[72]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`

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
  - -> `[77]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `435` (*Rizia/Turn 9/FPnT_Mediation*), Węzeł `[9]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The Derdian leader rose to leave, then sat back down with a thoughtful look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Jorga Azmal**
> ""Your Majesty... did you know that a former member of your royal household has recently claimed asylum in Derdia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[6]`
  - -> `[12]`
  - -> `[10]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it the Princess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not know that. But it does not come as surprising news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You must extradite this person immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My butler Pabel Adria, I presume? He mentioned he had friends there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""None other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""No. A man by the name of Pabel Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Jorga Azmal**
> ""I presume it is someone involved in Princess Vina's recent disappearance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""That may be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""That won't be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""The man, Pabel Adria, claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[36]`
  - -> `[35]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He assisted in my daughter's disappearance. He might have information about where she is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""Mr. Adria claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment by your laws, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[36]`
  - -> `[35]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""This man, Pabel Adria, claims he will be unjustly persecuted if he returns to Rizia. But if you deem his crime worthy of punishment by your laws, you may have him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[36]`
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""Then you know that I cannot help you should you wish Pabel Adria's extradition to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[40]`
  - -> `[41]`
  - -> `[45]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Supreme Wiseman. Nobody betrays the King of Rizia without consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, leave him be. Punishing him would accomplish nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, send him here. He was complicit in my daughter's escape. He might have information about where she is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. Nobody betrays the King of Rizia and gets away with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you say that? Do you even know what he did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[42]`
Mówca: **Jorga Azmal**
> ""According to the Derdian Constitution, we are obliged to offer sanctuary to those facing persecution due to their practice of the most sacred form of love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""Without exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[52]`
  - -> `[60]`
  - -> `[54]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Arrested = true; RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition = true; RiziaDLC.Relations_Pabel_Together = false;
EnableCodexEntry("Characters_Others_PabelAdria_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pabel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_Derdia_PabelExtradition"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;
EnableCodexEntry("Characters_Others_PabelAdria_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would not expect your assistance in this matter. What happened is between Mr. Adria and myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Wruhec himself would admire your mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""We do not use such labels in Derdia. And we do not imprison men when a divine spark ignites between them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. Are you saying my butler was a homosexual?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == false && RiziaDLC.Relations_Pabel_OutedToPlayer == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == false  and  Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. May God forgive him, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Love wasn't his crime. Abetting my daughter's escape was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Azmal nodded sagely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""I will not ask what happened. But I hope the Lord shows you both mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[59]`
Mówca: **Jorga Azmal**
> ""And yet Rizia would have him punished for either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The most sacred form of love is between a man and a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Jorga Azmal**
> ""Is that what you believe, Your Majesty? Or are you parroting the words of your flawed Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you ever actually been with a man, Supreme Wiseman? There's nothing sacred about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""That is in the eye of the beholder, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""I do not want to put a taint on what we have accomplished today. But I unfortunately cannot assist in returning him to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[40]`
  - -> `[41]`
  - -> `[45]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Very well. I'll give the orders when I arrive back at the Garrison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Azmal shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Azmal nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""As long as he faces danger upon returning to Rizia, Pabel Adria must remain in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He stood up, shook my hand and left the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
Mówca: **Jorga Azmal**
> ""I will not ask you to change your kingdom's laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""But I hope that someday you and your people will see things the way we do. The way St. Wruhec intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""May the Lord be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_DerdiaWehlenMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
