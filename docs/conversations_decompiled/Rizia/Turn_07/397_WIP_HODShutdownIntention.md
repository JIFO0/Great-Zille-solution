# Rizia/Turn 7/WIP_HODShutdownIntention

- **ID konwersacji:** `397`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/397_WIP_HODShutdownIntention.md`
- **Liczba węzłów dialogowych:** 59
- **Liczba wyborów gracza:** 12

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Religion_Leaning_Theocratic`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLCIsolated.Turn07_Hugo_Informal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Turn07_Intention_HODShutdown`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[153]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[183]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[1502]`
- Węzeł `[2]` -> **[395] Rizia/Turn 7/A_HugoManusPrivateTalk** (../Turn_07/395_A_HugoManusPrivateTalk.md), Węzeł `[1506]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[58]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn07_Intention_HODShutdown"] = true;`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `395` (*Rizia/Turn 7/A_HugoManusPrivateTalk*), Węzeł `[153]`
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `395` (*Rizia/Turn 7/A_HugoManusPrivateTalk*), Węzeł `[183]`
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `395` (*Rizia/Turn 7/A_HugoManusPrivateTalk*), Węzeł `[1502]`
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `395` (*Rizia/Turn 7/A_HugoManusPrivateTalk*), Węzeł `[1506]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Hugo scrutinized me very closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""Romus. What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[15]`
  - -> `[14]`
  - -> `[16]`
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Hugo_Informal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Hugo_Informal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Hugo_Informal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Hugo_Informal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Hugo_Informal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Your Majesty. What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[15]`
  - -> `[14]`
  - -> `[16]`
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a fine experiment. But I believe the time has come to put a stop to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a vision, Hugo. Of a Rizia led only by the most devout and pure of heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religion_Leaning_Theocratic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religion_Leaning_Theocratic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religion_Leaning_Theocratic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a waste of resources. My council advises me on lawmaking. I don't need a building full of useless bureaucrats doing the same thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even assuming we can control Manus, some other young hothead might try to warp the HOD to his or her own ends. It's too dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a mistake to make it easier to elect commoners. I don't want their heads getting too big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sazon and the other noble houses should stick to their provinces. They don't need a say in the federal government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""You do have a point...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Hugo mulled it over for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""A waste indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""Nor do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""I take it you've been consulting with the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""If you eliminate the House of Delegates as an institution, there will certainly be a backlash. Both at home and abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""And the reformists who've recently been elected may turn to more dangerous outlets if this one is taken away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""The nobles who hold seats in the House of Delegates have also gotten quite used to their positions, and the salaries and perks that come with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> """If you command enough respect in the capital, you may be able to get away with it. But not overnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[43]`
  - -> `[48]`
  - -> `[53]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority > 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority > 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] > 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority > 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] > 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Hugo Toras**
> ""If you command enough respect in the capital, you may be able to get away with it. But frankly put, you're currently at a disadvantage in that regard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[43]`
  - -> `[48]`
  - -> `[45]`
  - -> `[53]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I knew someone with connections among commoners and nobles alike? Someone with experience greasing the wheels in the capital?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""I'd imagine such a person could be very helpful. But you have to be careful about what you promise them in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. I'll give it some more thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This has been my goal since I took the throne. And I will stop at nothing to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't say. Even my own uncle disrespects me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll let go of this for now. Winning the war is more important than consolidating my power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I hold you in the highest esteem. It's why I tell you the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""When the time comes, you shall have my full backing. As always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""At any rate, if you do shut down the House of Delegates, Manus Sazon will be one of your greatest opponents. So I strongly suggest we figure out what to do with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Perhaps you'll win it more easily without a chorus of dissent in your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll let go of this for now. There are more important things than consolidating my power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn07_Intention_HODShutdown = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn07_Intention_HODShutdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
