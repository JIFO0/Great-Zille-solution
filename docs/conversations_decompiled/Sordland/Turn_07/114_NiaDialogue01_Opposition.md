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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""What about Heron?""** | `[46]` **Nia Morgna**: ""The Old Guards are fanatically ..."<br>`[102]` **Nia Morgna**: ""The Old Guards were fanatically..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Nia Morgna**: ""Oh, now you want to cooperate w..." |
| `[8]` | **""We won the vote. I can still persuade Orso.""** | `[46]` **Nia Morgna**: ""The Old Guards are fanatically ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Nia Morgna**: ""He's not willing to talk. I dou..." |
| `[9]` | **""Mrs. Morgna. Don't do this. I need your vote.""** | `[46]` **Nia Morgna**: ""The Old Guards are fanatically ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Nia Morgna**: ""I thought we've been through th..." |
| `[13]` | **""There's nothing else.""** | `[91]` **Nia Morgna**: ""But anyway... Let me know if th..."<br>`[6]` **Nia Morgna**: ""Lucian and Petr believe that he..."<br>*(oraz 17 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Nia Morgna**: ""Fine."" |
| `[15]` | **""Thank you for your efforts with the Anti-corruption police.""** | `[68]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Nia Morgna**: ""Thank you for signing the order..." |
| `[24]` | **""Interesting. Maybe I should play into that.""** | `[23]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Nia Morgna**: ""Do whatever you want, Mr. Presi..." |
| `[28]` | **""We can find common ground against the Old Guard.""** | `[23]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Nia Morgna**: ""Having common enemies doesn't a..."<br>`[35]` **Nia Morgna**: ""Having common enemies doesn't a..." |
| `[30]` | **""So, you think she's scared of us?""** | `[23]` **Nia Morgna**: ""She's certainly open to dialogu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Nia Morgna**: ""She's not entirely scared about..." |
| `[31]` | **""When will Isabel be here?""** | `[6]` **Nia Morgna**: ""Lucian and Petr believe that he..."<br>`[10]` **Nia Morgna**: ""I thought we've been through th..."<br>*(oraz 16 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true` | *Brak zmian stanu* | `[33]` **Narrator**: "She looked at her watch." |
| `[38]` | **""We need to talk to Heron, then.""** | `[29]` **Nia Morgna**: ""Their weakest link is Heron, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Nia Morgna**: ""Well, I'm not helping with that."" |
| `[45]` | **""What is the atmosphere in the Court?""** | `[91]` **Nia Morgna**: ""But anyway... Let me know if th..."<br>`[6]` **Nia Morgna**: ""Lucian and Petr believe that he..."<br>*(oraz 17 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false` | *Brak zmian stanu* | `[83]` **Nia Morgna**: ""Most Justices don't really talk..." |
| `[58]` | **""What about Justice Edmonds? Does she share your views?""** | `[91]` **Nia Morgna**: ""But anyway... Let me know if th..."<br>`[6]` **Nia Morgna**: ""Lucian and Petr believe that he..."<br>*(oraz 17 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false` | *Brak zmian stanu* | `[64]` **Nia Morgna**: ""Somewhat, yes. We are not ideol..." |
| `[66]` | **""We have to keep up the pressure.""** | `[68]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Nia Morgna**: ""The investigations are still go..." |
| `[67]` | **""Nobody is unbreakable.""** | `[29]` **Nia Morgna**: ""Their weakest link is Heron, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Nia Morgna**: ""You are right, but where's the ..." |
| `[70]` | **""What has Orso been doing?""** | `[91]` **Nia Morgna**: ""But anyway... Let me know if th..."<br>`[6]` **Nia Morgna**: ""Lucian and Petr believe that he..."<br>*(oraz 17 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false` | *Brak zmian stanu* | `[19]` **Nia Morgna**: ""He's doing his best to organize..." |
| `[71]` | **""Good. The whole Court must finally learn to back down.""** | `[68]` **Nia Morgna**: ""Although they have immunity, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Nia Morgna**: ""Is this a battle against the Co..." |
| `[80]` | **""They can keep relying on their immunity. Soon, we will be able to impeach them.""** | `[68]` **Nia Morgna**: ""Although they have immunity, th..." | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true` | *Brak zmian stanu* | `[82]` **Nia Morgna**: ""With the ongoing investigations..." |
| `[85]` | **""Thank you Mrs. Morgna. This means a lot.""** | `[5]` **Nia Morgna**: ""I've organized this meeting bec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Nia Morgna**: ""It should, Mr. President. I'm a..." |
| `[86]` | **""Are you saying that you will vote against the proposal?""** | `[5]` **Nia Morgna**: ""I've organized this meeting bec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Nia Morgna**: ""I believe my position was clear..." |
| `[87]` | **""I'm disappointed, Mrs. Morgna. I thought I'd be able to change your mind.""** | `[5]` **Nia Morgna**: ""I've organized this meeting bec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Nia Morgna**: ""I believe my position was clear..." |
| `[92]` | **""It is a battle that I will win. Yes.""** | `[69]` **Nia Morgna**: ""It is the Old Guard that are di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCou...` | `[13]` **Player**: ""There's nothing else.""<br>`[58]` **Player**: ""What about Justice Edmonds? Doe..."<br>*(oraz 3 innych odgałęzień)* |
| `[93]` | **""Watch your words, Mrs. Morgna.""** | `[69]` **Nia Morgna**: ""It is the Old Guard that are di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCou...` | `[13]` **Player**: ""There's nothing else.""<br>`[58]` **Player**: ""What about Justice Edmonds? Doe..."<br>*(oraz 3 innych odgałęzień)* |
| `[94]` | **""I'm sorry to hear that you feel this way.""** | `[69]` **Nia Morgna**: ""It is the Old Guard that are di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCou...` | `[13]` **Player**: ""There's nothing else.""<br>`[58]` **Player**: ""What about Justice Edmonds? Doe..."<br>*(oraz 3 innych odgałęzień)* |
| `[103]` | **""We won the vote. That might have changed their minds.""** | `[102]` **Nia Morgna**: ""The Old Guards were fanatically..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Nia Morgna**: ""Maybe..."" |
| `[105]` | **""So the problem is not the Old Guards but you...""** | `[102]` **Nia Morgna**: ""The Old Guards were fanatically..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Nia Morgna**: ""I thought we've been through th..." |

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
  - -> `[3]` (*Nia Morgna: ""I'm sure he also pressured the Justices of the Court aga..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Nia Morgna: ""I thought we've been through this.""*)

### Węzeł `[3]`
Mówca: **Nia Morgna**
> ""I'm sure he also pressured the Justices of the Court against your proposal right after that win. I hate to be on his side but I don't agree with your proposal either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Nia Morgna: ""You call this proposal *democratic*, but we know it's a ..."*)

### Węzeł `[4]`
Mówca: **Nia Morgna**
> ""You call this proposal *democratic*, but we know it's a power grab, Mr. President. I'm only doing this out of respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Nia Morgna: ""I've organized this meeting because I am still a part of..."*)

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""I've organized this meeting because I am still a part of the cabinet. Consider this a favour from my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""Thank you Mrs. Morgna. This means a lot.""*)
  - -> `[86]` (*Player: ""Are you saying that you will vote against the proposal?""*)
  - -> `[87]` (*Player: ""I'm disappointed, Mrs. Morgna. I thought I'd be able to ..."*)

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""Lucian and Petr believe that he can be persuaded too. Whatever you do, I am not with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""What about Heron?""]** — Mówca: **Player**
> ""What about Heron?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Nia Morgna), `[102]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Nia Morgna: ""Oh, now you want to cooperate with the Old Guards, after..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""We won the vote. I can still persuade Orso.""]** — Mówca: **Player**
> ""We won the vote. I can still persuade Orso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Nia Morgna: ""He's not willing to talk. I doubt you can do anything ab..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Mrs. Morgna. Don't do this. I need your vote.""]** — Mówca: **Player**
> ""Mrs. Morgna. Don't do this. I need your vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Nia Morgna: ""I thought we've been through this.""*)

### Węzeł `[10]`
Mówca: **Nia Morgna**
> ""I thought we've been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[11]`
Mówca: **Nia Morgna**
> ""Well, I'm not helping with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Nia Morgna: ""Your openness to talk to Heron is already showing me you..."*)

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""He's not willing to talk. I doubt you can do anything about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""There's nothing else.""]** — Mówca: **Player**
> ""There's nothing else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Nia Morgna), `[6]` (Nia Morgna), `[10]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Nia Morgna: ""Fine.""*)

### Węzeł `[14]`
Mówca: **Nia Morgna**
> ""Oh, now you want to cooperate with the Old Guards, after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Nia Morgna: ""Lucian and Petr believe that he can be persuaded too. Wh..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Thank you for your efforts with the Anti-corruption police.""]** — Mówca: **Player**
> ""Thank you for your efforts with the Anti-corruption police.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Nia Morgna: ""Thank you for signing the order, Mr. President. But do n..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubOpposition]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "NiaHubOpposition"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubOpposition]"*)

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""He's doing his best to organize the Court against your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[20]`
Mówca: **Nia Morgna**
> ""I guess we have... maybe 5 minutes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[21]`
Mówca: **Nia Morgna**
> ""Thank you for signing the order, Mr. President. But do not think that the force is a political tool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""I won't let their efforts be exploited.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubOpposition]"*)

### Węzeł `[23]`
Mówca: **Nia Morgna**
> ""She's certainly open to dialogue but also sceptical. She seemed to be scared of a potential purge against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""Interesting. Maybe I should play into that.""*)
  - -> `[28]` (*Player: ""We can find common ground against the Old Guard.""*)
  - -> `[30]` (*Player: ""So, you think she's scared of us?""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Interesting. Maybe I should play into that.""]** — Mówca: **Player**
> ""Interesting. Maybe I should play into that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""Do whatever you want, Mr. President. Isabel might be fee..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHu..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""When will Isabel be here?""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B == true && BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We can find common ground against the Old Guard.""]** — Mówca: **Player**
> ""We can find common ground against the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""Their weakest link is Heron, but the rest are unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Nobody is unbreakable.""*)
  - -> `[38]` (*Player: ""We need to talk to Heron, then.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""So, you think she's scared of us?""]** — Mówca: **Player**
> ""So, you think she's scared of us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Nia Morgna: ""She's not entirely scared about the situation, but then ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""When will Isabel be here?""]** — Mówca: **Player**
> ""When will Isabel be here?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true  and  Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Nia Morgna), `[10]` (Nia Morgna), `[12]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She looked at her watch."*)

### Węzeł `[32]`
Mówca: **Nia Morgna**
> ""She's not entirely scared about the situation, but then again, none of the court even believed that you would succeed in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She looked at her watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Nia Morgna: ""I guess we have... maybe 5 minutes?""*)

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Maybe she's feeling the pressure now. But in any case, you'll discover that soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Having common enemies doesn't always result in an alliance. As you know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHubOpposition`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[13]` (*Player: ""There's nothing else.""*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Do whatever you want, Mr. President. Isabel might be feeling the pressure after the vote, but she's not a weak woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""We need to talk to Heron, then.""]** — Mówca: **Player**
> ""We need to talk to Heron, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Nia Morgna: ""Well, I'm not helping with that.""*)

### Węzeł `[39]`
Mówca: **Nia Morgna**
> ""But there's huge pressure on them. The Anti-corruption force has found incriminating evidence against some of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Nia Morgna: ""Although they have immunity, they are scared that these ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Nia Morgna: ""But there's huge pressure on them. The Anti-corruption f..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Nia Morgna: ""Their weakest link is Heron, but the rest are unbreakable.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubOpposition]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "NiaHubOpposition"*)

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""You still need six votes from somewhere. Isabel can potentially bring two to three votes, that's why she's your ticket. But I doubt it will work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""What is the atmosphere in the Court?""]** — Mówca: **Player**
> ""What is the atmosphere in the Court?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_B"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Nia Morgna), `[6]` (Nia Morgna), `[10]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Nia Morgna: ""Most Justices don't really talk when I'm around. They do..."*)

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""The Old Guards are fanatically opposing your proposal too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""What about Heron?""*)
  - -> `[8]` (*Player: ""We won the vote. I can still persuade Orso.""*)
  - -> `[9]` (*Player: ""Mrs. Morgna. Don't do this. I need your vote.""*)

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
  - -> `[70]` (*Player: ""What has Orso been doing?""*)

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
  - -> `[58]` (*Player: ""What about Justice Edmonds? Does she share your views?""*)

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
Mówca: **Nia Morgna**
> ""You are right, but where's the breaking point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Nia Morgna: ""These old men have a pride as vast as Merkopa, they're n..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubOpposition]"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What about Justice Edmonds? Does she share your views?""]** — Mówca: **Player**
> ""What about Justice Edmonds? Does she share your views?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_A"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Nia Morgna), `[6]` (Nia Morgna), `[10]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Nia Morgna: ""Somewhat, yes. We are not ideologically entirely aligned..."*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""She's not openly protesting against the Old Guards but she has told me about her concerns about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Nia Morgna: ""She's certainly open to dialogue but also sceptical. She..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Nia Morgna: ""She must also be under pressure after the anti-corruptio..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: ""Maybe she's feeling the pressure now. But in any case, y..."*)

### Węzeł `[63]`
Mówca: **Nia Morgna**
> ""Your openness to talk to Heron is already showing me your true intentions...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[64]`
Mówca: **Nia Morgna**
> ""Somewhat, yes. We are not ideologically entirely aligned but she's still someone who has a sense of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""She's not openly protesting against the Old Guards but s..."*)

### Węzeł `[65]`
Mówca: **Nia Morgna**
> ""She must also be under pressure after the anti-corruption police's raids against her fellow colleagues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We have to keep up the pressure.""]** — Mówca: **Player**
> ""We have to keep up the pressure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Nia Morgna: ""The investigations are still going, Mr. President. The p..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Nobody is unbreakable.""]** — Mówca: **Player**
> ""Nobody is unbreakable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Nia Morgna: ""You are right, but where's the breaking point?""*)

### Węzeł `[68]`
Mówca: **Nia Morgna**
> ""Although they have immunity, they are scared that these would go public. You might have already gained a few more votes in the Court but I'm not sure more Old Guards would jump on the same wagon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[15]` (*Player: ""Thank you for your efforts with the Anti-corruption poli..."*)
  - -> `[71]` (*Player: ""Good. The whole Court must finally learn to back down.""*)
  - -> `[66]` (*Player: ""We have to keep up the pressure.""*)

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""It is the Old Guard that are disrespecting their positions. You cannot bring down the Court. With all due respect, it is the *President* who needs to *finally learn to back down*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""Watch your words, Mrs. Morgna.""*)
  - -> `[92]` (*Player: ""It is a battle that I will win. Yes.""*)
  - -> `[94]` (*Player: ""I'm sorry to hear that you feel this way.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""What has Orso been doing?""]** — Mówca: **Player**
> ""What has Orso been doing?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_C"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Nia Morgna), `[6]` (Nia Morgna), `[10]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Nia Morgna: ""He's doing his best to organize the Court against your p..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Good. The whole Court must finally learn to back down.""]** — Mówca: **Player**
> ""Good. The whole Court must finally learn to back down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Nia Morgna: ""Is this a battle against the Court, Mr. President?""*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""I won't let their efforts be exploited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""I only know about the two Justices I've mentioned earlier who are with me. So we have three votes there. Against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Nia Morgna: ""You still need six votes from somewhere. Isabel can pote..."*)

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""Is this a battle against the Court, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Nia Morgna: ""It is the Old Guard that are disrespecting their positio..."*)

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""These old men have a pride as vast as Merkopa, they're not easy to break. And... This is not a game, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""They can keep relying on their immunity. Soon, we will b..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Nia Morgna**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""They can keep relying on their immunity. Soon, we will be able to impeach them.""]** — Mówca: **Player**
> ""They can keep relying on their immunity. Soon, we will be able to impeach them.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Nia Morgna: ""With the ongoing investigations of the anti-corruption f..."*)

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""The investigations are still going, Mr. President. The pressure will build up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""With the ongoing investigations of the anti-corruption force, I'm sure we will have a strong position against most of the Old Guards regarding their impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Nia Morgna: ""But I still think it was not the right decision to add t..."*)

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""Most Justices don't really talk when I'm around. They don't trust me as I'm an outside member of the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""I only know about the two Justices I've mentioned earlie..."*)

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""But I still think it was not the right decision to add that to the proposal. This might pressure the future Courts to always be in line with the fear of being displaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Nia Morgna: ""Anyway...""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Thank you Mrs. Morgna. This means a lot.""]** — Mówca: **Player**
> ""Thank you Mrs. Morgna. This means a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Nia Morgna: ""It should, Mr. President. I'm aiding you against what I ..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Are you saying that you will vote against the proposal?""]** — Mówca: **Player**
> ""Are you saying that you will vote against the proposal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Nia Morgna: ""I believe my position was clear from the beginning.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I'm disappointed, Mrs. Morgna. I thought I'd be able to change your mind.""]** — Mówca: **Player**
> ""I'm disappointed, Mrs. Morgna. I thought I'd be able to change your mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Nia Morgna: ""I believe my position was clear from the beginning.""*)

### Węzeł `[88]`
Mówca: **Nia Morgna**
> ""I believe my position was clear from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Nia Morgna: ""But anyway... Let me know if there's something else... I..."*)

### Węzeł `[89]`
Mówca: **Nia Morgna**
> ""It should, Mr. President. I'm aiding you against what I believe in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""Of course, that won't stop me from doing what I can to m..."*)

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Of course, that won't stop me from doing what I can to make it fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Nia Morgna: ""But anyway... Let me know if there's something else... I..."*)

### Węzeł `[91]`
Mówca: **Nia Morgna**
> ""But anyway... Let me know if there's something else... I'd be taking my leave as soon as Mrs. Edmonds gets here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
  - -> `[13]` (*Player: ""There's nothing else.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""It is a battle that I will win. Yes.""]** — Mówca: **Player**
> ""It is a battle that I will win. Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Watch your words, Mrs. Morgna.""]** — Mówca: **Player**
> ""Watch your words, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I'm sorry to hear that you feel this way.""]** — Mówca: **Player**
> ""I'm sorry to hear that you feel this way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Nia Morgna: ""Having common enemies doesn't always result in an allian..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Having common enemies doesn't always result in an allian..."*)

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""Having common enemies doesn't always result in an alliance. But I doubt that they are really your *enemies.*"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Nia Morgna: ""The Old Guards were fanatically opposing any constitutio..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Nia Morgna: ""The Old Guards are fanatically opposing your proposal too.""*)

### Węzeł `[102]`
Mówca: **Nia Morgna**
> ""The Old Guards were fanatically opposing any constitutional changes. But I think they are not that discontent anymore... Since you are protecting the status quo...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""What about Heron?""*)
  - -> `[103]` (*Player: ""We won the vote. That might have changed their minds.""*)
  - -> `[105]` (*Player: ""So the problem is not the Old Guards but you...""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""We won the vote. That might have changed their minds.""]** — Mówca: **Player**
> ""We won the vote. That might have changed their minds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Nia Morgna: ""Maybe...""*)

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""Maybe...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""So the problem is not the Old Guards but you...""]** — Mówca: **Player**
> ""So the problem is not the Old Guards but you...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""I thought we've been through this. I organized a meeting..."*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""I thought we've been through this. I organized a meeting for you, didn't I? Don't even try to attack me with that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Reformist_ConvinceCourt_NiaHub_..."*)
