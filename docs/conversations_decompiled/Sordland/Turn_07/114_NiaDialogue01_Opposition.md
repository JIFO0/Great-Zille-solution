# Sordland/Turn07/NiaDialogue01_Opposition

- **ID konwersacji:** `114`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/114_NiaDialogue01_Opposition.md`
- **Liczba węzłów dialogowych:** 107
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
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
- Węzeł `[17]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- Węzeł `[22]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- Węzeł `[57]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[10]`

### Węzeł `[3]`
Mówca: **Nia Morgna**
> ""I'm sure he also pressured the Justices of the Court against your proposal right after that win. I hate to be on his side but I don't agree with your proposal either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Nia Morgna**
> ""You call this proposal *democratic*, but we know it's a power grab, Mr. President. I'm only doing this out of respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""I've organized this meeting because I am still a part of the cabinet. Consider this a favour from my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`
  - -> `[87]`

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""Lucian and Petr believe that he can be persuaded too. Whatever you do, I am not with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""What about Heron?""]** — Mówca: **Player**
> ""What about Heron?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""We won the vote. I can still persuade Orso.""]** — Mówca: **Player**
> ""We won the vote. I can still persuade Orso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Mrs. Morgna. Don't do this. I need your vote.""]** — Mówca: **Player**
> ""Mrs. Morgna. Don't do this. I need your vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""I thought we've been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Nia Morgna**
> ""Well, I'm not helping with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""He's not willing to talk. I doubt you can do anything about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""There's nothing else.""]** — Mówca: **Player**
> ""There's nothing else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Nia Morgna**
> ""Oh, now you want to cooperate with the Old Guards, after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Thank you for your efforts with the Anti-corruption police.""]** — Mówca: **Player**
> ""Thank you for your efforts with the Anti-corruption police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubOpposition])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""He's doing his best to organize the Court against your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[20]`
Mówca: **Nia Morgna**
> ""I guess we have... maybe 5 minutes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[21]`
Mówca: **Nia Morgna**
> ""Thank you for signing the order, Mr. President. But do not think that the force is a political tool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[23]`
Mówca: **Nia Morgna**
> ""She's certainly open to dialogue but also sceptical. She seemed to be scared of a potential purge against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Interesting. Maybe I should play into that.""]** — Mówca: **Player**
> ""Interesting. Maybe I should play into that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We can find common ground against the Old Guard.""]** — Mówca: **Player**
> ""We can find common ground against the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""Their weakest link is Heron, but the rest are unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[38]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""So, you think she's scared of us?""]** — Mówca: **Player**
> ""So, you think she's scared of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""When will Isabel be here?""]** — Mówca: **Player**
> ""When will Isabel be here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Nia Morgna**
> ""She's not entirely scared about the situation, but then again, none of the court even believed that you would succeed in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[33]`
Mówca: **Narrator**
> "She looked at her watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Maybe she's feeling the pressure now. But in any case, you'll discover that soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Having common enemies doesn't always result in an alliance. As you know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NiaHubOpposition)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[53]`
  - -> `[47]`
  - -> `[13]`
  - -> `[25]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Do whatever you want, Mr. President. Isabel might be feeling the pressure after the vote, but she's not a weak woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""We need to talk to Heron, then.""]** — Mówca: **Player**
> ""We need to talk to Heron, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[39]`
Mówca: **Nia Morgna**
> ""But there's huge pressure on them. The Anti-corruption force has found incriminating evidence against some of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubOpposition])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""You still need six votes from somewhere. Isabel can potentially bring two to three votes, that's why she's your ticket. But I doubt it will work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""What is the atmosphere in the Court?""]** — Mówca: **Player**
> ""What is the atmosphere in the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""The Old Guards are fanatically opposing your proposal too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

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
  - -> `[70]`

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
  - -> `[58]`

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
Mówca: **Nia Morgna**
> ""You are right, but where's the breaking point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What about Justice Edmonds? Does she share your views?""]** — Mówca: **Player**
> ""What about Justice Edmonds? Does she share your views?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""She's not openly protesting against the Old Guards but she has told me about her concerns about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[63]`
Mówca: **Nia Morgna**
> ""Your openness to talk to Heron is already showing me your true intentions...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Nia Morgna**
> ""Somewhat, yes. We are not ideologically entirely aligned but she's still someone who has a sense of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[65]`
Mówca: **Nia Morgna**
> ""She must also be under pressure after the anti-corruption police's raids against her fellow colleagues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We have to keep up the pressure.""]** — Mówca: **Player**
> ""We have to keep up the pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Nobody is unbreakable.""]** — Mówca: **Player**
> ""Nobody is unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[68]`
Mówca: **Nia Morgna**
> ""Although they have immunity, they are scared that these would go public. You might have already gained a few more votes in the Court but I'm not sure more Old Guards would jump on the same wagon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[15]`
  - -> `[71]`
  - -> `[66]`

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""It is the Old Guard that are disrespecting their positions. You cannot bring down the Court. With all due respect, it is the *President* who needs to *finally learn to back down*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[92]`
  - -> `[94]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""What has Orso been doing?""]** — Mówca: **Player**
> ""What has Orso been doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Good. The whole Court must finally learn to back down.""]** — Mówca: **Player**
> ""Good. The whole Court must finally learn to back down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""I won't let their efforts be exploited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""I only know about the two Justices I've mentioned earlier who are with me. So we have three votes there. Against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""Is this a battle against the Court, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""These old men have a pride as vast as Merkopa, they're not easy to break. And... This is not a game, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Nia Morgna**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""They can keep relying on their immunity. Soon, we will be able to impeach them.""]** — Mówca: **Player**
> ""They can keep relying on their immunity. Soon, we will be able to impeach them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""The investigations are still going, Mr. President. The pressure will build up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""With the ongoing investigations of the anti-corruption force, I'm sure we will have a strong position against most of the Old Guards regarding their impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""Most Justices don't really talk when I'm around. They don't trust me as I'm an outside member of the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""But I still think it was not the right decision to add that to the proposal. This might pressure the future Courts to always be in line with the fear of being displaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Thank you Mrs. Morgna. This means a lot.""]** — Mówca: **Player**
> ""Thank you Mrs. Morgna. This means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Are you saying that you will vote against the proposal?""]** — Mówca: **Player**
> ""Are you saying that you will vote against the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I'm disappointed, Mrs. Morgna. I thought I'd be able to change your mind.""]** — Mówca: **Player**
> ""I'm disappointed, Mrs. Morgna. I thought I'd be able to change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Nia Morgna**
> ""I believe my position was clear from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Nia Morgna**
> ""It should, Mr. President. I'm aiding you against what I believe in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Of course, that won't stop me from doing what I can to make it fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Nia Morgna**
> ""But anyway... Let me know if there's something else... I'd be taking my leave as soon as Mrs. Edmonds gets here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[53]`
  - -> `[47]`
  - -> `[13]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""It is a battle that I will win. Yes.""]** — Mówca: **Player**
> ""It is a battle that I will win. Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Watch your words, Mrs. Morgna.""]** — Mówca: **Player**
> ""Watch your words, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I'm sorry to hear that you feel this way.""]** — Mówca: **Player**
> ""I'm sorry to hear that you feel this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""Having common enemies doesn't always result in an alliance. But I doubt that they are really your *enemies.*"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[102]`
Mówca: **Nia Morgna**
> ""The Old Guards were fanatically opposing any constitutional changes. But I think they are not that discontent anymore... Since you are protecting the status quo...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[103]`
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""We won the vote. That might have changed their minds.""]** — Mówca: **Player**
> ""We won the vote. That might have changed their minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""Maybe...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""So the problem is not the Old Guards but you...""]** — Mówca: **Player**
> ""So the problem is not the Old Guards but you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""I thought we've been through this. I organized a meeting for you, didn't I? Don't even try to attack me with that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
