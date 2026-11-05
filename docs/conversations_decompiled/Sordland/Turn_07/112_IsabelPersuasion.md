# Sordland/Turn07/IsabelPersuasion

- **ID konwersacji:** `112`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/112_IsabelPersuasion.md`
- **Liczba węzłów dialogowych:** 193
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Law_Veto_Limited`
- `BaseGame.Reform_Law_Veto_Removed`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[310]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Why?""** | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Isabel Edmonds**: ""What do you mean why? I asked y..." |
| `[19]` | **""The Court protects the Constitution. I would have done the same with my proposal ..."** | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." |
| `[25]` | **""I don't agree with that. I am no Malenyevist.""** | `[41]` **Isabel Edmonds**: ""I don't want to hand a victory ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Isabel Edmonds**: ""So, you're no fan of Malenyev? ..." |
| `[27]` | **""Purely an advisory body for legislation and the high criminal court.""** | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." |
| `[29]` | **""It must have the power of judicial review and to strike down laws that are agains..."** | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." |
| `[32]` | **""No. Even though I'm abolishing his position, he must be respected as the founder ..."** | `[30]` **Isabel Edmonds**: ""Tell me... Are you planning to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[47]` **Isabel Edmonds**: ""I see."" |
| `[33]` | **""I have no such plans. The important thing here is now he will be a regular Sordis..."** | `[30]` **Isabel Edmonds**: ""Tell me... Are you planning to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Isabel Edmonds**: ""I see."" |
| `[34]` | **""Yes. He should be properly investigated and finally answer for his crimes.""** | `[30]` **Isabel Edmonds**: ""Tell me... Are you planning to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[47]` **Isabel Edmonds**: ""I see."" |
| `[36]` | **""The threshold not only affects them but all of us. It can lead to a political cri..."** | `[153]` **Isabel Edmonds**: ""...I still have great concerns...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...`<br>`Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[99]` **Isabel Edmonds**: ""And what about the Assembly? Yo..."<br>`[105]` **Isabel Edmonds**: ""...If I give you the power to i..." |
| `[37]` | **""I am a democratic socialist, Mrs. Edmonds. There is a difference.""** | `[41]` **Isabel Edmonds**: ""I don't want to hand a victory ..." | `Variable["BaseGame.Democratic"] >= 5` | *Brak zmian stanu* | `[178]` **Isabel Edmonds**: ""So what? You're going to tell m..." |
| `[39]` | **""I don't agree with their ideologies, but we must be fair.""** | `[153]` **Isabel Edmonds**: ""...I still have great concerns...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[99]` **Isabel Edmonds**: ""And what about the Assembly? Yo..."<br>`[105]` **Isabel Edmonds**: ""...If I give you the power to i..." |
| `[48]` | **""We can't silence different political opinions anymore, Mrs. Edmonds.""** | `[153]` **Isabel Edmonds**: ""...I still have great concerns...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[99]` **Isabel Edmonds**: ""And what about the Assembly? Yo..."<br>`[105]` **Isabel Edmonds**: ""...If I give you the power to i..." |
| `[57]` | **""You must understand that it is the way forward.""** | `[41]` **Isabel Edmonds**: ""I don't want to hand a victory ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[31]` **Isabel Edmonds**: ""You are playing with fire, Mr. ..." |
| `[62]` | **""I don't agree with that. We are not their puppet.""** | `[81]` **Isabel Edmonds**: ""I am concerned about your heavy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Isabel Edmonds**: ""I didn't say that. But if we're..." |
| `[73]` | **""It gives the Court an abrupt power over other branches.""** | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[167]` **Isabel Edmonds**: ""So you'd rather have no Court, ..." |
| `[74]` | **""Why are you asking me these questions?""** | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Isabel Edmonds**: ""Fine. I am not asking any more ..." |
| `[80]` | **""It plays an essential role in ensuring that each branch of government recognizes ..."** | `[59]` **Isabel Edmonds**: ""So what do you think about the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[147]` **Isabel Edmonds**: ""Precisely."" |
| `[88]` | **""Weren't you for Alphonso's free market reforms? Why are you suddenly against this?""** | `[81]` **Isabel Edmonds**: ""I am concerned about your heavy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Isabel Edmonds**: ""I find the growing Arcasian inf..." |
| `[92]` | **""I have to protect myself after my duty ends too. Sordland is dangerous for presid..."** | `[116]` **Isabel Edmonds**: ""This will also be a huge burden..."<br>`[118]` **Isabel Edmonds**: ""But what about giving yourself ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[78]` **Isabel Edmonds**: ""Yes... Sordland definitely give..." |
| `[93]` | **""I disagree. Soll wasn't any trouble after he resigned. I think we deserve this ti..."** | `[116]` **Isabel Edmonds**: ""This will also be a huge burden..."<br>`[118]` **Isabel Edmonds**: ""But what about giving yourself ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "She coughed." |
| `[94]` | **""Mrs. Edmonds. You are exaggerating it. It's only a symbolic title.""** | `[116]` **Isabel Edmonds**: ""This will also be a huge burden..."<br>`[118]` **Isabel Edmonds**: ""But what about giving yourself ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[77]` **Isabel Edmonds**: ""Right..."" |
| `[95]` | **""We need Arcasia's support as a country. They can be an important ally.""** | `[81]` **Isabel Edmonds**: ""I am concerned about your heavy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Isabel Edmonds**: ""I find the growing Arcasian inf..." |
| `[106]` | **""The President is elected by people and the title should not be taken away by anyo..."** | `[97]` **Isabel Edmonds**: ""The only one who wins here is y..."<br>`[136]` **Isabel Edmonds**: ""And how about you? You are givi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Isabel Edmonds**: ""Even a president who becomes an..." |
| `[107]` | **""There are still checks and balances. They can't go against the Constitution.""** | `[98]` **Isabel Edmonds**: ""Wasn't that even a concern for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Isabel Edmonds**: ""I don't agree."" |
| `[108]` | **""Of course it was a concern. But this is a transition. The future lies in the parl..."** | `[98]` **Isabel Edmonds**: ""Wasn't that even a concern for ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[154]` **Isabel Edmonds**: ""You are an interesting man inde..." |
| `[109]` | **""No it's not. We have to believe in the MP's. The Assembly is our most democratic ..."** | `[98]` **Isabel Edmonds**: ""Wasn't that even a concern for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Isabel Edmonds**: ""Sure, we just need to have *bli..." |
| `[117]` | **""Don't be. We are together in this. This will open the way for further reforms too.""** | `[10]` **Isabel Edmonds**: ""I want the Old Guard gone as mu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." |
| `[128]` | **""As I said before, it is only a safety mechanism for threats like the Old Guard.""** | `[105]` **Isabel Edmonds**: ""...If I give you the power to i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Isabel Edmonds**: ""And how about you? You are givi..."<br>`[134]` **Isabel Edmonds**: ""...I still have great concerns ..."<br>*(oraz 1 innych odgałęzień)* |
| `[135]` | **""Vote yes. There is not much to think.""** | `[10]` **Isabel Edmonds**: ""I want the Old Guard gone as mu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." |
| `[140]` | **""Please, Mrs. Edmonds. We need your help.""** | `[10]` **Isabel Edmonds**: ""I want the Old Guard gone as mu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Isabel Edmonds**: ""Mr. President. I am also wonder..." |
| `[146]` | **""You know Sordish politics, Mrs. Edmonds. We have to protect the presidents. Remem..."** | `[97]` **Isabel Edmonds**: ""The only one who wins here is y..."<br>`[136]` **Isabel Edmonds**: ""And how about you? You are givi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[127]` **Isabel Edmonds**: ""I tried to stop it. But the Chi..." |
| `[148]` | **""I had to protect myself from all the backlash from changing Soll's Constitution.""** | `[97]` **Isabel Edmonds**: ""The only one who wins here is y..."<br>`[136]` **Isabel Edmonds**: ""And how about you? You are givi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Isabel Edmonds**: ""But what about giving yourself ..."<br>`[7]` **Narrator**: "She took a sip from her glass."<br>*(oraz 2 innych odgałęzień)* |
| `[152]` | **""You have nothing to worry about. The Justices cannot be impeached so easily.""** | `[105]` **Isabel Edmonds**: ""...If I give you the power to i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Isabel Edmonds**: ""And how about you? You are givi..."<br>`[134]` **Isabel Edmonds**: ""...I still have great concerns ..."<br>*(oraz 1 innych odgałęzień)* |
| `[155]` | **""I promise, Mrs. Edmonds. Centrists will have nothing to worry about. You have my ..."** | `[105]` **Isabel Edmonds**: ""...If I give you the power to i..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[136]` **Isabel Edmonds**: ""And how about you? You are givi..."<br>`[134]` **Isabel Edmonds**: ""...I still have great concerns ..." |
| `[176]` | **""Malenyev isn't the only communist theoretician, Mrs. Edmonds.""** | `[41]` **Isabel Edmonds**: ""I don't want to hand a victory ..." | `(Variable["BaseGame.Democratic"] >= 5) == false` | *Brak zmian stanu* | `[177]` **Isabel Edmonds**: ""So what? You're going to tell m..." |

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
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true && BaseGam..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Isabel Edmonds: ""...I still have great concerns about the removal of the ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[6]`
Mówca: **Isabel Edmonds**
> ""Well... I actually have to say this too. I am really surprised that the proposal is abolishing the member of honor title. I support that part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Isabel Edmonds: ""Tell me... Are you planning to put Soll to trial?""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Isabel Edmonds: ""Well... I actually have to say this too. I am really sur..."*)

### Węzeł `[8]`
Mówca: **Isabel Edmonds**
> ""Sure, we just need to have *blind faith*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""If we were to come back to the point of unifying against the Old Guard...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Isabel Edmonds: ""I want the Old Guard gone as much as you, but I am torn ..."*)

### Węzeł `[10]`
Mówca: **Isabel Edmonds**
> ""I want the Old Guard gone as much as you, but I am torn about this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""Don't be. We are together in this. This will open the wa..."*)
  - -> `[135]` (*Player: ""Vote yes. There is not much to think.""*)
  - -> `[140]` (*Player: ""Please, Mrs. Edmonds. We need your help.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Why?""]** — Mówca: **Player**
> ""Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Isabel Edmonds: ""What do you mean why? I asked you a question.""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Nia suddenly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""If we were to come back to the point of unifying against..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Isabel Edmonds: ""Anyway... At least the proposal introduces term limits. ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Isabel Edmonds: ""Anyway, I don't have much else to say.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""The Court protects the Constitution. I would have done the same with my proposal today.""]** — Mówca: **Player**
> ""The Court protects the Constitution. I would have done the same with my proposal today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Isabel Edmonds: ""So what do you think about the judicial review?""*)

### Węzeł `[20]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Isabel Edmonds: ""Well... I actually have to say this. I am really surpris..."*)

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""Well... I actually have to say this. I am really surprised that you are bringing term limits. That's one good point of the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Isabel Edmonds: ""And what about the Assembly? You are giving them too muc..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I don't agree with that. I am no Malenyevist.""]** — Mówca: **Player**
> ""I don't agree with that. I am no Malenyevist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Isabel Edmonds: ""So, you're no fan of Malenyev? Who cares if you're into ..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Isabel Edmonds: ""Well... At least you are bringing term limits. I guess t..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Purely an advisory body for legislation and the high criminal court.""]** — Mówca: **Player**
> ""Purely an advisory body for legislation and the high criminal court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""Well... At least you are bringing term limits. I guess that's one positive aspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""It must have the power of judicial review and to strike down laws that are against the Constitution.""]** — Mówca: **Player**
> ""It must have the power of judicial review and to strike down laws that are against the Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""Tell me... Are you planning to put Soll to trial?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Yes. He should be properly investigated and finally answ..."*)
  - -> `[33]` (*Player: ""I have no such plans. The important thing here is now he..."*)
  - -> `[32]` (*Player: ""No. Even though I'm abolishing his position, he must be ..."*)

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> ""You are playing with fire, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""No. Even though I'm abolishing his position, he must be respected as the founder of our second republic.""]** — Mówca: **Player**
> ""No. Even though I'm abolishing his position, he must be respected as the founder of our second republic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I have no such plans. The important thing here is now he will be a regular Sordish citizen.""]** — Mówca: **Player**
> ""I have no such plans. The important thing here is now he will be a regular Sordish citizen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Yes. He should be properly investigated and finally answer for his crimes.""]** — Mówca: **Player**
> ""Yes. He should be properly investigated and finally answer for his crimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""The threshold not only affects them but all of us. It can lead to a political crisis in the future.""]** — Mówca: **Player**
> ""The threshold not only affects them but all of us. It can lead to a political crisis in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""I am a democratic socialist, Mrs. Edmonds. There is a difference.""]** — Mówca: **Player**
> ""I am a democratic socialist, Mrs. Edmonds. There is a difference.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Democratic"] >= 5`
- **Kontekst wejściowy (poprzednik):** `[41]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Isabel Edmonds: ""So what? You're going to tell me you pursue Valgslandian..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I don't agree with their ideologies, but we must be fair.""]** — Mówca: **Player**
> ""I don't agree with their ideologies, but we must be fair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Isabel Edmonds: ""I see.""*)

### Węzeł `[41]`
Mówca: **Isabel Edmonds**
> ""I don't want to hand a victory to a Malenyevist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""I don't agree with that. I am no Malenyevist.""*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 5"*)
  - -> `[57]` (*Player: ""You must understand that it is the way forward.""*)

### Węzeł `[42]`
Mówca: **Isabel Edmonds**
> ""Anyway... At least the proposal introduces term limits. I can say that I support that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[43]`
Mówca: **Isabel Edmonds**
> ""These changes are one thing. But there is also your political view...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Isabel Edmonds: ""I don't want to hand a victory to a Malenyevist.""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Isabel Edmonds: ""I also like that the proposal introduces term limits. Th..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Isabel Edmonds: ""Anyway, I don't have much else to say.""*)

### Węzeł `[47]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""We can't silence different political opinions anymore, Mrs. Edmonds.""]** — Mówca: **Player**
> ""We can't silence different political opinions anymore, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Isabel Edmonds: ""So what do you think about the judicial review?""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Isabel Edmonds: ""You are playing with fire, Mr. President.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Isabel Edmonds: ""So what do you think about the judicial review?""*)

### Węzeł `[52]`
Mówca: **Isabel Edmonds**
> ""I also like that the proposal introduces term limits. That's another good point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true || BaseGame..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == true || BaseGa..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Isabel Edmonds: ""...I still have great concerns. This proposal would pave..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Isabel Edmonds: ""Anyway, I don't have much else to say.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""You must understand that it is the way forward.""]** — Mówca: **Player**
> ""You must understand that it is the way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Isabel Edmonds: ""Anyway, I don't have much else to say.""*)

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""So what do you think about the judicial review?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""Why are you asking me these questions?""*)
  - -> `[80]` (*Player: ""It plays an essential role in ensuring that each branch ..."*)
  - -> `[73]` (*Player: ""It gives the Court an abrupt power over other branches.""*)

### Węzeł `[60]`
Mówca: **Isabel Edmonds**
> ""I didn't say that. But if we're not careful, we will become a puppet, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Isabel Edmonds: ""I find the growing Arcasian influence concerning. I supp..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I don't agree with that. We are not their puppet.""]** — Mówca: **Player**
> ""I don't agree with that. We are not their puppet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Isabel Edmonds: ""I didn't say that. But if we're not careful, we will bec..."*)

### Węzeł `[63]`
Mówca: **Isabel Edmonds**
> ""I want to help you, Mrs. Morgna. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true || BaseGame..."*)

### Węzeł `[64]`
Mówca: **Isabel Edmonds**
> ""Anyway, I don't have much else to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[65]`
Mówca: **Nia Morgna**
> ""So, Mrs. Edmonds... What are you thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Isabel Edmonds: ""I want to help you, Mrs. Morgna. But...""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned == true && BaseGam..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromotePlanned == true && BaseG..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true  and  Variable["BaseGame.Malenyevist"] >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Isabel Edmonds: ""These changes are one thing. But there is also your poli..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true  and  Variable["BaseGame.Malenyevist"] >= 17) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true && BaseGame..."*)

### Węzeł `[69]`
Mówca: **Isabel Edmonds**
> ""Anyway, I don't have much else to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true && BaseGame..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromoteMarket == true && BaseGa..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  and  Variable["BaseGame.Capitalist"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Isabel Edmonds: ""These changes are one thing. But you also lead an alarmi..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  and  Variable["BaseGame.Capitalist"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Isabel Edmonds: ""I want the Old Guard gone as much as you, but I am torn ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""It gives the Court an abrupt power over other branches.""]** — Mówca: **Player**
> ""It gives the Court an abrupt power over other branches.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why are you asking me these questions?""]** — Mówca: **Player**
> ""Why are you asking me these questions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Isabel Edmonds: ""Fine. I am not asking any more questions.""*)

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""These changes are one thing. But you also lead an alarming narrative...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Isabel Edmonds: ""I am concerned about your heavy pursuit of capitalism. Y..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Isabel Edmonds: ""Precisely.""*)

### Węzeł `[77]`
Mówca: **Isabel Edmonds**
> ""Right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[78]`
Mówca: **Isabel Edmonds**
> ""Yes... Sordland definitely gives presidents paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Isabel Edmonds: ""So you'd rather have no Court, no balances or checks in ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""It plays an essential role in ensuring that each branch of government recognizes the limits of its own power.""]** — Mówca: **Player**
> ""It plays an essential role in ensuring that each branch of government recognizes the limits of its own power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[81]`
Mówca: **Isabel Edmonds**
> ""I am concerned about your heavy pursuit of capitalism. You are bringing Arcasia's influence to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""I don't agree with that. We are not their puppet.""*)
  - -> `[88]` (*Player: ""Weren't you for Alphonso's free market reforms? Why are ..."*)
  - -> `[95]` (*Player: ""We need Arcasia's support as a country. They can be an i..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "She coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Isabel Edmonds: ""Right...""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Isabel Edmonds: ""Right...""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Isabel Edmonds: ""Yes... Sordland definitely gives presidents paranoia.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Weren't you for Alphonso's free market reforms? Why are you suddenly against this?""]** — Mówca: **Player**
> ""Weren't you for Alphonso's free market reforms? Why are you suddenly against this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Isabel Edmonds: ""I find the growing Arcasian influence concerning. I supp..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""I have to protect myself after my duty ends too. Sordland is dangerous for presidents.""]** — Mówca: **Player**
> ""I have to protect myself after my duty ends too. Sordland is dangerous for presidents.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Isabel Edmonds), `[118]` (Isabel Edmonds), `[119]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I disagree. Soll wasn't any trouble after he resigned. I think we deserve this title.""]** — Mówca: **Player**
> ""I disagree. Soll wasn't any trouble after he resigned. I think we deserve this title.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Isabel Edmonds), `[118]` (Isabel Edmonds), `[119]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "She coughed."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Mrs. Edmonds. You are exaggerating it. It's only a symbolic title.""]** — Mówca: **Player**
> ""Mrs. Edmonds. You are exaggerating it. It's only a symbolic title.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Isabel Edmonds), `[118]` (Isabel Edmonds), `[119]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""We need Arcasia's support as a country. They can be an important ally.""]** — Mówca: **Player**
> ""We need Arcasia's support as a country. They can be an important ally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Isabel Edmonds: ""I find the growing Arcasian influence concerning. I supp..."*)

### Węzeł `[96]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about the Assembly. You are giving them too much power. How can we ensure that they will never go rogue in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Isabel Edmonds: ""Wasn't that even a concern for you?""*)

### Węzeł `[97]`
Mówca: **Isabel Edmonds**
> ""The only one who wins here is you, Mr. President. What are you trying to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""I had to protect myself from all the backlash from chang..."*)
  - -> `[106]` (*Player: ""The President is elected by people and the title should ..."*)
  - -> `[146]` (*Player: ""You know Sordish politics, Mrs. Edmonds. We have to prot..."*)

### Węzeł `[98]`
Mówca: **Isabel Edmonds**
> ""Wasn't that even a concern for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""There are still checks and balances. They can't go again..."*)
  - -> `[108]` (*Player: ""Of course it was a concern. But this is a transition. Th..."*)
  - -> `[109]` (*Player: ""No it's not. We have to believe in the MP's. The Assembl..."*)

### Węzeł `[99]`
Mówca: **Isabel Edmonds**
> ""And what about the Assembly? You are giving them too much power. How can we ensure that they will never go rogue in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Isabel Edmonds: ""Wasn't that even a concern for you?""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Isabel Edmonds: ""...I still have great concerns about the Assembly. You a..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[103]`
Mówca: **Isabel Edmonds**
> ""I find the growing Arcasian influence concerning. I supported the free market reforms earlier but you can't afford to be reckless like Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[104]`
Mówca: **Isabel Edmonds**
> ""What do you mean why? I asked you a question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[105]`
Mówca: **Isabel Edmonds**
> ""...If I give you the power to impeach us today... What's going to happen tomorrow? Can you even give me any guarantees that this will not result in the destruction of the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""As I said before, it is only a safety mechanism for thre..."*)
  - -> `[152]` (*Player: ""You have nothing to worry about. The Justices cannot be ..."*)
  - -> `[155]` (*Player: ""I promise, Mrs. Edmonds. Centrists will have nothing to ..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""The President is elected by people and the title should not be taken away by anyone else.""]** — Mówca: **Player**
> ""The President is elected by people and the title should not be taken away by anyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Isabel Edmonds), `[136]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Isabel Edmonds: ""Even a president who becomes another Tarquin Soll? Would..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""There are still checks and balances. They can't go against the Constitution.""]** — Mówca: **Player**
> ""There are still checks and balances. They can't go against the Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Isabel Edmonds: ""I don't agree.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Of course it was a concern. But this is a transition. The future lies in the parliamentary system.""]** — Mówca: **Player**
> ""Of course it was a concern. But this is a transition. The future lies in the parliamentary system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""No it's not. We have to believe in the MP's. The Assembly is our most democratic branch.""]** — Mówca: **Player**
> ""No it's not. We have to believe in the MP's. The Assembly is our most democratic branch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Isabel Edmonds: ""Sure, we just need to have *blind faith*.""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "She took a sip from her glass."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Isabel Edmonds: ""But what about giving yourself the Member of Honor title..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[116]`
Mówca: **Isabel Edmonds**
> ""This will also be a huge burden on the government to take care of every former President's lavish lifestyles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""Mrs. Edmonds. You are exaggerating it. It's only a symbo..."*)
  - -> `[93]` (*Player: ""I disagree. Soll wasn't any trouble after he resigned. I..."*)
  - -> `[92]` (*Player: ""I have to protect myself after my duty ends too. Sordlan..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Don't be. We are together in this. This will open the way for further reforms too.""]** — Mówca: **Player**
> ""Don't be. We are together in this. This will open the way for further reforms too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[118]`
Mówca: **Isabel Edmonds**
> ""But what about giving yourself the Member of Honor title too? You are clearly playing a dangerous game here, Mr. President. We don't want another king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""Mrs. Edmonds. You are exaggerating it. It's only a symbo..."*)
  - -> `[93]` (*Player: ""I disagree. Soll wasn't any trouble after he resigned. I..."*)
  - -> `[92]` (*Player: ""I have to protect myself after my duty ends too. Sordlan..."*)

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""This will also be a huge burden on the government to take care of every former President's lavish lifestyles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""Mrs. Edmonds. You are exaggerating it. It's only a symbo..."*)
  - -> `[93]` (*Player: ""I disagree. Soll wasn't any trouble after he resigned. I..."*)
  - -> `[92]` (*Player: ""I have to protect myself after my duty ends too. Sordlan..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Isabel Edmonds: ""...If I give you the power to impeach us today... What's..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Isabel Edmonds: ""Let's just forget it and enjoy our meal.""*)

### Węzeł `[124]`
Mówca: **Isabel Edmonds**
> ""I don't agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[125]`
Mówca: **Isabel Edmonds**
> ""Even a president who becomes another Tarquin Soll? Would you be okay if people elected a Malenyev here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Isabel Edmonds: ""I tried to stop it. But the Chief Justice was the puppet..."*)

### Węzeł `[127]`
Mówca: **Isabel Edmonds**
> ""I tried to stop it. But the Chief Justice was the puppet master. Alphonso didn't deserve that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""As I said before, it is only a safety mechanism for threats like the Old Guard.""]** — Mówca: **Player**
> ""As I said before, it is only a safety mechanism for threats like the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[129]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about making every president a member of honor. That title was created for Soll to protect himself. Not only dangerous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Isabel Edmonds: ""This will also be a huge burden on the government to tak..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Isabel Edmonds: ""You are an interesting man indeed, Mr. President.""*)

### Węzeł `[131]`
Mówca: **Isabel Edmonds**
> ""Mr. President. I am also wondering... If you were in Soll's position, how would you have structured the Supreme Court? What do you even believe is its role?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""Purely an advisory body for legislation and the high cri..."*)
  - -> `[29]` (*Player: ""It must have the power of judicial review and to strike ..."*)
  - -> `[19]` (*Player: ""The Court protects the Constitution. I would have done t..."*)
  - -> `[14]` (*Player: ""Why?""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Isabel Edmonds: ""Mr. President. I am also wondering... If you were in Sol..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Isabel Edmonds: ""Mr. President. I am also wondering... If you were in Sol..."*)

### Węzeł `[134]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about making every president a member of honor. That title was created for Soll to protect himself. Not only dangerous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Isabel Edmonds: ""This will also be a huge burden on the government to tak..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Vote yes. There is not much to think.""]** — Mówca: **Player**
> ""Vote yes. There is not much to think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[136]`
Mówca: **Isabel Edmonds**
> ""And how about you? You are giving yourself total immunity... The only one who wins here is you, Mr. President. What are you trying to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""I had to protect myself from all the backlash from chang..."*)
  - -> `[106]` (*Player: ""The President is elected by people and the title should ..."*)
  - -> `[146]` (*Player: ""You know Sordish politics, Mrs. Edmonds. We have to prot..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Isabel Edmonds: ""...If I give you the power to impeach us today... What's..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Please, Mrs. Edmonds. We need your help.""]** — Mówca: **Player**
> ""Please, Mrs. Edmonds. We need your help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Isabel Edmonds: ""Mr. President. I am also wondering... If you were in Sol..."*)

### Węzeł `[141]`
Mówca: **Isabel Edmonds**
> ""Let's just forget it and enjoy our meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Isabel went on to finish the remaining of her salad."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Isabel Edmonds: ""The only one who wins here is you, Mr. President. What a..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Isabel Edmonds: ""...If I give you the power to impeach us today... What's..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""You know Sordish politics, Mrs. Edmonds. We have to protect the presidents. Remember Alphonso?""]** — Mówca: **Player**
> ""You know Sordish politics, Mrs. Edmonds. We have to protect the presidents. Remember Alphonso?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Isabel Edmonds), `[136]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Isabel Edmonds: ""I'm glad that we agree on that.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I had to protect myself from all the backlash from changing Soll's Constitution.""]** — Mówca: **Player**
> ""I had to protect myself from all the backlash from changing Soll's Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Isabel Edmonds), `[136]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Isabel Edmonds: ""...I still have great concerns about making every presid..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""You have nothing to worry about. The Justices cannot be impeached so easily.""]** — Mówca: **Player**
> ""You have nothing to worry about. The Justices cannot be impeached so easily.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[153]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns. This proposal would pave the way for the WPB and the CPS to enter the Assembly... I don't want to be a supporter of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""We can't silence different political opinions anymore, M..."*)
  - -> `[39]` (*Player: ""I don't agree with their ideologies, but we must be fair.""*)
  - -> `[36]` (*Player: ""The threshold not only affects them but all of us. It ca..."*)

### Węzeł `[154]`
Mówca: **Isabel Edmonds**
> ""You are an interesting man indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""I promise, Mrs. Edmonds. Centrists will have nothing to worry about. You have my word.""]** — Mówca: **Player**
> ""I promise, Mrs. Edmonds. Centrists will have nothing to worry about. You have my word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion += 1"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Isabel Edmonds: ""And how about you? You are giving yourself total immunit..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[159]`
Mówca: **Isabel Edmonds**
> ""Let's just forget it and enjoy the remaining of our meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Isabel went on to finish the remaining of her salad."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Isabel went on to finish the remaining of her salad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Isabel Edmonds: ""...I still have great concerns about making every presid..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[164]`
Mówca: **Isabel Edmonds**
> ""I'm glad that we agree on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Isabel went on to finish the remaining of her salad."*)

### Węzeł `[165]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about the removal of the President's impeachment procedure. The President is giving himself total immunity here...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She looked at me."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[167]`
Mówca: **Isabel Edmonds**
> ""So you'd rather have no Court, no balances or checks in our goverment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Isabel Edmonds: ""And how about you? You are giving yourself total immunit..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[171]`
Mówca: **Nia Morgna**
> ""I don't think that's what he meant, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Isabel Edmonds: ""Let's just forget it and enjoy the remaining of our meal.""*)

### Węzeł `[172]`
Mówca: **Isabel Edmonds**
> ""Fine. I am not asking any more questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Isabel Edmonds: ""Let's just forget it and enjoy the remaining of our meal.""*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 5"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic >= 5)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""I am a democratic socialist, Mrs. Edmonds. There is a di..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""Malenyev isn't the only communist theoretician, Mrs. Edm..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Malenyev isn't the only communist theoretician, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Malenyev isn't the only communist theoretician, Mrs. Edmonds.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Democratic"] >= 5) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Isabel Edmonds: ""So what? You're going to tell me you pursue Marco-Raynis..."*)

### Węzeł `[177]`
Mówca: **Isabel Edmonds**
> ""So what? You're going to tell me you pursue Marco-Raynism or something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Isabel Edmonds: ""Who cares if you're into Chancellor Hegel's socialism, o..."*)

### Węzeł `[178]`
Mówca: **Isabel Edmonds**
> ""So what? You're going to tell me you pursue Valgslandian Socialism or something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Isabel Edmonds: ""Who cares if you're into Chancellor Hegel's socialism, o..."*)

### Węzeł `[179]`
Mówca: **Isabel Edmonds**
> ""So, you're no fan of Malenyev? Who cares if you're into Chancellor Hegel's Valgslandian Socialism, or Sordish socialism of Bernard Circas? It's all Karlos Marcia's socio-economics in the end...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Isabel Edmonds: ""You are playing with fire, Mr. President.""*)

### Węzeł `[180]`
Mówca: **Isabel Edmonds**
> ""Who cares if you're into Chancellor Hegel's socialism, or Sordish socialism of Bernard Circas? It's all Karlos Marcia's socio-economics in the end...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Isabel Edmonds: ""You are playing with fire, Mr. President.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "She let out a sigh."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Nia suddenly cut in."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "She let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Isabel Edmonds: ""Anyway... There's no point in discussing this with you a..."*)

### Węzeł `[185]`
Mówca: **Isabel Edmonds**
> ""Anyway... There's no point in discussing this with you at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Isabel Edmonds: ""I want the Old Guard gone as much as you, but I am torn ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Isabel Edmonds: ""Let's just forget it and enjoy the remaining of our meal.""*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Nia Morgna: ""I don't think that's what he meant, Mrs. Edmonds.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true || BaseGame..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Nia Morgna: ""So, Mrs. Edmonds... What are you thinking?""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
