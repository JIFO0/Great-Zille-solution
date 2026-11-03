# Sordland/Turn07/NiaDialogue01_Ally

- **ID konwersacji:** `108`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/108_NiaDialogue01_Ally.md`
- **Liczba węzłów dialogowych:** 101
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A`
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B`
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A`
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B`
- `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[10]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[14]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- Węzeł `[19]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- Węzeł `[60]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[10]`

### Węzeł `[3]`
Mówca: **Nia Morgna**
> ""Lucian and Petr believe that he can be persuaded though... So I'll leave that up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[4]`
Mówca: **Nia Morgna**
> "The Old Guards are fanatically opposing your proposal, so I doubt there is any possibility there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[7]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""What about Heron? I thought we could get to him.""]** — Mówca: **Player**
> ""What about Heron? I thought we could get to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""We won the vote. Maybe we could still persuade Orso.""]** — Mówca: **Player**
> ""We won the vote. Maybe we could still persuade Orso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Can we rely on Isabel to bring all three centrist votes?""]** — Mówca: **Player**
> ""Can we rely on Isabel to bring all three centrist votes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[8]`
Mówca: **Nia Morgna**
> ""We can't know for *sure* of course, but the centrist trio always stick together and Isabel is their mouthpiece. She's the only one willing to talk, so we have to take our chances with her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Yes. We might need him for the last vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""He's not willing to talk. I doubt you can do anything about that. He won't be giving away his powers like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""Let's talk about our next steps.""]** — Mówca: **Player**
> ""Let's talk about our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""Heron might be a possibility, yes. But I advise against dealing with any of them. If we can persuade Isabel, we can get the votes we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Thank you for your efforts with the Anti-corruption police.""]** — Mówca: **Player**
> ""Thank you for your efforts with the Anti-corruption police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[15]`
Mówca: **Nia Morgna**
> ""Well, the next step is speaking to Isabel and making sure she votes for the proposal. But also...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[16]`
Mówca: **Nia Morgna**
> ""He's doing his best to organize the Court against your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[17]`
Mówca: **Nia Morgna**
> ""I guess we have... maybe 15 minutes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Thank you for signing the order, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[20]`
Mówca: **Nia Morgna**
> ""She's certainly open to dialogue but also sceptical. She seemed to be scared of a potential purge against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[25]`
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Interesting. We should play into that.""]** — Mówca: **Player**
> ""Interesting. We should play into that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We can find common ground against the Old Guard.""]** — Mówca: **Player**
> ""We can find common ground against the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
Mówca: **Nia Morgna**
> ""Their weakest link is Heron, but the rest are unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[36]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""So you think she's scared of us?""]** — Mówca: **Player**
> ""So you think she's scared of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""When will Isabel be here?""]** — Mówca: **Player**
> ""When will Isabel be here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""She's not entirely scared about the situation but then again none of the court even believed that you would pass the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[30]`
Mówca: **Narrator**
> "She looked at her watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""So maybe she's feeling the pressure on her now. But in any case, we'll discover that soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[32]`
Mówca: **Nia Morgna**
> ""That's what I hope for too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NiaHub1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[53]`
  - -> `[47]`
  - -> `[11]`
  - -> `[22]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Just don't take her lightly. Isabel's feeling the pressure after the vote but she's not a weak woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""I'm sure he has also pressured the Justices of the Court right after that win. I can't speak any sense into them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[45]`
  - -> `[68]`
  - -> `[79]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""We need to talk to Heron, then.""]** — Mówca: **Player**
> ""We need to talk to Heron, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""But there's huge pressure on them. The Anti-corruption force has found incriminating evidence against some of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHub1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""Also thanks for the recent efforts of our anti-corruption force, we managed to *pressure* several Justices into cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""So we have... potentially four or five votes in total. So today's meeting can bring us the last vote we need to reach six.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""We still need three more votes. Isabel can potentially bring two to three votes, that's why she's our ticket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""What is the atmosphere in the Court?""]** — Mówca: **Player**
> ""What is the atmosphere in the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""The Old Guards are fanatically opposing your proposal, so I doubt there is any possibility there. But we might still need their help if Isabel can't bring exactly the three votes we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""You are right, but where's the breaking point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHub1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""What about Justice Edmonds? Do you think we can sway her?""]** — Mówca: **Player**
> ""What about Justice Edmonds? Do you think we can sway her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""Heron is a possibility, yes. I dislike him but if we really want to be sure we might need him. A disgrace of a justice he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[67]`
Mówca: **Nia Morgna**
> ""She's not openly protesting against the Old Guards but she has told me about her concerns about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""You are the Minister of Justice. You must speak sense into them.""]** — Mówca: **Player**
> ""You are the Minister of Justice. You must speak sense into them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""You should call Lucian, he has been trying to deal with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Yes, I think she's our best bet. We have a meeting with her now, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""She must also be under pressure after the anti-corruption police's raids against her fellow colleagues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""We have to keep up the pressure.""]** — Mówca: **Player**
> ""We have to keep up the pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Nobody is unbreakable.""]** — Mówca: **Player**
> ""Nobody is unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""Although they have immunity, they are scared that these would go public. We have already gained a few more votes in the Court but I'm not sure more Old Guards would jump on the same wagon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[13]`
  - -> `[80]`
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""It is the Old Guard that are disrespecting their positions. But we will hopefully take care of that soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""What has Orso been doing?""]** — Mówca: **Player**
> ""What has Orso been doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Good. The whole Court must finally learn to back down.""]** — Mówca: **Player**
> ""Good. The whole Court must finally learn to back down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""Orso and Heron have a tight grip on everybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""You know who I'm dealing with, Mr. President. It's not easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""The efforts are bearing fruit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""I only know about the two Justices I've mentioned earlier who are with me. So we have three votes there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""We are not in a battle against the Court here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
Mówca: **Nia Morgna**
> ""These old men have a pride as vast as Merkopa, they're not easy game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""They can keep relying on their immunity. Soon, we will be able to impeach them.""]** — Mówca: **Player**
> ""They can keep relying on their immunity. Soon, we will be able to impeach them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Nia Morgna**
> ""The investigations are still going, Mr. President. The pressure will build up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""With the ongoing investigations of the anti-corruption force, I'm sure we will have a strong position against most of the Old Guards regarding their impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""Most Justices don't really talk when I'm around. They don't trust me as I'm an outside member of the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[95]`
Mówca: **Nia Morgna**
> ""But I still think it was not the right decision to add that to the proposal. This might pressure the future Courts to always be in line with the fear of being displaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHub1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""We can't know for *sure* of course, but the ACP should help them get in line if Isabel's trust can be earned. The centrists stick together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
