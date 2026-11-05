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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""I will be honest with you. I'm considering reforming the Rizian government.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[21]` **Narrator**: "Vina opened her mouth in shock."<br>`[22]` **Narrator**: "Surprise flashed across Hugo's f..." |
| `[10]` | **""No, that will be all.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Hugo Toras**: ""Very good."" |
| `[11]` | **""Your Grace, I feel the situation as you've just described it leaves me with limit..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[12]` **Narrator**: "Vina's eyes widened in shock. Hu..."<br>`[16]` **Narrator**: "Surprise registered on Hugo's fa..." |
| `[25]` | **""This wouldn't be for me. I want to pave the way for Vina and all of her descenden..."** | `[29]` **Hugo Toras**: ""Ultimately, though, the Crown e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "Vina looked askance at me, but s..."<br>`[54]` **Narrator**: "Hugo gave an approving nod." |
| `[26]` | **""How do you know support is high? Anyone could be plotting anything at any time. I..."** | `[29]` **Hugo Toras**: ""Ultimately, though, the Crown e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Hugo Toras**: ""I have my ear to the ground. Th..." |
| `[27]` | **""You're right. I'm better off keeping things as they are.""** | `[29]` **Hugo Toras**: ""Ultimately, though, the Crown e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "My uncle arched an eyebrow." |
| `[37]` | **""Let's just forget I asked this question.""** | `[35]` **Hugo Toras**: ""What's more, the nobility would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "Hugo looked unsatisfied." |
| `[38]` | **""A major shake-up is not what I had in mind. I only want a few small tweaks here a..."** | `[35]` **Hugo Toras**: ""What's more, the nobility would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Hugo Toras**: ""Hmm. Such a strategy could paci..." |
| `[40]` | **""Thank you for your opinion. I'll keep it in mind.""** | `[35]` **Hugo Toras**: ""What's more, the nobility would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Hugo looked unsatisfied." |
| `[43]` | **""A more democratic Rizia would benefit all of us. Citizens and nobles alike.""** | `[35]` **Hugo Toras**: ""What's more, the nobility would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Hugo firmly pressed his hands on..." |
| `[62]` | **""But I fear that Rizia is straying from its Wruhecist roots. Only I can restore re..."** | `[29]` **Hugo Toras**: ""Ultimately, though, the Crown e..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""I see..."" |
| `[63]` | **""The measures I intend to implement are necessary, but they won't be popular. I wa..."** | `[29]` **Hugo Toras**: ""Ultimately, though, the Crown e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Hugo Toras**: ""It is true that the nobles in t..." |
| `[70]` | **""I worry the modern era may bring unwanted change to Rizia. All I've ever wanted w..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "I saw sympathy in Hugo's eyes." |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_StatusQuo == true"*)
  - -> `[10]` (*Player_Romus: ""No, that will be all.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. I'm considering reforming the Rizian government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 2"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Your Grace, I feel the situation as you've just describe..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus: ""I will be honest with you. I'm considering reforming the..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, that will be all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""Very good.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Grace, I feel the situation as you've just described it leaves me with limited power over my own kingdom. I wish to reign unchallenged by the House of Delegates or any of the noble families.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 2; RiziaDLC.PersonalV..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Vina's eyes widened in shock. Hugo appeared unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""You've hit upon an interesting point, Romus.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Vina's eyes widened in shock. Hugo appeared unfazed."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Surprise registered on Hugo's face, but only for a second..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Surprise registered on Hugo's face, but only for a second. He stroked his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""You've hit upon an interesting point, Romus.""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""You've hit upon an interesting point, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""I myself have often wondered whether Rizia would be stro..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Vina opened her mouth in shock."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Surprise flashed across Hugo's face, but only for a second."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Vina opened her mouth in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""I hope you don't have any drastic changes in mind, Romus.""*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Surprise flashed across Hugo's face, but only for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""I hope you don't have any drastic changes in mind, Romus.""*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I hope you don't have any drastic changes in mind, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""The RPP may try to claim otherwise, but the citizens of ..."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""The RPP may try to claim otherwise, but the citizens of Rizia hardly hunger for reform. The majority are perfectly satisfied with things as they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This wouldn't be for me. I want to pave the way for Vina and all of her descendents.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know support is high? Anyone could be plotting anything at any time. It unsettles me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""I have my ear to the ground. The only potential sources ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I'm better off keeping things as they are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "My uncle arched an eyebrow."*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""I myself have often wondered whether Rizia would be stronger were it wholly united under the banner of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""Ultimately, though, the Crown enjoys high support among ..."*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""Ultimately, though, the Crown enjoys high support among both the Delegates and the noble houses. I fear any attempt to defang them will lead to more strife than it is worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""This wouldn't be for me. I want to pave the way for Vina..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[63]` (*Player_Romus: ""The measures I intend to implement are necessary, but th..."*)
  - -> `[26]` (*Player_Romus: ""How do you know support is high? Anyone could be plottin..."*)
  - -> `[27]` (*Player_Romus: ""You're right. I'm better off keeping things as they are.""*)

### Węzeł `[30]`
Mówca: **Vina Toras**
> ""Do you know that for sure, Uncle Hugo? Our only information source is the Royal Herald, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""I have my ear to the ground. Any potential sources of di..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Vina's nose wrinkled."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""What's more, the nobility would never tolerate such a ma..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Vina's nose wrinkled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Vina Toras: ""Do you know that for sure, Uncle Hugo? Our only informat..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""What's more, the nobility would never tolerate such a major shake-up. Why, it was all Valero could do to get them to accept the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""Thank you for your opinion. I'll keep it in mind.""*)
  - -> `[43]` (*Player_Romus: ""A more democratic Rizia would benefit all of us. Citizen..."*)
  - -> `[38]` (*Player_Romus: ""A major shake-up is not what I had in mind. I only want ..."*)
  - -> `[37]` (*Player_Romus: ""Let's just forget I asked this question.""*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""I have my ear to the ground. Any potential sources of discontent are the ones I've already mentioned. Hardly worth rearranging the government for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""What's more, the nobility would never tolerate such a ma..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's just forget I asked this question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Hugo looked unsatisfied."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A major shake-up is not what I had in mind. I only want a few small tweaks here and there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""Hmm. Such a strategy could pacify would-be reformists wi..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Hugo firmly pressed his hands on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""As king, you can directly make Rizians' lives better wit..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your opinion. I'll keep it in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Hugo looked unsatisfied."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Hugo looked unsatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""Please do.""*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He took one last curious look at me before brightening up."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A more democratic Rizia would benefit all of us. Citizens and nobles alike.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Hugo firmly pressed his hands on the table."*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""As king, you can directly make Rizians' lives better with the stroke of a pen. I don't see why anyone would trade that for populism and infighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He took one last curious look at me before brightening up."*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""The best advice I can give you is to proceed gradually. Else you risk hurting the very citizens you wish to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He took one last curious look at me before brightening up."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Hugo looked unsatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""Very well.""*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He took one last curious look at me before brightening up."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Vina looked askance at me, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""I completely understand the impulse. But upset the balan..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""I have my ear to the ground. The only potential sources of discontent are the ones I already mentioned. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""Please trust that I will come to you if the situation ch..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina looked askance at me, but said nothing."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Hugo gave an approving nod."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Hugo gave an approving nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""I completely understand the impulse. But upset the balan..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I completely understand the impulse. But upset the balance of power too suddenly, and your path will be far from smooth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""There is nothing stopping you from passing laws aimed at..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""There is nothing stopping you from passing laws aimed at centralization. But it must be done with the utmost of sensitivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""Unless any of the houses pose an immediate threat, of co..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "My uncle arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""If it appears that any of the houses are about to pose a..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""If it appears that any of the houses are about to pose a threat -- well, then we can have this conversation again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He was pensive for a moment; then, his expression brighte..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""But I fear that Rizia is straying from its Wruhecist roo..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I fear that Rizia is straying from its Wruhecist roots. Only I can restore religious harmony to the kingdom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""I see...""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The measures I intend to implement are necessary, but they won't be popular. I want to make sure they're met with minimal backlash.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""It is true that the nobles in this kingdom often have tr..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: ""In that case, I am sure the religious community will sup..."*)

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""In that case, I am sure the religious community will support you. But Grand Wiseman Ignacius can advise you better than I can on this matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He was pensive for a moment; then, his expression brighte..."*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""It is true that the nobles in this kingdom often have trouble seeing past their own provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""There is nothing stopping you from passing laws aimed at..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 2;
RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 2;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Please trust that I will come to you if the situation changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He was pensive for a moment; then, his expression brighte..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""Unless any of the houses pose an immediate threat, of course. In which case more drastic action would be justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He was pensive for a moment; then, his expression brighte..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I worry the modern era may bring unwanted change to Rizia. All I've ever wanted was to keep things as they are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I saw sympathy in Hugo's eyes."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_StatusQuo == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_StatusQuo == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I worry the modern era may bring unwanted change to Rizi..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_StatusQuo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Narrator**
> "I saw sympathy in Hugo's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""That is perhaps the most challenging duty of a monarch -..."*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""That is perhaps the most challenging duty of a monarch -- to project stability and serenity even amidst the most violent of tempests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""But you are not alone. Have faith in House Toras and the..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""But you are not alone. Have faith in House Toras and the Rizian National Coalition to help you preserve calm and order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""There's also GRACE, right? As long as we're a member, we..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""And do not forget that we are part of a network of monar..."*)

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""There's also GRACE, right? As long as we're a member, we can rely on Rumburg and the others to keep the monarchy strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""Absolutely, Your Highness. Your aunt would never let any..."*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""Absolutely, Your Highness. Your aunt would never let anything get in the way of your future reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention = true"*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""And do not forget that we are part of a network of monarchies. Rumburg and the other members of GRACE have a vested interest in ensuring a smooth reign for you and your descendents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention = true"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "He took one last curious look at me before brightening up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention = true"*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""Hmm. Such a strategy could pacify would-be reformists without ruffling the feathers of those who prefer the status quo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""The best advice I can give you is to proceed gradually. ..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "He was pensive for a moment; then, his expression brightened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention = true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_KnowsIntention = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_KnowsIntention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
