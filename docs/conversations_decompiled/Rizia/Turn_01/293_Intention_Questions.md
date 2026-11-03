# Rizia/Turn 1/Intention Questions

- **ID konwersacji:** `293`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/293_Intention_Questions.md`
- **Liczba węzłów dialogowych:** 88
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Focus_Government_StatusQuo`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_KnowsIntention`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Tyrant`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[291] Rizia/Turn 1/A_TorasPoliticalOverview** (../Turn_01/291_A_TorasPoliticalOverview.md), Węzeł `[307]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 2; ...`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 2;`
- Węzeł `[87]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_KnowsIntention"] = true;`

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
  - -> `[4]`
  - -> `[7]`
  - -> `[71]`
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `291` (*Rizia/Turn 1/A_TorasPoliticalOverview*), Węzeł `[307]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. I'm considering reforming the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, that will be all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Grace, I feel the situation as you've just described it leaves me with limited power over my own kingdom. I wish to reign unchallenged by the House of Delegates or any of the noble families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Vina's eyes widened in shock. Hugo appeared unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Surprise registered on Hugo's face, but only for a second. He stroked his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""You've hit upon an interesting point, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Vina opened her mouth in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Surprise flashed across Hugo's face, but only for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I hope you don't have any drastic changes in mind, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""The RPP may try to claim otherwise, but the citizens of Rizia hardly hunger for reform. The majority are perfectly satisfied with things as they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wouldn't be for me. I want to pave the way for Vina and all of her descendents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know support is high? Anyone could be plotting anything at any time. It unsettles me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I'm better off keeping things as they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""I myself have often wondered whether Rizia would be stronger were it wholly united under the banner of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""Ultimately, though, the Crown enjoys high support among both the Delegates and the noble houses. I fear any attempt to defang them will lead to more strife than it is worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[59]`
  - -> `[63]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Vina Toras**
> ""Do you know that for sure, Uncle Hugo? Our only information source is the Royal Herald, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Vina's nose wrinkled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""What's more, the nobility would never tolerate such a major shake-up. Why, it was all Valero could do to get them to accept the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[43]`
  - -> `[38]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""I have my ear to the ground. Any potential sources of discontent are the ones I've already mentioned. Hardly worth rearranging the government for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's just forget I asked this question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A major shake-up is not what I had in mind. I only want a few small tweaks here and there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Hugo firmly pressed his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your opinion. I'll keep it in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Hugo looked unsatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A more democratic Rizia would benefit all of us. Citizens and nobles alike.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""As king, you can directly make Rizians' lives better with the stroke of a pen. I don't see why anyone would trade that for populism and infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""The best advice I can give you is to proceed gradually. Else you risk hurting the very citizens you wish to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Hugo looked unsatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Vina looked askance at me, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""I have my ear to the ground. The only potential sources of discontent are the ones I already mentioned. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Hugo gave an approving nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I completely understand the impulse. But upset the balance of power too suddenly, and your path will be far from smooth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""There is nothing stopping you from passing laws aimed at centralization. But it must be done with the utmost of sensitivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[57]`
Mówca: **Narrator**
> "My uncle arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""If it appears that any of the houses are about to pose a threat -- well, then we can have this conversation again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I fear that Rizia is straying from its Wruhecist roots. Only I can restore religious harmony to the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The measures I intend to implement are necessary, but they won't be popular. I want to make sure they're met with minimal backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""In that case, I am sure the religious community will support you. But Grand Wiseman Ignacius can advise you better than I can on this matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""It is true that the nobles in this kingdom often have trouble seeing past their own provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 2;
RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 2;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Please trust that I will come to you if the situation changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""Unless any of the houses pose an immediate threat, of course. In which case more drastic action would be justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I worry the modern era may bring unwanted change to Rizia. All I've ever wanted was to keep things as they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_StatusQuo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Narrator**
> "I saw sympathy in Hugo's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""That is perhaps the most challenging duty of a monarch -- to project stability and serenity even amidst the most violent of tempests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""But you are not alone. Have faith in House Toras and the Rizian National Coalition to help you preserve calm and order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""There's also GRACE, right? As long as we're a member, we can rely on Rumburg and the others to keep the monarchy strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""Absolutely, Your Highness. Your aunt would never let anything get in the way of your future reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""And do not forget that we are part of a network of monarchies. Rumburg and the other members of GRACE have a vested interest in ensuring a smooth reign for you and your descendents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[83]`
Mówca: **Narrator**
> "He took one last curious look at me before brightening up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""Hmm. Such a strategy could pacify would-be reformists without ruffling the feathers of those who prefer the status quo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[85]`
Mówca: **Narrator**
> "He was pensive for a moment; then, his expression brightened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_KnowsIntention = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_KnowsIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
