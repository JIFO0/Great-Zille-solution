# Sordland/Turn10/DINNER MONICA AND DEANA (BAD)

- **ID konwersacji:** `218`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/218_DINNER_MONICA_AND_DEANA_(BAD).md`
- **Liczba węzłów dialogowych:** 298
- **Liczba wyborów gracza:** 76

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Capitalist`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[49]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[287]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[288]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[289]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[294]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- Węzeł `[295]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- Węzeł `[296]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`

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
  - -> `[36]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[49]`

### Węzeł `[3]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[100]`

### Węzeł `[4]`
Mówca: **Deana**
> ""Then I guess good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I drained my glass and left the table. I had packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[8]`
Mówca: **Deana**
> ""I'll still call you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Narrator**
> "I put that thought out of my mind as I left. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What do you hear from your brother these days?""]** — Mówca: **Player**
> ""What do you hear from your brother these days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[15]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "The three of us gathered around the dining room table. Monica ladled out bowls full of beef stew -- not my favorite, but a comforting dish nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[42]`
  - -> `[40]`

### Węzeł `[17]`
Mówca: **Monica**
> ""Don't worry, we won't make it public until then. I just wanted Deana to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[18]`
Mówca: **Monica**
> ""Nobody's going anywhere. Except you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Kyrute. And you kids can visit whenever you want.""]** — Mówca: **Player**
> ""Kyrute. And you can visit whenever you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'd rather not tell you. For safety reasons.""]** — Mówca: **Player**
> ""I'd rather not tell you. For safety reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Deana**
> ""Almost forgot that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[14]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""It's the presidential complex. I'm the President, remember?""]** — Mówca: **Player**
> ""It's the presidential complex. I'm the President, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Your mother is right, Deana. We're getting divorced -- immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right, Deana. We're getting divorced -- immediately after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Fine. I will.""]** — Mówca: **Player**
> ""Fine. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[30]`
Mówca: **Deana**
> ""Um... All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[21]`

### Węzeł `[32]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Monica**
> ""Oh, sweetheart. It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Deana still looked slightly dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[35]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Maybe things really could get better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Tears appeared in Monica's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica and Deana looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[80]`
  - -> `[78]`

### Węzeł `[41]`
Mówca: **Monica**
> ""Please, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica and Deana slowly followed suit, looking puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[80]`
  - -> `[78]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Deana watched silently as I got up from the table. Finally, she spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[80]`
  - -> `[78]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Deana came back downstairs and made a beeline for the pencil case on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[47]`
Mówca: **Deana**
> ""Papa, where are you going to go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[48]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Monica**
> ""Then leave this house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[26]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Instead, I started thinking about how I would announce my decision not to seek re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: ""No. Not without my family.""]** — Mówca: **Player**
> ""No. Not without my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""All right. I will leave in a week. I have to make sure my tracks are covered first.""]** — Mówca: **Player**
> ""All right. I will leave in a week. I have to make sure my tracks are covered first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""All right. I'm leaving tomorrow.""]** — Mówca: **Player**
> ""All right. I'm leaving tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[61]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[62]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Monica**
> ""Go, Anton. I think it's better this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""I will. I'll see you later, Deana.""]** — Mówca: **Player**
> ""I will. I'll see you later, Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[73]`
Mówca: **Narrator**
> "She looked up. Her face was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[74]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard hesitant footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Instead, I started thinking about where I wanted to go for my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[76]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Monica**
> ""No, Anton. You've dug your own grave. You've got to deal with this yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[123]`
  - -> `[119]`

### Węzeł `[79]`
Mówca: **Monica**
> ""You're not even running anymore. Why should it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[123]`
  - -> `[119]`

### Węzeł `[81]`
Mówca: **Monica**
> ""If you're leaving the country, the election doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[123]`
  - -> `[119]`

### Węzeł `[83]`
Mówca: **Deana**
> ""I'll still call you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[84]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[87]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Deana! How is school?""]** — Mówca: **Player**
> ""Deana! How is school?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[88]`
Mówca: **Deana**
> ""Uh, I guess... good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She reluctantly accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""How's school?""]** — Mówca: **Player**
> ""How's school?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Deana mutely gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[103]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[105]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Monica, now is not the time. We've got to get out of here.""]** — Mówca: **Player**
> ""Monica, now is not the time. We've got to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Your mother is right. We're divorcing immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right. We're divorcing immediately after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[115]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[121]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I will. And I'm still quitting politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still quitting politics, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Fine. But I'm not retiring. I'm going to stay in the Maroon Palace forever, just to show you.""]** — Mówca: **Player**
> ""Fine. But I'm not retiring. I'm going to stay in the Maroon Palace forever, just to show you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[118]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[128]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I've done some unforgivable things. Especially to you, Monica.""]** — Mówca: **Player**
> ""I've done some unforgivable things. Especially to you, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[147]`

### Węzeł `[120]`
Mówca: **Deana**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[122]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[108]`
  - -> `[107]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I let my power get to my head. I became unrecognizeable to myself -- and to all of you.""]** — Mówca: **Player**
> ""I let my power get to my head. I became unrecognizable to myself -- and to you two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[147]`

### Węzeł `[124]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and daughter.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[147]`

### Węzeł `[127]`
Mówca: **Deana**
> ""Uh, I guess... I'll call you soon, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[129]`
Mówca: **Deana**
> ""Uh, I guess... I'll call you soon, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[130]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[212]`
  - -> `[213]`

### Węzeł `[131]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Narrator**
> "Monica scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[134]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[136]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Deana ignored my comment and gestured vaguely towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[142]`
Mówca: **Deana**
> ""Mama's in there. I'll be up in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Deana**
> ""I'll be in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[146]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""I hope I can redeem myself someday.""]** — Mówca: **Player**
> ""I hope I can redeem myself someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I will. And I'm still quitting politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still quitting politics, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[149]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs, thinking about the days when she idolized me. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I hesitantly stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[152]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Narrator**
> "Monica looked at me sadly. She slowly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[175]`

### Węzeł `[158]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[150]`

### Węzeł `[159]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[160]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[161]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[162]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Monica whirled around in surprise. Her eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Monica**
> ""The only person in danger is him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[172]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know we're all still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[6]`

### Węzeł `[173]`
Mówca: **Monica**
> ""No. Not if he's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[174]`
Mówca: **Monica**
> ""No, sweetie. Your father's imagining things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[178]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Deana, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Deana, don't listen to her. Everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I'm sorry. I'll go wait in the living room.""]** — Mówca: **Player**
> ""I'm sorry. I'll go wait in the living room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[184]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! Go wait in the living room. I'll tell you when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[179]`
  - -> `[180]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[187]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[188]`
Mówca: **Narrator**
> "I walked back out and sat on the living room sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "I awkwardly flipped through one of Monica's women's magazines. I felt like an intruder in my own home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[190]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[191]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Monica and Deana turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[193]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[194]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[195]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[196]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[197]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[198]`
**[WYBÓR GRACZA: ""I swear to you both, once I'm retired things will go back to the way they used to be.""]** — Mówca: **Player**
> ""I swear to you both, once I'm retired things will go back to the way they used to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""As a first step towards that, I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""As a first step towards that, I'm retiring from politics at the end of this term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I swear to you both, I'll learn from my mistakes as I strive to make Sordland a better place.""]** — Mówca: **Player**
> ""I swear to you both, I'll learn from my mistakes as I strive to make Sordland a better place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[202]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[210]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[211]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Deana, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Deana, don't listen to her. Everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[216]`
Mówca: **Narrator**
> "Deana scratched her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[217]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[52]`
  - -> `[65]`
  - -> `[297]`

### Węzeł `[218]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Monica and Deana looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Franc never took his studies so seriously.""]** — Mówca: **Player**
> ""Franc never took his studies so seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Deana frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Deana**
> ""Papa, is Franc going to die fighting the Rummies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
**[WYBÓR GRACZA: ""No, of course not.""]** — Mówca: **Player**
> ""No, of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[230]`
**[WYBÓR GRACZA: ""If he sacrifices himself for the sake of the country, that will be his decision.""]** — Mówca: **Player**
> ""If he sacrifices himself for the sake of the country, that will be his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[231]`
Mówca: **Deana**
> ""He does now. I think he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[235]`
Mówca: **Deana**
> ""He doesn't call home so much now that the troops are getting ready for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[246]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Deana**
> ""Papa, are we 'bourgeoisie pigs'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[260]`

### Węzeł `[248]`
Mówca: **Deana**
> ""Papa, are we a 'socialist hive mind'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[254]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[253]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in Arcasia, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in Arcasia, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Capitalist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Capitalist > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Capitalist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[259]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in United Contana, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in United Contana, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[261]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Deana**
> ""Papa, is it true how he got into Holsord State? Would you do that for me, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`
  - -> `[265]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""No, I've learned my lesson.""]** — Mówca: **Player**
> ""No, I've learned my lesson.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Only if you show more gratitude for it than he did.""]** — Mówca: **Player**
> ""Only if you show more gratitude for it than he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Just keep studying so we'll never have to find out.""]** — Mówca: **Player**
> ""Just keep studying so we'll never have to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[273]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[274]`
Mówca: **Deana**
> ""Not much. He doesn't call as often now that he's got a girlfriend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[275]`
Mówca: **Deana**
> ""I think he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Deana**
> ""Papa, is Sordland 'run by a bunch of weaklings'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
**[WYBÓR GRACZA: ""What? Of course not.""]** — Mówca: **Player**
> ""What? Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[278]`
**[WYBÓR GRACZA: ""It's complicated.""]** — Mówca: **Player**
> ""It's complicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Deana**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Monica appeared in the doorway. She smiled at Deana, then fixed me with an icy look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[281]`
Mówca: **Monica**
> ""It's an outcast, sweetie. But you and I don't need to worry about that. This is your father's problem, not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Deana**
> ""But then where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[283]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[25]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[285]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[293]`
Mówca: **Monica**
> ""You're not even running anymore. Why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[297]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
