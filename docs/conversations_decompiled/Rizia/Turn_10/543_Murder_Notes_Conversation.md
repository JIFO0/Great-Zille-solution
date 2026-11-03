# Rizia/Turn 10/Murder Notes/Murder Notes Conversation

- **ID konwersacji:** `543`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/543_Murder_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 80
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[17]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion"); ;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Titus Gordion**
> "“Actually, there is, in fact, a matter that requires your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[4]`
Mówca: **Titus Gordion**
> "Government facilities in a handful of smaller towns have been seized, sparking street riots as citizens demand change. The situation has escalated far beyond calling it mere unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[44]`
  - -> `[5]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well, then what would you call it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Titus Gordion**
> "“I'd call it, a revolution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Titus Gordion**
> "“Or at the very least, the makings of one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[28]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Titus, I think you're blowing this out of proportion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Titus Gordion**
> "“I can assure you, I'm not. We’re seeing a turning point that we can no longer ignore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Titus Gordion**
> "“I've already made arrangements for myself in case this worst-case scenario comes to pass, and advise you to do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""A storm is coming, Your Majesty. There's no doubt about it. How you prepare for it is up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[38]`
  - -> `[12]`
  - -> `[40]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your concern is duly noted, Captain. However, I have weathered many storms in my time as king, and I will not falter now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus > 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus > 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Titus > 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] > 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Titus Gordion**
> ""The ongoing protests we've been seeing have taken a significant turn for the worse, escalating across the entire kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Titus Gordion**
> "“Actually, there is a matter that may require your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Titus Gordion**
> ""I've been receiving anonymous tips and warnings from informants within the court and from sources outside the kingdom who speak of growing discontent with the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Discontent? From within our own court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see... It seems trust is becoming a rare commodity these days. What else can you tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't tolerate betrayal from within my own court. Can you tell me who these traitor are? We need to get to the bottom of this treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""Yes, sir. These sources hint at potential changes in leadership, but don't disclose which noble houses are involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Anonymous sources... unnamed noble houses... Sorry, but I don't take cryptically vague threats very seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is troubling news. Continue to gather any and all information that you can, Titus. We must stay vigilant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Titus Gordion**
> ""It's a matter not to be taken lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[28]`
  - -> `[27]`
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Titus Gordion**
> ""From what I've gathered, my sources hint at potential changes in leadership, but don't disclose which noble houses are involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Titus Gordion**
> "My informants haven't disclosed the specific noble houses involved -- rather, they've only mentioned a growing discussion about a potential leadership change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""This may not sound like much, but I can assure you that my informants are reliable, and what they've uncovered shouldn't be taken lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[28]`
  - -> `[27]`
  - -> `[33]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like someone's been reading too many spy thrillers. But in all seriousness, if there's even a hint of truth to these whispers, we must act swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Titus Gordion**
> ""Yes, sir. Before I go, I would be remiss if I didn't inform you that I've already made arrangements for myself in case this worst-case scenario comes to pass, and would advise you to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[35]`
Mówca: **Titus Gordion**
> "“I assure you, this threat is very real. We’re seeing a turning point that we can no longer ignore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[36]`
Mówca: **Titus Gordion**
> "Very well. But before I go, I would be remiss if I didn't inform you that I've already made arrangements for myself in case this worst-case scenario comes to pass, and would advise you to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for the weather report, Titus. I'll make sure to pack an umbrella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I didn't ask for unsolicited advice. You're excused, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, Titus. I'll take it into consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Funny you should mention it... it just so happens that I took the liberty of inviting Lucita to meet us for that very purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "He checked his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Titus Gordion**
> ""And, actually, should be arriving any minute--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Titus Gordion**
> ""And speaking of unexpected revelations, there's someone here who can hopefully shed some light on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Titus Gordion**
> ""Well, if you don't believe me, then maybe you'll believe what Lucita has to say for herself, who I invited here and should be arriving shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Titus Gordion**
> ""I'm glad you brought that up because that brings up another matter that deserves your immediate attention.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[54]`
Mówca: **Narrator**
> ""I felt compelled to share with you the findings of our investigation into your uncle and Grand Vizier, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> ""It all began with eyewitness accounts, including my own, placing Hugo exiting the late King’s private chambers just before his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> ""There's been a lingering conspiracy theory surrounding Hugo, suggesting he sees himself as the rightful king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> ""This alone provided a motive for suspicion, not to mention the rumored bitter rivalry between them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> ""However, as I delved deeper, I uncovered a surprising truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> ""Hugo and King Valero shared a close bond, evident through their correspondence and numerous testimonials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> ""There was no evidence of Hugo aspiring to claim the throne. The supposed rivalry was a mere fiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> ""Regarding the night of Valero’s demise, I found no traces linking Hugo to any murder weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Narrator**
> ""When the late king was exhumed, a preserved sample of formalin-fixed tissue allowed for an advanced toxicology examination by Iza University's laboratories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> ""You might be surprised to learn that traces of Mandragora -- a deadly nightshade --were found in the late king's system during a recent toxicology test.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[64]`
Mówca: **Narrator**
> ""However, despite our exhaustive efforts, there's no evidence linking Hugo to the possession or acquisition of such a poison. It appears to be a case of him being at the wrong place at the wrong time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> ""I hope this information proves useful to you, Your Majesty, as you continue to seek answers and closure regarding your father's untimely passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Narrator**
> ""I must bring to your attention the progress made in our investigation concerning Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> ""While our efforts yielded significant findings, they only extended as far as the toxicology report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> ""Initially, suspicions were raised due to the presence of Mandragora—a lethal nightshade—in your father's toxicology report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> ""However, we were unable to uncover any tangible evidence linking Lucita to the acquisition or possession of such a poison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[70]`
Mówca: **Narrator**
> ""Respectfully,

Captain Titus Gordion""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[74]`
Mówca: **Narrator**
> ""I felt compelled to share with you the findings of our investigation into your uncle and former Grand Vizier, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[75]`
Mówca: **Narrator**
> ""Sincerely, 

Captain Titus Gordion""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Narrator**
> ""Despite our thorough investigation, we were unable to uncover any further leads or evidence implicating Lucita in the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> ""I trust this information sheds some light on the ongoing investigation, and I remain committed to assisting you in any way possible to bring closure to this troubling ordeal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
