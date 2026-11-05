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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""What about Heron? I thought we could get to him.""** | `[4]` **Nia Morgna**: "The Old Guards are fanatically o..."<br>`[46]` **Nia Morgna**: ""The Old Guards are fanatically ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Nia Morgna**: ""Heron might be a possibility, y..."<br>`[66]` **Nia Morgna**: ""Heron is a possibility, yes. I ..." |
| `[6]` | **""We won the vote. Maybe we could still persuade Orso.""** | `[46]` **Nia Morgna**: ""The Old Guards are fanatically ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Nia Morgna**: ""He's not willing to talk. I dou..." |
| `[7]` | **""Can we rely on Isabel to bring all three centrist votes?""** | `[4]` **Nia Morgna**: "The Old Guards are fanatically o..."<br>`[46]` **Nia Morgna**: ""The Old Guards are fanatically ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Nia Morgna**: ""We can't know for *sure* of cou..."<br>`[8]` **Nia Morgna**: ""We can't know for *sure* of cou..." |
| `[11]` | **""Let's talk about our next steps.""** | `[81]` **Nia Morgna**: ""Orso and Heron have a tight gri..."<br>`[31]` **Nia Morgna**: ""So maybe she's feeling the pres..."<br>*(oraz 14 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Nia Morgna**: ""Well, the next step is speaking..." |
| `[13]` | **""Thank you for your efforts with the Anti-corruption police.""** | `[77]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Nia Morgna**: ""Thank you for signing the order..." |
| `[21]` | **""Interesting. We should play into that.""** | `[20]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Nia Morgna**: ""Just don't take her lightly. Is..." |
| `[25]` | **""We can find common ground against the Old Guard.""** | `[20]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Nia Morgna**: ""That's what I hope for too."" |
| `[27]` | **""So you think she's scared of us?""** | `[20]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Nia Morgna**: ""She's not entirely scared about..." |
| `[28]` | **""When will Isabel be here?""** | `[81]` **Nia Morgna**: ""Orso and Heron have a tight gri..."<br>`[31]` **Nia Morgna**: ""So maybe she's feeling the pres..."<br>*(oraz 14 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true` | *Brak zmian stanu* | `[30]` **Narrator**: "She looked at her watch." |
| `[36]` | **""We need to talk to Heron, then.""** | `[26]` **Nia Morgna**: ""Their weakest link is Heron, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Nia Morgna**: ""Yes. We might need him for the ..." |
| `[45]` | **""What is the atmosphere in the Court?""** | `[35]` **Nia Morgna**: ""I'm sure he has also pressured ..."<br>`[81]` **Nia Morgna**: ""Orso and Heron have a tight gri..."<br>*(oraz 15 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false` | *Brak zmian stanu* | `[94]` **Nia Morgna**: ""Most Justices don't really talk..." |
| `[65]` | **""What about Justice Edmonds? Do you think we can sway her?""** | `[35]` **Nia Morgna**: ""I'm sure he has also pressured ..."<br>`[81]` **Nia Morgna**: ""Orso and Heron have a tight gri..."<br>*(oraz 15 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false` | *Brak zmian stanu* | `[73]` **Nia Morgna**: ""Yes, I think she's our best bet..." |
| `[68]` | **""You are the Minister of Justice. You must speak sense into them.""** | `[35]` **Nia Morgna**: ""I'm sure he has also pressured ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Nia Morgna**: ""You know who I'm dealing with, ..." |
| `[75]` | **""We have to keep up the pressure.""** | `[77]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Nia Morgna**: ""The investigations are still go..." |
| `[76]` | **""Nobody is unbreakable.""** | `[26]` **Nia Morgna**: ""Their weakest link is Heron, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Nia Morgna**: ""You are right, but where's the ..." |
| `[79]` | **""What has Orso been doing?""** | `[35]` **Nia Morgna**: ""I'm sure he has also pressured ..."<br>`[81]` **Nia Morgna**: ""Orso and Heron have a tight gri..."<br>*(oraz 15 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false` | *Brak zmian stanu* | `[16]` **Nia Morgna**: ""He's doing his best to organize..." |
| `[80]` | **""Good. The whole Court must finally learn to back down.""** | `[77]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Nia Morgna**: ""We are not in a battle against ..." |
| `[91]` | **""They can keep relying on their immunity. Soon, we will be able to impeach them.""** | `[77]` **Nia Morgna**: ""Although they have immunity, th..." | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true` | *Brak zmian stanu* | `[93]` **Nia Morgna**: ""With the ongoing investigations..." |

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
  - -> `[35]` (*Nia Morgna: ""I'm sure he has also pressured the Justices of the Court..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Nia Morgna: ""He's not willing to talk. I doubt you can do anything ab..."*)

### Węzeł `[3]`
Mówca: **Nia Morgna**
> ""Lucian and Petr believe that he can be persuaded though... So I'll leave that up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[4]`
Mówca: **Nia Morgna**
> "The Old Guards are fanatically opposing your proposal, so I doubt there is any possibility there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""What about Heron? I thought we could get to him.""*)
  - -> `[7]` (*Player: ""Can we rely on Isabel to bring all three centrist votes?""*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""What about Heron? I thought we could get to him.""]** — Mówca: **Player**
> ""What about Heron? I thought we could get to him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Nia Morgna), `[46]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""We won the vote. Maybe we could still persuade Orso.""]** — Mówca: **Player**
> ""We won the vote. Maybe we could still persuade Orso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Nia Morgna: ""He's not willing to talk. I doubt you can do anything ab..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Can we rely on Isabel to bring all three centrist votes?""]** — Mówca: **Player**
> ""Can we rely on Isabel to bring all three centrist votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Nia Morgna), `[46]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[8]`
Mówca: **Nia Morgna**
> ""We can't know for *sure* of course, but the centrist trio always stick together and Isabel is their mouthpiece. She's the only one willing to talk, so we have to take our chances with her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Yes. We might need him for the last vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""You should call Lucian, he has been trying to deal with ..."*)

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""He's not willing to talk. I doubt you can do anything about that. He won't be giving away his powers like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""Let's talk about our next steps.""]** — Mówca: **Player**
> ""Let's talk about our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Nia Morgna), `[31]` (Nia Morgna), `[32]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Nia Morgna: ""Well, the next step is speaking to Isabel and making sur..."*)

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""Heron might be a possibility, yes. But I advise against dealing with any of them. If we can persuade Isabel, we can get the votes we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Nia Morgna: ""Lucian and Petr believe that he can be persuaded though...."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Thank you for your efforts with the Anti-corruption police.""]** — Mówca: **Player**
> ""Thank you for your efforts with the Anti-corruption police.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Nia Morgna: ""Thank you for signing the order, Mr. President.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub1]"*)

### Węzeł `[15]`
Mówca: **Nia Morgna**
> ""Well, the next step is speaking to Isabel and making sure she votes for the proposal. But also...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[16]`
Mówca: **Nia Morgna**
> ""He's doing his best to organize the Court against your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[17]`
Mówca: **Nia Morgna**
> ""I guess we have... maybe 15 minutes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Thank you for signing the order, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Nia Morgna: ""The efforts are bearing fruit.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub1]"*)

### Węzeł `[20]`
Mówca: **Nia Morgna**
> ""She's certainly open to dialogue but also sceptical. She seemed to be scared of a potential purge against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Interesting. We should play into that.""*)
  - -> `[25]` (*Player: ""We can find common ground against the Old Guard.""*)
  - -> `[27]` (*Player: ""So you think she's scared of us?""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Interesting. We should play into that.""]** — Mówca: **Player**
> ""Interesting. We should play into that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: ""Just don't take her lightly. Isabel's feeling the pressu..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHu..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""When will Isabel be here?""*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We can find common ground against the Old Guard.""]** — Mówca: **Player**
> ""We can find common ground against the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Nia Morgna: ""That's what I hope for too.""*)

### Węzeł `[26]`
Mówca: **Nia Morgna**
> ""Their weakest link is Heron, but the rest are unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Nobody is unbreakable.""*)
  - -> `[36]` (*Player: ""We need to talk to Heron, then.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""So you think she's scared of us?""]** — Mówca: **Player**
> ""So you think she's scared of us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Nia Morgna: ""She's not entirely scared about the situation but then a..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""When will Isabel be here?""]** — Mówca: **Player**
> ""When will Isabel be here?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Kontekst wejściowy (poprzednik):** `[81]` (Nia Morgna), `[31]` (Nia Morgna), `[32]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She looked at her watch."*)

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""She's not entirely scared about the situation but then again none of the court even believed that you would pass the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "She looked at her watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Nia Morgna: ""I guess we have... maybe 15 minutes?""*)

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""So maybe she's feeling the pressure on her now. But in any case, we'll discover that soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[32]`
Mówca: **Nia Morgna**
> ""That's what I hope for too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHub1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[11]` (*Player: ""Let's talk about our next steps.""*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Just don't take her lightly. Isabel's feeling the pressure after the vote but she's not a weak woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""I'm sure he has also pressured the Justices of the Court right after that win. I can't speak any sense into them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""What about Justice Edmonds? Do you think we can sway her?""*)
  - -> `[45]` (*Player: ""What is the atmosphere in the Court?""*)
  - -> `[68]` (*Player: ""You are the Minister of Justice. You must speak sense in..."*)
  - -> `[79]` (*Player: ""What has Orso been doing?""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""We need to talk to Heron, then.""]** — Mówca: **Player**
> ""We need to talk to Heron, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""Yes. We might need him for the last vote.""*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""But there's huge pressure on them. The Anti-corruption force has found incriminating evidence against some of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Nia Morgna: ""Although they have immunity, they are scared that these ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""But there's huge pressure on them. The Anti-corruption f..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Nia Morgna: ""Their weakest link is Heron, but the rest are unbreakable.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHub1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "NiaHub1"*)

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""Also thanks for the recent efforts of our anti-corruption force, we managed to *pressure* several Justices into cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Nia Morgna: ""So we have... potentially four or five votes in total. S..."*)

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""So we have... potentially four or five votes in total. So today's meeting can bring us the last vote we need to reach six.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Nia Morgna: "The Old Guards are fanatically opposing your proposal, so..."*)

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""We still need three more votes. Isabel can potentially bring two to three votes, that's why she's our ticket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Nia Morgna: ""The Old Guards are fanatically opposing your proposal, s..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""What is the atmosphere in the Court?""]** — Mówca: **Player**
> ""What is the atmosphere in the Court?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Nia Morgna), `[81]` (Nia Morgna), `[31]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Nia Morgna: ""Most Justices don't really talk when I'm around. They do..."*)

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""The Old Guards are fanatically opposing your proposal, so I doubt there is any possibility there. But we might still need their help if Isabel can't bring exactly the three votes we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""What about Heron? I thought we could get to him.""*)
  - -> `[6]` (*Player: ""We won the vote. Maybe we could still persuade Orso.""*)
  - -> `[7]` (*Player: ""Can we rely on Isabel to bring all three centrist votes?""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHu..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""What has Orso been doing?""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHu..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""What about Justice Edmonds? Do you think we can sway her?""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHu..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""What is the atmosphere in the Court?""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Nia Morgna: ""Also thanks for the recent efforts of our anti-corruptio..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Nia Morgna: ""We still need three more votes. Isabel can potentially b..."*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""You are right, but where's the breaking point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Nia Morgna: ""These old men have a pride as vast as Merkopa, they're n..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub1]"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Nia Morgna: ""Heron might be a possibility, yes. But I advise against ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: ""Heron is a possibility, yes. I dislike him but if we rea..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHub1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "NiaHub1"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""What about Justice Edmonds? Do you think we can sway her?""]** — Mówca: **Player**
> ""What about Justice Edmonds? Do you think we can sway her?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Nia Morgna), `[81]` (Nia Morgna), `[31]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""Yes, I think she's our best bet. We have a meeting with ..."*)

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""Heron is a possibility, yes. I dislike him but if we really want to be sure we might need him. A disgrace of a justice he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[67]`
Mówca: **Nia Morgna**
> ""She's not openly protesting against the Old Guards but she has told me about her concerns about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Nia Morgna: ""She's certainly open to dialogue but also sceptical. She..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""You are the Minister of Justice. You must speak sense into them.""]** — Mówca: **Player**
> ""You are the Minister of Justice. You must speak sense into them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Nia Morgna: ""You know who I'm dealing with, Mr. President. It's not e..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Nia Morgna: ""She must also be under pressure after the anti-corruptio..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Nia Morgna: ""So maybe she's feeling the pressure on her now. But in a..."*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""You should call Lucian, he has been trying to deal with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Yes, I think she's our best bet. We have a meeting with her now, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Nia Morgna: ""She's not openly protesting against the Old Guards but s..."*)

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""She must also be under pressure after the anti-corruption police's raids against her fellow colleagues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""We have to keep up the pressure.""]** — Mówca: **Player**
> ""We have to keep up the pressure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Nia Morgna: ""The investigations are still going, Mr. President. The p..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Nobody is unbreakable.""]** — Mówca: **Player**
> ""Nobody is unbreakable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""You are right, but where's the breaking point?""*)

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""Although they have immunity, they are scared that these would go public. We have already gained a few more votes in the Court but I'm not sure more Old Guards would jump on the same wagon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[13]` (*Player: ""Thank you for your efforts with the Anti-corruption poli..."*)
  - -> `[80]` (*Player: ""Good. The whole Court must finally learn to back down.""*)
  - -> `[75]` (*Player: ""We have to keep up the pressure.""*)

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""It is the Old Guard that are disrespecting their positions. But we will hopefully take care of that soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""What has Orso been doing?""]** — Mówca: **Player**
> ""What has Orso been doing?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Nia Morgna), `[81]` (Nia Morgna), `[31]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Nia Morgna: ""He's doing his best to organize the Court against your p..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Good. The whole Court must finally learn to back down.""]** — Mówca: **Player**
> ""Good. The whole Court must finally learn to back down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Nia Morgna: ""We are not in a battle against the Court here, Mr. Presi..."*)

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""Orso and Heron have a tight grip on everybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub1]"*)

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""You know who I'm dealing with, Mr. President. It's not easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Nia Morgna: ""Orso and Heron have a tight grip on everybody.""*)

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""The efforts are bearing fruit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""I only know about the two Justices I've mentioned earlier who are with me. So we have three votes there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""We are not in a battle against the Court here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Nia Morgna: ""It is the Old Guard that are disrespecting their positio..."*)

### Węzeł `[86]`
Mówca: **Nia Morgna**
> ""These old men have a pride as vast as Merkopa, they're not easy game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""They can keep relying on their immunity. Soon, we will b..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""They can keep relying on their immunity. Soon, we will be able to impeach them.""]** — Mówca: **Player**
> ""They can keep relying on their immunity. Soon, we will be able to impeach them.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Kontekst wejściowy (poprzednik):** `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Nia Morgna: ""With the ongoing investigations of the anti-corruption f..."*)

### Węzeł `[92]`
Mówca: **Nia Morgna**
> ""The investigations are still going, Mr. President. The pressure will build up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""With the ongoing investigations of the anti-corruption force, I'm sure we will have a strong position against most of the Old Guards regarding their impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Nia Morgna: ""But I still think it was not the right decision to add t..."*)

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""Most Justices don't really talk when I'm around. They don't trust me as I'm an outside member of the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Nia Morgna: ""I only know about the two Justices I've mentioned earlie..."*)

### Węzeł `[95]`
Mówca: **Nia Morgna**
> ""But I still think it was not the right decision to add that to the proposal. This might pressure the future Courts to always be in line with the fear of being displaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""Anyway...""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHub1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "NiaHub1"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""We can't know for *sure* of course, but the ACP should h..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Nia Morgna: ""We can't know for *sure* of course, but the centrist tri..."*)

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""We can't know for *sure* of course, but the ACP should help them get in line if Isabel's trust can be earned. The centrists stick together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
