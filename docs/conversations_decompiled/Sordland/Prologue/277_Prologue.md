# Sordland/Prologue

- **ID konwersacji:** `277`
- **StoryPack:** `Sordland`
- **Tura:** `Prologue`
- **Lokalizacja pliku:** `Sordland/Prologue/277_Prologue.md`
- **Liczba węzłów dialogowych:** 297
- **Liczba wyborów gracza:** 137

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_Political_Socialist`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_EasyLife`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Prologue_HardLife`
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Prologue_MinisterOffer_Accepted`
- `BaseGame.Prologue_MinisterOffer_Rejected`
- `BaseGame.Prologue_NormalLife`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Prologue_Protest_Girl_Crushed`
- `BaseGame.Prologue_Speech_Democracy_Conservative`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_1stCoup_Protested`
- `BaseGame.Prologue_University_Group_HumanRights`
- `BaseGame.Prologue_University_Group_PoliticalDebate`
- `BaseGame.Prologue_University_Group_StudentCouncil`
- `BaseGame.Prologue_University_Political_Active`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Prologue_University_SupportWomensRights`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 75

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[24]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] = true;`
- Węzeł `[25]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] = true;`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] = true;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] = true;`
- Węzeł `[29]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] = true;`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Party_Congress_Soll"] = false;`
- Węzeł `[120]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Party_Congress_Soll"] = true;`
- *...oraz 67 innych węzłów ze skryptami.*

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
  - -> `[283]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... a wealthy family in the city of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... a middle-income family in the city of Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... an impoverished family in the city of Deyr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "1908|Kingdom of Sordland"]** — Mówca: **Narrator**
> "You opened your eyes to this world. 

You came from..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[4]`
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a successful businessman, you had the chance to grow up in a wealthy family.

Life was easy at first and you had the best education money could afford. 

However, things inside the Rayne family changed due to the absence of your father. This affected your mother and you negatively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a diligent civil servant, you lived quite an ordinary childhood.

Life was not bad. You were lucky enough to attend a well-known public school.

But frequent fights broke out at the Rayne family home, which made you feel uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a farmer, you spent your childhood among wheat fields.

Life was not easy. You were too poor to afford a good education.

The Rayne family was caring regardless of the economically dire situation. Your parents always did their best to support you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "1923|September 9th"]** — Mówca: **Narrator**
> "During a history class at school, the bell started to ring unexpectedly. You heard a loud commotion outside.

As everyone tried to figure out what was going on, the principal announced the historic revolution. 

The Kingdom was no more. The Republic of Sordland was born."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did not fully understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy that you had the day off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were somewhat worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "1926"]** — Mówca: **Narrator**
> "After graduating, you passed the university exam with high marks.

You had the opportunity to choose between several studies. You chose..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...Law at the Holsord State University."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...Economics at the Lachaven Business School."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...History at the Deyr University of Culture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[18]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained why a market economy is the better option for Sordland.

He argued for a system where prices for goods and services are determined by the open market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[19]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained how the Supreme Court is obstructing justice in Sordland. 

He stated that laws should be applied fairly, and that even the members of the Supreme Court, are subject to the same laws."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[20]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained why Realpolitik is important for a successful foreign policy.

He argued that a strategy based on practical and material factors would be much more successful in reaching Sordland's ambitions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "1927|May 22nd"]** — Mówca: **Narrator**
> "Soldiers entered the campus in the evening ahead of the first election.

Many were in shock as the uniformed men created a security cordon and started arresting the teachers. 

A group of students started gathering in protest. Along with your best friend Petr Vectern, you decided to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...protest with the students."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...avoid any confrontation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[30]`
Mówca: **Narrator**
> "One of the officers made a loud announcement that echoed through the campus.

“General Luderin declared martial law in order to restore the administration. Please stand back and disperse to your rooms.”

You joined the students that slowly marched towards the large group of soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[31]`
Mówca: **Narrator**
> "You heard a loud announcement that echoed through the campus.

“General Luderin declared martial law in order to restore the administration. Please stand back and disperse to your rooms.”

You quickly made your way towards the dormitory, avoiding the scene."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The arrested teachers were replaced by those that promoted conformism to the state.

Holsord turned a blind eye to the things that were happening.

You didn't want to stay idle and decided to join..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The majority of the students and teachers displayed their opposition.

Thus, Lachaven became a target for the military regime.

You didn't want to stay idle and decided to join..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The coup split the students into two groups and caused frequent fights. 

Torture and imprisonment of any opposing voice became a daily routine in Deyr.

You didn't want to stay idle and decided to join..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a political debate group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[45]`
Mówca: **Narrator**
> "A student fell and was trampled as everybody started running away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Narrator**
> "As you entered the room, you heard screams coming from the outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You held your ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to go out to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ran off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Narrator**
> "The soldiers beat you relentlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Unlike the others, you were lucky to escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to bury yourself under the sheets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "But the screams echoed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[54]`
Mówca: **Narrator**
> "But the soldiers locked the doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[55]`
Mówca: **Narrator**
> "The dozens of debates helped you hone your oratory skills while also helping you grow your network.

Even though the discussions between different groups often became heated, you all grew from sharing ideas.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[178]`
  - -> `[130]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The politically charged environment led you to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[200]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...join the Red Youth, the socialists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...join the Young Sords, the nationalists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "1928|June 2nd"]** — Mówca: **Narrator**
> "The radio relayed that the communist general Rikard surrounded Luderin and his troops, demanding their surrender.

They refused and heavy fighting broke out across the country. 

You just couldn't believe it. The army was fighting amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Rikard's sudden attack caused more instability in the country. 

But compared to nationalist Luderin, he was a real socialist.

This convinced you to participate in a support march. You were chanting..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Rikard's sudden attack caused even more bloodshed in the country. 

He seemed different compared to nationalist Luderin. In your opinion however, he was more of the same. 

So you participated in a protest march. You were chanting..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“United we stand, divided we fall!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Freedom, equality and solidarity!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "You were marching under the protection of Rikard's soldiers.

The students supporting Luderin's coup gathered a few hundred meters in front of you. 

Many nationalists were among them. You knew something was going to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[157]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ran to save her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You warned her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Narrator**
> "You were marching against Rikard.

The students and soldiers against Luderin's coup gathered a few hundred meters away.

Many socialists were among them. You knew something was going to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[157]`

### Węzeł `[71]`
Mówca: **Narrator**
> "But you couldn't reach her in time..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[72]`
Mówca: **Narrator**
> "There was a massive clash between the two sides. Soldiers began to beat the students.

Tanks started rolling forward. 

In this chaotic moment, you saw a young girl about to get run over by a tank."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[73]`
Mówca: **Narrator**
> "But all your efforts were in vain..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[74]`
Mówca: **Narrator**
> "The clashes escalated into a full blown civil war. The horrors made you isolate yourself for a while.

Monica helped you cope and love grew between the two of you.

However, it was a difficult time for love."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "1929|Republic of Sordland"]** — Mówca: **Narrator**
> "The charismatic Colonel, Tarquin Soll, orchestrated a sudden attack on the capital where the Luderinist and Rikardist forces were battling each other. He defeated both, ending the war.

A new constitution was written, and the military government began efforts to restore stability. Many people saw the Colonel as a savior. 

He formed the United Sordland Party and ran as a presidential candidate. In the first-ever single-party elections..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...you did not vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "1929|June"]** — Mówca: **Narrator**
> "USP won the election by a large majority. The military government announced a four-year restoration period to transform to an entirely civilian government.

After graduation, you kept seeing Monica. You were both interested in marrying and starting a family.

However, a letter arrived from the military, calling you to fulfill your compulsory service."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "1930|February|Bergia Region"]** — Mówca: **Narrator**
> "The devastating civil war from neighboring Wehlen quickly turned into a proxy war between regional and world powers.

The distinguished major, Iosef Lancea, ordered you to lead your squad on a border patrol mission.

It was a very cold winter night when you began marching out of Gumren Outpost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The years passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your only concern was passing the exams."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did exactly as they said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You could see your breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "After several hours of marching through the snowy hills, distant noises were heard. 

Visibility was too low to confirm the source, so the squad crawled forward in formation and found a spot to observe.

A group of refugees had made it beyond the border fence. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[84]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...let them slip through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...escorted them back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "The refugees were in despair when they realized that you were taking them back to the border.

Screams and protests ensued as they were restrained. You delivered them to the border guards.

After several months of military service..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...your duties ended and you went back to civilian life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "1931|July|Holsord"]** — Mówca: **Narrator**
> "You and Monica decided to share your lives together. After receiving the blessing of her parents, a ceremony was held in Holsord.

During the same year, you were offered a high-paying job within the governing United Sordland Party. 

It was important to start your career on a good foot, so you accepted it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[95]`
Mówca: **Narrator**
> "You became the legal assistant to one of the more experienced members of assembly.

You worked long and hard, going through hundreds of pages of legal documents late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[96]`
Mówca: **Narrator**
> "You became the economics assistant to one of the more experienced members of assembly.

You worked long and hard, investigating hundreds of pages of economic reports late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[97]`
Mówca: **Narrator**
> "You became the foreign policy assistant to one of the more experienced members of assembly.

You worked long and hard, reviewing dozens of foreign policy plans late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was the best opportunity to change the country for the better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "1933|September"]** — Mówca: **Narrator**
> "Tarquin Soll gave amnesty to the remaining factions of the civil war and chose de-escalation and appeasement. The institutions and symbols of the former kingdom were slowly replaced.

His government launched several new initiatives, such as a citizen-funded bills program to revitalize the economy, a social labor initiative to help rebuild and improve society, and a large dam project to solve the energy crisis.

The first multi-party elections in the history of Sordland were held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were climbing the ladder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "President Tarquin Soll was elected once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "1945|October|Time of Change"]** — Mówca: **Narrator**
> "President Soll barely secured a majority in the election against the opposition leader.

Over the next year, the Sordish people grew increasingly discontent with corruption and the worsening quality of life. Economic growth was slowing down.

Meanwhile, calls for a United Sordland Party congress became louder as a leadership struggle started to brew. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the internal opposition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Justice and Law in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[111]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Economy, Commerce and Energy in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[112]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Foreign Affairs and Trade in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "1946|August"]** — Mówca: **Narrator**
> "The congress was nothing short of impressive. The banners of the United Sordland Party were decorating every possible spot.

Thousands of influential political figures, lobbyists and benefactors gathered for this turning point. 

The voting for the party leadership began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You voted for Ewald Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "1946|September 1st"]** — Mówca: **Narrator**
> "The efforts bore fruit as the contentious leadership vote was won by Ewald Alphonso. 

During the congress, Tarquin Soll announced he would retire from politics at the end of his term, and appointed Alphonso as Vice President.

You knew the structure he had established was to stay. The country had become increasingly authoritarian. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You voted for Tarquin Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't care about who was in charge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "1949"]** — Mówca: **Narrator**
> "During the general elections, the main opposition leader was embroiled in a sex scandal with his secretary. He was replaced by the more popular figure Frens Ricter, but the damage had been done.

The new economic policies and the extensive privatization program proposed by Ewald Alphonso secured an election victory for the United Sordland Party.

Over the following years you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "1951|Summer|A New Sordland"]** — Mówca: **Narrator**
> "The Presidency of Alphonso saw many bold reforms in government and law and advancements in liberal democratic values.

However, due to infighting and disorganization, continental economic tensions, and fast-track privatization, it was followed by a severe economic recession.

The other parties announced their bids for the 1953 election, but the unfair election system hampered opposition efforts to campaign. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "1952|October|Rise of Rayne"]** — Mówca: **Narrator**
> "With Petr's help, your presence in the USP grew. The two of you worked long nights together; he flipped opponents to your side. 

You became the face of a new wing of the party. Step by step and with adequate planning, your wing took over the leadership as President Alphonso lost control of the country.

The moment to make a move had come. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[146]`
  - -> `[125]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised Alphonso to step down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "He listened to your advice. 

Alphonso conceded the leadership struggle and the party eventually voted you in because of your indisputable influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried that your reputation would be tarnished along with Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was your turn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was a gloomy year."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[35]`
  - -> `[32]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her diligence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland plunged into chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never forgot her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The chaos had to end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "The contender for party leadership was Ewald Alphonso, a reformist and talented business magnate with a growing follower base within the party.

President Soll noticed your attempts to secure votes for him and approached you with a lucrative deal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had a meeting with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "1946|October 15th|Uncertain Years"]** — Mówca: **Narrator**
> "A month later, your daughter was born. Monica named her Deana. She motivated you during a tumultuous period in the party.

As the VP and the leader of the USP, Ewald Alphonso began dismantling the old organizations and structures established by the USP such as the State Educators Corps and the Sordish State Corporation Bills.

The general elections were approaching. The United Sordland party was under new leadership. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best not to help him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...dedicated yourself to the party and its success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "1953|October|Election Campaign"]** — Mówca: **Narrator**
> "After visiting every city and town during the campaign, you made a speech on state television.

You promised to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...preserve national values."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...enact democratic reforms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Narrator**
> "“The people are tired of empty promises. We need fundamental change in our institutions and government!

A solid and transparent democracy awaits us. Brothers and sisters, a new constitution and a new age is upon us!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Conservative = true; 
BaseGame.Sollist += 1;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal = true; 
BaseGame.Democratic += 1;
BaseGame.Bludish_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] = true;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...bribed and extorted Alphonso's inner circle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The broadcast ended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "1953|November 5th"]** — Mówca: **Narrator**
> "On election day, millions went out to cast their votes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed Alphonso for the crisis on television."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You questioned what you were being taught."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a student council."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a human rights group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“End the chaos! We want stability!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Workers of the world, unite!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Bring down the nationalists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“One nation, one system, one people!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...you voted for the United Sordland Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The financial compensation was too great to pass up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Working for the ruling party was the easiest path to power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted with doubts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted right away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting the president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...watched from the sidelines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "You gave your support to Ewald Alphonso, a reformist and talented business magnate, who was the main contender for party leadership.

Meanwhile, in a desperate effort to secure votes before the congress, President Soll was meeting party members one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "The contender for party leadership was Ewald Alphonso, a reformist and talented business magnate with a growing follower base within the party.

Meanwhile, in a desperate effort to secure votes before the congress, President Soll was meeting party members one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But he didn't approach you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "He approached you too."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "1946|September 1st"]** — Mówca: **Narrator**
> "Unfortunately, Tarquin Soll lost the leadership vote to Ewald Alphonso by a small margin. 

During the congress, Soll announced he would retire from politics at the end of his term, and appointed Alphonso as Vice President.

The systems he had established were to stay much longer; his achievements wouldn't be forgotten. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were troubled by the departure of Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were happy that Soll was finally leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the party effort and campaigned for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried all that was necessary to climb up the ladder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best in order to make Sordland a better place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought that your party could not survive another crisis."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[176]`
Mówca: **Narrator**
> "The council was focused on increasing the student involvement in the campus along with partaking in the budget. 

Through active participation, you gained budget management and leadership skills.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[178]`
  - -> `[130]`

### Węzeł `[177]`
Mówca: **Narrator**
> "The group heavily protested against the deteriorating human rights situation in Sordland. 

You contributed in thorough discussions on how to protect and expand freedoms.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[178]`
  - -> `[130]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her beauty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[179]`
Mówca: **Narrator**
> "The clashes escalated into a full blown civil war. The horrors made you isolate yourself for a while.

Monica helped you cope and love grew between the two of you.

However, it was a difficult time for love."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was time to serve your national duty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You agreed in principle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were worried about the economic recession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was time to face the truth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Suddenly the soldiers charged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[185]`
Mówca: **Narrator**
> "After the patrol, Major Lancea arrived with anger and immediately relieved you of your command, calling you a disappointment.

One of your squad members had reported your actions.

After several months of scrubbing the floors as a punishment..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "Most of the inner circle abandoned him, even Minister of Development Gus Manger. President Alphonso started to reshuffle his cabinet, but it was too late.

Alphonso was removed from power by a no-confidence vote. The party eventually voted you in because of your influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "The media backlash prompted President Alphonso to reshuffle his cabinet, but most of his inner circle, even Minister of Development Gus Manger, abandoned him.

Alphonso was removed from power by a no-confidence vote. The party eventually voted you in because of your influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her intelligence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_PublicBlame = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_HumanRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Group_HumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_StudentCouncil = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Group_StudentCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_PoliticalDebate = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Group_PoliticalDebate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...your duties ended and you went back to civilian life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "1931|July|Holsord"]** — Mówca: **Narrator**
> "You and Monica decided to share your lives together. After receiving the blessing of her parents, a ceremony was held in Holsord.

During the same year, you worked hard to secure a high-paying job within the governing United Sordland Party. 

It was much more difficult to start your career on a good foot because of the "refugee incident", but you still managed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "During your absence, Petr Vectern found trustworthy contacts and strengthened your position in the party.

At the same time, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The cracks began to show."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stay away from any political organization."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
**[WYBÓR GRACZA: "1928|June 2nd"]** — Mówca: **Narrator**
> "The radio relayed that the communist general Rikard surrounded Luderin and his troops, demanding their surrender.

They refused and heavy fighting broke out across the country. 

You just couldn't believe it. The army was fighting amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland plunged into chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[205]`
Mówca: **Narrator**
> "“Great nation of Sordland! Due to our incompetent leadership, enemies both internal and external are influencing our glorious nation.

Today, more than ever, we need to unite under one flag and protect our values! Greci Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 3;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[207]`
**[WYBÓR GRACZA: "1938|June|Rising Career"]** — Mówca: **Narrator**
> "As the youngest MP, it was difficult to connect with the influential inner circle. You needed allies, so you brought on Petr Vectern as your right hand man.

The birth of your son, Franc, provided a brief moment of joy and relief.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[208]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The preparation of a comprehensive trade agreement with Agnolia was occupying most of your personal time.

But your significant contribution to the trade talks triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sacrificed work to spend time with your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sacrificed family time to improve your position in the party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The new five-year plan and the subsequent financial work put you under a lot of pressure.

But your significant contribution to the economic strategy triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[218]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The ongoing legal battle between the Justice Ministry and the Supreme Court put you under a lot of stress.

But your significant contribution to the legal case triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Family_Important"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "Just like your father once did, you prioritized work over family. Along with Petr Vectern, you accomplished great things for your party. 

At home, Monica and Franc felt your absence.

Meanwhile, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_1stCoup_Protested = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Protest_Girl_Crushed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "Along with Petr Vectern, you did great things to cement your position in the party. Meanwhile at home, Monica and Franc felt your absence.

At the same time, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active = true; BaseGame.Prologue_University_Political_Socialist = true; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;
Variable["BaseGame.Prologue_University_Political_Socialist"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active = true; BaseGame.Prologue_University_Political_Nationalist = true; BaseGame.Sollist += 1; BaseGame.Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;
Variable["BaseGame.Prologue_University_Political_Nationalist"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 2;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1;
BaseGame.Public_Opinion += 2;
BaseGame.Bludish_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_MinisterOffer_Accepted = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_MinisterOffer_Accepted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_MinisterOffer_Rejected = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_MinisterOffer_Rejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "1926"]** — Mówca: **Narrator**
> "After graduating, you passed the university exam with high marks.

Even though your family was poor, the public education system made it possible to go to university. You had the opportunity to choose between several studies.

You chose..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_CampaignedForAlphonso == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[247]`
**[WYBÓR GRACZA: "1951|Summer|A New Sordland"]** — Mówca: **Narrator**
> "The Presidency of Alphonso saw many bold reforms in government and law and advancements in liberal democratic values. He valued your support throughout.

However, due to infighting and disorganization, continental economic tensions, and fast-track privatization, it was followed by a severe economic recession.

The other parties announced their bids for the 1953 election, but the unfair election system hampered opposition efforts to campaign. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_university");)*
- **Efekt (`userScript`):** `PrologueImage("pe_university");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[150]`
  - -> `[80]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_coup");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[151]`
  - -> `[44]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_lachaven");)*
- **Efekt (`userScript`):** `PrologueImage("pe_lachaven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[151]`
  - -> `[44]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_deyr");)*
- **Efekt (`userScript`):** `PrologueImage("pe_deyr");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[151]`
  - -> `[44]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_protest");)*
- **Efekt (`userScript`):** `PrologueImage("pe_protest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[153]`
  - -> `[65]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_protest");)*
- **Efekt (`userScript`):** `PrologueImage("pe_protest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coup2");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coup2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_soll");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_soll");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[76]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_outpost");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_outpost");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_wedding");)*
- **Efekt (`userScript`):** `PrologueImage("pe_wedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[159]`
  - -> `[98]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meeting");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[161]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_baby");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_baby");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[213]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_innercircle");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[163]`
  - -> `[103]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_politicians");)*
- **Efekt (`userScript`):** `PrologueImage("pe_politicians");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meeting");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[118]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[115]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[170]`
  - -> `[121]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_baby");)*
- **Efekt (`userScript`):** `PrologueImage("pe_baby");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[138]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_flag");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_flag");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[173]`
  - -> `[139]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[182]`
  - -> `[127]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();
PrologueImage("pe_speech");)*
- **Efekt (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_speech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[141]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_vote");)*
- **Efekt (`userScript`):** `PrologueImage("pe_vote");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_lachaven");)*
- **Efekt (`userScript`):** `PrologueImage("pe_lachaven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_deyr");)*
- **Efekt (`userScript`):** `PrologueImage("pe_deyr");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("MainTheme");)*
- **Efekt (`userScript`):** `PlayMusic("MainTheme");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Prologue_Finish");)*
- **Efekt (`userScript`):** `UnlockAchievement("Prologue_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("In the Prologue", "", "");)*
- **Efekt (`userScript`):** `SetRichPresence("In the Prologue","","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DontPlayMapMusic();)*
- **Efekt (`userScript`):** `DontPlayMapMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[285]`
Mówca: **Narrator**
> "She mentioned to you that she was a volunteer for the Sordish League of Women, an organization campaigning for women's rights.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told her you wholeheartedly supported her cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...weren't particularly interested in women's rights, but asked her to dinner nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DontPlayMapAmbience();)*
- **Efekt (`userScript`):** `DontPlayMapAmbience();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[290]`
Mówca: **Narrator**
> "Months after the Republic was proclaimed, life around you changed. You watched friends and family face uncertainty, economic hardship, scattered unrest and resistance from those tied to the old order. 

In their struggle, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`

### Węzeł `[291]`
**[WYBÓR GRACZA: "…envied those who escaped it all, and wished for an easier path. [Easier Resources]"]** — Mówca: **Player**
> "…envied those who escaped it all, and wished for an easier path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "…saw both pain and perseverance, and sought balance between the two."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
**[WYBÓR GRACZA: "…felt the weight they carried and chose to shoulder even more. [Harder Resources]"]** — Mówca: **Player**
> "…felt the weight they carried and chose to shoulder even more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_EasyLife = true; 
BaseGame.Economy += 2;
BaseGame.GovernmentBudget += 2;
BaseGame.PersonalWealth += 1;
BaseGame.Public_Opinion += 3;
BaseGame.Bludish_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_EasyLife"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;
Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_NormalLife = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_NormalLife"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_HardLife = true; 
BaseGame.Economy -= 2;
BaseGame.GovernmentBudget -= 2;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_HardLife"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
